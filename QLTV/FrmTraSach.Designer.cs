﻿namespace QLTV
{
    partial class FrmTraSach
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
            this.txtmaphieubg = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.cbtinhtrangsach = new System.Windows.Forms.ComboBox();
            this.dtpngaytra = new System.Windows.Forms.DateTimePicker();
            this.btntra = new System.Windows.Forms.Button();
            this.txtmadg = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.txtmasach = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.txttendg = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.txtngayquahan = new System.Windows.Forms.TextBox();
            this.label10 = new System.Windows.Forms.Label();
            this.txtmanv = new System.Windows.Forms.TextBox();
            this.dtpdu = new System.Windows.Forms.DateTimePicker();
            this.lbltienphat = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(53, 53);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(75, 15);
            this.label1.TabIndex = 0;
            this.label1.Text = "Mã Phiếu BG";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.label1.UseMnemonic = false;
            // 
            // txtmaphieubg
            // 
            this.txtmaphieubg.Enabled = false;
            this.txtmaphieubg.Location = new System.Drawing.Point(159, 48);
            this.txtmaphieubg.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtmaphieubg.Name = "txtmaphieubg";
            this.txtmaphieubg.ReadOnly = true;
            this.txtmaphieubg.Size = new System.Drawing.Size(213, 23);
            this.txtmaphieubg.TabIndex = 1;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(406, 159);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(53, 15);
            this.label2.TabIndex = 2;
            this.label2.Text = "Ngày Trả";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.label2.UseMnemonic = false;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(51, 214);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(79, 15);
            this.label3.TabIndex = 4;
            this.label3.Text = "Mã nhân viên";
            // 
            // cbtinhtrangsach
            // 
            this.cbtinhtrangsach.FormattingEnabled = true;
            this.cbtinhtrangsach.Items.AddRange(new object[] {
            "Nguyên Vẹn",
            "Hỏng",
            "Mất"});
            this.cbtinhtrangsach.Location = new System.Drawing.Point(153, 267);
            this.cbtinhtrangsach.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.cbtinhtrangsach.Name = "cbtinhtrangsach";
            this.cbtinhtrangsach.Size = new System.Drawing.Size(219, 23);
            this.cbtinhtrangsach.TabIndex = 5;
            this.cbtinhtrangsach.SelectedIndexChanged += new System.EventHandler(this.comboBox1_SelectedIndexChanged);
            // 
            // dtpngaytra
            // 
            this.dtpngaytra.CustomFormat = "MM-dd-yyyy";
            this.dtpngaytra.Enabled = false;
            this.dtpngaytra.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpngaytra.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.dtpngaytra.Location = new System.Drawing.Point(515, 159);
            this.dtpngaytra.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.dtpngaytra.Name = "dtpngaytra";
            this.dtpngaytra.Size = new System.Drawing.Size(219, 23);
            this.dtpngaytra.TabIndex = 6;
            // 
            // btntra
            // 
            this.btntra.Location = new System.Drawing.Point(689, 322);
            this.btntra.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btntra.Name = "btntra";
            this.btntra.Size = new System.Drawing.Size(135, 22);
            this.btntra.TabIndex = 7;
            this.btntra.Text = "Trả Sách";
            this.btntra.UseVisualStyleBackColor = true;
            this.btntra.Click += new System.EventHandler(this.btntra_Click);
            // 
            // txtmadg
            // 
            this.txtmadg.Enabled = false;
            this.txtmadg.Location = new System.Drawing.Point(153, 95);
            this.txtmadg.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtmadg.Name = "txtmadg";
            this.txtmadg.ReadOnly = true;
            this.txtmadg.Size = new System.Drawing.Size(219, 23);
            this.txtmadg.TabIndex = 9;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(65, 100);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(63, 15);
            this.label4.TabIndex = 8;
            this.label4.Text = "Mã thẻ DG";
            this.label4.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.label4.UseMnemonic = false;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(37, 269);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(90, 15);
            this.label5.TabIndex = 10;
            this.label5.Text = "Tình Trạng Sách";
            this.label5.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.label5.UseMnemonic = false;
            // 
            // txtmasach
            // 
            this.txtmasach.Enabled = false;
            this.txtmasach.Location = new System.Drawing.Point(517, 95);
            this.txtmasach.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtmasach.Name = "txtmasach";
            this.txtmasach.ReadOnly = true;
            this.txtmasach.Size = new System.Drawing.Size(213, 23);
            this.txtmasach.TabIndex = 15;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(394, 98);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(90, 15);
            this.label7.TabIndex = 14;
            this.label7.Text = "Mã Quyển Sách";
            this.label7.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.label7.UseMnemonic = false;
            // 
            // txttendg
            // 
            this.txttendg.Enabled = false;
            this.txttendg.Location = new System.Drawing.Point(517, 46);
            this.txttendg.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txttendg.Name = "txttendg";
            this.txttendg.ReadOnly = true;
            this.txttendg.Size = new System.Drawing.Size(213, 23);
            this.txttendg.TabIndex = 17;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(406, 51);
            this.label8.Name = "label8";
            this.label8.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.label8.Size = new System.Drawing.Size(67, 15);
            this.label8.TabIndex = 16;
            this.label8.Text = "Tên độc giả";
            this.label8.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.label8.UseMnemonic = false;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(26, 161);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(97, 15);
            this.label9.TabIndex = 18;
            this.label9.Text = "Ngày Dự Kiến Trả";
            this.label9.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.label9.UseMnemonic = false;
            // 
            // txtngayquahan
            // 
            this.txtngayquahan.ForeColor = System.Drawing.SystemColors.WindowText;
            this.txtngayquahan.Location = new System.Drawing.Point(515, 209);
            this.txtngayquahan.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtngayquahan.Name = "txtngayquahan";
            this.txtngayquahan.ReadOnly = true;
            this.txtngayquahan.Size = new System.Drawing.Size(219, 23);
            this.txtngayquahan.TabIndex = 21;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(394, 212);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(94, 15);
            this.label10.TabIndex = 20;
            this.label10.Text = "số ngày quá hạn";
            this.label10.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.label10.UseMnemonic = false;
            // 
            // txtmanv
            // 
            this.txtmanv.Location = new System.Drawing.Point(153, 212);
            this.txtmanv.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtmanv.Name = "txtmanv";
            this.txtmanv.Size = new System.Drawing.Size(219, 23);
            this.txtmanv.TabIndex = 11;
            // 
            // dtpdu
            // 
            this.dtpdu.Enabled = false;
            this.dtpdu.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpdu.Location = new System.Drawing.Point(153, 159);
            this.dtpdu.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.dtpdu.Name = "dtpdu";
            this.dtpdu.Size = new System.Drawing.Size(219, 23);
            this.dtpdu.TabIndex = 23;
            // 
            // lbltienphat
            // 
            this.lbltienphat.AutoSize = true;
            this.lbltienphat.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lbltienphat.ForeColor = System.Drawing.Color.Red;
            this.lbltienphat.Location = new System.Drawing.Point(412, 270);
            this.lbltienphat.Name = "lbltienphat";
            this.lbltienphat.Size = new System.Drawing.Size(77, 21);
            this.lbltienphat.TabIndex = 24;
            this.lbltienphat.Text = "Tiền Phạt:";
            this.lbltienphat.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.lbltienphat.UseMnemonic = false;
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(689, 273);
            this.textBox1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(162, 23);
            this.textBox1.TabIndex = 25;
            // 
            // FrmTraSach
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(902, 353);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.lbltienphat);
            this.Controls.Add(this.dtpdu);
            this.Controls.Add(this.txtngayquahan);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.txttendg);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.txtmasach);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.txtmanv);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.txtmadg);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.btntra);
            this.Controls.Add(this.dtpngaytra);
            this.Controls.Add(this.cbtinhtrangsach);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txtmaphieubg);
            this.Controls.Add(this.label1);
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "FrmTraSach";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "FrmTraSach";
            this.Load += new System.EventHandler(this.FrmTraSach_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtmaphieubg;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ComboBox cbtinhtrangsach;
        private System.Windows.Forms.DateTimePicker dtpngaytra;
        private System.Windows.Forms.Button btntra;
        private System.Windows.Forms.TextBox txtmadg;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txtmasach;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox txttendg;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.TextBox txtngayquahan;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.TextBox txtmanv;
        private System.Windows.Forms.DateTimePicker dtpdu;
        private System.Windows.Forms.Label lbltienphat;
        private System.Windows.Forms.TextBox textBox1;
    }
}