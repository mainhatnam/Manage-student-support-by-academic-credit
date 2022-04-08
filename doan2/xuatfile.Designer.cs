
namespace doan2
{
    partial class xuatfile
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.button1 = new System.Windows.Forms.Button();
            this.cbtenmon = new System.Windows.Forms.ComboBox();
            this.cbtenhocky = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.button2 = new System.Windows.Forms.Button();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.MACD = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.MAMHSV1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.TENSV1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.TENMON = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.DIEMQT = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.DIEMGK = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.DIEMTHI = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.DIEMHP = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.DIEMCHU = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.HE4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.GHICHU = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(1314, 28);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(122, 43);
            this.button1.TabIndex = 1;
            this.button1.Text = "Xuất";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // cbtenmon
            // 
            this.cbtenmon.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend;
            this.cbtenmon.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            this.cbtenmon.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbtenmon.FormattingEnabled = true;
            this.cbtenmon.Location = new System.Drawing.Point(136, 116);
            this.cbtenmon.Name = "cbtenmon";
            this.cbtenmon.Size = new System.Drawing.Size(417, 30);
            this.cbtenmon.TabIndex = 2;
            // 
            // cbtenhocky
            // 
            this.cbtenhocky.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend;
            this.cbtenhocky.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            this.cbtenhocky.FormattingEnabled = true;
            this.cbtenhocky.Location = new System.Drawing.Point(723, 116);
            this.cbtenhocky.Name = "cbtenhocky";
            this.cbtenhocky.Size = new System.Drawing.Size(444, 24);
            this.cbtenhocky.TabIndex = 3;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(66, 123);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(64, 17);
            this.label1.TabIndex = 4;
            this.label1.Text = "Tên môn";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(639, 123);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(78, 17);
            this.label2.TabIndex = 5;
            this.label2.Text = "Tên học kỳ";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(528, 28);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(233, 29);
            this.label3.TabIndex = 6;
            this.label3.Text = "Xuất File chấm điểm";
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(1314, 107);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(116, 33);
            this.button2.TabIndex = 7;
            this.button2.Text = "Lọc";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridView1.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.MACD,
            this.MAMHSV1,
            this.TENSV1,
            this.TENMON,
            this.DIEMQT,
            this.DIEMGK,
            this.DIEMTHI,
            this.DIEMHP,
            this.DIEMCHU,
            this.HE4,
            this.GHICHU});
            this.dataGridView1.Location = new System.Drawing.Point(12, 179);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.Size = new System.Drawing.Size(1424, 591);
            this.dataGridView1.TabIndex = 8;
            // 
            // MACD
            // 
            this.MACD.HeaderText = "MACD";
            this.MACD.MinimumWidth = 6;
            this.MACD.Name = "MACD";
            // 
            // MAMHSV1
            // 
            this.MAMHSV1.DataPropertyName = "MAMHSV";
            this.MAMHSV1.HeaderText = "Mã môn học sv";
            this.MAMHSV1.MinimumWidth = 6;
            this.MAMHSV1.Name = "MAMHSV1";
            // 
            // TENSV1
            // 
            this.TENSV1.DataPropertyName = "TENSV";
            this.TENSV1.HeaderText = "Tên sinh viên";
            this.TENSV1.MinimumWidth = 6;
            this.TENSV1.Name = "TENSV1";
            // 
            // TENMON
            // 
            this.TENMON.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.TENMON.DataPropertyName = "TENMON";
            this.TENMON.HeaderText = "Tên Môn Học";
            this.TENMON.MinimumWidth = 6;
            this.TENMON.Name = "TENMON";
            this.TENMON.Width = 122;
            // 
            // DIEMQT
            // 
            this.DIEMQT.HeaderText = "DIEMQT";
            this.DIEMQT.MinimumWidth = 6;
            this.DIEMQT.Name = "DIEMQT";
            // 
            // DIEMGK
            // 
            this.DIEMGK.HeaderText = "DIEMGK";
            this.DIEMGK.MinimumWidth = 6;
            this.DIEMGK.Name = "DIEMGK";
            // 
            // DIEMTHI
            // 
            this.DIEMTHI.HeaderText = "DIEMTHI";
            this.DIEMTHI.MinimumWidth = 6;
            this.DIEMTHI.Name = "DIEMTHI";
            // 
            // DIEMHP
            // 
            this.DIEMHP.HeaderText = "DIEMHP";
            this.DIEMHP.MinimumWidth = 6;
            this.DIEMHP.Name = "DIEMHP";
            // 
            // DIEMCHU
            // 
            this.DIEMCHU.HeaderText = "DIEMCHU";
            this.DIEMCHU.MinimumWidth = 6;
            this.DIEMCHU.Name = "DIEMCHU";
            // 
            // HE4
            // 
            this.HE4.HeaderText = "HE4";
            this.HE4.MinimumWidth = 6;
            this.HE4.Name = "HE4";
            // 
            // GHICHU
            // 
            this.GHICHU.HeaderText = "GHICHU";
            this.GHICHU.MinimumWidth = 6;
            this.GHICHU.Name = "GHICHU";
            // 
            // xuatfile
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1437, 782);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.cbtenhocky);
            this.Controls.Add(this.cbtenmon);
            this.Controls.Add(this.button1);
            this.Name = "xuatfile";
            this.Text = "xuatfile";
            this.Activated += new System.EventHandler(this.xuatfile_Activated);
            this.Load += new System.EventHandler(this.xuatfile_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.ComboBox cbtenmon;
        private System.Windows.Forms.ComboBox cbtenhocky;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.DataGridViewTextBoxColumn MACD;
        private System.Windows.Forms.DataGridViewTextBoxColumn MAMHSV1;
        private System.Windows.Forms.DataGridViewTextBoxColumn TENSV1;
        private System.Windows.Forms.DataGridViewTextBoxColumn TENMON;
        private System.Windows.Forms.DataGridViewTextBoxColumn DIEMQT;
        private System.Windows.Forms.DataGridViewTextBoxColumn DIEMGK;
        private System.Windows.Forms.DataGridViewTextBoxColumn DIEMTHI;
        private System.Windows.Forms.DataGridViewTextBoxColumn DIEMHP;
        private System.Windows.Forms.DataGridViewTextBoxColumn DIEMCHU;
        private System.Windows.Forms.DataGridViewTextBoxColumn HE4;
        private System.Windows.Forms.DataGridViewTextBoxColumn GHICHU;
    }
}