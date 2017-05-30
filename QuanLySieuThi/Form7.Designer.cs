namespace QuanLySieuThi
{
    partial class Form7
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
            this.button_statiscal_back = new System.Windows.Forms.Button();
            this.grid_view_statistical = new System.Windows.Forms.DataGridView();
            this.panel1 = new System.Windows.Forms.Panel();
            this.button_statistical_search = new System.Windows.Forms.Button();
            this.combo_box_statistical = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.grid_view_statistical)).BeginInit();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // button_statiscal_back
            // 
            this.button_statiscal_back.BackgroundImage = global::QuanLySieuThi.Properties.Resources._1492426060_icons_share;
            this.button_statiscal_back.Location = new System.Drawing.Point(602, 296);
            this.button_statiscal_back.Name = "button_statiscal_back";
            this.button_statiscal_back.Size = new System.Drawing.Size(64, 64);
            this.button_statiscal_back.TabIndex = 18;
            this.button_statiscal_back.UseVisualStyleBackColor = true;
            // 
            // grid_view_statistical
            // 
            this.grid_view_statistical.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.grid_view_statistical.Location = new System.Drawing.Point(1, 114);
            this.grid_view_statistical.Name = "grid_view_statistical";
            this.grid_view_statistical.Size = new System.Drawing.Size(675, 172);
            this.grid_view_statistical.TabIndex = 17;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.panel1.Controls.Add(this.button_statistical_search);
            this.panel1.Controls.Add(this.combo_box_statistical);
            this.panel1.Location = new System.Drawing.Point(129, 36);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(404, 72);
            this.panel1.TabIndex = 16;
            // 
            // button_statistical_search
            // 
            this.button_statistical_search.BackgroundImage = global::QuanLySieuThi.Properties.Resources._1492418944_icons_search;
            this.button_statistical_search.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.button_statistical_search.Location = new System.Drawing.Point(302, 3);
            this.button_statistical_search.Name = "button_statistical_search";
            this.button_statistical_search.Size = new System.Drawing.Size(64, 64);
            this.button_statistical_search.TabIndex = 1;
            this.button_statistical_search.UseVisualStyleBackColor = true;
            // 
            // combo_box_statistical
            // 
            this.combo_box_statistical.FormattingEnabled = true;
            this.combo_box_statistical.Location = new System.Drawing.Point(42, 26);
            this.combo_box_statistical.Name = "combo_box_statistical";
            this.combo_box_statistical.Size = new System.Drawing.Size(211, 21);
            this.combo_box_statistical.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Arial", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(240, 11);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(190, 22);
            this.label1.TabIndex = 15;
            this.label1.Text = "Thống kê hàng hóa";
            // 
            // Form7
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(677, 370);
            this.Controls.Add(this.button_statiscal_back);
            this.Controls.Add(this.grid_view_statistical);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.label1);
            this.Name = "Form7";
            this.Text = "Form7";
            ((System.ComponentModel.ISupportInitialize)(this.grid_view_statistical)).EndInit();
            this.panel1.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button button_statiscal_back;
        private System.Windows.Forms.DataGridView grid_view_statistical;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button button_statistical_search;
        private System.Windows.Forms.ComboBox combo_box_statistical;
        private System.Windows.Forms.Label label1;
    }
}