using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace ProductAllTool.Models.DuyetBST
{
    public class DuyetBST
    {
        public string MaBST { get; set; }
        public string TenBST { get; set; }
        public string Cate { get; set; }
        public string MuaVu { get; set; }
        public string DoiTuong { get; set; }
        public string GioiTinh { get; set; }
        public string ThuNhap { get; set; }
        public string USP { get; set; }
        public string ThongDiep { get; set; }
        public string imglink { get; set; }
    }

    public class ListSP
    {
        public string ID { get; set; }
        public string IDparent { get; set; }
        public string catcode { get; set; }
        public string catname { get; set; }
        public string groupcode { get; set; }
        public string groupname { get; set; }
        public string functcode { get; set; }
        public string functname { get; set; }
        public string Range { get; set; }
        public string brandcode { get; set; }
        public string brandname { get; set; }
        public string nguonnhapcode { get; set; }
        public string nguonnhapname { get; set; }
        public string MuaVu { get; set; }
        public string MaHang { get; set; }
        public string TenHang { get; set; }
        public string imglink { get; set; }
        public string price { get; set; }
        public string slcombo { get; set; }
        public string status { get; set; }
        public string step { get; set; }
        public string createdate { get; set; }
        public string createby { get; set; }
        public string aprovedate { get; set; }
        public string aproveby { get; set; }
        public string aprovenote { get; set; }
    }
}