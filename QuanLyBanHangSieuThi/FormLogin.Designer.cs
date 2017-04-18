namespace QuanLyBanHangSieuThi
{
    partial class FormLogin
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
            this.panel1 = new System.Windows.Forms.Panel();
            this.button_login_exit = new System.Windows.Forms.Button();
            this.button_login_sign_in = new System.Windows.Forms.Button();
            this.panel3 = new System.Windows.Forms.Panel();
            this.edit_text_login_password = new System.Windows.Forms.TextBox();
            this.text_login_password = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.edit_text_login_account = new System.Windows.Forms.TextBox();
            this.text_login_account = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            this.panel3.SuspendLayout();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.button_login_exit);
            this.panel1.Controls.Add(this.button_login_sign_in);
            this.panel1.Controls.Add(this.panel3);
            this.panel1.Controls.Add(this.panel2);
            this.panel1.Location = new System.Drawing.Point(6, 12);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(482, 170);
            this.panel1.TabIndex = 0;
            // 
            // button_login_exit
            // 
            this.button_login_exit.Location = new System.Drawing.Point(370, 139);
            this.button_login_exit.Name = "button_login_exit";
            this.button_login_exit.Size = new System.Drawing.Size(75, 23);
            this.button_login_exit.TabIndex = 3;
            this.button_login_exit.Text = "Thoát";
            this.button_login_exit.UseVisualStyleBackColor = true;
            this.button_login_exit.Click += new System.EventHandler(this.button_login_exit_Click);
            // 
            // button_login_sign_in
            // 
            this.button_login_sign_in.Location = new System.Drawing.Point(272, 139);
            this.button_login_sign_in.Name = "button_login_sign_in";
            this.button_login_sign_in.Size = new System.Drawing.Size(75, 23);
            this.button_login_sign_in.TabIndex = 2;
            this.button_login_sign_in.Text = "Đăng Nhập";
            this.button_login_sign_in.UseVisualStyleBackColor = true;
            this.button_login_sign_in.Click += new System.EventHandler(this.button_login_sign_in_Click);
            // 
            // panel3
            // 
            this.panel3.Controls.Add(this.edit_text_login_password);
            this.panel3.Controls.Add(this.text_login_password);
            this.panel3.Location = new System.Drawing.Point(18, 74);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(450, 45);
            this.panel3.TabIndex = 1;
            // 
            // edit_text_login_password
            // 
            this.edit_text_login_password.Location = new System.Drawing.Point(216, 15);
            this.edit_text_login_password.Name = "edit_text_login_password";
            this.edit_text_login_password.Size = new System.Drawing.Size(211, 20);
            this.edit_text_login_password.TabIndex = 1;
            this.edit_text_login_password.TabStop = false;
            this.edit_text_login_password.UseSystemPasswordChar = true;
            // 
            // text_login_password
            // 
            this.text_login_password.AutoSize = true;
            this.text_login_password.Font = new System.Drawing.Font("Arial", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.text_login_password.Location = new System.Drawing.Point(13, 12);
            this.text_login_password.Name = "text_login_password";
            this.text_login_password.Size = new System.Drawing.Size(105, 24);
            this.text_login_password.TabIndex = 0;
            this.text_login_password.Text = "Mật Khẩu";
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.edit_text_login_account);
            this.panel2.Controls.Add(this.text_login_account);
            this.panel2.Location = new System.Drawing.Point(18, 14);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(450, 45);
            this.panel2.TabIndex = 0;
            // 
            // edit_text_login_account
            // 
            this.edit_text_login_account.Location = new System.Drawing.Point(216, 16);
            this.edit_text_login_account.Name = "edit_text_login_account";
            this.edit_text_login_account.Size = new System.Drawing.Size(211, 20);
            this.edit_text_login_account.TabIndex = 1;
            // 
            // text_login_account
            // 
            this.text_login_account.AutoSize = true;
            this.text_login_account.Font = new System.Drawing.Font("Arial", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.text_login_account.Location = new System.Drawing.Point(13, 13);
            this.text_login_account.Name = "text_login_account";
            this.text_login_account.Size = new System.Drawing.Size(165, 24);
            this.text_login_account.TabIndex = 0;
            this.text_login_account.Text = "Tên Đăng Nhập";
            // 
            // FormLogin
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.ClientSize = new System.Drawing.Size(500, 194);
            this.Controls.Add(this.panel1);
            this.Name = "FormLogin";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Đăng nhập";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.FormLogin_FormClosing);
            this.panel1.ResumeLayout(false);
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Label text_login_password;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label text_login_account;
        private System.Windows.Forms.Button button_login_exit;
        private System.Windows.Forms.Button button_login_sign_in;
        private System.Windows.Forms.TextBox edit_text_login_password;
        private System.Windows.Forms.TextBox edit_text_login_account;
    }
}

