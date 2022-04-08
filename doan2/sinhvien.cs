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
    public partial class sinhvien : Form
    {
        public sinhvien()
        {
            InitializeComponent();
        }

        private void sinhvien_Load(object sender, EventArgs e)
        {

        }
        String masv = dangnhap.masv;

        void nhandangsinhvien()
        {
            try
            {
                Connection ketnoi = new Connection();
                ketnoi.openConn();
                string sql = "SELECT MASV,TENSV,TENKHOASV,TENKHOA FROM dbo.SINHVIEN,dbo.KHOACHUYENNGANH,dbo.KHOA WHERE dbo.SINHVIEN.MAKHOASV = dbo.KHOA.MAKHOASV AND dbo.SINHVIEN.MAKHOA=dbo.KHOACHUYENNGANH.MAKHOA AND MASV='" + masv + "'";
                DataTable dt = ketnoi.loadDataTable(sql);
                txtmsv.Text = dt.Rows[0][0].ToString();
                txttsv.Text = dt.Rows[0][1].ToString();
                txtkhoa.Text = dt.Rows[0][2].ToString();
                txtkhoacn.Text = dt.Rows[0][3].ToString();
                ///////////////////////////////////////////////
                string sql1 = "SELECT TENSV ,TENMON ,CHAMDIEMSV.DIEMQT,CHAMDIEMSV.DIEMGK,CHAMDIEMSV.DIEMTHI,CHAMDIEMSV.DIEMHP,CHAMDIEMSV.DIEMCHU ,CHAMDIEMSV.HE4,CHAMDIEMSV.GHICHU ,TENHKNH  FROM dbo.CHAMDIEMSV,dbo.MONHOCSV,dbo.SINHVIEN,dbo.MONHOC,dbo.HOCKYNAMHOC WHERE dbo.CHAMDIEMSV.MAMHSV = dbo.MONHOCSV.MAMHSV AND dbo.MONHOCSV.MASV =dbo.SINHVIEN.MASV AND dbo.MONHOCSV.MAMON = dbo.MONHOC.MAMON AND dbo.MONHOCSV.MAHKNH = dbo.HOCKYNAMHOC.MAHKNH AND MONHOCSV.MASV='" + txtmsv.Text+ "' AND DIEMHP >= 4.0 ";
                DataTable dt1 = ketnoi.loadDataTable(sql1);
                dataGridView1.DataSource = dt1;
                ///////////////////////////////////////////////
                string sq2 = "SELECT MAHKNH,TENHKNH FROM dbo.HOCKYNAMHOC";
                DataTable dt2 = ketnoi.loadDataTable(sq2);
                comboBox1.DataSource = dt2;
                comboBox1.ValueMember = "MAHKNH";
                comboBox1.DisplayMember = "TENHKNH";
                //////////////////////////////////////////////

                string sql13 = "SELECT TENSV ,TENMON ,CHAMDIEMSV.DIEMQT,CHAMDIEMSV.DIEMGK,CHAMDIEMSV.DIEMTHI,CHAMDIEMSV.DIEMHP,CHAMDIEMSV.DIEMCHU ,CHAMDIEMSV.HE4,CHAMDIEMSV.GHICHU ,TENHKNH  FROM dbo.CHAMDIEMSV,dbo.MONHOCSV,dbo.SINHVIEN,dbo.MONHOC,dbo.HOCKYNAMHOC WHERE dbo.CHAMDIEMSV.MAMHSV = dbo.MONHOCSV.MAMHSV AND dbo.MONHOCSV.MASV =dbo.SINHVIEN.MASV AND dbo.MONHOCSV.MAMON = dbo.MONHOC.MAMON AND dbo.MONHOCSV.MAHKNH = dbo.HOCKYNAMHOC.MAHKNH AND MONHOCSV.MASV='" + txtmsv.Text + "'";
                DataTable dt3 = ketnoi.loadDataTable(sql13);
                dataGridView2.DataSource = dt3;

                ////////////////////////////////////

                string sqltl = "SELECT (SUM(TCMON*HE4))/SUM(TCMON) FROM dbo.CHAMDIEMSV,dbo.MONHOCSV,dbo.SINHVIEN,dbo.MONHOC,dbo.HOCKYNAMHOC WHERE dbo.CHAMDIEMSV.MAMHSV = dbo.MONHOCSV.MAMHSV AND dbo.MONHOCSV.MASV =dbo.SINHVIEN.MASV AND dbo.MONHOCSV.MAMON = dbo.MONHOC.MAMON AND dbo.MONHOCSV.MAHKNH = dbo.HOCKYNAMHOC.MAHKNH AND MONHOCSV.MASV='"+txtmsv.Text+"'";
                DataTable dttl = ketnoi.loadDataTable(sqltl);
                txttl.Text = dttl.Rows[0][0].ToString();
                ketnoi.closeConn();

                //SELECT (SUM(TCMON*HE4))/SUM(TCMON) FROM dbo.CHAMDIEMSV,dbo.MONHOCSV,dbo.SINHVIEN,dbo.MONHOC,dbo.HOCKYNAMHOC WHERE dbo.CHAMDIEMSV.MAMHSV = dbo.MONHOCSV.MAMHSV AND dbo.MONHOCSV.MASV =dbo.SINHVIEN.MASV AND dbo.MONHOCSV.MAMON = dbo.MONHOC.MAMON AND dbo.MONHOCSV.MAHKNH = dbo.HOCKYNAMHOC.MAHKNH AND MONHOCSV.MASV='31' 

            }
            catch (Exception)
            {
                txtmsv.Text = "";
                txttsv.Text = "";

            }
        }
        //ham
        int tongtc = 0;
        void tinhtcht()
        {
            try
            {
                Connection ketnoi = new Connection();
                ketnoi.openConn();
                string sql4 = "SELECT SUM(TCMON)  FROM dbo.CHAMDIEMSV,dbo.MONHOCSV,dbo.SINHVIEN,dbo.MONHOC,dbo.HOCKYNAMHOC WHERE dbo.CHAMDIEMSV.MAMHSV = dbo.MONHOCSV.MAMHSV AND dbo.MONHOCSV.MASV =dbo.SINHVIEN.MASV AND dbo.MONHOCSV.MAMON = dbo.MONHOC.MAMON AND dbo.MONHOCSV.MAHKNH = dbo.HOCKYNAMHOC.MAHKNH AND MONHOCSV.MASV='" + txtmsv.Text + "' AND DIEMHP >= 4.0";
                DataTable dt4 = ketnoi.loadDataTable(sql4);
                tongtc = Convert.ToInt32(dt4.Rows[0][0].ToString());
                txttcht.Text = tongtc.ToString();
                ketnoi.closeConn();
                svnam(tongtc);
                txtnamsv.Text = nam;
            }
            catch (Exception)
            {
                txttcht.Text = "";
                txtnamsv.Text = "";
            }
           
          
        }
        string nam = "";
        string svnam(int a)
        {
            if (a < 38)
            {
                nam = "Sinh viên năm thứ nhất";
            }
            else if (a >= 38 && a <= 75)
            {
                nam = "Sinh viên năm thứ hai";
            }
            else if (a >= 76 && a <= 113)
            {
                nam = "Sinh viên năm thứ ba";
            }
            else if (a >= 114 && a <= 150)
            {
                nam = "Sinh viên năm thứ tư";
            }
            else if (a >= 151)
            {
                nam = "Sinh viên năm thứ năm";
            }
            return nam;
        }

        string tl;
        string tichluy(float a)
        {
            if (a < 2)
            {
                tl = "Hạng yếu";
            }
            else if (a >= 2 && a <= 2.49)
            {
                tl = "Trung bình";
            }
            else if (a >= 2.50 && a<=3.19)
            {
                tl = "Khá";
            }
            else if (a >= 3.20 && a<=3.59)
            {
                tl = "Giỏi";
            }
            else if (a >= 3.60 && a<= 4.00)
            {
                tl = "Xuất sắc";
            }

            return tl;
        }
        private void sinhvien_Activated(object sender, EventArgs e)
        {
            nhandangsinhvien();
            tinhtcht();
            float test = Convert.ToSingle(txttl.Value);
            if (txttl.Text=="")
            {
                txthl.Text ="";
            }
            else
            {
                txthl.Text = tichluy(test);
            }
         
          
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Connection ketnoi = new Connection();
            ketnoi.openConn();
            string sql1 = "SELECT TENSV ,TENMON ,CHAMDIEMSV.DIEMQT,CHAMDIEMSV.DIEMGK,CHAMDIEMSV.DIEMTHI,CHAMDIEMSV.DIEMHP,CHAMDIEMSV.DIEMCHU ,CHAMDIEMSV.HE4,CHAMDIEMSV.GHICHU ,TENHKNH  FROM dbo.CHAMDIEMSV,dbo.MONHOCSV,dbo.SINHVIEN,dbo.MONHOC,dbo.HOCKYNAMHOC WHERE dbo.CHAMDIEMSV.MAMHSV = dbo.MONHOCSV.MAMHSV AND dbo.MONHOCSV.MASV =dbo.SINHVIEN.MASV AND dbo.MONHOCSV.MAMON = dbo.MONHOC.MAMON AND dbo.MONHOCSV.MAHKNH = dbo.HOCKYNAMHOC.MAHKNH AND MONHOCSV.MASV='" + txtmsv.Text + "' AND DIEMHP >= 4.0 AND dbo.MONHOCSV.MAHKNH ='"+comboBox1.SelectedValue+"'";
            DataTable dt1 = ketnoi.loadDataTable(sql1);
            dataGridView1.DataSource = dt1;
            ketnoi.closeConn();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            Connection ketnoi = new Connection();
            ketnoi.openConn();
            string sql1 = "SELECT TENSV ,TENMON ,CHAMDIEMSV.DIEMQT,CHAMDIEMSV.DIEMGK,CHAMDIEMSV.DIEMTHI,CHAMDIEMSV.DIEMHP,CHAMDIEMSV.DIEMCHU ,CHAMDIEMSV.HE4,CHAMDIEMSV.GHICHU ,TENHKNH  FROM dbo.CHAMDIEMSV,dbo.MONHOCSV,dbo.SINHVIEN,dbo.MONHOC,dbo.HOCKYNAMHOC WHERE dbo.CHAMDIEMSV.MAMHSV = dbo.MONHOCSV.MAMHSV AND dbo.MONHOCSV.MASV =dbo.SINHVIEN.MASV AND dbo.MONHOCSV.MAMON = dbo.MONHOC.MAMON AND dbo.MONHOCSV.MAHKNH = dbo.HOCKYNAMHOC.MAHKNH AND MONHOCSV.MASV='" + txtmsv.Text + "' AND TENMON LIKE N'%"+timten.Text+"%' ";
            DataTable dt1 = ketnoi.loadDataTable(sql1);
            dataGridView2.DataSource = dt1;
            ketnoi.closeConn();
        }
    }
}
