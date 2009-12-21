using System;
using System.Collections.Generic;
using System.Text;
using System.Text.RegularExpressions;
using System.Data;
using System.Data.SqlClient;
using System.Windows.Forms;
using System.Xml;


namespace SSMP
{
    class HoTro
    {
        SqlConnection conn;
        SqlCommand cmd;
        SqlDataReader dr;
        SqlDataAdapter da;
        DataSet ds;

        public static string TenMayChu = "";
        public static string TenCoSoDuLieu = "";
        public static string TenDangNhap = "";
        public static string MatKhau = "";

        public static int maNguoiDung = 1;

        public HoTro()
        {
            try
            {
                string TepCauHinh = Application.StartupPath + "\\cauhinh.xml";
                XmlTextReader rd = new XmlTextReader(TepCauHinh);
                while (rd.Read())
                    if (rd.NodeType == XmlNodeType.Element)
                    {
                        if (rd.LocalName.Equals("TenMayChu"))
                            TenMayChu = rd.ReadString();
                        if (rd.LocalName.Equals("TenCoSoDuLieu"))
                            TenCoSoDuLieu = rd.ReadString();
                        if (rd.LocalName.Equals("TenDangNhap"))
                            TenDangNhap = rd.ReadString();
                        if (rd.LocalName.Equals("MatKhau"))
                            MatKhau = rd.ReadString();
                    }
                if (rd != null) rd.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            
        }

        public SqlConnection KetNoi()
        {
            try
            {
                string Xkn = "server=" + TenMayChu + ";database=" + TenCoSoDuLieu + ";uid=" + TenDangNhap + ";pwd=" + MatKhau + ";";
                conn = new SqlConnection(Xkn);
            }
            catch (Exception ex)
            {
                return null;
                MessageBox.Show(ex.Message);
            }
            return conn;
        }

        public static string DieuKienTaiLai(DataGridView dgv, string TenKhoaChinh)
        {
            int SoDong = dgv.Rows.Count;
            int Dem = 0;
            string Dk = "";

            while (Dem < SoDong - 1)
            {
                Dk += " or " + TenKhoaChinh + "=" + dgv.Rows[Dem].Cells[0].Value.ToString();
                ++Dem;
            }

            if (Dk.Trim().Length > 0)
                Dk = " where " + Dk.Substring(4);
            return Dk;
        }

        public void HienThiVaoDataGridView(DataGridView dgv, string CauLenh)
        {
            try
            {
                da = new SqlDataAdapter(CauLenh, KetNoi());
                ds = new DataSet();
                da.Fill(ds, "KetQua");
                dgv.DataSource = ds.Tables[0];
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        public void CapNhatDuLieu(SqlCommand cmd)
        {
            //try
            //{
                cmd.Connection = KetNoi();
                cmd.Connection.Open();
                cmd.ExecuteNonQuery();
            //}
        /*
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }*/
        }

        public void TaiDuLieu(ComboBox cbo, string TenBang, string TruongKhoa, string TruongHienThi)
        {
            try
            {
                string CauLenh = "";
                CauLenh = "select " + TruongKhoa + "," + TruongHienThi + " from " + TenBang;

                if (TenBang.Equals("Product")) CauLenh += " where StatusId = 1";


                da = new SqlDataAdapter(CauLenh, KetNoi());
                ds = new DataSet();
                da.Fill(ds, "KetQua");
                cbo.DataSource = ds.Tables[0];
                cbo.DisplayMember = TruongHienThi;
                cbo.ValueMember = TruongKhoa;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        public string DoiSangMaMD5(String XauKyTu)
        {
            System.Text.UTF8Encoding ue = new System.Text.UTF8Encoding();
            byte[] XauDangByte = ue.GetBytes(XauKyTu);

            System.Security.Cryptography.MD5CryptoServiceProvider md5 = new System.Security.Cryptography.MD5CryptoServiceProvider();
            byte[] BamDangByte = md5.ComputeHash(XauDangByte);

            string XauBam = "";
            int dem = 0;
            while (dem < BamDangByte.Length)
            {
                XauBam += Convert.ToString(BamDangByte[dem], 16).PadLeft(2, '0');
                ++dem;
            }
            return XauBam.PadLeft(32, '0');
        }

        public Int32 LayGiaTriTruongKhoaVuaChen(string TenBang, string TenTruongKhoa)
        {
            Int32 gt = 0;
            try
            {
                string CauLenh = "select max(" + TenTruongKhoa + ") from " + TenBang;
                cmd = new SqlCommand(CauLenh, KetNoi());
                cmd.Connection.Open();
                dr = cmd.ExecuteReader();
                if (dr.Read()) gt = dr.GetInt32(0);
            }
            catch (Exception ex)
            {
                return gt;
                MessageBox.Show(ex.Message);
            }
            finally
            {
                if (dr != null) dr.Close();
                if (cmd != null) cmd.Connection.Close();
            }
            return gt;
        }

        public Int64 LayGiaTriTruongKhoaVuaChen2(string TenBang, string TenTruongKhoa)
        {
            Int64 gt = 0;
            try
            {
                string CauLenh = "select max(" + TenTruongKhoa + ") from " + TenBang;
                cmd = new SqlCommand(CauLenh, KetNoi());
                cmd.Connection.Open();
                dr = cmd.ExecuteReader();
                if (dr.Read()) gt = dr.GetInt64(0);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
                return gt;
                
            }
            finally
            {
                if (dr != null) dr.Close();
                if (cmd != null) cmd.Connection.Close();
            }
            return gt;
        }

        public Int32 SoDongCuaBang(string CauLenh)
        {
            Int32 kq = 0;
            try
            {
                cmd = new SqlCommand(CauLenh, KetNoi());
                cmd.Connection.Open();
                dr = cmd.ExecuteReader();
                while (dr.Read())
                    ++kq;
            }
            catch (Exception ex)
            {
                kq = 0;
            }
            finally
            {
                try
                {
                    if (dr != null) dr.Close();
                    if (cmd != null) cmd.Connection.Close();
                }
                catch (Exception ex)
                {
                    kq = 0;
                }
            }
            return kq;
        }

        public Int32[] LayVeMangGiaTriKhoa(string CauLenh)
        {
            Int32[] gt = new Int32[SoDongCuaBang(CauLenh)]; ;
            Int32 Dem = 0;

            try
            {
                cmd = new SqlCommand(CauLenh, KetNoi());
                cmd.Connection.Open();
                dr = cmd.ExecuteReader();
                while (dr.Read())
                {
                    gt[Dem] = dr.GetInt32(0);
                    ++Dem;
                }
            }
            catch (Exception ex)
            {
                gt = null;

                MessageBox.Show(ex.Message);
            }
            finally
            {
                if (dr != null) dr.Close();
                if (cmd != null) cmd.Connection.Close();
            }
            return gt;
        }

        public string TenNguoiDung(Int32 MaNguoiDung)
        {
            string CauLenh = "", HoVaTen = "";
            CauLenh = "select NguoiDung from NguoiDung where MaNguoiDung=" + MaNguoiDung;
            try
            {
                cmd = new SqlCommand(CauLenh, KetNoi());
                cmd.Connection.Open();
                dr = cmd.ExecuteReader();
                if (dr.Read()) HoVaTen = dr.GetString(0);
            }
            catch (Exception ex)
            {
                HoVaTen = "";
            }
            finally
            {
                if (dr != null) dr.Close();
                if (cmd != null) cmd.Connection.Close();
            }

            return HoVaTen;
        }

        public DateTime LayDotNhapGanDayNhat()
        {
            DateTime DotNhap = DateTime.MinValue;

            string CauLenh = "";
            CauLenh = "select NgayThang from DotNhap where MaDotNhap>=(select max(MaDotNhap) from DotNhap)";
            try
            {
                cmd = new SqlCommand(CauLenh, KetNoi());
                cmd.Connection.Open();
                dr = cmd.ExecuteReader();
                if (dr.Read()) DotNhap = dr.GetDateTime(0);
            }
            catch (Exception ex)
            {
                DotNhap = DateTime.MinValue;
            }
            finally
            {
                if (dr != null) dr.Close();
                if (cmd != null) cmd.Connection.Close();
            }
            return DotNhap;
        }


        public Int32 LayVeKhoa(string TenBang, string TenTruongKhoa, string TenTruong, string GiaTri)
        {
            string CauLenh = "select " + TenTruongKhoa + " from " + TenBang + " where " + TenTruong + "=N'" + GiaTri + "'";
            try
            {
                cmd = new SqlCommand(CauLenh, KetNoi());
                cmd.Connection.Open();
                dr = cmd.ExecuteReader();
                if (dr.Read()) return dr.GetInt32(0);
            }
            catch (Exception ex)
            {
                return 0;
            }
            finally
            {
                if (dr != null) dr.Close();
                if (cmd != null) cmd.Connection.Close();
            }
            return 0;
        }

        public String LayVeKhoa2(string TenBang, string TenTruongKhoa, string TenTruong, string GiaTri)
        {
            string CauLenh = "select " + TenTruongKhoa + " from " + TenBang + " where " + TenTruong + "=N'" + GiaTri + "'";
            try
            {
                cmd = new SqlCommand(CauLenh, KetNoi());
                cmd.Connection.Open();
                String khoa = cmd.ExecuteScalar().ToString();
                return khoa;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
                return null;
            }
            finally
            {
                if (cmd != null) cmd.Connection.Close();
            }
            return null;
        }

        public static bool isEmpty(String s)
        {
            if (s.Equals("") || s.Equals(null)) return true;
            return false;
        }

        public DateTime toSQLDateTime(String s)
        {
            try
            {
                String[] dateTimeS = null;
                if (s.LastIndexOf("-") > 0)
                {
                    dateTimeS = s.Split('-');
                }
                else if (s.LastIndexOf("/") > 0)
                {
                    dateTimeS = s.Split('/');
                }
                return new DateTime(Int32.Parse(dateTimeS[2]), Int32.Parse(dateTimeS[1]), Int32.Parse(dateTimeS[0]));
            }
            catch (Exception e) {
                return new DateTime(1990, 1, 1);
            }
        }

        public static void baoLoi(String s) {
            MessageBox.Show(s, "Báo lỗi", MessageBoxButtons.OK, MessageBoxIcon.Warning) ;
        }

        public static void thongBao(string s) {
            MessageBox.Show(s, "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        public static bool IsWholeNumber(String strNumber)
        {
            Regex objNotWholePattern = new Regex("[^0-9]");
            return !objNotWholePattern.IsMatch(strNumber);
        }
    }
}
