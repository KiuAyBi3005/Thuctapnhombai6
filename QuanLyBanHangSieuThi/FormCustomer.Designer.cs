namespace QuanLyBanHangSieuThi
{
    partial class FormCustomer
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.edit_text_customer_id = new System.Windows.Forms.TextBox();
            this.edit_text_customer_name = new System.Windows.Forms.TextBox();
            this.edit_text_customer_address = new System.Windows.Forms.TextBox();
            this.edit_text_customer_phone = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.grid_view_customer = new System.Windows.Forms.DataGridView();
            this.button_customer_search_name = new System.Windows.Forms.Button();
            this.button_customer_search_id = new System.Windows.Forms.Button();
            this.button_customer_back = new System.Windows.Forms.Button();
            this.button_customer_no = new System.Windows.Forms.Button();
            this.button_customer_yes = new System.Windows.Forms.Button();
            this.button_customer_delete = new System.Windows.Forms.Button();
            this.button_customer_update = new System.Windows.Forms.Button();
            this.button_customer_insert = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.grid_view_customer)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Arial", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(210, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(206, 22);
            this.label1.TabIndex = 0;
            this.label1.Text = "Quản Lý Khách Hàng";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 75);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(82, 13);
            this.label2.TabIndex = 4;
            this.label2.Text = "Mã khách hàng";
            // 
            // edit_text_customer_id
            // 
            this.edit_text_customer_id.Location = new System.Drawing.Point(111, 72);
            this.edit_text_customer_id.Name = "edit_text_customer_id";
            this.edit_text_customer_id.Size = new System.Drawing.Size(155, 20);
            this.edit_text_customer_id.TabIndex = 8;
            // 
            // edit_text_customer_name
            // 
            this.edit_text_customer_name.Location = new System.Drawing.Point(111, 152);
            this.edit_text_customer_name.Name = "edit_text_customer_name";
            this.edit_text_customer_name.Size = new System.Drawing.Size(155, 20);
            this.edit_text_customer_name.TabIndex = 9;
            // 
            // edit_text_customer_address
            // 
            this.edit_text_customer_address.Location = new System.Drawing.Point(435, 149);
            this.edit_text_customer_address.Name = "edit_text_customer_address";
            this.edit_text_customer_address.Size = new System.Drawing.Size(155, 20);
            this.edit_text_customer_address.TabIndex = 10;
            // 
            // edit_text_customer_phone
            // 
            this.edit_text_customer_phone.Location = new System.Drawing.Point(435, 72);
            this.edit_text_customer_phone.Name = "edit_text_customer_phone";
            this.edit_text_customer_phone.Size = new System.Drawing.Size(155, 20);
            this.edit_text_customer_phone.TabIndex = 11;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(359, 75);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(70, 13);
            this.label4.TabIndex = 12;
            this.label4.Text = "Số điện thoại";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(359, 152);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(40, 13);
            this.label5.TabIndex = 13;
            this.label5.Text = "Địa chỉ";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(12, 152);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(86, 13);
            this.label3.TabIndex = 14;
            this.label3.Text = "Tên khách hàng";
            // 
            // grid_view_customer
            // 
            this.grid_view_customer.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.grid_view_customer.Location = new System.Drawing.Point(15, 193);
            this.grid_view_customer.Name = "grid_view_customer";
            this.grid_view_customer.Size = new System.Drawing.Size(575, 186);
            this.grid_view_customer.TabIndex = 15;
            // 
            // button_customer_search_name
            // 
            this.button_customer_search_name.BackColor = System.Drawing.SystemColors.ControlLight;
            this.button_customer_search_name.BackgroundImage = global::QuanLyBanHangSieuThi.Properties.Resources._1492429049_icons_search;
            this.button_customer_search_name.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.button_customer_search_name.Location = new System.Drawing.Point(285, 142);
            this.button_customer_search_name.Name = "button_customer_search_name";
            this.button_customer_search_name.Size = new System.Drawing.Size(32, 32);
            this.button_customer_search_name.TabIndex = 23;
            this.button_customer_search_name.UseVisualStyleBackColor = false;
            // 
            // button_customer_search_id
            // 
            this.button_customer_search_id.BackColor = System.Drawing.SystemColors.ControlLight;
            this.button_customer_search_id.BackgroundImage = global::QuanLyBanHangSieuThi.Properties.Resources._1492429049_icons_search;
            this.button_customer_search_id.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.button_customer_search_id.Location = new System.Drawing.Point(285, 65);
            this.button_customer_search_id.Name = "button_customer_search_id";
            this.button_customer_search_id.Size = new System.Drawing.Size(32, 32);
            this.button_customer_search_id.TabIndex = 22;
            this.button_customer_search_id.UseVisualStyleBackColor = false;
            // 
            // button_customer_back
            // 
            this.button_customer_back.BackgroundImage = global::QuanLyBanHangSieuThi.Properties.Resources._1492426060_icons_share;
            this.button_customer_back.Location = new System.Drawing.Point(526, 409);
            this.button_customer_back.Name = "button_customer_back";
            this.button_customer_back.Size = new System.Drawing.Size(64, 64);
            this.button_customer_back.TabIndex = 21;
            this.button_customer_back.UseVisualStyleBackColor = true;
            // 
            // button_customer_no
            // 
            this.button_customer_no.BackgroundImage = global::QuanLyBanHangSieuThi.Properties.Resources._1492426077_icons_exit;
            this.button_customer_no.Location = new System.Drawing.Point(447, 409);
            this.button_customer_no.Name = "button_customer_no";
            this.button_customer_no.Size = new System.Drawing.Size(64, 64);
            this.button_customer_no.TabIndex = 20;
            this.button_customer_no.UseVisualStyleBackColor = true;
            // 
            // button_customer_yes
            // 
            this.button_customer_yes.BackgroundImage = global::QuanLyBanHangSieuThi.Properties.Resources._1492426098_icons_check;
            this.button_customer_yes.Location = new System.Drawing.Point(365, 409);
            this.button_customer_yes.Name = "button_customer_yes";
            this.button_customer_yes.Size = new System.Drawing.Size(64, 64);
            this.button_customer_yes.TabIndex = 19;
            this.button_customer_yes.UseVisualStyleBackColor = true;
            // 
            // button_customer_delete
            // 
            this.button_customer_delete.BackgroundImage = global::QuanLyBanHangSieuThi.Properties.Resources._1492427262_icons_delete;
            this.button_customer_delete.Location = new System.Drawing.Point(185, 409);
            this.button_customer_delete.Name = "button_customer_delete";
            this.button_customer_delete.Size = new System.Drawing.Size(64, 64);
            this.button_customer_delete.TabIndex = 18;
            this.button_customer_delete.UseVisualStyleBackColor = true;
            // 
            // button_customer_update
            // 
            this.button_customer_update.BackgroundImage = global::QuanLyBanHangSieuThi.Properties.Resources._1492426128_icons_edit1;
            this.button_customer_update.Location = new System.Drawing.Point(97, 409);
            this.button_customer_update.Name = "button_customer_update";
            this.button_customer_update.Size = new System.Drawing.Size(64, 64);
            this.button_customer_update.TabIndex = 17;
            this.button_customer_update.UseVisualStyleBackColor = true;
            // 
            // button_customer_insert
            // 
            this.button_customer_insert.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.button_customer_insert.BackgroundImage = global::QuanLyBanHangSieuThi.Properties.Resources._1492425953_icons_add;
            this.button_customer_insert.Location = new System.Drawing.Point(15, 409);
            this.button_customer_insert.Name = "button_customer_insert";
            this.button_customer_insert.Size = new System.Drawing.Size(64, 64);
            this.button_customer_insert.TabIndex = 16;
            this.button_customer_insert.UseVisualStyleBackColor = false;
            // 
            // FormCustomer
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.ClientSize = new System.Drawing.Size(602, 485);
            this.Controls.Add(this.button_customer_search_name);
            this.Controls.Add(this.button_customer_search_id);
            this.Controls.Add(this.button_customer_back);
            this.Controls.Add(this.button_customer_no);
            this.Controls.Add(this.button_customer_yes);
            this.Controls.Add(this.button_customer_delete);
            this.Controls.Add(this.button_customer_update);
            this.Controls.Add(this.button_customer_insert);
            this.Controls.Add(this.grid_view_customer);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.edit_text_customer_phone);
            this.Controls.Add(this.edit_text_customer_address);
            this.Controls.Add(this.edit_text_customer_name);
            this.Controls.Add(this.edit_text_customer_id);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "FormCustomer";
            this.Text = "Quản lý khách hàng";
            ((System.ComponentModel.ISupportInitialize)(this.grid_view_customer)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox edit_text_customer_id;
        private System.Windows.Forms.TextBox edit_text_customer_name;
        private System.Windows.Forms.TextBox edit_text_customer_address;
        private System.Windows.Forms.TextBox edit_text_customer_phone;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.DataGridView grid_view_customer;
        private System.Windows.Forms.Button button_customer_insert;
        private System.Windows.Forms.Button button_customer_update;
        private System.Windows.Forms.Button button_customer_delete;
        private System.Windows.Forms.Button button_customer_yes;
        private System.Windows.Forms.Button button_customer_no;
        private System.Windows.Forms.Button button_customer_back;
        private System.Windows.Forms.Button button_customer_search_id;
        private System.Windows.Forms.Button button_customer_search_name;
    }
}