using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using System.Xml;
using System.Data.SqlClient;

namespace SSMP
{
    public partial class frmDoiMatKhau : Form
    {
        public frmDoiMatKhau()
        {
            InitializeComponent();
        }

        private void btnXoaTrang_Click(object sender, EventArgs e)
        {
            txtMatKhauCu.Text = "";
            txtMatKhauMoi.Text = "";
            txtXacNhanLaiMatKhau.Text = "";
        }

        private void frmDoiMatKhau_Load(object sender, EventArgs e)
        {
            this.Location = new Point((this.MdiParent.ClientSize.Width-this.Width)/2,(this.MdiParent.ClientSize.Height-this.Height)/2-100);
        }

        private void btnDoiMatKhau_Click(object sender, EventArgs e)
        {
            //kiem tra mat khau cu khac rong
            if (txtMatKhauCu.Text.Length == 0)
            {
                MessageBox.Show(this, "Mật khẩu cũ không được trống", "Thông báo", MessageBoxButtons.OK);
                txtMatKhauCu.Focus();
                txtMatKhauCu.SelectAll();
                return;
            }

            //kiem tra mat khau moi khac rong
            else if (txtMatKhauMoi.Text.Length == 0)
            {
                MessageBox.Show(this, "Mật khẩu mới không được trống", "Thông báo", MessageBoxButtons.OK);
                txtMatKhauMoi.Focus();
                txtMatKhauMoi.SelectAll();
                return;
            }

            //kiem tra go lai mat khau giong mat khau
            else if (!txtMatKhauMoi.Text.Equals(txtXacNhanLaiMatKhau.Text))
            {
                MessageBox.Show(this, "Mật khẩu mới không trùng nhau", "Thông báo", MessageBoxButtons.OK);
                txtXacNhanLaiMatKhau.Focus();
                txtXacNhanLaiMatKhau.SelectAll();
                return;
            }
            else
            {
                try
                {
                    int userId = DangNhap.idNguoiDung;
                    HoTro ht = new HoTro();
                    SqlConnection conn = ht.KetNoi() ;
                    conn.Open();
                    SqlCommand comm = new SqlCommand("select password from Users where UserId=" + userId, conn);
                    string oldPass = comm.ExecuteScalar().ToString();
                    if (!oldPass.Equals(txtMatKhauCu.Text))
                    {
                        MessageBox.Show(this, "Mật khẩu cũ không đúng !", "Lỗi nhập mật khẩu cũ", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        txtMatKhauCu.Focus();
                        txtMatKhauCu.SelectAll();
                        return;
                    }
                    else {
                        comm = new SqlCommand("update Users set Password='" + txtMatKhauMoi.Text + "' where userId = " + userId, conn);
                        comm.ExecuteNonQuery();
                        MessageBox.Show(this, "Bạn đã thay đổi mật khẩu thành công!", "Thông báo thay đổi mật khẩu thành công");
                        this.Dispose();
                    }
                    conn.Close();
                }
                catch (Exception ex) {
                    MessageBox.Show(ex.Message);                   
                }
            }

        }
    }
}