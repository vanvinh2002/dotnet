using Newtonsoft.Json;
using ProductAllTool.Common;
using ProductAllTool.DataAccess;
using ProductAllTool.Models.DuyetBST;
using ProductAllTool.Models.MDS;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace ProductAllTool.Controllers
{
    public class MDSItemController : Controller
    {
        // GET: MDSItem
        public ActionResult MDSItem()
        {
            if (Session["uid"] != null && Session["uid"].ToString().Length > 0)
            {
                var MDS_cboNCC = DataAccess.DataAccessMDSItem.MDS_cboNCC();
                ViewBag.MDS_cboNCC = MDS_cboNCC;
                var MDS_cboNCC1 = DataAccess.DataAccessMDSItem.MDS_cboNCC1();
                ViewBag.MDS_cboNCC1 = MDS_cboNCC1;
                var MDS_cboFunc = DataAccess.DataAccessMDSItem.MDS_cboFunc();
                ViewBag.MDS_cboFunc = MDS_cboFunc;
                var MDS_cboDivision = DataAccess.DataAccessMDSItem.MDS_cboDivision();
                ViewBag.MDS_cboDivision = MDS_cboDivision;
                var MDS_cboCategory = DataAccess.DataAccessMDSItem.MDS_cboCategory();
                ViewBag.MDS_cboCategory = MDS_cboCategory;
                var MDS_cboGroup = DataAccess.DataAccessMDSItem.MDS_cboGroup();
                ViewBag.MDS_cboGroup = MDS_cboGroup;
                var MDS_cboDivision18 = DataAccess.DataAccessMDSItem.MDS_cboDivision18();
                ViewBag.MDS_cboDivision18 = MDS_cboDivision18;
                var MDS_cboCategory18 = DataAccess.DataAccessMDSItem.MDS_cboCategory18();
                ViewBag.MDS_cboCategory18 = MDS_cboCategory18;
                var MDS_cboGroup18 = DataAccess.DataAccessMDSItem.MDS_cboGroup18();
                ViewBag.MDS_cboGroup18 = MDS_cboGroup18;
                var MDS_cboHHKG = DataAccess.DataAccessMDSItem.MDS_cboHHKG();
                ViewBag.MDS_cboHHKG = MDS_cboHHKG;
                var MDS_cboMuaVu = DataAccess.DataAccessMDSItem.MDS_cboMuaVu();
                ViewBag.MDS_cboMuaVu = MDS_cboMuaVu;
                var MDS_cboThuongHieu = DataAccess.DataAccessMDSItem.MDS_cboThuongHieu();
                ViewBag.MDS_cboThuongHieu = MDS_cboThuongHieu;
                var MDS_cboNguonNhap = DataAccess.DataAccessMDSItem.MDS_cboNguonNhap();
                ViewBag.MDS_cboNguonNhap = MDS_cboNguonNhap;
                var MDS_cboXuatSu = DataAccess.DataAccessMDSItem.MDS_cboXuatSu();
                ViewBag.MDS_cboXuatSu = MDS_cboXuatSu;
                var MDS_cboDVT = DataAccess.DataAccessMDSItem.MDS_cboDVT();
                ViewBag.MDS_cboDVT = MDS_cboDVT;
                var MDS_cboSP = DataAccess.DataAccessMDSItem.MDS_cboSP();
                ViewBag.MDS_cboSP = MDS_cboSP;
                return View();
            }
            else
            {
                SystemFunctions.SaveSession("GDMobile", "LayoutMobileTT3");
                return RedirectToAction("Login", "Account");
            }
        }

        public ActionResult GetTableDSItem(string NCC, string TenSP)
        {
            if (Session["uid"] != null && Session["uid"].ToString().Length > 0)
            {
                DataTable table = DataAccess.DataAccessMDSItem.MDS_GetTblDSItem(Session["uid"].ToString(), NCC, TenSP);

                return PartialView("~/Views/MDSItem/Tables/__tbl_dsitem.cshtml", table);
            }
            return RedirectToAction("Login", "Account");
        }

        public ActionResult GetTableDSItem1(string NCC1, string TenSP1)
        {
            if (Session["uid"] != null && Session["uid"].ToString().Length > 0)
            {
                DataTable table = DataAccess.DataAccessMDSItem.MDS_GetTblDSItem1(Session["uid"].ToString(), NCC1, TenSP1);

                return PartialView("~/Views/MDSItem/Tables/__tbl_dsduyetitem.cshtml", table);
            }
            return RedirectToAction("Login", "Account");
        }

        [HttpPost]
        public ActionResult MDSSetTrangThai(List<setTrangThai> lst)
        {
            try
            {
                if (Session["uid"] != null && Session["uid"].ToString().Length > 0)
                {
                    foreach (setTrangThai po in lst)
                    {
                        DataAccess.DataAccessMDSItem.MDS_setTrangThai(Session["uid"].ToString(), po.ID);
                    }
                    return Json(1);
                }
                return RedirectToAction("Login", "Account");
            }
            catch (Exception ex)
            {
                LogBuild.CreateLogger(JsonConvert.SerializeObject(ex), "MDSSetTrangThai");
                return Json(null);
            }
        }

        public ActionResult MDSSetTrangThai1(List<setTrangThai> lst)
        {
            try
            {
                if (Session["uid"] != null && Session["uid"].ToString().Length > 0)
                {
                    foreach (setTrangThai po in lst)
                    {
                        DataAccess.DataAccessMDSItem.MDS_setTrangThai1(Session["uid"].ToString(), po.ID);
                    }
                    return Json(1);
                }
                return RedirectToAction("Login", "Account");
            }
            catch (Exception ex)
            {
                LogBuild.CreateLogger(JsonConvert.SerializeObject(ex), "MDSSetTrangThai1");
                return Json(null);
            }
        }

        public ActionResult MDSCreateItem(MDSModel lst)
        {
            try
            {
                if (Session["uid"] != null && Session["uid"].ToString().Length > 0)
                {
                    DataAccess.DataAccessMDSItem.MDS_CreateItem(Session["uid"].ToString(), lst);

                    return Json(1);
                }
                return RedirectToAction("Login", "Account");
            }
            catch (Exception ex)
            {
                LogBuild.CreateLogger(JsonConvert.SerializeObject(ex), "MDSCreateItem");
                return Json(null);
            }
        }
    }
}