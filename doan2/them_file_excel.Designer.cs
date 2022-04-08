
namespace doan2
{
    partial class them_file_excel
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
            this.label2 = new System.Windows.Forms.Label();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.MACD = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.MAMHSV = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.TENSV1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tenmon = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.DIEMQT = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.DIEMGK = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.DIEMTHI = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.DIEMHP = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.DIEMCHU = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.HE4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.GHICHU = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cbosheet = new System.Windows.Forms.ComboBox();
            this.button3 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.txtfilename = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.button4 = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(36, 76);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(45, 17);
            this.label2.TabIndex = 25;
            this.label2.Text = "Sheet";
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.MACD,
            this.MAMHSV,
            this.TENSV1,
            this.tenmon,
            this.DIEMQT,
            this.DIEMGK,
            this.DIEMTHI,
            this.DIEMHP,
            this.DIEMCHU,
            this.HE4,
            this.GHICHU});
            this.dataGridView1.Location = new System.Drawing.Point(6, 141);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.Size = new System.Drawing.Size(1534, 529);
            this.dataGridView1.TabIndex = 24;
            this.dataGridView1.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellClick);
            // 
            // MACD
            // 
            this.MACD.DataPropertyName = "MACD";
            this.MACD.HeaderText = "MACD";
            this.MACD.MinimumWidth = 6;
            this.MACD.Name = "MACD";
            this.MACD.ReadOnly = true;
            // 
            // MAMHSV
            // 
            this.MAMHSV.DataPropertyName = "MAMHSV";
            this.MAMHSV.HeaderText = "MAMHSV";
            this.MAMHSV.MinimumWidth = 6;
            this.MAMHSV.Name = "MAMHSV";
            this.MAMHSV.ReadOnly = true;
            // 
            // TENSV1
            // 
            this.TENSV1.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.TENSV1.DataPropertyName = "TENSV";
            this.TENSV1.HeaderText = "Tên sinh viên";
            this.TENSV1.MinimumWidth = 6;
            this.TENSV1.Name = "TENSV1";
            this.TENSV1.ReadOnly = true;
            this.TENSV1.Width = 122;
            // 
            // tenmon
            // 
            this.tenmon.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.tenmon.DataPropertyName = "tenmon";
            this.tenmon.HeaderText = "Tên môn ";
            this.tenmon.MinimumWidth = 6;
            this.tenmon.Name = "tenmon";
            this.tenmon.ReadOnly = true;
            this.tenmon.Width = 97;
            // 
            // DIEMQT
            // 
            this.DIEMQT.DataPropertyName = "DIEMQT";
            this.DIEMQT.HeaderText = "DIEMQT";
            this.DIEMQT.MinimumWidth = 6;
            this.DIEMQT.Name = "DIEMQT";
            this.DIEMQT.ReadOnly = true;
            // 
            // DIEMGK
            // 
            this.DIEMGK.DataPropertyName = "DIEMGK";
            this.DIEMGK.HeaderText = "DIEMGK";
            this.DIEMGK.MinimumWidth = 6;
            this.DIEMGK.Name = "DIEMGK";
            this.DIEMGK.ReadOnly = true;
            // 
            // DIEMTHI
            // 
            this.DIEMTHI.DataPropertyName = "DIEMTHI";
            this.DIEMTHI.HeaderText = "DIEMTHI";
            this.DIEMTHI.MinimumWidth = 6;
            this.DIEMTHI.Name = "DIEMTHI";
            this.DIEMTHI.ReadOnly = true;
            // 
            // DIEMHP
            // 
            this.DIEMHP.DataPropertyName = "DIEMHP";
            this.DIEMHP.HeaderText = "DIEMHP";
            this.DIEMHP.MinimumWidth = 6;
            this.DIEMHP.Name = "DIEMHP";
            this.DIEMHP.ReadOnly = true;
            // 
            // DIEMCHU
            // 
            this.DIEMCHU.DataPropertyName = "DIEMCHU";
            this.DIEMCHU.HeaderText = "DIEMCHU";
            this.DIEMCHU.MinimumWidth = 6;
            this.DIEMCHU.Name = "DIEMCHU";
            this.DIEMCHU.ReadOnly = true;
            // 
            // HE4
            // 
            this.HE4.DataPropertyName = "HE4";
            this.HE4.HeaderText = "HE4";
            this.HE4.MinimumWidth = 6;
            this.HE4.Name = "HE4";
            this.HE4.ReadOnly = true;
            // 
            // GHICHU
            // 
            this.GHICHU.DataPropertyName = "GHICHU";
            this.GHICHU.HeaderText = "GHICHU";
            this.GHICHU.MinimumWidth = 6;
            this.GHICHU.Name = "GHICHU";
            this.GHICHU.ReadOnly = true;
            // 
            // cbosheet
            // 
            this.cbosheet.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbosheet.FormattingEnabled = true;
            this.cbosheet.Location = new System.Drawing.Point(87, 69);
            this.cbosheet.Name = "cbosheet";
            this.cbosheet.Size = new System.Drawing.Size(123, 24);
            this.cbosheet.TabIndex = 23;
            this.cbosheet.SelectedIndexChanged += new System.EventHandler(this.cbosheet_SelectedIndexChanged);
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(393, 102);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(117, 33);
            this.button3.TabIndex = 22;
            this.button3.Text = "Thêm ";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(526, 102);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(114, 33);
            this.button2.TabIndex = 21;
            this.button2.Text = "Làm mới";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(605, 18);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(35, 23);
            this.button1.TabIndex = 20;
            this.button1.Text = "...";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // txtfilename
            // 
            this.txtfilename.Location = new System.Drawing.Point(87, 18);
            this.txtfilename.Name = "txtfilename";
            this.txtfilename.ReadOnly = true;
            this.txtfilename.Size = new System.Drawing.Size(512, 22);
            this.txtfilename.TabIndex = 19;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 21);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(69, 17);
            this.label1.TabIndex = 18;
            this.label1.Text = "File name";
            // 
            // button4
            // 
            this.button4.Location = new System.Drawing.Point(231, 67);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(88, 27);
            this.button4.TabIndex = 26;
            this.button4.Text = "kiểm tra";
            this.button4.UseVisualStyleBackColor = true;
            this.button4.Click += new System.EventHandler(this.button4_Click_1);
            // 
            // them_file_excel
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1552, 682);
            this.Controls.Add(this.button4);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.cbosheet);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.txtfilename);
            this.Controls.Add(this.label1);
            this.Name = "them_file_excel";
            this.Text = "them_file_excel";
            this.Activated += new System.EventHandler(this.them_file_excel_Activated);
            this.Load += new System.EventHandler(this.them_file_excel_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.ComboBox cbosheet;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.TextBox txtfilename;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridViewTextBoxColumn MACD;
        private System.Windows.Forms.DataGridViewTextBoxColumn MAMHSV;
        private System.Windows.Forms.DataGridViewTextBoxColumn TENSV1;
        private System.Windows.Forms.DataGridViewTextBoxColumn tenmon;
        private System.Windows.Forms.DataGridViewTextBoxColumn DIEMQT;
        private System.Windows.Forms.DataGridViewTextBoxColumn DIEMGK;
        private System.Windows.Forms.DataGridViewTextBoxColumn DIEMTHI;
        private System.Windows.Forms.DataGridViewTextBoxColumn DIEMHP;
        private System.Windows.Forms.DataGridViewTextBoxColumn DIEMCHU;
        private System.Windows.Forms.DataGridViewTextBoxColumn HE4;
        private System.Windows.Forms.DataGridViewTextBoxColumn GHICHU;
        private System.Windows.Forms.Button button4;
    }
}