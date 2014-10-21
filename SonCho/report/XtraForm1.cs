using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using DevExpress.XtraEditors;
using DevExpress.XtraReports.UI;

namespace SonCho.report
{
    public partial class XtraForm1 : DevExpress.XtraEditors.XtraForm
    {
        public XtraForm1()
        {
            InitializeComponent();
        }
        List<Int32> lstID = new List<int>();
        public void layID(List<Int32> ID)
        {
            lstID = ID;
        }
        private void XtraForm1_Load(object sender, EventArgs e)
        {
            XtraReport1 rpt = new XtraReport1();
            SoLuong sl = new SoLuong();
            sl.ShowDialog();
            int soluong = sl.soluong;
            if (soluong < 0) return;
            for (int i = 0; i < lstID.Count; i++)
            {
                DataRow dr = tblSanPham.NewRow();
                dr = new SanPhamBL().Select2(lstID[i]);

                for (int ii = 0; ii < soluong * 4; ii++)
                {
                    tblSanPham.ImportRow(dr);
                }
            }
            LoadReport(rpt, tblSanPham);

        }
        public void LoadReport(DevExpress.XtraReports.UI.XtraReport rptFile, DataTable dataSource)
        {
            rptFile.DataSource = dataSource.Copy();
            printControl1.PrintingSystem = rptFile.PrintingSystem;
          
            rptFile.CreateDocument(true);
                   
        }
    }
}