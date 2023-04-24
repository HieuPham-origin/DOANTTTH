
namespace TrungTamTinHoc.FormsChildGiangVien
{
    partial class fLopHoc
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
            this.btn_Timkiem = new FontAwesome.Sharp.IconButton();
            this.label2 = new System.Windows.Forms.Label();
            this.lb_Search = new System.Windows.Forms.Label();
            this.cbx_LH = new System.Windows.Forms.ComboBox();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_LopHoc)).BeginInit();
            this.panel1.SuspendLayout();
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
            this.dgv_LopHoc.Location = new System.Drawing.Point(0, 158);
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
            this.dgv_LopHoc.Size = new System.Drawing.Size(800, 292);
            this.dgv_LopHoc.TabIndex = 36;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.RoyalBlue;
            this.panel1.Controls.Add(this.cbx_LH);
            this.panel1.Controls.Add(this.btn_Timkiem);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.lb_Search);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(800, 158);
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
            this.btn_Timkiem.Location = new System.Drawing.Point(547, 106);
            this.btn_Timkiem.Name = "btn_Timkiem";
            this.btn_Timkiem.Rotation = 0D;
            this.btn_Timkiem.Size = new System.Drawing.Size(40, 37);
            this.btn_Timkiem.TabIndex = 4;
            this.btn_Timkiem.UseVisualStyleBackColor = true;
            this.btn_Timkiem.Click += new System.EventHandler(this.btn_Timkiem_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Segoe UI", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label2.Location = new System.Drawing.Point(265, 36);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(279, 35);
            this.label2.TabIndex = 0;
            this.label2.Text = "DANH SÁCH LỚP HỌC";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lb_Search
            // 
            this.lb_Search.AutoSize = true;
            this.lb_Search.Font = new System.Drawing.Font("Segoe UI Semibold", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lb_Search.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.lb_Search.Location = new System.Drawing.Point(175, 111);
            this.lb_Search.Name = "lb_Search";
            this.lb_Search.Size = new System.Drawing.Size(80, 23);
            this.lb_Search.TabIndex = 3;
            this.lb_Search.Text = "Tìm kiếm";
            // 
            // cbx_LH
            // 
            this.cbx_LH.FormattingEnabled = true;
            this.cbx_LH.Location = new System.Drawing.Point(288, 113);
            this.cbx_LH.Name = "cbx_LH";
            this.cbx_LH.Size = new System.Drawing.Size(230, 24);
            this.cbx_LH.TabIndex = 5;
            // 
            // fLopHoc
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.dgv_LopHoc);
            this.Controls.Add(this.panel1);
            this.Name = "fLopHoc";
            this.Text = "fLopHoc";
            this.Load += new System.EventHandler(this.fLopHoc_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgv_LopHoc)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dgv_LopHoc;
        private System.Windows.Forms.Panel panel1;
        private FontAwesome.Sharp.IconButton btn_Timkiem;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label lb_Search;
        private System.Windows.Forms.ComboBox cbx_LH;
    }
}