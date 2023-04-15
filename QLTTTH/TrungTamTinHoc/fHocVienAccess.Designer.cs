
namespace TrungTamTinHoc
{
    partial class fHocVienAccess
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
            FontAwesome.Sharp.IconButton btn_Minimize;
            this.panelTitle = new System.Windows.Forms.Panel();
            this.btn_Dangxuat = new FontAwesome.Sharp.IconButton();
            this.btn_Maximize = new FontAwesome.Sharp.IconButton();
            this.lbTitle = new System.Windows.Forms.Label();
            this.btn_Exit = new FontAwesome.Sharp.IconButton();
            this.iconCurrChildForm = new FontAwesome.Sharp.IconPictureBox();
            this.panelNav = new System.Windows.Forms.Panel();
            this.btn_Instruction = new FontAwesome.Sharp.IconButton();
            this.btn_Result = new FontAwesome.Sharp.IconButton();
            this.btn_RegistCourse = new FontAwesome.Sharp.IconButton();
            this.btn_TimeTable = new FontAwesome.Sharp.IconButton();
            this.btn_Information = new FontAwesome.Sharp.IconButton();
            this.btn_Home = new FontAwesome.Sharp.IconButton();
            this.panel1 = new System.Windows.Forms.Panel();
            this.panelDesktop = new System.Windows.Forms.Panel();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            btn_Minimize = new FontAwesome.Sharp.IconButton();
            this.panelTitle.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.iconCurrChildForm)).BeginInit();
            this.panelNav.SuspendLayout();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // btn_Minimize
            // 
            btn_Minimize.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            btn_Minimize.FlatAppearance.BorderSize = 0;
            btn_Minimize.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            btn_Minimize.Flip = FontAwesome.Sharp.FlipOrientation.Normal;
            btn_Minimize.IconChar = FontAwesome.Sharp.IconChar.MinusSquare;
            btn_Minimize.IconColor = System.Drawing.Color.White;
            btn_Minimize.IconSize = 16;
            btn_Minimize.Location = new System.Drawing.Point(623, 0);
            btn_Minimize.Margin = new System.Windows.Forms.Padding(0);
            btn_Minimize.Name = "btn_Minimize";
            btn_Minimize.Rotation = 0D;
            btn_Minimize.Size = new System.Drawing.Size(24, 23);
            btn_Minimize.TabIndex = 7;
            btn_Minimize.UseVisualStyleBackColor = true;
            // 
            // panelTitle
            // 
            this.panelTitle.BackColor = System.Drawing.Color.RoyalBlue;
            this.panelTitle.Controls.Add(this.btn_Dangxuat);
            this.panelTitle.Controls.Add(this.btn_Maximize);
            this.panelTitle.Controls.Add(btn_Minimize);
            this.panelTitle.Controls.Add(this.lbTitle);
            this.panelTitle.Controls.Add(this.btn_Exit);
            this.panelTitle.Controls.Add(this.iconCurrChildForm);
            this.panelTitle.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelTitle.ForeColor = System.Drawing.Color.White;
            this.panelTitle.Location = new System.Drawing.Point(187, 0);
            this.panelTitle.Name = "panelTitle";
            this.panelTitle.Size = new System.Drawing.Size(695, 73);
            this.panelTitle.TabIndex = 4;
            // 
            // btn_Dangxuat
            // 
            this.btn_Dangxuat.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btn_Dangxuat.BackColor = System.Drawing.Color.CornflowerBlue;
            this.btn_Dangxuat.FlatAppearance.BorderSize = 0;
            this.btn_Dangxuat.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_Dangxuat.Flip = FontAwesome.Sharp.FlipOrientation.Normal;
            this.btn_Dangxuat.IconChar = FontAwesome.Sharp.IconChar.ShareSquare;
            this.btn_Dangxuat.IconColor = System.Drawing.Color.White;
            this.btn_Dangxuat.IconSize = 25;
            this.btn_Dangxuat.Location = new System.Drawing.Point(645, 23);
            this.btn_Dangxuat.Name = "btn_Dangxuat";
            this.btn_Dangxuat.Rotation = 0D;
            this.btn_Dangxuat.Size = new System.Drawing.Size(50, 50);
            this.btn_Dangxuat.TabIndex = 8;
            this.btn_Dangxuat.UseVisualStyleBackColor = false;
            this.btn_Dangxuat.Click += new System.EventHandler(this.btn_Dangxuat_Click);
            // 
            // btn_Maximize
            // 
            this.btn_Maximize.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btn_Maximize.FlatAppearance.BorderSize = 0;
            this.btn_Maximize.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_Maximize.Flip = FontAwesome.Sharp.FlipOrientation.Normal;
            this.btn_Maximize.IconChar = FontAwesome.Sharp.IconChar.Expand;
            this.btn_Maximize.IconColor = System.Drawing.Color.White;
            this.btn_Maximize.IconSize = 16;
            this.btn_Maximize.Location = new System.Drawing.Point(647, 0);
            this.btn_Maximize.Margin = new System.Windows.Forms.Padding(0);
            this.btn_Maximize.Name = "btn_Maximize";
            this.btn_Maximize.Rotation = 0D;
            this.btn_Maximize.Size = new System.Drawing.Size(24, 23);
            this.btn_Maximize.TabIndex = 6;
            this.btn_Maximize.UseVisualStyleBackColor = true;
            // 
            // lbTitle
            // 
            this.lbTitle.AutoSize = true;
            this.lbTitle.Font = new System.Drawing.Font("Segoe UI", 13F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbTitle.Location = new System.Drawing.Point(53, 25);
            this.lbTitle.Name = "lbTitle";
            this.lbTitle.Size = new System.Drawing.Size(115, 30);
            this.lbTitle.TabIndex = 4;
            this.lbTitle.Text = "Trang chủ";
            this.lbTitle.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // btn_Exit
            // 
            this.btn_Exit.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btn_Exit.FlatAppearance.BorderSize = 0;
            this.btn_Exit.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_Exit.Flip = FontAwesome.Sharp.FlipOrientation.Normal;
            this.btn_Exit.IconChar = FontAwesome.Sharp.IconChar.Times;
            this.btn_Exit.IconColor = System.Drawing.Color.White;
            this.btn_Exit.IconSize = 16;
            this.btn_Exit.Location = new System.Drawing.Point(671, 0);
            this.btn_Exit.Margin = new System.Windows.Forms.Padding(0);
            this.btn_Exit.Name = "btn_Exit";
            this.btn_Exit.Rotation = 0D;
            this.btn_Exit.Size = new System.Drawing.Size(24, 23);
            this.btn_Exit.TabIndex = 5;
            this.btn_Exit.UseVisualStyleBackColor = true;
            // 
            // iconCurrChildForm
            // 
            this.iconCurrChildForm.BackColor = System.Drawing.Color.RoyalBlue;
            this.iconCurrChildForm.IconChar = FontAwesome.Sharp.IconChar.Home;
            this.iconCurrChildForm.IconColor = System.Drawing.Color.White;
            this.iconCurrChildForm.Location = new System.Drawing.Point(15, 25);
            this.iconCurrChildForm.Name = "iconCurrChildForm";
            this.iconCurrChildForm.Size = new System.Drawing.Size(32, 32);
            this.iconCurrChildForm.TabIndex = 3;
            this.iconCurrChildForm.TabStop = false;
            // 
            // panelNav
            // 
            this.panelNav.BackColor = System.Drawing.Color.RoyalBlue;
            this.panelNav.Controls.Add(this.btn_Instruction);
            this.panelNav.Controls.Add(this.btn_Result);
            this.panelNav.Controls.Add(this.btn_RegistCourse);
            this.panelNav.Controls.Add(this.btn_TimeTable);
            this.panelNav.Controls.Add(this.btn_Information);
            this.panelNav.Controls.Add(this.btn_Home);
            this.panelNav.Controls.Add(this.panel1);
            this.panelNav.Dock = System.Windows.Forms.DockStyle.Left;
            this.panelNav.Location = new System.Drawing.Point(0, 0);
            this.panelNav.Name = "panelNav";
            this.panelNav.Size = new System.Drawing.Size(187, 537);
            this.panelNav.TabIndex = 3;
            // 
            // btn_Instruction
            // 
            this.btn_Instruction.BackColor = System.Drawing.Color.RoyalBlue;
            this.btn_Instruction.Dock = System.Windows.Forms.DockStyle.Top;
            this.btn_Instruction.FlatAppearance.BorderSize = 0;
            this.btn_Instruction.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_Instruction.Flip = FontAwesome.Sharp.FlipOrientation.Normal;
            this.btn_Instruction.Font = new System.Drawing.Font("Segoe UI Semibold", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Instruction.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btn_Instruction.IconChar = FontAwesome.Sharp.IconChar.Info;
            this.btn_Instruction.IconColor = System.Drawing.Color.White;
            this.btn_Instruction.IconSize = 20;
            this.btn_Instruction.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_Instruction.Location = new System.Drawing.Point(0, 410);
            this.btn_Instruction.Name = "btn_Instruction";
            this.btn_Instruction.Rotation = 0D;
            this.btn_Instruction.Size = new System.Drawing.Size(187, 50);
            this.btn_Instruction.TabIndex = 9;
            this.btn_Instruction.Text = "Hướng dẫn sử dụng";
            this.btn_Instruction.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btn_Instruction.UseVisualStyleBackColor = true;
            this.btn_Instruction.Click += new System.EventHandler(this.btn_HdSudung_Click);
            // 
            // btn_Result
            // 
            this.btn_Result.BackColor = System.Drawing.Color.RoyalBlue;
            this.btn_Result.Dock = System.Windows.Forms.DockStyle.Top;
            this.btn_Result.FlatAppearance.BorderSize = 0;
            this.btn_Result.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_Result.Flip = FontAwesome.Sharp.FlipOrientation.Normal;
            this.btn_Result.Font = new System.Drawing.Font("Segoe UI Semibold", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Result.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btn_Result.IconChar = FontAwesome.Sharp.IconChar.Star;
            this.btn_Result.IconColor = System.Drawing.Color.White;
            this.btn_Result.IconSize = 20;
            this.btn_Result.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_Result.Location = new System.Drawing.Point(0, 360);
            this.btn_Result.Name = "btn_Result";
            this.btn_Result.Rotation = 0D;
            this.btn_Result.Size = new System.Drawing.Size(187, 50);
            this.btn_Result.TabIndex = 8;
            this.btn_Result.Text = "Xem điểm";
            this.btn_Result.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btn_Result.UseVisualStyleBackColor = true;
            this.btn_Result.Click += new System.EventHandler(this.btn_Xemdiem_Click);
            // 
            // btn_RegistCourse
            // 
            this.btn_RegistCourse.BackColor = System.Drawing.Color.RoyalBlue;
            this.btn_RegistCourse.Dock = System.Windows.Forms.DockStyle.Top;
            this.btn_RegistCourse.FlatAppearance.BorderSize = 0;
            this.btn_RegistCourse.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_RegistCourse.Flip = FontAwesome.Sharp.FlipOrientation.Normal;
            this.btn_RegistCourse.Font = new System.Drawing.Font("Segoe UI Semibold", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_RegistCourse.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btn_RegistCourse.IconChar = FontAwesome.Sharp.IconChar.CalendarCheck;
            this.btn_RegistCourse.IconColor = System.Drawing.Color.White;
            this.btn_RegistCourse.IconSize = 20;
            this.btn_RegistCourse.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_RegistCourse.Location = new System.Drawing.Point(0, 310);
            this.btn_RegistCourse.Name = "btn_RegistCourse";
            this.btn_RegistCourse.Rotation = 0D;
            this.btn_RegistCourse.Size = new System.Drawing.Size(187, 50);
            this.btn_RegistCourse.TabIndex = 7;
            this.btn_RegistCourse.Text = "Đăng ký khóa học";
            this.btn_RegistCourse.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btn_RegistCourse.UseVisualStyleBackColor = true;
            this.btn_RegistCourse.Click += new System.EventHandler(this.btn_DangKiKH_Click);
            // 
            // btn_TimeTable
            // 
            this.btn_TimeTable.BackColor = System.Drawing.Color.RoyalBlue;
            this.btn_TimeTable.Dock = System.Windows.Forms.DockStyle.Top;
            this.btn_TimeTable.FlatAppearance.BorderSize = 0;
            this.btn_TimeTable.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_TimeTable.Flip = FontAwesome.Sharp.FlipOrientation.Normal;
            this.btn_TimeTable.Font = new System.Drawing.Font("Segoe UI Semibold", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_TimeTable.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btn_TimeTable.IconChar = FontAwesome.Sharp.IconChar.Calendar;
            this.btn_TimeTable.IconColor = System.Drawing.Color.White;
            this.btn_TimeTable.IconSize = 20;
            this.btn_TimeTable.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_TimeTable.Location = new System.Drawing.Point(0, 260);
            this.btn_TimeTable.Name = "btn_TimeTable";
            this.btn_TimeTable.Rotation = 0D;
            this.btn_TimeTable.Size = new System.Drawing.Size(187, 50);
            this.btn_TimeTable.TabIndex = 4;
            this.btn_TimeTable.Text = "Thời khóa biểu";
            this.btn_TimeTable.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btn_TimeTable.UseVisualStyleBackColor = true;
            this.btn_TimeTable.Click += new System.EventHandler(this.btn_Xemlichhoc_Click);
            // 
            // btn_Information
            // 
            this.btn_Information.BackColor = System.Drawing.Color.RoyalBlue;
            this.btn_Information.Dock = System.Windows.Forms.DockStyle.Top;
            this.btn_Information.FlatAppearance.BorderSize = 0;
            this.btn_Information.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_Information.Flip = FontAwesome.Sharp.FlipOrientation.Normal;
            this.btn_Information.Font = new System.Drawing.Font("Segoe UI Semibold", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Information.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btn_Information.IconChar = FontAwesome.Sharp.IconChar.User;
            this.btn_Information.IconColor = System.Drawing.Color.White;
            this.btn_Information.IconSize = 20;
            this.btn_Information.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_Information.Location = new System.Drawing.Point(0, 210);
            this.btn_Information.Name = "btn_Information";
            this.btn_Information.Rotation = 0D;
            this.btn_Information.Size = new System.Drawing.Size(187, 50);
            this.btn_Information.TabIndex = 2;
            this.btn_Information.Text = "Thông tin cá nhân";
            this.btn_Information.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btn_Information.UseVisualStyleBackColor = true;
            this.btn_Information.Click += new System.EventHandler(this.btn_KhoaHoc_Click);
            // 
            // btn_Home
            // 
            this.btn_Home.BackColor = System.Drawing.Color.RoyalBlue;
            this.btn_Home.Dock = System.Windows.Forms.DockStyle.Top;
            this.btn_Home.FlatAppearance.BorderSize = 0;
            this.btn_Home.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_Home.Flip = FontAwesome.Sharp.FlipOrientation.Normal;
            this.btn_Home.Font = new System.Drawing.Font("Segoe UI Semibold", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Home.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btn_Home.IconChar = FontAwesome.Sharp.IconChar.Home;
            this.btn_Home.IconColor = System.Drawing.Color.White;
            this.btn_Home.IconSize = 20;
            this.btn_Home.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_Home.Location = new System.Drawing.Point(0, 160);
            this.btn_Home.Name = "btn_Home";
            this.btn_Home.Rotation = 0D;
            this.btn_Home.Size = new System.Drawing.Size(187, 50);
            this.btn_Home.TabIndex = 1;
            this.btn_Home.Text = "Trang chủ";
            this.btn_Home.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btn_Home.UseVisualStyleBackColor = true;
            this.btn_Home.Click += new System.EventHandler(this.btn_Thongtincanhan_Click);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.RoyalBlue;
            this.panel1.Controls.Add(this.pictureBox1);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(187, 160);
            this.panel1.TabIndex = 0;
            // 
            // panelDesktop
            // 
            this.panelDesktop.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelDesktop.Location = new System.Drawing.Point(187, 73);
            this.panelDesktop.Name = "panelDesktop";
            this.panelDesktop.Size = new System.Drawing.Size(695, 464);
            this.panelDesktop.TabIndex = 5;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::TrungTamTinHoc.Properties.Resources.TTTH_logo;
            this.pictureBox1.Location = new System.Drawing.Point(0, 0);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(187, 170);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // fHocVienAccess
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(882, 537);
            this.Controls.Add(this.panelDesktop);
            this.Controls.Add(this.panelTitle);
            this.Controls.Add(this.panelNav);
            this.Name = "fHocVienAccess";
            this.Text = "fHocVienAccess";
            this.panelTitle.ResumeLayout(false);
            this.panelTitle.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.iconCurrChildForm)).EndInit();
            this.panelNav.ResumeLayout(false);
            this.panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panelTitle;
        private FontAwesome.Sharp.IconButton btn_Dangxuat;
        private FontAwesome.Sharp.IconButton btn_Maximize;
        private System.Windows.Forms.Label lbTitle;
        private FontAwesome.Sharp.IconButton btn_Exit;
        private FontAwesome.Sharp.IconPictureBox iconCurrChildForm;
        private System.Windows.Forms.Panel panelNav;
        private FontAwesome.Sharp.IconButton btn_RegistCourse;
        private FontAwesome.Sharp.IconButton btn_TimeTable;
        private FontAwesome.Sharp.IconButton btn_Home;
        private System.Windows.Forms.Panel panel1;
        private FontAwesome.Sharp.IconButton btn_Result;
        private FontAwesome.Sharp.IconButton btn_Instruction;
        private System.Windows.Forms.Panel panelDesktop;
        private FontAwesome.Sharp.IconButton btn_Information;
        private System.Windows.Forms.PictureBox pictureBox1;
    }
}