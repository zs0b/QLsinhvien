namespace Bai5.GUI
{
    partial class Form1
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
            this.label1 = new System.Windows.Forms.Label();
            this.dataGridView_data = new System.Windows.Forms.DataGridView();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.pictureBox_anhdaidien = new System.Windows.Forms.PictureBox();
            this.textBox_diemtrungbinh = new System.Windows.Forms.TextBox();
            this.comboBox_khoa = new System.Windows.Forms.ComboBox();
            this.textBox_hoten = new System.Windows.Forms.TextBox();
            this.textBox_masinhvien = new System.Windows.Forms.TextBox();
            this.button_delete = new System.Windows.Forms.Button();
            this.button_addandupdate = new System.Windows.Forms.Button();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.checkBox_chuadangky = new System.Windows.Forms.CheckBox();
            this.button_uploadimage = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView_data)).BeginInit();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox_anhdaidien)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.IndianRed;
            this.label1.Location = new System.Drawing.Point(364, 42);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(172, 24);
            this.label1.TabIndex = 0;
            this.label1.Text = "Quản lý sinh viên";
            // 
            // dataGridView_data
            // 
            this.dataGridView_data.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.dataGridView_data.Location = new System.Drawing.Point(368, 115);
            this.dataGridView_data.Name = "dataGridView_data";
            this.dataGridView_data.Size = new System.Drawing.Size(545, 375);
            this.dataGridView_data.TabIndex = 1;
            this.dataGridView_data.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView_data_CellClick);

            // 
            // groupBox1
            // 
            this.groupBox1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.groupBox1.Controls.Add(this.button_uploadimage);
            this.groupBox1.Controls.Add(this.pictureBox_anhdaidien);
            this.groupBox1.Controls.Add(this.textBox_diemtrungbinh);
            this.groupBox1.Controls.Add(this.comboBox_khoa);
            this.groupBox1.Controls.Add(this.textBox_hoten);
            this.groupBox1.Controls.Add(this.textBox_masinhvien);
            this.groupBox1.Controls.Add(this.button_delete);
            this.groupBox1.Controls.Add(this.button_addandupdate);
            this.groupBox1.Controls.Add(this.label6);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.ForeColor = System.Drawing.SystemColors.Highlight;
            this.groupBox1.Location = new System.Drawing.Point(13, 115);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(349, 375);
            this.groupBox1.TabIndex = 2;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Thông tin sinh viên";
            // 
            // pictureBox_anhdaidien
            // 
            this.pictureBox_anhdaidien.Location = new System.Drawing.Point(138, 190);
            this.pictureBox_anhdaidien.Name = "pictureBox_anhdaidien";
            this.pictureBox_anhdaidien.Size = new System.Drawing.Size(174, 139);
            this.pictureBox_anhdaidien.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox_anhdaidien.TabIndex = 11;
            this.pictureBox_anhdaidien.TabStop = false;
            // 
            // textBox_diemtrungbinh
            // 
            this.textBox_diemtrungbinh.Location = new System.Drawing.Point(138, 150);
            this.textBox_diemtrungbinh.Name = "textBox_diemtrungbinh";
            this.textBox_diemtrungbinh.Size = new System.Drawing.Size(174, 22);
            this.textBox_diemtrungbinh.TabIndex = 10;
            // 
            // comboBox_khoa
            // 
            this.comboBox_khoa.FormattingEnabled = true;
            this.comboBox_khoa.Location = new System.Drawing.Point(138, 109);
            this.comboBox_khoa.Name = "comboBox_khoa";
            this.comboBox_khoa.Size = new System.Drawing.Size(174, 24);
            this.comboBox_khoa.TabIndex = 9;
            // 
            // textBox_hoten
            // 
            this.textBox_hoten.Location = new System.Drawing.Point(138, 72);
            this.textBox_hoten.Name = "textBox_hoten";
            this.textBox_hoten.Size = new System.Drawing.Size(174, 22);
            this.textBox_hoten.TabIndex = 8;
            // 
            // textBox_masinhvien
            // 
            this.textBox_masinhvien.Location = new System.Drawing.Point(138, 37);
            this.textBox_masinhvien.Name = "textBox_masinhvien";
            this.textBox_masinhvien.Size = new System.Drawing.Size(174, 22);
            this.textBox_masinhvien.TabIndex = 7;
            // 
            // button_delete
            // 
            this.button_delete.Location = new System.Drawing.Point(138, 346);
            this.button_delete.Name = "button_delete";
            this.button_delete.Size = new System.Drawing.Size(101, 23);
            this.button_delete.TabIndex = 6;
            this.button_delete.Text = "Delete";
            this.button_delete.UseVisualStyleBackColor = true;
            // 
            // button_addandupdate
            // 
            this.button_addandupdate.Location = new System.Drawing.Point(8, 346);
            this.button_addandupdate.Name = "button_addandupdate";
            this.button_addandupdate.Size = new System.Drawing.Size(102, 23);
            this.button_addandupdate.TabIndex = 5;
            this.button_addandupdate.Text = "Add/Update";
            this.button_addandupdate.UseVisualStyleBackColor = true;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.ForeColor = System.Drawing.SystemColors.Desktop;
            this.label6.Location = new System.Drawing.Point(23, 190);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(87, 16);
            this.label6.TabIndex = 4;
            this.label6.Text = "Ảnh đại diện: ";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.ForeColor = System.Drawing.SystemColors.Desktop;
            this.label5.Location = new System.Drawing.Point(6, 150);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(104, 16);
            this.label5.TabIndex = 3;
            this.label5.Text = "Điểm trung bình: ";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.ForeColor = System.Drawing.SystemColors.Desktop;
            this.label4.Location = new System.Drawing.Point(66, 109);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(44, 16);
            this.label4.TabIndex = 2;
            this.label4.Text = "Khoa: ";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.ForeColor = System.Drawing.SystemColors.Desktop;
            this.label3.Location = new System.Drawing.Point(58, 72);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(52, 16);
            this.label3.TabIndex = 1;
            this.label3.Text = "Họ tên: ";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.ForeColor = System.Drawing.SystemColors.Desktop;
            this.label2.Location = new System.Drawing.Point(23, 37);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(87, 16);
            this.label2.TabIndex = 0;
            this.label2.Text = "Mã sinh viên: ";
            // 
            // checkBox_chuadangky
            // 
            this.checkBox_chuadangky.AutoSize = true;
            this.checkBox_chuadangky.Location = new System.Drawing.Point(749, 92);
            this.checkBox_chuadangky.Name = "checkBox_chuadangky";
            this.checkBox_chuadangky.Size = new System.Drawing.Size(164, 17);
            this.checkBox_chuadangky.TabIndex = 3;
            this.checkBox_chuadangky.Text = "Chưa đăng ký chuyên ngành";
            this.checkBox_chuadangky.UseVisualStyleBackColor = true;
            this.checkBox_chuadangky.CheckedChanged += new System.EventHandler(this.checkBox_chuadangky_CheckedChanged);
            // 
            // button_uploadimage
            // 
            this.button_uploadimage.Location = new System.Drawing.Point(319, 247);
            this.button_uploadimage.Name = "button_uploadimage";
            this.button_uploadimage.Size = new System.Drawing.Size(24, 23);
            this.button_uploadimage.TabIndex = 12;
            this.button_uploadimage.Text = "...";
            this.button_uploadimage.UseVisualStyleBackColor = true;
            this.button_uploadimage.Click += new System.EventHandler(this.button_uploadimage_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(925, 502);
            this.Controls.Add(this.checkBox_chuadangky);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.dataGridView_data);
            this.Controls.Add(this.label1);
            this.MaximizeBox = false;
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Quản Lý Sinh Viên";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView_data)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox_anhdaidien)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.TextBox textBox_hoten;
        private System.Windows.Forms.TextBox textBox_masinhvien;
        private System.Windows.Forms.Button button_delete;
        private System.Windows.Forms.Button button_addandupdate;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.PictureBox pictureBox_anhdaidien;
        private System.Windows.Forms.TextBox textBox_diemtrungbinh;
        private System.Windows.Forms.ComboBox comboBox_khoa;
        private System.Windows.Forms.CheckBox checkBox_chuadangky;
        private System.Windows.Forms.DataGridView dataGridView_data;
        private System.Windows.Forms.Button button_uploadimage;
    }
}

