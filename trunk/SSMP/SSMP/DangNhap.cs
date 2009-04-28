using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace SSMP
{
    public partial class DangNhap : Form
    {
        public static int idNguoiDung = 0;
        public static string tenDangNhap = null;
        public static int quyenNguoiDung = 0;
        private frmGiaoDienChinh giaoDienChinh = null;

        public DangNhap()
        {
            InitializeComponent();
        }

        public void setGiaoDienChinh(Form f) {
            giaoDienChinh = (frmGiaoDienChinh)f;
        }

        private void buttonDangNhap_Click(object sender, EventArgs e)
        {
            String uname = textBoxTen.Text;
            String pass = textBoxPass.Text;
            if (HoTro.isEmpty(uname))
            {
                MessageBox.Show(this, "Bạn chưa nhập tên đăng nhập!", "Thông Báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                textBoxTen.Focus();
                textBoxTen.SelectAll();
                return;
            }
            if (HoTro.isEmpty(pass))
            {
                MessageBox.Show(this, "Bạn chưa nhập mật khẩu!", "Thông Báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                textBoxPass.Focus();
                textBoxPass.SelectAll();
                return;
            }
            try
            {
                HoTro ht = new HoTro();
                SqlConnection con = ht.KetNoi();
                con.Open();
                string comm = "select UserId, Username, UserStatusId, UserRoleId from Users where Username = '" + uname + "' and password='" + pass + "'" ; 
                SqlDataAdapter adapter = new SqlDataAdapter(comm, con);
                DataTable table = new DataTable() ;
                adapter.Fill(table);
                if (table.Rows.Count == 0) {
                    MessageBox.Show(this, "Tên đăng nhập hoặc mật khẩu không đúng", "Lỗi đăng nhập", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    textBoxTen.Focus();
                    textBoxTen.SelectAll();
                }
                else if (Int32.Parse(table.Rows[0].ItemArray[2].ToString()) != 1)
                { // check status
                    MessageBox.Show(this, "Tài khoản của bạn đang bị khóa! Hãy liên lạc với người quản trị hệ thống !", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Stop);
                }
                else { // dang  nhap thanh cong
                    MessageBox.Show(this, "Đăng nhập thành công !", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    idNguoiDung = Int32.Parse(table.Rows[0].ItemArray[0].ToString()) ;
                    tenDangNhap = table.Rows[0].ItemArray[1].ToString();
                    quyenNguoiDung = Int32.Parse(table.Rows[0].ItemArray[3].ToString());

                    //giaoDienChinh.enableMenu(1);
                    this.Dispose();
                }
                con.Close();
            } catch (Exception ex) {
                MessageBox.Show(ex.Message) ;
            }            
        }

        private void buttonHuy_Click(object sender, EventArgs e)
        {
            this.Dispose();
        }
    }
}