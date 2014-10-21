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
    public partial class SoLuong : DevExpress.XtraEditors.XtraForm
    {
        public SoLuong()
        {
            InitializeComponent();
        }
        public int soluong = 0;
        private void simpleButton1_Click(object sender, EventArgs e)
        {
            soluong = Int32.Parse(textEdit1.Text);
            this.Dispose();
        }
    }
}