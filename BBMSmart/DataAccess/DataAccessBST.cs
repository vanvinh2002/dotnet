using Newtonsoft.Json;
using ProductAllTool.Models.CaLamViec;
using ProductAllTool.Models.DuyetBST;
using ProductAllTool.Models.ManageSales;
using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Web;

namespace ProductAllTool.DataAccess
{
    public class DataAccessBST
    {
        private static string strConnTHUCTAP = ConfigurationManager.AppSettings.Get("strConnTHUCTAP");

        public static List<objCombox> cbo_MuaVu()
        {
            List<objCombox> it_r = new List<objCombox>();
            using (var con = new SqlConnection(strConnTHUCTAP))
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

        public static List<objCombox> cbo_NguonNhap()
        {
            List<objCombox> it_r = new List<objCombox>();
            using (var con = new SqlConnection(strConnTHUCTAP))
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

        public static List<objCombox> cbo_Brand()
        {
            List<objCombox> it_r = new List<objCombox>();
            using (var con = new SqlConnection(strConnTHUCTAP))
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

        public static List<objCombox> cbo_RR()
        {
            List<objCombox> it_r = new List<objCombox>();
            using (var con = new SqlConnection(strConnTHUCTAP))
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

        public static List<objCombox> cbo_Func()
        {
            List<objCombox> it_r = new List<objCombox>();
            using (var con = new SqlConnection(strConnTHUCTAP))
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

        public static List<objCombox> cbo_Group()
        {
            List<objCombox> it_r = new List<objCombox>();
            using (var con = new SqlConnection(strConnTHUCTAP))
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

        public static List<objCombox> cbo_Cate()
        {
            List<objCombox> it_r = new List<objCombox>();
            using (var con = new SqlConnection(strConnTHUCTAP))
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

        public static DataTable BST_getListDuyet(string userid, string Cate, string GroupCat, string Func, string RR, string Brand, string NguonNhap, string MuaVu)
        {
            DataSet ds = new DataSet();
            try
            {
                using (var con = new SqlConnection(strConnTHUCTAP))
                {
                    con.Open();
                    SqlCommand cmd = new SqlCommand("BST_getListDuyet", con);
                    cmd.CommandType = CommandType.StoredProcedure;
                    cmd.CommandTimeout = 30000;
                    cmd.Parameters.Add(new SqlParameter("userid", userid));
                    cmd.Parameters.Add(new SqlParameter("Cate", Cate));
                    cmd.Parameters.Add(new SqlParameter("GroupCat", GroupCat));
                    cmd.Parameters.Add(new SqlParameter("Func", Func));
                    cmd.Parameters.Add(new SqlParameter("RR", RR));
                    cmd.Parameters.Add(new SqlParameter("Brand", Brand));
                    cmd.Parameters.Add(new SqlParameter("NguonNhap", NguonNhap));
                    cmd.Parameters.Add(new SqlParameter("MuaVu", MuaVu));
                    using (SqlDataAdapter sda = new SqlDataAdapter(cmd))
                    { sda.Fill(ds); }

                    con.Close();
                    return ds.Tables[0];
                }
            }
            catch (Exception ex)
            {
                LogBuild.CreateLogger(JsonConvert.SerializeObject(ex), "BST_getListDuyet");
                return ds.Tables[0];
            }
        }

        public static List<ListSP> BST_GetNextAndPreviousSP(string userid, string Cate, string GroupCat, string Func, string RR, string Brand, string NguonNhap, string MuaVu, string mahang, string ID)
        {
            List<ListSP> it_r = new List<ListSP>();

            using (var con = new SqlConnection(strConnTHUCTAP))
            {
                con.Open();
                try
                {
                    SqlCommand cmd = new SqlCommand("[BST_GetNextAndPreviousSP]", con);
                    cmd.CommandType = CommandType.StoredProcedure;
                    cmd.Parameters.Add(new SqlParameter("userid", userid));
                    cmd.Parameters.Add(new SqlParameter("Cate", Cate));
                    cmd.Parameters.Add(new SqlParameter("GroupCat", GroupCat));
                    cmd.Parameters.Add(new SqlParameter("Func", Func));
                    cmd.Parameters.Add(new SqlParameter("RR", RR));
                    cmd.Parameters.Add(new SqlParameter("Brand", Brand));
                    cmd.Parameters.Add(new SqlParameter("NguonNhap", NguonNhap));
                    cmd.Parameters.Add(new SqlParameter("MuaVu", MuaVu));
                    cmd.Parameters.Add(new SqlParameter("mahang", mahang));
                    cmd.Parameters.Add(new SqlParameter("ID", ID));
                    var reader = cmd.ExecuteReader();

                    while (reader.Read())
                    {
                        ListSP it_ = new ListSP
                        {
                            ID = reader["ID"].ToString(),
                            Code = reader["Code"].ToString(),
                            Name = reader["Name"].ToString(),
                            GiaBanAll = reader["GiaBanAll"].ToString(),
                            SLTon = reader["SLTon"].ToString(),
                            hinhanh = reader["hinhanh"].ToString()
                        };

                        it_r.Add(it_);
                    }
                    con.Close();

                    return it_r;
                }
                catch (Exception ex)
                {
                    con.Close();
                    LogBuild.CreateLogger(JsonConvert.SerializeObject(ex), "BST_GetNextAndPreviousSP");
                    return it_r;
                }
            }
        }

        public static List<ListSP> BST_getNextSP(string userid, string Cate, string GroupCat, string Func, string RR, string Brand, string NguonNhap, string MuaVu, string mahang)
        {
            List<ListSP> it_r = new List<ListSP>();

            using (var con = new SqlConnection(strConnTHUCTAP))
            {
                con.Open();
                try
                {
                    SqlCommand cmd = new SqlCommand("[BST_getListDuyet]", con);
                    cmd.CommandType = CommandType.StoredProcedure;
                    cmd.Parameters.Add(new SqlParameter("userid", userid));
                    cmd.Parameters.Add(new SqlParameter("Cate", Cate));
                    cmd.Parameters.Add(new SqlParameter("GroupCat", GroupCat));
                    cmd.Parameters.Add(new SqlParameter("Func", Func));
                    cmd.Parameters.Add(new SqlParameter("RR", RR));
                    cmd.Parameters.Add(new SqlParameter("Brand", Brand));
                    cmd.Parameters.Add(new SqlParameter("NguonNhap", NguonNhap));
                    cmd.Parameters.Add(new SqlParameter("MuaVu", MuaVu));
                    cmd.Parameters.Add(new SqlParameter("mahang", mahang));
                    var reader = cmd.ExecuteReader();

                    while (reader.Read())
                    {
                        ListSP it_ = new ListSP
                        {
                            ID = reader["ID"].ToString(),
                            Code = reader["Code"].ToString(),
                            Name = reader["Name"].ToString(),
                            GiaBanAll = reader["GiaBanAll"].ToString(),
                            SLTon = reader["SLTon"].ToString(),
                            hinhanh = reader["hinhanh"].ToString()
                        };

                        it_r.Add(it_);
                    }
                    con.Close();

                    return it_r;
                }
                catch (Exception ex)
                {
                    con.Close();
                    LogBuild.CreateLogger(JsonConvert.SerializeObject(ex), "BST_getNextSP");
                    return it_r;
                }
            }
        }

        public static List<ListSP> BST_getListDuyet1(string userid, string Cate, string GroupCat, string Func, string RR, string Brand, string NguonNhap, string MuaVu)
        {
            List<ListSP> it_r = new List<ListSP>();

            using (var con = new SqlConnection(strConnTHUCTAP))
            {
                con.Open();
                try
                {
                    SqlCommand cmd = new SqlCommand("[BST_getListDuyet]", con);
                    cmd.CommandType = CommandType.StoredProcedure;
                    cmd.Parameters.Add(new SqlParameter("userid", userid));
                    cmd.Parameters.Add(new SqlParameter("Cate", Cate));
                    cmd.Parameters.Add(new SqlParameter("GroupCat", GroupCat));
                    cmd.Parameters.Add(new SqlParameter("Func", Func));
                    cmd.Parameters.Add(new SqlParameter("RR", RR));
                    cmd.Parameters.Add(new SqlParameter("Brand", Brand));
                    cmd.Parameters.Add(new SqlParameter("NguonNhap", NguonNhap));
                    cmd.Parameters.Add(new SqlParameter("MuaVu", MuaVu));
                    var reader = cmd.ExecuteReader();

                    while (reader.Read())
                    {
                        ListSP it_ = new ListSP
                        {
                            ID = reader["ID"].ToString(),
                            Code = reader["Code"].ToString(),
                            Name = reader["Name"].ToString(),
                            GiaBanAll = reader["GiaBanAll"].ToString(),
                            SLTon = reader["SLTon"].ToString(),
                            hinhanh = reader["hinhanh"].ToString()
                        };

                        it_r.Add(it_);
                    }
                    con.Close();

                    return it_r;
                }
                catch (Exception ex)
                {
                    con.Close();
                    LogBuild.CreateLogger(JsonConvert.SerializeObject(ex), "BST_getListDuyet1");
                    return it_r;
                }
            }
        }

        public static List<DuyetBST> BST_GetBST(string userid, string MaBST, string TenBST)
        {
            List<DuyetBST> it_r = new List<DuyetBST>();

            using (var con = new SqlConnection(strConnTHUCTAP))
            {
                con.Open();
                try
                {
                    SqlCommand cmd = new SqlCommand("BST_GetBST", con);
                    cmd.CommandType = CommandType.StoredProcedure;
                    cmd.Parameters.Add(new SqlParameter("userid", userid));
                    cmd.Parameters.Add(new SqlParameter("MaBST", MaBST));
                    cmd.Parameters.Add(new SqlParameter("TenBST", TenBST));
                    var reader = cmd.ExecuteReader();

                    while (reader.Read())
                    {
                        DuyetBST it_ = new DuyetBST
                        {
                            MaBST = reader["MaBST"].ToString(),
                            TenBST = reader["TenBST"].ToString(),
                            Cate = reader["Cate"].ToString(),
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
                    LogBuild.CreateLogger(JsonConvert.SerializeObject(ex), "BST_GetBST");
                    return it_r;
                }
            }
        }

        public static int BST_GetSPDetail(string userid, string ID)
        {
            DataSet ds = new DataSet();
            try
            {
                using (var con = new SqlConnection(strConnTHUCTAP))
                {
                    con.Open();
                    SqlCommand cmd = new SqlCommand("BST_GetSPDetail", con);
                    cmd.CommandType = CommandType.StoredProcedure;
                    cmd.CommandTimeout = 30000;
                    cmd.Parameters.Add(new SqlParameter("userid", userid));
                    cmd.Parameters.Add(new SqlParameter("ID", ID));
                    cmd.ExecuteNonQuery();

                    con.Close();
                    return 1;
                }
            }
            catch (Exception ex)
            {
                LogBuild.CreateLogger(JsonConvert.SerializeObject(ex), "BST_GetSPDetail");
                return 0;
            }
        }

        public static int BST_UpdateStatusCollect(string userid, string type, string Code)
        {
            DataSet ds = new DataSet();
            try
            {
                using (var con = new SqlConnection(strConnTHUCTAP))
                {
                    con.Open();
                    SqlCommand cmd = new SqlCommand("BST_UpdateStatusCollect", con);
                    cmd.CommandType = CommandType.StoredProcedure;
                    cmd.CommandTimeout = 30000;
                    cmd.Parameters.Add(new SqlParameter("userid", userid));
                    cmd.Parameters.Add(new SqlParameter("type", type));
                    cmd.Parameters.Add(new SqlParameter("Code", Code));
                    cmd.ExecuteNonQuery();

                    con.Close();
                    return 1;
                }
            }
            catch (Exception ex)
            {
                LogBuild.CreateLogger(JsonConvert.SerializeObject(ex), "BST_UpdateStatusCollect");
                return 0;
            }
        }

        public static int BST_UpdateStatusCollectDetail(string userid, string type)
        {
            DataSet ds = new DataSet();
            try
            {
                using (var con = new SqlConnection(strConnTHUCTAP))
                {
                    con.Open();
                    SqlCommand cmd = new SqlCommand("BST_UpdateStatusCollect", con);
                    cmd.CommandType = CommandType.StoredProcedure;
                    cmd.CommandTimeout = 30000;
                    cmd.Parameters.Add(new SqlParameter("userid", userid));
                    cmd.Parameters.Add(new SqlParameter("userid", type));
                    cmd.ExecuteNonQuery();

                    con.Close();
                    return 1;
                }
            }
            catch (Exception ex)
            {
                LogBuild.CreateLogger(JsonConvert.SerializeObject(ex), "BST_UpdateStatusCollect");
                return 0;
            }
        }

        public static int BST_SetRunCollect(string userid, string Code)
        {
            DataSet ds = new DataSet();
            try
            {
                using (var con = new SqlConnection(strConnTHUCTAP))
                {
                    con.Open();
                    SqlCommand cmd = new SqlCommand("BST_SetRunCollect", con);
                    cmd.CommandType = CommandType.StoredProcedure;
                    cmd.CommandTimeout = 30000;
                    cmd.Parameters.Add(new SqlParameter("userid", userid));
                    cmd.Parameters.Add(new SqlParameter("Code", Code));
                    cmd.ExecuteNonQuery();

                    con.Close();
                    return 1;
                }
            }
            catch (Exception ex)
            {
                LogBuild.CreateLogger(JsonConvert.SerializeObject(ex), "BST_SetRunCollect");
                return 0;
            }
        }

        public static int BST_CreateBST(string userid, string cateid)
        {
            DataSet ds = new DataSet();
            try
            {
                using (var con = new SqlConnection(strConnTHUCTAP))
                {
                    con.Open();
                    SqlCommand cmd = new SqlCommand("BST_CreateBST", con);
                    cmd.CommandType = CommandType.StoredProcedure;
                    cmd.CommandTimeout = 300;
                    cmd.Parameters.Add(new SqlParameter("userid", userid));
                    cmd.Parameters.Add(new SqlParameter("cateid", cateid));
                    cmd.ExecuteNonQuery();

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

        public static int BST_updateSP(string userid, int id, string slton)
        {
            DataSet ds = new DataSet();
            try
            {
                using (var con = new SqlConnection(strConnTHUCTAP))
                {
                    con.Open();
                    SqlCommand cmd = new SqlCommand("BST_updateSP", con);
                    cmd.CommandType = CommandType.StoredProcedure;
                    cmd.CommandTimeout = 30000;
                    cmd.Parameters.Add(new SqlParameter("userid", userid));
                    cmd.Parameters.Add(new SqlParameter("id", id));
                    cmd.Parameters.Add(new SqlParameter("slton", slton));
                    cmd.ExecuteNonQuery();

                    con.Close();
                    return 1;
                }
            }
            catch (Exception ex)
            {
                LogBuild.CreateLogger(JsonConvert.SerializeObject(ex), "BST_updateSP");
                return 0;
            }
        }
    }
}