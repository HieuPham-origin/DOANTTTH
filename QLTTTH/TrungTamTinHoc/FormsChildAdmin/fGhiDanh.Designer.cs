
namespace TrungTamTinHoc.FormsChildAdmin
{
    partial class fGhiDanh
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
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.hpTextBox1 = new ToolsBox.RJControls.HPTextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.hpDateTimePicker1 = new ToolsBox.RJControls.HPDateTimePicker();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.hpDateTimePicker1);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.hpTextBox1);
            this.groupBox1.Location = new System.Drawing.Point(23, 25);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(834, 290);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Thông tin học viên";
            // 
            // hpTextBox1
            // 
            this.hpTextBox1.BorderColor = System.Drawing.Color.SlateBlue;
            this.hpTextBox1.BorderFocusColor = System.Drawing.Color.Plum;
            this.hpTextBox1.BorderRadius = 0;
            this.hpTextBox1.BorderSize = 2;
            this.hpTextBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.hpTextBox1.Location = new System.Drawing.Point(122, 42);
            this.hpTextBox1.Margin = new System.Windows.Forms.Padding(4);
            this.hpTextBox1.Multiline = false;
            this.hpTextBox1.Name = "hpTextBox1";
            this.hpTextBox1.Padding = new System.Windows.Forms.Padding(7);
            this.hpTextBox1.PasswordChar = false;
            this.hpTextBox1.PlaceholderColor = System.Drawing.Color.DarkGray;
            this.hpTextBox1.PlaceholderText = "";
            this.hpTextBox1.Size = new System.Drawing.Size(250, 35);
            this.hpTextBox1.TabIndex = 0;
            this.hpTextBox1.Texts = "";
            this.hpTextBox1.UnderlinedStyle = true;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(32, 51);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(69, 17);
            this.label1.TabIndex = 1;
            this.label1.Text = "Họ và tên";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(32, 108);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(71, 17);
            this.label2.TabIndex = 2;
            this.label2.Text = "Ngày sinh";
            // 
            // hpDateTimePicker1
            // 
            this.hpDateTimePicker1.BorderColor = System.Drawing.Color.PaleVioletRed;
            this.hpDateTimePicker1.BorderSize = 0;
            this.hpDateTimePicker1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.5F);
            this.hpDateTimePicker1.Location = new System.Drawing.Point(122, 96);
            this.hpDateTimePicker1.MinimumSize = new System.Drawing.Size(0, 35);
            this.hpDateTimePicker1.Name = "hpDateTimePicker1";
            this.hpDateTimePicker1.Size = new System.Drawing.Size(250, 35);
            this.hpDateTimePicker1.SkinColor = System.Drawing.Color.MediumSlateBlue;
            this.hpDateTimePicker1.TabIndex = 3;
            this.hpDateTimePicker1.TextColor = System.Drawing.Color.White;
            // 
            // fGhiDanh
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(884, 494);
            this.Controls.Add(this.groupBox1);
            this.Name = "fGhiDanh";
            this.Text = "fAddHV";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private ToolsBox.RJControls.HPTextBox hpTextBox1;
        private ToolsBox.RJControls.HPDateTimePicker hpDateTimePicker1;
    }
}