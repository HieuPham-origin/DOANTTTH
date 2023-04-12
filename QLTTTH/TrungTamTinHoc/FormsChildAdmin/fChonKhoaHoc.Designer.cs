
namespace TrungTamTinHoc.FormsChildAdmin
{
    partial class fChonKhoaHoc
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
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.hpButton1 = new TTTH.RJControls.HPButton();
            this.hpTextBox1 = new ToolsBox.RJControls.HPTextBox();
            this.label1 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(12, 94);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.Size = new System.Drawing.Size(555, 298);
            this.dataGridView1.TabIndex = 0;
            // 
            // hpButton1
            // 
            this.hpButton1.BackColor = System.Drawing.Color.MediumSlateBlue;
            this.hpButton1.BackgroundColor = System.Drawing.Color.MediumSlateBlue;
            this.hpButton1.BorderColor = System.Drawing.Color.PaleVioletRed;
            this.hpButton1.BorderRadius = 40;
            this.hpButton1.BorderSize = 0;
            this.hpButton1.FlatAppearance.BorderSize = 0;
            this.hpButton1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.hpButton1.ForeColor = System.Drawing.Color.White;
            this.hpButton1.Location = new System.Drawing.Point(417, 37);
            this.hpButton1.Name = "hpButton1";
            this.hpButton1.Size = new System.Drawing.Size(150, 40);
            this.hpButton1.TabIndex = 1;
            this.hpButton1.Text = "Thêm";
            this.hpButton1.TextColor = System.Drawing.Color.White;
            this.hpButton1.UseVisualStyleBackColor = false;
            // 
            // hpTextBox1
            // 
            this.hpTextBox1.BorderColor = System.Drawing.Color.MediumSlateBlue;
            this.hpTextBox1.BorderFocusColor = System.Drawing.Color.HotPink;
            this.hpTextBox1.BorderRadius = 0;
            this.hpTextBox1.BorderSize = 2;
            this.hpTextBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.hpTextBox1.Location = new System.Drawing.Point(145, 42);
            this.hpTextBox1.Margin = new System.Windows.Forms.Padding(4);
            this.hpTextBox1.Multiline = false;
            this.hpTextBox1.Name = "hpTextBox1";
            this.hpTextBox1.Padding = new System.Windows.Forms.Padding(7);
            this.hpTextBox1.PasswordChar = false;
            this.hpTextBox1.PlaceholderColor = System.Drawing.Color.DarkGray;
            this.hpTextBox1.PlaceholderText = "";
            this.hpTextBox1.Size = new System.Drawing.Size(250, 35);
            this.hpTextBox1.TabIndex = 2;
            this.hpTextBox1.Texts = "";
            this.hpTextBox1.UnderlinedStyle = false;
            this.hpTextBox1._TextChanged += new System.EventHandler(this.hpTextBox1__TextChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 49);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(126, 17);
            this.label1.TabIndex = 4;
            this.label1.Text = "Tìm kiếm khóa học";
            // 
            // fChonKhoaHoc
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(580, 407);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.hpTextBox1);
            this.Controls.Add(this.hpButton1);
            this.Controls.Add(this.dataGridView1);
            this.Name = "fChonKhoaHoc";
            this.Text = "fChonKhoaHoc";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView1;
        private TTTH.RJControls.HPButton hpButton1;
        private ToolsBox.RJControls.HPTextBox hpTextBox1;
        private System.Windows.Forms.Label label1;
    }
}