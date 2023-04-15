using System.Drawing;
namespace TrungTamTinHoc.FormsChildAdmin
{
    partial class fQLGiangVien
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.btn_InGV = new FontAwesome.Sharp.IconButton();
            this.btn_ThemGV = new FontAwesome.Sharp.IconButton();
            this.btn_XoaGV = new FontAwesome.Sharp.IconButton();
            this.panel1 = new System.Windows.Forms.Panel();
            this.btn_Search = new FontAwesome.Sharp.IconButton();
            this.lb_Search = new System.Windows.Forms.Label();
            this.hpTextBox1 = new ToolsBox.RJControls.HPTextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.dgv_GiangVien = new System.Windows.Forms.DataGridView();
            this.groupBox1.SuspendLayout();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_GiangVien)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.AutoSize = true;
            this.groupBox1.BackColor = System.Drawing.Color.RoyalBlue;
            this.groupBox1.Controls.Add(this.btn_Search);
            this.groupBox1.Controls.Add(this.btn_InGV);
            this.groupBox1.Controls.Add(this.lb_Search);
            this.groupBox1.Controls.Add(this.hpTextBox1);
            this.groupBox1.Controls.Add(this.btn_ThemGV);
            this.groupBox1.Controls.Add(this.btn_XoaGV);
            this.groupBox1.Dock = System.Windows.Forms.DockStyle.Top;
            this.groupBox1.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.groupBox1.Location = new System.Drawing.Point(0, 125);
            this.groupBox1.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Padding = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.groupBox1.Size = new System.Drawing.Size(989, 158);
            this.groupBox1.TabIndex = 22;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Chức năng";
            // 
            // btn_InGV
            // 
            this.btn_InGV.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btn_InGV.BackColor = System.Drawing.Color.RoyalBlue;
            this.btn_InGV.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.btn_InGV.FlatAppearance.CheckedBackColor = System.Drawing.Color.White;
            this.btn_InGV.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_InGV.Flip = FontAwesome.Sharp.FlipOrientation.Normal;
            this.btn_InGV.Font = new System.Drawing.Font("Segoe UI Semibold", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_InGV.IconChar = FontAwesome.Sharp.IconChar.Print;
            this.btn_InGV.IconColor = System.Drawing.Color.White;
            this.btn_InGV.IconSize = 16;
            this.btn_InGV.Location = new System.Drawing.Point(837, 61);
            this.btn_InGV.Margin = new System.Windows.Forms.Padding(0);
            this.btn_InGV.Name = "btn_InGV";
            this.btn_InGV.Rotation = 0D;
            this.btn_InGV.Size = new System.Drawing.Size(143, 60);
            this.btn_InGV.TabIndex = 4;
            this.btn_InGV.Text = "In danh sách";
            this.btn_InGV.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btn_InGV.UseVisualStyleBackColor = false;
            // 
            // btn_ThemGV
            // 
            this.btn_ThemGV.BackColor = System.Drawing.Color.RoyalBlue;
            this.btn_ThemGV.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.btn_ThemGV.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_ThemGV.Flip = FontAwesome.Sharp.FlipOrientation.Normal;
            this.btn_ThemGV.Font = new System.Drawing.Font("Segoe UI Semibold", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_ThemGV.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btn_ThemGV.IconChar = FontAwesome.Sharp.IconChar.UserPlus;
            this.btn_ThemGV.IconColor = System.Drawing.Color.White;
            this.btn_ThemGV.IconSize = 16;
            this.btn_ThemGV.Location = new System.Drawing.Point(35, 58);
            this.btn_ThemGV.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btn_ThemGV.Name = "btn_ThemGV";
            this.btn_ThemGV.Rotation = 0D;
            this.btn_ThemGV.Size = new System.Drawing.Size(143, 60);
            this.btn_ThemGV.TabIndex = 0;
            this.btn_ThemGV.Text = "Thêm giảng viên";
            this.btn_ThemGV.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btn_ThemGV.UseVisualStyleBackColor = false;
            this.btn_ThemGV.Click += new System.EventHandler(this.btn_ThemGV_Click);
            // 
            // btn_XoaGV
            // 
            this.btn_XoaGV.BackColor = System.Drawing.Color.RoyalBlue;
            this.btn_XoaGV.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.btn_XoaGV.FlatAppearance.CheckedBackColor = System.Drawing.Color.White;
            this.btn_XoaGV.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_XoaGV.Flip = FontAwesome.Sharp.FlipOrientation.Normal;
            this.btn_XoaGV.Font = new System.Drawing.Font("Segoe UI Semibold", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_XoaGV.IconChar = FontAwesome.Sharp.IconChar.Eraser;
            this.btn_XoaGV.IconColor = System.Drawing.Color.White;
            this.btn_XoaGV.IconSize = 16;
            this.btn_XoaGV.Location = new System.Drawing.Point(238, 58);
            this.btn_XoaGV.Margin = new System.Windows.Forms.Padding(0);
            this.btn_XoaGV.Name = "btn_XoaGV";
            this.btn_XoaGV.Rotation = 0D;
            this.btn_XoaGV.Size = new System.Drawing.Size(143, 60);
            this.btn_XoaGV.TabIndex = 1;
            this.btn_XoaGV.Text = "Xóa giảng viên";
            this.btn_XoaGV.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btn_XoaGV.UseVisualStyleBackColor = false;
            this.btn_XoaGV.Click += new System.EventHandler(this.btn_XoaGV_Click);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.RoyalBlue;
            this.panel1.Controls.Add(this.label2);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(989, 125);
            this.panel1.TabIndex = 23;
            // 
            // btn_Search
            // 
            this.btn_Search.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)));
            this.btn_Search.FlatAppearance.BorderSize = 0;
            this.btn_Search.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_Search.Flip = FontAwesome.Sharp.FlipOrientation.Normal;
            this.btn_Search.IconChar = FontAwesome.Sharp.IconChar.Search;
            this.btn_Search.IconColor = System.Drawing.Color.White;
            this.btn_Search.IconSize = 27;
            this.btn_Search.Location = new System.Drawing.Point(767, 61);
            this.btn_Search.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btn_Search.Name = "btn_Search";
            this.btn_Search.Rotation = 0D;
            this.btn_Search.Size = new System.Drawing.Size(45, 60);
            this.btn_Search.TabIndex = 4;
            this.btn_Search.UseVisualStyleBackColor = true;
            // 
            // lb_Search
            // 
            this.lb_Search.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lb_Search.AutoSize = true;
            this.lb_Search.Font = new System.Drawing.Font("Segoe UI Semibold", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lb_Search.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.lb_Search.Location = new System.Drawing.Point(396, 68);
            this.lb_Search.Name = "lb_Search";
            this.lb_Search.Size = new System.Drawing.Size(97, 28);
            this.lb_Search.TabIndex = 3;
            this.lb_Search.Text = "Tìm kiếm";
            // 
            // hpTextBox1
            // 
            this.hpTextBox1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.hpTextBox1.BorderColor = System.Drawing.Color.DodgerBlue;
            this.hpTextBox1.BorderFocusColor = System.Drawing.Color.HotPink;
            this.hpTextBox1.BorderRadius = 0;
            this.hpTextBox1.BorderSize = 2;
            this.hpTextBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.hpTextBox1.Location = new System.Drawing.Point(500, 61);
            this.hpTextBox1.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.hpTextBox1.Multiline = false;
            this.hpTextBox1.Name = "hpTextBox1";
            this.hpTextBox1.Padding = new System.Windows.Forms.Padding(8, 9, 8, 9);
            this.hpTextBox1.PasswordChar = false;
            this.hpTextBox1.PlaceholderColor = System.Drawing.Color.DarkGray;
            this.hpTextBox1.PlaceholderText = "";
            this.hpTextBox1.Size = new System.Drawing.Size(260, 43);
            this.hpTextBox1.TabIndex = 2;
            this.hpTextBox1.Texts = "";
            this.hpTextBox1.UnderlinedStyle = true;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Segoe UI", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label2.Location = new System.Drawing.Point(28, 36);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(379, 41);
            this.label2.TabIndex = 0;
            this.label2.Text = "DANH SÁCH GIẢNG VIÊN";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // dgv_GiangVien
            // 
            this.dgv_GiangVien.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgv_GiangVien.BackgroundColor = System.Drawing.SystemColors.ActiveCaption;
            this.dgv_GiangVien.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dgv_GiangVien.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal;
            this.dgv_GiangVien.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.HotTrack;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgv_GiangVien.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.dgv_GiangVien.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv_GiangVien.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgv_GiangVien.EnableHeadersVisualStyles = false;
            this.dgv_GiangVien.GridColor = System.Drawing.Color.CornflowerBlue;
            this.dgv_GiangVien.Location = new System.Drawing.Point(0, 283);
            this.dgv_GiangVien.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.dgv_GiangVien.Name = "dgv_GiangVien";
            this.dgv_GiangVien.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.SteelBlue;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgv_GiangVien.RowHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.dgv_GiangVien.RowHeadersVisible = false;
            this.dgv_GiangVien.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.AutoSizeToAllHeaders;
            dataGridViewCellStyle3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Segoe UI", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.SteelBlue;
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.Color.White;
            this.dgv_GiangVien.RowsDefaultCellStyle = dataGridViewCellStyle3;
            this.dgv_GiangVien.RowTemplate.Height = 24;
            this.dgv_GiangVien.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgv_GiangVien.Size = new System.Drawing.Size(989, 401);
            this.dgv_GiangVien.TabIndex = 24;
            this.dgv_GiangVien.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgv_GiangVien_CellClick);
            this.dgv_GiangVien.CellEndEdit += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgv_GiangVien_CellEndEdit);
            // 
            // fQLGiangVien
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(989, 684);
            this.Controls.Add(this.dgv_GiangVien);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.panel1);
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Name = "fQLGiangVien";
            this.Text = "fQLGiangVien";
            this.Load += new System.EventHandler(this.fQLGiangVien_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_GiangVien)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.GroupBox groupBox1;
        private FontAwesome.Sharp.IconButton btn_InGV;
        private FontAwesome.Sharp.IconButton btn_XoaGV;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label2;
        private FontAwesome.Sharp.IconButton btn_ThemGV;
        private System.Windows.Forms.DataGridView dgv_GiangVien;
        private System.Windows.Forms.Label lb_Search;
        private FontAwesome.Sharp.IconButton btn_Search;
        private ToolsBox.RJControls.HPTextBox hpTextBox1;
    }
}