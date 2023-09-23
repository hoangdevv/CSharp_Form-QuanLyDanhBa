namespace Login_Logout
{
    partial class FormDangNhap
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
            this.buttonDangNhap = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.panelDangNhap = new System.Windows.Forms.Panel();
            this.textBoxMK = new System.Windows.Forms.TextBox();
            this.textBoxTK = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.panelDangNhap.SuspendLayout();
            this.SuspendLayout();
            // 
            // buttonDangNhap
            // 
            this.buttonDangNhap.Location = new System.Drawing.Point(236, 145);
            this.buttonDangNhap.Name = "buttonDangNhap";
            this.buttonDangNhap.Size = new System.Drawing.Size(86, 39);
            this.buttonDangNhap.TabIndex = 4;
            this.buttonDangNhap.Text = "Đăng nhập";
            this.buttonDangNhap.UseVisualStyleBackColor = true;
            this.buttonDangNhap.Click += new System.EventHandler(this.button1_Click);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(342, 145);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(83, 39);
            this.button2.TabIndex = 5;
            this.button2.Text = "Thoát";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // panelDangNhap
            // 
            this.panelDangNhap.Controls.Add(this.textBoxMK);
            this.panelDangNhap.Controls.Add(this.textBoxTK);
            this.panelDangNhap.Controls.Add(this.label2);
            this.panelDangNhap.Controls.Add(this.label1);
            this.panelDangNhap.Location = new System.Drawing.Point(94, 26);
            this.panelDangNhap.Name = "panelDangNhap";
            this.panelDangNhap.Size = new System.Drawing.Size(270, 100);
            this.panelDangNhap.TabIndex = 6;
            // 
            // textBoxMK
            // 
            this.textBoxMK.Location = new System.Drawing.Point(96, 68);
            this.textBoxMK.Name = "textBoxMK";
            this.textBoxMK.Size = new System.Drawing.Size(149, 20);
            this.textBoxMK.TabIndex = 7;
            // 
            // textBoxTK
            // 
            this.textBoxTK.Location = new System.Drawing.Point(96, 13);
            this.textBoxTK.Name = "textBoxTK";
            this.textBoxTK.Size = new System.Drawing.Size(149, 20);
            this.textBoxTK.TabIndex = 6;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(26, 71);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(55, 13);
            this.label2.TabIndex = 5;
            this.label2.Text = "Mật khẩu ";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(26, 16);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(58, 13);
            this.label1.TabIndex = 4;
            this.label1.Text = "Tài khoản ";
            // 
            // FormDangNhap
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(474, 225);
            this.Controls.Add(this.panelDangNhap);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.buttonDangNhap);
            this.Name = "FormDangNhap";
            this.Text = "FormDangNhap";
            this.panelDangNhap.ResumeLayout(false);
            this.panelDangNhap.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Button buttonDangNhap;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Panel panelDangNhap;
        private System.Windows.Forms.TextBox textBoxMK;
        private System.Windows.Forms.TextBox textBoxTK;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
    }
}

