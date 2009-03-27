using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using System.Xml;
using System.Runtime.Serialization;
using System.Runtime.Serialization.Formatters.Binary;
using System.IO;
using System.Collections;

namespace SSMP
{
    public partial class FrmConfig : Form
    {
        public FrmConfig()
        {
            InitializeComponent();
        }

        private void btnXoaTrang_Click(object sender, EventArgs e)
        {
            txtTenMayChu.Text = "";
            txtCoSoDuLieu.Text = "";
            txtTenDangNhap.Text = "";
            txtMatKhau.Text = "";
        }

        private void frmCauHinh_Load(object sender, EventArgs e)
        {
            this.Location = new Point((this.MdiParent.ClientSize.Width-this.Width)/2,(this.MdiParent.ClientSize.Height-this.Height)/2-100);

            try
            {
                string TepCauHinh = Application.StartupPath + "\\cauhinh.xml";
                XmlTextReader rd = new XmlTextReader(TepCauHinh);

                string TenMayChu = "";
                string TenCoSoDuLieu = "";
                string TenDangNhap = "";
                string MatKhau = "";

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

                txtTenMayChu.Text = TenMayChu;
                txtCoSoDuLieu.Text = TenCoSoDuLieu;
                txtTenDangNhap.Text = TenDangNhap;
                txtMatKhau.Text = MatKhau;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Nhập thông tin để cấu hình hệ thống!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void btnCauHinh_Click(object sender, EventArgs e)
        {
            if (txtTenMayChu.Text.Trim().Length == 0)
            {
                MessageBox.Show("Tên máy chủ không được để trống","Báo lỗi",MessageBoxButtons.OK,MessageBoxIcon.Error);
                txtTenMayChu.Focus();
                return;
            }

            if (txtCoSoDuLieu.Text.Trim().Length == 0)
            {
                MessageBox.Show("Tên cơ sở dữ liệu không được để trống", "Báo lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txtCoSoDuLieu.Focus();
                return;
            }

            if (txtTenDangNhap.Text.Trim().Length == 0)
            {
                MessageBox.Show("Tên đăng nhập không được để trống", "Báo lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txtTenDangNhap.Focus();
                return;
            }

            string TenMayChu = txtTenMayChu.Text;
            string TenCoSoDuLieu = txtCoSoDuLieu.Text;
            string TenDangNhap = txtTenDangNhap.Text;
            string MatKhau = txtMatKhau.Text;
            SqlConnection conn=null;
            SqlCommand cmd=null;
            SqlDataReader dr=null;

            //kiem tra ket noi
            try
            {
                string XauKetNoi = "server=" + TenMayChu + ";database=" + TenCoSoDuLieu + ";uid=" + TenDangNhap + ";pwd=" + MatKhau;
                conn = new SqlConnection(XauKetNoi);
                cmd = new SqlCommand("select * from Users", conn);
                cmd.Connection.Open();
                dr = cmd.ExecuteReader();

                string TepCauHinh = Application.StartupPath + "\\cauhinh.xml";

                XmlTextWriter wr = new XmlTextWriter(TepCauHinh, null);

                wr.Formatting = Formatting.Indented;
                wr.Indentation = 6;

                wr.WriteStartDocument();

                wr.WriteStartElement("", "CauHinh", "");

                wr.WriteStartElement("", "TenMayChu", "");
                wr.WriteString(TenMayChu);
                wr.WriteEndElement();

                wr.WriteStartElement("", "TenCoSoDuLieu", "");
                wr.WriteString(TenCoSoDuLieu);
                wr.WriteEndElement();

                wr.WriteStartElement("", "TenDangNhap", "");
                wr.WriteString(TenDangNhap);
                wr.WriteEndElement();

                wr.WriteStartElement("", "MatKhau", "");
                wr.WriteString(MatKhau);
                wr.WriteEndElement();

                wr.WriteEndElement();

                wr.WriteEndDocument();

                wr.Flush();
                wr.Close();

                Config config = new Config();
                BinaryFormatter formatter = new BinaryFormatter();
                FileStream fStream;

                if (File.Exists(Constants.CONFIG_FILE))
                {
                    fStream = new FileStream(Constants.CONFIG_FILE, FileMode.Open);
                    config = (Config)formatter.Deserialize(fStream);
                }
                else
                {
                    fStream = new FileStream(Constants.CONFIG_FILE, FileMode.Create);

                    config.Server = TenMayChu;
                    config.Database = TenCoSoDuLieu;
                    config.Username = TenDangNhap;
                    config.Password = MatKhau;

                    formatter.Serialize(fStream, config);
                }

                MessageBox.Show("Cấu hình máy chủ thành công!", Constants.INFO, MessageBoxButtons.OK, MessageBoxIcon.Information);
                this.Dispose();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Thông tin cấu hình sai!", Constants.ERROR, MessageBoxButtons.OK, MessageBoxIcon.Error);
                txtTenMayChu.Focus();
                txtTenMayChu.SelectAll();
                MessageBox.Show(ex.Message);
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
                    MessageBox.Show("Lỗi đóng kết nối đến cơ sở dữ liệu!","Báo lỗi",MessageBoxButtons.OK,MessageBoxIcon.Error);
                }
            }

            
        }
    }
}