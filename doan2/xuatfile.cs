using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using GemBox.Spreadsheet;
using GemBox.Spreadsheet.WinFormsUtilities;
namespace doan2
{
    public partial class xuatfile : Form
    {
        public xuatfile()
        {
            InitializeComponent();
            SpreadsheetInfo.SetLicense("FREE-LIMITED-KEY");
        }

        void check()
        {
            if (dataGridView1.Rows.Count != 0)
            {
                button1.Enabled = true;

            }
            else
            {
                button1.Enabled = false;
            }
        }
        private void xuatfile_Activated(object sender, EventArgs e)
        {
            Connection ketnoi = new Connection();
            ketnoi.openConn();
            check();
            string cbtenmon1 = "SELECT TENMON,MAMON FROM dbo.MONHOC";
            DataTable tenmon = ketnoi.loadDataTable(cbtenmon1);
            cbtenmon.DataSource = tenmon;
            cbtenmon.ValueMember = "MAMON";
            cbtenmon.DisplayMember = "TENMON";
            cbtenmon.AutoCompleteMode = AutoCompleteMode.SuggestAppend;
            cbtenmon.AutoCompleteSource = AutoCompleteSource.ListItems;
            ////////////////////////////////
            string sql12 = "SELECT MAHKNH,TENHKNH FROM dbo.HOCKYNAMHOC";
            DataTable dt12 = ketnoi.loadDataTable(sql12);
            cbtenhocky.DataSource = dt12;
            cbtenhocky.ValueMember = "MAHKNH";
            cbtenhocky.DisplayMember = "TENHKNH";
            cbtenhocky.AutoCompleteMode = AutoCompleteMode.SuggestAppend;
            cbtenhocky.AutoCompleteSource = AutoCompleteSource.ListItems;
         
         
        }

        private void button1_Click(object sender, EventArgs e)
        {
            SaveFileDialog saveFileDialog = new SaveFileDialog();
            saveFileDialog.Filter = "XLS files(*.xls)|.xls";
            if (saveFileDialog.ShowDialog()==DialogResult.OK)
            {
                ExcelFile ef = new ExcelFile();
                ExcelWorksheet ws = ef.Worksheets.Add("Sheet1");
                DataGridViewConverter.ImportFromDataGridView(ws, this.dataGridView1, new ImportFromDataGridViewOptions() { ColumnHeaders = true });
                ef.Save(saveFileDialog.FileName);
            }

        }

        private void xuatfile_Load(object sender, EventArgs e)
        {
          
        }

        private void button2_Click(object sender, EventArgs e)
        {
            try
            {
                Connection ketnoi = new Connection();
                ketnoi.openConn();
                String sql = "SELECT MONHOCSV.MAMHSV,MONHOC.TENMON,SINHVIEN.TENSV FROM dbo.MONHOCSV,dbo.MONHOC,dbo.SINHVIEN,dbo.HOCKYNAMHOC WHERE dbo.MONHOCSV.MAMON=dbo.MONHOC.MAMON AND dbo.MONHOCSV.MASV = dbo.SINHVIEN.MASV AND dbo.MONHOCSV.MAHKNH = dbo.HOCKYNAMHOC.MAHKNH AND MONHOC.MAMON='" + cbtenmon.SelectedValue + "' AND MONHOCSV.MAHKNH='" + cbtenhocky.SelectedValue + "'";
                DataTable dt = ketnoi.loadDataTable(sql);
                dataGridView1.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
                dataGridView1.AutoGenerateColumns = false;
                   
                dataGridView1.DataSource = dt;
                if (dataGridView1.Rows.Count != 0)
                {
                    MessageBox.Show("Lọc thành công");

                }
                else
                {
                    MessageBox.Show("không có dữ liệu");
                }
             
            }
            catch (Exception)
            {

                MessageBox.Show("lỗi");
            }
          
        }
    }
}
