﻿using Microsoft.Ajax.Utilities;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Web.Mvc;
using ProductAllTool.Models.Approve;
using Lib.Utils.Package;
using ProductAllTool.Common;
using System.Threading.Tasks;
using ProductAllTool.Models.QLNCC;
using System.Configuration;
using System.Text.RegularExpressions;
using ProductAllTool.Models.ERP_API.PurchaseOrder;
using ProductAllTool.DataAccess;
using ProductAllTool.Models.ManageSales;
using ProductAllTool.Models.Po2;
using ProductAllTool.Models.HRM;

namespace ProductAllTool.Controllers
{
    public class ThucTapController : Controller
    {

        #region system function
        private bool checkpermission(string action)
        {
            List<permissioninfo> ls = (List<permissioninfo>)Session["permission"];
            if (ls.Where(x => x.controller == "ThucTap" && x.action == action).Count() > 0)
                return true;
            else return false;
        }

        #endregion

        #region thuctap1
        public ActionResult ThucTap1()
        {
            if (Session["uid"] != null && Session["uid"].ToString().Length > 0)
            {
               

                return View();
            }
            else
            {
                SystemFunctions.SaveSession("ThucTap", "ThucTap1");
                return RedirectToAction("Login", "Account");
            }
        }


        #endregion

        #region Thuc tap 2
        public ActionResult ThucTap2()
        {
            if (Session["uid"] != null && Session["uid"].ToString().Length > 0)
            {

                return View();
            }
            else
            {
                SystemFunctions.SaveSession("ThucTap", "ThucTap2");
                return RedirectToAction("Login", "Account");
            }
        }

        #endregion

        #region BalancedScorecard
        public ActionResult BalancedScorecard()
        {
            if (Session["uid"] != null && Session["uid"].ToString().Length > 0)
            {

                var lst_division = DataAccess.DataAccessHRM.sp_bbs_get_sys_list_Division();
                ViewBag.lst_division = lst_division;
                var lst_company = DataAccess.DataAccessHRM.sp_bbs_get_sys_list_company();
                ViewBag.lst_company = lst_company;

                var lstsia = DataAccess.DataAccessHRM.sp_getlist_balancedscorecard_SIA();
                ViewBag.lstsia = lstsia;

                var lstkhoi = DataAccess.DataAccessHRM.sp_getlist_balancedscorecard_Khoi();
                ViewBag.lstkhoi = lstkhoi;

                return View();
            }
            else
            {
                return RedirectToAction("Login", "Account");
            }
        }
        //get Balanced scorecard
        [HttpPost]
        public ActionResult GetListBalancedscorecard(string nam, string congty, string khoi, string sia)
        {
            if (Session["uid"] != null && Session["uid"].ToString().Length > 0)
            {
                DataTable table = DataAccess.DataAccessHRM.sp_bbs_get_sys_list_BalancedScoreCard(nam, congty, khoi, sia);

                return PartialView("~/Views/HRM/Partial/__BalancedScorecard.cshtml", table);

            }
            return RedirectToAction("Login", "Account");
        }
        #endregion

        #region Điều chuyển nhân sự cửa hàng

        public ActionResult DieuChuyenNSCH()
        {
            try
            {
                if (Session["uid"] != null && Session["uid"].ToString().Length > 0)
                {
                    if (Session["ls_link_db"] != null)
                    {
                        List<backLink_DinhBien> ls_link_db = (List<backLink_DinhBien>)Session["ls_link_db"];

                        var roledb = ls_link_db.Where(s => s.backLink.ToLower().Contains("dieuchuyennsch")).ToList();
                        if (roledb.Count() > 0)
                        {
                            List<backLink_DinhBien> ls_stock = DataAccess.DataAccessHRM.SP_BBS_HRM_DinhBienPhanCa_backLink_get(Session["uid"].ToString());
                            Session["ls_stock"] = ls_stock;


                            if (ls_stock.Count > 0)
                            {
                                ViewBag.StoreId = roledb[0].E_SECTION_CODE;
                                ViewBag.StoreName = roledb[0].E_SECTION;
                            }
                            var lst_store = DataAccess.DataAccessHRM.SP_BBS_HRM_DinhBienPhanCa_getstore(Session["uid"].ToString());
                            ViewBag.lst_store = lst_store;
                            var lst_postision = DataAccess.DataAccessHRM.SP_BBS_HRM_DieuChuyenNSCH_getPostision(Session["uid"].ToString());
                            ViewBag.lst_postision = lst_postision;
                            var lst_province = DataAccess.DataAccessHRM.SP_BBS_HRM_DieuChuyenNSCH_getProvinceStore(Session["uid"].ToString());
                            ViewBag.lst_province = lst_province;

                            ViewBag.uid = Session["uid"];

                            return View();
                        }
                        else
                        {
                            return RedirectToAction("NoAccess");
                        }
                    }
                    else
                    {
                        return RedirectToAction("NoAccess");
                    }
                }
                else
                {
                    return RedirectToAction("Login", "Account");
                }
            }
            catch (Exception ex)
            {
                SystemFunctions.SaveSession("HRM", "DieuChuyenNSCH");
                DataAccess.LogBuild.CreateLogger(JsonConvert.SerializeObject(ex), "DieuChuyenNSCH");
                return RedirectToAction("Logout", "Account");
            }
        }

        public ActionResult GetLstDieuChuyenNSCH(string LoaiDieuChuyen, string Province, string Postision, string Store)
        {
            if (Session["uid"] != null && Session["uid"].ToString().Length > 0)
            {
                DataTable table = DataAccess.DataAccessHRM.SP_BBS_HRM_DieuChuyenNSCH_getlst(Session["uid"].ToString(), LoaiDieuChuyen, Province, Postision, Store);

                return PartialView("~/Views/HRM/Partial/__DieuChuyenNSCH.cshtml", table);

            }
            return RedirectToAction("Login", "Account");
        }

        public ActionResult GetLstDieuChuyenNSCHDetail(string LoaiDieuChuyen)
        {
            if (Session["uid"] != null && Session["uid"].ToString().Length > 0)
            {
                DataTable table = DataAccess.DataAccessHRM.SP_BBS_HRM_DieuChuyenNSCH_getlstDetails(Session["uid"].ToString(), LoaiDieuChuyen);

                return PartialView("~/Views/HRM/Partial/__DieuChuyenNSCHDetail.cshtml", table);

            }
            return RedirectToAction("Login", "Account");
        }

        [HttpPost]
        public ActionResult AddDieuChuyenNSCHDetail(List<AddDuyetDieuChuyenNSCH> lst)
        {
            try
            {
                if (Session["uid"] != null && Session["uid"].ToString().Length > 0)
                {
                    foreach (AddDuyetDieuChuyenNSCH po in lst)
                    {
                        DataAccess.DataAccessHRM.SP_BBS_HRM_DieuChuyenNSCH_Add(Session["uid"].ToString(), po.MaNVdc, po.MaCHnhan, po.TenCHnhan, po.ChucDanhnhan, po.SLThieu, po.LoaiDieuChuyen);
                    }
                    return Json(1);
                }
                return RedirectToAction("Login", "Account");
            }
            catch (Exception ex)
            {
                LogBuild.CreateLogger(JsonConvert.SerializeObject(ex), "AddDieuChuyenNSCHDetail");
                return Json(null);
            }
        }

        #endregion

        #region Danh sách điều chuyển nhân sự cửa hàng
        public ActionResult DSDieuChuyenNSCH()
        {
            if (Session["uid"] != null && Session["uid"].ToString().Length > 0)
            {
                if (!checkpermission("DSDieuChuyenNSCH")) return RedirectToAction("Index", "Home");

                var lst_storedc = DataAccess.DataAccessHRM.SP_BBS_HRM_DSDieuChuyenNSCH_getStoreChuyen(Session["uid"].ToString());
                ViewBag.lst_storedc = lst_storedc;
                var lst_storenhan = DataAccess.DataAccessHRM.SP_BBS_HRM_DSDieuChuyenNSCH_getStoreNhan(Session["uid"].ToString());
                ViewBag.lst_storenhan = lst_storenhan;
                var lst_user = DataAccess.DataAccessHRM.SP_BBS_HRM_DSDieuChuyenNSCH_getUser(Session["uid"].ToString());
                ViewBag.lst_user = lst_user;
                return View();
            }
            else
            {
                SystemFunctions.SaveSession("HRM", "DSDieuChuyenNSCH");
                return RedirectToAction("Login", "Account");
            }
        }

        public ActionResult GetLstDSDieuChuyenNSCH(string CHchuyen, string CHnhan, string NhanVien, string frDate, string toDate)
        {
            if (Session["uid"] != null && Session["uid"].ToString().Length > 0)
            {
                DataTable table = DataAccess.DataAccessHRM.SP_BBS_HRM_DSDieuChuyenNSCH_getlst(Session["uid"].ToString(), CHchuyen, CHnhan, NhanVien, frDate, toDate);

                return PartialView("~/Views/HRM/Partial/__DSDieuChuyenNSCH.cshtml", table);

            }
            return RedirectToAction("Login", "Account");
        }

        [HttpPost]
        public ActionResult UpdateDSDieuChuyenNSCH(List<UpdateDuyetDSDieuChuyenNSCH> lst)
        {
            try
            {
                if (Session["uid"] != null && Session["uid"].ToString().Length > 0)
                {
                    foreach (UpdateDuyetDSDieuChuyenNSCH po in lst)
                    {
                        DataAccess.DataAccessHRM.SP_BBS_HRM_DSDieuChuyenNSCH_Update(Session["uid"].ToString(), po.ID);
                    }
                    return Json(1);
                }
                return RedirectToAction("Login", "Account");
            }
            catch (Exception ex)
            {
                LogBuild.CreateLogger(JsonConvert.SerializeObject(ex), "UpdateDSDieuChuyenNSCH");
                return Json(null);
            }
        }

        #endregion
    }
}