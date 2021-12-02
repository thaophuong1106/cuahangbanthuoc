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
    public class HangHoa_bll
    {
        Ketnoi kn;
        public DataTable TimKiem(HangHoa hh, NhaCungCap ncc)
        {
            kn = new Ketnoi();
            string sql = "select Mahang,Tenhang,Hanghoa.Mancc,Loaihang,Size,Mau,Soluong,Giaban  from Hanghoa inner join NhaCungCap on Hanghoa.Mancc = NhaCungCap.Mancc   where Mahang like '%"+hh.Mahang+"%' and Tenhang like'%"+hh.Tenhang+"%' and NhaCungCap.Tenncc like '%"+ncc.Tenncc+"%' and Size like'%"+hh.Size+"%'";
            return kn.SetTable(sql);
        }
        public DataTable hienthi()
        {
            kn = new Ketnoi();
            string sql = "select * from Hanghoa";
            return kn.SetTable(sql);
        }
        public void Them(HangHoa hh)
        {
            kn = new Ketnoi();
            String sql = "Insert into Hanghoa values('"+hh.Mahang+"',N'"+hh.Tenhang+"','"+hh.Mancc+"',N'"+hh.Loaihang+"',N'"+hh.Size+"',N'"+hh.Mau+"','"+hh.Soluong+"','"+hh.Gianhap+"','"+hh.Giaban+"',N'"+hh.Trangthai+"')";
            kn.ExecuteQuery(sql);
        }
        public void Sua(HangHoa hh)
        {
            kn = new Ketnoi();
            String sql = "Update  Hanghoa set Tenhang=N'" + hh.Tenhang + "',Mancc='" + hh.Mancc + "',Loaihang=N'" + hh.Loaihang + "',Size=N'" + hh.Size + "',Mau=N'" + hh.Mau + "',Soluong='" + hh.Soluong + "',Gianhap='" + hh.Gianhap + "',Giaban='" + hh.Giaban + "',Trangthai=N'" + hh.Trangthai + "' where Mahang='"+hh.Mahang+"'";
            kn.ExecuteQuery(sql);
        }
        public void Xoa(HangHoa hh)
        {
            kn = new Ketnoi();
            String sql = "Update  Hanghoa set Trangthai=N'Ngừng kinh doanh' where Mahang='" + hh.Mahang + "'";
            kn.ExecuteQuery(sql);
        }
        public void Nhaplai(HangHoa hh)
        {
            kn = new Ketnoi();
            String sql = "Update  Hanghoa set Trangthai=N'Đang kinh doanh' where Mahang='" + hh.Mahang + "'";
            kn.ExecuteQuery(sql);
        }
        public void Capnhatsoluong(int a, int b,string c)
        {
            kn = new Ketnoi();
            string sql = "Update Hanghoa set Soluong ="+(a-b)+ " where Mahang='" + c + "'";
            kn.ExecuteQuery(sql);
        }


    }
}
