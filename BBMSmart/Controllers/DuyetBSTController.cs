using Newtonsoft.Json;
using ProductAllTool.Common;
using ProductAllTool.DataAccess;
using ProductAllTool.Models.DuyetBST;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Threading.Tasks;
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
                ViewBag.lst = new ListSP();
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

        public ActionResult BSTGetListDuyet1(string Cate, string GroupCat, string Func, string RR, string Brand, string NguonNhap, string MuaVu)
        {
            if (Session["uid"] != null && Session["uid"].ToString().Length > 0)
            {
                List<ListSP> lstSP = DataAccess.DataAccessBST.BST_getListDuyet1(Session["uid"].ToString(), Cate, GroupCat, Func, RR, Brand, NguonNhap, MuaVu);
                Console.WriteLine(lstSP);
                return Json(lstSP, JsonRequestBehavior.AllowGet);
            }
            return RedirectToAction("Login", "Account");
        }

        public ActionResult BSTGetNextAndPreviousSP(string Cate, string GroupCat, string Func, string RR, string Brand, string NguonNhap, string MuaVu, string mahang, string ID)
        {
            if (Session["uid"] != null && Session["uid"].ToString().Length > 0)
            {
                List<ListSP> lstSP = DataAccess.DataAccessBST.BST_GetNextAndPreviousSP(Session["uid"].ToString(), Cate, GroupCat, Func, RR, Brand, NguonNhap, MuaVu, mahang, ID);
                Console.WriteLine(lstSP);
                return Json(lstSP, JsonRequestBehavior.AllowGet);
            }
            return RedirectToAction("Login", "Account");
        }

        public ActionResult BSTGetNextSP(string Cate, string GroupCat, string Func, string RR, string Brand, string NguonNhap, string MuaVu, string mahang)
        {
            if (Session["uid"] != null && Session["uid"].ToString().Length > 0)
            {
                List<ListSP> lstSP = DataAccess.DataAccessBST.BST_getNextSP(Session["uid"].ToString(), Cate, GroupCat, Func, RR, Brand, NguonNhap, MuaVu, mahang);
                Console.WriteLine(lstSP);
                return Json(lstSP, JsonRequestBehavior.AllowGet);
            }
            return RedirectToAction("Login", "Account");
        }

        public ActionResult GetBST(string MaBST, string TenBST)
        {
            if (Session["uid"] != null && Session["uid"].ToString().Length > 0)
            {
                List<DuyetBST> lstBST = DataAccess.DataAccessBST.BST_GetBST(Session["uid"].ToString(), MaBST, TenBST);
                Console.WriteLine(lstBST);
                return Json(lstBST, JsonRequestBehavior.AllowGet);
            }
            return RedirectToAction("Login", "Account");
        }

        public ActionResult setDuyetBST(List<SetDuyetBST1> lst)
        {
            try
            {
                if (Session["uid"] != null && Session["uid"].ToString().Length > 0)
                {
                    foreach (SetDuyetBST1 po in lst)
                    {
                        DataAccess.DataAccessBST.BST_UpdateStatusCollect(Session["uid"].ToString(), po.type, po.Code);
                    }
                    return Json(1);
                }
                return RedirectToAction("Login", "Account");
            }
            catch (Exception ex)
            {
                LogBuild.CreateLogger(JsonConvert.SerializeObject(ex), "setDuyetBST");
                return Json(null);
            }
        }

        public ActionResult getSPDetail(List<ListSP> lst)
        {
            try
            {
                if (Session["uid"] != null && Session["uid"].ToString().Length > 0)
                {
                    foreach (ListSP po in lst)
                    {
                        DataAccess.DataAccessBST.BST_GetSPDetail(Session["uid"].ToString(), po.ID);
                    }
                    return Json(1);
                }
                return RedirectToAction("Login", "Account");
            }
            catch (Exception ex)
            {
                LogBuild.CreateLogger(JsonConvert.SerializeObject(ex), "getSPDetail");
                return Json(null);
            }
        }

        [HttpPost]
        public ActionResult setRUN(List<setRun> lst)
        {
            try
            {
                if (Session["uid"] != null && Session["uid"].ToString().Length > 0)
                {
                    foreach (setRun po in lst)
                    {
                        DataAccess.DataAccessBST.BST_SetRunCollect(Session["uid"].ToString(), po.Code, po.type);
                    }
                    return Json(1);
                }
                return RedirectToAction("Login", "Account");
            }
            catch (Exception ex)
            {
                LogBuild.CreateLogger(JsonConvert.SerializeObject(ex), "setRUN");
                return Json(null);
            }
        }

        //[HttpPost]
        //public ActionResult BSTCreateBST(List<addBST> info)
        //{
        //    try
        //    {
        //        if (Session["uid"] != null && Session["uid"].ToString().Length > 0)
        //        {
        //            foreach (addBST po in info)
        //            {
        //                DataAccess.DataAccessBST.BST_CreateBST(Session["uid"].ToString(), po.MaHang, po.TenHang, po.price, po.SLTon, po.imglink, po.catcode, po.catname);
        //            }
        //            return Json(1);
        //        }
        //        return RedirectToAction("Login", "Account");
        //    }
        //    catch (Exception ex)
        //    {
        //        LogBuild.CreateLogger(JsonConvert.SerializeObject(ex), "BSTCreateBST");
        //        return Json(null);
        //    }
        //}
        [HttpPost]
        public ActionResult BSTCreateBST(addBST lst)
        {
            try
            {
                string rs = DataAccess.DataAccessBST.BST_CreateBST(Session["uid"].ToString(), lst);

                return Json(new { result = rs });
            }
            catch (Exception ex)
            {
                return Json(new { result = ex.Message });
            }
        }

        [HttpPost]
        public ActionResult BST_updateSPP(List<UpdateSP> lst)
        {
            try
            {
                if (Session["uid"] != null && Session["uid"].ToString().Length > 0)
                {
                    foreach (UpdateSP po in lst)
                    {
                        DataAccess.DataAccessBST.BST_updateSP(Session["uid"].ToString(), po.ID, po.slcombo);
                    }
                    return Json(1);
                }
                return RedirectToAction("Login", "Account");
            }
            catch (Exception ex)
            {
                LogBuild.CreateLogger(JsonConvert.SerializeObject(ex), "BST_updateSPP");
                return Json(null);
            }
        }

        [HttpPost]
        public ActionResult BSTDeleteSP(List<UpdateSP> lst)
        {
            try
            {
                if (Session["uid"] != null && Session["uid"].ToString().Length > 0)
                {
                    foreach (UpdateSP po in lst)
                    {
                        DataAccess.DataAccessBST.BST_DeleteSP(Session["uid"].ToString(), po.ID);
                    }
                    return Json(1);
                }
                return RedirectToAction("Login", "Account");
            }
            catch (Exception ex)
            {
                LogBuild.CreateLogger(JsonConvert.SerializeObject(ex), "BSTDeleteSP");
                return Json(null);
            }
        }
    }
}