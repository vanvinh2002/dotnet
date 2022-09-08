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




        public static DataTable tbl_XayBST(string userid)
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


        #endregion

    }
}


