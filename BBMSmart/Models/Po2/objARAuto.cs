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

    public class TTUVadd
    {
        public string Ten { get; set; }
        public string Ma { get; set; }
        public string GioiTinh { get; set; }
        public string TinhTrangHonNhan { get; set; }
        public DateTime NgaySinh { get; set; }
        public string NoiSinh { get; set; }
        public string NguyenQuan { get; set; }
        public string Quoctich { get; set; }
        public string TonGiao { get; set; }
        public string TrinhDoVanHoa { get; set; }
        public string TrinhDoHocVan { get; set; }
        public string TenThuongGoi { get; set; }
        public string TenTiengHoa { get; set; }
        public int SoCMND { get; set; }
        public DateTime NgayCapCMND { get; set; }
        public string NoiCapCMND { get; set; }
        public string MST { get; set; }
        public DateTime NgayApDung { get; set; }
        public string CoQuanQuanLy { get; set; }
        public int SoHoChieu { get; set; }
        public string NoiCapSHC { get; set; }
        public DateTime NgayCapSHC { get; set; }
        public DateTime NgayHetHanSHC { get; set; }
        public int SoCCCD { get; set; }
        public int DTDD { get; set; }
        public int DTDD2 { get; set; }
        public int DTN { get; set; }
        public string Email { get; set; }
        public string QuocgiaThuongTru { get; set; }
        public string TinhThanhThuongTru { get; set; }
        public string QuanHuyenThuongTru { get; set; }
        public string PhuongXaThuongTru { get; set; }
        public string DiaChiThuongTru { get; set; }
        public string QuocGiaCMND { get; set; }
        public string TinhThanhCMND { get; set; }
        public string QuanHuyenCMND { get; set; }
        public string PhuongXaCMND { get; set; }
        public string DiaChiCMND { get; set; }
        public string QuocGiaTamTru { get; set; }
        public string TinhThanhTamTru { get; set; }
        public string QuanHuyenTamTru { get; set; }
        public string PhuongXaTamTru { get; set; }
        public string DiaChiTamTru { get; set; }
        public string TinhTrangSucKhoe { get; set; }
        public int ChieuCao { get; set; }
        public int CanNang { get; set; }
        public string MatTrai { get; set; }
        public string MatPhai { get; set; }
        public string BenhLy { get; set; }
        public string HuyetAp { get; set; }
        public string NhipTim { get; set; }
        public string SizeQuan { get; set; }
        public string BangLaiXe { get; set; }
        public string SBD { get; set; }

    }

}