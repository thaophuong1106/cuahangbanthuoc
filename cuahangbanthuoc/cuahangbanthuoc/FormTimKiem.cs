using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using BLL;
using DAT;
using DOT;

namespace cuahangbanthuoc
{
    public partial class FormTimKiem : UserControl
    {
        public FormTimKiem()
        {
            InitializeComponent();
        }

        private void FormTimKiem_Load(object sender, EventArgs e)
        {
    
        }

        private void btnTimKiem_Click(object sender, EventArgs e)
        {
            HangHoa_bll hh_bll = new HangHoa_bll();
            HangHoa hh = new HangHoa();
            NhaCungCap ncc = new NhaCungCap();
            hh.Mahang = txtMahang.Text;
            hh.Tenhang = txtTenhang.Text;
            hh.Size = cmbSize.Text;
            ncc.Tenncc = txtNcc.Text;
           
            dgvTimKiem.DataSource = hh_bll.TimKiem(hh,ncc);
            FormTimKiem_Load(sender,e);
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void txtTenhang_TextChanged(object sender, EventArgs e)
        {

        }

        private void dgvTimKiem_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
