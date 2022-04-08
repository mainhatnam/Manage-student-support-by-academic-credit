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
    public partial class truongkhoa : Form
    {
        public truongkhoa()
        {
            InitializeComponent();
        }

        private void tabPage1_Click(object sender, EventArgs e)
        {

        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
   
        }

     

        private void truongkhoa_Activated(object sender, EventArgs e)
        {
            Connection ketnoi = new Connection();
            ketnoi.openConn();
            string sql = "SELECT MAKHOA,TENKHOA FROM dbo.KHOACHUYENNGANH";
            DataTable dt2 = ketnoi.loadDataTable(sql);
            comboBox2.DataSource = dt2;
            comboBox2.ValueMember = "MAKHOA";
            comboBox2.DisplayMember = "TENKHOA";
            string sq2 = "SELECT MAQUYEN,TENQUYEN FROM dbo.PHANQUYEN";
            DataTable dt3 = ketnoi.loadDataTable(sq2);
            comboBox3.DataSource = dt3;
            comboBox3.ValueMember = "MAQUYEN";
            comboBox3.DisplayMember = "TENQUYEN";
            string sql3 = "SELECT MAGV,TENGV,TAIKHOAN,MATKHAU,GIOITINH,TENKHOA,TENQUYEN FROM dbo.GIAOVIEN,dbo.KHOACHUYENNGANH,dbo.PHANQUYEN WHERE  dbo.GIAOVIEN.MAKHOA = dbo.KHOACHUYENNGANH.MAKHOA AND dbo.GIAOVIEN.MAQUYEN = dbo.PHANQUYEN.MAQUYEN";
            DataTable dt4 = ketnoi.loadDataTable(sql3);
            dataGridView1.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dataGridView1.DataSource = dt4;

            //khoa
            string sqlkhoa = "SELECT * FROM dbo.KHOA";
            DataTable dtkhoa = ketnoi.loadDataTable(sqlkhoa);
            dataGridView2.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dataGridView2.DataSource = dtkhoa;
            //khoa chuyen nganh
            string sqlkhoacn = "SELECT*FROM dbo.KHOACHUYENNGANH";
            DataTable dtkhoacn = ketnoi.loadDataTable(sqlkhoacn);
            dataGridView3.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dataGridView3.DataSource = dtkhoacn;

            ketnoi.closeConn();
            
        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {   
            int i;
            i = dataGridView1.CurrentRow.Index;
            textBox4.Text = dataGridView1.Rows[i].Cells[0].Value.ToString();
            textBox2.Text = dataGridView1.Rows[i].Cells[1].Value.ToString();
            textBox1.Text = dataGridView1.Rows[i].Cells[2].Value.ToString();
            textBox3.Text = dataGridView1.Rows[i].Cells[3].Value.ToString();
            comboBox1.Text = dataGridView1.Rows[i].Cells[4].Value.ToString();
            comboBox2.Text = dataGridView1.Rows[i].Cells[5].Value.ToString();
            comboBox3.Text = dataGridView1.Rows[i].Cells[6].Value.ToString();    
        }

        private void button1_Click(object sender, EventArgs e)
        {
           
                try
            {              
                if (textBox2.Text == "" || textBox3.Text=="" || textBox1.Text=="" || comboBox1.Text=="" || comboBox2.Text=="" || comboBox3.Text=="")
                {
                    MessageBox.Show("Không được bỏ trống dữ liệu", "Thông báo");
                }
                else if (textBox1.Text.IndexOf(" ") != -1 )
                {
                    MessageBox.Show("Tài khoản không dùng cái khoảng trắng", "Thông báo");
                }   
                else if (comboBox3.SelectedValue.ToString() == "2")
                {
                    MessageBox.Show("Phân quyền sai tài khoản này", "Thông báo");
                }
                else
                {
                   
                        Connection ketnoi = new Connection();
                        ketnoi.openConn();
                        string sql = "INSERT INTO GIAOVIEN VALUES(N'" + textBox1.Text + "',N'" + textBox3.Text + "',N'" + textBox2.Text + "',N'" + comboBox1.Text + "',N'" + comboBox2.SelectedValue + "',N'" + comboBox3.SelectedValue + "')";
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

        private void button2_Click(object sender, EventArgs e)
        {      
                try
                {
                    if (textBox2.Text == "" || textBox3.Text == "" || textBox1.Text == "" || comboBox1.Text == "" || comboBox2.Text == "" || comboBox3.Text == "")
                    {
                        MessageBox.Show("Không được bỏ trống dữ liệu", "Thông báo");
                    }
                    else if (textBox1.Text.IndexOf(" ") != -1)
                    {
                        MessageBox.Show("Tài khoản không dùng cái khoảng trắng", "Thông báo");
                    }
                    else if (textBox4.Text == "")
                    {
                        MessageBox.Show("Vui lòng chọn giáo viên để sửa");
                    }
                    else if (comboBox3.SelectedValue.ToString() == "2")
                    {
                         MessageBox.Show("Phân quyền sai tài khoản này", "Thông báo");
                    }
                else
                    {
                        {
                            Connection ketnoi = new Connection();
                            ketnoi.openConn();
                            string sql = "UPDATE dbo.GIAOVIEN SET TAIKHOAN=N'" + textBox1.Text + "',MATKHAU='" + textBox3.Text + "',TENGV=N'" + textBox2.Text + "',GIOITINH=N'" + comboBox1.Text + "',MAKHOA='" + comboBox2.SelectedValue + "',MAQUYEN='" + comboBox3.SelectedValue + "' WHERE MAGV='" + textBox4.Text + "'";
                            ketnoi.executeUpdate(sql);
                            ketnoi.closeConn();
                            MessageBox.Show("Sửa thành công ♥");
                    
                        }
                    }

                }
                catch (Exception)
                {
                    MessageBox.Show("Đã có lỗi xảy ra vui lòng kiểm tra lại dữ liệu nhập", "thông báo");
               
                }
            
        }

        private void button3_Click(object sender, EventArgs e)
        {
            try
            {                        
                if (textBox4.Text == "")
                {
                    MessageBox.Show("Vui lòng chọn giáo viên để xóa");
                }
                else
                {
                    DialogResult result = MessageBox.Show("Bạn có chắc muốn xóa giáo viên này ?", "Xóa giáo viên", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
                    if (result == System.Windows.Forms.DialogResult.Yes)
                    {
                        Connection ketnoi = new Connection();
                        ketnoi.openConn();
                        string sql = "DELETE FROM dbo.GIAOVIEN WHERE MAGV='"+textBox4.Text+"'";
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

        private void textBox5_TextChanged(object sender, EventArgs e)
        {
          
        }

        private void comboBox3_SelectedIndexChanged(object sender, EventArgs e)
        {
           
        }

        private void textBox5_TextChanged_1(object sender, EventArgs e)
        {
            Connection ketnoi = new Connection();
            ketnoi.openConn();
            string sql = "SELECT* FROM dbo.GIAOVIEN WHERE TENGV LIKE N'%" + textBox5.Text + "%'";
            DataTable dt4 = ketnoi.loadDataTable(sql);       
            dataGridView1.DataSource = dt4;
            ketnoi.closeConn();
            
        }

        private void textBox7_KeyPress(object sender, KeyPressEventArgs e)
        {
            {
                if (!Char.IsDigit(e.KeyChar) && !Char.IsControl(e.KeyChar))
                    e.Handled = true;
            }
        }

        private void dataGridView2_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            int i;
            i = dataGridView2.CurrentRow.Index;
            txtmakhoa.Text = dataGridView2.Rows[i].Cells[0].Value.ToString();
            txttenkhoa.Text = dataGridView2.Rows[i].Cells[1].Value.ToString();
            txttinchi.Text = dataGridView2.Rows[i].Cells[2].Value.ToString();
        }

        private void button6_Click(object sender, EventArgs e)
        {
            try
            {
                if (txttenkhoa.Text =="" || txttinchi.Text=="")
                {
                    MessageBox.Show("Không được bỏ trống dữ liệu", "Thông báo");
                }                         
                else
                {

                    Connection ketnoi = new Connection();
                    ketnoi.openConn();
                    string sqlthem = "	INSERT INTO dbo.KHOA VALUES (N'"+txttenkhoa.Text+"',"+txttinchi.Text+")";
                    ketnoi.executeUpdate(sqlthem);
                    ketnoi.closeConn();
                    MessageBox.Show("Thêm thành công ♥");
                }

            }
            catch (Exception)
            {

                MessageBox.Show("đã có lỗi xảy ra vui lòng nhập đúng dữ liệu", "thông báo");

            }
        }
        private void button4_Click(object sender, EventArgs e)
        {
            try
            {
                if (txttenkhoa.Text == "" || txttinchi.Text == "")
                {
                    MessageBox.Show("Không được bỏ trống dữ liệu", "Thông báo");
                }
                else
                {

                    Connection ketnoi = new Connection();
                    ketnoi.openConn();
                    string sqlsua = "UPDATE dbo.KHOA SET TENKHOASV=N'"+txttenkhoa.Text+ "',TINCHIHT='"+txttinchi.Text+ "' WHERE MAKHOASV ='" + txtmakhoa.Text+"'";
                    ketnoi.executeUpdate(sqlsua);
                    ketnoi.closeConn();
                    MessageBox.Show("Sửa thành công ♥");
                }

            }
            catch (Exception)
            {

                MessageBox.Show("đã có lỗi xảy ra vui lòng nhập đúng dữ liệu", "thông báo");

            }

        }
        private void button5_Click(object sender, EventArgs e)
        {
            try
            {
                if (txtmakhoa.Text == "")
                {
                    MessageBox.Show("Không được bỏ trống dữ liệu", "Thông báo");
                }
                else
                {
                    DialogResult result = MessageBox.Show("Bạn có chắc muốn xóa khóa này ?", "Xóa khóa", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
                    if (result == System.Windows.Forms.DialogResult.Yes)
                    {
                        Connection ketnoi = new Connection();
                        ketnoi.openConn();
                        string sqlxoa = "DELETE FROM dbo.KHOA WHERE MAKHOASV='" + txtmakhoa.Text + "'";
                        ketnoi.executeUpdate(sqlxoa);
                        ketnoi.closeConn();
                        MessageBox.Show("Xóa thành công ♥");

                    }
                }

            }
            catch (Exception)
            {

                MessageBox.Show("Khóa này đã có dữ liệu không xóa được", "thông báo");

            }
        }

        private void textBox8_TextChanged(object sender, EventArgs e)
        {
            Connection ketnoi = new Connection();
            ketnoi.openConn();
            string sqltkkhoa = "SELECT* FROM dbo.KHOA WHERE TENKHOASV LIKE N'%" + textBox8.Text + "%'";
            DataTable dt_timkhoa = ketnoi.loadDataTable(sqltkkhoa);
            dataGridView2.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dataGridView2.DataSource = dt_timkhoa;
            ketnoi.closeConn();
        }

        private void label9_Click(object sender, EventArgs e)
        {

        }

        private void dataGridView3_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            int i;
            i = dataGridView3.CurrentRow.Index;
            txtkhoa.Text = dataGridView3.Rows[i].Cells[0].Value.ToString();
            txtkhoacn.Text = dataGridView3.Rows[i].Cells[1].Value.ToString();
        }

        private void button7_Click(object sender, EventArgs e)
        {
            try
            {
                if (txtkhoacn.Text == "")
                {
                    MessageBox.Show("Không được bỏ trống dữ liệu", "Thông báo");
                }
                else
                {

                    Connection ketnoi = new Connection();
                    ketnoi.openConn();
                    string sqlthem = "	INSERT INTO dbo.KHOACHUYENNGANH VALUES (N'" + txtkhoacn.Text + "')";
                    ketnoi.executeUpdate(sqlthem);
                    ketnoi.closeConn();
                    MessageBox.Show("Thêm thành công ♥");
                }

            }
            catch (Exception)
            {

                MessageBox.Show("đã có lỗi xảy ra vui lòng nhập đúng dữ liệu", "thông báo");

            }
        }

        private void button9_Click(object sender, EventArgs e)
        {
            try
            {
                if (txtkhoacn.Text == "" || txtkhoa.Text == "")
                {
                    MessageBox.Show("Không được bỏ trống dữ liệu", "Thông báo");
                }
                else
                {

                    Connection ketnoi = new Connection();
                    ketnoi.openConn();
                    string sqlsua = "UPDATE dbo.KHOACHUYENNGANH SET TENKHOA= N'" + txtkhoacn.Text + "'  WHERE MAKHOA ='" + txtkhoa.Text + "' ";
                    ketnoi.executeUpdate(sqlsua);
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
                if (txtkhoa.Text == "")
                {
                    MessageBox.Show("Không được bỏ trống dữ liệu", "Thông báo");
                }
                else
                {
                    DialogResult result = MessageBox.Show("Bạn có chắc muốn xóa khoa này ?", "Xóa khoa", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
                    if (result == System.Windows.Forms.DialogResult.Yes)
                    {
                        Connection ketnoi = new Connection();
                        ketnoi.openConn();
                        string sqlxoa = "DELETE FROM dbo.KHOACHUYENNGANH WHERE MAKHOA='" + txtkhoa.Text + "'";
                        ketnoi.executeUpdate(sqlxoa);
                        ketnoi.closeConn();
                        MessageBox.Show("Xóa thành công ♥");

                    }
                }

            }
            catch (Exception)
            {

                MessageBox.Show("Khoa này đã có dữ liệu không xóa được", "thông báo");

            }
        }

        private void textBox7_TextChanged(object sender, EventArgs e)
        {
            Connection ketnoi = new Connection();
            ketnoi.openConn();
            string sqltkkhoa = "SELECT* FROM dbo.KHOACHUYENNGANH WHERE TENKHOA LIKE N'%" + textBox7.Text + "%'";
            DataTable dt_timkhoa = ketnoi.loadDataTable(sqltkkhoa);
            dataGridView3.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dataGridView3.DataSource = dt_timkhoa;
            ketnoi.closeConn();

        }

        private void textBox7_TextChanged_1(object sender, EventArgs e)
        {
           
        }
    }
}
