namespace QuanLyBanHangSieuThi
{
    partial class FormEmployy
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
            this.gird_view_employy = new System.Windows.Forms.DataGridView();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.edit_text_employy_id = new System.Windows.Forms.TextBox();
            this.edit_text_employy_name = new System.Windows.Forms.TextBox();
            this.edit_text_employy_phone = new System.Windows.Forms.TextBox();
            this.edit_text_employy_address = new System.Windows.Forms.TextBox();
            this.button_employy_search_name = new System.Windows.Forms.Button();
            this.button_employy_search_id = new System.Windows.Forms.Button();
            this.button_employy_no = new System.Windows.Forms.Button();
            this.button_employy_yes = new System.Windows.Forms.Button();
            this.button_employy_delete = new System.Windows.Forms.Button();
            this.button_employy_back = new System.Windows.Forms.Button();
            this.button_employy_update = new System.Windows.Forms.Button();
            this.button_employy_insert = new System.Windows.Forms.Button();
            this.backgroundWorker1 = new System.ComponentModel.BackgroundWorker();
            this.panel1 = new System.Windows.Forms.Panel();
            ((System.ComponentModel.ISupportInitialize)(this.gird_view_employy)).BeginInit();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // gird_view_employy
            // 
            this.gird_view_employy.AccessibleRole = System.Windows.Forms.AccessibleRole.Cursor;
            this.gird_view_employy.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.gird_view_employy.Location = new System.Drawing.Point(3, 3);
            this.gird_view_employy.Name = "gird_view_employy";
            this.gird_view_employy.Size = new System.Drawing.Size(568, 186);
            this.gird_view_employy.TabIndex = 1;
            
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Arial", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(215, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(187, 22);
            this.label1.TabIndex = 2;
            this.label1.Text = "Quản Lý Nhân Viên";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 75);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(72, 13);
            this.label2.TabIndex = 3;
            this.label2.Text = "Mã nhân viên";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(12, 135);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(76, 13);
            this.label3.TabIndex = 4;
            this.label3.Text = "Tên nhân viên";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(332, 82);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(70, 13);
            this.label4.TabIndex = 5;
            this.label4.Text = "Số điện thoại";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(343, 139);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(40, 13);
            this.label5.TabIndex = 6;
            this.label5.Text = "Địa chỉ";
            // 
            // edit_text_employy_id
            // 
            this.edit_text_employy_id.Location = new System.Drawing.Point(97, 72);
            this.edit_text_employy_id.Name = "edit_text_employy_id";
            this.edit_text_employy_id.Size = new System.Drawing.Size(155, 20);
            this.edit_text_employy_id.TabIndex = 7;
            // 
            // edit_text_employy_name
            // 
            this.edit_text_employy_name.Location = new System.Drawing.Point(97, 128);
            this.edit_text_employy_name.Name = "edit_text_employy_name";
            this.edit_text_employy_name.Size = new System.Drawing.Size(155, 20);
            this.edit_text_employy_name.TabIndex = 8;
            // 
            // edit_text_employy_phone
            // 
            this.edit_text_employy_phone.Location = new System.Drawing.Point(427, 75);
            this.edit_text_employy_phone.Name = "edit_text_employy_phone";
            this.edit_text_employy_phone.Size = new System.Drawing.Size(156, 20);
            this.edit_text_employy_phone.TabIndex = 9;
            // 
            // edit_text_employy_address
            // 
            this.edit_text_employy_address.Location = new System.Drawing.Point(427, 132);
            this.edit_text_employy_address.Name = "edit_text_employy_address";
            this.edit_text_employy_address.Size = new System.Drawing.Size(156, 20);
            this.edit_text_employy_address.TabIndex = 10;
            // 
            // button_employy_search_name
            // 
            this.button_employy_search_name.BackColor = System.Drawing.SystemColors.ControlLight;
            this.button_employy_search_name.BackgroundImage = global::QuanLyBanHangSieuThi.Properties.Resources._1492429049_icons_search;
            this.button_employy_search_name.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.button_employy_search_name.Location = new System.Drawing.Point(258, 121);
            this.button_employy_search_name.Name = "button_employy_search_name";
            this.button_employy_search_name.Size = new System.Drawing.Size(32, 32);
            this.button_employy_search_name.TabIndex = 19;
            this.button_employy_search_name.UseVisualStyleBackColor = false;
            // 
            // button_employy_search_id
            // 
            this.button_employy_search_id.BackColor = System.Drawing.SystemColors.ControlLight;
            this.button_employy_search_id.BackgroundImage = global::QuanLyBanHangSieuThi.Properties.Resources._1492429049_icons_search;
            this.button_employy_search_id.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.button_employy_search_id.Location = new System.Drawing.Point(258, 65);
            this.button_employy_search_id.Name = "button_employy_search_id";
            this.button_employy_search_id.Size = new System.Drawing.Size(32, 32);
            this.button_employy_search_id.TabIndex = 18;
            this.button_employy_search_id.UseVisualStyleBackColor = false;
            // 
            // button_employy_no
            // 
            this.button_employy_no.BackgroundImage = global::QuanLyBanHangSieuThi.Properties.Resources._1492426077_icons_exit;
            this.button_employy_no.Location = new System.Drawing.Point(440, 389);
            this.button_employy_no.Name = "button_employy_no";
            this.button_employy_no.Size = new System.Drawing.Size(64, 64);
            this.button_employy_no.TabIndex = 16;
            this.button_employy_no.UseVisualStyleBackColor = true;
            // 
            // button_employy_yes
            // 
            this.button_employy_yes.BackgroundImage = global::QuanLyBanHangSieuThi.Properties.Resources._1492426098_icons_check;
            this.button_employy_yes.Location = new System.Drawing.Point(361, 389);
            this.button_employy_yes.Name = "button_employy_yes";
            this.button_employy_yes.Size = new System.Drawing.Size(64, 64);
            this.button_employy_yes.TabIndex = 15;
            this.button_employy_yes.UseVisualStyleBackColor = true;
            // 
            // button_employy_delete
            // 
            this.button_employy_delete.BackgroundImage = global::QuanLyBanHangSieuThi.Properties.Resources._1492427262_icons_delete;
            this.button_employy_delete.Location = new System.Drawing.Point(177, 389);
            this.button_employy_delete.Name = "button_employy_delete";
            this.button_employy_delete.Size = new System.Drawing.Size(64, 64);
            this.button_employy_delete.TabIndex = 14;
            this.button_employy_delete.UseVisualStyleBackColor = true;
            // 
            // button_employy_back
            // 
            this.button_employy_back.BackgroundImage = global::QuanLyBanHangSieuThi.Properties.Resources._1492426060_icons_share;
            this.button_employy_back.Location = new System.Drawing.Point(519, 389);
            this.button_employy_back.Name = "button_employy_back";
            this.button_employy_back.Size = new System.Drawing.Size(64, 64);
            this.button_employy_back.TabIndex = 13;
            this.button_employy_back.UseVisualStyleBackColor = true;
            // 
            // button_employy_update
            // 
            this.button_employy_update.BackgroundImage = global::QuanLyBanHangSieuThi.Properties.Resources._1492426128_icons_edit1;
            this.button_employy_update.Location = new System.Drawing.Point(97, 389);
            this.button_employy_update.Name = "button_employy_update";
            this.button_employy_update.Size = new System.Drawing.Size(64, 64);
            this.button_employy_update.TabIndex = 12;
            this.button_employy_update.UseVisualStyleBackColor = true;
            // 
            // button_employy_insert
            // 
            this.button_employy_insert.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.button_employy_insert.BackgroundImage = global::QuanLyBanHangSieuThi.Properties.Resources._1492425953_icons_add;
            this.button_employy_insert.Location = new System.Drawing.Point(15, 389);
            this.button_employy_insert.Name = "button_employy_insert";
            this.button_employy_insert.Size = new System.Drawing.Size(64, 64);
            this.button_employy_insert.TabIndex = 11;
            this.button_employy_insert.UseVisualStyleBackColor = false;
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.gird_view_employy);
            this.panel1.Location = new System.Drawing.Point(15, 188);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(575, 195);
            this.panel1.TabIndex = 20;
            // 
            // FormEmployy
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.ClientSize = new System.Drawing.Size(602, 485);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.button_employy_search_name);
            this.Controls.Add(this.button_employy_search_id);
            this.Controls.Add(this.button_employy_no);
            this.Controls.Add(this.button_employy_yes);
            this.Controls.Add(this.button_employy_delete);
            this.Controls.Add(this.button_employy_back);
            this.Controls.Add(this.button_employy_update);
            this.Controls.Add(this.button_employy_insert);
            this.Controls.Add(this.edit_text_employy_address);
            this.Controls.Add(this.edit_text_employy_phone);
            this.Controls.Add(this.edit_text_employy_name);
            this.Controls.Add(this.edit_text_employy_id);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "FormEmployy";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Quản Lý Nhân Viên";
            ((System.ComponentModel.ISupportInitialize)(this.gird_view_employy)).EndInit();
            this.panel1.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.DataGridView gird_view_employy;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox edit_text_employy_id;
        private System.Windows.Forms.TextBox edit_text_employy_name;
        private System.Windows.Forms.TextBox edit_text_employy_phone;
        private System.Windows.Forms.TextBox edit_text_employy_address;
        private System.Windows.Forms.Button button_employy_insert;
        private System.Windows.Forms.Button button_employy_update;
        private System.Windows.Forms.Button button_employy_back;
        private System.Windows.Forms.Button button_employy_delete;
        private System.Windows.Forms.Button button_employy_yes;
        private System.Windows.Forms.Button button_employy_no;
        private System.Windows.Forms.Button button_employy_search_id;
        private System.Windows.Forms.Button button_employy_search_name;
        private System.ComponentModel.BackgroundWorker backgroundWorker1;
        private System.Windows.Forms.Panel panel1;
    }
}