/*
  Copyright 2009 Smart Enterprise Solution Corp.
  Email: contact@ses.vn - Website: http://www.ses.vn
  KimNgan Project.
*/
using System;
using System.Collections;

namespace SonCho

{
   [Serializable ]
   public class SanPhamDO
    {

        /// <summary>
        /// Summary description for SanPhamDO
        /// </summary>
		
		#region Public Constants (Fields name)
					public const string ID_FIELD ="ID";
		public const string TENSANPHAM_FIELD ="TenSanPham";
		public const string MASANPHAM_FIELD ="MaSanPham";
		public const string MAVACH_FIELD ="MaVach";
		public const string GIA_FIELD ="Gia";
		public const string GIAKM_FIELD ="GiaKM";
		public const string SIZE_FIELD ="Size";
		public const string MAU_FIELD ="Mau";
		public const string CHAT_FIELD ="Chat";
		public const string GHICHU_FIELD ="GhiChu";
		public const string CHON_FIELD ="Chon";
        public const string FOOTER_FIELD = "footer";
		
		#endregion
		
		#region Private Variables
					private Int32 _ID;
		private String _TenSanPham;
		private String _MaSanPham;
		private String _MaVach;
		private Decimal _Gia;
		private Decimal _GiaKM;
		private String _Size;
		private String _Mau;
		private String _Chat;
		private String _GhiChu;
		private Boolean _Chon;
        private String _footer;
		

		#endregion

		#region Public Properties
					public Int32 ID
		{
			get
			{
				return _ID;
			}
			set
			{
				_ID = value;
			}
		}
		public String TenSanPham
		{
			get
			{
				return _TenSanPham;
			}
			set
			{
				_TenSanPham = value;
			}
		}
		public String MaSanPham
		{
			get
			{
				return _MaSanPham;
			}
			set
			{
				_MaSanPham = value;
			}
		}
		public String MaVach
		{
			get
			{
				return _MaVach;
			}
			set
			{
				_MaVach = value;
			}
		}
		public Decimal Gia
		{
			get
			{
				return _Gia;
			}
			set
			{
				_Gia = value;
			}
		}
		public Decimal GiaKM
		{
			get
			{
				return _GiaKM;
			}
			set
			{
				_GiaKM = value;
			}
		}
		public String Size
		{
			get
			{
				return _Size;
			}
			set
			{
				_Size = value;
			}
		}
		public String Mau
		{
			get
			{
				return _Mau;
			}
			set
			{
				_Mau = value;
			}
		}
		public String Chat
		{
			get
			{
				return _Chat;
			}
			set
			{
				_Chat = value;
			}
		}
		public String GhiChu
		{
			get
			{
				return _GhiChu;
			}
			set
			{
				_GhiChu = value;
			}
		}
		public Boolean Chon
		{
			get
			{
				return _Chon;
			}
			set
			{
				_Chon = value;
			}
		}

        public String footer
        {
            get
            {
                return _footer;
            }
            set
            {
                _footer = value;
            }
        }
		

        #endregion

	}
}
