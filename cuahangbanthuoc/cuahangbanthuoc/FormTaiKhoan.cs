using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using DOT;
using DAT;


using BLL;

namespace cuahangbanthuoc
{
    public partial class FormTaiKhoan : UserControl
    {
        public FormTaiKhoan()
        {
            InitializeComponent();
        }

        private void FormTaiKhoan_Load(object sender, EventArgs e)
        {
            TaiKhoan_bll tk = new TaiKhoan_bll();
       
            dgvTaiKhoan.DataSource = tk.laydanhsachTK();

        }

        private void btnThem_Click(object sender, EventArgs e)
        {
            TaiKhoan tk = new TaiKhoan();

            tk.Username = txtUsername.Text;
            tk.Password = txtPassword.Text;
            tk.Email = txtEmail.Text;
            //  tk.Trangthai = txtTrangthai.Text;
            //   int vt = dgvTaiKhoan.RowCount-1;

            DialogResult a = MessageBox.Show("Bạn có muốn thêm tài khoản: " + txtUsername.Text + "???", "Thêm", MessageBoxButtons.YesNo);
            TaiKhoan_bll tk_bll = new TaiKhoan_bll();
            try
            {
                if (txtUsername.Text.Trim() == "" || txtUsername.Text.Trim() == "" || txtPassword.Text.Trim() == "")
                { MessageBox.Show("Điền đầy đủ thông tin!!!"); }

                else if (a == DialogResult.Yes)
                {
                        tk_bll.Them(tk);
                        MessageBox.Show("Thêm thành công!!!");                   
                }
            }
            catch (Exception ex)
            { MessageBox.Show("Lỗi khi thêm tài khoản. Nhập lại!!!  /n " + ex.ToString() + ""); }
            FormTaiKhoan_Load(sender, e);
        }

        private void btnXoas_Click(object sender, EventArgs e)
        {
            TaiKhoan tk = new TaiKhoan();  
            TaiKhoan_bll tk_bll = new TaiKhoan_bll();
            tk.Username = txtUsername.Text;
            DialogResult a = MessageBox.Show("Bạn có muốn vô hiệu hóa tài khoản: " + txtUsername.Text + "???", "???", MessageBoxButtons.YesNo);
            if (txtUsername.Text.Trim() == "")
            { MessageBox.Show("Chọn tài khoản cần vô hiệu hóa!!!"); }

            else if (a == DialogResult.Yes)
            {
                tk_bll.Vohieuhoa(tk);
                MessageBox.Show("Vô hiệu hóa thành công!!!");
            }
            FormTaiKhoan_Load(sender, e);
        }

        private void btnSua_Click(object sender, EventArgs e)
        {
            TaiKhoan tk = new TaiKhoan();
            tk.Username = txtUsername.Text;
            tk.Password = txtPassword.Text;
            tk.Email = txtEmail.Text;
            // tk.Trangthai = txtTrangthai.Text;

            TaiKhoan_bll tk_bll = new TaiKhoan_bll();
            DialogResult a = MessageBox.Show("Bạn có muốn sửa tài khoản: " + txtUsername.Text + "???", "Sửa", MessageBoxButtons.YesNo);
            try
            {
                if (txtUsername.Text.Trim() == "")
                { MessageBox.Show("Chọn tài khoản để sửa !!!"); }

                else if (a == DialogResult.Yes)
                {                
                        tk_bll.Sua(tk);
                        MessageBox.Show("Sửa thành công!!!");              
                }
            }
            catch { MessageBox.Show("Lỗi khi sửa dữu liệu!!!"); }
            FormTaiKhoan_Load(sender, e);
        }

        private void dgvTaiKhoan_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            // Vị trí dòng được chọn
           
            int vt = e.RowIndex;
            //Lấy dữ liệu từ các cells trên dòng vt        
            //đưa vào ô tương ứng     
            string Username = dgvTaiKhoan.Rows[vt].Cells[0].Value.ToString();
            txtUsername.Text = Username;
            string Password = dgvTaiKhoan.Rows[vt].Cells[1].Value.ToString();
            txtPassword.Text = Password;
            string Email = dgvTaiKhoan.Rows[vt].Cells[2].Value.ToString();
            txtEmail.Text = Email;
            string Trangthai = dgvTaiKhoan.Rows[vt].Cells[3].Value.ToString();
            // txtTrangthai.Text = Trangthai;
        }

       

        private void btnKichhoat_Click_1(object sender, EventArgs e)
        {
            TaiKhoan tk = new TaiKhoan();
            TaiKhoan_bll tk_bll = new TaiKhoan_bll();
            tk.Username = txtUsername.Text;
            DialogResult a = MessageBox.Show("Bạn có muốn kích hoạt lại tài khoản: " + txtUsername.Text + "???", "???", MessageBoxButtons.YesNo);
            if (txtUsername.Text.Trim() == "")
            { MessageBox.Show("Chọn tài khoản cần kích hoạt!!!"); }

            else if (a == DialogResult.Yes)
            {
                tk_bll.Kichhoat(tk);
                MessageBox.Show("kích hoạt thành công!!!");
            }
            FormTaiKhoan_Load(sender, e);
        }
    }
}
