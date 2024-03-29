using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using System.Data.SqlClient;
using SSMP.Core.Domain;
using SSMP.Data.Manager;

namespace SSMP
{
    public partial class DangNhap : Form
    {
        public static int idNguoiDung = 0;
        public static string tenDangNhap = null;
        public static int quyenNguoiDung = 0;
        private frmGiaoDienChinh giaoDienChinh = null;
        private UserManager userManager;
        private RoleDetailManager roleDetailManager;

        public DangNhap()
        {
            InitializeComponent();

            //
            userManager = new UserManager();
            roleDetailManager = new RoleDetailManager();
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
                //HoTro ht = new HoTro();
                //SqlConnection con = ht.KetNoi();
                //con.Open();
                //string comm = "select UserId, Username, UserStatusId, UserRoleId from Users where Username = '" + uname + "' and password='" + pass + "'" ; 
                //SqlDataAdapter adapter = new SqlDataAdapter(comm, con);
                //DataTable table = new DataTable() ;
                //adapter.Fill(table);
                //if (table.Rows.Count == 0) {
                //    MessageBox.Show(this, "Tên đăng nhập hoặc mật khẩu không đúng", "Lỗi đăng nhập", MessageBoxButtons.OK, MessageBoxIcon.Error);
                //    textBoxTen.Focus();
                //    textBoxTen.SelectAll();
                //}
                //else if (Int32.Parse(table.Rows[0].ItemArray[2].ToString()) != 1)
                //{ // check status
                //    MessageBox.Show(this, "Tài khoản của bạn đang bị khóa! Hãy liên lạc với người quản trị hệ thống !", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Stop);
                //}
                //else { // dang  nhap thanh cong
                //    MessageBox.Show(this, "Đăng nhập thành công !", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                //    idNguoiDung = Int32.Parse(table.Rows[0].ItemArray[0].ToString()) ;
                //    tenDangNhap = table.Rows[0].ItemArray[1].ToString();
                //    quyenNguoiDung = Int32.Parse(table.Rows[0].ItemArray[3].ToString());

                //    //giaoDienChinh.enableMenu(1);
                //    this.Dispose();
                //}
                //con.Close();
                User objUser = userManager.GetUserByUserPass(uname, new HoTro().DoiSangMaMD5(pass));

                if (objUser != null)
                {
                    if (objUser.UserStatusId == 2) //Hard code
                    {
                        MessageBox.Show(this, "Tài khoản của bạn đang bị khóa! Hãy liên lạc với người quản trị hệ thống !", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Stop);
                    }
                    else
                    {
                        idNguoiDung = objUser.ID;
                        tenDangNhap = objUser.FullName;
                        giaoDienChinh.SessionUsername = objUser.Username;
                        giaoDienChinh.SessionFullname = objUser.FullName;
                        giaoDienChinh.SetStatusText("Xin chào: " + objUser.FullName);

                        //Check role detail
                        List<RoleDetail> listRoleDetail = roleDetailManager.GetListByRole(objUser.UserRoleId);
                                                
                        giaoDienChinh.ShowHideDangNhap(false);
                        giaoDienChinh.ShowHideDangXuat(true);
                        giaoDienChinh.ShowHideDoiMatKhau(true);

                        foreach (RoleDetail objRoleDetail in listRoleDetail)
                        {
                            switch (objRoleDetail.ID.MenuId)
                            {
                                case 1:
                                    if (objRoleDetail.Enable == 1) { giaoDienChinh.ShowHideCauHinh(true); } else { giaoDienChinh.ShowHideCauHinh(false); }
                                    break;
                                case 2:
                                    if (objRoleDetail.Enable == 1) { giaoDienChinh.ShowHideBanHang(true); } else { giaoDienChinh.ShowHideBanHang(false); }
                                    break;
                                case 3:
                                    if (objRoleDetail.Enable == 1) { giaoDienChinh.ShowHideNhapHang(true); } else { giaoDienChinh.ShowHideNhapHang(false); }
                                    break;
                                case 4:
                                    if (objRoleDetail.Enable == 1) { giaoDienChinh.ShowHideQuanLyDanhMuc(true); } else { giaoDienChinh.ShowHideQuanLyDanhMuc(false); }
                                    break;
                                case 5:
                                    if (objRoleDetail.Enable == 1) { giaoDienChinh.ShowHideQuanTri(true); } else { giaoDienChinh.ShowHideQuanTri(false); }
                                    break;
                            }
                        }

                        if (objUser.UserRoleId != 1) //Khong phai Quan tri he thong
                        {
                            giaoDienChinh.ShowHideCauHinh(false);
                        }
                        else
                        {
                            giaoDienChinh.ShowHideCauHinh(true);
                        }

                        this.Dispose();
                    }
                }
                else
                {
                    MessageBox.Show(this, "Tên đăng nhập hoặc mật khẩu không đúng", "Lỗi đăng nhập", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }

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