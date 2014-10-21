/*
  Copyright 2009 Smart Enterprise Solution Corp.
  Email: contact@ses.vn - Website: http://www.ses.vn
  KimNgan Project.
*/
using System;
using System.Data;
using System.Configuration;
using System.Collections;

using SonCho;

/// <summary>
/// Summary description for SanPhamBL
/// </summary>
namespace SonCho 
{
    public class SanPhamBL 
    {
    	#region Private Variables
        SanPhamDAL objSanPhamDAL; 
		#endregion
		
        #region Public Constructors
        public SanPhamBL()
        {
            //
            // TODO: Add constructor logic here
            //
            objSanPhamDAL=new SanPhamDAL();
        }
        #endregion       

        #region Public Methods
        public int Insert(SanPhamDO objSanPhamDO)
        {
            return objSanPhamDAL.Insert(objSanPhamDO);
        }

        public int Update(SanPhamDO objSanPhamDO)
        {
             return objSanPhamDAL.Update(objSanPhamDO);

        }

        public int Delete(SanPhamDO objSanPhamDO)
        {
             return objSanPhamDAL.Delete(objSanPhamDO);

        }

         public int DeleteAll()
        {
             return objSanPhamDAL.DeleteAll();
        }

        public SanPhamDO Select(SanPhamDO objSanPhamDO)
        {
            return objSanPhamDAL.Select(objSanPhamDO);
        }

        public ArrayList SelectAll1( )
        {
         return objSanPhamDAL.SelectAll1();
        }
        
        public DataTable SelectAll( )
        {
         return objSanPhamDAL.SelectAll();
        }

        public DataRow Select2(int ID)
        {
            return objSanPhamDAL.Select2(ID);
        }
     
#endregion          
    
    }

}
