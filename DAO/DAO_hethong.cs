using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using DA;
using System.Data;
using System.Data.SqlClient;
namespace DAO
{
    public class DAO_hethong
    {
       
        
        #region select tai khoan nguoi dung
        public static DataTable selectTaikhoan()
        {
            string s = "select hoten,ten, ";
            s += "          CASE quyen  ";
            s += "         WHEN 0 THEN 'User'  ";
            s += "         ELSE 'Admin'  ";
            s += "  END as quyen from taikhoan";
            return DA.Ketnoi.ExcecuteQuery(s);
        }
        #endregion
        #region insert tai khoan nguoi dung
        public static string insertTaikhoan(string hoten, string ten, string matkhau, string quyen)
        {
            string s = "insert into Taikhoan values (N'" + hoten + "',N'" + ten + "','" + matkhau + "'," + quyen + ")";
            return DA.Ketnoi.ExcuteNonQuery(s);
        }

        #endregion
        #region update tai khoan nguoi dung
        public static string updateTaikhoan(string hoten, string tencu, string tenmoi, string matkhau, string quyen)
        {
            string s1, s2; s1 = s2 = "";
            if (hoten != "")
                s1 = " hoten=N'" + hoten + "' ,";
            if (matkhau != "")
                s2 = " matkhau='" + matkhau + "' ,";
            string s = "update Taikhoan set " + s1 + " " + s2 + " ten = N'" + tenmoi + "',quyen=" + quyen + " where ten=N'" + tencu + "'";
            return DA.Ketnoi.ExcuteNonQuery(s);
        }
        #endregion
        #region xoa tai khoan nguoi dung
        public static string deleteTaikhoan(string ten)
        {
            string s = "delete taikhoan where ten=N'" + ten + "'";
            return DA.Ketnoi.ExcuteNonQuery(s);
        }
        #endregion
        public static bool KT_ketnoi()
        {
            DA.Ketnoi kn = new Ketnoi();
            return kn.Open();
        }
        #region get nho tai khoan o trang login
        public static string nhoTaikhoan()
        {
            string s = "select * from nhotaikhoan";
            return DA.Ketnoi.ExcecuteQuery(s).Rows[0]["taikhoan"].ToString();
        }
        #endregion
        public static DataTable dangnhap(string name, string pass)
        {
            string s = "select * from Taikhoan where ten=N'" + name + "' and matkhau='" + pass + "'";
            DataTable dt = DA.Ketnoi.ExcecuteQuery(s);
            return dt;
        }
        #region luu nho tai khoan
        public static string setnhotaikhoan(string tk)
        {
            string s = "update nhotaikhoan set taikhoan = N'" + tk + "'";
            return DA.Ketnoi.ExcuteNonQuery(s);
        }
        #endregion

     
        
    }
}