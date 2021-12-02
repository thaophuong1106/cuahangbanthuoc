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
    public partial class FormNhaCungCap : UserControl
    {
        public FormNhaCungCap()
        {
            InitializeComponent();
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void FormNhaCungCap_Load(object sender, EventArgs e)
        {
          
        }

        private void btnThem_Click(object sender, EventArgs e)
        {
            // tạo mã
            int count = 0;
            count = dgvNhaCungCap.Rows.Count;
            string chuoi = "";
            int chuoi2 = 0;
            chuoi = Convert.ToString(dgvNhaCungCap.Rows[count - 2].Cells[0].Value);
            chuoi2 = Convert.ToInt32(chuoi.Remove(0, 3));
            if (chuoi2 + 1 < 10)
                txtMancc.Text = "NCC00" + (chuoi2 + 1).ToString();
            else
                txtMancc.Text = "NCC0" + (chuoi2 + 1).ToString();
            //end tạo mã
            NhaCungCap ncc = new NhaCungCap();
            ncc.Mancc = txtMancc.Text;
            ncc.Tenncc = txtTenncc.Text;
            ncc.Diachi = txtDiachi.Text;
            ncc.Trangthai =cmbTrangthai.Text;

            DialogResult a = MessageBox.Show("Bạn có muốn thêm Nhà cung cấp: " + txtTenncc.Text + "???", "Thêm", MessageBoxButtons.YesNo);
            NhaCungCap_bll ncc_bll = new NhaCungCap_bll();
            try
            {
                if (txtMancc.Text.Trim() == "" || txtTenncc.Text.Trim() == "" ||txtDiachi.Text.Trim() == ""||cmbTrangthai.Text.Trim()=="")
                { MessageBox.Show("Điền đầy đủ thông tin!!!"); }

                else if (a == DialogResult.Yes)
                {                
                        Ketnoi kn = new Ketnoi();
                        DataTable dt = kn.SetTable("select * from NhaCungCap where Tenncc ='" + txtTenncc.Text + "'");
                        if (dt.Rows.Count >= 1)
                        {
                            MessageBox.Show("Tên nhà cung cấp đã tồn tại !!!");
                        }
                        else
                        {
                            ncc_bll.Them(ncc);
                            MessageBox.Show("Thêm thành công!!!");
                        }
                }
            }
            catch (Exception ex)
            { MessageBox.Show("Lỗi khi thêm Nhà cung cấp. Nhập lại!!!  /n " + ex.ToString() + ""); }
            FormNhaCungCap_Load_1(sender, e);
        }

        private void FormNhaCungCap_Load_1(object sender, EventArgs e)
        {
            NhaCungCap_bll ncc_bll = new NhaCungCap_bll();
            dgvNhaCungCap.DataSource = ncc_bll.Hienthi();
        }

        private void dgvNhaCungCap_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            // Vị trí dòng được chọn
           txtMancc.Enabled = false;
            int vt = e.RowIndex;
            //Lấy dữ liệu từ các cells trên dòng vt
            string Mancc = dgvNhaCungCap.Rows[vt].Cells[0].Value.ToString();
            //đưa vào ô tương ứng
            txtMancc.Text = Mancc;
            string Tenncc = dgvNhaCungCap.Rows[vt].Cells[1].Value.ToString();
            txtTenncc.Text = Tenncc;
            string Diachi= dgvNhaCungCap.Rows[vt].Cells[2].Value.ToString();
            txtDiachi.Text = Diachi;
            string Trangthai = dgvNhaCungCap.Rows[vt].Cells[3].Value.ToString();
            cmbTrangthai.Text = Trangthai;

        }

        private void btnSua_Click(object sender, EventArgs e)
        {
            NhaCungCap ncc = new NhaCungCap();
            ncc.Mancc = txtMancc.Text;
            ncc.Tenncc = txtTenncc.Text;
            ncc.Diachi = txtDiachi.Text;
            ncc.Trangthai = cmbTrangthai.Text;
            
            // tk.Trangthai = txtTrangthai.Text;
            DialogResult a = MessageBox.Show("Bạn có muốn Sửa Nhà cung cấp: " + txtTenncc.Text + "???", "Thêm", MessageBoxButtons.YesNo);
            NhaCungCap_bll ncc_bll = new NhaCungCap_bll();
            try
            {
                if (txtMancc.Text.Trim() == "" || txtTenncc.Text.Trim() == "" || txtDiachi.Text.Trim() == "" || cmbTrangthai.Text.Trim() == "")
                { MessageBox.Show("Điền đầy đủ thông tin!!!"); }

                else if (a == DialogResult.Yes)
                {
                    ncc_bll.Sua(ncc);
                    MessageBox.Show("Sửathành công!!!");

                }
            }
            catch (Exception ex)
            { MessageBox.Show("Lỗi khi Sửa Nhà cung cấp. Nhập lại!!!  /n " + ex.ToString() + ""); }
            FormNhaCungCap_Load_1(sender, e);
        }

        private void button2_Click(object sender, EventArgs e)
        {
            NhaCungCap ncc = new NhaCungCap();
            ncc.Mancc = txtMancc.Text;
            NhaCungCap_bll ncc_bll = new NhaCungCap_bll();
            DialogResult a = MessageBox.Show("Bạn có muốn ngừng nhập hàng từ: " + txtTenncc.Text + "???", "???", MessageBoxButtons.YesNo);
            if (txtMancc.Text.Trim() == "")
            { MessageBox.Show("Chọn nhà cung cấp cần ngừng nhập!!!"); }

            else if (a == DialogResult.Yes)
            {
                ncc_bll.Ngungnhap(ncc);
                MessageBox.Show(" Thành công!!!");
            }
            FormNhaCungCap_Load_1(sender, e);
        }

        private void btnNhaplai_Click(object sender, EventArgs e)
        {
            NhaCungCap ncc = new NhaCungCap();
            ncc.Mancc = txtMancc.Text;
            NhaCungCap_bll ncc_bll = new NhaCungCap_bll();
            DialogResult a = MessageBox.Show("Bạn có muốn nhập lại hàng từ: " + txtTenncc.Text + "???", "???", MessageBoxButtons.YesNo);
            if (txtMancc.Text.Trim() == "")
            { MessageBox.Show("Chọn nhà cung cấp cần nhập lại hàng!!!"); }

            else if (a == DialogResult.Yes)
            {
                ncc_bll.Nhaplai(ncc);
                MessageBox.Show(" Thành công!!!");
            }
            FormNhaCungCap_Load_1(sender, e);
        }

        private void dgvNhaCungCap_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
