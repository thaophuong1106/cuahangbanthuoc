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
namespace GUI
{
    public partial class Hoadon : Form
    {
        public Hoadon()
        {
            InitializeComponent();
        }

        private void Hoadon_Load(object sender, EventArgs e)
        {
            Hoadon_bll hd = new Hoadon_bll();
            dgvhoadon.DataSource = hd.laydanhsachhoadon();
            string sql = "select Mahd,Makh,Tenkh,idNguoiban,Ngaylap from ChiTietHoaDon inner join NhanVien.ID=idNguoiban inner join Hoadon.Mahd=Mahd ";
            dgvchitiethd.DataSource = hd.laydanhsachchitiethoadon();
        }

    }
}
