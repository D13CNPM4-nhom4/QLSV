﻿namespace QLSV
{
    partial class QLDiem
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
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.cbbmonhoc = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.btnchon = new System.Windows.Forms.Button();
            this.cbbchonlop = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.textBox3 = new System.Windows.Forms.TextBox();
            this.button3 = new System.Windows.Forms.Button();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.button2 = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.button4 = new System.Windows.Forms.Button();
            this.button5 = new System.Windows.Forms.Button();
            this.btncapnhat = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.cbbmonhoc);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.cbbchonlop);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Location = new System.Drawing.Point(12, 39);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(377, 81);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "DANH SÁCH CÁC LỚP ĐANG QUẢN LÝ";
            // 
            // cbbmonhoc
            // 
            this.cbbmonhoc.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbbmonhoc.FormattingEnabled = true;
            this.cbbmonhoc.Location = new System.Drawing.Point(81, 25);
            this.cbbmonhoc.Name = "cbbmonhoc";
            this.cbbmonhoc.Size = new System.Drawing.Size(204, 21);
            this.cbbmonhoc.TabIndex = 8;
            this.cbbmonhoc.SelectedIndexChanged += new System.EventHandler(this.cbbchonmon_SelectedIndexChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(6, 28);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(69, 13);
            this.label2.TabIndex = 7;
            this.label2.Text = "CHỌN MÔN:";
            // 
            // btnchon
            // 
            this.btnchon.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.btnchon.Location = new System.Drawing.Point(616, 10);
            this.btnchon.Name = "btnchon";
            this.btnchon.Size = new System.Drawing.Size(83, 23);
            this.btnchon.TabIndex = 2;
            this.btnchon.Text = "XUẤT EXCEL";
            this.btnchon.UseVisualStyleBackColor = false;
            this.btnchon.Click += new System.EventHandler(this.btnchon_Click);
            // 
            // cbbchonlop
            // 
            this.cbbchonlop.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbbchonlop.FormattingEnabled = true;
            this.cbbchonlop.Location = new System.Drawing.Point(81, 52);
            this.cbbchonlop.Name = "cbbchonlop";
            this.cbbchonlop.Size = new System.Drawing.Size(204, 21);
            this.cbbchonlop.TabIndex = 1;
            this.cbbchonlop.SelectedIndexChanged += new System.EventHandler(this.cbbchonlop_SelectedIndexChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(10, 55);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(65, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "CHỌN LỚP:";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.textBox3);
            this.groupBox2.Controls.Add(this.button3);
            this.groupBox2.Location = new System.Drawing.Point(395, 39);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(226, 81);
            this.groupBox2.TabIndex = 3;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "TÌM KIẾM";
            // 
            // textBox3
            // 
            this.textBox3.Location = new System.Drawing.Point(6, 37);
            this.textBox3.Name = "textBox3";
            this.textBox3.Size = new System.Drawing.Size(139, 20);
            this.textBox3.TabIndex = 8;
            // 
            // button3
            // 
            this.button3.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.button3.Location = new System.Drawing.Point(151, 34);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(69, 23);
            this.button3.TabIndex = 4;
            this.button3.Text = "TÌM";
            this.button3.UseVisualStyleBackColor = false;
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.button2);
            this.groupBox3.Controls.Add(this.button1);
            this.groupBox3.Location = new System.Drawing.Point(627, 39);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(344, 81);
            this.groupBox3.TabIndex = 4;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "THỐNG KÊ";
            // 
            // button2
            // 
            this.button2.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.button2.Location = new System.Drawing.Point(188, 24);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(128, 42);
            this.button2.TabIndex = 1;
            this.button2.Text = "DANH SÁCH HỌC SINH ĐẠT";
            this.button2.UseVisualStyleBackColor = false;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.button1.Location = new System.Drawing.Point(32, 24);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(128, 42);
            this.button1.TabIndex = 0;
            this.button1.Text = "DANH SÁCH HỌC SINH HỌC LẠI";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // dataGridView1
            // 
            this.dataGridView1.BackgroundColor = System.Drawing.SystemColors.ButtonHighlight;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(21, 126);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(950, 410);
            this.dataGridView1.TabIndex = 5;
            this.dataGridView1.CellEndEdit += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellEndEdit);
            this.dataGridView1.SelectionChanged += new System.EventHandler(this.dataGridView1_SelectionChanged);
            // 
            // button4
            // 
            this.button4.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.button4.Location = new System.Drawing.Point(786, 10);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(80, 23);
            this.button4.TabIndex = 6;
            this.button4.Text = "LƯU LẠI";
            this.button4.UseVisualStyleBackColor = false;
            this.button4.Click += new System.EventHandler(this.button4_Click);
            // 
            // button5
            // 
            this.button5.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.button5.Location = new System.Drawing.Point(872, 10);
            this.button5.Name = "button5";
            this.button5.Size = new System.Drawing.Size(75, 23);
            this.button5.TabIndex = 7;
            this.button5.Text = "QUAY LẠI";
            this.button5.UseVisualStyleBackColor = false;
            this.button5.Click += new System.EventHandler(this.button5_Click);
            // 
            // btncapnhat
            // 
            this.btncapnhat.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.btncapnhat.Location = new System.Drawing.Point(705, 10);
            this.btncapnhat.Name = "btncapnhat";
            this.btncapnhat.Size = new System.Drawing.Size(75, 23);
            this.btncapnhat.TabIndex = 8;
            this.btncapnhat.Text = "CẬP NHẬT";
            this.btncapnhat.UseVisualStyleBackColor = false;
            this.btncapnhat.Click += new System.EventHandler(this.btncapnhat_Click);
            // 
            // QLDiem
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.ClientSize = new System.Drawing.Size(983, 548);
            this.Controls.Add(this.btncapnhat);
            this.Controls.Add(this.button5);
            this.Controls.Add(this.btnchon);
            this.Controls.Add(this.button4);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Name = "QLDiem";
            this.Text = "QLDiem";
            this.Load += new System.EventHandler(this.QLDiem_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox3.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button btnchon;
        private System.Windows.Forms.ComboBox cbbchonlop;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.TextBox textBox3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox cbbmonhoc;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.Button button5;
        private System.Windows.Forms.Button btncapnhat;
    }
}