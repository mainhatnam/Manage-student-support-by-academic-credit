using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.OleDb;
using System.Data.SqlClient;
using ExcelDataReader;
using System.IO;


namespace doan2
{
    public partial class giaovien : Form
    {

        public giaovien()
        {
            InitializeComponent();
        }


        void capnhatfrom()
        {
            Connection ketnoi = new Connection();
            ketnoi.openConn();
            string sql = "	SELECT CHAMDIEMSV.MACD,CHAMDIEMSV.MAMHSV,MONHOCSV.MASV,TENSV,TENMON,CHAMDIEMSV.DIEMQT,CHAMDIEMSV.DIEMGK,CHAMDIEMSV.DIEMTHI,CHAMDIEMSV.DIEMHP,CHAMDIEMSV.DIEMCHU,CHAMDIEMSV.HE4,CHAMDIEMSV.GHICHU FROM dbo.CHAMDIEMSV,dbo.MONHOCSV,dbo.SINHVIEN,dbo.MONHOC WHERE dbo.CHAMDIEMSV.MAMHSV = dbo.MONHOCSV.MAMHSV AND dbo.MONHOCSV.MASV =dbo.SINHVIEN.MASV AND dbo.MONHOCSV.MAMON = dbo.MONHOC.MAMON  ";
            DataTable dt2 = ketnoi.loadDataTable(sql);
            dataGridView1.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dataGridView1.DataSource = dt2;
            ////////////////////////
            string sql1 = "SELECT * FROM dbo.TINCHI";
            DataTable dt3 = ketnoi.loadDataTable(sql1);
            dataGridView2.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dataGridView2.DataSource = dt3;
            //////////////////////////
            string sq3 = "SELECT MATC,CONCAT(N'học kỳ: ',TENTC,' - ',N' số tiền tc: ',TIENTC) AS TIENTC  FROM dbo.TINCHI";
            DataTable dt4 = ketnoi.loadDataTable(sq3);
            cbtentc.DataSource = dt4;
            cbtentc.ValueMember = "MATC";
            cbtentc.DisplayMember = "TIENTC";
            ///////////////////////////
            string sq4 = "SELECT MAKHOA,TENKHOA FROM dbo.KHOACHUYENNGANH";
            DataTable dt5 = ketnoi.loadDataTable(sq4);
            cbtenkhoa.DataSource = dt5;
            cbtenkhoa.ValueMember = "MAKHOA";
            cbtenkhoa.DisplayMember = "TENKHOA";
            ////////////////////////////
            string sql5 = "SELECT MAMON,TENMON,TCMON,TENKHOA,CONCAT(N'học kỳ: ',TENTC,' - ',N' số tiền tc: ',TIENTC) AS TIENTC,TONGTIEN FROM dbo.MONHOC,dbo.KHOACHUYENNGANH,dbo.TINCHI WHERE dbo.MONHOC.MAKHOA = dbo.KHOACHUYENNGANH.MAKHOA AND dbo.MONHOC.MATC = dbo.TINCHI.MATC";
            DataTable dt6 = ketnoi.loadDataTable(sql5);
            dataGridView3.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dataGridView3.DataSource = dt6;
            ////////////////////////////
            string sq6 = "SELECT MAKHOA,TENKHOA FROM dbo.KHOACHUYENNGANH";
            DataTable dt7 = ketnoi.loadDataTable(sq6);
            cbkcn.DataSource = dt7;
            cbkcn.ValueMember = "MAKHOA";
            cbkcn.DisplayMember = "TENKHOA";
            ////////////////////////////
            string sq7 = "SELECT MAKHOASV , TENKHOASV FROM dbo.KHOA";
            DataTable dt8 = ketnoi.loadDataTable(sq7);
            cbk.DataSource = dt8;
            cbk.ValueMember = "MAKHOASV";
            cbk.DisplayMember = "TENKHOASV";
            /////////////////////////////
            string sql8 = "SELECT MASV,TAIKHOANSV,MATKHAUSV,TENSV,GIOITINHSV,NAMSINH,TENKHOASV,TENKHOA FROM dbo.SINHVIEN,dbo.KHOACHUYENNGANH,dbo.KHOA WHERE dbo.SINHVIEN.MAKHOASV = dbo.KHOA.MAKHOASV AND dbo.SINHVIEN.MAKHOA = dbo.KHOACHUYENNGANH.MAKHOA";
            DataTable dt9 = ketnoi.loadDataTable(sql8);
            dataGridView4.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dataGridView4.DataSource = dt9;
            /////////////////////////////
            string sql9 = "SELECT MONHOCSV.MAMHSV,MONHOC.TENMON,MONHOC.TCMON,SINHVIEN.TENSV,HOCKYNAMHOC.TENHKNH FROM dbo.MONHOCSV,dbo.MONHOC,dbo.SINHVIEN,dbo.HOCKYNAMHOC WHERE dbo.MONHOCSV.MAMON=dbo.MONHOC.MAMON AND dbo.MONHOCSV.MASV = dbo.SINHVIEN.MASV AND dbo.MONHOCSV.MAHKNH = dbo.HOCKYNAMHOC.MAHKNH";
            DataTable dt10 = ketnoi.loadDataTable(sql9);
            dataGridView5.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dataGridView5.DataSource = dt10;
            ///////////////////////////////
            string cbtenmon1 = "SELECT TENMON,MAMON FROM dbo.MONHOC";
            DataTable tenmon = ketnoi.loadDataTable(cbtenmon1);
            cbtenmon.DataSource = tenmon;
            cbtenmon.ValueMember = "MAMON";
            cbtenmon.DisplayMember = "TENMON";
            cbtenmon.AutoCompleteMode = AutoCompleteMode.SuggestAppend;
            cbtenmon.AutoCompleteSource = AutoCompleteSource.ListItems;


            ///////////////////////////////////////
            string sql10 = "SELECT MASV,TENSV FROM dbo.SINHVIEN";
            DataTable dt11 = ketnoi.loadDataTable(sql10);
            cbtensv.DataSource = dt11;
            cbtensv.ValueMember = "MASV";
            cbtensv.DisplayMember = "TENSV";
            cbtensv.AutoCompleteMode = AutoCompleteMode.SuggestAppend;
            cbtensv.AutoCompleteSource = AutoCompleteSource.ListItems;
            ///////////////////////////////////////
            string sql12 = "SELECT MAHKNH,TENHKNH FROM dbo.HOCKYNAMHOC";
            DataTable dt12 = ketnoi.loadDataTable(sql12);
            cbtenhocky.DataSource = dt12;
            cbtenhocky.ValueMember = "MAHKNH";
            cbtenhocky.DisplayMember = "TENHKNH";
            cbtenhocky.AutoCompleteMode = AutoCompleteMode.SuggestAppend;
            cbtenhocky.AutoCompleteSource = AutoCompleteSource.ListItems;

            ////////////////////////////////////////

            string sql13 = "SELECT MAMHSV,CONCAT(MONHOCSV.MASV ,' - ', TENSV ,' - ',TENMON,' - ',MAMHSV ) AS Tentt FROM dbo.MONHOCSV,dbo.SINHVIEN,dbo.MONHOC WHERE dbo.MONHOCSV.MASV = dbo.SINHVIEN.MASV AND dbo.MONHOCSV.MAMON = dbo.MONHOC.MAMON";
            DataTable dt13 = ketnoi.loadDataTable(sql13);
            cbmacd.DataSource = dt13;
            cbmacd.ValueMember = "MAMHSV";
            cbmacd.DisplayMember = "Tentt";
            cbmacd.AutoCompleteMode = AutoCompleteMode.SuggestAppend;
            cbmacd.AutoCompleteSource = AutoCompleteSource.ListItems;
            ///////////////////////////////////////////
            string sql14 = "SELECT MAHKNH,TENHKNH FROM dbo.HOCKYNAMHOC";
            DataTable dt14 = ketnoi.loadDataTable(sql14);
            lochk.DataSource = dt14;
            lochk.ValueMember = "MAHKNH";
            lochk.DisplayMember = "TENHKNH";


            ketnoi.closeConn();
        }
        private void giaovien_Activated(object sender, EventArgs e)
        {
            capnhatfrom();

        }


        private void button4_Click(object sender, EventArgs e)
        {
            them_file_excel b = new them_file_excel();
            b.Show();
        }

        private void button6_Click(object sender, EventArgs e)
        {
            try
            {
                if (txttentc.Text == "")
                {
                    MessageBox.Show("Không được bỏ trống dữ liệu", "Thông báo");
                }
                else if (nupttc.Value == 0 || nupttc.Value < 0)
                {
                    MessageBox.Show("Số tín không phù hợp", "Thông báo");
                }
                else
                {

                    Connection ketnoi = new Connection();
                    ketnoi.openConn();
                    string sql = "INSERT INTO TINCHI VALUES(N'" + txttentc.Text + "'," + nupttc.Value + ")";
                    ketnoi.executeUpdate(sql);
                    ketnoi.closeConn();
                    MessageBox.Show("Thêm thành công ♥");

                }

            }
            catch (Exception)
            {

                MessageBox.Show("đã có lỗi xảy ra vui lòng nhập đúng dữ liệu", "thông báo");

            }
        }

        private void dataGridView2_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            int i;
            i = dataGridView2.CurrentRow.Index;
            txtmatc.Text = dataGridView2.Rows[i].Cells[0].Value.ToString();
            txttentc.Text = dataGridView2.Rows[i].Cells[1].Value.ToString();
            nupttc.Value = Convert.ToInt32(dataGridView2.Rows[i].Cells[2].Value.ToString());

        }

        private void button7_Click(object sender, EventArgs e)
        {
            try
            {
                if (txtmatc.Text == "" || txttentc.Text == "")
                {
                    MessageBox.Show("Không được bỏ trống dữ liệu", "Thông báo");
                }
                else if (nupttc.Value == 0 || nupttc.Value < 0)
                {
                    MessageBox.Show("Số tín không phù hợp", "Thông báo");
                }
                else
                {

                    Connection ketnoi = new Connection();
                    ketnoi.openConn();
                    string sql = "UPDATE dbo.TINCHI SET TENTC = N'" + txttentc.Text + "',TIENTC = " + nupttc.Value + " WHERE MATC = " + txtmatc.Text + "	";
                    ketnoi.executeUpdate(sql);
                    ketnoi.closeConn();
                    MessageBox.Show("Sửa thành công ♥");

                }
            }
            catch (Exception)
            {

                MessageBox.Show("đã có lỗi xảy ra vui lòng nhập đúng dữ liệu", "thông báo");

            }
        }

        private void button8_Click(object sender, EventArgs e)
        {
            try
            {
                if (txtmatc.Text == "")
                {
                    MessageBox.Show("Vui lòng chọn tín chỉ cần xóa");
                }
                else
                {
                    DialogResult result = MessageBox.Show("Bạn có chắc muốn xóa tín chỉ này ?", "Xóa tín chỉ", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
                    if (result == System.Windows.Forms.DialogResult.Yes)
                    {
                        Connection ketnoi = new Connection();
                        ketnoi.openConn();
                        string sql = "DELETE FROM dbo.TINCHI WHERE MATC=" + txtmatc.Text + " ";
                        ketnoi.executeUpdate(sql);
                        ketnoi.closeConn();
                        MessageBox.Show("Xóa thành công ♥ ");
                    }
                }
            }
            catch (Exception)
            {
                MessageBox.Show("Đã có lỗi xảy ra vui lòng kiểm tra lại dữ liệu nhập ", "thông báo");
            }
        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {
            Connection ketnoi = new Connection();
            ketnoi.openConn();
            string sql = "SELECT* FROM dbo.TINCHI WHERE TENTC LIKE N'%" + textBox2.Text + "%'";
            DataTable dt4 = ketnoi.loadDataTable(sql);
            dataGridView2.DataSource = dt4;
            ketnoi.closeConn();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            try
            {
                if (txttenmon.Text == "" || cbtenkhoa.Text == "" || cbtentc.Text == "")
                {
                    MessageBox.Show("Không được bỏ trống dữ liệu", "Thông báo");
                }
                else if (nuptcm.Value == 0 || nuptcm.Value < 0)
                {
                    MessageBox.Show("Số tín môn không phù hợp", "Thông báo");
                }
                else
                {

                    Connection ketnoi = new Connection();
                    ketnoi.openConn();
                    string sql1 = "SELECT TIENTC FROM dbo.TINCHI WHERE MATC =" + cbtentc.SelectedValue + "";
                    DataTable dt_tc = ketnoi.loadDataTable(sql1);
                    int tc = Convert.ToInt32(dt_tc.Rows[0][0].ToString());
                    int tongtien = Convert.ToInt32(nuptcm.Value) * tc;
                    /////////////////////////////////
                    string sql = "INSERT INTO MONHOC VALUES(N'" + txttenmon.Text + "'," + nuptcm.Value + "," + tongtien + ",'" + cbtenkhoa.SelectedValue + "','" + cbtentc.SelectedValue + "')";
                    ketnoi.executeUpdate(sql);
                    ketnoi.closeConn();
                    dataGridView3.Columns["TONGTIEN"].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight;
                    MessageBox.Show("Thêm thành công ♥");

                }

            }
            catch (Exception)
            {

                MessageBox.Show("đã có lỗi xảy ra vui lòng nhập đúng dữ liệu", "thông báo");

            }
        }

        private void dataGridView3_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            int i;
            i = dataGridView3.CurrentRow.Index;
            txtmamon.Text = dataGridView3.Rows[i].Cells[0].Value.ToString();
            txttenmon.Text = dataGridView3.Rows[i].Cells[1].Value.ToString();
            nuptcm.Value = Convert.ToInt32(dataGridView3.Rows[i].Cells[2].Value.ToString());
            cbtenkhoa.Text = dataGridView3.Rows[i].Cells[3].Value.ToString();
            cbtentc.Text = dataGridView3.Rows[i].Cells[4].Value.ToString();

        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                if (txttenmon.Text == "" || txtmamon.Text == "")
                {
                    MessageBox.Show("Không được bỏ trống dữ liệu", "Thông báo");
                }
                else if (nuptcm.Value == 0)
                {
                    MessageBox.Show("Số tín môn không phù hợp", "Thông báo");
                }
                else
                {
                    Connection ketnoi = new Connection();
                    ketnoi.openConn();
                    string sql1 = "SELECT TIENTC FROM dbo.TINCHI WHERE MATC =" + cbtentc.SelectedValue + "";
                    DataTable dt_tc = ketnoi.loadDataTable(sql1);
                    int tc = Convert.ToInt32(dt_tc.Rows[0][0].ToString());
                    int tongtien = Convert.ToInt32(nuptcm.Value) * tc;
                    string sql = "UPDATE dbo.MONHOC SET TENMON=N'" + txttenmon.Text + "', TCMON=" + nuptcm.Value + ",MAKHOA ='" + cbtenkhoa.SelectedValue + "',MATC='" + cbtentc.SelectedValue + "',TONGTIEN = " + tongtien + " WHERE MAMON = '" + txtmamon.Text + "' ";
                    ketnoi.executeUpdate(sql);
                    ketnoi.closeConn();
                    MessageBox.Show("Sửa thành công ♥");

                }
            }
            catch (Exception)
            {

                MessageBox.Show("đã có lỗi xảy ra vui lòng nhập đúng dữ liệu", "thông báo");

            }


        }

        private void button2_Click(object sender, EventArgs e)
        {
            try
            {
                if (txtmamon.Text == "")
                {
                    MessageBox.Show("Vui lòng chọn môn cần xóa");
                }
                else
                {
                    DialogResult result = MessageBox.Show("Bạn có chắc muốn xóa môn học này ?", "Xóa môn học", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
                    if (result == System.Windows.Forms.DialogResult.Yes)
                    {
                        Connection ketnoi = new Connection();
                        ketnoi.openConn();
                        string sql = "DELETE FROM dbo.MONHOC WHERE MAMON=" + txtmamon.Text + " ";
                        ketnoi.executeUpdate(sql);
                        ketnoi.closeConn();
                        MessageBox.Show("Xóa thành công ♥ ");
                    }
                }
            }
            catch (Exception)
            {
                MessageBox.Show("Đã có lỗi xảy ra vui lòng kiểm tra lại dữ liệu nhập ", "thông báo");
            }

        }

        private void textBox6_TextChanged(object sender, EventArgs e)
        {
            try
            {
                Connection ketnoi = new Connection();
                ketnoi.openConn();
                string sql = "SELECT* FROM dbo.MONHOC WHERE TENMON LIKE N'%" + textBox6.Text + "%'";
                DataTable dt4 = ketnoi.loadDataTable(sql);
                dataGridView3.DataSource = dt4;
                ketnoi.closeConn();
            }
            catch (Exception)
            {


            }

        }

        private void button3_Click(object sender, EventArgs e)
        {

            try
            {
                if (txttk.Text == "" || txtmk.Text == "" || txttsv.Text == "" || cbgt.Text == "")
                {
                    MessageBox.Show("Không được bỏ trống dữ liệu", "Thông báo");
                }
                else if (DateTime.Now.Year - dateTimePicker1.Value.Year < 18)
                {
                    MessageBox.Show("ngày sinh không hợp lệ", "Thông báo");

                }
                else if (txttk.Text.IndexOf(" ") != -1)
                {
                    MessageBox.Show("Tài khoản không dùng cái khoảng trắng", "Thông báo");
                }
                else
                {
                    Connection ketnoi = new Connection();
                    ketnoi.openConn();
                    string sql = "INSERT INTO SINHVIEN VALUES('" + txttk.Text + "','" + txtmk.Text + "',N'" + txttsv.Text + "',N'" + cbgt.Text + "','" + dateTimePicker1.Text + "','" + cbk.SelectedValue + "','" + cbkcn.SelectedValue + "'," + 2 + ")";
                    ketnoi.executeUpdate(sql);

                    ketnoi.closeConn();
                    MessageBox.Show("Thêm thành công ♥");


                }
            }
            catch (Exception)
            {

                MessageBox.Show("đã có lỗi xảy ra vui lòng nhập đúng dữ liệu", "thông báo");

            }
        }

        private void dataGridView4_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            int i;
            i = dataGridView4.CurrentRow.Index;
            txtmsv.Text = dataGridView4.Rows[i].Cells[0].Value.ToString();
            txttk.Text = dataGridView4.Rows[i].Cells[1].Value.ToString();
            txtmk.Text = dataGridView4.Rows[i].Cells[2].Value.ToString();
            txttsv.Text = dataGridView4.Rows[i].Cells[3].Value.ToString();
            cbgt.Text = dataGridView4.Rows[i].Cells[4].Value.ToString();
            dateTimePicker1.Text = dataGridView4.Rows[i].Cells[5].Value.ToString();
            cbk.Text = dataGridView4.Rows[i].Cells[6].Value.ToString();
            cbkcn.Text = dataGridView4.Rows[i].Cells[7].Value.ToString();
        }

        private void button9_Click(object sender, EventArgs e)
        {
            try
            {
                if (txttk.Text == "" || txtmk.Text == "" || txttsv.Text == "" || cbgt.Text == "" || txtmsv.Text == "")
                {
                    MessageBox.Show("Không được bỏ trống dữ liệu", "Thông báo");
                }
                else if (txttk.Text.IndexOf(" ") != -1)
                {
                    MessageBox.Show("Tài khoản không dùng cái khoảng trắng", "Thông báo");
                }
                else
                {
                    Connection ketnoi = new Connection();
                    ketnoi.openConn();
                    string sql = "UPDATE dbo.SINHVIEN SET TAIKHOANSV='" + txttk.Text + "',MATKHAUSV='" + txtmk.Text + "',TENSV=N'" + txttsv.Text + "',GIOITINHSV=N'" + cbgt.Text + "',NAMSINH='" + dateTimePicker1.Text + "',MAKHOASV=" + cbk.SelectedValue + ",MAKHOA=" + cbkcn.SelectedValue + ",MAQUYEN=" + 2 + " WHERE MASV = '" + txtmsv.Text + "'";
                    ketnoi.executeUpdate(sql);
                    ketnoi.closeConn();
                    MessageBox.Show("Sửa thành công ♥");


                }
            }
            catch (Exception)
            {

                MessageBox.Show("đã có lỗi xảy ra vui lòng nhập đúng dữ liệu", "thông báo");


            }

        }

        private void button10_Click(object sender, EventArgs e)
        {
            try
            {
                if (txtmsv.Text == "")
                {
                    MessageBox.Show("Vui lòng chọn sinh viên cần xóa");
                }
                else
                {
                    DialogResult result = MessageBox.Show("Bạn có chắc muốn xóa sinh viên này ?", "Xóa sinh viên", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
                    if (result == System.Windows.Forms.DialogResult.Yes)
                    {
                        Connection ketnoi = new Connection();
                        ketnoi.openConn();
                        string sql = "DELETE FROM dbo.SINHVIEN WHERE MASV=" + txtmsv.Text + " ";
                        ketnoi.executeUpdate(sql);
                        ketnoi.closeConn();
                        MessageBox.Show("Xóa thành công ♥ ");
                    }
                }
            }
            catch (Exception)
            {
                MessageBox.Show("sinh viên đã có dữ liệu không thể xóa ", "thông báo");
            }


        }

        private void button11_Click(object sender, EventArgs e)
        {
            excel_DKMH a = new excel_DKMH();
            a.Show();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            Connection ketnoi = new Connection();
            ketnoi.openConn();
            string sql = "SELECT * FROM SINHVIEN WHERE TENSV LIKE N'%" + textBox1.Text + "%'";
            DataTable dt4 = ketnoi.loadDataTable(sql);
            dataGridView4.DataSource = dt4;
            ketnoi.closeConn();
        }

        private void button12_Click(object sender, EventArgs e)
        {
            Connection ketnoi = new Connection();
            ketnoi.openConn();
            string sql = "SELECT MAMON,TENMON,TCMON,TENKHOA,CONCAT(N'học kỳ: ',TENTC,' - ',N' số tiền tc: ',TIENTC) AS TIENTC,TONGTIEN FROM dbo.MONHOC,dbo.KHOACHUYENNGANH,dbo.TINCHI WHERE dbo.MONHOC.MAKHOA = dbo.KHOACHUYENNGANH.MAKHOA AND dbo.MONHOC.MATC = dbo.TINCHI.MATC ";
            DataTable dt4 = ketnoi.loadDataTable(sql);
            dataGridView3.DataSource = dt4;
            ketnoi.closeConn();
        }

        private void cbtenmon_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void button13_Click(object sender, EventArgs e)
        {
            try
            {
                Connection ketnoi = new Connection();
                ketnoi.openConn();
                string sql = "SELECT COUNT(*) FROM dbo.MONHOC WHERE MAMON='" + cbtenmon.SelectedValue + "'AND TENMON=N'" + cbtenmon.Text + "'";
                string sql1 = "SELECT COUNT (*) FROM SINHVIEN WHERE MASV='" + cbtensv.SelectedValue + "'AND TENSV=N'" + cbtensv.Text + "'";
                string sql2 = "SELECT COUNT(*) FROM dbo.HOCKYNAMHOC WHERE MAHKNH='" + cbtenhocky.SelectedValue + "'AND TENHKNH=N'" + cbtenhocky.Text + "'";
                string sql5 = "select COUNT(*) from dbo.MONHOCSV where Mamon='" +cbtenmon.SelectedValue + "' and Masv ='" +cbtensv.SelectedValue + "' and MAHKNH = '" +cbtenhocky.SelectedValue+ "'";
                DataTable dt5 = ketnoi.loadDataTable(sql5);
                DataTable dt = ketnoi.loadDataTable(sql);
                DataTable dt1 = ketnoi.loadDataTable(sql1);
                DataTable dt2 = ketnoi.loadDataTable(sql2);
                if (Convert.ToInt32(dt.Rows[0][0].ToString()) != 1)
                {
                    MessageBox.Show("không có thông tin từ môn học đã chọn");
                    ketnoi.closeConn();
                }
                else if (Convert.ToInt32(dt1.Rows[0][0].ToString()) != 1)
                {
                    MessageBox.Show("không có thông tin từ sinh viên đã chọn");
                    ketnoi.closeConn();
                }
                else if (Convert.ToInt32(dt2.Rows[0][0].ToString()) != 1)
                {
                    MessageBox.Show("không có thông tin từ học kỳ đã chọn");
                    ketnoi.closeConn();
                }
                else if (Convert.ToInt32(dt5.Rows[0][0].ToString()) >= 1)
                {
                    MessageBox.Show("dữ liệu đã có trong danh sách ");
                    ketnoi.closeConn();
                }
                else
                {
                    string sql3 = "	INSERT INTO dbo.MONHOCSV VALUES(" + cbtenmon.SelectedValue + "," + cbtensv.SelectedValue + "," + cbtenhocky.SelectedValue + ")";
                    ketnoi.executeUpdate(sql3);
                    ketnoi.closeConn();
                    MessageBox.Show("Thêm thành công ♥");

                }
            }
            catch (Exception)
            {
                MessageBox.Show("Đã có lỗi xảy ra vui lòng nhập lại");
            }


        }

        private void dataGridView5_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            int i;
            i = dataGridView5.CurrentRow.Index;
            txtmadk.Text = dataGridView5.Rows[i].Cells[0].Value.ToString();
            cbtenmon.Text = dataGridView5.Rows[i].Cells[1].Value.ToString();
            cbtensv.Text = dataGridView5.Rows[i].Cells[3].Value.ToString();
            cbtenhocky.Text = dataGridView5.Rows[i].Cells[4].Value.ToString();
        }

        private void button14_Click(object sender, EventArgs e)
        {
            try
            {
                Connection ketnoi = new Connection();
                ketnoi.openConn();
                string sql = "SELECT COUNT(*) FROM dbo.MONHOC WHERE MAMON='" + cbtenmon.SelectedValue + "'AND TENMON=N'" + cbtenmon.Text + "'";
                string sql1 = "SELECT COUNT (*) FROM SINHVIEN WHERE MASV='" + cbtensv.SelectedValue + "'AND TENSV=N'" + cbtensv.Text + "'";
                string sql2 = "SELECT COUNT(*) FROM dbo.HOCKYNAMHOC WHERE MAHKNH='" + cbtenhocky.SelectedValue + "'AND TENHKNH=N'" + cbtenhocky.Text + "'";
                DataTable dt = ketnoi.loadDataTable(sql);
                DataTable dt1 = ketnoi.loadDataTable(sql1);
                DataTable dt2 = ketnoi.loadDataTable(sql2);
                if (Convert.ToInt32(dt.Rows[0][0].ToString()) != 1)
                {
                    MessageBox.Show("không có thông tin từ môn học đã chọn");
                    ketnoi.closeConn();
                }
                else if (Convert.ToInt32(dt1.Rows[0][0].ToString()) != 1)
                {
                    MessageBox.Show("không có thông tin từ sinh viên đã chọn");
                    ketnoi.closeConn();
                }
                else if (Convert.ToInt32(dt2.Rows[0][0].ToString()) != 1)
                {
                    MessageBox.Show("không có thông tin từ học kỳ đã chọn");
                    ketnoi.closeConn();
                }
                else if (txtmadk.Text == "")
                {
                    MessageBox.Show("Mã đăng ký không được bỏ trống");
                }
                else
                {
                    string sql3 = "	UPDATE dbo.MONHOCSV SET MAMON=" + cbtenmon.SelectedValue + ",MASV=" + cbtensv.SelectedValue + ",MAHKNH=" + cbtenhocky.SelectedValue + " WHERE MAMHSV = " + txtmadk.Text + "";
                    ketnoi.executeUpdate(sql3);
                    ketnoi.closeConn();
                    MessageBox.Show("Sửa thành công ♥");

                }


            }
            catch (Exception)
            {
                MessageBox.Show("Đã có lỗi xảy ra vui lòng nhập lại");
            }
        }

        private void button15_Click(object sender, EventArgs e)
        {
            try
            {
                Connection ketnoi = new Connection();
                ketnoi.openConn();
                string sql1 = "SELECT COUNT(*) FROM dbo.CHAMDIEMSV WHERE MAMHSV = " + txtmadk.Text + " ";
                DataTable dt2 = ketnoi.loadDataTable(sql1);
                if (Convert.ToInt32(dt2.Rows[0][0].ToString()) >= 1)
                {
                    MessageBox.Show("không thể xóa sinh viên này vì đã chấm điểm rồi");
                }
                else if (txtmadk.Text == "")
                {
                    MessageBox.Show("Vui lòng chọn mã đăng ký cần xóa");
                }
                else
                {
                    DialogResult result = MessageBox.Show("Bạn có chắc muốn xóa đăng ký này ?", "Xóa đăng ký", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
                    if (result == System.Windows.Forms.DialogResult.Yes)
                    {

                        string sql = "DELETE FROM dbo.MONHOCSV WHERE MAMHSV=" + txtmadk.Text + "";
                        ketnoi.executeUpdate(sql);
                        ketnoi.closeConn();
                        MessageBox.Show("Xóa thành công ♥ ");
                    }
                }
            }
            catch (Exception)
            {
                MessageBox.Show("Đã có lỗi xảy ra vui lòng kiểm tra lại dữ liệu nhập ", "thông báo");
            }
        }

        private void textBox4_TextChanged(object sender, EventArgs e)
        {
            Connection ketnoi = new Connection();
            ketnoi.openConn();
            string sql = "SELECT MONHOCSV.MAMHSV,MONHOC.TENMON,MONHOC.TCMON,SINHVIEN.TENSV,HOCKYNAMHOC.TENHKNH FROM dbo.MONHOCSV,dbo.MONHOC,dbo.SINHVIEN,dbo.HOCKYNAMHOC WHERE dbo.MONHOCSV.MAMON=dbo.MONHOC.MAMON AND dbo.MONHOCSV.MASV = dbo.SINHVIEN.MASV AND dbo.MONHOCSV.MAHKNH = dbo.HOCKYNAMHOC.MAHKNH AND TENSV LIKE N'%" + textBox4.Text + "%'";
            DataTable dt4 = ketnoi.loadDataTable(sql);
            dataGridView5.DataSource = dt4;
            ketnoi.closeConn();
        }

        //ham tinh diem
        float tongdiem = 0;
        string diemchu1 = "";
        float diemhe = 0;
        float tinhdiemtrungbinh(float diem10, float diem40, float diem50)
        {
            tongdiem = ((diem10 + (diem40 * 4) + (diem50 * 5)) / 10);
            return tongdiem;
        }
        string tinhdiemchu(float tongdiem)
        {
            if (tongdiem < 4.0)
            {
                diemchu1 = "F";
            }
            else if (tongdiem >= 4.0 && tongdiem <= 4.7)
            {
                diemchu1 = "D";
            }
            else if (tongdiem >= 4.8 && tongdiem <= 5.4)
            {
                diemchu1 = "D+";
            }
            else if (tongdiem >= 5.5 && tongdiem <= 6.2)
            {
                diemchu1 = "C";
            }
            else if (tongdiem >= 6.3 && tongdiem <= 6.9)
            {
                diemchu1 = "C+";
            }
            else if (tongdiem >= 7.0 && tongdiem <= 7.7)
            {
                diemchu1 = "B";
            }
            else if (tongdiem >= 7.8 && tongdiem <= 8.4)
            {
                diemchu1 = "B+";
            }
            else if (tongdiem >= 8.5 && tongdiem <= 10)
            {
                diemchu1 = "A";
            }
            return diemchu1;
        }
        float tinhdiemhe4(string diemchu1)
        {
            if (diemchu1 == "F")
            {
                diemhe = 0;
            }
            else if (diemchu1 == "D")
            {
                diemhe = 1;
            }
            else if (diemchu1 == "D+")
            {
                diemhe = 1.5F;
            }
            else if (diemchu1 == "C")
            {
                diemhe = 2;
            }
            else if (diemchu1 == "C+")
            {
                diemhe = 2.5F;
            }
            else if (diemchu1 == "B")
            {
                diemhe = 3;
            }
            else if (diemchu1 == "B+")
            {
                diemhe = 3.5F;
            }
            else if (diemchu1 == "A")
            {
                diemhe = 4;
            }
            return diemhe;
        }

        private void button16_Click(object sender, EventArgs e)
        {
            float a = Convert.ToSingle(diem10.Value);
            float b = Convert.ToSingle(diem40.Value);
            float c = Convert.ToSingle(diem50.Value);
            ///////////////////
           
            try
            {
                Connection ketnoi = new Connection();
                ketnoi.openConn();
                string kt = "select COUNT(*) from CHAMDIEMSV where MAMHSV ='" +cbmacd.SelectedValue+ "'";
                DataTable dtkt = ketnoi.loadDataTable(kt);
                string sql = "SELECT COUNT(MAMHSV) FROM dbo.MONHOCSV,dbo.SINHVIEN,dbo.MONHOC WHERE dbo.MONHOCSV.MASV = dbo.SINHVIEN.MASV AND dbo.MONHOCSV.MAMON = dbo.MONHOC.MAMON  AND MAMHSV = '"+cbmacd.SelectedValue+"' ";        
                DataTable dt = ketnoi.loadDataTable(sql);
                if (Convert.ToInt32(dt.Rows[0][0].ToString()) != 1)
                {
                    MessageBox.Show("nhập đúng thông tin ở mã môn học đăng ký");
                }
                else if (cbghichu.Text == "")
                {
                    MessageBox.Show("ghi trú không được bỏ trống");
                }
                else if (Convert.ToInt32(dtkt.Rows[0][0]) >= 1)
                {
                    MessageBox.Show("Dữ liệu đã có trong danh sách");
                }
                else
                {
                    float diem1 = tinhdiemtrungbinh(a, b, c);
                    string diem2 = tinhdiemchu(tongdiem);
                    float diem3 = tinhdiemhe4(diemchu1);
                    string sql1 = "	INSERT INTO dbo.CHAMDIEMSV VALUES('"+cbmacd.SelectedValue+"','"+diem10.Value+"','"+diem40.Value+"','"+diem50.Value+"',"+diem1+",N'"+diem2.ToString()+"',N'"+diem3+"',N'"+cbghichu.Text+"')";
                    ketnoi.executeUpdate(sql1);
                    ketnoi.closeConn();
                    MessageBox.Show("Thêm thành công ♥");
                    //   textBox5.Text = sql1;
                }
            }
            catch (Exception)
            {
                MessageBox.Show("loi");

            }
        }

        private void lochk_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void button19_Click(object sender, EventArgs e)
        {
            try
            {
                Connection ketnoi = new Connection();
                ketnoi.openConn();
                string sql = "SELECT CHAMDIEMSV.MACD,CHAMDIEMSV.MAMHSV,TENSV,TENMON,CHAMDIEMSV.DIEMQT,CHAMDIEMSV.DIEMGK,CHAMDIEMSV.DIEMTHI,CHAMDIEMSV.DIEMHP,CHAMDIEMSV.DIEMCHU,CHAMDIEMSV.HE4,CHAMDIEMSV.GHICHU,MONHOCSV.MAHKNH FROM dbo.CHAMDIEMSV,dbo.MONHOCSV,dbo.SINHVIEN,dbo.MONHOC,dbo.HOCKYNAMHOC WHERE dbo.CHAMDIEMSV.MAMHSV = dbo.MONHOCSV.MAMHSV AND dbo.MONHOCSV.MASV =dbo.SINHVIEN.MASV AND dbo.MONHOCSV.MAMON = dbo.MONHOC.MAMON AND dbo.MONHOCSV.MAHKNH = dbo.HOCKYNAMHOC.MAHKNH AND dbo.MONHOCSV.MAHKNH = N'" + lochk.SelectedValue + "'";
                DataTable dt4 = ketnoi.loadDataTable(sql);
                dataGridView1.DataSource = dt4;
                ketnoi.closeConn();
            }
            catch (Exception)
            {


            }
        }

        private void tabControl1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void button17_Click(object sender, EventArgs e)
        {
            float a = Convert.ToSingle(diem10.Value);
            float b = Convert.ToSingle(diem40.Value);
            float c = Convert.ToSingle(diem50.Value);
            ///////////////////

            try
            {
                Connection ketnoi = new Connection();
                ketnoi.openConn();
                string sql = "SELECT COUNT(MAMHSV) FROM dbo.MONHOCSV,dbo.SINHVIEN,dbo.MONHOC WHERE dbo.MONHOCSV.MASV = dbo.SINHVIEN.MASV AND dbo.MONHOCSV.MAMON = dbo.MONHOC.MAMON  AND MAMHSV = '" + cbmacd.SelectedValue + "' ";
                DataTable dt = ketnoi.loadDataTable(sql);
                if (Convert.ToInt32(dt.Rows[0][0].ToString()) != 1)
                {
                    MessageBox.Show("nhập đúng thông tin ở mã môn học đăng ký");
                }
                else if (cbghichu.Text == "")
                {
                    MessageBox.Show("ghi trú không được bỏ trống");
                }
                else if (mcd.Text=="")
                {
                    MessageBox.Show("Mã chấm điểm không được bỏ trống");
                }
                else
                {
                    float diem1 = tinhdiemtrungbinh(a, b, c);
                    string diem2 = tinhdiemchu(tongdiem);
                    float diem3 = tinhdiemhe4(diemchu1);
                    string sql1 = "UPDATE dbo.CHAMDIEMSV SET MAMHSV='" + cbmacd.SelectedValue + "',DIEMQT='" + diem10.Value + "',DIEMGK='" + diem40.Value + "',DIEMTHI='" + diem50.Value + "',DIEMHP='" + diem1 + "',DIEMCHU=N'" + diem2.ToString() + "',HE4=N'" + diem3 + "',GHICHU=N'" + cbghichu.Text + "' WHERE MACD='"+mcd.Text+"'";
                    //UPDATE dbo.CHAMDIEMSV SET MAMHSV='"+cbmacd.SelectedValue+"',DIEMQT='" + diem10.Value + "',DIEMGK='" + diem40.Value + "',DIEMTHI='" + diem50.Value + "',DIEMHP='" + diem1 + "',DIEMCHU=N'" + diem2.ToString() + "',HE4=N'" + diem3 + "',GHICHU=N'" + cbghichu.Text + "' WHERE MACD='"++"'
                    ketnoi.executeUpdate(sql1);
                    ketnoi.closeConn();
                    MessageBox.Show("Sửa thành công ♥");
                    //   textBox5.Text = sql1;
                }
            }
            catch (Exception)
            {
                MessageBox.Show("loi");

            }
        }

        private void button18_Click(object sender, EventArgs e)
        {
            try
            {
                Connection ketnoi = new Connection();
                ketnoi.openConn();
              
                if (mcd.Text == "")
                {
                    MessageBox.Show("Mã chấm điểm không được bỏ trống");
                }
                else
                {             
                    string sql1 = "	DELETE FROM dbo.CHAMDIEMSV WHERE MACD='"+mcd.Text+"'";
                    ketnoi.executeUpdate(sql1);
                    ketnoi.closeConn();
                    MessageBox.Show("Xóa thành công ♥");
                    
                }
            }
            catch (Exception)
            {
                MessageBox.Show("loi");

            }

        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            Connection ketnoi = new Connection();
            ketnoi.openConn();
            int i;
            i = dataGridView1.CurrentRow.Index;
            mcd.Text = dataGridView1.Rows[i].Cells[0].Value.ToString();
            cbmacd.Text = (dataGridView1.Rows[i].Cells[2].Value.ToString()  +" - " + dataGridView1.Rows[i].Cells[3].Value.ToString() +" - "+ dataGridView1.Rows[i].Cells[4].Value.ToString() +" - "+ dataGridView1.Rows[i].Cells[1].Value.ToString()) ;
            cbghichu.Text = dataGridView1.Rows[i].Cells[11].Value.ToString();
            diem10.Text = dataGridView1.Rows[i].Cells[5].Value.ToString() ; 
            diem40.Text = dataGridView1.Rows[i].Cells[6].Value.ToString();
            diem50.Text = dataGridView1.Rows[i].Cells[7].Value.ToString();
            diemtb.Text = dataGridView1.Rows[i].Cells[8].Value.ToString();
            dchu.Text = dataGridView1.Rows[i].Cells[9].Value.ToString();
            diemh4.Text = dataGridView1.Rows[i].Cells[10].Value.ToString();


        }

        private void xuatfile_Click(object sender, EventArgs e)
        {
            xuatfile a = new xuatfile();
            a.Show();
        }

        private void button20_Click(object sender, EventArgs e)
        {
           
        }
    }
}
