using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using DOT;
using System.Data.SqlClient;


namespace DAT
{
    public class Ketnoi
    {
        private SqlConnection cnn;
        //Xây dựng hàm tạo
        public Ketnoi()
        {
            //Khởi tạo SqlConnection
            cnn = new SqlConnection();
            //Giá trị của ConnectionString
            cnn.ConnectionString = @"Data Source=THAOPHUONG\SQLEXPRESS;Initial Catalog=QUANLYCUAHANG1;Integrated Security=True";
            //Mở kết nối
            cnn.Open();

        }
        public void DongKetNoi()
        {
            if (cnn.State == ConnectionState.Open)
                cnn.Close();
        }
        //Dùng cho câu lệnh Select
        public DataTable SetTable(string sql)
        {
            //Lấy dữ liệu từ kết nối cnn và câu lệnh sql

            SqlDataAdapter sda = new SqlDataAdapter(sql, cnn);
            //Đưa kết quả vào DataSet
            DataSet ds = new DataSet();
            sda.Fill(ds);
            //Lấy dữ liệu từ Table[0] của DataSset
            DataTable dt = ds.Tables[0];

            DongKetNoi();
            return dt;

        }
        //Dùng cho update, insert, delete
        public void ExecuteQuery(string sql)
        {
            //Khai báo và khởi tạo SqlCommand
            SqlCommand cmd = cnn.CreateCommand();
            //Xác định CommandText
            cmd.CommandText = sql;
            cmd.ExecuteNonQuery();//Thực hiện lệnh
            cmd.Dispose();
            DongKetNoi();
        }
    }
}