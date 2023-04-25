
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
            this.txt_Timkiem = new ToolsBox.RJControls.HPTextBox();
            this.lb_Search = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.btn_Timkiem = new FontAwesome.Sharp.IconButton();
            this.btn_XoaHV = new FontAwesome.Sharp.IconButton();
            this.btn_ThemLopHoc = new FontAwesome.Sharp.IconButton();
            this.btn_ThemHV = new FontAwesome.Sharp.IconButton();
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
            this.dgv_LopHoc.Location = new System.Drawing.Point(0, 292);
            this.dgv_LopHoc.Margin = new System.Windows.Forms.Padding(3, 5, 3, 5);
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
            this.dgv_LopHoc.Size = new System.Drawing.Size(1097, 466);
            this.dgv_LopHoc.TabIndex = 38;
            this.dgv_LopHoc.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgv_LopHoc_CellClick);
            this.dgv_LopHoc.CellEndEdit += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgv_LopHoc_CellEndEdit);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.RoyalBlue;
            this.panel1.Controls.Add(this.groupBox1);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Margin = new System.Windows.Forms.Padding(3, 5, 3, 5);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1097, 292);
            this.panel1.TabIndex = 37;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.btn_ThemHV);
            this.groupBox1.Controls.Add(this.btn_Timkiem);
            this.groupBox1.Controls.Add(this.btn_XoaHV);
            this.groupBox1.Controls.Add(this.btn_ThemLopHoc);
            this.groupBox1.Controls.Add(this.txt_Timkiem);
            this.groupBox1.Controls.Add(this.lb_Search);
            this.groupBox1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.groupBox1.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.groupBox1.Location = new System.Drawing.Point(0, 117);
            this.groupBox1.Margin = new System.Windows.Forms.Padding(3, 5, 3, 5);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Padding = new System.Windows.Forms.Padding(3, 5, 3, 5);
            this.groupBox1.Size = new System.Drawing.Size(1097, 175);
            this.groupBox1.TabIndex = 5;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Chức năng";
            // 
            // txt_Timkiem
            // 
            this.txt_Timkiem.BorderColor = System.Drawing.Color.DodgerBlue;
            this.txt_Timkiem.BorderFocusColor = System.Drawing.Color.HotPink;
            this.txt_Timkiem.BorderRadius = 0;
            this.txt_Timkiem.BorderSize = 2;
            this.txt_Timkiem.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_Timkiem.Location = new System.Drawing.Point(597, 108);
            this.txt_Timkiem.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.txt_Timkiem.Multiline = false;
            this.txt_Timkiem.Name = "txt_Timkiem";
            this.txt_Timkiem.Padding = new System.Windows.Forms.Padding(8, 9, 8, 9);
            this.txt_Timkiem.PasswordChar = false;
            this.txt_Timkiem.PlaceholderColor = System.Drawing.Color.DarkGray;
            this.txt_Timkiem.PlaceholderText = "";
            this.txt_Timkiem.Size = new System.Drawing.Size(316, 49);
            this.txt_Timkiem.TabIndex = 2;
            this.txt_Timkiem.Texts = "";
            this.txt_Timkiem.UnderlinedStyle = true;
            // 
            // lb_Search
            // 
            this.lb_Search.AutoSize = true;
            this.lb_Search.Font = new System.Drawing.Font("Segoe UI Semibold", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lb_Search.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.lb_Search.Location = new System.Drawing.Point(483, 119);
            this.lb_Search.Name = "lb_Search";
            this.lb_Search.Size = new System.Drawing.Size(101, 30);
            this.lb_Search.TabIndex = 3;
            this.lb_Search.Text = "Tìm kiếm";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Segoe UI", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label2.Location = new System.Drawing.Point(352, 39);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(333, 41);
            this.label2.TabIndex = 0;
            this.label2.Text = "DANH SÁCH LỚP HỌC";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // btn_Timkiem
            // 
            this.btn_Timkiem.FlatAppearance.BorderSize = 0;
            this.btn_Timkiem.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_Timkiem.Flip = FontAwesome.Sharp.FlipOrientation.Normal;
            this.btn_Timkiem.IconChar = FontAwesome.Sharp.IconChar.Search;
            this.btn_Timkiem.IconColor = System.Drawing.Color.White;
            this.btn_Timkiem.IconSize = 27;
            this.btn_Timkiem.Location = new System.Drawing.Point(935, 111);
            this.btn_Timkiem.Margin = new System.Windows.Forms.Padding(3, 5, 3, 5);
            this.btn_Timkiem.Name = "btn_Timkiem";
            this.btn_Timkiem.Rotation = 0D;
            this.btn_Timkiem.Size = new System.Drawing.Size(45, 46);
            this.btn_Timkiem.TabIndex = 4;
            this.btn_Timkiem.UseVisualStyleBackColor = true;
            this.btn_Timkiem.Click += new System.EventHandler(this.btn_Timkiem_Click);
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
            this.btn_XoaHV.Location = new System.Drawing.Point(258, 69);
            this.btn_XoaHV.Margin = new System.Windows.Forms.Padding(3, 5, 3, 5);
            this.btn_XoaHV.Name = "btn_XoaHV";
            this.btn_XoaHV.Rotation = 0D;
            this.btn_XoaHV.Size = new System.Drawing.Size(158, 60);
            this.btn_XoaHV.TabIndex = 6;
            this.btn_XoaHV.Text = "Xóa lớp học";
            this.btn_XoaHV.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btn_XoaHV.UseVisualStyleBackColor = true;
            this.btn_XoaHV.Click += new System.EventHandler(this.btn_XoaHV_Click);
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
            this.btn_ThemLopHoc.Location = new System.Drawing.Point(62, 69);
            this.btn_ThemLopHoc.Margin = new System.Windows.Forms.Padding(3, 5, 3, 5);
            this.btn_ThemLopHoc.Name = "btn_ThemLopHoc";
            this.btn_ThemLopHoc.Rotation = 0D;
            this.btn_ThemLopHoc.Size = new System.Drawing.Size(158, 60);
            this.btn_ThemLopHoc.TabIndex = 5;
            this.btn_ThemLopHoc.Text = "Thêm lớp học";
            this.btn_ThemLopHoc.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btn_ThemLopHoc.UseVisualStyleBackColor = true;
            this.btn_ThemLopHoc.Click += new System.EventHandler(this.btn_ThemLopHoc_Click);
            // 
            // btn_ThemHV
            // 
            this.btn_ThemHV.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_ThemHV.Flip = FontAwesome.Sharp.FlipOrientation.Normal;
            this.btn_ThemHV.Font = new System.Drawing.Font("Segoe UI Semibold", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_ThemHV.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btn_ThemHV.IconChar = FontAwesome.Sharp.IconChar.Eraser;
            this.btn_ThemHV.IconColor = System.Drawing.Color.White;
            this.btn_ThemHV.IconSize = 16;
            this.btn_ThemHV.Location = new System.Drawing.Point(569, 37);
            this.btn_ThemHV.Margin = new System.Windows.Forms.Padding(3, 5, 3, 5);
            this.btn_ThemHV.Name = "btn_ThemHV";
            this.btn_ThemHV.Rotation = 0D;
            this.btn_ThemHV.Size = new System.Drawing.Size(158, 60);
            this.btn_ThemHV.TabIndex = 7;
            this.btn_ThemHV.Text = "Thêm học viên";
            this.btn_ThemHV.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btn_ThemHV.UseVisualStyleBackColor = true;
            this.btn_ThemHV.Click += new System.EventHandler(this.btn_ThemHV_Click);
            // 
            // fQLLopHoc
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1097, 758);
            this.Controls.Add(this.dgv_LopHoc);
            this.Controls.Add(this.panel1);
            this.Margin = new System.Windows.Forms.Padding(3, 5, 3, 5);
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
        private FontAwesome.Sharp.IconButton btn_Timkiem;
        private FontAwesome.Sharp.IconButton btn_XoaHV;
        private FontAwesome.Sharp.IconButton btn_ThemLopHoc;
        private ToolsBox.RJControls.HPTextBox txt_Timkiem;
        private System.Windows.Forms.Label lb_Search;
        private System.Windows.Forms.Label label2;
        private FontAwesome.Sharp.IconButton btn_ThemHV;
    }
}