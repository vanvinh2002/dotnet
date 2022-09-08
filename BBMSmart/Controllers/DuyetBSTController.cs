using ProductAllTool.Common;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace ProductAllTool.Controllers
{
    public class DuyetBSTController : Controller
    {
        // GET: DuyetBST
        public ActionResult DuyetBST()
        {
            if (Session["uid"] != null && Session["uid"].ToString().Length > 0)
            {
                var lst_MuaVu = DataAccess.DataAccessBST.cbo_MuaVu();
                ViewBag.lst_MuaVu = lst_MuaVu;
                var lst_NguonNhap = DataAccess.DataAccessBST.cbo_NguonNhap();
                ViewBag.lst_NguonNhap = lst_NguonNhap;
                var lst_Brand = DataAccess.DataAccessBST.cbo_Brand();
                ViewBag.lst_Brand = lst_Brand;
                var lst_RR = DataAccess.DataAccessBST.cbo_RR();
                ViewBag.lst_RR = lst_RR;
                var lst_Func = DataAccess.DataAccessBST.cbo_Func();
                ViewBag.lst_Func = lst_Func;
                var lst_Group = DataAccess.DataAccessBST.cbo_Group();
                ViewBag.lst_Group = lst_Group;
                var lst_Cate = DataAccess.DataAccessBST.cbo_Cate();
                ViewBag.lst_Cate = lst_Cate;

                return View();
            }
            else
            {
                SystemFunctions.SaveSession("DuyetBST", "DuyetBST");
                return RedirectToAction("Login", "Account");
            }
        }

        public ActionResult DataTableDBST(string Cate, string GroupCat, string Func, string RR, string Brand, string NguonNhap, string MuaVu)
        {
            if (Session["uid"] != null && Session["uid"].ToString().Length > 0)
            {
                DataTable table = DataAccess.DataAccessBST.BST_getListDuyet(Session["uid"].ToString(), Cate, GroupCat, Func, RR, Brand, NguonNhap, MuaVu);

                return PartialView("~/Views/DuyetBST/Table/__DuyetBST.cshtml", table);
            }
            return RedirectToAction("Login", "Account");
        }
    }
}