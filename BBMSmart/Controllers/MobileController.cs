using Microsoft.Ajax.Utilities;
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
    public class MobileController : Controller
    {
        #region Test
        public ActionResult Mobile()
        {
            return View();
        }

        #endregion

        #region Test1
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

                var listca = DataAccess.DataAccessTT.CLV_Ca();
                ViewBag.listca = listca;

                var listLoaiNghi = DataAccess.DataAccessTT.CLV_LoaiNghi();
                ViewBag.listLoaiNghi = listLoaiNghi;

                var listbreaktypes = DataAccess.DataAccessTT.CLV_getListUser();
                ViewBag.listbreaktypes = listbreaktypes;

                var listNoilam = DataAccess.DataAccessTT.CLV_getListUser();
                ViewBag.listNoilam = listNoilam;

                return View();
            }
            else
            {
                SystemFunctions.SaveSession("Mobile", "RegisterShift");
                return RedirectToAction("Login", "Account");
            }
        }

        public ActionResult GetList(string TuNgay, string DenNgay, string NoiLam, string Ca)
        {
            if (Session["uid"] != null && Session["uid"].ToString().Length > 0)
            {
                DataTable table = DataAccess.DataAccessTT.CLV_GetList(Session["uid"].ToString(), TuNgay, DenNgay, NoiLam, Ca);

                return PartialView("~/Views/Mobile/Mb/_CalenderShift.cshtml", table);

            }
            return RedirectToAction("Login", "Account");
        }

        public ActionResult GetListNC1()
        {
            if (Session["uid"] != null && Session["uid"].ToString().Length > 0)
            {
                DataTable table = DataAccess.DataAccessTT.CLV_getListNC1(Session["uid"].ToString());

                return PartialView("~/Views/Mobile/Mb/_RegisterShift.cshtml", table);

            }
            return RedirectToAction("Login", "Account");
        }


        public ActionResult GetListNC2(string TenCH, string Ca)
        {
            if (Session["uid"] != null && Session["uid"].ToString().Length > 0)
            {
                DataTable table = DataAccess.DataAccessTT.CLV_getListNC2(Session["uid"].ToString(), TenCH, Ca);

                return PartialView("~/Views/Mobile/Mb/_SupportShift.cshtml", table);

            }
            return RedirectToAction("Login", "Account");
        }
        public ActionResult SetTrue(List<Xacnhan> lst)
        {
            try
            {
                if (Session["uid"] != null && Session["uid"].ToString().Length > 0)
                {
                    foreach (Xacnhan po in lst)
                    {
                        DataAccess.DataAccessTT.CLV_AddListNC(Session["uid"].ToString(), po.Ca);
                    }
                    return Json(1);
                }
                return RedirectToAction("Login", "Account");
            }
            catch (Exception ex)
            {
                LogBuild.CreateLogger(JsonConvert.SerializeObject(ex), "SetTrue");
                return Json(null);
            }
        }


        public ActionResult GetListDC(string TuNgay, string DenNgay)
        {
            if (Session["uid"] != null && Session["uid"].ToString().Length > 0)
            {
                DataTable table = DataAccess.DataAccessTT.CLV_getListDC(Session["uid"].ToString(), TuNgay, DenNgay);

                return PartialView("~/Views/Mobile/Mb/_SwitchShift.cshtml", table);

            }
            return RedirectToAction("Login", "Account");
        }

        public ActionResult GetListXN1(string TuNgay, string DenNgay)
        {
            if (Session["uid"] != null && Session["uid"].ToString().Length > 0)
            {
                DataTable table = DataAccess.DataAccessTT.CLV_getListXN1(Session["uid"].ToString(), TuNgay, DenNgay);

                return PartialView("~/Views/Mobile/Mb/_TakeABreakShift.cshtml", table);

            }
            return RedirectToAction("Login", "Account");
        }

        public ActionResult GetListDuyetNghi(string TuNgay, string DenNgay)
        {
            if (Session["uid"] != null && Session["uid"].ToString().Length > 0)
            {
                DataTable table = DataAccess.DataAccessTT.CLV_getListXN1(Session["uid"].ToString(), TuNgay, DenNgay);

                return PartialView("~/Views/Mobile/Mb/_AcceptTakeABreakShift.cshtml", table);

            }
            return RedirectToAction("Login", "Account");
        }


        #endregion
    }

}