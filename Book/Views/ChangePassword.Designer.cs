namespace Book.Views
{
    partial class ChangePassView
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ChangePassView));
            this.lbClose = new System.Windows.Forms.Label();
            this.btnChange = new System.Windows.Forms.Button();
            this.txtNewPassword = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.txtRetypePass = new System.Windows.Forms.TextBox();
            this.pictureBoxSeeRetype = new System.Windows.Forms.PictureBox();
            this.pictureBoxSeePass = new System.Windows.Forms.PictureBox();
            this.pictureBox4 = new System.Windows.Forms.PictureBox();
            this.pictureBox3 = new System.Windows.Forms.PictureBox();
            this.lbMessage = new System.Windows.Forms.Label();
            this.lbLogin = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxSeeRetype)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxSeePass)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox4)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).BeginInit();
            this.SuspendLayout();
            // 
            // lbClose
            // 
            this.lbClose.AutoSize = true;
            this.lbClose.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbClose.Location = new System.Drawing.Point(351, 9);
            this.lbClose.Name = "lbClose";
            this.lbClose.Size = new System.Drawing.Size(20, 19);
            this.lbClose.TabIndex = 19;
            this.lbClose.Text = "X";
            this.lbClose.Click += new System.EventHandler(this.lbClose_Click);
            // 
            // btnChange
            // 
            this.btnChange.BackColor = System.Drawing.SystemColors.Desktop;
            this.btnChange.Font = new System.Drawing.Font("Times New Roman", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnChange.Location = new System.Drawing.Point(44, 170);
            this.btnChange.Name = "btnChange";
            this.btnChange.Size = new System.Drawing.Size(292, 34);
            this.btnChange.TabIndex = 17;
            this.btnChange.Text = "Change";
            this.btnChange.UseVisualStyleBackColor = false;
            // 
            // txtNewPassword
            // 
            this.txtNewPassword.Font = new System.Drawing.Font("Times New Roman", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtNewPassword.Location = new System.Drawing.Point(44, 77);
            this.txtNewPassword.Name = "txtNewPassword";
            this.txtNewPassword.Size = new System.Drawing.Size(292, 22);
            this.txtNewPassword.TabIndex = 16;
            this.txtNewPassword.Text = "New Password";
            this.txtNewPassword.MouseClick += new System.Windows.Forms.MouseEventHandler(this.txtNewPassword_MouseClick);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Times New Roman", 26.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(12, 9);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(283, 40);
            this.label2.TabIndex = 12;
            this.label2.Text = "Change password";
            // 
            // txtRetypePass
            // 
            this.txtRetypePass.Font = new System.Drawing.Font("Times New Roman", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtRetypePass.Location = new System.Drawing.Point(44, 116);
            this.txtRetypePass.Name = "txtRetypePass";
            this.txtRetypePass.Size = new System.Drawing.Size(292, 22);
            this.txtRetypePass.TabIndex = 21;
            this.txtRetypePass.Text = "Retype Password";
            this.txtRetypePass.MouseClick += new System.Windows.Forms.MouseEventHandler(this.txtRetypePass_MouseClick);
            // 
            // pictureBoxSeeRetype
            // 
            this.pictureBoxSeeRetype.Image = global::Book.Properties.Resources._353411_circle_eye_icon;
            this.pictureBoxSeeRetype.Location = new System.Drawing.Point(342, 120);
            this.pictureBoxSeeRetype.Name = "pictureBoxSeeRetype";
            this.pictureBoxSeeRetype.Size = new System.Drawing.Size(16, 16);
            this.pictureBoxSeeRetype.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.pictureBoxSeeRetype.TabIndex = 23;
            this.pictureBoxSeeRetype.TabStop = false;
            this.pictureBoxSeeRetype.MouseClick += new System.Windows.Forms.MouseEventHandler(this.pictureBoxSeeRetype_MouseClick);
            // 
            // pictureBoxSeePass
            // 
            this.pictureBoxSeePass.Image = global::Book.Properties.Resources._353411_circle_eye_icon;
            this.pictureBoxSeePass.Location = new System.Drawing.Point(342, 81);
            this.pictureBoxSeePass.Name = "pictureBoxSeePass";
            this.pictureBoxSeePass.Size = new System.Drawing.Size(16, 16);
            this.pictureBoxSeePass.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.pictureBoxSeePass.TabIndex = 22;
            this.pictureBoxSeePass.TabStop = false;
            this.pictureBoxSeePass.MouseClick += new System.Windows.Forms.MouseEventHandler(this.pictureBoxSeePass_MouseClick);
            // 
            // pictureBox4
            // 
            this.pictureBox4.Image = global::Book.Properties.Resources._2191544_key_lock_login_secret_secure_icon__1_;
            this.pictureBox4.Location = new System.Drawing.Point(18, 116);
            this.pictureBox4.Name = "pictureBox4";
            this.pictureBox4.Size = new System.Drawing.Size(20, 20);
            this.pictureBox4.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.pictureBox4.TabIndex = 20;
            this.pictureBox4.TabStop = false;
            // 
            // pictureBox3
            // 
            this.pictureBox3.Image = global::Book.Properties.Resources._2191544_key_lock_login_secret_secure_icon__1_;
            this.pictureBox3.Location = new System.Drawing.Point(18, 77);
            this.pictureBox3.Name = "pictureBox3";
            this.pictureBox3.Size = new System.Drawing.Size(20, 20);
            this.pictureBox3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.pictureBox3.TabIndex = 14;
            this.pictureBox3.TabStop = false;
            // 
            // lbMessage
            // 
            this.lbMessage.AutoSize = true;
            this.lbMessage.Font = new System.Drawing.Font("Times New Roman", 9F, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbMessage.ForeColor = System.Drawing.Color.Red;
            this.lbMessage.Location = new System.Drawing.Point(41, 141);
            this.lbMessage.Name = "lbMessage";
            this.lbMessage.Size = new System.Drawing.Size(0, 15);
            this.lbMessage.TabIndex = 24;
            // 
            // lbLogin
            // 
            this.lbLogin.AutoSize = true;
            this.lbLogin.Font = new System.Drawing.Font("Times New Roman", 9.75F, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbLogin.Location = new System.Drawing.Point(150, 208);
            this.lbLogin.Name = "lbLogin";
            this.lbLogin.Size = new System.Drawing.Size(77, 15);
            this.lbLogin.TabIndex = 25;
            this.lbLogin.Text = "Back to login";
            // 
            // ChangePassView
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(383, 242);
            this.Controls.Add(this.lbLogin);
            this.Controls.Add(this.lbMessage);
            this.Controls.Add(this.pictureBoxSeeRetype);
            this.Controls.Add(this.pictureBoxSeePass);
            this.Controls.Add(this.txtRetypePass);
            this.Controls.Add(this.pictureBox4);
            this.Controls.Add(this.lbClose);
            this.Controls.Add(this.btnChange);
            this.Controls.Add(this.txtNewPassword);
            this.Controls.Add(this.pictureBox3);
            this.Controls.Add(this.label2);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "ChangePassView";
            this.Text = "ChangePassword";
            this.Load += new System.EventHandler(this.ChangePassword_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxSeeRetype)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxSeePass)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox4)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lbClose;
        private System.Windows.Forms.Button btnChange;
        private System.Windows.Forms.TextBox txtNewPassword;
        private System.Windows.Forms.PictureBox pictureBox3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtRetypePass;
        private System.Windows.Forms.PictureBox pictureBox4;
        private System.Windows.Forms.PictureBox pictureBoxSeePass;
        private System.Windows.Forms.PictureBox pictureBoxSeeRetype;
        private System.Windows.Forms.Label lbMessage;
        private System.Windows.Forms.Label lbLogin;
    }
}