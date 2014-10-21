using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using DevExpress.XtraEditors;


namespace SonCho
{
    public partial class frmHang : DevExpress.XtraEditors.XtraForm
    {

        public frmHang()
        {
            InitializeComponent();
        }
        SanPhamDO obj = new SanPhamDO();

        private void btnOK_Click(object sender, EventArgs e)
        {
            int dem = 0;

            for (int i = 0; i < gridView1.RowCount; i++)
            {
                if (gridView1.GetRowCellValue(i, Chon) == null)
                {
                    continue;
                }
                else
                {
                    if (bool.Parse(gridView1.GetRowCellValue(i, Chon).ToString()) == true)
                    {
                        if (gridView1.GetRowCellValue(i, ID).ToString() == "")
                        {
                            // thêm mới
                            Setobj(i);
                            new SanPhamBL().Insert(obj);
                            dem++;
                        }
                        else
                        {
                            Setobj(i);
                            obj.ID = Int32.Parse(gridView1.GetRowCellValue(i, ID).ToString());
                            new SanPhamBL().Update(obj);
                            dem++;
                            // update
                        }
                    }
                    {

                    }
                }
            }
            if (dem > 0)
            {
                XtraMessageBox.Show(" Lưu Thành Công " + dem + " san pham! ");
                dem = 0;
            }
            else
            {
                XtraMessageBox.Show("Không Sp nào được lưu , Phải tích chọn tương ứng mỗi sản phẩm để lưu ");
                dem = 0;
            }
            LoadData();
        }

        private void Setobj(int i)
        {
            obj.TenSanPham = gridView1.GetRowCellValue(i, TenSanPham).ToString();
            obj.MaSanPham = gridView1.GetRowCellValue(i, MaSanPham).ToString();
            obj.MaVach = LayMaVach(gridView1.GetRowCellValue(i, MaVach).ToString());
            if (obj.MaVach == "Error")
            {
                MessageBox.Show("Error");
                return;
            }
            if (gridView1.GetRowCellValue(i, Gia).ToString() != "")
            {
                obj.Gia = decimal.Parse(gridView1.GetRowCellValue(i, Gia).ToString());
            }
            if (gridView1.GetRowCellValue(i, GiaKM).ToString() != "")
            {
                obj.GiaKM = decimal.Parse(gridView1.GetRowCellValue(i, GiaKM).ToString());
            }
            obj.Mau = gridView1.GetRowCellValue(i, Mau).ToString();
            obj.Size = gridView1.GetRowCellValue(i, Size).ToString();
            obj.GhiChu = gridView1.GetRowCellValue(i, GhiChu).ToString();
            obj.Chat = gridView1.GetRowCellValue(i, Chat).ToString();
            obj.footer = gridView1.GetRowCellValue(i, footer).ToString();
        }

        private string LayMaVach(string MaCu)
        {
            string MaMoi="Error";
            try
            {
               MaMoi = "8936059" + MaCu.Substring(MaCu.Length - 5);
                
            }
            catch (Exception e)
            {
                MessageBox.Show(e.ToString());
            }
            return MaMoi;
        }

        private void frmHang_Load(object sender, EventArgs e)
        {
            LoadData();
        }

        private void LoadData()
        {
            gridControl1.DataSource = new SanPhamBL().SelectAll();
        }

        private void btnXoa_Click(object sender, EventArgs e)
        {
            for (int i = 0; i < gridView1.RowCount; i++)
            {
                if (gridView1.GetRowCellValue(i, Chon) == null)
                {
                    continue;
                }
                else
                {   // kt chọn null
                    if (bool.Parse(gridView1.GetRowCellValue(i, Chon).ToString()) == true)
                    {   // kt ID null
                        if (gridView1.GetRowCellValue(i, ID).ToString() != "")
                        {
                            obj.ID = Int32.Parse(gridView1.GetRowCellValue(i, ID).ToString());
                            new SanPhamBL().Delete(obj);
                            // Delete
                        }

                    }

                    {

                    }
                }
            }
            XtraMessageBox.Show(" Xóa Thành Công!");
            LoadData();
        }

        private void btnInMaVach_Click(object sender, EventArgs e)
        {
            try
            {
                List<Int32> lstID = new List<Int32>();
                for (int i = 0; i < gridView1.RowCount; i++)
                {
                    if (gridView1.GetRowCellValue(i, Chon) == null)
                    {
                        continue;
                    }
                    else
                    {   // kt chọn null
                        if (bool.Parse(gridView1.GetRowCellValue(i, Chon).ToString()) == true)
                        {   // add mã vạch vào đây
                            lstID.Add(Int32.Parse(gridView1.GetRowCellValue(i, ID).ToString()));
                        }


                    }
                }
                if (lstID.Count == 0)
                {
                    MessageBox.Show("Chưa chọn sản phẩm nào");
                }
                else
                {
                    report.XtraForm1 buoi = new SonCho.report.XtraForm1();
                    buoi.layID(lstID);
                    buoi.ShowDialog();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void btnChonHet_Click(object sender, EventArgs e)
        {
            for (int i = 0; i < gridView1.RowCount; i++)
            {
                gridView1.SetRowCellValue(i, Chon, true);
            }
        }

        private void btnBoChon_Click(object sender, EventArgs e)
        {
            for (int i = 0; i < gridView1.RowCount; i++)
            {
                gridView1.SetRowCellValue(i, Chon, false);
            }
        }

        private void gridView1_CustomColumnDisplayText(object sender, DevExpress.XtraGrid.Views.Base.CustomColumnDisplayTextEventArgs e)
        {

            try
            {
                if (e.Column.Name == MaVach.Name)
                {
                    if (e.Value != null)
                    {
                        String Mavach = e.Value.ToString();
                        Int64 A = 0;
                        Int64 B = 0;
                        Int64 X = 0;
                        // lấy số A = tổng các số vị trí lẻ
                        A = Int32.Parse(Mavach.Substring(0, 1)) + Int32.Parse(Mavach.Substring(2, 1)) + Int32.Parse(Mavach.Substring(4, 1)) + Int32.Parse(Mavach.Substring(6, 1)) + Int32.Parse(Mavach.Substring(8, 1)) + Int32.Parse(Mavach.Substring(10, 1));
                        B = 3 * (Int32.Parse(Mavach.Substring(1, 1)) + Int32.Parse(Mavach.Substring(3, 1)) + Int32.Parse(Mavach.Substring(5, 1)) + Int32.Parse(Mavach.Substring(7, 1)) + Int32.Parse(Mavach.Substring(9, 1)) + Int32.Parse(Mavach.Substring(11, 1)));
                        X = (A + B) % 10;

                        if (X == 0)
                        {
                            Mavach = Mavach + "0";
                        }
                        else
                        {
                            Mavach = Mavach + (10 - X).ToString();
                        }
                        e.DisplayText = Mavach;
                    }
                }
            }
            catch (Exception)
            {
            }




        }

    }

}
