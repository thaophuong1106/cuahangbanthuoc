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
    public partial class FormHangHoa : UserControl
    {
        public FormHangHoa()
        {
            InitializeComponent();
        }

        private void btnthem_Click(object sender, EventArgs e)
        {
            HangHoa hang = new HangHoa();
            hang.Mahang = txtmahang.Text;
            hang.Tenhang = txttenhang.Text;
            hang.Mancc = cmbmancc.Text;
            hang.Size = cmbsize.Text;
            hang.Mau = txtmau.Text;
            hang.Gianhap = float.Parse(txtgianhap.Text);
            hang.Giaban = float.Parse(txtgiaban.Text);
            hang.Trangthai = cmbtrangthai.Text;
            string loai;
            if (rbnam.Checked)
                loai = "Thuốc Chỉ Định B.S ( Nguy Hiểm)";
            else
                loai = "Thuốc Phổ Thông";
            hang.Loaihang = loai;
            hang.Soluong = Int32.Parse(txtsoluong.Text);

            MessageBox.Show("Bạn có chắc chắn muốn thêm hang hoa", "Trả lời", MessageBoxButtons.OKCancel, MessageBoxIcon.Question);
            errorProvider1.SetError(txtmahang, "");
            if (txtmahang.Text.Trim() == "")
            {
                errorProvider1.SetError(txtmahang, "Vui lòng nhập mã hàng");
            }

            errorProvider1.SetError(txttenhang, "");
            if (txttenhang.Text.Trim() == "")
            {
                errorProvider1.SetError(txttenhang, "Vui lòng nhập tên hàng");
            }

            errorProvider1.SetError(cmbmancc, "");
            if (cmbmancc.Text.Trim() == "")
            {
                errorProvider1.SetError(cmbmancc, "Vui lòng nhập mã nhà cung cấp");
            }

            errorProvider1.SetError(cmbsize, "");
            if (cmbsize.Text.Trim() == "")
            {
                errorProvider1.SetError(cmbsize, "Vui lòng chọn size");
            }

            errorProvider1.SetError(txtmau, "");
            if (txtmau.Text.Trim() == "")
            {
                errorProvider1.SetError(txtmau, "Vui lòng nhập HSD");
            }

            errorProvider1.SetError(txtsoluong, "");
            if (txtsoluong.Text.Trim() == "")
            {
                errorProvider1.SetError(txtsoluong, "Vui lòng nhập số lượng");
            }

            errorProvider1.SetError(txtgianhap, "");
            if (txtgianhap.Text.Trim() == "")
            {
                errorProvider1.SetError(txtgianhap, "Vui lòng điền giá nhập");
            }
            errorProvider1.SetError(txtgiaban, "");
            if (txtgiaban.Text.Trim() == "")
            {
                errorProvider1.SetError(txtgiaban, "Vui lòng điền giá bán");
            }
            if (txtmahang.Text.Trim() == "" || txttenhang.Text.Trim() == "" || cmbmancc.Text.Trim() == "" 
                || txtmau.Text.Trim() == "" || cmbsize.Text.Trim() == "" || txtsoluong.Text.Trim() == "" || txtgianhap.Text.Trim() == "")
            {
                MessageBox.Show("Vui lòng nhập đầy đủ thông tin");
            }
            else
            {
                try
                {
                    HangHoa_bll hangbll = new HangHoa_bll();
                    hangbll.Them(hang);
                    MessageBox.Show("Thềm thành công!!");
                    FormHangHoa_Load(sender, e);
                }
                catch (Exception ex)
                { MessageBox.Show("Mã hàng đã tồn tại!!!"); }
            }
        }

        private void FormHangHoa_Load(object sender, EventArgs e)
        {
         
            HangHoa_bll hh = new HangHoa_bll();
            dgvhanghoa.DataSource = hh.hienthi();
            NhaCungCap_bll ncc_bll = new NhaCungCap_bll();
            cmbmancc.DataSource = ncc_bll.Hienthi();
            cmbmancc.ValueMember = "Mancc";
            cmbmancc.DisplayMember = "Mancc";
          
        }

        private void dgvhanghoa_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            String loai;
            
            int vt = e.RowIndex;
            txtmahang.Text = dgvhanghoa.Rows[vt].Cells[0].Value.ToString();
            txttenhang.Text = dgvhanghoa.Rows[vt].Cells[1].Value.ToString();
            cmbmancc.Text = dgvhanghoa.Rows[vt].Cells[2].Value.ToString();
            loai= dgvhanghoa.Rows[vt].Cells[3].Value.ToString();
            if (loai == "Thuốc Phổ Thông")
                rbnu.Checked = true;
            else 
                rbnam.Checked = true    ;
            cmbsize.Text = dgvhanghoa.Rows[vt].Cells[4].Value.ToString();
            txtmau.Text = dgvhanghoa.Rows[vt].Cells[5].Value.ToString();
            txtsoluong.Text = dgvhanghoa.Rows[vt].Cells[6].Value.ToString();
            txtgianhap.Text = dgvhanghoa.Rows[vt].Cells[7].Value.ToString();
            txtgiaban.Text = dgvhanghoa.Rows[vt].Cells[8].Value.ToString();
            cmbtrangthai.Text= dgvhanghoa.Rows[vt].Cells[9].Value.ToString();
        }

        private void btnsua_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Bạn có chắc chắn muốn sửa thông tin hang hoá", "Trả lời", MessageBoxButtons.OKCancel, MessageBoxIcon.Question);
            errorProvider1.SetError(txtmahang, "");
            if (txtmahang.Text.Trim() == "")
            {
                errorProvider1.SetError(txtmahang, "Vui lòng nhập mã hàng");
            }

            errorProvider1.SetError(txttenhang, "");
            if (txttenhang.Text.Trim() == "")
            {
                errorProvider1.SetError(txttenhang, "Vui lòng nhập tên hàng");
            }

            errorProvider1.SetError(cmbmancc, "");
            if (cmbmancc.Text.Trim() == "")
            {
                errorProvider1.SetError(cmbmancc, "Vui lòng nhập mã nhà cung cấp");
            }

            errorProvider1.SetError(cmbsize, "");
            if (cmbsize.Text.Trim() == "")
            {
                errorProvider1.SetError(cmbsize, "Vui lòng chọn size");
            }

            errorProvider1.SetError(txtmau, "");
            if (txtmau.Text.Trim() == "")
            {
                errorProvider1.SetError(txtmau, "Vui lòng nhập HSD");
            }

            errorProvider1.SetError(txtsoluong, "");
            if (txtsoluong.Text.Trim() == "")
            {
                errorProvider1.SetError(txtsoluong, "Vui lòng nhập số lượng");
            }

            errorProvider1.SetError(txtgianhap, "");
            if (txtgianhap.Text.Trim() == "")
            {
                errorProvider1.SetError(txtgianhap, "Vui lòng điền giá nhập");
            }
            errorProvider1.SetError(txtgiaban, "");
            if (txtgiaban.Text.Trim() == "")
            {
                errorProvider1.SetError(txtgiaban, "Vui lòng điền giá bán");
            }
            HangHoa hang = new HangHoa();
            hang.Mahang = txtmahang.Text;
            hang.Tenhang = txttenhang.Text;
            hang.Mancc = cmbmancc.Text;
            hang.Size = cmbsize.Text;
            hang.Mau = txtmau.Text;
            hang.Gianhap = float.Parse(txtgianhap.Text);
            hang.Giaban = float.Parse(txtgiaban.Text);
            hang.Trangthai = cmbtrangthai.Text;
            string loai;
            if (rbnam.Checked)
                loai = "Thuốc Chỉ Định B.S ( Nguy Hiểm)";
            else
                loai = "Thuốc Phổ Thông";
            hang.Loaihang = loai;
            hang.Soluong = Int32.Parse(txtsoluong.Text);
            if (txtmahang.Text.Trim() == "" || txttenhang.Text.Trim() == "" || cmbmancc.Text.Trim() == "" 
                || txtmau.Text.Trim() == "" || cmbsize.Text.Trim() == "" || txtsoluong.Text.Trim() == "" || txtgianhap.Text.Trim() == "")
            {
                MessageBox.Show("Vui lòng nhập đầy đủ thông tin");
            }
            else
            {
                try
                {
                    HangHoa_bll hangbll = new HangHoa_bll();
                    hangbll.Sua(hang);
                    MessageBox.Show("Sửa thành công!!");
                    FormHangHoa_Load(sender, e);
                }
                catch (Exception ex)
                { MessageBox.Show("Mã hàng đã tồn tại!!!"); }
            }
        }

        private void btnngungkinhdoanh_Click(object sender, EventArgs e)
        {
            HangHoa hh = new HangHoa();
            hh.Mahang = txtmahang.Text;
            HangHoa_bll hh_bll = new HangHoa_bll();
            DialogResult a = MessageBox.Show("Bạn có muốn ngừng kinh doanh : " +txttenhang.Text + "???", "???", MessageBoxButtons.YesNo);
            if (txtmahang.Text.Trim() == "")
            { MessageBox.Show("Chọn hàng hóa muốn ngừng kinh doanh!!!"); }

            else if (a == DialogResult.Yes)
            {
                hh_bll.Xoa(hh);
                MessageBox.Show("Thay đổi thành công!!!");
            }
            FormHangHoa_Load(sender, e);
        }

        private void btnkinhdoanhlai_Click(object sender, EventArgs e)
        {
            HangHoa hh = new HangHoa();
            hh.Mahang = txtmahang.Text;
            HangHoa_bll hh_bll = new HangHoa_bll();
            DialogResult a = MessageBox.Show("Bạn có muốn kinh doanh lại : " + txttenhang.Text + "???", "???", MessageBoxButtons.YesNo);
            if (txtmahang.Text.Trim() == "")
            { MessageBox.Show("Chọn hàng hóa muốn kinh doanh lại!!!"); }

            else if (a == DialogResult.Yes)
            {
                hh_bll.Nhaplai(hh);
                MessageBox.Show("Thay đổi thành công!!!");
            }
            FormHangHoa_Load(sender, e);
        }

        private void cmbsize_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}
