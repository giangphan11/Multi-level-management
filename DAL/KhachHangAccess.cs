using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;
using DTO;

namespace DAL
{
    public class KhachHangAccess :DatabaseAccess
    {
        public List<KhachHang> layDanhSachKH()
        {
            List<KhachHang> dsKH = new List<KhachHang>();
            openConnection();
            SqlCommand command = new SqlCommand();
            command.CommandType = CommandType.Text;
            command.CommandText = "select * from KhachHang";
            command.Connection = conn;

            SqlDataReader reader = command.ExecuteReader();
            while (reader.Read())
            {
                string ma = reader.GetString(0);
                string tenCty = reader.GetString(1);
                string dc = reader.GetString(2);
                string tp = reader.GetString(3);
                string phone = reader.GetString(4);
                KhachHang kh = new KhachHang();
                
                kh.ma = ma;
                kh.tenCty = tenCty;
                kh.diaChi = dc;
                kh.thanhP = tp;
                kh.phone = phone;

                dsKH.Add(kh);
            }
            reader.Close();
            return dsKH;
        }
    }
}
