/*
  Copyright 2009 Smart Enterprise Solution Corp.
  Email: contact@ses.vn - Website: http://www.ses.vn
  KimNgan Project.
*/
using System;
using System.Data;
using System.Configuration;
using System.Collections;
using System.Data.SqlClient;
using SonCho;

/// <summary>
/// Summary description for SanPhamDAL
/// </summary>
namespace SonCho
{

    public class SanPhamDAL : BaseDAL
    {
        #region Private Variables

        #endregion

        #region Public Constructors
        public SanPhamDAL()
        {
            //
            // TODO: Add constructor logic here
            //

        }
        #endregion



        #region Public Methods
        public int Insert(SanPhamDO objSanPhamDO)
        {

            SqlCommand Sqlcomm = new SqlCommand();
            Sqlcomm.CommandType = CommandType.StoredProcedure;
            Sqlcomm.CommandText = "spSanPham_Insert";
            SqlParameter Sqlparam;

            Sqlparam = new SqlParameter("@TenSanPham", SqlDbType.NVarChar);
            Sqlparam.Value = objSanPhamDO.TenSanPham;
            Sqlcomm.Parameters.Add(Sqlparam);

            Sqlparam = new SqlParameter("@MaSanPham", SqlDbType.NVarChar);
            Sqlparam.Value = objSanPhamDO.MaSanPham;
            Sqlcomm.Parameters.Add(Sqlparam);

            Sqlparam = new SqlParameter("@MaVach", SqlDbType.NVarChar);
            Sqlparam.Value = objSanPhamDO.MaVach;
            Sqlcomm.Parameters.Add(Sqlparam);

            Sqlparam = new SqlParameter("@Gia", SqlDbType.Float);
            Sqlparam.Value = objSanPhamDO.Gia;
            Sqlcomm.Parameters.Add(Sqlparam);

            Sqlparam = new SqlParameter("@GiaKM", SqlDbType.Float);
            Sqlparam.Value = objSanPhamDO.GiaKM;
            Sqlcomm.Parameters.Add(Sqlparam);

            Sqlparam = new SqlParameter("@Size", SqlDbType.NVarChar);
            Sqlparam.Value = objSanPhamDO.Size;
            Sqlcomm.Parameters.Add(Sqlparam);

            Sqlparam = new SqlParameter("@Mau", SqlDbType.NVarChar);
            Sqlparam.Value = objSanPhamDO.Mau;
            Sqlcomm.Parameters.Add(Sqlparam);

            Sqlparam = new SqlParameter("@Chat", SqlDbType.NVarChar);
            Sqlparam.Value = objSanPhamDO.Chat;
            Sqlcomm.Parameters.Add(Sqlparam);

            Sqlparam = new SqlParameter("@GhiChu", SqlDbType.NVarChar);
            Sqlparam.Value = objSanPhamDO.GhiChu;
            Sqlcomm.Parameters.Add(Sqlparam);

            Sqlparam = new SqlParameter("@Chon", SqlDbType.Bit);
            Sqlparam.Value = objSanPhamDO.Chon;
            Sqlcomm.Parameters.Add(Sqlparam);

            Sqlparam = new SqlParameter("@footer", SqlDbType.NVarChar);
            Sqlparam.Value = objSanPhamDO.footer;
            Sqlcomm.Parameters.Add(Sqlparam);



            Sqlparam = new SqlParameter("@ID", SqlDbType.Int);
            Sqlparam.Direction = ParameterDirection.ReturnValue;
            Sqlcomm.Parameters.Add(Sqlparam);


            int result = base.ExecuteNoneQuery(Sqlcomm);

            if (!Convert.IsDBNull(Sqlcomm.Parameters["@ID"]))
                result = Convert.ToInt32(Sqlcomm.Parameters["@ID"].Value);

            return result;
        }

        public int Update(SanPhamDO objSanPhamDO)
        {

            SqlCommand Sqlcomm = new SqlCommand();
            Sqlcomm.CommandType = CommandType.StoredProcedure;
            Sqlcomm.CommandText = "spSanPham_UpdateByPK";
            SqlParameter Sqlparam;

            Sqlparam = new SqlParameter("@ID", SqlDbType.Int);
            Sqlparam.Value = objSanPhamDO.ID;
            Sqlcomm.Parameters.Add(Sqlparam);

            Sqlparam = new SqlParameter("@TenSanPham", SqlDbType.NVarChar);
            Sqlparam.Value = objSanPhamDO.TenSanPham;
            Sqlcomm.Parameters.Add(Sqlparam);

            Sqlparam = new SqlParameter("@MaSanPham", SqlDbType.NVarChar);
            Sqlparam.Value = objSanPhamDO.MaSanPham;
            Sqlcomm.Parameters.Add(Sqlparam);

            Sqlparam = new SqlParameter("@MaVach", SqlDbType.NVarChar);
            Sqlparam.Value = objSanPhamDO.MaVach;
            Sqlcomm.Parameters.Add(Sqlparam);

            Sqlparam = new SqlParameter("@Gia", SqlDbType.Float);
            Sqlparam.Value = objSanPhamDO.Gia;
            Sqlcomm.Parameters.Add(Sqlparam);

            Sqlparam = new SqlParameter("@GiaKM", SqlDbType.Float);
            Sqlparam.Value = objSanPhamDO.GiaKM;
            Sqlcomm.Parameters.Add(Sqlparam);

            Sqlparam = new SqlParameter("@Size", SqlDbType.NVarChar);
            Sqlparam.Value = objSanPhamDO.Size;
            Sqlcomm.Parameters.Add(Sqlparam);

            Sqlparam = new SqlParameter("@Mau", SqlDbType.NVarChar);
            Sqlparam.Value = objSanPhamDO.Mau;
            Sqlcomm.Parameters.Add(Sqlparam);

            Sqlparam = new SqlParameter("@Chat", SqlDbType.NVarChar);
            Sqlparam.Value = objSanPhamDO.Chat;
            Sqlcomm.Parameters.Add(Sqlparam);

            Sqlparam = new SqlParameter("@GhiChu", SqlDbType.NVarChar);
            Sqlparam.Value = objSanPhamDO.GhiChu;
            Sqlcomm.Parameters.Add(Sqlparam);

            Sqlparam = new SqlParameter("@Chon", SqlDbType.Bit);
            Sqlparam.Value = objSanPhamDO.Chon;
            Sqlcomm.Parameters.Add(Sqlparam);

            Sqlparam = new SqlParameter("@footer", SqlDbType.NVarChar);
            Sqlparam.Value = objSanPhamDO.footer;
            Sqlcomm.Parameters.Add(Sqlparam);



            Sqlparam = new SqlParameter("@ErrorCode", SqlDbType.Int);
            Sqlparam.Direction = ParameterDirection.ReturnValue;
            Sqlcomm.Parameters.Add(Sqlparam);

            int result = base.ExecuteNoneQuery(Sqlcomm);

            if (!Convert.IsDBNull(Sqlcomm.Parameters["@ErrorCode"]))
                result = Convert.ToInt32(Sqlcomm.Parameters["@ErrorCode"].Value);

            return result;


        }

        public int Delete(SanPhamDO objSanPhamDO)
        {

            SqlCommand Sqlcomm = new SqlCommand();
            Sqlcomm.CommandType = CommandType.StoredProcedure;
            Sqlcomm.CommandText = "spSanPham_DeleteByPK";
            SqlParameter Sqlparam;


            Sqlparam = new SqlParameter("@ID", SqlDbType.Int);
            Sqlparam.Value = objSanPhamDO.ID;
            Sqlcomm.Parameters.Add(Sqlparam);



            int result = base.ExecuteNoneQuery(Sqlcomm);
            return result;
        }

        public int DeleteAll()
        {

            SqlCommand Sqlcomm = new SqlCommand();
            Sqlcomm.CommandType = CommandType.StoredProcedure;
            Sqlcomm.CommandText = "spSanPham_DeleteAll";

            int result = base.ExecuteNoneQuery(Sqlcomm);
            return result;
        }

        public SanPhamDO Select(SanPhamDO objSanPhamDO)
        {

            SqlCommand Sqlcomm = new SqlCommand();
            Sqlcomm.CommandType = CommandType.StoredProcedure;
            Sqlcomm.CommandText = "spSanPham_GetByPK";
            SqlParameter Sqlparam;


            Sqlparam = new SqlParameter("@ID", SqlDbType.Int);
            Sqlparam.Value = objSanPhamDO.ID;
            Sqlcomm.Parameters.Add(Sqlparam);



            DataSet ds = base.GetDataSet(Sqlcomm);
            DataRow dr = null;
            if (ds != null && ds.Tables.Count > 0 && ds.Tables[0].Rows.Count > 0)
            {
                dr = ds.Tables[0].Rows[0];
                if (!Convert.IsDBNull(dr["ID"]))
                    objSanPhamDO.ID = Convert.ToInt32(dr["ID"]);
                if (!Convert.IsDBNull(dr["TenSanPham"]))
                    objSanPhamDO.TenSanPham = Convert.ToString(dr["TenSanPham"]);
                if (!Convert.IsDBNull(dr["MaSanPham"]))
                    objSanPhamDO.MaSanPham = Convert.ToString(dr["MaSanPham"]);
                if (!Convert.IsDBNull(dr["MaVach"]))
                    objSanPhamDO.MaVach = Convert.ToString(dr["MaVach"]);
                if (!Convert.IsDBNull(dr["Gia"]))
                    objSanPhamDO.Gia = Convert.ToDecimal(dr["Gia"]);
                if (!Convert.IsDBNull(dr["GiaKM"]))
                    objSanPhamDO.GiaKM = Convert.ToDecimal(dr["GiaKM"]);
                if (!Convert.IsDBNull(dr["Size"]))
                    objSanPhamDO.Size = Convert.ToString(dr["Size"]);
                if (!Convert.IsDBNull(dr["Mau"]))
                    objSanPhamDO.Mau = Convert.ToString(dr["Mau"]);
                if (!Convert.IsDBNull(dr["Chat"]))
                    objSanPhamDO.Chat = Convert.ToString(dr["Chat"]);
                if (!Convert.IsDBNull(dr["GhiChu"]))
                    objSanPhamDO.GhiChu = Convert.ToString(dr["GhiChu"]);
                if (!Convert.IsDBNull(dr["Chon"]))
                    objSanPhamDO.Chon = Convert.ToBoolean(dr["Chon"]);
                if (!Convert.IsDBNull(dr["footer"]))
                    objSanPhamDO.footer = Convert.ToString(dr["footer"]);

            }
            return objSanPhamDO;
        }

        public ArrayList SelectAll1()
        {

            SqlCommand Sqlcomm = new SqlCommand();
            Sqlcomm.CommandType = CommandType.StoredProcedure;
            Sqlcomm.CommandText = "spSanPham_GetAll";

            DataSet ds = base.GetDataSet(Sqlcomm);
            DataTable dt = null;
            ArrayList arrSanPhamDO = new ArrayList();
            if (ds != null && ds.Tables.Count > 0)
            {
                dt = ds.Tables[0];
                foreach (DataRow dr in dt.Rows)
                {
                    SanPhamDO objSanPhamDO = new SanPhamDO();
                    if (!Convert.IsDBNull(dr["ID"]))
                        objSanPhamDO.ID = Convert.ToInt32(dr["ID"]);
                    if (!Convert.IsDBNull(dr["TenSanPham"]))
                        objSanPhamDO.TenSanPham = Convert.ToString(dr["TenSanPham"]);
                    if (!Convert.IsDBNull(dr["MaSanPham"]))
                        objSanPhamDO.MaSanPham = Convert.ToString(dr["MaSanPham"]);
                    if (!Convert.IsDBNull(dr["MaVach"]))
                        objSanPhamDO.MaVach = Convert.ToString(dr["MaVach"]);
                    if (!Convert.IsDBNull(dr["Gia"]))
                        objSanPhamDO.Gia = Convert.ToDecimal(dr["Gia"]);
                    if (!Convert.IsDBNull(dr["GiaKM"]))
                        objSanPhamDO.GiaKM = Convert.ToDecimal(dr["GiaKM"]);
                    if (!Convert.IsDBNull(dr["Size"]))
                        objSanPhamDO.Size = Convert.ToString(dr["Size"]);
                    if (!Convert.IsDBNull(dr["Mau"]))
                        objSanPhamDO.Mau = Convert.ToString(dr["Mau"]);
                    if (!Convert.IsDBNull(dr["Chat"]))
                        objSanPhamDO.Chat = Convert.ToString(dr["Chat"]);
                    if (!Convert.IsDBNull(dr["GhiChu"]))
                        objSanPhamDO.GhiChu = Convert.ToString(dr["GhiChu"]);
                    if (!Convert.IsDBNull(dr["Chon"]))
                        objSanPhamDO.Chon = Convert.ToBoolean(dr["Chon"]);
                    if (!Convert.IsDBNull(dr["footer"]))
                        objSanPhamDO.footer = Convert.ToString(dr["footer"]);

                }
            }
            return arrSanPhamDO;
        }

        public DataTable SelectAll()
        {

            SqlCommand Sqlcomm = new SqlCommand();
            Sqlcomm.CommandType = CommandType.StoredProcedure;
            Sqlcomm.CommandText = "spSanPham_GetAll";

            DataSet ds = base.GetDataSet(Sqlcomm);
            DataTable dt = null;

            if (ds != null && ds.Tables.Count > 0)
            {
                dt = ds.Tables[0];

            }
            return dt;
        }
        public DataRow Select2(int ID)
        {

            SqlCommand Sqlcomm = new SqlCommand();
            Sqlcomm.CommandType = CommandType.StoredProcedure;
            Sqlcomm.CommandText = "spSanPham_GetByPK";
            SqlParameter Sqlparam;


            Sqlparam = new SqlParameter("@ID", SqlDbType.Int);
            Sqlparam.Value = ID;
            Sqlcomm.Parameters.Add(Sqlparam);


            DataSet ds = base.GetDataSet(Sqlcomm);
            DataRow dr = null;
            if (ds != null && ds.Tables.Count > 0 && ds.Tables[0].Rows.Count > 0)
            {
                dr = ds.Tables[0].Rows[0];
            }
            return dr;
        }

        #endregion

    }

}
