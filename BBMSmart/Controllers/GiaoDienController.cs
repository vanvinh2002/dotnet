using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using ProductAllTool.Models.Approve;
using Lib.Utils.Package;
using ProductAllTool.Common;
using System.Data;
using ProductAllTool.Models.HRM;
using ProductAllTool.DataAccess;
using Newtonsoft.Json;
using ProductAllTool.Models.ManageSales;

namespace ProductAllTool.Controllers
{
    public class GiaoDienController : Controller
    {
        public ActionResult GDMobile()
        {

            return View();
        }
        public ActionResult LichCa()
        {

            return View();
        }
        public ActionResult RegisterShift()
        {

            if (Session["uid"] != null && Session["uid"].ToString().Length > 0)
            {

                var listcalenderca = DataAccess.DataAccessTT.CLV_Ca();
                ViewBag.listcalenderca = listcalenderca;

                var listcalendersto = DataAccess.DataAccessTT.CLV_NoiLam();
                ViewBag.listcalendersto = listcalendersto;

                var liststore = DataAccess.DataAccessTT.CLV_CuaHang();
                ViewBag.liststore = liststore;

                var listbreaktype = DataAccess.DataAccessTT.CLV_LoaiNghi();
                ViewBag.listbreaktype = listbreaktype;

                return View();
            }
            else
            {
                SystemFunctions.SaveSession("GiaoDien", "RegisterShift");
                return RedirectToAction("Login", "Account");
            }
        }
        public ActionResult getList(string TuNgay, string DenNgay, string Ca, string NoiLam)
        {
            if (Session["uid"] != null && Session["uid"].ToString().Length > 0)
            {
                DataTable table = DataAccess.DataAccessTT.CLV_GetList(Session["uid"].ToString(), TuNgay, DenNgay, Ca, NoiLam);

                return PartialView("~/Views/SHIFT/__CalenderShift.cshtml", table);

            }
            return RedirectToAction("Login", "Account");
        }
        public ActionResult getListNC1()
        {
            if (Session["uid"] != null && Session["uid"].ToString().Length > 0)
            {
                DataTable table = DataAccess.DataAccessTT.CLV_getListNC1(Session["uid"].ToString());

                return PartialView("~/Views/SHIFT/__RegisterShift.cshtml", table);

            }
            return RedirectToAction("Login", "Account");
        }
        [HttpPost]
        public ActionResult UpdateTT(List<SetTT> lst)
        {
            try
            {
                if (Session["uid"] != null && Session["uid"].ToString().Length > 0)
                {
                    foreach (SetTT po in lst)
                    {
                        DataAccess.DataAccessTT.CLV_setTT(Session["uid"].ToString(), po.Ca, po.type);
                    }
                    return Json(1);
                }
                return RedirectToAction("Login", "Account");
            }
            catch (Exception ex)
            {
                LogBuild.CreateLogger(JsonConvert.SerializeObject(ex), "UpdateTT");
                return Json(null);
            }
        }
        public ActionResult getListNC2(string TenCH, string Ca)
        {
            if (Session["uid"] != null && Session["uid"].ToString().Length > 0)
            {
                DataTable table = DataAccess.DataAccessTT.CLV_getListNC2(Session["uid"].ToString(), TenCH, Ca);

                return PartialView("~/Views/SHIFT/__SupportShift.cshtml", table);

            }
            return RedirectToAction("Login", "Account");
        }

        public ActionResult GetlistDC(string TuNgay, string DenNgay)
        {
            if (Session["uid"] != null && Session["uid"].ToString().Length > 0)
            {
                DataTable table = DataAccess.DataAccessTT.CLV_getListDC(Session["uid"].ToString(), TuNgay, DenNgay);

                return PartialView("~/Views/SHIFT/__SwitchShift.cshtml", table);

            }
            return RedirectToAction("Login", "Account");
        }
        public ActionResult getListTTNV4()
        {
            if (Session["uid"] != null && Session["uid"].ToString().Length > 0)
            {
                List<ThongTinNV4> listTTNV4 = DataAccess.DataAccessTT.CLV_TTNV4(Session["uid"].ToString());

                return Json(listTTNV4);

            }
            return RedirectToAction("Login", "Account");
        }

        public ActionResult getListXN1(string TuNgay, string DenNgay)
        {
            if (Session["uid"] != null && Session["uid"].ToString().Length > 0)
            {
                DataTable table = DataAccess.DataAccessTT.CLV_getListXN1(Session["uid"].ToString(), TuNgay, DenNgay);

                return PartialView("~/Views/SHIFT/__TakeABreakShift.cshtml", table);

            }
            return RedirectToAction("Login", "Account");
        }
        [HttpPost]
        public ActionResult DuyetList(List<Add> lst)
        {
            try
            {
                if (Session["uid"] != null && Session["uid"].ToString().Length > 0)
                {
                    foreach (Add po in lst)
                    {
                        DataAccess.DataAccessTT.CLV_ADD(Session["uid"].ToString(), po.MaNV, po.TenNV, po.ChucDanh, po.BoPhan, po.TenPB, po.NgayBD, po.NgayKT, po.NgayLamLai, po.LoaiCa, po.LoaiNghi, po.LyDoNghi, po.SoGioNghi);
                    }
                    return Json(1);
                }
                return RedirectToAction("Login", "Account");
            }
            catch (Exception ex)
            {
                LogBuild.CreateLogger(JsonConvert.SerializeObject(ex), "DuyetList");
                return Json(null);
            }
        }
    }
}