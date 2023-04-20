
namespace TrungTamTinHoc.FormsChildGiangVien
{
    partial class fLichDay
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
            this.dgv_KhoaHoc = new System.Windows.Forms.DataGridView();
            this.panel1 = new System.Windows.Forms.Panel();
            this.btn_Timkiem = new FontAwesome.Sharp.IconButton();
            this.label2 = new System.Windows.Forms.Label();
            this.txt_Timkiem = new ToolsBox.RJControls.HPTextBox();
            this.lb_Search = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_KhoaHoc)).BeginInit();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // dgv_KhoaHoc
            // 
            this.dgv_KhoaHoc.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgv_KhoaHoc.BackgroundColor = System.Drawing.SystemColors.ActiveCaption;
            this.dgv_KhoaHoc.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dgv_KhoaHoc.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal;
            this.dgv_KhoaHoc.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.HotTrack;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgv_KhoaHoc.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.dgv_KhoaHoc.ColumnHeadersHeight = 30;
            this.dgv_KhoaHoc.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            this.dgv_KhoaHoc.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgv_KhoaHoc.EnableHeadersVisualStyles = false;
            this.dgv_KhoaHoc.GridColor = System.Drawing.Color.SteelBlue;
            this.dgv_KhoaHoc.Location = new System.Drawing.Point(0, 153);
            this.dgv_KhoaHoc.Name = "dgv_KhoaHoc";
            this.dgv_KhoaHoc.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.SteelBlue;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgv_KhoaHoc.RowHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.dgv_KhoaHoc.RowHeadersVisible = false;
            this.dgv_KhoaHoc.RowHeadersWidth = 51;
            dataGridViewCellStyle3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Segoe UI", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.SteelBlue;
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.Color.White;
            this.dgv_KhoaHoc.RowsDefaultCellStyle = dataGridViewCellStyle3;
            this.dgv_KhoaHoc.RowTemplate.Height = 24;
            this.dgv_KhoaHoc.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgv_KhoaHoc.Size = new System.Drawing.Size(800, 297);
            this.dgv_KhoaHoc.TabIndex = 36;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.RoyalBlue;
            this.panel1.Controls.Add(this.btn_Timkiem);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.txt_Timkiem);
            this.panel1.Controls.Add(this.lb_Search);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(800, 153);
            this.panel1.TabIndex = 35;
            // 
            // btn_Timkiem
            // 
            this.btn_Timkiem.FlatAppearance.BorderSize = 0;
            this.btn_Timkiem.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_Timkiem.Flip = FontAwesome.Sharp.FlipOrientation.Normal;
            this.btn_Timkiem.IconChar = FontAwesome.Sharp.IconChar.Search;
            this.btn_Timkiem.IconColor = System.Drawing.Color.White;
            this.btn_Timkiem.IconSize = 27;
            this.btn_Timkiem.Location = new System.Drawing.Point(597, 98);
            this.btn_Timkiem.Name = "btn_Timkiem";
            this.btn_Timkiem.Rotation = 0D;
            this.btn_Timkiem.Size = new System.Drawing.Size(49, 37);
            this.btn_Timkiem.TabIndex = 4;
            this.btn_Timkiem.UseVisualStyleBackColor = true;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Segoe UI", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label2.Location = new System.Drawing.Point(314, 36);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(190, 35);
            this.label2.TabIndex = 0;
            this.label2.Text = "LỊCH DẠY HỌC";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // txt_Timkiem
            // 
            this.txt_Timkiem.BorderColor = System.Drawing.Color.DodgerBlue;
            this.txt_Timkiem.BorderFocusColor = System.Drawing.Color.HotPink;
            this.txt_Timkiem.BorderRadius = 0;
            this.txt_Timkiem.BorderSize = 2;
            this.txt_Timkiem.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_Timkiem.Location = new System.Drawing.Point(264, 98);
            this.txt_Timkiem.Margin = new System.Windows.Forms.Padding(4);
            this.txt_Timkiem.Multiline = false;
            this.txt_Timkiem.Name = "txt_Timkiem";
            this.txt_Timkiem.Padding = new System.Windows.Forms.Padding(7);
            this.txt_Timkiem.PasswordChar = false;
            this.txt_Timkiem.PlaceholderColor = System.Drawing.Color.DarkGray;
            this.txt_Timkiem.PlaceholderText = "";
            this.txt_Timkiem.Size = new System.Drawing.Size(326, 39);
            this.txt_Timkiem.TabIndex = 2;
            this.txt_Timkiem.Texts = "";
            this.txt_Timkiem.UnderlinedStyle = true;
            // 
            // lb_Search
            // 
            this.lb_Search.AutoSize = true;
            this.lb_Search.Font = new System.Drawing.Font("Segoe UI Semibold", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lb_Search.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.lb_Search.Location = new System.Drawing.Point(164, 105);
            this.lb_Search.Name = "lb_Search";
            this.lb_Search.Size = new System.Drawing.Size(80, 23);
            this.lb_Search.TabIndex = 3;
            this.lb_Search.Text = "Tìm kiếm";
            // 
            // fLichDay
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.dgv_KhoaHoc);
            this.Controls.Add(this.panel1);
            this.Name = "fLichDay";
            this.Text = "fLichDay";
            ((System.ComponentModel.ISupportInitialize)(this.dgv_KhoaHoc)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dgv_KhoaHoc;
        private System.Windows.Forms.Panel panel1;
        private FontAwesome.Sharp.IconButton btn_Timkiem;
        private System.Windows.Forms.Label label2;
        private ToolsBox.RJControls.HPTextBox txt_Timkiem;
        private System.Windows.Forms.Label lb_Search;
    }
}