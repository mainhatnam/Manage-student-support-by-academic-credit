
namespace doan2
{
    partial class excel_DKMH
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
            this.cbosheet = new System.Windows.Forms.ComboBox();
            this.button3 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.txtfilename = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.MAMON = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.TENMON = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.TCMON = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.MASV = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.TENSV = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.MAHKNH = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.TENHKNH = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.button4 = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(38, 81);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(45, 17);
            this.label2.TabIndex = 32;
            this.label2.Text = "Sheet";
            // 
            // cbosheet
            // 
            this.cbosheet.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbosheet.FormattingEnabled = true;
            this.cbosheet.Location = new System.Drawing.Point(89, 74);
            this.cbosheet.Name = "cbosheet";
            this.cbosheet.Size = new System.Drawing.Size(123, 24);
            this.cbosheet.TabIndex = 31;
            this.cbosheet.SelectedIndexChanged += new System.EventHandler(this.cbosheet_SelectedIndexChanged);
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(395, 107);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(117, 33);
            this.button3.TabIndex = 30;
            this.button3.Text = "Thêm ";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(539, 107);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(114, 33);
            this.button2.TabIndex = 29;
            this.button2.Text = "Làm mới";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(607, 23);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(35, 23);
            this.button1.TabIndex = 28;
            this.button1.Text = "...";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // txtfilename
            // 
            this.txtfilename.Location = new System.Drawing.Point(89, 23);
            this.txtfilename.Name = "txtfilename";
            this.txtfilename.ReadOnly = true;
            this.txtfilename.Size = new System.Drawing.Size(512, 22);
            this.txtfilename.TabIndex = 27;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(14, 26);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(69, 17);
            this.label1.TabIndex = 26;
            this.label1.Text = "File name";
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.MAMON,
            this.TENMON,
            this.TCMON,
            this.MASV,
            this.TENSV,
            this.MAHKNH,
            this.TENHKNH});
            this.dataGridView1.Location = new System.Drawing.Point(12, 146);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.Size = new System.Drawing.Size(1280, 508);
            this.dataGridView1.TabIndex = 33;
            // 
            // MAMON
            // 
            this.MAMON.DataPropertyName = "MAMON";
            this.MAMON.HeaderText = "Mã môn học";
            this.MAMON.MinimumWidth = 6;
            this.MAMON.Name = "MAMON";
            // 
            // TENMON
            // 
            this.TENMON.DataPropertyName = "TENMON";
            this.TENMON.HeaderText = "Tên môn";
            this.TENMON.MinimumWidth = 6;
            this.TENMON.Name = "TENMON";
            // 
            // TCMON
            // 
            this.TCMON.DataPropertyName = "TCMON";
            this.TCMON.HeaderText = "Tín chỉ môn";
            this.TCMON.MinimumWidth = 6;
            this.TCMON.Name = "TCMON";
            // 
            // MASV
            // 
            this.MASV.DataPropertyName = "MASV";
            this.MASV.HeaderText = "Mã sinh viên";
            this.MASV.MinimumWidth = 6;
            this.MASV.Name = "MASV";
            // 
            // TENSV
            // 
            this.TENSV.DataPropertyName = "TENSV";
            this.TENSV.HeaderText = "Tên sinh viên";
            this.TENSV.MinimumWidth = 6;
            this.TENSV.Name = "TENSV";
            // 
            // MAHKNH
            // 
            this.MAHKNH.DataPropertyName = "MAHKNH";
            this.MAHKNH.HeaderText = "Mã học kỳ năm học";
            this.MAHKNH.MinimumWidth = 6;
            this.MAHKNH.Name = "MAHKNH";
            // 
            // TENHKNH
            // 
            this.TENHKNH.DataPropertyName = "TENHKNH";
            this.TENHKNH.HeaderText = "Tên học kỳ năm học";
            this.TENHKNH.MinimumWidth = 6;
            this.TENHKNH.Name = "TENHKNH";
            // 
            // button4
            // 
            this.button4.Location = new System.Drawing.Point(227, 69);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(98, 29);
            this.button4.TabIndex = 34;
            this.button4.Text = "Kiểm tra";
            this.button4.UseVisualStyleBackColor = true;
            this.button4.Click += new System.EventHandler(this.button4_Click);
            // 
            // excel_DKMH
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1290, 657);
            this.Controls.Add(this.button4);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.cbosheet);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.txtfilename);
            this.Controls.Add(this.label1);
            this.Name = "excel_DKMH";
            this.Text = "excel_DKMH";
            this.Activated += new System.EventHandler(this.excel_DKMH_Activated);
            this.Load += new System.EventHandler(this.excel_DKMH_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox cbosheet;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.TextBox txtfilename;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.DataGridViewTextBoxColumn MAMON;
        private System.Windows.Forms.DataGridViewTextBoxColumn TENMON;
        private System.Windows.Forms.DataGridViewTextBoxColumn TCMON;
        private System.Windows.Forms.DataGridViewTextBoxColumn MASV;
        private System.Windows.Forms.DataGridViewTextBoxColumn TENSV;
        private System.Windows.Forms.DataGridViewTextBoxColumn MAHKNH;
        private System.Windows.Forms.DataGridViewTextBoxColumn TENHKNH;
        private System.Windows.Forms.Button button4;
    }
}