
namespace TrungTamTinHoc.FormsChildAdmin
{
    partial class fQLLopHoc
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
            this.dgv_LopHoc = new System.Windows.Forms.DataGridView();
            this.panel1 = new System.Windows.Forms.Panel();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.btn_Loc = new FontAwesome.Sharp.IconButton();
            this.label1 = new System.Windows.Forms.Label();
            this.cbx_KhoaHoc = new System.Windows.Forms.ComboBox();
            this.btn_Timkiem = new FontAwesome.Sharp.IconButton();
            this.btn_XoaHV = new FontAwesome.Sharp.IconButton();
            this.btn_ThemLopHoc = new FontAwesome.Sharp.IconButton();
            this.txt_Timkiem = new ToolsBox.RJControls.HPTextBox();
            this.lb_Search = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_LopHoc)).BeginInit();
            this.panel1.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // dgv_LopHoc
            // 
            this.dgv_LopHoc.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgv_LopHoc.BackgroundColor = System.Drawing.SystemColors.ActiveCaption;
            this.dgv_LopHoc.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dgv_LopHoc.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal;
            this.dgv_LopHoc.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.HotTrack;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgv_LopHoc.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.dgv_LopHoc.ColumnHeadersHeight = 30;
            this.dgv_LopHoc.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            this.dgv_LopHoc.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgv_LopHoc.EnableHeadersVisualStyles = false;
            this.dgv_LopHoc.GridColor = System.Drawing.Color.SteelBlue;
            this.dgv_LopHoc.Location = new System.Drawing.Point(0, 190);
            this.dgv_LopHoc.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.dgv_LopHoc.Name = "dgv_LopHoc";
            this.dgv_LopHoc.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.SteelBlue;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgv_LopHoc.RowHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.dgv_LopHoc.RowHeadersVisible = false;
            this.dgv_LopHoc.RowHeadersWidth = 51;
            dataGridViewCellStyle3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Segoe UI", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.SteelBlue;
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.Color.White;
            this.dgv_LopHoc.RowsDefaultCellStyle = dataGridViewCellStyle3;
            this.dgv_LopHoc.RowTemplate.Height = 24;
            this.dgv_LopHoc.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgv_LopHoc.Size = new System.Drawing.Size(731, 302);
            this.dgv_LopHoc.TabIndex = 38;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.RoyalBlue;
            this.panel1.Controls.Add(this.groupBox1);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(731, 190);
            this.panel1.TabIndex = 37;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.btn_Loc);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.cbx_KhoaHoc);
            this.groupBox1.Controls.Add(this.btn_Timkiem);
            this.groupBox1.Controls.Add(this.btn_XoaHV);
            this.groupBox1.Controls.Add(this.btn_ThemLopHoc);
            this.groupBox1.Controls.Add(this.txt_Timkiem);
            this.groupBox1.Controls.Add(this.lb_Search);
            this.groupBox1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.groupBox1.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.groupBox1.Location = new System.Drawing.Point(0, 76);
            this.groupBox1.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Padding = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.groupBox1.Size = new System.Drawing.Size(731, 114);
            this.groupBox1.TabIndex = 5;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Chức năng";
            // 
            // btn_Loc
            // 
            this.btn_Loc.FlatAppearance.BorderSize = 0;
            this.btn_Loc.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_Loc.Flip = FontAwesome.Sharp.FlipOrientation.Normal;
            this.btn_Loc.IconChar = FontAwesome.Sharp.IconChar.Filter;
            this.btn_Loc.IconColor = System.Drawing.Color.White;
            this.btn_Loc.IconSize = 27;
            this.btn_Loc.Location = new System.Drawing.Point(623, 23);
            this.btn_Loc.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.btn_Loc.Name = "btn_Loc";
            this.btn_Loc.Rotation = 0D;
            this.btn_Loc.Size = new System.Drawing.Size(31, 30);
            this.btn_Loc.TabIndex = 9;
            this.btn_Loc.UseVisualStyleBackColor = true;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label1.Location = new System.Drawing.Point(323, 32);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(80, 13);
            this.label1.TabIndex = 8;
            this.label1.Text = "Chọn khóa học";
            // 
            // cbx_KhoaHoc
            // 
            this.cbx_KhoaHoc.FormattingEnabled = true;
            this.cbx_KhoaHoc.Location = new System.Drawing.Point(405, 29);
            this.cbx_KhoaHoc.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.cbx_KhoaHoc.Name = "cbx_KhoaHoc";
            this.cbx_KhoaHoc.Size = new System.Drawing.Size(197, 21);
            this.cbx_KhoaHoc.TabIndex = 7;
            // 
            // btn_Timkiem
            // 
            this.btn_Timkiem.FlatAppearance.BorderSize = 0;
            this.btn_Timkiem.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_Timkiem.Flip = FontAwesome.Sharp.FlipOrientation.Normal;
            this.btn_Timkiem.IconChar = FontAwesome.Sharp.IconChar.Search;
            this.btn_Timkiem.IconColor = System.Drawing.Color.White;
            this.btn_Timkiem.IconSize = 27;
            this.btn_Timkiem.Location = new System.Drawing.Point(623, 72);
            this.btn_Timkiem.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.btn_Timkiem.Name = "btn_Timkiem";
            this.btn_Timkiem.Rotation = 0D;
            this.btn_Timkiem.Size = new System.Drawing.Size(30, 30);
            this.btn_Timkiem.TabIndex = 4;
            this.btn_Timkiem.UseVisualStyleBackColor = true;
            // 
            // btn_XoaHV
            // 
            this.btn_XoaHV.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_XoaHV.Flip = FontAwesome.Sharp.FlipOrientation.Normal;
            this.btn_XoaHV.Font = new System.Drawing.Font("Segoe UI Semibold", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_XoaHV.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btn_XoaHV.IconChar = FontAwesome.Sharp.IconChar.Eraser;
            this.btn_XoaHV.IconColor = System.Drawing.Color.White;
            this.btn_XoaHV.IconSize = 16;
            this.btn_XoaHV.Location = new System.Drawing.Point(172, 45);
            this.btn_XoaHV.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.btn_XoaHV.Name = "btn_XoaHV";
            this.btn_XoaHV.Rotation = 0D;
            this.btn_XoaHV.Size = new System.Drawing.Size(105, 39);
            this.btn_XoaHV.TabIndex = 6;
            this.btn_XoaHV.Text = "Xóa lớp học";
            this.btn_XoaHV.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btn_XoaHV.UseVisualStyleBackColor = true;
            // 
            // btn_ThemLopHoc
            // 
            this.btn_ThemLopHoc.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_ThemLopHoc.Flip = FontAwesome.Sharp.FlipOrientation.Normal;
            this.btn_ThemLopHoc.Font = new System.Drawing.Font("Segoe UI Semibold", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_ThemLopHoc.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btn_ThemLopHoc.IconChar = FontAwesome.Sharp.IconChar.UserPlus;
            this.btn_ThemLopHoc.IconColor = System.Drawing.Color.White;
            this.btn_ThemLopHoc.IconSize = 16;
            this.btn_ThemLopHoc.Location = new System.Drawing.Point(41, 45);
            this.btn_ThemLopHoc.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.btn_ThemLopHoc.Name = "btn_ThemLopHoc";
            this.btn_ThemLopHoc.Rotation = 0D;
            this.btn_ThemLopHoc.Size = new System.Drawing.Size(105, 39);
            this.btn_ThemLopHoc.TabIndex = 5;
            this.btn_ThemLopHoc.Text = "Thêm lớp học";
            this.btn_ThemLopHoc.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btn_ThemLopHoc.UseVisualStyleBackColor = true;
            this.btn_ThemLopHoc.Click += new System.EventHandler(this.btn_ThemLopHoc_Click);
            // 
            // txt_Timkiem
            // 
            this.txt_Timkiem.BorderColor = System.Drawing.Color.DodgerBlue;
            this.txt_Timkiem.BorderFocusColor = System.Drawing.Color.HotPink;
            this.txt_Timkiem.BorderRadius = 0;
            this.txt_Timkiem.BorderSize = 2;
            this.txt_Timkiem.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_Timkiem.Location = new System.Drawing.Point(398, 70);
            this.txt_Timkiem.Multiline = false;
            this.txt_Timkiem.Name = "txt_Timkiem";
            this.txt_Timkiem.Padding = new System.Windows.Forms.Padding(5, 6, 5, 6);
            this.txt_Timkiem.PasswordChar = false;
            this.txt_Timkiem.PlaceholderColor = System.Drawing.Color.DarkGray;
            this.txt_Timkiem.PlaceholderText = "";
            this.txt_Timkiem.Size = new System.Drawing.Size(211, 31);
            this.txt_Timkiem.TabIndex = 2;
            this.txt_Timkiem.Texts = "";
            this.txt_Timkiem.UnderlinedStyle = true;
            // 
            // lb_Search
            // 
            this.lb_Search.AutoSize = true;
            this.lb_Search.Font = new System.Drawing.Font("Segoe UI Semibold", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lb_Search.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.lb_Search.Location = new System.Drawing.Point(322, 77);
            this.lb_Search.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lb_Search.Name = "lb_Search";
            this.lb_Search.Size = new System.Drawing.Size(67, 19);
            this.lb_Search.TabIndex = 3;
            this.lb_Search.Text = "Tìm kiếm";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Segoe UI", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label2.Location = new System.Drawing.Point(235, 25);
            this.label2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(222, 28);
            this.label2.TabIndex = 0;
            this.label2.Text = "DANH SÁCH LỚP HỌC";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // fQLLopHoc
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(731, 492);
            this.Controls.Add(this.dgv_LopHoc);
            this.Controls.Add(this.panel1);
            this.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.Name = "fQLLopHoc";
            this.Text = "fLopHoc";
            this.Load += new System.EventHandler(this.fQLLopHoc_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgv_LopHoc)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dgv_LopHoc;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.GroupBox groupBox1;
        private FontAwesome.Sharp.IconButton btn_Loc;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox cbx_KhoaHoc;
        private FontAwesome.Sharp.IconButton btn_Timkiem;
        private FontAwesome.Sharp.IconButton btn_XoaHV;
        private FontAwesome.Sharp.IconButton btn_ThemLopHoc;
        private ToolsBox.RJControls.HPTextBox txt_Timkiem;
        private System.Windows.Forms.Label lb_Search;
        private System.Windows.Forms.Label label2;
    }
}