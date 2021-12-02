using DAT;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace cuahangbanthuoc
{
    public partial class DangNhap : Form
    {
        public DangNhap()
        {
            InitializeComponent();
        }

        private void DangNhap_Load(object sender, EventArgs e)
        {
            formDangKi1.Hide();
        }
        
        private void ShowForm2()
        {
            
            Form1 f = new Form1();
            f.ShowDialog();
        }
        private void ShowForm1()
        {

            Form1 f = new Form1();
            f.user = txtUsername.Text;
            f.ShowDialog();
        }

        private void btnDangNhap_Click(object sender, EventArgs e)
        {
            try
            {
                Ketnoi kn = new Ketnoi();
                DataTable dt = kn.SetTable("select * from TaiKhoan where Username='" + txtUsername.Text + "' And Password='" + Int32.Parse(txtPassword.Text) + "' And Trangthai=N'Hoạt động'");
                if (dt.Rows.Count == 1)
                {

                    MessageBox.Show("Đăng nhập thành công !!!");

                    //   Thread thread = new Thread(new ThreadStart(ShowForm2)); //Tạo luồng mới


                    //     thread.Start(); //Khởi chạy luồng
                    //    this.Close(); //đóng Form hiện tại. (Form1)
                    ShowForm1();

                }
                else
                    MessageBox.Show("Sai tài khoản hoặc mật khẩu. Nhập lại", "thông báo");
            }
            catch
            { MessageBox.Show("Lỗi exception không kết nối được với database!!!!!!");
              
            }
        }

        private void btnDangKi_Click(object sender, EventArgs e)
        {
            formDangKi1.Show();
        }

        private void formDangKi1_Load(object sender, EventArgs e)
        {

        }
    }
}
