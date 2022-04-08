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
    public partial class excel_DKMH : Form
    {
        public excel_DKMH()
        {
            InitializeComponent();
        }
        DataTableCollection tableCollection;
        bool a = false;
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

        private void button3_Click(object sender, EventArgs e)
        {
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
                        string sql = "INSERT INTO MONHOCSV VALUES(" + Convert.ToInt32(dataGridView1.Rows[i].Cells[0].Value)+ ","+Convert.ToInt32(dataGridView1.Rows[i].Cells[3].Value) +","+ Convert.ToInt32(dataGridView1.Rows[i].Cells[5].Value) + ")";
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

        private void excel_DKMH_Load(object sender, EventArgs e)
        {
            Connection ketnoi = new Connection();
            ketnoi.openConn();
            string sql9 = "SELECT MONHOCSV.MAMHSV,MONHOCSV.MAMON,MONHOC.TENMON,MONHOC.TCMON,dbo.MONHOCSV.MASV,SINHVIEN.TENSV,dbo.MONHOCSV.MAHKNH,HOCKYNAMHOC.TENHKNH FROM dbo.MONHOCSV,dbo.MONHOC,dbo.SINHVIEN,dbo.HOCKYNAMHOC WHERE dbo.MONHOCSV.MAMON=dbo.MONHOC.MAMON AND dbo.MONHOCSV.MASV = dbo.SINHVIEN.MASV AND dbo.MONHOCSV.MAHKNH = dbo.HOCKYNAMHOC.MAHKNH";
            DataTable dt10 = ketnoi.loadDataTable(sql9);
            dataGridView1.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dataGridView1.DataSource = dt10;
            ketnoi.closeConn();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Connection ketnoi = new Connection();
            ketnoi.openConn();
            string sql9 = "SELECT MONHOCSV.MAMHSV,MONHOCSV.MAMON,MONHOC.TENMON,MONHOC.TCMON,dbo.MONHOCSV.MASV,SINHVIEN.TENSV,dbo.MONHOCSV.MAHKNH,HOCKYNAMHOC.TENHKNH FROM dbo.MONHOCSV,dbo.MONHOC,dbo.SINHVIEN,dbo.HOCKYNAMHOC WHERE dbo.MONHOCSV.MAMON=dbo.MONHOC.MAMON AND dbo.MONHOCSV.MASV = dbo.SINHVIEN.MASV AND dbo.MONHOCSV.MAHKNH = dbo.HOCKYNAMHOC.MAHKNH";
            DataTable dt10 = ketnoi.loadDataTable(sql9);
            dataGridView1.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dataGridView1.DataSource = dt10;
            ketnoi.closeConn();

            txtfilename.Clear();
            cbosheet.Items.Clear();
        }
        
        private void excel_DKMH_Activated(object sender, EventArgs e)
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

        private void button4_Click(object sender, EventArgs e)
        {
            try   
            {
                //0 3 5
                int b = 0;
                Connection ketnoi = new Connection();
                ketnoi.openConn();
                
                for (int i = 0; i < dataGridView1.Rows.Count; i++)
                {
                    string sql = "select COUNT(*) from dbo.MONHOCSV where Mamon='"+dataGridView1.Rows[i].Cells[0].Value.ToString()+"' and Masv ='"+ dataGridView1.Rows[i].Cells[3].Value.ToString() + "' and MAHKNH = '"+ dataGridView1.Rows[i].Cells[5].Value.ToString() + "'";
                    DataTable dt = ketnoi.loadDataTable(sql);
                    if (Convert.ToInt32(dt.Rows[0][0].ToString()) >= 1)
                    {
                        b++;
                    }
                }             
                if (txtfilename.Text == "" || cbosheet.Text == "")
                {
                    a = false;
                    MessageBox.Show("không được bỏ trống");

                }
                else if (b >= 1)
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
    }
}
