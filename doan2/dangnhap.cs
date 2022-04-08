using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace doan2
{
    public partial class dangnhap : Form
    {
        public dangnhap()
        {
            InitializeComponent();
        }

        private void txtMatKhau_TextChanged(object sender, EventArgs e)
        {
            string txt = txtMatKhau.Text;
            txtMatKhau.PasswordChar = '*';
            if (Control.IsKeyLocked(Keys.CapsLock))
            {
                label1.Text = "The Caps Lock key is ON";
            }
            else
            {
                label1.Text = "";
            }    
        }

        private void cbHienthiMK_CheckedChanged(object sender, EventArgs e)
        {
         
            if (cbHienthiMK.Checked == true)
            {
                txtMatKhau.PasswordChar = (char)0;
            }
            else
            {
                txtMatKhau.PasswordChar = '*';
            }
        }

        private void btnThoat_Click(object sender, EventArgs e)
        {
            DialogResult thongbao;
            thongbao = (MessageBox.Show("Bạn có muốn thoát?", "Note", MessageBoxButtons.YesNo, MessageBoxIcon.Warning));
            if (thongbao == DialogResult.Yes)
                Application.Exit();
        }

        private void Form2_Load(object sender, EventArgs e)
        {

        }
        public static
            string magv, masv; //lay ma
        private void btnDangNhap_Click(object sender, EventArgs e)
        {
            if(txtTaiKhoan.Text.Length == 0 || txtMatKhau.Text.Length ==0)
            {
                MessageBox.Show("Nhập chưa đủ dữ liệu");
            }
            else
            {
                Connection ketnoi = new Connection();
                ketnoi.openConn();
                string sql = "SELECT COUNT(*) FROM GIAOVIEN WHERE TAIKHOAN='" + txtTaiKhoan.Text + "' AND MATKHAU='" + txtMatKhau.Text + "'";
                string sql1 = "SELECT COUNT(*) FROM SINHVIEN WHERE TAIKHOANSV='" + txtTaiKhoan.Text + "' AND MATKHAUSV='" + txtMatKhau.Text + "'";
                DataTable dt = ketnoi.loadDataTable(sql);
                DataTable dt1 = ketnoi.loadDataTable(sql1);
                ketnoi.closeConn();
                if (dt.Rows[0][0].ToString() == "1")
                {
                    string sql4 = "SELECT MAQUYEN FROM GIAOVIEN WHERE TAIKHOAN='" + txtTaiKhoan.Text + "' AND MATKHAU='" + txtMatKhau.Text + "'";
                    DataTable dt3 = ketnoi.loadDataTable(sql4);
                    if (dt3.Rows[0][0].ToString() == "3")    //quan tri
                    {
                        string sql3 = "SELECT MAGV FROM GIAOVIEN WHERE TAIKHOAN='" + txtTaiKhoan.Text + "' AND MATKHAU='" + txtMatKhau.Text + "'";
                        DataTable dt2 = ketnoi.loadDataTable(sql3);                 
                        magv = dt2.Rows[0][0].ToString();
                        Quanli a = new Quanli();
                        a.Show();
                        this.Hide();
                    }
                    else if (dt3.Rows[0][0].ToString() == "1")
                    {
                        string sql3 = "SELECT MAGV FROM GIAOVIEN WHERE TAIKHOAN='" + txtTaiKhoan.Text + "' AND MATKHAU='" + txtMatKhau.Text + "'";
                        DataTable dt2 = ketnoi.loadDataTable(sql3);
                        magv = dt2.Rows[0][0].ToString();
                        giaovien gv = new giaovien();                            
                        gv.Show();                                
                        this.Hide();

                    }
                    else
                    {
                        MessageBox.Show("Sửa lại mã quyền cho tài khoản giáo viên này vì có mã quyền là sinh viên"); //check trong csdl roi 
                    }                        
                 
                 

                }
                else if (dt1.Rows[0][0].ToString() == "1")
                {
                    string sql5 = "SELECT MASV FROM SINHVIEN WHERE TAIKHOANSV='" + txtTaiKhoan.Text + "' AND MATKHAUSV='" + txtMatKhau.Text + "'";
                    DataTable dt5 = ketnoi.loadDataTable(sql5);
                    masv = dt5.Rows[0][0].ToString();
                    sinhvien sv = new sinhvien();
                    sv.Show();
                   
                    this.Hide();
                }
                else
                {
                    MessageBox.Show("Nhập sai tài khoản hoặc mật khẩu");
                    txtTaiKhoan.Clear();
                    txtMatKhau.Clear();
                }
            }
        }
    }
}
