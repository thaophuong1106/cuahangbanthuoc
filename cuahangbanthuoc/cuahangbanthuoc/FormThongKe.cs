using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace cuahangbanthuoc
{
    public partial class FormThongKe : UserControl
    {
        public FormThongKe()
        {
            InitializeComponent();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            this.QUANLYCUAHANG11DataSet.EnforceConstraints = false;
            try
            {  this.TimKiemTheoNgayTableAdapter.Fill(this.QUANLYCUAHANG11DataSet.TimKiemTheoNgay,dateTimePicker1.Value, dateTimePicker2.Value);
            }
            catch(Exception ex)
            { MessageBox.Show("lỗi:"+ex.ToString()+""); }
            this.reportViewer1.RefreshReport();
        }

        private void FormThongKe_Load(object sender, EventArgs e)
        {
           
        }

        private void reportViewer1_Load(object sender, EventArgs e)
        {

        }
    }
}
