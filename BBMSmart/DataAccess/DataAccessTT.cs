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
using ProductAllTool.Models.Po2;
using ProductAllTool.Models.HRM;

namespace ProductAllTool.DataAccess
{
    public class DataAccessTT
    {
        private static string strCon = ConfigurationManager.AppSettings.Get("strConn");
        private static string strConn1101 = ConfigurationManager.AppSettings.Get("strConn1.101");
        private static string strConnDWH = ConfigurationManager.AppSettings.Get("strConnDWH");
        private static string strConnTT = ConfigurationManager.AppSettings.Get("strConnTHUCTAP");


        #region Cai AR
        public static List<objCombox> sp_Brand()
        {
            List<objCombox> it_r = new List<objCombox>();
            using (var con = new SqlConnection(strConnTT))
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
            using (var con = new SqlConnection(strConnTT))
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
            using (var con = new SqlConnection(strConnTT))
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
            using (var con = new SqlConnection(strConnTT))
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

       
        public static List<objCombox> AR_CuaHang()
        {
            List<objCombox> it_r = new List<objCombox>();
            using (var con = new SqlConnection(strConnTT))
            {
                con.Open();
                try
                {
                    SqlCommand cmd = new SqlCommand("AR_CuaHang", con);
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
                    LogBuild.CreateLogger(JsonConvert.SerializeObject(ex), "AR_CuaHang");
                    return it_r;
                }
            }
        }

        public static List<objCombox> AR_ChiaKho()
        {
            List<objCombox> it_r = new List<objCombox>();
            using (var con = new SqlConnection(strConnTT))
            {
                con.Open();
                try
                {
                    SqlCommand cmd = new SqlCommand("AR_ChiaKho", con);
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
                    LogBuild.CreateLogger(JsonConvert.SerializeObject(ex), "AR_ChiaKho");
                    return it_r;
                }
            }
        }

        public static DataTable sp_getTable(string userid, string brand, string mahang, string mien, string tinh, string cuahang, string khochia)
        {
            DataSet ds = new DataSet();
            try
            {
                using (var con = new SqlConnection(strConnTT))
                {
                    con.Open();
                    SqlCommand cmd = new SqlCommand("sp_getTable", con);
                    cmd.CommandType = CommandType.StoredProcedure;
                    cmd.CommandTimeout = 30000;
                    cmd.Parameters.Add(new SqlParameter("userid", userid));
                    cmd.Parameters.Add(new SqlParameter("brand", brand));
                    cmd.Parameters.Add(new SqlParameter("mahang", mahang));
                    cmd.Parameters.Add(new SqlParameter("mien", mien));
                    cmd.Parameters.Add(new SqlParameter("tinh", tinh));
                    cmd.Parameters.Add(new SqlParameter("cuahang", cuahang));
                    cmd.Parameters.Add(new SqlParameter("khochia", khochia));

                    using (SqlDataAdapter sda = new SqlDataAdapter(cmd))
                    { sda.Fill(ds); }

                    con.Close();
                    return ds.Tables[0];
                }
            }
            catch (Exception ex)
            {
                LogBuild.CreateLogger(JsonConvert.SerializeObject(ex), "sp_getTable");
                return ds.Tables[0];
            }
        }

        public static int UpdateLyDo(string userid, int ID, string LyDo)
        {
            DataSet ds = new DataSet();
            try
            {
                using (var con = new SqlConnection(strConnTT))
                {
                    con.Open();
                    SqlCommand cmd = new SqlCommand("UpdateLyDo", con);
                    cmd.CommandType = CommandType.StoredProcedure;
                    cmd.CommandTimeout = 30000;
                    cmd.Parameters.Add(new SqlParameter("userid", userid));
                    cmd.Parameters.Add(new SqlParameter("id", ID));
                    cmd.Parameters.Add(new SqlParameter("lydo", LyDo));
                    cmd.ExecuteNonQuery();
                    con.Close();
                    return 1;
                }
            }
            catch (Exception ex)
            {
                LogBuild.CreateLogger(JsonConvert.SerializeObject(ex), "UpdateLyDo");
                return 0;
            }
        }

        #endregion

        #region Mobile


        public static List<objCombox> CLV_Ca()
        {
            List<objCombox> it_r = new List<objCombox>();
            using (var con = new SqlConnection(strConnTT))
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
            using (var con = new SqlConnection(strConnTT))
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

        public static DataTable CLV_GetList(string userid, string TuNgay, string DenNgay, string NoiLam, string Ca)
        {
            DataSet ds = new DataSet();
            try
            {
                using (var con = new SqlConnection(strConnTT))
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

                    cmd.Parameters.Add(new SqlParameter("NoiLam", NoiLam));
                    cmd.Parameters.Add(new SqlParameter("Ca", Ca));



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

        public static DataTable CLV_getListNC1(string userid)
        {
            DataSet ds = new DataSet();
            try
            {
                using (var con = new SqlConnection(strConnTT))
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

        public static DataTable CLV_getListNC2(string userid, string TenCH, string Ca)
        {
            DataSet ds = new DataSet();
            try
            {
                using (var con = new SqlConnection(strConnTT))
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

        public static List<objCombox> CLV_CuaHang()
        {
            List<objCombox> it_r = new List<objCombox>();
            using (var con = new SqlConnection(strConnTT))
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

        public static int CLV_AddListNC(string userid, string Ca)
        {
            DataSet ds = new DataSet();
            try
            {
                using (var con = new SqlConnection(strConnTT))
                {
                    con.Open();
                    SqlCommand cmd = new SqlCommand("CLV_AddListNC", con);
                    cmd.CommandType = CommandType.StoredProcedure;
                    cmd.CommandTimeout = 30000;
                    cmd.Parameters.Add(new SqlParameter("userid", userid));
                    cmd.Parameters.Add(new SqlParameter("Ca", Ca));

                    cmd.ExecuteNonQuery();
                    con.Close();
                    return 1;
                }
            }
            catch (Exception ex)
            {
                LogBuild.CreateLogger(JsonConvert.SerializeObject(ex), "CLV_AddListNC");
                return 0;
            }
        }
        public static int CLV_setTT(string userid, int Ca)
        {
            DataSet ds = new DataSet();
            try
            {
                using (var con = new SqlConnection(strConnTT))
                {
                    con.Open();
                    SqlCommand cmd = new SqlCommand("CLV_setTT", con);
                    cmd.CommandType = CommandType.StoredProcedure;
                    cmd.CommandTimeout = 30000;
                    cmd.Parameters.Add(new SqlParameter("userid", userid));
                    cmd.Parameters.Add(new SqlParameter("Ca", Ca));

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

        public static DataTable CLV_getListDC(string userid, string TuNgay, string DenNgay)
        {
            DataSet ds = new DataSet();
            try
            {
                using (var con = new SqlConnection(strConnTT))
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

        public static List<objCombox> CLV_LoaiNghi()
        {
            List<objCombox> it_r = new List<objCombox>();
            using (var con = new SqlConnection(strConnTT))
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
                using (var con = new SqlConnection(strConnTT))
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

        public static List<objXinNghi> CLV_getListUser()
        {
            List<objXinNghi> it_r = new List<objXinNghi>();
            using (var con = new SqlConnection(strConnTT))
            {
                con.Open();
                try
                {
                    SqlCommand cmd = new SqlCommand("CLV_getListUser", con);
                    cmd.CommandType = CommandType.StoredProcedure;
                    cmd.CommandTimeout = 300;
                    var reader = cmd.ExecuteReader();
                    while (reader.Read())
                    {
                        objXinNghi it_ = new objXinNghi
                        {
                            MaNV = reader["MaNV"].ToString(),
                            TenNV = reader["TenNV"].ToString(),
                            ChucDanh = reader["ChucDanh"].ToString(),
                            BoPhan = reader["BoPhan"].ToString(),
                            TenCH = reader["TenCH"].ToString(),
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
                    LogBuild.CreateLogger(JsonConvert.SerializeObject(ex), "CLV_getListUser");
                    return it_r;
                }
            }
        }

        public static List<objCombox> CLV_Ca_NoiLam()
        {
            List<objCombox> it_r = new List<objCombox>();
            using (var con = new SqlConnection(strConnTT))
            {
                con.Open();
                try
                {
                    SqlCommand cmd = new SqlCommand("CLV_Ca_NoiLam", con);
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
                    LogBuild.CreateLogger(JsonConvert.SerializeObject(ex), "CLV_Ca_NoiLam");
                    return it_r;
                }
            }
        }

        public static DataTable CLV_getListDuyetNghi(string userid, string TuNgay, string DenNgay)
        {
            DataSet ds = new DataSet();
            try
            {
                using (var con = new SqlConnection(strConnTT))
                {
                    con.Open();
                    SqlCommand cmd = new SqlCommand("CLV_getListDuyetNghi", con);
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
                LogBuild.CreateLogger(JsonConvert.SerializeObject(ex), "CLV_getListDuyetNghi");
                return ds.Tables[0];
            }
        }


        #endregion

        #region Xây Dựng BST




        public static DataTable tbl_XayBST(string userid, string MaBST, string TenBST)
        {
            DataSet ds = new DataSet();
            try
            {
                using (var con = new SqlConnection(strConnTT))
                {
                    con.Open();
                    SqlCommand cmd = new SqlCommand("tbl_XayBST", con);
                    cmd.CommandType = CommandType.StoredProcedure;
                    cmd.CommandTimeout = 30000;
                    cmd.Parameters.Add(new SqlParameter("userid", userid));
                    cmd.Parameters.Add(new SqlParameter("MaBST", MaBST));
                    cmd.Parameters.Add(new SqlParameter("TenBST", TenBST));

                    using (SqlDataAdapter sda = new SqlDataAdapter(cmd))
                    { sda.Fill(ds); }

                    con.Close();
                    return ds.Tables[0];
                }
            }
            catch (Exception ex)
            {
                LogBuild.CreateLogger(JsonConvert.SerializeObject(ex), "tbl_XayBST");
                return ds.Tables[0];
            }
        }

        public static List<objautocode> sp_autocode()
        {
            List<objautocode> it_r = new List<objautocode>();
            using (var con = new SqlConnection(strConnTT))
            {
                con.Open();
                try
                {
                    SqlCommand cmd = new SqlCommand("sp_autocode", con);
                    cmd.CommandType = CommandType.StoredProcedure;
                    cmd.CommandTimeout = 300;
                    var reader = cmd.ExecuteReader();

                    while (reader.Read())
                    {
                        objautocode it_ = new objautocode
                        {
                            Code = reader["Code"].ToString(),
                        };

                        it_r.Add(it_);
                    }
                    con.Close();
                    return it_r;
                }
                catch (Exception ex)
                {
                    con.Close();
                    LogBuild.CreateLogger(JsonConvert.SerializeObject(ex), "sp_autocode");
                    return it_r;
                }
            }
        }

        public static int BST_ADD(string userid, create lst)
        {
            try
            {
                using (var con = new SqlConnection(strConnTT))
                {
                    con.Open();
                    SqlCommand cmd = new SqlCommand("BST_ADD", con);
                    cmd.CommandType = CommandType.StoredProcedure;

                    cmd.Parameters.Add(new SqlParameter("userid",userid));
                    cmd.Parameters.Add(new SqlParameter("Code", lst.Code));
                    cmd.Parameters.Add(new SqlParameter("Name", lst.Name));
                    cmd.Parameters.Add(new SqlParameter("Category", lst.Category));
                    cmd.Parameters.Add(new SqlParameter("MuaVu", lst.MuaVu));
                    cmd.Parameters.Add(new SqlParameter("DoiTuong", lst.DoiTuong));
                    cmd.Parameters.Add(new SqlParameter("GioiTinh", lst.GioiTinh));
                    cmd.Parameters.Add(new SqlParameter("ThuNhap", lst.ThuNhap));
                    cmd.Parameters.Add(new SqlParameter("USP", lst.USP));
                    cmd.Parameters.Add(new SqlParameter("ThongDiep", lst.ThongDiep));
                    cmd.Parameters.Add(new SqlParameter("Themelink", lst.Themelink));
                    var reader = cmd.ExecuteNonQuery();

                    con.Close();

                    return 1;
                }
            }
            catch (Exception ex)
            {
                LogBuild.CreateLogger(JsonConvert.SerializeObject(ex), "BST_ADD");
                return 0;
            }
        }
        #endregion

        #region Test

        public static List<objCombox> TTUV_GioiTinh()
        {
            List<objCombox> it_r = new List<objCombox>();
            using (var con = new SqlConnection(strConnTT))
            {
                con.Open();
                try
                {
                    SqlCommand cmd = new SqlCommand("TTUV_GioiTinh", con);
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
                    LogBuild.CreateLogger(JsonConvert.SerializeObject(ex), "TTUV_GioiTinh");
                    return it_r;
                }
            }
        }

        public static List<objCombox> TTUV_TinhTrang()
        {
            List<objCombox> it_r = new List<objCombox>();
            using (var con = new SqlConnection(strConnTT))
            {
                con.Open();
                try
                {
                    SqlCommand cmd = new SqlCommand("TTUV_TinhTrang", con);
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
                    LogBuild.CreateLogger(JsonConvert.SerializeObject(ex), "TTUV_TinhTrang");
                    return it_r;
                }
            }
        }

        public static List<objCombox> TTUV_TinhThanhThuongTru()
        {
            List<objCombox> it_r = new List<objCombox>();
            using (var con = new SqlConnection(strConnTT))
            {
                con.Open();
                try
                {
                    SqlCommand cmd = new SqlCommand("TTUV_TinhThanhThuongTru", con);
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
                    LogBuild.CreateLogger(JsonConvert.SerializeObject(ex), "TTUV_TinhThanhThuongTru");
                    return it_r;
                }
            }
        }

        public static List<objCombox> TTUV_TinhThanhCMND()
        {
            List<objCombox> it_r = new List<objCombox>();
            using (var con = new SqlConnection(strConnTT))
            {
                con.Open();
                try
                {
                    SqlCommand cmd = new SqlCommand("TTUV_TinhThanhCMND", con);
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
                    LogBuild.CreateLogger(JsonConvert.SerializeObject(ex), "TTUV_TinhThanhCMND");
                    return it_r;
                }
            }
        }

        public static List<objCombox> TTUV_QuanHuyenThuongTru()
        {
            List<objCombox> it_r = new List<objCombox>();
            using (var con = new SqlConnection(strConnTT))
            {
                con.Open();
                try
                {
                    SqlCommand cmd = new SqlCommand("TTUV_QuanHuyenThuongTru", con);
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
                    LogBuild.CreateLogger(JsonConvert.SerializeObject(ex), "TTUV_QuanHuyenThuongTru");
                    return it_r;
                }
            }
        }

        public static List<objCombox> TTUV_QuanHuyenCMND()
        {
            List<objCombox> it_r = new List<objCombox>();
            using (var con = new SqlConnection(strConnTT))
            {
                con.Open();
                try
                {
                    SqlCommand cmd = new SqlCommand("TTUV_QuanHuyenCMND", con);
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
                    LogBuild.CreateLogger(JsonConvert.SerializeObject(ex), "TTUV_QuanHuyenCMND");
                    return it_r;
                }
            }
        }

        public static List<objCombox> TTUV_PhuongXaThuongTru()
        {
            List<objCombox> it_r = new List<objCombox>();
            using (var con = new SqlConnection(strConnTT))
            {
                con.Open();
                try
                {
                    SqlCommand cmd = new SqlCommand("TTUV_PhuongXaThuongTru", con);
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
                    LogBuild.CreateLogger(JsonConvert.SerializeObject(ex), "TTUV_PhuongXaThuongTru");
                    return it_r;
                }
            }
        }

        public static List<objCombox> TTUV_PhuongXaCMND()
        {
            List<objCombox> it_r = new List<objCombox>();
            using (var con = new SqlConnection(strConnTT))
            {
                con.Open();
                try
                {
                    SqlCommand cmd = new SqlCommand("TTUV_PhuongXaCMND", con);
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
                    LogBuild.CreateLogger(JsonConvert.SerializeObject(ex), "TTUV_PhuongXaCMND");
                    return it_r;
                }
            }
        }

        public static List<objCombox> TTUV_TinhThanhTamTru()
        {
            List<objCombox> it_r = new List<objCombox>();
            using (var con = new SqlConnection(strConnTT))
            {
                con.Open();
                try
                {
                    SqlCommand cmd = new SqlCommand("TTUV_TinhThanhTamTru", con);
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
                    LogBuild.CreateLogger(JsonConvert.SerializeObject(ex), "TTUV_TinhThanhTamTru");
                    return it_r;
                }
            }
        }

        public static List<objCombox> TTUV_QuanHuyenTamTru()
        {
            List<objCombox> it_r = new List<objCombox>();
            using (var con = new SqlConnection(strConnTT))
            {
                con.Open();
                try
                {
                    SqlCommand cmd = new SqlCommand("TTUV_QuanHuyenTamTru", con);
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
                    LogBuild.CreateLogger(JsonConvert.SerializeObject(ex), "TTUV_QuanHuyenTamTru");
                    return it_r;
                }
            }
        }

        public static List<objCombox> TTUV_PhuongXaaTamTru()
        {
            List<objCombox> it_r = new List<objCombox>();
            using (var con = new SqlConnection(strConnTT))
            {
                con.Open();
                try
                {
                    SqlCommand cmd = new SqlCommand("TTUV_PhuongXaaTamTru", con);
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
                    LogBuild.CreateLogger(JsonConvert.SerializeObject(ex), "TTUV_PhuongXaaTamTru");
                    return it_r;
                }
            }
        }

        public static int TTUV_ADD(string userid, TTUVadd lst)
        {
            try
            {
                using (var con = new SqlConnection(strConnTT))
                {
                    con.Open();
                    SqlCommand cmd = new SqlCommand("TTUV_ADD", con);
                    cmd.CommandType = CommandType.StoredProcedure;

                    cmd.Parameters.Add(new SqlParameter("Ten", lst.Ten));
                    cmd.Parameters.Add(new SqlParameter("Ma", lst.Ma));
                    cmd.Parameters.Add(new SqlParameter("SBD", lst.SBD));
                    cmd.Parameters.Add(new SqlParameter("GioiTinh", lst.GioiTinh));
                    cmd.Parameters.Add(new SqlParameter("TinhTrangHonNhan", lst.TinhTrangHonNhan));
                    cmd.Parameters.Add(new SqlParameter("NgaySinh", lst.NgaySinh));
                    cmd.Parameters.Add(new SqlParameter("NoiSinh", lst.NoiSinh));
                    cmd.Parameters.Add(new SqlParameter("NguyenQuan", lst.NguyenQuan));
                    cmd.Parameters.Add(new SqlParameter("QuocTich", lst.Quoctich));
                    cmd.Parameters.Add(new SqlParameter("TonGiao", lst.TonGiao));
                    cmd.Parameters.Add(new SqlParameter("TrinhDoVanHoa", lst.TrinhDoVanHoa));
                    cmd.Parameters.Add(new SqlParameter("TrinhDoHocVan", lst.TrinhDoHocVan));
                    cmd.Parameters.Add(new SqlParameter("TenThuongGoi", lst.TenThuongGoi));
                    cmd.Parameters.Add(new SqlParameter("TenTiengHoa", lst.TenTiengHoa));
                    cmd.Parameters.Add(new SqlParameter("SoCMND", lst.SoCMND));
                    cmd.Parameters.Add(new SqlParameter("NgayCapCMND", lst.NgayCapCMND));
                    cmd.Parameters.Add(new SqlParameter("NoiCapCMND", lst.NoiCapCMND));
                    cmd.Parameters.Add(new SqlParameter("MST", lst.MST));
                    cmd.Parameters.Add(new SqlParameter("NgayApDung", lst.NgayApDung));
                    cmd.Parameters.Add(new SqlParameter("CoQuanQuanLy", lst.CoQuanQuanLy));
                    cmd.Parameters.Add(new SqlParameter("SoHoChieu", lst.SoHoChieu));
                    cmd.Parameters.Add(new SqlParameter("NoiCapSHC", lst.NoiCapSHC));
                    cmd.Parameters.Add(new SqlParameter("NgayCapSHC", lst.NgayCapSHC));
                    cmd.Parameters.Add(new SqlParameter("NgayHetHanSHC", lst.NgayHetHanSHC));
                    cmd.Parameters.Add(new SqlParameter("SoCCCD", lst.SoCCCD));
                    cmd.Parameters.Add(new SqlParameter("DTDD", lst.DTDD));
                    cmd.Parameters.Add(new SqlParameter("DTDD2", lst.DTDD2));
                    cmd.Parameters.Add(new SqlParameter("DTN", lst.DTN));
                    cmd.Parameters.Add(new SqlParameter("Email", lst.Email));
                    cmd.Parameters.Add(new SqlParameter("QuocgiaThuongTru", lst.QuocgiaThuongTru));
                    cmd.Parameters.Add(new SqlParameter("TinhThanhThuongTru", lst.TinhThanhThuongTru));
                    cmd.Parameters.Add(new SqlParameter("QuanHuyenThuongTru", lst.QuanHuyenThuongTru));
                    cmd.Parameters.Add(new SqlParameter("PhuongXaThuongTru", lst.PhuongXaThuongTru));
                    cmd.Parameters.Add(new SqlParameter("DiaChiThuongTru", lst.DiaChiThuongTru));
                    cmd.Parameters.Add(new SqlParameter("QuocGiaCMND", lst.QuocGiaCMND));
                    cmd.Parameters.Add(new SqlParameter("TinhThanhCMND", lst.TinhThanhCMND));
                    cmd.Parameters.Add(new SqlParameter("QuanHuyenCMND", lst.QuanHuyenCMND));
                    cmd.Parameters.Add(new SqlParameter("PhuongXaCMND", lst.PhuongXaCMND));
                    cmd.Parameters.Add(new SqlParameter("DiaChiCMND", lst.DiaChiCMND));
                    cmd.Parameters.Add(new SqlParameter("QuocGiaTamTru", lst.QuocGiaTamTru));
                    cmd.Parameters.Add(new SqlParameter("TinhThanhTamTru", lst.TinhThanhTamTru));
                    cmd.Parameters.Add(new SqlParameter("QuanHuyenTamTru", lst.QuanHuyenTamTru));
                    cmd.Parameters.Add(new SqlParameter("PhuongXaTamTru", lst.PhuongXaTamTru));
                    cmd.Parameters.Add(new SqlParameter("DiaChiTamTru", lst.DiaChiTamTru));
                    cmd.Parameters.Add(new SqlParameter("TinhTrangSucKhoe", lst.TinhTrangSucKhoe));
                    cmd.Parameters.Add(new SqlParameter("ChieuCao", lst.ChieuCao));
                    cmd.Parameters.Add(new SqlParameter("CanNang", lst.CanNang));
                    cmd.Parameters.Add(new SqlParameter("MatTrai", lst.MatTrai));
                    cmd.Parameters.Add(new SqlParameter("MatPhai", lst.MatPhai));
                    cmd.Parameters.Add(new SqlParameter("BenhLy", lst.BenhLy));
                    cmd.Parameters.Add(new SqlParameter("HuyetAp", lst.HuyetAp));
                    cmd.Parameters.Add(new SqlParameter("NhipTim", lst.NhipTim));
                    cmd.Parameters.Add(new SqlParameter("SizeQuan", lst.SizeQuan));
                    cmd.Parameters.Add(new SqlParameter("BangLaiXe", lst.BangLaiXe));
                    

                    var reader = cmd.ExecuteNonQuery();

                    con.Close();

                    return 1;
                }
            }
            catch (Exception ex)
            {
                LogBuild.CreateLogger(JsonConvert.SerializeObject(ex), "TTUV_ADD");
                return 0;
            }
        }

        public static DataTable TTUV_GetDS(string userid,string Ma, int SBD)
        {
            DataSet ds = new DataSet();
            try
            {
                using (var con = new SqlConnection(strConnTT))
                {
                    con.Open();
                    SqlCommand cmd = new SqlCommand("TTUV_GetDS", con);
                    cmd.CommandType = CommandType.StoredProcedure;
                    cmd.CommandTimeout = 30000;
                    cmd.Parameters.Add(new SqlParameter("userid", userid));
                    cmd.Parameters.Add(new SqlParameter("Ma", Ma));
                    cmd.Parameters.Add(new SqlParameter("SBD", SBD));
                    using (SqlDataAdapter sda = new SqlDataAdapter(cmd))
                    { sda.Fill(ds); }

                    con.Close();
                    return ds.Tables[0];
                }
            }
            catch (Exception ex)
            {
                LogBuild.CreateLogger(JsonConvert.SerializeObject(ex), "TTUV_GetDS");
                return ds.Tables[0];
            }
        }

        #endregion

        #region Xây dựng bộ sưu tập 

        public static List<itemBST> sp_BBSmart_GetListThuongHieu(string uid)
        {
            List<itemBST> it_r = new List<itemBST>();

            using (var con = new SqlConnection(strCon))
            {
                con.Open();
                try
                {
                    SqlCommand cmd = new SqlCommand("sp_BBSmart_GetListThuongHieu", con);
                    cmd.CommandType = CommandType.StoredProcedure;
                    cmd.CommandTimeout = 30000;

                    cmd.Parameters.Add(new SqlParameter("userid", uid));

                    var reader = cmd.ExecuteReader();

                    while (reader.Read())
                    {
                        itemBST it_ = new itemBST
                        {
                            ThuongHieu = reader["Thương hiệu"].ToString(),
                        };

                        it_r.Add(it_);
                    }
                    con.Close();

                    return it_r;
                }
                catch (Exception ex)
                {
                    con.Close();
                    LogBuild.CreateLogger(JsonConvert.SerializeObject(ex), "sp_BBSmart_GetListThuongHieu");
                    return it_r;
                }
            }
        }

        public static List<itemBST> sp_BBSmart_GetListDoTuoi(string uid)
        {
            List<itemBST> it_r = new List<itemBST>();

            using (var con = new SqlConnection(strCon))
            {
                con.Open();
                try
                {

                    SqlCommand cmd = new SqlCommand("sp_BBSmart_GetListDoTuoi", con);
                    cmd.CommandType = CommandType.StoredProcedure;
                    cmd.CommandTimeout = 30000;

                    cmd.Parameters.Add(new SqlParameter("userid", uid));

                    var reader = cmd.ExecuteReader();

                    while (reader.Read())
                    {
                        itemBST it_ = new itemBST
                        {
                            DaiTuoi = reader["Name 2"].ToString(),
                        };

                        it_r.Add(it_);
                    }
                    con.Close();

                    return it_r;
                }
                catch (Exception ex)
                {
                    con.Close();
                    LogBuild.CreateLogger(JsonConvert.SerializeObject(ex), "sp_BBSmart_GetListDoTuoi");
                    return it_r;
                }
            }
        }

        public static List<objCombox> sp_bbs_collection_GetLstCodeBST()
        {
            List<objCombox> it_r = new List<objCombox>();

            using (var con = new SqlConnection(strCon))
            {
                con.Open();
                try
                {

                    SqlCommand cmd = new SqlCommand("sp_bbs_collection_GetLstCodeBST", con);
                    cmd.CommandType = CommandType.StoredProcedure;
                    cmd.CommandTimeout = 30000;
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
                    LogBuild.CreateLogger(JsonConvert.SerializeObject(ex), "sp_bbs_collection_GetLstCodeBST");
                    return it_r;
                }
            }
        }

        public static List<objCombox> sp_bbs_collection_GetLstNameBST()
        {
            List<objCombox> it_r = new List<objCombox>();

            using (var con = new SqlConnection(strCon))
            {
                con.Open();
                try
                {

                    SqlCommand cmd = new SqlCommand("sp_bbs_collection_GetLstNameBST", con);
                    cmd.CommandType = CommandType.StoredProcedure;
                    cmd.CommandTimeout = 30000;
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
                    LogBuild.CreateLogger(JsonConvert.SerializeObject(ex), "sp_bbs_collection_GetLstNameBST");
                    return it_r;
                }
            }
        }

        public static List<objCombox> sp_bbs_collection_getrangereview()
        {
            List<objCombox> it_r = new List<objCombox>();

            using (var con = new SqlConnection(strCon))
            {
                con.Open();
                try
                {

                    SqlCommand cmd = new SqlCommand("sp_bbs_collection_getrangereview", con);
                    cmd.CommandType = CommandType.StoredProcedure;
                    cmd.CommandTimeout = 30000;
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
                    LogBuild.CreateLogger(JsonConvert.SerializeObject(ex), "sp_bbs_collection_getrangereview");
                    return it_r;
                }
            }
        }

        public static List<objCombox> sp_bbs_collection_lstNguonNhap()
        {
            List<objCombox> it_r = new List<objCombox>();

            using (var con = new SqlConnection(strCon))
            {
                con.Open();
                try
                {

                    SqlCommand cmd = new SqlCommand("sp_bbs_collection_lstNguonNhap", con);
                    cmd.CommandType = CommandType.StoredProcedure;
                    cmd.CommandTimeout = 30000;
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
                    LogBuild.CreateLogger(JsonConvert.SerializeObject(ex), "sp_bbs_collection_lstNguonNhap");
                    return it_r;
                }
            }
        }

        public static List<objCombox> sp_bbs_collection_lstMuaVu()
        {
            List<objCombox> it_r = new List<objCombox>();

            using (var con = new SqlConnection(strCon))
            {
                con.Open();
                try
                {

                    SqlCommand cmd = new SqlCommand("sp_bbs_collection_lstMuaVu", con);
                    cmd.CommandType = CommandType.StoredProcedure;
                    cmd.CommandTimeout = 30000;
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
                    LogBuild.CreateLogger(JsonConvert.SerializeObject(ex), "sp_bbs_collection_lstMuaVu");
                    return it_r;
                }
            }
        }

        public static List<objCombox> sp_bbs_collection_lstbrand()
        {
            List<objCombox> it_r = new List<objCombox>();

            using (var con = new SqlConnection(strCon))
            {
                con.Open();
                try
                {

                    SqlCommand cmd = new SqlCommand("sp_bbs_collection_lstbrand", con);
                    cmd.CommandType = CommandType.StoredProcedure;
                    cmd.CommandTimeout = 30000;
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
                    LogBuild.CreateLogger(JsonConvert.SerializeObject(ex), "sp_bbs_collection_lstbrand");
                    return it_r;
                }
            }
        }

        public static List<objCombox> sp_bbs_collection_getbrand(string funct)
        {
            List<objCombox> it_r = new List<objCombox>();

            using (var con = new SqlConnection(strCon))
            {
                con.Open();
                try
                {

                    SqlCommand cmd = new SqlCommand("sp_bbs_collection_getbrand", con);
                    cmd.CommandType = CommandType.StoredProcedure;
                    cmd.CommandTimeout = 3000;
                    cmd.Parameters.Add(new SqlParameter("funct", funct));
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
                    LogBuild.CreateLogger(JsonConvert.SerializeObject(ex), "sp_bbs_collection_getbrand");
                    return it_r;
                }
            }
        }

        public static List<objCombox> sp_bbs_collection_getMuaVu(string funct)
        {
            List<objCombox> it_r = new List<objCombox>();

            using (var con = new SqlConnection(strCon))
            {
                con.Open();
                try
                {

                    SqlCommand cmd = new SqlCommand("sp_bbs_collection_getMuaVu", con);
                    cmd.CommandType = CommandType.StoredProcedure;
                    cmd.CommandTimeout = 3000;
                    cmd.Parameters.Add(new SqlParameter("funct", funct));
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
                    LogBuild.CreateLogger(JsonConvert.SerializeObject(ex), "sp_bbs_collection_getMuaVu");
                    return it_r;
                }
            }
        }

        public static List<objCombox> sp_bbs_collection_getNguonNhap(string funct)
        {
            List<objCombox> it_r = new List<objCombox>();

            using (var con = new SqlConnection(strCon))
            {
                con.Open();
                try
                {

                    SqlCommand cmd = new SqlCommand("sp_bbs_collection_getNguonNhap", con);
                    cmd.CommandType = CommandType.StoredProcedure;
                    cmd.CommandTimeout = 3000;
                    cmd.Parameters.Add(new SqlParameter("funct", funct));
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
                    LogBuild.CreateLogger(JsonConvert.SerializeObject(ex), "sp_bbs_collection_getNguonNhap");
                    return it_r;
                }
            }
        }

        public static List<DivCatGroupFuncollect> sp_collection_SourceProduct_DivCatGroupFunc_v2_get(string uid)
        {
            List<DivCatGroupFuncollect> it_r = new List<DivCatGroupFuncollect>();


            using (var con = new SqlConnection(strCon))
            {
                con.Open();

                try
                {

                    SqlCommand cmd = new SqlCommand("sp_collection_SourceProduct_DivCatGroupFunc_v2_get", con);
                    cmd.CommandType = CommandType.StoredProcedure;

                    cmd.Parameters.Add(new SqlParameter("uid", uid));

                    var reader = cmd.ExecuteReader();

                    while (reader.Read())
                    {
                        DivCatGroupFuncollect it = new DivCatGroupFuncollect
                        {
                            DivisionCode = reader["DivisionCode"].ToString(),
                            DivisionName = reader["DivisionName"].ToString(),
                            CategoryCode = reader["CategoryCode"].ToString(),
                            CategoryName = reader["CategoryName"].ToString(),
                            GroupCode = reader["GroupCode"].ToString(),
                            GroupName = reader["GroupName"].ToString(),
                            FunctionCode = reader["FunctionCode"].ToString(),
                            FunctionName = reader["FunctionName"].ToString()

                        };

                        it_r.Add(it);
                    }
                    con.Close();

                    return it_r;

                }
                catch (Exception ex)
                {
                    con.Close();
                    LogBuild.CreateLogger(JsonConvert.SerializeObject(ex), "sp_collection_SourceProduct_DivCatGroupFunc_v2_get");
                    return it_r;
                }
            }

        }

        public static DataTable sp_bbs_collection_GetLstproductImg(string userid, string cat, string group, string funct, string range, string brand, string nguonnhap, string muavu)
        {
            DataSet ds = new DataSet();
            try
            {
                using (var con = new SqlConnection(strCon))
                {
                    con.Open();
                    SqlCommand cmd = new SqlCommand("sp_bbs_collection_GetLstproductImg", con);
                    cmd.CommandType = CommandType.StoredProcedure;
                    cmd.CommandTimeout = 30000;
                    cmd.Parameters.Add(new SqlParameter("userid", userid));
                    cmd.Parameters.Add(new SqlParameter("cat", cat));
                    cmd.Parameters.Add(new SqlParameter("group", group));
                    cmd.Parameters.Add(new SqlParameter("funct", funct));
                    cmd.Parameters.Add(new SqlParameter("range", range));
                    cmd.Parameters.Add(new SqlParameter("brand", brand));
                    cmd.Parameters.Add(new SqlParameter("nguonnhap", nguonnhap));
                    cmd.Parameters.Add(new SqlParameter("muavu", muavu));
                    using (SqlDataAdapter sda = new SqlDataAdapter(cmd))
                    { sda.Fill(ds); }

                    con.Close();
                    return ds.Tables[0];
                }
            }
            catch (Exception ex)
            {
                LogBuild.CreateLogger(JsonConvert.SerializeObject(ex), "sp_bbs_collection_GetLstproductImg");
                return ds.Tables[0];
            }
        }

        public static List<collectiondetail> sp_bbs_collection_GetLstproduct(string userid, string mahang)
        {
            List<collectiondetail> it_r = new List<collectiondetail>();

            using (var con = new SqlConnection(strCon))
            {
                con.Open();
                try
                {

                    SqlCommand cmd = new SqlCommand("sp_bbs_collection_GetLstproduct", con);
                    cmd.CommandType = CommandType.StoredProcedure;
                    cmd.Parameters.Add(new SqlParameter("userid", userid));
                    cmd.Parameters.Add(new SqlParameter("mahang", mahang));

                    var reader = cmd.ExecuteReader();

                    while (reader.Read())
                    {
                        collectiondetail it = new collectiondetail
                        {
                            Code = reader["Code"].ToString(),
                            Name = reader["Name"].ToString(),
                            hinhanh = reader["hinhanh"].ToString(),
                            SLton = reader["SLton"].ToString(),
                            GiaBanAll = reader["GiaBanAll"].ToString(),
                            CategoryCode = reader["CategoryCode"].ToString(),
                            CategoryName = reader["CategoryName"].ToString(),
                            GroupCode = reader["GroupCode"].ToString(),
                            GroupName = reader["GroupName"].ToString(),
                            FunctionCode = reader["FunctionCode"].ToString(),
                            FunctionName = reader["FunctionName"].ToString(),
                            BrandCode = reader["BrandCode"].ToString(),
                            BrandName = reader["BrandName"].ToString(),
                            NguonNhapCode = reader["NguonNhapCode"].ToString(),
                            NguonNhapName = reader["NguonNhapName"].ToString(),
                            MuaVuCode = reader["MuaVuCode"].ToString(),
                            MuaVuName = reader["MuaVuName"].ToString(),
                        };

                        it_r.Add(it);
                    }
                    con.Close();

                    return it_r;
                }
                catch (Exception ex)
                {
                    con.Close();
                    LogBuild.CreateLogger(JsonConvert.SerializeObject(ex), "sp_bbs_collection_GetLstproduct");
                    return it_r;
                }
            }
        }

        #endregion

    }
}


