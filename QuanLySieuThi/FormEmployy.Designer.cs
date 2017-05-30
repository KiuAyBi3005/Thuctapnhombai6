namespace QuanLySieuThi
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
            this.panel1 = new System.Windows.Forms.Panel();
            this.grid_view_employy = new System.Windows.Forms.DataGridView();
            this.button_employy_search_name = new System.Windows.Forms.Button();
            this.button_employy_search_id = new System.Windows.Forms.Button();
            this.button_employy_delete = new System.Windows.Forms.Button();
            this.button_employy_back = new System.Windows.Forms.Button();
            this.button_employy_update = new System.Windows.Forms.Button();
            this.button_employy_insert = new System.Windows.Forms.Button();
            this.edit_text_employy_address = new System.Windows.Forms.TextBox();
            this.edit_text_employy_phone = new System.Windows.Forms.TextBox();
            this.edit_text_employy_name = new System.Windows.Forms.TextBox();
            this.edit_text_employy_id = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.grid_view_employy)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.grid_view_employy);
            this.panel1.Location = new System.Drawing.Point(15, 199);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(575, 195);
            this.panel1.TabIndex = 38;
            // 
            // grid_view_employy
            // 
            this.grid_view_employy.AccessibleRole = System.Windows.Forms.AccessibleRole.Cursor;
            this.grid_view_employy.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.grid_view_employy.Location = new System.Drawing.Point(3, 3);
            this.grid_view_employy.Name = "grid_view_employy";
            this.grid_view_employy.Size = new System.Drawing.Size(568, 186);
            this.grid_view_employy.TabIndex = 1;
            // 
            // button_employy_search_name
            // 
            this.button_employy_search_name.BackColor = System.Drawing.SystemColors.ControlLight;
            this.button_employy_search_name.BackgroundImage = global::QuanLySieuThi.Properties.Resources._1492428977_search;
            this.button_employy_search_name.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.button_employy_search_name.Location = new System.Drawing.Point(258, 132);
            this.button_employy_search_name.Name = "button_employy_search_name";
            this.button_employy_search_name.Size = new System.Drawing.Size(32, 32);
            this.button_employy_search_name.TabIndex = 37;
            this.button_employy_search_name.UseVisualStyleBackColor = false;
            // 
            // button_employy_search_id
            // 
            this.button_employy_search_id.BackColor = System.Drawing.SystemColors.ControlLight;
            this.button_employy_search_id.BackgroundImage = global::QuanLySieuThi.Properties.Resources._1492428977_search;
            this.button_employy_search_id.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.button_employy_search_id.Location = new System.Drawing.Point(258, 76);
            this.button_employy_search_id.Name = "button_employy_search_id";
            this.button_employy_search_id.Size = new System.Drawing.Size(32, 32);
            this.button_employy_search_id.TabIndex = 36;
            this.button_employy_search_id.UseVisualStyleBackColor = false;
            // 
            // button_employy_delete
            // 
            this.button_employy_delete.BackgroundImage = global::QuanLySieuThi.Properties.Resources._1492427262_icons_delete;
            this.button_employy_delete.Location = new System.Drawing.Point(346, 409);
            this.button_employy_delete.Name = "button_employy_delete";
            this.button_employy_delete.Size = new System.Drawing.Size(64, 64);
            this.button_employy_delete.TabIndex = 33;
            this.button_employy_delete.UseVisualStyleBackColor = true;
            this.button_employy_delete.Click += new System.EventHandler(this.button_employy_delete_Click);
            // 
            // button_employy_back
            // 
            this.button_employy_back.BackgroundImage = global::QuanLySieuThi.Properties.Resources._1492426060_icons_share;
            this.button_employy_back.Location = new System.Drawing.Point(522, 409);
            this.button_employy_back.Name = "button_employy_back";
            this.button_employy_back.Size = new System.Drawing.Size(64, 64);
            this.button_employy_back.TabIndex = 32;
            this.button_employy_back.UseVisualStyleBackColor = true;
            this.button_employy_back.Click += new System.EventHandler(this.button_employy_back_Click);
            // 
            // button_employy_update
            // 
            this.button_employy_update.BackgroundImage = global::QuanLySieuThi.Properties.Resources._1492426128_icons_edit;
            this.button_employy_update.Location = new System.Drawing.Point(188, 409);
            this.button_employy_update.Name = "button_employy_update";
            this.button_employy_update.Size = new System.Drawing.Size(64, 64);
            this.button_employy_update.TabIndex = 31;
            this.button_employy_update.UseVisualStyleBackColor = true;
            this.button_employy_update.Click += new System.EventHandler(this.button_employy_update_Click);
            // 
            // button_employy_insert
            // 
            this.button_employy_insert.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.button_employy_insert.BackgroundImage = global::QuanLySieuThi.Properties.Resources._1492425953_icons_add;
            this.button_employy_insert.Location = new System.Drawing.Point(20, 409);
            this.button_employy_insert.Name = "button_employy_insert";
            this.button_employy_insert.Size = new System.Drawing.Size(64, 64);
            this.button_employy_insert.TabIndex = 30;
            this.button_employy_insert.UseVisualStyleBackColor = false;
            this.button_employy_insert.Click += new System.EventHandler(this.button_employy_insert_Click);
            // 
            // edit_text_employy_address
            // 
            this.edit_text_employy_address.Location = new System.Drawing.Point(427, 143);
            this.edit_text_employy_address.Name = "edit_text_employy_address";
            this.edit_text_employy_address.Size = new System.Drawing.Size(156, 20);
            this.edit_text_employy_address.TabIndex = 29;
            // 
            // edit_text_employy_phone
            // 
            this.edit_text_employy_phone.Location = new System.Drawing.Point(427, 86);
            this.edit_text_employy_phone.Name = "edit_text_employy_phone";
            this.edit_text_employy_phone.Size = new System.Drawing.Size(156, 20);
            this.edit_text_employy_phone.TabIndex = 28;
            // 
            // edit_text_employy_name
            // 
            this.edit_text_employy_name.Location = new System.Drawing.Point(97, 139);
            this.edit_text_employy_name.Name = "edit_text_employy_name";
            this.edit_text_employy_name.Size = new System.Drawing.Size(155, 20);
            this.edit_text_employy_name.TabIndex = 27;
            // 
            // edit_text_employy_id
            // 
            this.edit_text_employy_id.Location = new System.Drawing.Point(97, 83);
            this.edit_text_employy_id.Name = "edit_text_employy_id";
            this.edit_text_employy_id.Size = new System.Drawing.Size(155, 20);
            this.edit_text_employy_id.TabIndex = 26;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(343, 150);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(40, 13);
            this.label5.TabIndex = 25;
            this.label5.Text = "Địa chỉ";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(332, 93);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(70, 13);
            this.label4.TabIndex = 24;
            this.label4.Text = "Số điện thoại";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(12, 146);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(76, 13);
            this.label3.TabIndex = 23;
            this.label3.Text = "Tên nhân viên";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 86);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(72, 13);
            this.label2.TabIndex = 22;
            this.label2.Text = "Mã nhân viên";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Arial", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(215, 20);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(187, 22);
            this.label1.TabIndex = 21;
            this.label1.Text = "Quản Lý Nhân Viên";
            // 
            // FormEmployy
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(602, 485);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.button_employy_search_name);
            this.Controls.Add(this.button_employy_search_id);
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
            this.Text = "Form3";
            this.panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.grid_view_employy)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.DataGridView grid_view_employy;
        private System.Windows.Forms.Button button_employy_search_name;
        private System.Windows.Forms.Button button_employy_search_id;
        private System.Windows.Forms.Button button_employy_delete;
        private System.Windows.Forms.Button button_employy_back;
        private System.Windows.Forms.Button button_employy_update;
        private System.Windows.Forms.Button button_employy_insert;
        private System.Windows.Forms.TextBox edit_text_employy_address;
        private System.Windows.Forms.TextBox edit_text_employy_phone;
        private System.Windows.Forms.TextBox edit_text_employy_name;
        private System.Windows.Forms.TextBox edit_text_employy_id;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
    }
}