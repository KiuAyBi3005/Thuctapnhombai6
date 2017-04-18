namespace QuanLyBanHangSieuThi
{
    partial class FormSearch
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
            this.combo_box_search = new System.Windows.Forms.ComboBox();
            this.grid_view_search = new System.Windows.Forms.DataGridView();
            this.button_search_search = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.grid_view_search)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Arial", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(154, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(202, 24);
            this.label1.TabIndex = 0;
            this.label1.Text = "Tìm kiếm hàng hóa";
            // 
            // combo_box_search
            // 
            this.combo_box_search.FormattingEnabled = true;
            this.combo_box_search.Location = new System.Drawing.Point(159, 52);
            this.combo_box_search.Name = "combo_box_search";
            this.combo_box_search.Size = new System.Drawing.Size(159, 21);
            this.combo_box_search.TabIndex = 1;
            // 
            // grid_view_search
            // 
            this.grid_view_search.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.grid_view_search.Location = new System.Drawing.Point(13, 96);
            this.grid_view_search.Name = "grid_view_search";
            this.grid_view_search.Size = new System.Drawing.Size(473, 150);
            this.grid_view_search.TabIndex = 2;
            // 
            // button_search_search
            // 
            this.button_search_search.BackColor = System.Drawing.SystemColors.ControlLight;
            this.button_search_search.BackgroundImage = global::QuanLyBanHangSieuThi.Properties.Resources._1492429049_icons_search;
            this.button_search_search.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.button_search_search.Location = new System.Drawing.Point(324, 45);
            this.button_search_search.Name = "button_search_search";
            this.button_search_search.Size = new System.Drawing.Size(32, 32);
            this.button_search_search.TabIndex = 3;
            this.button_search_search.UseVisualStyleBackColor = false;
            // 
            // FormSearch
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.ClientSize = new System.Drawing.Size(498, 266);
            this.Controls.Add(this.button_search_search);
            this.Controls.Add(this.grid_view_search);
            this.Controls.Add(this.combo_box_search);
            this.Controls.Add(this.label1);
            this.Name = "FormSearch";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Tìm kiếm";
            ((System.ComponentModel.ISupportInitialize)(this.grid_view_search)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox combo_box_search;
        private System.Windows.Forms.DataGridView grid_view_search;
        private System.Windows.Forms.Button button_search_search;
    }
}