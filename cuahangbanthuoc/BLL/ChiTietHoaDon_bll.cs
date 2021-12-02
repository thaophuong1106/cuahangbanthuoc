using DAT;
using DOT;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BLL
{
   public class ChiTietHoaDon_bll
    {
        Ketnoi kn;
        public void Them(ChiTietHoaDon cthd)
        {
            kn = new Ketnoi();
            string sql = "insert into ChiTietHoaDon values('"+cthd.Mahd+"','"+cthd.Mahang+"','"+cthd.Soluongxuat+"','"+cthd.Dongia+"','"+cthd.Thanhtien+"')";
            kn.ExecuteQuery(sql);
        }
    }
}
