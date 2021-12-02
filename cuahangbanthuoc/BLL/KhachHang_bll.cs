using DAT;
using DOT;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
namespace BLL
{
    public class KhachHang_bll
    {
        Ketnoi kn;
        public DataTable hienthi()
        {
            kn = new Ketnoi();
            string sql = "select * from KhachHang";
            return kn.SetTable(sql);
        }
        public void Them(KhachHang kh)
        {
            kn = new Ketnoi();
            string sql = "insert into KhachHang values('" + kh.Makh + "',N'" + kh.Tenkh + "','" + kh.Sdt + "',N'" + kh.Gioitinh + "','" + kh.Diachi + "')";
            kn.ExecuteQuery(sql);
        }
        public void Sua(KhachHang kh)
        {
            kn = new Ketnoi();
            string sql = "update KhachHang set Makh='" + kh.Makh + "',Tenkh=N'" + kh.Tenkh + "',Gioitinh=N'" + kh.Gioitinh + "',Sdt='" + kh.Sdt + "',Diachi=N'" + kh.Diachi + "'where Makh='"+kh.Makh+"'";
            kn.ExecuteQuery(sql);
        }

        public void Xoa(KhachHang kh)
        {
            throw new NotImplementedException();
        }

        public static void Clear()
        {
            throw new NotImplementedException();
        }
    }
}
