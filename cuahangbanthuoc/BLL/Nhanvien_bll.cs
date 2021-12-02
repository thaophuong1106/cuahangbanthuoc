using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DOT;
using DAT;

using System.Data;

namespace BLL
{
    public class Nhanvien_bll
    {
        Ketnoi kn;
        public void Them(Nhanvien nv)
        {
            kn = new Ketnoi();
            string sql = "insert into Nhanvien values(N'" + nv.ID + "',N'" + nv.Hoten + "',N'" + nv.Gioitinh + "','" + nv.Namsinh + "','" + nv.Socmt + "','" + nv.Sdt + "',N'" + nv.Diachi + "',N'" + nv.Chucvu + "',N'" + nv.Trangthai + "')";
            kn.ExecuteQuery(sql);
        }
        public void Sua(Nhanvien nv)
        {
            kn = new Ketnoi();
            string sql = "update Nhanvien set ID=N'" + nv.ID + "',Hoten=N'" + nv.Hoten + "',Gioitinh=N'" + nv.Gioitinh + "',Namsinh='" + nv.Namsinh + "',Socmt='" + nv.Socmt + "',Sdt='" + nv.Sdt + "',Diachi=N'" + nv.Diachi + "',Chucvu=N'" + nv.Chucvu + "',Trangthai=N'" + nv.Trangthai + "' where ID='" + nv.ID + "'";
            kn.ExecuteQuery(sql);
        }
        public void Xoa(Nhanvien nv)
        {
            kn = new Ketnoi();
            string sql = "Update Nhanvien set Trangthai=N'Nghỉ làm' where ID='"+nv.ID+"' ";
            kn.ExecuteQuery(sql);
        }
        public void Lamvieclai(Nhanvien nv)
        {
            kn = new Ketnoi();
            string sql = "Update Nhanvien set Trangthai=N'Đang làm việc'where ID='" + nv.ID + "'";
            kn.ExecuteQuery(sql);
        }

        public DataTable laydanhsachnv()
        {
            kn = new Ketnoi();
            string sql = "select * from Nhanvien";
            return kn.SetTable(sql);
        }
    }
}
