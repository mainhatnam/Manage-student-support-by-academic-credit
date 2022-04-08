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
    public partial class them_file_excel : Form
    {
        public them_file_excel()
        {
            InitializeComponent();
        }
        DataTableCollection tableCollection;
        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                using (OpenFileDialog openFileDialog = new OpenFileDialog() { Filter = "Excel 97-2003 Workbook|*.xls|Excel Worbook|*.xlsx" })
                {
                    if (openFileDialog.ShowDialog() == DialogResult.OK)
                    {
                        txtfilename.Text = openFileDialog.FileName;
                        using (var stream = File.Open(openFileDialog.FileName, FileMode.Open, FileAccess.Read))
                        {
                            using (IExcelDataReader reader = ExcelReaderFactory.CreateReader(stream))
                            {
                                DataSet result = reader.AsDataSet(new ExcelDataSetConfiguration()
                                {
                                    ConfigureDataTable = (_) => new ExcelDataTableConfiguration() { UseHeaderRow = true }
                                });
                                tableCollection = result.Tables;
                                cbosheet.Items.Clear();
                                foreach (DataTable table in tableCollection)
                                    cbosheet.Items.Add(table.TableName);
                                {

                                }
                            }
                        }
                    }
                }
            }
            catch (Exception)
            {
                MessageBox.Show("tắt file excel mới có thể thực hiện được ");
                txtfilename.Clear();
                cbosheet.Items.Clear();
            }
           
        }

        private void cbosheet_SelectedIndexChanged(object sender, EventArgs e)
        {
            DataTable dt = tableCollection[cbosheet.SelectedItem.ToString()];
            dataGridView1.DataSource = dt;
        }

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
        private void button3_Click(object sender, EventArgs e)
        {

            float a, b, c, diemhp, he4;
            string chu;
          


            if (txtfilename.Text == "" || cbosheet.Text == "")
            {
                MessageBox.Show("Dữ liệu không được bỏ trống");
            }
            else
            {
                try
                {

                    Connection ketnoi = new Connection();
                    ketnoi.openConn();
                 
                    for (int i = 0; i < dataGridView1.Rows.Count; i++)
                    {
                    
                        a = Convert.ToSingle(dataGridView1.Rows[i].Cells[4].Value);
                        b = Convert.ToSingle(dataGridView1.Rows[i].Cells[5].Value);
                        c = Convert.ToSingle(dataGridView1.Rows[i].Cells[6].Value);
                        diemhp = tinhdiemtrungbinh(a, b, c);
                        chu = tinhdiemchu(tongdiem);
                        he4 = tinhdiemhe4(diemchu1);               
                        string sql = "INSERT INTO CHAMDIEMSV VALUES(" + Convert.ToInt32(dataGridView1.Rows[i].Cells[1].Value) + "," + a + "," + b + "," + c + "," + diemhp + ",N'" + chu.ToString() + "'," + he4 + ",N'" + dataGridView1.Rows[i].Cells[10].Value.ToString() + "')";
                        ketnoi.executeUpdate(sql);

                    }

                
                    MessageBox.Show("them thanh cong");
                    ketnoi.closeConn();

                }
                catch (Exception)
                {
                    MessageBox.Show("loi");

                }

            }
        }


        private void them_file_excel_Load(object sender, EventArgs e)
        {
            Connection ketnoi = new Connection();
            ketnoi.openConn();
            string sql = "SELECT CHAMDIEMSV.MACD,CHAMDIEMSV.MAMHSV,TENSV,TENMON,CHAMDIEMSV.DIEMQT,CHAMDIEMSV.DIEMGK,CHAMDIEMSV.DIEMTHI,CHAMDIEMSV.DIEMHP,CHAMDIEMSV.DIEMCHU,CHAMDIEMSV.HE4,CHAMDIEMSV.GHICHU FROM dbo.CHAMDIEMSV,dbo.MONHOCSV,dbo.SINHVIEN,dbo.MONHOC WHERE dbo.CHAMDIEMSV.MAMHSV = dbo.MONHOCSV.MAMHSV AND dbo.MONHOCSV.MASV =dbo.SINHVIEN.MASV AND dbo.MONHOCSV.MAMON = dbo.MONHOC.MAMON ";
            DataTable dt2 = ketnoi.loadDataTable(sql);
            dataGridView1.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dataGridView1.DataSource = dt2;
            ketnoi.closeConn();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Connection ketnoi = new Connection();
            ketnoi.openConn();
            string sql = "	SELECT CHAMDIEMSV.MACD,CHAMDIEMSV.MAMHSV,TENSV,TENMON,CHAMDIEMSV.DIEMQT,CHAMDIEMSV.DIEMGK,CHAMDIEMSV.DIEMTHI,CHAMDIEMSV.DIEMHP,CHAMDIEMSV.DIEMCHU,CHAMDIEMSV.HE4,CHAMDIEMSV.GHICHU FROM dbo.CHAMDIEMSV,dbo.MONHOCSV,dbo.SINHVIEN,dbo.MONHOC WHERE dbo.CHAMDIEMSV.MAMHSV = dbo.MONHOCSV.MAMHSV AND dbo.MONHOCSV.MASV =dbo.SINHVIEN.MASV AND dbo.MONHOCSV.MAMON = dbo.MONHOC.MAMON";
            DataTable dt2 = ketnoi.loadDataTable(sql);
            dataGridView1.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dataGridView1.DataSource = dt2;
            ketnoi.closeConn();

            txtfilename.Clear();
            cbosheet.Items.Clear();
        }

        private void button4_Click(object sender, EventArgs e)
        {

        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            //    int i;
            //    i = dataGridView1.CurrentRow.Index;
            //    textBox1.Text = dataGridView1.Rows[i].Cells[1].Value.ToString();
            //    textBox2.Text = dataGridView1.Rows[i].Cells[4].Value.ToString();
            //    textBox3.Text = dataGridView1.Rows[i].Cells[5].Value.ToString();
            //    textBox4.Text = dataGridView1.Rows[i].Cells[6].Value.ToString();
            //    textBox5.Text = dataGridView1.Rows[i].Cells[7].Value.ToString();
            //    textBox6.Text = dataGridView1.Rows[i].Cells[8].Value.ToString();
            //    textBox7.Text = dataGridView1.Rows[i].Cells[9].Value.ToString();
            //
        }
        bool a = false;
        private void button4_Click_1(object sender, EventArgs e)
        {
            try
            {
                Connection ketnoi = new Connection();
                ketnoi.openConn();
                int k = 0;
                for (int i = 0; i < dataGridView1.Rows.Count; i++)
                {
                    string kt = "select COUNT(*) from CHAMDIEMSV where MAMHSV ='" + dataGridView1.Rows[i].Cells[1].Value.ToString() + "'";
                    DataTable dtkt = ketnoi.loadDataTable(kt);
                    if (Convert.ToInt32(dtkt.Rows[0][0].ToString()) >= 1)
                    {
                        k++;
                    }
                }
                if (txtfilename.Text == "" || cbosheet.Text == "")
                {
                    a = false;
                    MessageBox.Show("không được bỏ trống");

                }
                else if (k >= 1)
                {
                    a = false;
                    MessageBox.Show("dữ liệu bị trùng");
                }
                else
                {
                    a = true;
                    MessageBox.Show("thành công");

                }
            }
            catch (Exception)
            {
                MessageBox.Show("loi");

            }
           
        }

        private void them_file_excel_Activated(object sender, EventArgs e)
        {
            if (a == true)
            {
                button3.Enabled = a;
            }
            else
            {
                button3.Enabled = a;
            }
        }
    }
}
