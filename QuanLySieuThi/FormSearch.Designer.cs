﻿namespace QuanLySieuThi
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
            this.button_search_search = new System.Windows.Forms.Button();
            this.grid_view_search = new System.Windows.Forms.DataGridView();
            this.combo_box_search = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.grid_view_search)).BeginInit();
            this.SuspendLayout();
            // 
            // button_search_search
            // 
            this.button_search_search.BackColor = System.Drawing.SystemColors.ControlLight;
            this.button_search_search.BackgroundImage = global::QuanLySieuThi.Properties.Resources._1492428977_search;
            this.button_search_search.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.button_search_search.Location = new System.Drawing.Point(324, 51);
            this.button_search_search.Name = "button_search_search";
            this.button_search_search.Size = new System.Drawing.Size(32, 32);
            this.button_search_search.TabIndex = 7;
            this.button_search_search.UseVisualStyleBackColor = false;
            // 
            // grid_view_search
            // 
            this.grid_view_search.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.grid_view_search.Location = new System.Drawing.Point(13, 102);
            this.grid_view_search.Name = "grid_view_search";
            this.grid_view_search.Size = new System.Drawing.Size(473, 150);
            this.grid_view_search.TabIndex = 6;
            // 
            // combo_box_search
            // 
            this.combo_box_search.FormattingEnabled = true;
            this.combo_box_search.Location = new System.Drawing.Point(159, 58);
            this.combo_box_search.Name = "combo_box_search";
            this.combo_box_search.Size = new System.Drawing.Size(159, 21);
            this.combo_box_search.TabIndex = 5;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Arial", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(154, 15);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(202, 24);
            this.label1.TabIndex = 4;
            this.label1.Text = "Tìm kiếm hàng hóa";
            // 
            // Form5
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(498, 266);
            this.Controls.Add(this.button_search_search);
            this.Controls.Add(this.grid_view_search);
            this.Controls.Add(this.combo_box_search);
            this.Controls.Add(this.label1);
            this.Name = "Form5";
            this.Text = "Form5";
            ((System.ComponentModel.ISupportInitialize)(this.grid_view_search)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button button_search_search;
        private System.Windows.Forms.DataGridView grid_view_search;
        private System.Windows.Forms.ComboBox combo_box_search;
        private System.Windows.Forms.Label label1;
    }
}