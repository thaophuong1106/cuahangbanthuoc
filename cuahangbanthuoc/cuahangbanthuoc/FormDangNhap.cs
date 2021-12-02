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
using DOT;
using DAT;

namespace cuahangbanthuoc
{
    public partial class FormDangNhap : UserControl
    {
        public FormDangNhap()
        {
            InitializeComponent();
        }

        private void btnDangKi_Click(object sender, EventArgs e)
        {
            //formDangKi.Show();
            //formDangKi.BringToFront();
        }

        private void FormDangNhap_Load(object sender, EventArgs e)
        {
           // formDangKi.Hide();
           

        }

        private void btnDangNhap_Click(object sender, EventArgs e)
        {
            try
            {
                Ketnoi kn = new Ketnoi();
                DataTable dt = kn.SetTable("select * from TaiKhoan where Username='" + txtUsername.Text +
                    "' And Password='" + Int32.Parse(txtPassword.Text) + "' And Trangthai=N'Hoạt động'");
                if (dt.Rows.Count == 1)
                {
                    MessageBox.Show("Đăng nhập thành công !!!");
                }
                else
                    MessageBox.Show("Sai tài khoản hoặc mật khẩu. Nhập lại", "thông báo");
            }
            catch
            { MessageBox.Show("Lỗi exception không kết nối được với database!!!"); }
        }

        private void formDangKi_Load(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }
    }
}