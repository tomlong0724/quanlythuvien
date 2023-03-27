
namespace QLTV
{
    partial class Form1
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            lblAccount = new System.Windows.Forms.Label();
            lblPassword = new System.Windows.Forms.Label();
            txtAccount = new System.Windows.Forms.TextBox();
            txtPassword = new System.Windows.Forms.TextBox();
            btnLogin = new System.Windows.Forms.Button();
            lblIncorrect = new System.Windows.Forms.Label();
            ckbShowPassword = new System.Windows.Forms.CheckBox();
            btnExit = new System.Windows.Forms.Button();
            pictureBox1 = new System.Windows.Forms.PictureBox();
            lblTime = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // lblAccount
            // 
            lblAccount.AutoSize = true;
            lblAccount.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            lblAccount.Location = new System.Drawing.Point(12, 120);
            lblAccount.Name = "lblAccount";
            lblAccount.Size = new System.Drawing.Size(55, 16);
            lblAccount.TabIndex = 0;
            lblAccount.Text = "Account";
            // 
            // lblPassword
            // 
            lblPassword.AutoSize = true;
            lblPassword.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            lblPassword.Location = new System.Drawing.Point(12, 157);
            lblPassword.Name = "lblPassword";
            lblPassword.Size = new System.Drawing.Size(67, 16);
            lblPassword.TabIndex = 1;
            lblPassword.Text = "Password";
            // 
            // txtAccount
            // 
            txtAccount.Location = new System.Drawing.Point(99, 119);
            txtAccount.Name = "txtAccount";
            txtAccount.Size = new System.Drawing.Size(342, 23);
            txtAccount.TabIndex = 2;
            // 
            // txtPassword
            // 
            txtPassword.Location = new System.Drawing.Point(99, 156);
            txtPassword.Name = "txtPassword";
            txtPassword.Size = new System.Drawing.Size(342, 23);
            txtPassword.TabIndex = 3;
            txtPassword.UseSystemPasswordChar = true;
            // 
            // btnLogin
            // 
            btnLogin.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            btnLogin.Location = new System.Drawing.Point(447, 120);
            btnLogin.Name = "btnLogin";
            btnLogin.Size = new System.Drawing.Size(75, 60);
            btnLogin.TabIndex = 4;
            btnLogin.Text = "Login";
            btnLogin.UseVisualStyleBackColor = true;
            btnLogin.Click += btnLogin_Click;
            // 
            // lblIncorrect
            // 
            lblIncorrect.AutoSize = true;
            lblIncorrect.ForeColor = System.Drawing.Color.Red;
            lblIncorrect.Location = new System.Drawing.Point(99, 242);
            lblIncorrect.Name = "lblIncorrect";
            lblIncorrect.Size = new System.Drawing.Size(0, 15);
            lblIncorrect.TabIndex = 5;
            // 
            // ckbShowPassword
            // 
            ckbShowPassword.AutoSize = true;
            ckbShowPassword.Location = new System.Drawing.Point(99, 185);
            ckbShowPassword.Name = "ckbShowPassword";
            ckbShowPassword.Size = new System.Drawing.Size(108, 19);
            ckbShowPassword.TabIndex = 6;
            ckbShowPassword.Text = "Show password";
            ckbShowPassword.UseVisualStyleBackColor = true;
            ckbShowPassword.CheckedChanged += ckbShowPassword_CheckedChanged;
            // 
            // btnExit
            // 
            btnExit.BackColor = System.Drawing.Color.MediumTurquoise;
            btnExit.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            btnExit.Location = new System.Drawing.Point(447, 243);
            btnExit.Name = "btnExit";
            btnExit.Size = new System.Drawing.Size(75, 26);
            btnExit.TabIndex = 7;
            btnExit.Text = "Exit";
            btnExit.UseVisualStyleBackColor = false;
            btnExit.Click += btnExit_Click;
            // 
            // pictureBox1
            // 
            pictureBox1.Image = (System.Drawing.Image)resources.GetObject("pictureBox1.Image");
            pictureBox1.Location = new System.Drawing.Point(192, 1);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new System.Drawing.Size(167, 112);
            pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            pictureBox1.TabIndex = 8;
            pictureBox1.TabStop = false;
            // 
            // lblTime
            // 
            lblTime.AutoSize = true;
            lblTime.ForeColor = System.Drawing.SystemColors.HotTrack;
            lblTime.Location = new System.Drawing.Point(12, 249);
            lblTime.Name = "lblTime";
            lblTime.Size = new System.Drawing.Size(0, 15);
            lblTime.TabIndex = 9;
            lblTime.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // Form1
            // 
            AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            ClientSize = new System.Drawing.Size(550, 271);
            Controls.Add(lblTime);
            Controls.Add(pictureBox1);
            Controls.Add(btnExit);
            Controls.Add(ckbShowPassword);
            Controls.Add(lblIncorrect);
            Controls.Add(btnLogin);
            Controls.Add(txtPassword);
            Controls.Add(txtAccount);
            Controls.Add(lblPassword);
            Controls.Add(lblAccount);
            FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            MaximizeBox = false;
            Name = "Form1";
            StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            Text = "Dang Nhap";
            Load += Form1_Load;
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private System.Windows.Forms.Label lblAccount;
        private System.Windows.Forms.Label lblPassword;
        private System.Windows.Forms.TextBox txtAccount;
        private System.Windows.Forms.TextBox txtPassword;
        private System.Windows.Forms.Button btnLogin;
        private System.Windows.Forms.Label lblIncorrect;
        private System.Windows.Forms.CheckBox ckbShowPassword;
        private System.Windows.Forms.Button btnExit;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label lblTime;
    }
}