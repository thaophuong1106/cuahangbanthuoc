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
    public partial class FormHoaDon : UserControl
    {
        public FormHoaDon()
        {
            InitializeComponent();
        }

        private void comboBox2_SelectedIndexChanged(object sender, EventArgs e)
        {
            //txtTenhang.Text = cmbMahang.SelectedValue.ToString();
        }

        private void txtTenhang_TextChanged(object sender, EventArgs e)
        {

        }
        HangHoa_bll hh_bll = new HangHoa_bll();
        HoaDon_bll hd_bll = new HoaDon_bll();
        int dong = 0;
        Nhanvien_bll nv_bll = new Nhanvien_bll();
        private void FormHoaDon_Load(object sender, EventArgs e)
        {
            ColMahang.DataSource = hd_bll.Kiemtra("Where Soluong>0 ");
            ColMahang.ValueMember = "Mahang";
            ColMahang.DisplayMember = "Mahang";
            cmbManv.DataSource = nv_bll.laydanhsachnv();
            cmbManv.ValueMember = "ID";
            cmbManv.DisplayMember = "ID";
        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            dong = e.RowIndex;
        }

        private void dataGridView1_CellValueChanged(object sender, DataGridViewCellEventArgs e)
        {

            try
            {
                DataTable dt = new DataTable();
                dt = hd_bll.Kiemtra("where Mahang='" + Convert.ToString(dataGridView1.Rows[dong].Cells[0].Value) + "'");
                dataGridView1.Rows[dong].Cells[1].Value = dt.Rows[0]["Tenhang"].ToString();
                dataGridView1.Rows[dong].Cells[2].Value = dt.Rows[0]["Size"].ToString();
                dataGridView1.Rows[dong].Cells[3].Value = dt.Rows[0]["Soluong"].ToString();
                dataGridView1.Rows[dong].Cells[5].Value = Double.Parse(dt.Rows[0]["Giaban"].ToString());
               

            }

            catch
            { }

        }


        private void btnTinhtien_Click(object sender, EventArgs e)
        {
            try
            {
                if (int.Parse(dataGridView1.Rows[dong].Cells[4].Value.ToString()) > int.Parse(dataGridView1.Rows[dong].Cells[3].Value.ToString()))
                {
                    dataGridView1.Rows[dong].Cells[6].Value = "0";
                    MessageBox.Show("Sản phẩm: " + dataGridView1.Rows[dong].Cells[1].Value.ToString() + " tạm thời không đủ hàng!!!");

                }
                else if (dataGridView1.Rows[dong].Cells[3].Value != "0 ")
                {
                    dataGridView1.Rows[dong].Cells[6].Value = (double.Parse(dataGridView1.Rows[dong].Cells[4].Value.ToString()) 
                        * double.Parse(dataGridView1.Rows[dong].Cells[5].Value.ToString())).ToString();
                }

                int sc = dataGridView1.Rows.Count;
                double thanhtien = 0;
                for (int i = 0; i < sc - 1; i++)
                    thanhtien += double.Parse(dataGridView1.Rows[i].Cells[6].Value.ToString());
                lblTongtien.Text = thanhtien.ToString();
            }
            catch (Exception ex)
            { MessageBox.Show("Nhập đủ số lượng mua trước khi tính tiền"); }

        }

        private void btnTaohoadon_Click(object sender, EventArgs e)
        {
            KhachHang_bll kh_bll = new KhachHang_bll();
            KhachHang kh = new KhachHang();
            ChiTietHoaDon_bll cthd_bll = new ChiTietHoaDon_bll();
            ChiTietHoaDon cthd = new ChiTietHoaDon();
            HoaDon_bll hd_bll = new HoaDon_bll();
            HoaDon hd = new HoaDon();
            HangHoa_bll hh_bll = new HangHoa_bll();
            Boolean gt;
            if (cmbGioitinh.Text == "Nam")
                gt = true;
            else
                gt = false;
            kh.Makh = txtMakh.Text;
            kh.Tenkh = txtTenkh.Text;
            kh.Sdt = txtSdt.Text;

            kh.Gioitinh = gt.ToString();
            kh.Diachi = txtDiachi.Text;

            cthd.Mahd = txtMahd.Text;

            hd.Mahd = txtMahd.Text;
            hd.Makh = txtMakh.Text;
            hd.Tenkh = txtTenkh.Text;
            hd.Idnguoiban = cmbManv.Text;
            hd.Ngaylap = dtpNgaylap.Value.ToString();

            if (txtMahd.Text.Trim() == "" || txtMakh.Text.Trim() == "" || txtDiachi.Text.Trim() == "" 
                || txtSdt.Text.Trim() == "" || txtTenkh.Text.Trim() == "" || cmbGioitinh.Text.Trim() == "" || cmbManv.Text.Trim() == "")
            {
                MessageBox.Show("Điền đầy đủ thông tin hóa đơn, khách hàng trước khi tạo hóa đơn!!!!");
            }
            else if (double.Parse(lblTongtien.Text) == 0)
            { MessageBox.Show("Tính tiền trước khi thêm hóa đơn!!!"); }
            else
            {
                Ketnoi kn = new Ketnoi();
                DataTable dt = kn.SetTable("select * from KhachHang where Makh ='" + txtMakh.Text + "'");
                Ketnoi kn1 = new Ketnoi();
                DataTable dt1 = kn.SetTable("select * from HoaDon where Mahd ='" + txtMahd.Text + "'");
                if (dt.Rows.Count >= 1)
                {
                    MessageBox.Show("Mã khách hàng  đã tồn tại !!!");
                }
                else if (dt1.Rows.Count >= 1)
                { MessageBox.Show("Mã hóa đơn  đã tồn tại !!!"); }
                else
                {//thêm khách hàng
                    kh_bll.Them(kh);

                    //thêm hóa đơn
                    hd_bll.Them(hd);

                    //thêm chi tiết hóa đơn  
                    for (int i = 0; i < dong + 1; i++)
                    {
                        try
                        {
                            cthd.Mahd = txtMahd.Text;
                            cthd.Mahang = dataGridView1.Rows[i].Cells[0].Value.ToString();
                            cthd.Soluongxuat = Int32.Parse(dataGridView1.Rows[i].Cells[4].Value.ToString());
                            cthd.Dongia = float.Parse(dataGridView1.Rows[i].Cells[5].Value.ToString());
                            cthd.Thanhtien = float.Parse(dataGridView1.Rows[i].Cells[6].Value.ToString());
                            cthd_bll.Them(cthd);
                            hh_bll.Capnhatsoluong(Int32.Parse(dataGridView1.Rows[i].Cells[3].Value.ToString()), 
                                Int32.Parse(dataGridView1.Rows[i].Cells[4].Value.ToString()), dataGridView1.Rows[i].Cells[0].Value.ToString());
                        }
                        catch (Exception ex)
                        { MessageBox.Show("Loi:" + ex.ToString() + ""); }
                    }
                    dataGridView1.Rows.Clear();
                    MessageBox.Show("Tạo thành công hóa đơn");
                }
            }
        }



        private void cmbManv_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void btnxoa_Click(object sender, EventArgs e)
        {
            dataGridView1.Rows.Clear();
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
