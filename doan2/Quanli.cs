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
    public partial class Quanli : Form
    {
        public Quanli()
        {
            InitializeComponent();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            sinhvien a = new sinhvien();
            a.Show();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            giaovien b = new giaovien();
            b.Show();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            truongkhoa c = new truongkhoa();
            c.Show();
        }
    }
}
