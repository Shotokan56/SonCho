/*
  Copyright 2009 Smart Enterprise Solution Corp.
  Email: contact@ses.vn - Website: http://www.ses.vn
  KimNgan Project.
*/
using System;
using System.Data;
using System.Configuration;
using System.Data.SqlClient;
using System.Security.Cryptography;
using System.IO;
using System.Text;
/// <summary>
/// Summary description for BaseDAL
/// </summary>
namespace SonCho 
{
    public class BaseDAL
    {
        #region PrivateVariables
        private SqlConnection SqlConn;
        string passkey = "14092009";
        string salt = "cnnstring";
        #endregion

        #region Constructor
        public BaseDAL()
        {
            //
            // TODO: Add constructor logic here
            //
            if (SqlConn == null)
            {
                SqlConn = new SqlConnection();
                SqlConn.ConnectionString = ConfigurationManager.ConnectionStrings["SqlProvider"].ConnectionString;
            }

        }
        #endregion

        #region PrivateMethods

        private void OpenSqlConnection()
        {
            if (SqlConn.State != ConnectionState.Open)
            {
                SqlConn.Open();
            }
        }


        private void CloseSqlConnection()
        {
            if (SqlConn.State == ConnectionState.Open)
            {
               SqlConn.Close();
            }
        }

        #endregion

        #region PublicMethods
        public DataSet GetDataSet(SqlCommand SqlComm)
        {
            SqlDataAdapter SqlDataAdp;
            DataSet dsData;
            try
            {
                SqlComm.Connection = SqlConn;
                SqlDataAdp = new SqlDataAdapter(SqlComm);
                dsData = new DataSet();
                SqlDataAdp.Fill(dsData);
                return dsData;



            }
            catch (Exception ex)
            {
                throw ex;
            }
            finally
            {
                SqlDataAdp = null;
                dsData = null;
            }
        }

        public int ExecuteNoneQuery(SqlCommand SqlComm)
        {
            try
            {
                OpenSqlConnection();
                SqlComm.Connection = SqlConn;
                int i = SqlComm.ExecuteNonQuery();
                return i;

            }
            catch (Exception ex)
            {
                throw ex;
            }
            finally
            {
                CloseSqlConnection();
            }
        }

        public Object ExecuteScalar(SqlCommand SqlComm)
        {
            try
            {
                OpenSqlConnection();
                SqlComm.Connection = SqlConn;
                return SqlComm.ExecuteScalar();

            }
            catch (Exception ex)
            {
                throw ex;
            }
            finally
            {
                CloseSqlConnection();
            }
        }

        public string encryptDES(string source)
        {
            byte[] plainBytes = Encoding.ASCII.GetBytes(source);
            Rfc2898DeriveBytes rfc = new Rfc2898DeriveBytes(passkey, Encoding.ASCII.GetBytes(salt));
            SymmetricAlgorithm Alg = new DESCryptoServiceProvider();
            Alg.Key = rfc.GetBytes(Alg.KeySize / 8);
            Alg.IV = rfc.GetBytes(Alg.BlockSize / 8);
            MemoryStream strCiphered = new MemoryStream();//To Store Encrypted Data

            CryptoStream strCrypto = new CryptoStream(strCiphered, Alg.CreateEncryptor(), CryptoStreamMode.Write);

            strCrypto.Write(plainBytes, 0, plainBytes.Length);
            strCrypto.Close();
            string rt = Convert.ToBase64String(strCiphered.ToArray());
            strCiphered.Close();
            return rt;
        }
        public string decryptDES(string source)
        {

            byte[] cipheredBytes = Convert.FromBase64String(source);

            //Rfc2898DeriveBytes: Used to Generate Strong Keys
            Rfc2898DeriveBytes rfc = new Rfc2898DeriveBytes(passkey, Encoding.ASCII.GetBytes(salt));//Non-English Alfhabets Will not Work on ASCII Encoding

            SymmetricAlgorithm Alg = new DESCryptoServiceProvider();

            Alg.Key = rfc.GetBytes(Alg.KeySize / 8);
            Alg.IV = rfc.GetBytes(Alg.BlockSize / 8);

            MemoryStream strDeciphered = new MemoryStream();//To Store Decrypted Data

            CryptoStream strCrypto = new CryptoStream(strDeciphered,
                Alg.CreateDecryptor(), CryptoStreamMode.Write);

            strCrypto.Write(cipheredBytes, 0, cipheredBytes.Length);
            strCrypto.Close();

            string rt = Encoding.ASCII.GetString(strDeciphered.ToArray());
            strDeciphered.Close();
            return rt;

        }

        #endregion
    }
}

