using Newtonsoft.Json;
using ProductAllTool.Models.ManageSales;
using ProductAllTool.Models.MDS;
using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Web;

namespace ProductAllTool.DataAccess
{
    public class DataAccessMDSItem
    {
        private static string strConnTHUCTAP = ConfigurationManager.AppSettings.Get("strConnTHUCTAP");

        public static List<objCombox> MDS_cboNCC()
        {
            List<objCombox> it_r = new List<objCombox>();
            using (var con = new SqlConnection(strConnTHUCTAP))
            {
                con.Open();
                try
                {
                    SqlCommand cmd = new SqlCommand("MDS_cboNCC", con);
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
                    LogBuild.CreateLogger(JsonConvert.SerializeObject(ex), "MDS_cboNCC");
                    return it_r;
                }
            }
        }

        public static List<objCombox> MDS_cboNCC1()
        {
            List<objCombox> it_r = new List<objCombox>();
            using (var con = new SqlConnection(strConnTHUCTAP))
            {
                con.Open();
                try
                {
                    SqlCommand cmd = new SqlCommand("MDS_cboNCC1", con);
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
                    LogBuild.CreateLogger(JsonConvert.SerializeObject(ex), "MDS_cboNCC1");
                    return it_r;
                }
            }
        }

        public static List<objCombox> MDS_cboFunc()
        {
            List<objCombox> it_r = new List<objCombox>();
            using (var con = new SqlConnection(strConnTHUCTAP))
            {
                con.Open();
                try
                {
                    SqlCommand cmd = new SqlCommand("MDS_cboFunc", con);
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
                    LogBuild.CreateLogger(JsonConvert.SerializeObject(ex), "MDS_cboFunc");
                    return it_r;
                }
            }
        }

        public static List<objCombox> MDS_cboDivision()
        {
            List<objCombox> it_r = new List<objCombox>();
            using (var con = new SqlConnection(strConnTHUCTAP))
            {
                con.Open();
                try
                {
                    SqlCommand cmd = new SqlCommand("MDS_cboDivision", con);
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
                    LogBuild.CreateLogger(JsonConvert.SerializeObject(ex), "MDS_cboDivision");
                    return it_r;
                }
            }
        }

        public static List<objCombox> MDS_cboCategory()
        {
            List<objCombox> it_r = new List<objCombox>();
            using (var con = new SqlConnection(strConnTHUCTAP))
            {
                con.Open();
                try
                {
                    SqlCommand cmd = new SqlCommand("MDS_cboCategory", con);
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
                    LogBuild.CreateLogger(JsonConvert.SerializeObject(ex), "MDS_cboCategory");
                    return it_r;
                }
            }
        }

        public static List<objCombox> MDS_cboGroup()
        {
            List<objCombox> it_r = new List<objCombox>();
            using (var con = new SqlConnection(strConnTHUCTAP))
            {
                con.Open();
                try
                {
                    SqlCommand cmd = new SqlCommand("MDS_cboGroup", con);
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
                    LogBuild.CreateLogger(JsonConvert.SerializeObject(ex), "MDS_cboGroup");
                    return it_r;
                }
            }
        }

        public static List<objCombox> MDS_cboDivision18()
        {
            List<objCombox> it_r = new List<objCombox>();
            using (var con = new SqlConnection(strConnTHUCTAP))
            {
                con.Open();
                try
                {
                    SqlCommand cmd = new SqlCommand("MDS_cboDivision18", con);
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
                    LogBuild.CreateLogger(JsonConvert.SerializeObject(ex), "MDS_cboDivision18");
                    return it_r;
                }
            }
        }

        public static List<objCombox> MDS_cboCategory18()
        {
            List<objCombox> it_r = new List<objCombox>();
            using (var con = new SqlConnection(strConnTHUCTAP))
            {
                con.Open();
                try
                {
                    SqlCommand cmd = new SqlCommand("MDS_cboCategory18", con);
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
                    LogBuild.CreateLogger(JsonConvert.SerializeObject(ex), "MDS_cboCategory18");
                    return it_r;
                }
            }
        }

        public static List<objCombox> MDS_cboGroup18()
        {
            List<objCombox> it_r = new List<objCombox>();
            using (var con = new SqlConnection(strConnTHUCTAP))
            {
                con.Open();
                try
                {
                    SqlCommand cmd = new SqlCommand("MDS_cboGroup18", con);
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
                    LogBuild.CreateLogger(JsonConvert.SerializeObject(ex), "MDS_cboGroup18");
                    return it_r;
                }
            }
        }

        public static List<objCombox> MDS_cboHHKG()
        {
            List<objCombox> it_r = new List<objCombox>();
            using (var con = new SqlConnection(strConnTHUCTAP))
            {
                con.Open();
                try
                {
                    SqlCommand cmd = new SqlCommand("MDS_cboHHKG", con);
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
                    LogBuild.CreateLogger(JsonConvert.SerializeObject(ex), "MDS_cboHHKG");
                    return it_r;
                }
            }
        }

        public static List<objCombox> MDS_cboMuaVu()
        {
            List<objCombox> it_r = new List<objCombox>();
            using (var con = new SqlConnection(strConnTHUCTAP))
            {
                con.Open();
                try
                {
                    SqlCommand cmd = new SqlCommand("MDS_cboMuaVu", con);
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
                    LogBuild.CreateLogger(JsonConvert.SerializeObject(ex), "MDS_cboMuaVu");
                    return it_r;
                }
            }
        }

        public static List<objCombox> MDS_cboThuongHieu()
        {
            List<objCombox> it_r = new List<objCombox>();
            using (var con = new SqlConnection(strConnTHUCTAP))
            {
                con.Open();
                try
                {
                    SqlCommand cmd = new SqlCommand("MDS_cboThuongHieu", con);
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
                    LogBuild.CreateLogger(JsonConvert.SerializeObject(ex), "MDS_cboThuongHieu");
                    return it_r;
                }
            }
        }

        public static List<objCombox> MDS_cboNguonNhap()
        {
            List<objCombox> it_r = new List<objCombox>();
            using (var con = new SqlConnection(strConnTHUCTAP))
            {
                con.Open();
                try
                {
                    SqlCommand cmd = new SqlCommand("MDS_cboNguonNhap", con);
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
                    LogBuild.CreateLogger(JsonConvert.SerializeObject(ex), "MDS_cboNguonNhap");
                    return it_r;
                }
            }
        }

        public static List<objCombox> MDS_cboXuatSu()
        {
            List<objCombox> it_r = new List<objCombox>();
            using (var con = new SqlConnection(strConnTHUCTAP))
            {
                con.Open();
                try
                {
                    SqlCommand cmd = new SqlCommand("MDS_cboXuatSu", con);
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
                    LogBuild.CreateLogger(JsonConvert.SerializeObject(ex), "MDS_cboXuatSu");
                    return it_r;
                }
            }
        }

        public static List<objCombox> MDS_cboDVT()
        {
            List<objCombox> it_r = new List<objCombox>();
            using (var con = new SqlConnection(strConnTHUCTAP))
            {
                con.Open();
                try
                {
                    SqlCommand cmd = new SqlCommand("MDS_cboDVT", con);
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
                    LogBuild.CreateLogger(JsonConvert.SerializeObject(ex), "MDS_cboDVT");
                    return it_r;
                }
            }
        }

        public static List<objCombox> MDS_cboSP()
        {
            List<objCombox> it_r = new List<objCombox>();
            using (var con = new SqlConnection(strConnTHUCTAP))
            {
                con.Open();
                try
                {
                    SqlCommand cmd = new SqlCommand("MDS_cboSP", con);
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
                    LogBuild.CreateLogger(JsonConvert.SerializeObject(ex), "MDS_cboSP");
                    return it_r;
                }
            }
        }

        public static DataTable MDS_GetTblDSItem(string userid, string NCC, string TenSP)
        {
            DataSet ds = new DataSet();
            try
            {
                using (var con = new SqlConnection(strConnTHUCTAP))
                {
                    con.Open();
                    SqlCommand cmd = new SqlCommand("MDS_GetTblDSItem", con);
                    cmd.CommandType = CommandType.StoredProcedure;
                    cmd.CommandTimeout = 30000;
                    cmd.Parameters.Add(new SqlParameter("userid", userid));
                    cmd.Parameters.Add(new SqlParameter("NCC", NCC));
                    cmd.Parameters.Add(new SqlParameter("TenSP", TenSP));
                    using (SqlDataAdapter sda = new SqlDataAdapter(cmd))
                    { sda.Fill(ds); }

                    con.Close();
                    return ds.Tables[0];
                }
            }
            catch (Exception ex)
            {
                LogBuild.CreateLogger(JsonConvert.SerializeObject(ex), "MDS_GetTblDSItem");
                return ds.Tables[0];
            }
        }

        public static DataTable MDS_GetTblDSItem1(string userid, string NCC, string TenSP)
        {
            DataSet ds = new DataSet();
            try
            {
                using (var con = new SqlConnection(strConnTHUCTAP))
                {
                    con.Open();
                    SqlCommand cmd = new SqlCommand("MDS_GetTblDSItem1", con);
                    cmd.CommandType = CommandType.StoredProcedure;
                    cmd.CommandTimeout = 30000;
                    cmd.Parameters.Add(new SqlParameter("userid", userid));
                    cmd.Parameters.Add(new SqlParameter("NCC", NCC));
                    cmd.Parameters.Add(new SqlParameter("TenSP", TenSP));
                    using (SqlDataAdapter sda = new SqlDataAdapter(cmd))
                    { sda.Fill(ds); }

                    con.Close();
                    return ds.Tables[0];
                }
            }
            catch (Exception ex)
            {
                LogBuild.CreateLogger(JsonConvert.SerializeObject(ex), "MDS_GetTblDSItem1");
                return ds.Tables[0];
            }
        }

        public static int MDS_setTrangThai(string userid, int ID)
        {
            DataSet ds = new DataSet();
            try
            {
                using (var con = new SqlConnection(strConnTHUCTAP))
                {
                    con.Open();
                    SqlCommand cmd = new SqlCommand("MDS_setTrangThai", con);
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
                LogBuild.CreateLogger(JsonConvert.SerializeObject(ex), "MDS_setTrangThai");
                return 0;
            }
        }

        public static int MDS_setTrangThai1(string userid, int ID)
        {
            DataSet ds = new DataSet();
            try
            {
                using (var con = new SqlConnection(strConnTHUCTAP))
                {
                    con.Open();
                    SqlCommand cmd = new SqlCommand("MDS_setTrangThai1", con);
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
                LogBuild.CreateLogger(JsonConvert.SerializeObject(ex), "MDS_setTrangThai1");
                return 0;
            }
        }

        public static int MDS_CreateItem(string userid, MDSModel lst)
        {
            try
            {
                using (var con = new SqlConnection(strConnTHUCTAP))
                {
                    con.Open();
                    SqlCommand cmd = new SqlCommand("MDS_CreateItem", con);
                    cmd.CommandType = CommandType.StoredProcedure;

                    cmd.Parameters.Add(new SqlParameter("userid", userid));
                    cmd.Parameters.Add(new SqlParameter("NCC", lst.NCC));
                    cmd.Parameters.Add(new SqlParameter("TenSP", lst.TenSP));
                    cmd.Parameters.Add(new SqlParameter("Barcode", lst.Barcode));
                    cmd.Parameters.Add(new SqlParameter("Func", lst.Func));
                    cmd.Parameters.Add(new SqlParameter("DivE", lst.DivE));
                    cmd.Parameters.Add(new SqlParameter("CatE", lst.CatE));
                    cmd.Parameters.Add(new SqlParameter("GroE", lst.GroE));
                    cmd.Parameters.Add(new SqlParameter("Div18", lst.Div18));
                    cmd.Parameters.Add(new SqlParameter("Cat18", lst.Cat18));
                    cmd.Parameters.Add(new SqlParameter("Gro18", lst.Gro18));
                    cmd.Parameters.Add(new SqlParameter("HH", lst.HH));
                    cmd.Parameters.Add(new SqlParameter("MuaVu", lst.MuaVu));
                    cmd.Parameters.Add(new SqlParameter("ThuongHieu", lst.ThuongHieu));
                    cmd.Parameters.Add(new SqlParameter("NguonNhap", lst.NguonNhap));
                    cmd.Parameters.Add(new SqlParameter("XuatXu", lst.XuatXu));
                    cmd.Parameters.Add(new SqlParameter("DVT", lst.DVT));
                    cmd.Parameters.Add(new SqlParameter("TrongLuong", lst.TrongLuong));
                    cmd.Parameters.Add(new SqlParameter("Cao", lst.Cao));
                    cmd.Parameters.Add(new SqlParameter("Rong", lst.Rong));
                    cmd.Parameters.Add(new SqlParameter("Sau", lst.Sau));
                    cmd.Parameters.Add(new SqlParameter("CaoHop", lst.CaoHop));
                    cmd.Parameters.Add(new SqlParameter("RongHop", lst.RongHop));
                    cmd.Parameters.Add(new SqlParameter("SauHop", lst.SauHop));
                    cmd.Parameters.Add(new SqlParameter("GiaMua1", lst.GiaMua1));
                    cmd.Parameters.Add(new SqlParameter("Line", lst.Line));
                    cmd.Parameters.Add(new SqlParameter("VAT", lst.VAT));
                    cmd.Parameters.Add(new SqlParameter("GiaMua2", lst.GiaMua2));
                    cmd.Parameters.Add(new SqlParameter("GiaNY", lst.GiaNY));

                    var reader = cmd.ExecuteNonQuery();

                    con.Close();

                    return 1;
                }
            }
            catch (Exception ex)
            {
                LogBuild.CreateLogger(JsonConvert.SerializeObject(ex), "MDS_CreateItem");
                return 0;
            }
        }
    }
}