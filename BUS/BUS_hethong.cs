using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using DAO;
using System.Data;
namespace BUS
{
    public class BUS_hethong
    {
        public static DataTable selectTaikhoan()
        {
            return DAO_hethong.selectTaikhoan();
        }
        public static string insertTaikhoan(string hoten, string ten, string matkhau, string quyen)
        {
            return DAO_hethong.insertTaikhoan(hoten, ten, matkhau, quyen);
        }
        public static string updateTaikhoan(string hoten, string tencu, string tenmoi, string matkhau, string quyen)
        {
            return DAO_hethong.updateTaikhoan(hoten, tencu, tenmoi, matkhau, quyen);
        }
        public static string deleteTaikhoan(string ten)
        {
            return DAO_hethong.deleteTaikhoan(ten);
        }
        public static bool KT_ketnoi()
        {
            return DAO_hethong.KT_ketnoi();
        }
        public static string nhoTaikhoan()
        {
            return DAO_hethong.nhoTaikhoan();
        }
        public static DataTable dangnhap(string name, string pass)
        {
            return DAO_hethong.dangnhap(name, pass);
        }
        public static string setnhotaikhoan(string tk)
        {
            return DAO_hethong.setnhotaikhoan(tk);
        }

    }
}
