using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace ProductAllTool.Models.MDS
{
    public class MDSModel
    {
        public string NCC { get; set; }
        public string TenSP { get; set; }
        public string Barcode { get; set; }
        public string Func { get; set; }
        public string DivE { get; set; }
        public string CatE { get; set; }
        public string GroE { get; set; }
        public string Div18 { get; set; }
        public string Cat18 { get; set; }
        public string Gro18 { get; set; }
        public string HH { get; set; }
        public string MuaVu { get; set; }
        public string ThuongHieu { get; set; }
        public string NguonNhap { get; set; }
        public string XuatXu { get; set; }
        public string DVT { get; set; }
        public decimal TrongLuong { get; set; }
        public decimal Cao { get; set; }
        public decimal Rong { get; set; }
        public decimal Sau { get; set; }
        public decimal CaoHop { get; set; }
        public decimal RongHop { get; set; }
        public decimal SauHop { get; set; }
        public string GiaMua1 { get; set; }
        public string Line { get; set; }
        public string VAT { get; set; }
        public decimal GiaMua2 { get; set; }
        public string GiaNY { get; set; }
    }

    public class setTrangThai
    {
        public int ID { get; set; }
    }
}