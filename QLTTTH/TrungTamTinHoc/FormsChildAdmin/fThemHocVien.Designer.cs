
namespace TrungTamTinHoc.FormsChildAdmin
{
    partial class fThemHocVien
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
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.btn_Add = new FontAwesome.Sharp.IconButton();
            this.btn_Delete = new FontAwesome.Sharp.IconButton();
            this.label7 = new System.Windows.Forms.Label();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.btn_Confirm = new FontAwesome.Sharp.IconButton();
            this.btn_Cancel = new FontAwesome.Sharp.IconButton();
            this.txt_phone = new ToolsBox.RJControls.HPTextBox();
            this.txt_home = new ToolsBox.RJControls.HPTextBox();
            this.txt_name = new ToolsBox.RJControls.HPTextBox();
            this.date_dob = new ToolsBox.RJControls.HPDateTimePicker();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.cbx_KhoaHoc = new System.Windows.Forms.ComboBox();
            this.cbx_LopHoc = new System.Windows.Forms.ComboBox();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.cbx_LopHoc);
            this.groupBox2.Controls.Add(this.cbx_KhoaHoc);
            this.groupBox2.Controls.Add(this.btn_Add);
            this.groupBox2.Controls.Add(this.btn_Delete);
            this.groupBox2.Controls.Add(this.label7);
            this.groupBox2.Controls.Add(this.dataGridView1);
            this.groupBox2.Controls.Add(this.label6);
            this.groupBox2.Font = new System.Drawing.Font("Segoe UI", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox2.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.groupBox2.Location = new System.Drawing.Point(580, 74);
            this.groupBox2.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Padding = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.groupBox2.Size = new System.Drawing.Size(542, 469);
            this.groupBox2.TabIndex = 7;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Đăng ký khóa học";
            // 
            // btn_Add
            // 
            this.btn_Add.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.btn_Add.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_Add.Flip = FontAwesome.Sharp.FlipOrientation.Normal;
            this.btn_Add.Font = new System.Drawing.Font("Segoe UI Semibold", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Add.IconChar = FontAwesome.Sharp.IconChar.Plus;
            this.btn_Add.IconColor = System.Drawing.Color.White;
            this.btn_Add.IconSize = 16;
            this.btn_Add.Location = new System.Drawing.Point(325, 194);
            this.btn_Add.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btn_Add.Name = "btn_Add";
            this.btn_Add.Rotation = 0D;
            this.btn_Add.Size = new System.Drawing.Size(127, 55);
            this.btn_Add.TabIndex = 18;
            this.btn_Add.Text = "Thêm";
            this.btn_Add.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btn_Add.UseVisualStyleBackColor = true;
            // 
            // btn_Delete
            // 
            this.btn_Delete.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.btn_Delete.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_Delete.Flip = FontAwesome.Sharp.FlipOrientation.Normal;
            this.btn_Delete.Font = new System.Drawing.Font("Segoe UI Semibold", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Delete.IconChar = FontAwesome.Sharp.IconChar.Eraser;
            this.btn_Delete.IconColor = System.Drawing.Color.White;
            this.btn_Delete.IconSize = 16;
            this.btn_Delete.Location = new System.Drawing.Point(105, 194);
            this.btn_Delete.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btn_Delete.Name = "btn_Delete";
            this.btn_Delete.Rotation = 0D;
            this.btn_Delete.Size = new System.Drawing.Size(127, 55);
            this.btn_Delete.TabIndex = 17;
            this.btn_Delete.Text = "Xóa";
            this.btn_Delete.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btn_Delete.UseVisualStyleBackColor = true;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Segoe UI Semibold", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(21, 138);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(121, 25);
            this.label7.TabIndex = 7;
            this.label7.Text = "Chọn lớp học";
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(7, 256);
            this.dataGridView1.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.Size = new System.Drawing.Size(529, 205);
            this.dataGridView1.TabIndex = 4;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Segoe UI Semibold", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(18, 66);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(133, 25);
            this.label6.TabIndex = 2;
            this.label6.Text = "Chọn khóa học";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label5.Location = new System.Drawing.Point(140, 12);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(143, 20);
            this.label5.TabIndex = 6;
            this.label5.Text = "PHIẾU GHI DANH";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.btn_Confirm);
            this.groupBox1.Controls.Add(this.btn_Cancel);
            this.groupBox1.Controls.Add(this.txt_phone);
            this.groupBox1.Controls.Add(this.txt_home);
            this.groupBox1.Controls.Add(this.txt_name);
            this.groupBox1.Controls.Add(this.date_dob);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Font = new System.Drawing.Font("Segoe UI", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.groupBox1.Location = new System.Drawing.Point(8, 74);
            this.groupBox1.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Padding = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.groupBox1.Size = new System.Drawing.Size(544, 469);
            this.groupBox1.TabIndex = 5;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Thông tin học viên";
            // 
            // btn_Confirm
            // 
            this.btn_Confirm.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.btn_Confirm.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_Confirm.Flip = FontAwesome.Sharp.FlipOrientation.Normal;
            this.btn_Confirm.Font = new System.Drawing.Font("Segoe UI Semibold", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Confirm.IconChar = FontAwesome.Sharp.IconChar.Check;
            this.btn_Confirm.IconColor = System.Drawing.Color.White;
            this.btn_Confirm.IconSize = 16;
            this.btn_Confirm.Location = new System.Drawing.Point(328, 392);
            this.btn_Confirm.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btn_Confirm.Name = "btn_Confirm";
            this.btn_Confirm.Rotation = 0D;
            this.btn_Confirm.Size = new System.Drawing.Size(127, 55);
            this.btn_Confirm.TabIndex = 21;
            this.btn_Confirm.Text = "Xác nhận";
            this.btn_Confirm.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btn_Confirm.UseVisualStyleBackColor = true;
            this.btn_Confirm.Click += new System.EventHandler(this.btn_Confirm_Click);
            // 
            // btn_Cancel
            // 
            this.btn_Cancel.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.btn_Cancel.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_Cancel.Flip = FontAwesome.Sharp.FlipOrientation.Normal;
            this.btn_Cancel.Font = new System.Drawing.Font("Segoe UI Semibold", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Cancel.IconChar = FontAwesome.Sharp.IconChar.StickerMule;
            this.btn_Cancel.IconColor = System.Drawing.Color.White;
            this.btn_Cancel.IconSize = 16;
            this.btn_Cancel.Location = new System.Drawing.Point(116, 392);
            this.btn_Cancel.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btn_Cancel.Name = "btn_Cancel";
            this.btn_Cancel.Rotation = 0D;
            this.btn_Cancel.Size = new System.Drawing.Size(127, 55);
            this.btn_Cancel.TabIndex = 19;
            this.btn_Cancel.Text = "Hủy";
            this.btn_Cancel.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btn_Cancel.UseVisualStyleBackColor = true;
            // 
            // txt_phone
            // 
            this.txt_phone.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.txt_phone.BorderColor = System.Drawing.Color.RoyalBlue;
            this.txt_phone.BorderFocusColor = System.Drawing.Color.RoyalBlue;
            this.txt_phone.BorderRadius = 0;
            this.txt_phone.BorderSize = 2;
            this.txt_phone.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_phone.Location = new System.Drawing.Point(173, 281);
            this.txt_phone.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txt_phone.Multiline = false;
            this.txt_phone.Name = "txt_phone";
            this.txt_phone.Padding = new System.Windows.Forms.Padding(8, 9, 8, 9);
            this.txt_phone.PasswordChar = false;
            this.txt_phone.PlaceholderColor = System.Drawing.Color.DarkGray;
            this.txt_phone.PlaceholderText = "";
            this.txt_phone.Size = new System.Drawing.Size(320, 43);
            this.txt_phone.TabIndex = 15;
            this.txt_phone.Texts = "";
            this.txt_phone.UnderlinedStyle = false;
            // 
            // txt_home
            // 
            this.txt_home.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.txt_home.BorderColor = System.Drawing.Color.RoyalBlue;
            this.txt_home.BorderFocusColor = System.Drawing.Color.RoyalBlue;
            this.txt_home.BorderRadius = 0;
            this.txt_home.BorderSize = 2;
            this.txt_home.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_home.Location = new System.Drawing.Point(174, 205);
            this.txt_home.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txt_home.Multiline = false;
            this.txt_home.Name = "txt_home";
            this.txt_home.Padding = new System.Windows.Forms.Padding(8, 9, 8, 9);
            this.txt_home.PasswordChar = false;
            this.txt_home.PlaceholderColor = System.Drawing.Color.DarkGray;
            this.txt_home.PlaceholderText = "";
            this.txt_home.Size = new System.Drawing.Size(320, 43);
            this.txt_home.TabIndex = 14;
            this.txt_home.Texts = "";
            this.txt_home.UnderlinedStyle = false;
            // 
            // txt_name
            // 
            this.txt_name.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.txt_name.BorderColor = System.Drawing.Color.RoyalBlue;
            this.txt_name.BorderFocusColor = System.Drawing.Color.RoyalBlue;
            this.txt_name.BorderRadius = 0;
            this.txt_name.BorderSize = 2;
            this.txt_name.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_name.Location = new System.Drawing.Point(174, 60);
            this.txt_name.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txt_name.Multiline = false;
            this.txt_name.Name = "txt_name";
            this.txt_name.Padding = new System.Windows.Forms.Padding(8, 9, 8, 9);
            this.txt_name.PasswordChar = false;
            this.txt_name.PlaceholderColor = System.Drawing.Color.DarkGray;
            this.txt_name.PlaceholderText = "";
            this.txt_name.Size = new System.Drawing.Size(320, 43);
            this.txt_name.TabIndex = 13;
            this.txt_name.Texts = "";
            this.txt_name.UnderlinedStyle = false;
            // 
            // date_dob
            // 
            this.date_dob.BorderColor = System.Drawing.Color.PaleVioletRed;
            this.date_dob.BorderSize = 0;
            this.date_dob.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.5F);
            this.date_dob.Location = new System.Drawing.Point(173, 126);
            this.date_dob.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.date_dob.MinimumSize = new System.Drawing.Size(4, 35);
            this.date_dob.Name = "date_dob";
            this.date_dob.Size = new System.Drawing.Size(320, 35);
            this.date_dob.SkinColor = System.Drawing.Color.DodgerBlue;
            this.date_dob.TabIndex = 12;
            this.date_dob.TextColor = System.Drawing.Color.White;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Segoe UI Semibold", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(26, 281);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(122, 25);
            this.label4.TabIndex = 7;
            this.label4.Text = "Số điện thoại";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Segoe UI Semibold", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(26, 209);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(67, 25);
            this.label3.TabIndex = 4;
            this.label3.Text = "Địa chỉ";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Segoe UI Semibold", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(26, 138);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(94, 25);
            this.label2.TabIndex = 2;
            this.label2.Text = "Ngày sinh";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI Semibold", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(26, 66);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(92, 25);
            this.label1.TabIndex = 1;
            this.label1.Text = "Họ và tên";
            // 
            // cbx_KhoaHoc
            // 
            this.cbx_KhoaHoc.FormattingEnabled = true;
            this.cbx_KhoaHoc.Location = new System.Drawing.Point(197, 60);
            this.cbx_KhoaHoc.Name = "cbx_KhoaHoc";
            this.cbx_KhoaHoc.Size = new System.Drawing.Size(255, 38);
            this.cbx_KhoaHoc.TabIndex = 19;
            // 
            // cbx_LopHoc
            // 
            this.cbx_LopHoc.FormattingEnabled = true;
            this.cbx_LopHoc.Location = new System.Drawing.Point(197, 131);
            this.cbx_LopHoc.Name = "cbx_LopHoc";
            this.cbx_LopHoc.Size = new System.Drawing.Size(255, 38);
            this.cbx_LopHoc.TabIndex = 20;
            // 
            // fThemHocVien
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.CornflowerBlue;
            this.ClientSize = new System.Drawing.Size(1144, 558);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.groupBox1);
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Name = "fThemHocVien";
            this.Text = "fThemHocVien";
            this.Load += new System.EventHandler(this.fThemHocVien_Load);
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox2;
        private FontAwesome.Sharp.IconButton btn_Add;
        private FontAwesome.Sharp.IconButton btn_Delete;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.GroupBox groupBox1;
        private FontAwesome.Sharp.IconButton btn_Confirm;
        private FontAwesome.Sharp.IconButton btn_Cancel;
        private ToolsBox.RJControls.HPTextBox txt_phone;
        private ToolsBox.RJControls.HPTextBox txt_home;
        private ToolsBox.RJControls.HPTextBox txt_name;
        private ToolsBox.RJControls.HPDateTimePicker date_dob;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox cbx_LopHoc;
        private System.Windows.Forms.ComboBox cbx_KhoaHoc;
    }
}