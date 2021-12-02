using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using DAT;
using BLL;
using DOT;


namespace cuahangbanthuoc
{
    public partial class FormNhanVien : UserControl
    {
        public FormNhanVien()
        {
            InitializeComponent();
        }

        private void FormNhanVien_Load(object sender, EventArgs e)
        {
            Nhanvien_bll nv1 = new Nhanvien_bll();
            dgvnhanvien.DataSource = nv1.laydanhsachnv();
        }

        private void btnthem_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Bạn có chắc chắn muốn thêm nhân viên", "Trả lời", MessageBoxButtons.OKCancel, MessageBoxIcon.Question);
            Nhanvien nv = new Nhanvien();
            nv.ID = txtmanv.Text;
            nv.Hoten = txthoten.Text;
            nv.Socmt = txtcmnd.Text;
            nv.Sdt = txtsdt.Text;
            nv.Chucvu = cmbchucvu.Text;
            nv.Diachi = txtdiachi.Text;
            nv.Trangthai = cmbtrangthai.Text;
            nv.Namsinh = dtpngaysinh.Text;
            if (rdnam.Checked)
                nv.Gioitinh = "Nam";
            else
                nv.Gioitinh = "Nữ";
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

            errorProvider1.SetError(cmbchucvu, "");
            if (cmbchucvu.Text.Trim() == "")
            {
                errorProvider1.SetError(cmbchucvu, "Vui lòng nhập chức vụ");
            }

            errorProvider1.SetError(txtdiachi, "");
            if (txtdiachi.Text.Trim() == "")
            {
                errorProvider1.SetError(txtdiachi, "Vui lòng nhập địa chỉ");
            }
            errorProvider1.SetError(cmbtrangthai, "");
            if (cmbtrangthai.Text.Trim() == "")
            {
                errorProvider1.SetError(cmbtrangthai, "Vui lòng nhập trạng thái");
            }

            if ((txtmanv.Text.Trim() == "" || txthoten.Text.Trim() == "" || txtcmnd.Text.Trim() == "" 
                || txtsdt.Text.Trim() == "" || txtdiachi.Text.Trim() == "" || cmbchucvu.Text.Trim() == ""))
            {
                MessageBox.Show("Vui lòng nhập đầy đủ thông tin");
            }
            else
            {
                Nhanvien_bll nvbll = new Nhanvien_bll();
                nvbll.Them(nv);
                FormNhanVien_Load(sender, e);
            }
        }


        private void dgvnhanvien_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            //Chuyen thong tin len
            String gt;
           
            int vt = e.RowIndex;
            txtmanv.Text = dgvnhanvien.Rows[vt].Cells[0].Value.ToString();
            txthoten.Text = dgvnhanvien.Rows[vt].Cells[1].Value.ToString();
            gt = dgvnhanvien.Rows[vt].Cells[2].Value.ToString();
            if (gt == "Nam")
                rdnam.Checked = true;
            else
                rdnu.Checked = true;
            dtpngaysinh.Text = dgvnhanvien.Rows[vt].Cells[3].Value.ToString();
            txtcmnd.Text = dgvnhanvien.Rows[vt].Cells[4].Value.ToString();
            txtsdt.Text = dgvnhanvien.Rows[vt].Cells[5].Value.ToString();
            txtdiachi.Text = dgvnhanvien.Rows[vt].Cells[6].Value.ToString();
            cmbchucvu.Text = dgvnhanvien.Rows[vt].Cells[7].Value.ToString();
            cmbtrangthai.Text = dgvnhanvien.Rows[vt].Cells[8].Value.ToString();
        }

        private void btnsua_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Bạn có chắc chắn muốn sửa thông tin", "Trả lời", MessageBoxButtons.OKCancel, MessageBoxIcon.Question);
            Nhanvien nv = new Nhanvien();
            nv.ID = txtmanv.Text;
            nv.Hoten = txthoten.Text;
            nv.Socmt = txtcmnd.Text;
            nv.Sdt = txtsdt.Text;
            nv.Chucvu = cmbchucvu.Text;
            nv.Diachi = txtdiachi.Text;
            nv.Trangthai = cmbtrangthai.Text;
            nv.Namsinh = dtpngaysinh.Text;
            if (rdnam.Checked)
                nv.Gioitinh = "Nam";
            else
                nv.Gioitinh = "Nữ";
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

            errorProvider1.SetError(cmbchucvu, "");
            if (cmbchucvu.Text.Trim() == "")
            {
                errorProvider1.SetError(cmbchucvu, "Vui lòng nhập chức vụ");
            }

            errorProvider1.SetError(txtdiachi, "");
            if (txtdiachi.Text.Trim() == "")
            {
                errorProvider1.SetError(txtdiachi, "Vui lòng nhập địa chỉ");
            }
            errorProvider1.SetError(cmbtrangthai, "");
            if (cmbtrangthai.Text.Trim() == "")
            {
                errorProvider1.SetError(cmbtrangthai, "Vui lòng nhập trạng thái");
            }

            if ((txtmanv.Text.Trim() == "" || txthoten.Text.Trim() == "" || txtcmnd.Text.Trim() == "" 
                || txtsdt.Text.Trim() == "" || txtdiachi.Text.Trim() == "" || cmbchucvu.Text.Trim() == ""))
            {
                MessageBox.Show("Vui lòng nhập đầy đủ thông tin");
            }
            else
            {
                Nhanvien_bll nvbll = new Nhanvien_bll();
                nvbll.Sua(nv);
                FormNhanVien_Load(sender, e);
            }
        }

        private void btnnghilam_Click(object sender, EventArgs e)
        {
            Nhanvien nv = new Nhanvien();
            nv.ID = txtmanv.Text;
            Nhanvien_bll nv_bll = new Nhanvien_bll();
            DialogResult a = MessageBox.Show("Bạn có muốn thôi việc nhân viên: " + txthoten.Text + "???", "???", MessageBoxButtons.YesNo);
            if (txtmanv.Text.Trim() == "")
            { MessageBox.Show("Chọn nhân viên cần thôi việc!!!"); }

            else if (a == DialogResult.Yes)
            {
                nv_bll.Xoa(nv);
                MessageBox.Show(" Thành công!!!");
            }
            FormNhanVien_Load(sender, e);
        }

        private void btnlamvieclai_Click(object sender, EventArgs e)
        {
            Nhanvien nv = new Nhanvien();
            nv.ID = txtmanv.Text;
            Nhanvien_bll nv_bll = new Nhanvien_bll();
            DialogResult a = MessageBox.Show("Nhân viên: " + txthoten.Text + " làm việc lại???", "???", MessageBoxButtons.YesNo);
            if (txtmanv.Text.Trim() == "")
            { MessageBox.Show("Chọn nhân viên thay đổi!!!"); }

            else if (a == DialogResult.Yes)
            {
                nv_bll.Lamvieclai(nv);
                MessageBox.Show(" Thành công!!!");
            }
            FormNhanVien_Load(sender, e);
        }
    }
}
