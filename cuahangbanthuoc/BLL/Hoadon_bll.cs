using DAT;
using DOT;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BLL
{
    public class HoaDon_bll
    {
        Ketnoi kn;
        public DataTable Kiemtra(string sql)
        {
            kn = new Ketnoi();
            return kn.SetTable("Select Mahang,Tenhang,Size,Soluong, Giaban from Hanghoa "+sql+"");
        }
        public void Them(HoaDon hd)
        {
            kn = new Ketnoi();
            string sql = "insert into HoaDon values('"+hd.Mahd+"','"+hd.Makh+"','"+hd.Tenkh+"','"+hd.Idnguoiban+"','"+hd.Ngaylap+"')";
            kn.ExecuteQuery(sql);
        }


    }
}
