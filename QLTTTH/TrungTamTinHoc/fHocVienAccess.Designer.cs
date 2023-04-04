
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
            this.btn_HdSudung = new FontAwesome.Sharp.IconButton();
            this.btn_Xemdiem = new FontAwesome.Sharp.IconButton();
            this.btn_DangKiKH = new FontAwesome.Sharp.IconButton();
            this.btn_Xemlichhoc = new FontAwesome.Sharp.IconButton();
            this.btn_KhoaHoc = new FontAwesome.Sharp.IconButton();
            this.btn_Thongtincanhan = new FontAwesome.Sharp.IconButton();
            this.panel1 = new System.Windows.Forms.Panel();
            this.panelDesktop = new System.Windows.Forms.Panel();
            btn_Minimize = new FontAwesome.Sharp.IconButton();
            this.panelTitle.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.iconCurrChildForm)).BeginInit();
            this.panelNav.SuspendLayout();
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
            this.panelTitle.BackColor = System.Drawing.Color.MediumPurple;
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
            this.btn_Dangxuat.Flip = FontAwesome.Sharp.FlipOrientation.Normal;
            this.btn_Dangxuat.IconChar = FontAwesome.Sharp.IconChar.ShareSquare;
            this.btn_Dangxuat.IconColor = System.Drawing.Color.Black;
            this.btn_Dangxuat.IconSize = 25;
            this.btn_Dangxuat.Location = new System.Drawing.Point(645, 23);
            this.btn_Dangxuat.Name = "btn_Dangxuat";
            this.btn_Dangxuat.Rotation = 0D;
            this.btn_Dangxuat.Size = new System.Drawing.Size(50, 50);
            this.btn_Dangxuat.TabIndex = 8;
            this.btn_Dangxuat.UseVisualStyleBackColor = true;
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
            this.iconCurrChildForm.BackColor = System.Drawing.Color.MediumPurple;
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
            this.panelNav.Controls.Add(this.btn_HdSudung);
            this.panelNav.Controls.Add(this.btn_Xemdiem);
            this.panelNav.Controls.Add(this.btn_DangKiKH);
            this.panelNav.Controls.Add(this.btn_Xemlichhoc);
            this.panelNav.Controls.Add(this.btn_KhoaHoc);
            this.panelNav.Controls.Add(this.btn_Thongtincanhan);
            this.panelNav.Controls.Add(this.panel1);
            this.panelNav.Dock = System.Windows.Forms.DockStyle.Left;
            this.panelNav.Location = new System.Drawing.Point(0, 0);
            this.panelNav.Name = "panelNav";
            this.panelNav.Size = new System.Drawing.Size(187, 537);
            this.panelNav.TabIndex = 3;
            // 
            // btn_HdSudung
            // 
            this.btn_HdSudung.Dock = System.Windows.Forms.DockStyle.Top;
            this.btn_HdSudung.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_HdSudung.Flip = FontAwesome.Sharp.FlipOrientation.Normal;
            this.btn_HdSudung.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_HdSudung.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btn_HdSudung.IconChar = FontAwesome.Sharp.IconChar.Info;
            this.btn_HdSudung.IconColor = System.Drawing.Color.White;
            this.btn_HdSudung.IconSize = 20;
            this.btn_HdSudung.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_HdSudung.Location = new System.Drawing.Point(0, 398);
            this.btn_HdSudung.Name = "btn_HdSudung";
            this.btn_HdSudung.Rotation = 0D;
            this.btn_HdSudung.Size = new System.Drawing.Size(187, 50);
            this.btn_HdSudung.TabIndex = 9;
            this.btn_HdSudung.Text = "Hướng dẫn sử dụng";
            this.btn_HdSudung.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btn_HdSudung.UseVisualStyleBackColor = true;
            this.btn_HdSudung.Click += new System.EventHandler(this.btn_HdSudung_Click);
            // 
            // btn_Xemdiem
            // 
            this.btn_Xemdiem.Dock = System.Windows.Forms.DockStyle.Top;
            this.btn_Xemdiem.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_Xemdiem.Flip = FontAwesome.Sharp.FlipOrientation.Normal;
            this.btn_Xemdiem.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Xemdiem.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btn_Xemdiem.IconChar = FontAwesome.Sharp.IconChar.Star;
            this.btn_Xemdiem.IconColor = System.Drawing.Color.White;
            this.btn_Xemdiem.IconSize = 20;
            this.btn_Xemdiem.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_Xemdiem.Location = new System.Drawing.Point(0, 348);
            this.btn_Xemdiem.Name = "btn_Xemdiem";
            this.btn_Xemdiem.Rotation = 0D;
            this.btn_Xemdiem.Size = new System.Drawing.Size(187, 50);
            this.btn_Xemdiem.TabIndex = 8;
            this.btn_Xemdiem.Text = "Xem điểm";
            this.btn_Xemdiem.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btn_Xemdiem.UseVisualStyleBackColor = true;
            this.btn_Xemdiem.Click += new System.EventHandler(this.btn_Xemdiem_Click);
            // 
            // btn_DangKiKH
            // 
            this.btn_DangKiKH.Dock = System.Windows.Forms.DockStyle.Top;
            this.btn_DangKiKH.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_DangKiKH.Flip = FontAwesome.Sharp.FlipOrientation.Normal;
            this.btn_DangKiKH.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_DangKiKH.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btn_DangKiKH.IconChar = FontAwesome.Sharp.IconChar.CalendarCheck;
            this.btn_DangKiKH.IconColor = System.Drawing.Color.White;
            this.btn_DangKiKH.IconSize = 20;
            this.btn_DangKiKH.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_DangKiKH.Location = new System.Drawing.Point(0, 298);
            this.btn_DangKiKH.Name = "btn_DangKiKH";
            this.btn_DangKiKH.Rotation = 0D;
            this.btn_DangKiKH.Size = new System.Drawing.Size(187, 50);
            this.btn_DangKiKH.TabIndex = 7;
            this.btn_DangKiKH.Text = "Đăng ký khóa học";
            this.btn_DangKiKH.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btn_DangKiKH.UseVisualStyleBackColor = true;
            this.btn_DangKiKH.Click += new System.EventHandler(this.btn_DangKiKH_Click);
            // 
            // btn_Xemlichhoc
            // 
            this.btn_Xemlichhoc.Dock = System.Windows.Forms.DockStyle.Top;
            this.btn_Xemlichhoc.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_Xemlichhoc.Flip = FontAwesome.Sharp.FlipOrientation.Normal;
            this.btn_Xemlichhoc.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Xemlichhoc.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btn_Xemlichhoc.IconChar = FontAwesome.Sharp.IconChar.Calendar;
            this.btn_Xemlichhoc.IconColor = System.Drawing.Color.White;
            this.btn_Xemlichhoc.IconSize = 20;
            this.btn_Xemlichhoc.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_Xemlichhoc.Location = new System.Drawing.Point(0, 248);
            this.btn_Xemlichhoc.Name = "btn_Xemlichhoc";
            this.btn_Xemlichhoc.Rotation = 0D;
            this.btn_Xemlichhoc.Size = new System.Drawing.Size(187, 50);
            this.btn_Xemlichhoc.TabIndex = 4;
            this.btn_Xemlichhoc.Text = "Xem lịch học";
            this.btn_Xemlichhoc.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btn_Xemlichhoc.UseVisualStyleBackColor = true;
            this.btn_Xemlichhoc.Click += new System.EventHandler(this.btn_Xemlichhoc_Click);
            // 
            // btn_KhoaHoc
            // 
            this.btn_KhoaHoc.Dock = System.Windows.Forms.DockStyle.Top;
            this.btn_KhoaHoc.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_KhoaHoc.Flip = FontAwesome.Sharp.FlipOrientation.Normal;
            this.btn_KhoaHoc.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_KhoaHoc.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btn_KhoaHoc.IconChar = FontAwesome.Sharp.IconChar.Book;
            this.btn_KhoaHoc.IconColor = System.Drawing.Color.White;
            this.btn_KhoaHoc.IconSize = 20;
            this.btn_KhoaHoc.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_KhoaHoc.Location = new System.Drawing.Point(0, 198);
            this.btn_KhoaHoc.Name = "btn_KhoaHoc";
            this.btn_KhoaHoc.Rotation = 0D;
            this.btn_KhoaHoc.Size = new System.Drawing.Size(187, 50);
            this.btn_KhoaHoc.TabIndex = 2;
            this.btn_KhoaHoc.Text = "Thông tin khóa học";
            this.btn_KhoaHoc.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btn_KhoaHoc.UseVisualStyleBackColor = true;
            this.btn_KhoaHoc.Click += new System.EventHandler(this.btn_KhoaHoc_Click);
            // 
            // btn_Thongtincanhan
            // 
            this.btn_Thongtincanhan.BackColor = System.Drawing.SystemColors.Control;
            this.btn_Thongtincanhan.Dock = System.Windows.Forms.DockStyle.Top;
            this.btn_Thongtincanhan.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_Thongtincanhan.Flip = FontAwesome.Sharp.FlipOrientation.Normal;
            this.btn_Thongtincanhan.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Thongtincanhan.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btn_Thongtincanhan.IconChar = FontAwesome.Sharp.IconChar.User;
            this.btn_Thongtincanhan.IconColor = System.Drawing.Color.White;
            this.btn_Thongtincanhan.IconSize = 20;
            this.btn_Thongtincanhan.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_Thongtincanhan.Location = new System.Drawing.Point(0, 148);
            this.btn_Thongtincanhan.Name = "btn_Thongtincanhan";
            this.btn_Thongtincanhan.Rotation = 0D;
            this.btn_Thongtincanhan.Size = new System.Drawing.Size(187, 50);
            this.btn_Thongtincanhan.TabIndex = 1;
            this.btn_Thongtincanhan.Text = "Thông tin cá nhân";
            this.btn_Thongtincanhan.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btn_Thongtincanhan.UseVisualStyleBackColor = false;
            this.btn_Thongtincanhan.Click += new System.EventHandler(this.btn_Thongtincanhan_Click);
            // 
            // panel1
            // 
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(187, 148);
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
        private FontAwesome.Sharp.IconButton btn_DangKiKH;
        private FontAwesome.Sharp.IconButton btn_Xemlichhoc;
        private FontAwesome.Sharp.IconButton btn_KhoaHoc;
        private FontAwesome.Sharp.IconButton btn_Thongtincanhan;
        private System.Windows.Forms.Panel panel1;
        private FontAwesome.Sharp.IconButton btn_Xemdiem;
        private FontAwesome.Sharp.IconButton btn_HdSudung;
        private System.Windows.Forms.Panel panelDesktop;
    }
}