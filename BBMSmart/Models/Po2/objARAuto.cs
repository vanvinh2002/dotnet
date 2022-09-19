using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace ProductAllTool.Models.Po2
{
    public class ArAutoAdd
    {
        public string khochiacode { get; set; }
        public string khochianame { get; set; }
        public string vendorcode { get; set; }
        public string vendorname { get; set; }
        public string brand { get; set; }
        public string chtsf { get; set; }
        public string mien { get; set; }
        public string tinh { get; set; }
        public string storecode { get; set; }
        public string storename { get; set; }
        public string itemcode { get; set; }
        public string itemname { get; set; }
        public string pserp { get; set; }
        public string dserp { get; set; }
        public string minpsf { get; set; }
        public string slton { get; set; }
        public string slband30 { get; set; }
        public string stockday { get; set; }
        public string slgoiy { get; set; }
        public string sldexuat { get; set; }
        public string RNtopsalefunct { get; set; }
        
    }
    public class ArAutoAccept
    {
     
        public string ID { get; set; }
        public string slduyet { get; set; }

    }

    public class addlyDo
    {

        public int ID { get; set; }
        public string LyDo { get; set; }

    }

    public class Xacnhan
    {

        public string Ca { get; set; }


    }

    public class create
    {
        public string Code { get; set; }
        public string Name { get; set; }
        public string Category { get; set; }
        public string MuaVu { get; set; }
        public string DoiTuong { get; set; }
        public string GioiTinh { get; set; }
        public string ThuNhap { get; set; }
        public string USP { get; set; }
        public string ThongDiep { get; set; }
        public string Themelink { get; set; }
    }

}