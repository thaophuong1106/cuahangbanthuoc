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
    public partial class FormDangKi : UserControl
    {
        public FormDangKi()
        {
            InitializeComponent();
        }

        private void btnDangKi_Click(object sender, EventArgs e)
        { 
            TaiKhoan tk = new TaiKhoan(); 
            tk.Username = txtUsername.Text;
            tk.Password = txtPassword.Text;
            tk.Email = txtEmail.Text;

            //   int vt = dgvTaiKhoan.RowCount-1;

            DialogResult a = MessageBox.Show("Bạn có muốn tạo tài khoản: " + txtUsername.Text + "???", "Thêm", MessageBoxButtons.YesNo);
            TaiKhoan_bll tk_bll = new TaiKhoan_bll();
            try
            {
                if (txtUsername.Text.Trim() == "" || txtPassword.Text.Trim() == "")
                { MessageBox.Show("Điền đầy đủ thông tin!!!"); }
                else if (a == DialogResult.Yes)
                {
                    Ketnoi kn = new Ketnoi();
                    DataTable dt = kn.SetTable("select * from TaiKhoan where Username='" + txtUsername.Text + "'");
                    if (dt.Rows.Count >= 1)
                    {
                        MessageBox.Show("Tên đăng nhập đã được sử dung . Chọn tên khác !!!");
                    }
                    else
                    {
                        tk_bll.Themtk(tk);
                        MessageBox.Show("Đăng kí thành công. Chờ kích hoạt !!!");
                        FormDangKi_Load(sender, e);
                        this.Hide();
                    }
                }
            }
            catch { MessageBox.Show("Trùng mã id. Nhập lại!!!"); }
        }


        private void FormDangKi_Load(object sender, EventArgs e)
        {

        }


        private void btnHuy_Click(object sender, EventArgs e)
        {
            this.Hide();
        }

        private void txtEmail_Enter(object sender, EventArgs e)
        {
            if (txtEmail.Text == "abc@gmail.com")
            {
                txtEmail.Text = "";
                txtEmail.ForeColor = Color.Black;
            }
        }

        private void txtEmail_Leave(object sender, EventArgs e)
        {
            if (txtEmail.Text == "")
            {
                txtEmail.Text = "abc@gmail.com";
                txtEmail.ForeColor = Color.Silver;
            }
        }

        private void txtUsername_Leave(object sender, EventArgs e)
        {
            if (txtUsername.Text == "")
            {
                txtUsername.Text = "admin";
                txtUsername.ForeColor = Color.Silver;
            }
        }
        private void txtUsername_Enter(object sender, EventArgs e)
        {
            if (txtUsername.Text == "admin")
            {
                txtUsername.Text = "";
                txtUsername.ForeColor = Color.Black;
            }
        }

        private void txtPassword_Leave(object sender, EventArgs e)
        {
            if (txtPassword.Text == "")
            {
                txtPassword.Text = "****";
                txtPassword.ForeColor = Color.Silver;
            }
        }

        private void txtPassword_Enter(object sender, EventArgs e)
        {
            if (txtPassword.Text == "****")
            {
                txtPassword.Text = "";
                txtPassword.ForeColor = Color.Black;
            }
        }
    }
}