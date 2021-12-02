using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using DAT;
using System.Data.SqlClient;
using Microsoft.Reporting.WinForms;




namespace cuahangbanthuoc
{
    public partial class Form1 : Form
    {
        public string user;

        public Form1()
        {
            InitializeComponent();
        }
      
        public Form1(string a)
        {
            InitializeComponent();
      
            lblUsername.Text = a;

        }

        private void btnDangNhap_Click(object sender, EventArgs e)
        {
            formTimKiem1.Hide();
            formHangHoa1.Hide();
            formHoaDon1.Hide();
            lbluser.Hide();
            formNhaCungCap1.Hide();
            formTaiKhoan1.Hide();
            formThongKe1.Hide();

          

           //ẩn nút
     


           
        }

        private void btnTimKiem_Click(object sender, EventArgs e)
        {
            formTimKiem1.Hide();
            formHangHoa1.Hide();
            formHoaDon1.Hide();
            lbluser.Hide();
            formNhaCungCap1.Hide();
            formTaiKhoan1.Hide();
            formKhachHang1.Hide();
            formThongKe1.Hide();
            formTimKiem1.Show();
            formTimKiem1.BringToFront();
            //code         
        }




   
        private void Form1_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'QUANLYCUAHANG1DataSet.TimKiemTheoNgay' table. You can move, or remove it, as needed.
            //  this.TimKiemTheoNgayTableAdapter.Fill(this.QUANLYCUAHANG1DataSet.TimKiemTheoNgay);
            formKhachHang1.Hide();
            formTimKiem1.Show();
            formTimKiem1.BringToFront();
            formHangHoa1.Hide();
            formHoaDon1.Hide();
            lbluser.Hide();
            formNhaCungCap1.Hide();
            formTaiKhoan1.Hide();
            formThongKe1.Hide();

            lblUsername.Text = user;
            if(user=="admin")
            {
               
               btnHangHoa.Enabled = true;
                btnThongKe.Enabled = true;
                btnNhanVien.Enabled = true;
                btnNhaSanXuat.Enabled = true;
                btnTaiKhoan.Enabled = true;
                btnKhachhang.Enabled = true;


            }
            

         
        }

        private void btnHangHoa_Click(object sender, EventArgs e)
        {
            formKhachHang1.Hide();
            formTimKiem1.Hide();
            formHoaDon1.Hide();
            lbluser.Hide();
            formNhaCungCap1.Hide();
            formTaiKhoan1.Hide();
            formThongKe1.Hide();
        
            formHangHoa1.Show();
            formHangHoa1.BringToFront();
            //code
        }

        private void btnHoaDon_Click(object sender, EventArgs e)
        {
            formKhachHang1.Hide();
            formTimKiem1.Hide();
            formHangHoa1.Hide();
            lbluser.Hide();
            formNhaCungCap1.Hide();
            formTaiKhoan1.Hide();
            formThongKe1.Hide();
         
            formHoaDon1.Show();
            formHoaDon1.BringToFront();
            //code
        }

        private void btnThongKe_Click(object sender, EventArgs e)
        {
            formKhachHang1.Hide();
            formTimKiem1.Hide();
            formHangHoa1.Hide();
            formHoaDon1.Hide();
            lbluser.Hide();
            formNhaCungCap1.Hide();
            formTaiKhoan1.Hide();

            formThongKe1.Show();
            formThongKe1.BringToFront();
            //code
        }

        private void btnNhanVien_Click(object sender, EventArgs e)
        {
            formKhachHang1.Hide();
            formTimKiem1.Hide();
            formHangHoa1.Hide();
            formHoaDon1.Hide();
            formThongKe1.Hide();
            formNhaCungCap1.Hide();
            formTaiKhoan1.Hide();
         
            lbluser.Show();
            lbluser.BringToFront();
            //code
        }

        private void btnNhaSanXuat_Click(object sender, EventArgs e)
        {
            formKhachHang1.Hide();
            formTimKiem1.Hide();
            formHangHoa1.Hide();
            formHoaDon1.Hide();
            formThongKe1.Hide();
            lbluser.Hide();
            formTaiKhoan1.Hide();         
          
            formNhaCungCap1.Show();
            formNhaCungCap1.BringToFront();
            //code
        }

        private void btnTaiKhoan_Click(object sender, EventArgs e)
        {
            formKhachHang1.Hide();
            formTimKiem1.Hide();
            formHangHoa1.Hide();
            formHoaDon1.Hide();
            formThongKe1.Hide();
            lbluser.Hide();
            formNhaCungCap1.Hide();
         
            formTaiKhoan1.Show();
            formTaiKhoan1.BringToFront();
            //code
        }

     
        private void formTimKiem1_Load(object sender, EventArgs e)
        {

        }
        DangNhap dn = new DangNhap();
        private void btnDangXuat_Click(object sender, EventArgs e)
        {
            DialogResult a = MessageBox.Show("Bạn có muốn đăng xuất khỏi tài khoản ???", "???", MessageBoxButtons.YesNo);
            if (a == DialogResult.Yes)
            {
                this.Hide();
                dn.ShowDialog();
            }
         
        }

        private void btnKhachhang_Click(object sender, EventArgs e)
        {
            formKhachHang1.Show();
            formKhachHang1.BringToFront();
            formTimKiem1.Hide();
            formHangHoa1.Hide();
            formHoaDon1.Hide();
            lbluser.Hide();
            formNhaCungCap1.Hide();
            formTaiKhoan1.Hide();
            formThongKe1.Hide();
        }
    }
}
