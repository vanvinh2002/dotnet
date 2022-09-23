using Lib.Utils.Package;
using Microsoft.AspNetCore.Authentication;
using MySql.Data.MySqlClient;
using Newtonsoft.Json;
using Newtonsoft.Json.Linq;
using NPOI.SS.Formula.Functions;
using ProductAllTool.DataAccess.DataConnection;
using ProductAllTool.Models;
using ProductAllTool.Models.comparePrice;
using ProductAllTool.Models.ScoreStore;
using ProductAllTool.Models.SourceProduct;
using ProductAllTool.Models.SpaceMan;
using ProductAllTool.Models.StoreLayout;
using ProductAllTool.Models.ToDoList;
using ProductAllTool.Models.ManageSales;
using ProductAllTool.Models.ManageUse;
using ProductAllTool.Views.ScoreStore;
using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data;
using System.Data.Common;
using System.Data.SqlClient;
using System.DirectoryServices.AccountManagement;
using System.Linq;
using System.Net.Http;
using System.Net.Mail;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Web;
using ProductAllTool.Models.Approve;
using ProductAllTool.Models.Po;
using ProductAllTool.Models.HRM;

namespace ProductAllTool.DataAccess
{
    public class DataAccessTT
    {
        private static string strCon = ConfigurationManager.AppSettings.Get("strConn");
        private static string strConn1101 = ConfigurationManager.AppSettings.Get("strConn1.101");
        private static string strConnDWH = ConfigurationManager.AppSettings.Get("strConnDWH");
        private static string strConntt = ConfigurationManager.AppSettings.Get("strConnTHUCTAP");
        private static string strConntt1 = ConfigurationManager.AppSettings.Get("strConnTHUCTAP");


        #region cài AR
        public static List<objCombox> sp_Brand()
        {
            List<objCombox> it_r = new List<objCombox>();
            using (var con = new SqlConnection(strConntt))
            {
                con.Open();
                try
                {
                    SqlCommand cmd = new SqlCommand("sp_Brand", con);
                    cmd.CommandType = CommandType.StoredProcedure;
                    cmd.CommandTimeout = 300;
                    var reader = cmd.ExecuteReader();

                    while (reader.Read())
                    {
                        objCombox it_ = new objCombox
                        {
                            Code = reader["Code"].ToString(),
                            Name = reader["Name"].ToString(),
                        };
                        it_r.Add(it_);
                    }
                    con.Close();
                    return it_r;
                }
                catch (Exception ex)
                {
                    con.Close();
                    LogBuild.CreateLogger(JsonConvert.SerializeObject(ex), "sp_Brand");
                    return it_r;
                }
            }
        }

        public static List<objCombox> AR_MaHang()
        {
            List<objCombox> it_r = new List<objCombox>();
            using (var con = new SqlConnection(strConntt1))
            {
                con.Open();
                try
                {
                    SqlCommand cmd = new SqlCommand("AR_MaHang", con);
                    cmd.CommandType = CommandType.StoredProcedure;
                    cmd.CommandTimeout = 300;
                    var reader = cmd.ExecuteReader();

                    while (reader.Read())
                    {
                        objCombox it_ = new objCombox
                        {
                            Code = reader["Code"].ToString(),
                            Name = reader["Name"].ToString(),
                        };
                        it_r.Add(it_);
                    }
                    con.Close();
                    return it_r;
                }
                catch (Exception ex)
                {
                    con.Close();
                    LogBuild.CreateLogger(JsonConvert.SerializeObject(ex), "AR_MaHang");
                    return it_r;
                }
            }
        }

        public static List<objCombox> AR_MIEN()
        {
            List<objCombox> it_r = new List<objCombox>();
            using (var con = new SqlConnection(strConntt1))
            {
                con.Open();
                try
                {
                    SqlCommand cmd = new SqlCommand("AR_MIEN", con);
                    cmd.CommandType = CommandType.StoredProcedure;
                    cmd.CommandTimeout = 300;
                    var reader = cmd.ExecuteReader();

                    while (reader.Read())
                    {
                        objCombox it_ = new objCombox
                        {
                            Code = reader["Code"].ToString(),
                            Name = reader["Name"].ToString(),
                        };
                        it_r.Add(it_);
                    }
                    con.Close();
                    return it_r;
                }
                catch (Exception ex)
                {
                    con.Close();
                    LogBuild.CreateLogger(JsonConvert.SerializeObject(ex), "AR_MIEN");
                    return it_r;
                }
            }
        }


        public static List<objCombox> AR_Tinh()
        {
            List<objCombox> it_r = new List<objCombox>();
            using (var con = new SqlConnection(strConntt1))
            {
                con.Open();
                try
                {
                    SqlCommand cmd = new SqlCommand("AR_Tinh", con);
                    cmd.CommandType = CommandType.StoredProcedure;
                    cmd.CommandTimeout = 300;
                    var reader = cmd.ExecuteReader();

                    while (reader.Read())
                    {
                        objCombox it_ = new objCombox
                        {
                            Code = reader["Code"].ToString(),
                            Name = reader["Name"].ToString(),
                        };
                        it_r.Add(it_);
                    }
                    con.Close();
                    return it_r;
                }
                catch (Exception ex)
                {
                    con.Close();
                    LogBuild.CreateLogger(JsonConvert.SerializeObject(ex), "AR_Tinh");
                    return it_r;
                }
            }
        }

        public static DataTable sp_getList(string userid, string brand, string mahang, string mien)
        {
            DataSet ds = new DataSet();
            try
            {
                using (var con = new SqlConnection(strConntt1))
                {
                    con.Open();
                    SqlCommand cmd = new SqlCommand("sp_getList", con);
                    cmd.CommandType = CommandType.StoredProcedure;
                    cmd.CommandTimeout = 30000;
                    cmd.Parameters.Add(new SqlParameter("userid", userid));
                    cmd.Parameters.Add(new SqlParameter("brand", brand));
                    cmd.Parameters.Add(new SqlParameter("mahang", mahang));
                    cmd.Parameters.Add(new SqlParameter("mien", mien));

                    using (SqlDataAdapter sda = new SqlDataAdapter(cmd))
                    { sda.Fill(ds); }

                    con.Close();
                    return ds.Tables[0];
                }
            }
            catch (Exception ex)
            {
                LogBuild.CreateLogger(JsonConvert.SerializeObject(ex), "sp_getList");
                return ds.Tables[0];
            }
        }

        public static int sp_lydo_update(string userid, int ID, string LyDo)
        {
            DataSet ds = new DataSet();
            try
            {
                using (var con = new SqlConnection(strConntt))
                {
                    con.Open();
                    SqlCommand cmd = new SqlCommand("sp_lydo_update", con);
                    cmd.CommandType = CommandType.StoredProcedure;
                    cmd.CommandTimeout = 3000;
                    cmd.Parameters.Add(new SqlParameter("userid", userid));
                    cmd.Parameters.Add(new SqlParameter("ID", ID));
                    cmd.Parameters.Add(new SqlParameter("LyDo", LyDo));
                    cmd.ExecuteNonQuery();

                    con.Close();
                    return 1;
                }
            }
            catch (Exception ex)
            {
                LogBuild.CreateLogger(JsonConvert.SerializeObject(ex), "sp_lydo_update");
                return 0;
            }
        }
        public static int cbo_updateSL(string userid, int ID, string slcombo)
        {
            DataSet ds = new DataSet();
            try
            {
                using (var con = new SqlConnection(strConntt))
                {
                    con.Open();
                    SqlCommand cmd = new SqlCommand("cbo_updateSL", con);
                    cmd.CommandType = CommandType.StoredProcedure;
                    cmd.CommandTimeout = 3000;
                    cmd.Parameters.Add(new SqlParameter("userid", userid));
                    cmd.Parameters.Add(new SqlParameter("ID", ID));
                    cmd.Parameters.Add(new SqlParameter("slcombo", slcombo));
                    cmd.ExecuteNonQuery();

                    con.Close();
                    return 1;
                }
            }
            catch (Exception ex)
            {
                LogBuild.CreateLogger(JsonConvert.SerializeObject(ex), "cbo_updateSL");
                return 0;
            }
        }
        public static int BST_CreateBST(string userid, addBST lst)
        {
            try
            {
                using (var con = new SqlConnection(strConntt))
                {
                    con.Open();
                    SqlCommand cmd = new SqlCommand("BST_CreateBST", con);
                    cmd.CommandType = CommandType.StoredProcedure;

                    cmd.Parameters.Add(new SqlParameter("userid", userid));
                    cmd.Parameters.Add(new SqlParameter("code", lst.Code));
                    cmd.Parameters.Add(new SqlParameter("name", lst.Name));
                    cmd.Parameters.Add(new SqlParameter("MaHang", lst.MaHang));
                    cmd.Parameters.Add(new SqlParameter("TenHang", lst.TenHang));
                    cmd.Parameters.Add(new SqlParameter("price", lst.price));
                    cmd.Parameters.Add(new SqlParameter("imglink", lst.imglink));
                    cmd.Parameters.Add(new SqlParameter("slcombo", lst.slcombo));
                    cmd.Parameters.Add(new SqlParameter("catcode", lst.catcode));

                    var reader = cmd.ExecuteNonQuery();

                    con.Close();

                    return 1;
                }
            }
            catch (Exception ex)
            {
                LogBuild.CreateLogger(JsonConvert.SerializeObject(ex), "BST_CreateBST");
                return 0;
            }
        }

        public static List<objCombox> cbo_Cate()
        {
            List<objCombox> it_r = new List<objCombox>();
            using (var con = new SqlConnection(strConntt))
            {
                con.Open();
                try
                {
                    SqlCommand cmd = new SqlCommand("cbo_Cate", con);
                    cmd.CommandType = CommandType.StoredProcedure;
                    cmd.CommandTimeout = 300;
                    var reader = cmd.ExecuteReader();

                    while (reader.Read())
                    {
                        objCombox it_ = new objCombox
                        {
                            Code = reader["Code"].ToString(),
                            Name = reader["Name"].ToString(),
                        };
                        it_r.Add(it_);
                    }
                    con.Close();
                    return it_r;
                }
                catch (Exception ex)
                {
                    con.Close();
                    LogBuild.CreateLogger(JsonConvert.SerializeObject(ex), "cbo_Cate");
                    return it_r;
                }
            }
        }
        #endregion
        public static List<objCombox> cbo_Group()
        {
            List<objCombox> it_r = new List<objCombox>();
            using (var con = new SqlConnection(strConntt))
            {
                con.Open();
                try
                {
                    SqlCommand cmd = new SqlCommand("cbo_Group", con);
                    cmd.CommandType = CommandType.StoredProcedure;
                    cmd.CommandTimeout = 300;
                    var reader = cmd.ExecuteReader();

                    while (reader.Read())
                    {
                        objCombox it_ = new objCombox
                        {
                            Code = reader["Code"].ToString(),
                            Name = reader["Name"].ToString(),
                        };
                        it_r.Add(it_);
                    }
                    con.Close();
                    return it_r;
                }
                catch (Exception ex)
                {
                    con.Close();
                    LogBuild.CreateLogger(JsonConvert.SerializeObject(ex), "cbo_Group");
                    return it_r;
                }
            }
        }

        public static List<objCombox> cbo_Func()
        {
            List<objCombox> it_r = new List<objCombox>();
            using (var con = new SqlConnection(strConntt))
            {
                con.Open();
                try
                {
                    SqlCommand cmd = new SqlCommand("cbo_Func", con);
                    cmd.CommandType = CommandType.StoredProcedure;
                    cmd.CommandTimeout = 300;
                    var reader = cmd.ExecuteReader();

                    while (reader.Read())
                    {
                        objCombox it_ = new objCombox
                        {
                            Code = reader["Code"].ToString(),
                            Name = reader["Name"].ToString(),
                        };
                        it_r.Add(it_);
                    }
                    con.Close();
                    return it_r;
                }
                catch (Exception ex)
                {
                    con.Close();
                    LogBuild.CreateLogger(JsonConvert.SerializeObject(ex), "cbo_Func");
                    return it_r;
                }
            }
        }

        public static List<objCombox> cbo_RR()
        {
            List<objCombox> it_r = new List<objCombox>();
            using (var con = new SqlConnection(strConntt))
            {
                con.Open();
                try
                {
                    SqlCommand cmd = new SqlCommand("cbo_RR", con);
                    cmd.CommandType = CommandType.StoredProcedure;
                    cmd.CommandTimeout = 300;
                    var reader = cmd.ExecuteReader();

                    while (reader.Read())
                    {
                        objCombox it_ = new objCombox
                        {
                            Code = reader["Code"].ToString(),
                            Name = reader["Name"].ToString(),
                        };
                        it_r.Add(it_);
                    }
                    con.Close();
                    return it_r;
                }
                catch (Exception ex)
                {
                    con.Close();
                    LogBuild.CreateLogger(JsonConvert.SerializeObject(ex), "cbo_RR");
                    return it_r;
                }
            }
        }
        public static List<objCombox> cbo_Brand()
        {
            List<objCombox> it_r = new List<objCombox>();
            using (var con = new SqlConnection(strConntt))
            {
                con.Open();
                try
                {
                    SqlCommand cmd = new SqlCommand("cbo_Brand", con);
                    cmd.CommandType = CommandType.StoredProcedure;
                    cmd.CommandTimeout = 300;
                    var reader = cmd.ExecuteReader();

                    while (reader.Read())
                    {
                        objCombox it_ = new objCombox
                        {
                            Code = reader["Code"].ToString(),
                            Name = reader["Name"].ToString(),
                        };
                        it_r.Add(it_);
                    }
                    con.Close();
                    return it_r;
                }
                catch (Exception ex)
                {
                    con.Close();
                    LogBuild.CreateLogger(JsonConvert.SerializeObject(ex), "cbo_Brand");
                    return it_r;
                }
            }
        }
        public static List<objCombox> cbo_NguonNhap()
        {
            List<objCombox> it_r = new List<objCombox>();
            using (var con = new SqlConnection(strConntt))
            {
                con.Open();
                try
                {
                    SqlCommand cmd = new SqlCommand("cbo_NguonNhap", con);
                    cmd.CommandType = CommandType.StoredProcedure;
                    cmd.CommandTimeout = 300;
                    var reader = cmd.ExecuteReader();

                    while (reader.Read())
                    {
                        objCombox it_ = new objCombox
                        {
                            Code = reader["Code"].ToString(),
                            Name = reader["Name"].ToString(),
                        };
                        it_r.Add(it_);
                    }
                    con.Close();
                    return it_r;
                }
                catch (Exception ex)
                {
                    con.Close();
                    LogBuild.CreateLogger(JsonConvert.SerializeObject(ex), "cbo_NguonNhap");
                    return it_r;
                }
            }
        }
        public static List<objCombox> cbo_MuaVu()
        {
            List<objCombox> it_r = new List<objCombox>();
            using (var con = new SqlConnection(strConntt))
            {
                con.Open();
                try
                {
                    SqlCommand cmd = new SqlCommand("cbo_MuaVu", con);
                    cmd.CommandType = CommandType.StoredProcedure;
                    cmd.CommandTimeout = 300;
                    var reader = cmd.ExecuteReader();

                    while (reader.Read())
                    {
                        objCombox it_ = new objCombox
                        {
                            Code = reader["Code"].ToString(),
                            Name = reader["Name"].ToString(),
                        };
                        it_r.Add(it_);
                    }
                    con.Close();
                    return it_r;
                }
                catch (Exception ex)
                {
                    con.Close();
                    LogBuild.CreateLogger(JsonConvert.SerializeObject(ex), "cbo_MuaVu");
                    return it_r;
                }
            }
        }

        public static DataTable cbo_Bang(string userid, string Category, string Group)
        {
            DataSet ds = new DataSet();
            try
            {
                using (var con = new SqlConnection(strConntt1))
                {
                    con.Open();
                    SqlCommand cmd = new SqlCommand("cbo_Bang", con);
                    cmd.CommandType = CommandType.StoredProcedure;
                    cmd.CommandTimeout = 30000;
                    cmd.Parameters.Add(new SqlParameter("userid", userid));
                    cmd.Parameters.Add(new SqlParameter("Category", Category));
                    cmd.Parameters.Add(new SqlParameter("Group", Group));

                    using (SqlDataAdapter sda = new SqlDataAdapter(cmd))
                    { sda.Fill(ds); }

                    con.Close();
                    return ds.Tables[0];
                }
            }
            catch (Exception ex)
            {
                LogBuild.CreateLogger(JsonConvert.SerializeObject(ex), "cbo_Bang");
                return ds.Tables[0];
            }
        }

        public static List<ThongTinBST> TK_BSTT(string userid, string MaBST, string TenBST)
        {
            List<ThongTinBST> it_r = new List<ThongTinBST>();
            using (var con = new SqlConnection(strConntt))
            {
                con.Open();
                try
                {
                    SqlCommand cmd = new SqlCommand("TK_BSTT", con);
                    cmd.CommandType = CommandType.StoredProcedure;
                    cmd.Parameters.Add(new SqlParameter("userid", userid));
                    cmd.Parameters.Add(new SqlParameter("MaBST", MaBST));
                    cmd.Parameters.Add(new SqlParameter("TenBST", TenBST));
                    var reader = cmd.ExecuteReader();

                    while (reader.Read())
                    {
                        ThongTinBST it_ = new ThongTinBST
                        {
                            Code = reader["Code"].ToString(),
                            Name = reader["Name"].ToString(),
                            Category = reader["Category"].ToString(),
                            MuaVu = reader["MuaVu"].ToString(),
                            DoiTuong = reader["DoiTuong"].ToString(),
                            GioiTinh = reader["GioiTinh"].ToString(),
                            ThuNhap = reader["ThuNhap"].ToString(),
                            USP = reader["USP"].ToString(),
                            ThongDiep = reader["ThongDiep"].ToString(),
                        };
                        it_r.Add(it_);
                    }
                    con.Close();
                    return it_r;
                }
                catch (Exception ex)
                {
                    con.Close();
                    LogBuild.CreateLogger(JsonConvert.SerializeObject(ex), "TK_BSTT");
                    return it_r;
                }
            }
        }

        public static List<getIMG> cbo_getListIMG(string userid, string Function, string RangeRieview, string Band, string NguonNhap, string MuaVu)
        {
            List<getIMG> it_r = new List<getIMG>();
            using (var con = new SqlConnection(strConntt))
            {
                con.Open();
                try
                {
                    SqlCommand cmd = new SqlCommand("cbo_getListIMG", con);
                    cmd.CommandType = CommandType.StoredProcedure;
                    cmd.Parameters.Add(new SqlParameter("userid", userid));
                    cmd.Parameters.Add(new SqlParameter("Function", Function));
                    cmd.Parameters.Add(new SqlParameter("RangeRieview", RangeRieview));
                    cmd.Parameters.Add(new SqlParameter("Band", Band));
                    cmd.Parameters.Add(new SqlParameter("NguonNhap", NguonNhap));
                    cmd.Parameters.Add(new SqlParameter("MuaVu", MuaVu));
                    var reader = cmd.ExecuteReader();

                    while (reader.Read())
                    {
                        getIMG it_ = new getIMG
                        {
                            Code = reader["Code"].ToString(),
                            Name = reader["Name"].ToString(),
                            hinhanh = reader["hinhanh"].ToString(),
                            giabanall = reader["giabanall"].ToString(),
                            slton = reader["slton"].ToString(),
                        };
                        it_r.Add(it_);
                    }
                    con.Close();
                    return it_r;
                }
                catch (Exception ex)
                {
                    con.Close();
                    LogBuild.CreateLogger(JsonConvert.SerializeObject(ex), "cbo_getListIMG");
                    return it_r;
                }
            }
        }

        public static List<getIMG> cbo_listcollect(string userid, string mahang)
        {
            List<getIMG> it_r = new List<getIMG>();
            using (var con = new SqlConnection(strConntt))
            {
                con.Open();
                try
                {
                    SqlCommand cmd = new SqlCommand("cbo_listcollect", con);
                    cmd.CommandType = CommandType.StoredProcedure;
                    cmd.Parameters.Add(new SqlParameter("userid", userid));
                    cmd.Parameters.Add(new SqlParameter("mahang", mahang));
                    var reader = cmd.ExecuteReader();

                    while (reader.Read())
                    {
                        getIMG it_ = new getIMG
                        {
                            Code = reader["Code"].ToString(),
                            Name = reader["Name"].ToString(),
                            hinhanh = reader["hinhanh"].ToString(),
                            giabanall = reader["giabanall"].ToString(),
                            slton = reader["slton"].ToString(),
                        };
                        it_r.Add(it_);
                    }
                    con.Close();
                    return it_r;
                }
                catch (Exception ex)
                {
                    con.Close();
                    LogBuild.CreateLogger(JsonConvert.SerializeObject(ex), "cbo_listcollect");
                    return it_r;
                }
            }
        }

        #region Mobile
        public static List<objCombox> CLV_Ca()
        {
            List<objCombox> it_r = new List<objCombox>();
            using (var con = new SqlConnection(strConntt))
            {
                con.Open();
                try
                {
                    SqlCommand cmd = new SqlCommand("CLV_Ca", con);
                    cmd.CommandType = CommandType.StoredProcedure;
                    cmd.CommandTimeout = 300;
                    var reader = cmd.ExecuteReader();

                    while (reader.Read())
                    {
                        objCombox it_ = new objCombox
                        {
                            Code = reader["Code"].ToString(),
                            Name = reader["Name"].ToString(),
                        };
                        it_r.Add(it_);
                    }
                    con.Close();
                    return it_r;
                }
                catch (Exception ex)
                {
                    con.Close();
                    LogBuild.CreateLogger(JsonConvert.SerializeObject(ex), "CLV_Ca");
                    return it_r;
                }
            }
        }
        public static List<objCombox> CLV_NoiLam()
        {
            List<objCombox> it_r = new List<objCombox>();
            using (var con = new SqlConnection(strConntt))
            {
                con.Open();
                try
                {
                    SqlCommand cmd = new SqlCommand("CLV_NoiLam", con);
                    cmd.CommandType = CommandType.StoredProcedure;
                    cmd.CommandTimeout = 300;
                    var reader = cmd.ExecuteReader();

                    while (reader.Read())
                    {
                        objCombox it_ = new objCombox
                        {
                            Code = reader["Code"].ToString(),
                            Name = reader["Name"].ToString(),
                        };
                        it_r.Add(it_);
                    }
                    con.Close();
                    return it_r;
                }
                catch (Exception ex)
                {
                    con.Close();
                    LogBuild.CreateLogger(JsonConvert.SerializeObject(ex), "CLV_NoiLam");
                    return it_r;
                }
            }
        }
        public static DataTable CLV_GetList(string userid, string TuNgay, string DenNgay, string Ca, string NoiLam)
        {
            DataSet ds = new DataSet();
            try
            {
                using (var con = new SqlConnection(strConntt1))
                {
                    con.Open();
                    SqlCommand cmd = new SqlCommand("CLV_GetList", con);
                    cmd.CommandType = CommandType.StoredProcedure;
                    cmd.CommandTimeout = 30000;
                    cmd.Parameters.Add(new SqlParameter("userid", userid));
                    if (String.IsNullOrWhiteSpace(TuNgay))
                    {
                        cmd.Parameters.Add(new SqlParameter("TuNgay", DBNull.Value));
                    }
                    else
                    {
                        cmd.Parameters.Add(new SqlParameter("TuNgay", DateTime.Parse(TuNgay)));
                    }
                    if (String.IsNullOrWhiteSpace(DenNgay))
                    {
                        cmd.Parameters.Add(new SqlParameter("DenNgay", DBNull.Value));
                    }
                    else
                    {
                        cmd.Parameters.Add(new SqlParameter("DenNgay", DateTime.Parse(DenNgay)));
                    }
                    cmd.Parameters.Add(new SqlParameter("Ca", Ca));
                    cmd.Parameters.Add(new SqlParameter("NoiLam", NoiLam));

                    using (SqlDataAdapter sda = new SqlDataAdapter(cmd))
                    { sda.Fill(ds); }

                    con.Close();
                    return ds.Tables[0];
                }
            }
            catch (Exception ex)
            {
                LogBuild.CreateLogger(JsonConvert.SerializeObject(ex), "CLV_GetList");
                return ds.Tables[0];
            }
        }
        public static List<objCombox> CLV_CuaHang()
        {
            List<objCombox> it_r = new List<objCombox>();
            using (var con = new SqlConnection(strConntt))
            {
                con.Open();
                try
                {
                    SqlCommand cmd = new SqlCommand("CLV_CuaHang", con);
                    cmd.CommandType = CommandType.StoredProcedure;
                    cmd.CommandTimeout = 300;
                    var reader = cmd.ExecuteReader();

                    while (reader.Read())
                    {
                        objCombox it_ = new objCombox
                        {
                            Code = reader["Code"].ToString(),
                            Name = reader["Name"].ToString(),
                        };
                        it_r.Add(it_);
                    }
                    con.Close();
                    return it_r;
                }
                catch (Exception ex)
                {
                    con.Close();
                    LogBuild.CreateLogger(JsonConvert.SerializeObject(ex), "CLV_CuaHang");
                    return it_r;
                }
            }
        }
        public static DataTable CLV_getListNC1(string userid)
        {
            DataSet ds = new DataSet();
            try
            {
                using (var con = new SqlConnection(strConntt1))
                {
                    con.Open();
                    SqlCommand cmd = new SqlCommand("CLV_getListNC1", con);
                    cmd.CommandType = CommandType.StoredProcedure;
                    cmd.CommandTimeout = 30000;
                    cmd.Parameters.Add(new SqlParameter("userid", userid));

                    using (SqlDataAdapter sda = new SqlDataAdapter(cmd))
                    { sda.Fill(ds); }

                    con.Close();
                    return ds.Tables[0];
                }
            }
            catch (Exception ex)
            {
                LogBuild.CreateLogger(JsonConvert.SerializeObject(ex), "CLV_getListNC1");
                return ds.Tables[0];
            }
        }

        public static int CLV_setTT(string userid, string Ca, string type)
        {
            DataSet ds = new DataSet();
            try
            {
                using (var con = new SqlConnection(strConntt))
                {
                    con.Open();
                    SqlCommand cmd = new SqlCommand("CLV_setTT", con);
                    cmd.CommandType = CommandType.StoredProcedure;
                    cmd.CommandTimeout = 3000;
                    cmd.Parameters.Add(new SqlParameter("userid", userid));
                    cmd.Parameters.Add(new SqlParameter("Ca", Ca));
                    cmd.Parameters.Add(new SqlParameter("type", type));
                    cmd.ExecuteNonQuery();

                    con.Close();
                    return 1;
                }
            }
            catch (Exception ex)
            {
                LogBuild.CreateLogger(JsonConvert.SerializeObject(ex), "CLV_setTT");
                return 0;
            }
        }
        public static int CLV_ADD(string userid, string MaNV, string TenNV, string ChucDanh, string BoPhan, string TenPB, string NgayBD, string NgayKT, string NgayLamLai, string LoaiCa, string LoaiNghi, string LyDoNghi, string SoGioNghi)
        {
            DataSet ds = new DataSet();
            try
            {
                using (var con = new SqlConnection(strConntt))
                {
                    con.Open();
                    SqlCommand cmd = new SqlCommand("CLV_ADD", con);
                    cmd.CommandType = CommandType.StoredProcedure;
                    cmd.CommandTimeout = 3000;
                    cmd.Parameters.Add(new SqlParameter("userid", userid));
                    cmd.Parameters.Add(new SqlParameter("MaNV", MaNV));
                    cmd.Parameters.Add(new SqlParameter("TenNV", TenNV));
                    cmd.Parameters.Add(new SqlParameter("ChucDanh", ChucDanh));
                    cmd.Parameters.Add(new SqlParameter("BoPhan", BoPhan));
                    cmd.Parameters.Add(new SqlParameter("TenPB", TenPB));
                    cmd.Parameters.Add(new SqlParameter("NgayBD", NgayBD));
                    cmd.Parameters.Add(new SqlParameter("NgayKT", NgayKT));
                    cmd.Parameters.Add(new SqlParameter("NgayLamLai", NgayLamLai));
                    cmd.Parameters.Add(new SqlParameter("LoaiCa", LoaiCa));
                    cmd.Parameters.Add(new SqlParameter("LoaiNghi", LoaiNghi));
                    cmd.Parameters.Add(new SqlParameter("LyDoNghi", LyDoNghi));
                    cmd.Parameters.Add(new SqlParameter("SoGioNghi", SoGioNghi));
                    cmd.ExecuteNonQuery();

                    con.Close();
                    return 1;
                }
            }
            catch (Exception ex)
            {
                LogBuild.CreateLogger(JsonConvert.SerializeObject(ex), "CLV_ADD");
                return 0;
            }
        }
        public static DataTable CLV_getListNC2(string userid, string TenCH, string Ca)
        {
            DataSet ds = new DataSet();
            try
            {
                using (var con = new SqlConnection(strConntt1))
                {
                    con.Open();
                    SqlCommand cmd = new SqlCommand("CLV_getListNC2", con);
                    cmd.CommandType = CommandType.StoredProcedure;
                    cmd.CommandTimeout = 30000;
                    cmd.Parameters.Add(new SqlParameter("userid", userid));
                    cmd.Parameters.Add(new SqlParameter("TenCH", TenCH));
                    cmd.Parameters.Add(new SqlParameter("Ca", Ca));

                    using (SqlDataAdapter sda = new SqlDataAdapter(cmd))
                    { sda.Fill(ds); }

                    con.Close();
                    return ds.Tables[0];
                }
            }
            catch (Exception ex)
            {
                LogBuild.CreateLogger(JsonConvert.SerializeObject(ex), "CLV_getListNC2");
                return ds.Tables[0];
            }
        }
        public static DataTable CLV_getListDC(string userid, string TuNgay, string DenNgay)
        {
            DataSet ds = new DataSet();
            try
            {
                using (var con = new SqlConnection(strConntt1))
                {
                    con.Open();
                    SqlCommand cmd = new SqlCommand("CLV_getListDC", con);
                    cmd.CommandType = CommandType.StoredProcedure;
                    cmd.CommandTimeout = 30000;
                    cmd.Parameters.Add(new SqlParameter("userid", userid));
                    if (String.IsNullOrWhiteSpace(TuNgay))
                    {
                        cmd.Parameters.Add(new SqlParameter("TuNgay", DBNull.Value));
                    }
                    else
                    {
                        cmd.Parameters.Add(new SqlParameter("TuNgay", DateTime.Parse(TuNgay)));
                    }
                    if (String.IsNullOrWhiteSpace(DenNgay))
                    {
                        cmd.Parameters.Add(new SqlParameter("DenNgay", DBNull.Value));
                    }
                    else
                    {
                        cmd.Parameters.Add(new SqlParameter("DenNgay", DateTime.Parse(DenNgay)));
                    }

                    using (SqlDataAdapter sda = new SqlDataAdapter(cmd))
                    { sda.Fill(ds); }

                    con.Close();
                    return ds.Tables[0];
                }
            }
            catch (Exception ex)
            {
                LogBuild.CreateLogger(JsonConvert.SerializeObject(ex), "CLV_getListDC");
                return ds.Tables[0];
            }
        }
        public static List<ThongTinNV4> CLV_TTNV4(string userid)
        {
            List<ThongTinNV4> it_r = new List<ThongTinNV4>();
            using (var con = new SqlConnection(strConntt))
            {
                con.Open();
                try
                {
                    SqlCommand cmd = new SqlCommand("CLV_TTNV4", con);
                    cmd.CommandType = CommandType.StoredProcedure;
                    cmd.Parameters.Add(new SqlParameter("userid", userid));
                    var reader = cmd.ExecuteReader();

                    while (reader.Read())
                    {
                        ThongTinNV4 it_ = new ThongTinNV4
                        {
                            MaNv = reader["MaNv"].ToString(),
                            TenNv = reader["TenNv"].ToString(),
                            ChucDanh = reader["ChucDanh"].ToString(),
                            BoPhan = reader["BoPhan"].ToString(),
                            NoiLam = reader["NoiLam"].ToString(),
                            TenPB = reader["TenPB"].ToString(),
                        };
                        it_r.Add(it_);
                    }
                    con.Close();
                    return it_r;
                }
                catch (Exception ex)
                {
                    con.Close();
                    LogBuild.CreateLogger(JsonConvert.SerializeObject(ex), "CLV_TTNV4");
                    return it_r;
                }
            }
        }
        public static List<objCombox> CLV_LoaiNghi()
        {
            List<objCombox> it_r = new List<objCombox>();
            using (var con = new SqlConnection(strConntt))
            {
                con.Open();
                try
                {
                    SqlCommand cmd = new SqlCommand("CLV_LoaiNghi", con);
                    cmd.CommandType = CommandType.StoredProcedure;
                    cmd.CommandTimeout = 300;
                    var reader = cmd.ExecuteReader();

                    while (reader.Read())
                    {
                        objCombox it_ = new objCombox
                        {
                            Code = reader["Code"].ToString(),
                            Name = reader["Name"].ToString(),
                        };
                        it_r.Add(it_);
                    }
                    con.Close();
                    return it_r;
                }
                catch (Exception ex)
                {
                    con.Close();
                    LogBuild.CreateLogger(JsonConvert.SerializeObject(ex), "CLV_LoaiNghi");
                    return it_r;
                }
            }
        }

        public static DataTable CLV_getListXN1(string userid, string TuNgay, string DenNgay)
        {
            DataSet ds = new DataSet();
            try
            {
                using (var con = new SqlConnection(strConntt1))
                {
                    con.Open();
                    SqlCommand cmd = new SqlCommand("CLV_getListXN1", con);
                    cmd.CommandType = CommandType.StoredProcedure;
                    cmd.CommandTimeout = 30000;
                    cmd.Parameters.Add(new SqlParameter("userid", userid));
                    if (String.IsNullOrWhiteSpace(TuNgay))
                    {
                        cmd.Parameters.Add(new SqlParameter("TuNgay", DBNull.Value));
                    }
                    else
                    {
                        cmd.Parameters.Add(new SqlParameter("TuNgay", DateTime.Parse(TuNgay)));
                    }
                    if (String.IsNullOrWhiteSpace(DenNgay))
                    {
                        cmd.Parameters.Add(new SqlParameter("DenNgay", DBNull.Value));
                    }
                    else
                    {
                        cmd.Parameters.Add(new SqlParameter("DenNgay", DateTime.Parse(DenNgay)));
                    }

                    using (SqlDataAdapter sda = new SqlDataAdapter(cmd))
                    { sda.Fill(ds); }

                    con.Close();
                    return ds.Tables[0];
                }
            }
            catch (Exception ex)
            {
                LogBuild.CreateLogger(JsonConvert.SerializeObject(ex), "CLV_getListXN1");
                return ds.Tables[0];
            }
        }
        #endregion


        #region Test
        public static List<objCombox> Test_Category()
        {
            List<objCombox> it_r = new List<objCombox>();
            using (var con = new SqlConnection(strConntt))
            {
                con.Open();
                try
                {
                    SqlCommand cmd = new SqlCommand("Test_Category", con);
                    cmd.CommandType = CommandType.StoredProcedure;
                    cmd.CommandTimeout = 300;
                    var reader = cmd.ExecuteReader();

                    while (reader.Read())
                    {
                        objCombox it_ = new objCombox
                        {
                            Code = reader["Code"].ToString(),
                            Name = reader["Name"].ToString(),
                        };
                        it_r.Add(it_);
                    }
                    con.Close();
                    return it_r;
                }
                catch (Exception ex)
                {
                    con.Close();
                    LogBuild.CreateLogger(JsonConvert.SerializeObject(ex), "Test_Category");
                    return it_r;
                }
            }
        }
        public static List<objCombox> Test_Brand()
        {
            List<objCombox> it_r = new List<objCombox>();
            using (var con = new SqlConnection(strConntt))
            {
                con.Open();
                try
                {
                    SqlCommand cmd = new SqlCommand("Test_Brand", con);
                    cmd.CommandType = CommandType.StoredProcedure;
                    cmd.CommandTimeout = 300;
                    var reader = cmd.ExecuteReader();

                    while (reader.Read())
                    {
                        objCombox it_ = new objCombox
                        {
                            Code = reader["Code"].ToString(),
                            Name = reader["Name"].ToString(),
                        };
                        it_r.Add(it_);
                    }
                    con.Close();
                    return it_r;
                }
                catch (Exception ex)
                {
                    con.Close();
                    LogBuild.CreateLogger(JsonConvert.SerializeObject(ex), "Test_Brand");
                    return it_r;
                }
            }
        }
        public static List<objCombox> Test_Function()
        {
            List<objCombox> it_r = new List<objCombox>();
            using (var con = new SqlConnection(strConntt))
            {
                con.Open();
                try
                {
                    SqlCommand cmd = new SqlCommand("Test_Function", con);
                    cmd.CommandType = CommandType.StoredProcedure;
                    cmd.CommandTimeout = 300;
                    var reader = cmd.ExecuteReader();

                    while (reader.Read())
                    {
                        objCombox it_ = new objCombox
                        {
                            Code = reader["Code"].ToString(),
                            Name = reader["Name"].ToString(),
                        };
                        it_r.Add(it_);
                    }
                    con.Close();
                    return it_r;
                }
                catch (Exception ex)
                {
                    con.Close();
                    LogBuild.CreateLogger(JsonConvert.SerializeObject(ex), "Test_Function");
                    return it_r;
                }
            }
        }
        public static List<objCombox> Test_MaHang()
        {
            List<objCombox> it_r = new List<objCombox>();
            using (var con = new SqlConnection(strConntt))
            {
                con.Open();
                try
                {
                    SqlCommand cmd = new SqlCommand("Test_MaHang", con);
                    cmd.CommandType = CommandType.StoredProcedure;
                    cmd.CommandTimeout = 300;
                    var reader = cmd.ExecuteReader();

                    while (reader.Read())
                    {
                        objCombox it_ = new objCombox
                        {
                            Code = reader["Code"].ToString(),
                            Name = reader["Name"].ToString(),
                        };
                        it_r.Add(it_);
                    }
                    con.Close();
                    return it_r;
                }
                catch (Exception ex)
                {
                    con.Close();
                    LogBuild.CreateLogger(JsonConvert.SerializeObject(ex), "Test_MaHang");
                    return it_r;
                }
            }
        }
        public static DataTable Test_Bang(string userid, string Category, string Function, string Brand, string MaHang)
        {
            DataSet ds = new DataSet();
            try
            {
                using (var con = new SqlConnection(strConntt))
                {
                    con.Open();
                    SqlCommand cmd = new SqlCommand("Test_Bang", con);
                    cmd.CommandType = CommandType.StoredProcedure;
                    cmd.CommandTimeout = 30000;
                    cmd.Parameters.Add(new SqlParameter("userid", userid));
                    cmd.Parameters.Add(new SqlParameter("Category", Category));
                    cmd.Parameters.Add(new SqlParameter("Function", Function));
                    cmd.Parameters.Add(new SqlParameter("Brand", Brand));
                    cmd.Parameters.Add(new SqlParameter("MaHang", MaHang));

                    using (SqlDataAdapter sda = new SqlDataAdapter(cmd))
                    { sda.Fill(ds); }

                    con.Close();
                    return ds.Tables[0];
                }
            }
            catch (Exception ex)
            {
                LogBuild.CreateLogger(JsonConvert.SerializeObject(ex), "Test_Bang");
                return ds.Tables[0];
            }
        }

        public static DataTable Test_BangDuyet(string userid, string Category, string Function, string Brand, string MaHang)
        {
            DataSet ds = new DataSet();
            try
            {
                using (var con = new SqlConnection(strConntt))
                {
                    con.Open();
                    SqlCommand cmd = new SqlCommand("Test_BangDuyet", con);
                    cmd.CommandType = CommandType.StoredProcedure;
                    cmd.CommandTimeout = 30000;
                    cmd.Parameters.Add(new SqlParameter("userid", userid));
                    cmd.Parameters.Add(new SqlParameter("Category", Category));
                    cmd.Parameters.Add(new SqlParameter("Function", Function));
                    cmd.Parameters.Add(new SqlParameter("Brand", Brand));
                    cmd.Parameters.Add(new SqlParameter("MaHang", MaHang));

                    using (SqlDataAdapter sda = new SqlDataAdapter(cmd))
                    { sda.Fill(ds); }

                    con.Close();
                    return ds.Tables[0];
                }
            }
            catch (Exception ex)
            {
                LogBuild.CreateLogger(JsonConvert.SerializeObject(ex), "Test_BangDuyet");
                return ds.Tables[0];
            }
        }

        public static int Test_UpdateStus(string userid, int ID, string GiaDieuChinh, string GiaKhaoSat, string ngayapdung)
        {
            DataSet ds = new DataSet();
            try
            {
                using (var con = new SqlConnection(strConntt))
                {
                    con.Open();
                    SqlCommand cmd = new SqlCommand("Test_UpdateStus", con);
                    cmd.CommandType = CommandType.StoredProcedure;
                    cmd.CommandTimeout = 3000;
                    cmd.Parameters.Add(new SqlParameter("userid", userid));
                    cmd.Parameters.Add(new SqlParameter("ID", ID));
                    cmd.Parameters.Add(new SqlParameter("GiaDieuChinh", GiaDieuChinh));
                    cmd.Parameters.Add(new SqlParameter("GiaKhaoSat", GiaKhaoSat));
                    cmd.Parameters.Add(new SqlParameter("ngayapdung", ngayapdung));

                    cmd.ExecuteNonQuery();

                    con.Close();
                    return 1;
                }
            }
            catch (Exception ex)
            {
                LogBuild.CreateLogger(JsonConvert.SerializeObject(ex), "Test_UpdateStus");
                return 0;
            }
        }
        public static int Test_SETTT(string userid, int ID)
        {
            DataSet ds = new DataSet();
            try
            {
                using (var con = new SqlConnection(strConntt))
                {
                    con.Open();
                    SqlCommand cmd = new SqlCommand("Test_SETTT", con);
                    cmd.CommandType = CommandType.StoredProcedure;
                    cmd.CommandTimeout = 3000;
                    cmd.Parameters.Add(new SqlParameter("userid", userid));
                    cmd.Parameters.Add(new SqlParameter("ID", ID));

                    cmd.ExecuteNonQuery();

                    con.Close();
                    return 1;
                }
            }
            catch (Exception ex)
            {
                LogBuild.CreateLogger(JsonConvert.SerializeObject(ex), "Test_SETTT");
                return 0;
            }
        }
        #endregion

    }
}


