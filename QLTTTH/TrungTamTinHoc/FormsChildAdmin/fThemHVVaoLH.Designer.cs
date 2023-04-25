
namespace TrungTamTinHoc.FormsChildAdmin
{
    partial class fThemHVVaoLH
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
            this.dgv_HocVien = new System.Windows.Forms.DataGridView();
            this.panel1 = new System.Windows.Forms.Panel();
            this.cbx_LopHoc = new System.Windows.Forms.ComboBox();
            this.btn_Them = new FontAwesome.Sharp.IconButton();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_HocVien)).BeginInit();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // dgv_HocVien
            // 
            this.dgv_HocVien.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
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
            this.dgv_HocVien.Dock = System.Windows.Forms.DockStyle.Left;
            this.dgv_HocVien.EnableHeadersVisualStyles = false;
            this.dgv_HocVien.GridColor = System.Drawing.Color.SteelBlue;
            this.dgv_HocVien.Location = new System.Drawing.Point(0, 0);
            this.dgv_HocVien.Margin = new System.Windows.Forms.Padding(2, 1, 2, 1);
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
            this.dgv_HocVien.Size = new System.Drawing.Size(351, 364);
            this.dgv_HocVien.TabIndex = 19;
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.cbx_LopHoc);
            this.panel1.Controls.Add(this.btn_Them);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Location = new System.Drawing.Point(351, 0);
            this.panel1.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(286, 364);
            this.panel1.TabIndex = 20;
            // 
            // cbx_LopHoc
            // 
            this.cbx_LopHoc.FormattingEnabled = true;
            this.cbx_LopHoc.Location = new System.Drawing.Point(20, 125);
            this.cbx_LopHoc.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.cbx_LopHoc.Name = "cbx_LopHoc";
            this.cbx_LopHoc.Size = new System.Drawing.Size(153, 21);
            this.cbx_LopHoc.TabIndex = 1;
            // 
            // btn_Them
            // 
            this.btn_Them.Flip = FontAwesome.Sharp.FlipOrientation.Normal;
            this.btn_Them.IconChar = FontAwesome.Sharp.IconChar.None;
            this.btn_Them.IconColor = System.Drawing.Color.Black;
            this.btn_Them.IconSize = 16;
            this.btn_Them.Location = new System.Drawing.Point(191, 111);
            this.btn_Them.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btn_Them.Name = "btn_Them";
            this.btn_Them.Rotation = 0D;
            this.btn_Them.Size = new System.Drawing.Size(68, 45);
            this.btn_Them.TabIndex = 0;
            this.btn_Them.Text = "Thêm";
            this.btn_Them.UseVisualStyleBackColor = true;
            // 
            // fThemHVVaoLH
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(637, 364);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.dgv_HocVien);
            this.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.Name = "fThemHVVaoLH";
            this.Text = "fThemHVVaoLH";
            this.Load += new System.EventHandler(this.fThemHVVaoLH_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgv_HocVien)).EndInit();
            this.panel1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dgv_HocVien;
        private System.Windows.Forms.Panel panel1;
        private FontAwesome.Sharp.IconButton btn_Them;
        private System.Windows.Forms.ComboBox cbx_LopHoc;
    }
}