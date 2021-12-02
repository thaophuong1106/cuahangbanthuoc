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
    public class TaiKhoan_bll
    {
        Ketnoi kn;
        public void Them(TaiKhoan tk)
        {
            kn = new Ketnoi();
            string sql = "Insert into TaiKhoan values(N'" + tk.Username + "','" + tk.Password + "','" + tk.Email + "',N'Hoạt động')";
            kn.ExecuteQuery(sql);
        }
        public void Themtk(TaiKhoan tk)
        {
            kn = new Ketnoi();
            string sql = "Insert into TaiKhoan values(N'" + tk.Username + "','" + tk.Password + "','" + tk.Email + "',N'Chờ kích hoạt')";
            kn.ExecuteQuery(sql);
        }
        public void Sua(TaiKhoan tk)
        {
            kn = new Ketnoi();
            string sql = "Update TaiKhoan set Password='" + tk.Password + "',Email='" + tk.Email + "' where Username='" + tk.Username + "';";
            kn.ExecuteQuery(sql);
        }
        public void Vohieuhoa(TaiKhoan tk)
        {
            kn = new Ketnoi();
            string sql = "Update TaiKhoan set Trangthai=N'Ngừng hoạt động' Where Username='" + tk.Username + "'";
            kn.ExecuteQuery(sql);
        }
        public void Kichhoat(TaiKhoan tk)
        {
            kn = new Ketnoi();
            string sql = "Update TaiKhoan set Trangthai=N'Hoạt động' Where Username='" + tk.Username + "'";
            kn.ExecuteQuery(sql);
        }

        public DataTable laydanhsachTK()
        {
            kn = new Ketnoi();
            string sql = "select * from TaiKhoan";
            return kn.SetTable(sql);
        }
    }
}