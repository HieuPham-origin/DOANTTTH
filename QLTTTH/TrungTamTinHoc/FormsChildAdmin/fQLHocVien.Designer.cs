
namespace TrungTamTinHoc.FormsChildAdmin
{
    partial class fQLHocVien
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
            this.panel1 = new System.Windows.Forms.Panel();
            this.label2 = new System.Windows.Forms.Label();
            this.btn_Search = new FontAwesome.Sharp.IconButton();
            this.lb_Search = new System.Windows.Forms.Label();
            this.txt_Search = new ToolsBox.RJControls.HPTextBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.btn_Ghidanh = new FontAwesome.Sharp.IconButton();
            this.btn_XoaHV = new FontAwesome.Sharp.IconButton();
            this.btn_Print = new FontAwesome.Sharp.IconButton();
            this.dgv_HocVien = new System.Windows.Forms.DataGridView();
            this.panel1.SuspendLayout();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_HocVien)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.RoyalBlue;
            this.panel1.Controls.Add(this.label2);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(911, 100);
            this.panel1.TabIndex = 17;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Segoe UI", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label2.Location = new System.Drawing.Point(25, 29);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(290, 35);
            this.label2.TabIndex = 0;
            this.label2.Text = "DANH SÁCH HỌC VIÊN";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // btn_Search
            // 
            this.btn_Search.FlatAppearance.BorderSize = 0;
            this.btn_Search.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_Search.Flip = FontAwesome.Sharp.FlipOrientation.Normal;
            this.btn_Search.IconChar = FontAwesome.Sharp.IconChar.Search;
            this.btn_Search.IconColor = System.Drawing.Color.White;
            this.btn_Search.IconSize = 27;
            this.btn_Search.Location = new System.Drawing.Point(691, 48);
            this.btn_Search.Name = "btn_Search";
            this.btn_Search.Rotation = 0D;
            this.btn_Search.Size = new System.Drawing.Size(40, 37);
            this.btn_Search.TabIndex = 7;
            this.btn_Search.UseVisualStyleBackColor = true;
            // 
            // lb_Search
            // 
            this.lb_Search.AutoSize = true;
            this.lb_Search.Font = new System.Drawing.Font("Segoe UI Semibold", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lb_Search.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.lb_Search.Location = new System.Drawing.Point(351, 55);
            this.lb_Search.Name = "lb_Search";
            this.lb_Search.Size = new System.Drawing.Size(80, 23);
            this.lb_Search.TabIndex = 6;
            this.lb_Search.Text = "Tìm kiếm";
            // 
            // txt_Search
            // 
            this.txt_Search.BorderColor = System.Drawing.Color.DodgerBlue;
            this.txt_Search.BorderFocusColor = System.Drawing.Color.HotPink;
            this.txt_Search.BorderRadius = 0;
            this.txt_Search.BorderSize = 2;
            this.txt_Search.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_Search.Location = new System.Drawing.Point(438, 48);
            this.txt_Search.Margin = new System.Windows.Forms.Padding(4);
            this.txt_Search.Multiline = false;
            this.txt_Search.Name = "txt_Search";
            this.txt_Search.Padding = new System.Windows.Forms.Padding(7);
            this.txt_Search.PasswordChar = false;
            this.txt_Search.PlaceholderColor = System.Drawing.Color.DarkGray;
            this.txt_Search.PlaceholderText = "";
            this.txt_Search.Size = new System.Drawing.Size(246, 35);
            this.txt_Search.TabIndex = 5;
            this.txt_Search.Texts = "";
            this.txt_Search.UnderlinedStyle = true;
            // 
            // groupBox1
            // 
            this.groupBox1.BackColor = System.Drawing.Color.RoyalBlue;
            this.groupBox1.Controls.Add(this.btn_Search);
            this.groupBox1.Controls.Add(this.btn_Ghidanh);
            this.groupBox1.Controls.Add(this.btn_XoaHV);
            this.groupBox1.Controls.Add(this.btn_Print);
            this.groupBox1.Controls.Add(this.lb_Search);
            this.groupBox1.Controls.Add(this.txt_Search);
            this.groupBox1.Dock = System.Windows.Forms.DockStyle.Top;
            this.groupBox1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.groupBox1.Font = new System.Drawing.Font("Segoe UI Semibold", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.groupBox1.Location = new System.Drawing.Point(0, 100);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(911, 109);
            this.groupBox1.TabIndex = 16;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Chức năng";
            // 
            // btn_Ghidanh
            // 
            this.btn_Ghidanh.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_Ghidanh.Flip = FontAwesome.Sharp.FlipOrientation.Normal;
            this.btn_Ghidanh.Font = new System.Drawing.Font("Segoe UI Semibold", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Ghidanh.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btn_Ghidanh.IconChar = FontAwesome.Sharp.IconChar.UserPlus;
            this.btn_Ghidanh.IconColor = System.Drawing.Color.White;
            this.btn_Ghidanh.IconSize = 16;
            this.btn_Ghidanh.Location = new System.Drawing.Point(31, 43);
            this.btn_Ghidanh.Name = "btn_Ghidanh";
            this.btn_Ghidanh.Rotation = 0D;
            this.btn_Ghidanh.Size = new System.Drawing.Size(125, 48);
            this.btn_Ghidanh.TabIndex = 0;
            this.btn_Ghidanh.Text = "Ghi danh";
            this.btn_Ghidanh.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btn_Ghidanh.UseVisualStyleBackColor = true;
            this.btn_Ghidanh.Click += new System.EventHandler(this.btn_Ghidanh_Click);
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
            this.btn_XoaHV.Location = new System.Drawing.Point(190, 43);
            this.btn_XoaHV.Name = "btn_XoaHV";
            this.btn_XoaHV.Rotation = 0D;
            this.btn_XoaHV.Size = new System.Drawing.Size(125, 48);
            this.btn_XoaHV.TabIndex = 1;
            this.btn_XoaHV.Text = "Xóa học viên";
            this.btn_XoaHV.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btn_XoaHV.UseVisualStyleBackColor = true;
            this.btn_XoaHV.Click += new System.EventHandler(this.btn_XoaHV_Click);
            // 
            // btn_Print
            // 
            this.btn_Print.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_Print.Flip = FontAwesome.Sharp.FlipOrientation.Normal;
            this.btn_Print.Font = new System.Drawing.Font("Segoe UI Semibold", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Print.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btn_Print.IconChar = FontAwesome.Sharp.IconChar.Print;
            this.btn_Print.IconColor = System.Drawing.Color.White;
            this.btn_Print.IconSize = 16;
            this.btn_Print.Location = new System.Drawing.Point(760, 43);
            this.btn_Print.Name = "btn_Print";
            this.btn_Print.Rotation = 0D;
            this.btn_Print.Size = new System.Drawing.Size(125, 48);
            this.btn_Print.TabIndex = 4;
            this.btn_Print.Text = "In danh sách";
            this.btn_Print.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btn_Print.UseVisualStyleBackColor = true;
            // 
            // dgv_HocVien
            // 
            this.dgv_HocVien.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells;
            this.dgv_HocVien.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.dgv_HocVien.BackgroundColor = System.Drawing.SystemColors.ActiveCaption;
            this.dgv_HocVien.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dgv_HocVien.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal;
            this.dgv_HocVien.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.HotTrack;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgv_HocVien.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.dgv_HocVien.ColumnHeadersHeight = 30;
            this.dgv_HocVien.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            this.dgv_HocVien.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgv_HocVien.EnableHeadersVisualStyles = false;
            this.dgv_HocVien.GridColor = System.Drawing.Color.SteelBlue;
            this.dgv_HocVien.Location = new System.Drawing.Point(0, 209);
            this.dgv_HocVien.Name = "dgv_HocVien";
            this.dgv_HocVien.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.SteelBlue;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgv_HocVien.RowHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.dgv_HocVien.RowHeadersVisible = false;
            this.dgv_HocVien.RowHeadersWidth = 51;
            dataGridViewCellStyle3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Segoe UI", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.SteelBlue;
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.Color.White;
            this.dgv_HocVien.RowsDefaultCellStyle = dataGridViewCellStyle3;
            this.dgv_HocVien.RowTemplate.Height = 24;
            this.dgv_HocVien.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgv_HocVien.Size = new System.Drawing.Size(911, 369);
            this.dgv_HocVien.TabIndex = 18;
            this.dgv_HocVien.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgv_HocVien_CellClick);
            this.dgv_HocVien.CellEndEdit += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgv_HocVien_CellEndEdit);
            // 
            // fQLHocVien
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(911, 578);
            this.Controls.Add(this.dgv_HocVien);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.panel1);
            this.Name = "fQLHocVien";
            this.Text = "fQLHocVien";
            this.Load += new System.EventHandler(this.fQLHocVien_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_HocVien)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label2;
        private FontAwesome.Sharp.IconButton btn_Ghidanh;
        private System.Windows.Forms.GroupBox groupBox1;
        private FontAwesome.Sharp.IconButton btn_Print;
        private FontAwesome.Sharp.IconButton btn_XoaHV;
        private System.Windows.Forms.DataGridView dgv_HocVien;
        private FontAwesome.Sharp.IconButton btn_Search;
        private System.Windows.Forms.Label lb_Search;
        private ToolsBox.RJControls.HPTextBox txt_Search;
    }
}