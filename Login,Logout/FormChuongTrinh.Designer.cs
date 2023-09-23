namespace Login_Logout
{
    partial class FormChuongTrinh
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
            this.button2 = new System.Windows.Forms.Button();
            this.buttonDangXuat = new System.Windows.Forms.Button();
            this.textBox = new System.Windows.Forms.TextBox();
            this.buttonQLTK = new System.Windows.Forms.Button();
            this.buttonXem = new System.Windows.Forms.Button();
            this.buttonThemMoi = new System.Windows.Forms.Button();
            this.buttonXoa = new System.Windows.Forms.Button();
            this.buttonSua = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // button2
            // 
            this.button2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button2.Location = new System.Drawing.Point(510, 251);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(90, 38);
            this.button2.TabIndex = 1;
            this.button2.Text = "Thoát";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // buttonDangXuat
            // 
            this.buttonDangXuat.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonDangXuat.Location = new System.Drawing.Point(414, 251);
            this.buttonDangXuat.Name = "buttonDangXuat";
            this.buttonDangXuat.Size = new System.Drawing.Size(90, 38);
            this.buttonDangXuat.TabIndex = 2;
            this.buttonDangXuat.Text = "Đăng xuất";
            this.buttonDangXuat.UseVisualStyleBackColor = true;
            this.buttonDangXuat.Click += new System.EventHandler(this.buttonDangXuat_Click);
            // 
            // textBox
            // 
            this.textBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox.Location = new System.Drawing.Point(79, 38);
            this.textBox.Name = "textBox";
            this.textBox.Size = new System.Drawing.Size(100, 24);
            this.textBox.TabIndex = 3;
            // 
            // buttonQLTK
            // 
            this.buttonQLTK.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonQLTK.Location = new System.Drawing.Point(414, 22);
            this.buttonQLTK.Name = "buttonQLTK";
            this.buttonQLTK.Size = new System.Drawing.Size(164, 51);
            this.buttonQLTK.TabIndex = 4;
            this.buttonQLTK.Text = "Quản lý tài khoản";
            this.buttonQLTK.UseVisualStyleBackColor = true;
            // 
            // buttonXem
            // 
            this.buttonXem.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonXem.Location = new System.Drawing.Point(21, 251);
            this.buttonXem.Name = "buttonXem";
            this.buttonXem.Size = new System.Drawing.Size(90, 38);
            this.buttonXem.TabIndex = 5;
            this.buttonXem.Text = "Xem";
            this.buttonXem.UseVisualStyleBackColor = true;
            // 
            // buttonThemMoi
            // 
            this.buttonThemMoi.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonThemMoi.Location = new System.Drawing.Point(117, 251);
            this.buttonThemMoi.Name = "buttonThemMoi";
            this.buttonThemMoi.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.buttonThemMoi.Size = new System.Drawing.Size(90, 38);
            this.buttonThemMoi.TabIndex = 6;
            this.buttonThemMoi.Text = "Thêm mới";
            this.buttonThemMoi.UseVisualStyleBackColor = true;
            // 
            // buttonXoa
            // 
            this.buttonXoa.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonXoa.Location = new System.Drawing.Point(213, 251);
            this.buttonXoa.Name = "buttonXoa";
            this.buttonXoa.Size = new System.Drawing.Size(90, 38);
            this.buttonXoa.TabIndex = 7;
            this.buttonXoa.Text = "Xóa";
            this.buttonXoa.UseVisualStyleBackColor = true;
            // 
            // buttonSua
            // 
            this.buttonSua.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonSua.Location = new System.Drawing.Point(309, 251);
            this.buttonSua.Name = "buttonSua";
            this.buttonSua.Size = new System.Drawing.Size(90, 38);
            this.buttonSua.TabIndex = 8;
            this.buttonSua.Text = "Sửa";
            this.buttonSua.UseVisualStyleBackColor = true;
            // 
            // FormChuongTrinh
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(612, 318);
            this.Controls.Add(this.buttonSua);
            this.Controls.Add(this.buttonXoa);
            this.Controls.Add(this.buttonThemMoi);
            this.Controls.Add(this.buttonXem);
            this.Controls.Add(this.buttonQLTK);
            this.Controls.Add(this.textBox);
            this.Controls.Add(this.buttonDangXuat);
            this.Controls.Add(this.button2);
            this.Name = "FormChuongTrinh";
            this.Text = "FormChuongTrinh";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.FormChuongTrinh_FormClosing);
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.FormChuongTrinh_FormClosed);
            this.Load += new System.EventHandler(this.FormChuongTrinh_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button buttonDangXuat;
        private System.Windows.Forms.TextBox textBox;
        private System.Windows.Forms.Button buttonQLTK;
        private System.Windows.Forms.Button buttonXem;
        private System.Windows.Forms.Button buttonThemMoi;
        private System.Windows.Forms.Button buttonXoa;
        private System.Windows.Forms.Button buttonSua;
    }
}