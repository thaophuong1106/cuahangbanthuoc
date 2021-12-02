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
    public partial class FormKhachHang : UserControl
    {
        public FormKhachHang()
        {
            InitializeComponent();
        }

        private void FormKhachHang_Load(object sender, EventArgs e)
        {
            KhachHang_bll khbll = new KhachHang_bll();
            dgvkhachhang.DataSource = khbll.hienthi();
        }

        private void btnthem_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Bạn có muốn thêm", "Trả lời", MessageBoxButtons.OKCancel, MessageBoxIcon.Question);
            KhachHang kh = new KhachHang();
            kh.Makh = txtmakh.Text;
            kh.Tenkh = txttenkh.Text;
            if (radnam.Checked)
                kh.Gioitinh = "Nam";
            else
                kh.Gioitinh = "Nữ";
            kh.Sdt = txtsdt.Text;
            kh.Diachi = txtdiachi.Text;
            errorProvider1.SetError(txtmakh, "");
            if (txtmakh.Text.Trim() == "")
            {
                errorProvider1.SetError(txtmakh, "Vui lòng điền mã khách hàng");
            }
            errorProvider1.SetError(txttenkh, "");
            if (txttenkh.Text.Trim() == "")
            {
                errorProvider1.SetError(txttenkh, "Vui lòng điền tên khách hàng");
            }
            errorProvider1.SetError(txtsdt, "");
            if (txtsdt.Text.Trim() == "")
            {
                errorProvider1.SetError(txtsdt, "Vui lòng điền số điện thoại");
            }
            errorProvider1.SetError(txtdiachi, "");
            if (txtdiachi.Text.Trim() == "")
            {
                errorProvider1.SetError(txtdiachi, "Vui lòng điền địa chỉ");
            }

            if ((txtmakh.Text.Trim() == "" || txttenkh.Text.Trim() == "" || txtsdt.Text.Trim() == "" || txtdiachi.Text.Trim() == ""))
            {
                MessageBox.Show("Vui lòng nhập đầy đủ thông tin");
            }
            else
            {
                KhachHang_bll khbll = new KhachHang_bll();
                khbll.Them(kh);
                MessageBox.Show("Thêm thành công");
                FormKhachHang_Load(sender, e);
            }

        }

        private void btnsua_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Bạn có muốn sửa", "Trả lời", MessageBoxButtons.OKCancel, MessageBoxIcon.Question);
            KhachHang kh = new KhachHang();
            kh.Makh = txtmakh.Text;
            kh.Tenkh = txttenkh.Text;
            if (radnam.Checked)
                kh.Gioitinh = "Nam";
            else
                kh.Gioitinh = "Nữ";
            kh.Sdt = txtsdt.Text;
            kh.Diachi = txtdiachi.Text;
            errorProvider1.SetError(txtmakh, "");
            if (txtmakh.Text.Trim() == "")
            {
                errorProvider1.SetError(txtmakh, "Vui lòng điền mã khách hàng");
            }
            errorProvider1.SetError(txttenkh, "");
            if (txttenkh.Text.Trim() == "")
            {
                errorProvider1.SetError(txttenkh, "Vui lòng điền tên khách hàng");
            }
            errorProvider1.SetError(txtsdt, "");
            if (txtsdt.Text.Trim() == "")
            {
                errorProvider1.SetError(txtsdt, "Vui lòng điền số điện thoại");
            }
            errorProvider1.SetError(txtdiachi, "");
            if (txtdiachi.Text.Trim() == "")
            {
                errorProvider1.SetError(txtdiachi, "Vui lòng điền địa chỉ");
            }

            if ((txtmakh.Text.Trim() == "" || txttenkh.Text.Trim() == "" || txtsdt.Text.Trim() == "" || txtdiachi.Text.Trim() == ""))
            {
                MessageBox.Show("Vui lòng nhập đầy đủ thông tin");
            }
            else
            {
                KhachHang_bll khbll = new KhachHang_bll();
                khbll.Sua(kh);
                MessageBox.Show("Sửa thành công");
                FormKhachHang_Load(sender, e);
            }
        }
        int viTri;



        private void dgvkhachhang_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            String gt;
            viTri = e.RowIndex;
            if (viTri >= 0)
            {
                txtmakh.Text = dgvkhachhang.Rows[viTri].Cells[0].Value.ToString();
                txttenkh.Text = dgvkhachhang.Rows[viTri].Cells[1].Value.ToString();
                gt = dgvkhachhang.Rows[viTri].Cells[3].Value.ToString();
                if (gt == "Nam")
                    radnam.Checked = true;
                else
                    radnu.Checked = true;
                txtsdt.Text = dgvkhachhang.Rows[viTri].Cells[2].Value.ToString();
                txtdiachi.Text = dgvkhachhang.Rows[viTri].Cells[4].Value.ToString();
            }
        }

        private void groupBox3_Enter(object sender, EventArgs e)
        {

        }

        /*private void btnxoa_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Bạn có muốn xoá", "Trả lời", MessageBoxButtons.OKCancel, MessageBoxIcon.Question);
            KhachHang kh = new KhachHang();
            kh.Makh = txtmakh.Text;
            kh.Tenkh = txttenkh.Text;
            if (radnam.Checked)
                kh.Gioitinh = "Nam";
            else
                kh.Gioitinh = "Nữ";
            kh.Sdt = txtsdt.Text;
            kh.Diachi = txtdiachi.Text;
            errorProvider1.SetError(txtmakh, "");
            if (txtmakh.Text.Trim() == "")
            {
                errorProvider1.SetError(txtmakh, "Vui lòng điền mã khách hàng");
            }
            errorProvider1.SetError(txttenkh, "");
            if (txttenkh.Text.Trim() == "")
            {
                errorProvider1.SetError(txttenkh, "Vui lòng điền tên khách hàng");
            }
            errorProvider1.SetError(txtsdt, "");
            if (txtsdt.Text.Trim() == "")
            {
                errorProvider1.SetError(txtsdt, "Vui lòng điền số điện thoại");
            }
            errorProvider1.SetError(txtdiachi, "");
            if (txtdiachi.Text.Trim() == "")
            {
                errorProvider1.SetError(txtdiachi, "Vui lòng điền địa chỉ");
            }

            if ((txtmakh.Text.Trim() == "" || txttenkh.Text.Trim() == "" || txtsdt.Text.Trim() == "" || txtdiachi.Text.Trim() == ""))
            {
                MessageBox.Show("Vui lòng nhập đầy đủ thông tin");
            }
            else
            {
                KhachHang_bll khbll = new KhachHang_bll();
                KhachHang.Xoa();
                MessageBox.Show("Xoá thành công");
                FormKhachHang_Load(sender, e);
            }
            KhachHang_bll khbll = new KhachHang_bll();
            KhachHang.Xoa();
        }*/
    }
}
