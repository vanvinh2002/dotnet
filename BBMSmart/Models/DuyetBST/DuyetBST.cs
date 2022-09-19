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

    public class SetDuyetBST
    {
        public string type { get; set; }
        public List<ListSP> lst { get; set; }
    }

    public class SetDuyetBST1
    {
        public string type { get; set; }
        public string Code { get; set; }
        public List<DuyetBST> lst { get; set; }
    }

    public class setRun
    {
        public string Code { get; set; }
        public int type { get; set; }
    }

    public class ListSP
    {
        public string ID { get; set; }
        public string Code { get; set; }
        public string Name { get; set; }
        public string hinhanh { get; set; }
        public string GiaBanAll { get; set; }
        public string slcombo { get; set; }
    }

    public class UpdateSP
    {
        public int ID { get; set; }
        public string slcombo { get; set; }
    }

    public class addBST
    {
        public string Code { get; set; }
        public string Name { get; set; }
        public string MaHang { get; set; }
        public string TenHang { get; set; }
        public decimal price { get; set; }
        public string imglink { get; set; }
        public decimal slcombo { get; set; }
        public string catcode { get; set; }
    }
}