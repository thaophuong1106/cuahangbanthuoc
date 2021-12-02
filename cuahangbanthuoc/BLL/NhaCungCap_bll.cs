using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DAT;
using DOT;
using System.Data;
namespace BLL
{
   public class NhaCungCap_bll
    {
        Ketnoi kn;
        public void Them(NhaCungCap ncc)
        {
            kn = new Ketnoi();
            string sql = "Insert into NhaCungCap values('" + ncc.Mancc + "',N'" +ncc.Tenncc+ "',N'" + ncc.Diachi + "',N'Đang cung cấp')";
            kn.ExecuteQuery(sql);
        }
        public void Sua(NhaCungCap ncc)
        {
            kn = new Ketnoi();
            string sql = "Update NhaCungCap set   Tenncc=N'" + ncc.Tenncc + "',Diachi=N'" +ncc.Diachi + "', Trangthai=N'" + ncc.Trangthai + "'  where Mancc='" +ncc.Mancc + "';";
            kn.ExecuteQuery(sql);
        }
        public void Ngungnhap(NhaCungCap ncc)
        {
            kn = new Ketnoi();
            string sql = "Update NhaCungCap set Trangthai=N'Ngừng cung cấp' Where Mancc='" + ncc.Mancc + "'";
            kn.ExecuteQuery(sql);
        }
        public void Nhaplai(NhaCungCap ncc)
        {
            kn = new Ketnoi();
            string sql = "Update NhaCungCap set Trangthai=N'Đang cung cấp' Where Mancc='" + ncc.Mancc + "'";
            kn.ExecuteQuery(sql);
        }

        public DataTable Hienthi()
        {
            kn = new Ketnoi();
            string sql = "select * from NhaCungCap";
            return kn.SetTable(sql);
        }
    
}
}
