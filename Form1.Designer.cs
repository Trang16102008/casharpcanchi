namespace casharpcanchi
{
    partial class Form1
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
            this.lblnam = new System.Windows.Forms.Label();
            this.txtnam = new System.Windows.Forms.TextBox();
            this.txtketqua = new System.Windows.Forms.TextBox();
            this.lblketqua = new System.Windows.Forms.Label();
            this.lbsdanhsach = new System.Windows.Forms.ListBox();
            this.btntinh = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // lblnam
            // 
            this.lblnam.AutoSize = true;
            this.lblnam.Location = new System.Drawing.Point(136, 98);
            this.lblnam.Name = "lblnam";
            this.lblnam.Size = new System.Drawing.Size(29, 13);
            this.lblnam.TabIndex = 0;
            this.lblnam.Text = "Năm";
            // 
            // txtnam
            // 
            this.txtnam.Location = new System.Drawing.Point(241, 95);
            this.txtnam.Name = "txtnam";
            this.txtnam.Size = new System.Drawing.Size(100, 20);
            this.txtnam.TabIndex = 1;
            // 
            // txtketqua
            // 
            this.txtketqua.Location = new System.Drawing.Point(241, 179);
            this.txtketqua.Name = "txtketqua";
            this.txtketqua.Size = new System.Drawing.Size(100, 20);
            this.txtketqua.TabIndex = 2;
            // 
            // lblketqua
            // 
            this.lblketqua.AutoSize = true;
            this.lblketqua.Location = new System.Drawing.Point(136, 182);
            this.lblketqua.Name = "lblketqua";
            this.lblketqua.Size = new System.Drawing.Size(43, 13);
            this.lblketqua.TabIndex = 4;
            this.lblketqua.Text = "kết quả";
            // 
            // lbsdanhsach
            // 
            this.lbsdanhsach.FormattingEnabled = true;
            this.lbsdanhsach.Location = new System.Drawing.Point(512, 70);
            this.lbsdanhsach.Name = "lbsdanhsach";
            this.lbsdanhsach.Size = new System.Drawing.Size(259, 238);
            this.lbsdanhsach.TabIndex = 5;
            // 
            // btntinh
            // 
            this.btntinh.Location = new System.Drawing.Point(250, 263);
            this.btntinh.Name = "btntinh";
            this.btntinh.Size = new System.Drawing.Size(75, 23);
            this.btntinh.TabIndex = 6;
            this.btntinh.Text = "tinh";
            this.btntinh.UseVisualStyleBackColor = true;
            this.btntinh.Click += new System.EventHandler(this.btntinh_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 36F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(259, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(278, 55);
            this.label1.TabIndex = 7;
            this.label1.Text = "tính can chi";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btntinh);
            this.Controls.Add(this.lbsdanhsach);
            this.Controls.Add(this.lblketqua);
            this.Controls.Add(this.txtketqua);
            this.Controls.Add(this.txtnam);
            this.Controls.Add(this.lblnam);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblnam;
        private System.Windows.Forms.TextBox txtnam;
        private System.Windows.Forms.TextBox txtketqua;
        private System.Windows.Forms.Label lblketqua;
        private System.Windows.Forms.ListBox lbsdanhsach;
        private System.Windows.Forms.Button btntinh;
        private System.Windows.Forms.Label label1;
    }
}

