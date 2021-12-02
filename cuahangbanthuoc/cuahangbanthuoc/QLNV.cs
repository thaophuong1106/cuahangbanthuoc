using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using BLL;
using DTO;
using DAT;

namespace GUI
{
    public partial class QLNV : Form
    {
        public QLNV()
        {
            InitializeComponent();
        }

        private void QLNV_Load(object sender, EventArgs e)
        {

            Nhanvien_bll nv1 = new Nhanvien_bll();
            dgvnhanvien.DataSource = nv1.laydanhsachnv();

        }
        private void btndong_Click(object sender, EventArgs e)
        {
            DialogResult traloi;
            traloi = MessageBox.Show("Bạn có muốn đóng", "Trả lời", MessageBoxButtons.OKCancel, MessageBoxIcon.Question);
            if (traloi == DialogResult.OK)
                this.Hide();
        }
        private void dgvnhanvien_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            //Chuyen thong tin len
            String gt;
            if (radnam.Checked)
                gt = "Nam";
            else
                gt = "Nữ";
            int vt = e.RowIndex;
            txtmanv.Text = dgvnhanvien.Rows[vt].Cells[0].Value.ToString();
            txthoten.Text = dgvnhanvien.Rows[vt].Cells[1].Value.ToString();
            //dtpngaysinh.Text = dgvnhanvien.Rows[vt].Cells[2].Value.ToString();
            gt = dgvnhanvien.Rows[vt].Cells[3].Value.ToString();
            txtcmnd.Text = dgvnhanvien.Rows[vt].Cells[4].Value.ToString();
            txtsdt.Text = dgvnhanvien.Rows[vt].Cells[5].Value.ToString();
            txtdiachi.Text = dgvnhanvien.Rows[vt].Cells[6].Value.ToString();
            txtchucvu.Text = dgvnhanvien.Rows[vt].Cells[7].Value.ToString();
            cbotrangthai.SelectedValue = dgvnhanvien.Rows[vt].Cells[8].Value.ToString();

        }
        private void btnthem_Click_1(object sender, EventArgs e)
        {
            MessageBox.Show("Bạn có chắc chắn muốn thêm nhân viên", "Trả lời", MessageBoxButtons.OKCancel, MessageBoxIcon.Question);
            Nhanvien nv = new Nhanvien();
            if ((txtmanv.Text.Trim() == "" || txthoten.Text.Trim() == "" || txtcmnd.Text.Trim() == "" || txtsdt.Text.Trim() == "" || txtdiachi.Text.Trim() == "" || txtchucvu.Text.Trim() == ""))
            {
                MessageBox.Show("Vui lòng nhập đầy đủ thông tin");
                errorProvider1.SetError(txtmanv, "");
                if (txtmanv.Text.Trim() == "")
                {
                    errorProvider1.SetError(txtmanv, "Vui lòng nhập mã nhân viên");
                }
                nv.ID = txtmanv.Text;
                errorProvider1.SetError(txthoten, "");
                if (txthoten.Text.Trim() == "")
                {
                    errorProvider1.SetError(txthoten, "Vui lòng nhập họ tên");
                }
                nv.Hoten = txthoten.Text;
                errorProvider1.SetError(txtcmnd, "");
                if (txtcmnd.Text.Trim() == "")
                {
                    errorProvider1.SetError(txtcmnd, "Vui lòng nhập số CMND");
                }
                nv.Socmt = txtcmnd.Text;
                errorProvider1.SetError(txtsdt, "");
                if (txtsdt.Text.Trim() == "")
                {
                    errorProvider1.SetError(txtsdt, "Vui lòng nhập SĐT");
                }
                nv.Sdt = txtsdt.Text;
                errorProvider1.SetError(txtchucvu, "");
                if (txtchucvu.Text.Trim() == "")
                {
                    errorProvider1.SetError(txtchucvu, "Vui lòng nhập chức vụ");
                }
                nv.Chucvu = txtchucvu.Text;
                errorProvider1.SetError(txtdiachi, "");
                if (txtdiachi.Text.Trim() == "")
                {
                    errorProvider1.SetError(txtdiachi, "Vui lòng nhập địa chỉ");
                }
                nv.Diachi = txtdiachi.Text;
                if (radnam.Checked)
                    nv.Gioitinh = "Nam";
                else
                    nv.Gioitinh = "Nữ";
                nv.Trangthai = cbotrangthai.Text;
                nv.Namsinh = dtpngaysinh.Text;
            }
            else
            {
                Nhanvien_bll nvbll = new Nhanvien_bll();
                nvbll.Them(nv);
                QLNV_Load(sender, e);
            }
          }
        
        private void btnsua_Click(object sender, EventArgs e)
        {
            Nhanvien nv = new Nhanvien();
            MessageBox.Show("Bạn có chắc chắn muốn sửa thông tin nhân viên", "Trả lời", MessageBoxButtons.OKCancel, MessageBoxIcon.Question);
            
            nv.ID = txtmanv.Text;
            nv.Hoten = txthoten.Text;
            nv.Socmt = txtcmnd.Text;
            nv.Sdt = txtsdt.Text;
            nv.Chucvu = txtchucvu.Text;
            nv.Diachi = txtdiachi.Text;
            if (radnam.Checked)
                nv.Gioitinh = "Nam";
            else
                nv.Gioitinh = "Nữ";
            nv.Trangthai = cbotrangthai.Text;
            nv.Namsinh = dtpngaysinh.Text;
            if ((txtmanv.Text.Trim() == "" || txthoten.Text.Trim() == "" || txtcmnd.Text.Trim() == "" || txtsdt.Text.Trim() == "" || txtdiachi.Text.Trim() == "" || txtchucvu.Text.Trim() == ""))
            {
                MessageBox.Show("Vui lòng nhập đầy đủ thông tin");
                errorProvider1.SetError(txtmanv, "");
                if (txtmanv.Text.Trim() == "")
                {
                    errorProvider1.SetError(txtmanv, "Vui lòng nhập mã nhân viên");
                }
                errorProvider1.SetError(txthoten, "");
                if (txthoten.Text.Trim() == "")
                {
                    errorProvider1.SetError(txthoten, "Vui lòng nhập họ tên");
                }
                errorProvider1.SetError(txtcmnd, "");
                if (txtcmnd.Text.Trim() == "")
                {
                    errorProvider1.SetError(txtcmnd, "Vui lòng nhập số CMND");
                }
                errorProvider1.SetError(txtsdt, "");
                if (txtsdt.Text.Trim() == "")
                {
                    errorProvider1.SetError(txtsdt, "Vui lòng nhập SĐT");
                }
                errorProvider1.SetError(txtchucvu, "");
                if (txtchucvu.Text.Trim() == "")
                {
                    errorProvider1.SetError(txtchucvu, "Vui lòng nhập chức vụ");
                }
                errorProvider1.SetError(txtdiachi, "");
                if (txtdiachi.Text.Trim() == "")
                {
                    errorProvider1.SetError(txtdiachi, "Vui lòng nhập địa chỉ");
                }
            }

            else
            {
                Nhanvien_bll nvbll = new Nhanvien_bll();
                nvbll.Sua(nv);
                QLNV_Load(sender, e);
            }
        }

        private void btnxoa_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Bạn có chắc chắn muốn sửa thông tin nhân viên", "Trả lời", MessageBoxButtons.OKCancel, MessageBoxIcon.Question);
            Nhanvien nv = new Nhanvien();
            nv.ID = txtmanv.Text;
            Nhanvien_bll nvbll = new Nhanvien_bll();
            nvbll.Xoa(nv);
            QLNV_Load(sender, e);
        }
    }
}
   
