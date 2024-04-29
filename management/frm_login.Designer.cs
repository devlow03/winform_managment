
namespace management
{
    partial class frm_login
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frm_login));
            this.label2 = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.label4 = new System.Windows.Forms.Label();
            this.bntMinimize = new System.Windows.Forms.Button();
            this.btnClose = new System.Windows.Forms.Button();
            this.txtUser = new System.Windows.Forms.TextBox();
            this.txtPass = new System.Windows.Forms.TextBox();
            this.errorProvider1 = new System.Windows.Forms.ErrorProvider(this.components);
            this.errorProvider2 = new System.Windows.Forms.ErrorProvider(this.components);
            this.btnS = new management.Customs.CustomButton();
            this.btnH = new management.Customs.CustomButton();
            this.btnLogin = new management.Customs.CustomButton();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider2)).BeginInit();
            this.SuspendLayout();
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Arial Black", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.label2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(31)))), ((int)(((byte)(13)))), ((int)(((byte)(60)))));
            this.label2.Location = new System.Drawing.Point(100, 321);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(97, 24);
            this.label2.TabIndex = 99;
            this.label2.Text = "Mật khẩu";
            this.label2.Click += new System.EventHandler(this.label2_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(100, 38);
            this.pictureBox1.Margin = new System.Windows.Forms.Padding(4);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(413, 142);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 100;
            this.pictureBox1.TabStop = false;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Arial Black", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.label4.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(31)))), ((int)(((byte)(13)))), ((int)(((byte)(60)))));
            this.label4.Location = new System.Drawing.Point(100, 210);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(103, 24);
            this.label4.TabIndex = 99;
            this.label4.Text = "Tài khoản";
            this.label4.Click += new System.EventHandler(this.label2_Click);
            // 
            // bntMinimize
            // 
            this.bntMinimize.AccessibleRole = System.Windows.Forms.AccessibleRole.None;
            this.bntMinimize.FlatAppearance.BorderSize = 0;
            this.bntMinimize.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.bntMinimize.ForeColor = System.Drawing.Color.Gray;
            this.bntMinimize.Image = global::management.Properties.Resources.icons8_subtract_30;
            this.bntMinimize.Location = new System.Drawing.Point(533, 1);
            this.bntMinimize.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.bntMinimize.Name = "bntMinimize";
            this.bntMinimize.Size = new System.Drawing.Size(29, 30);
            this.bntMinimize.TabIndex = 105;
            this.bntMinimize.UseVisualStyleBackColor = true;
            this.bntMinimize.Click += new System.EventHandler(this.bntMinimize_Click);
            // 
            // btnClose
            // 
            this.btnClose.AccessibleRole = System.Windows.Forms.AccessibleRole.None;
            this.btnClose.FlatAppearance.BorderSize = 0;
            this.btnClose.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnClose.ForeColor = System.Drawing.Color.Black;
            this.btnClose.Image = global::management.Properties.Resources.icons8_macos_close_30;
            this.btnClose.Location = new System.Drawing.Point(573, 1);
            this.btnClose.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnClose.Name = "btnClose";
            this.btnClose.Size = new System.Drawing.Size(35, 34);
            this.btnClose.TabIndex = 104;
            this.btnClose.UseVisualStyleBackColor = true;
            this.btnClose.Click += new System.EventHandler(this.btnClose_Click);
            // 
            // txtUser
            // 
            this.txtUser.Cursor = System.Windows.Forms.Cursors.Default;
            this.txtUser.Font = new System.Drawing.Font("Arial", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.txtUser.Location = new System.Drawing.Point(105, 250);
            this.txtUser.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtUser.Name = "txtUser";
            this.txtUser.Size = new System.Drawing.Size(412, 36);
            this.txtUser.TabIndex = 0;
            this.txtUser.TextChanged += new System.EventHandler(this.txtUser_TextChanged_1);
            this.txtUser.Validating += new System.ComponentModel.CancelEventHandler(this.txtUser_Validating);
            // 
            // txtPass
            // 
            this.txtPass.Cursor = System.Windows.Forms.Cursors.WaitCursor;
            this.txtPass.Font = new System.Drawing.Font("Arial", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.txtPass.Location = new System.Drawing.Point(105, 362);
            this.txtPass.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtPass.Name = "txtPass";
            this.txtPass.Size = new System.Drawing.Size(416, 36);
            this.txtPass.TabIndex = 1;
            this.txtPass.UseSystemPasswordChar = true;
            this.txtPass.UseWaitCursor = true;
            this.txtPass.Validating += new System.ComponentModel.CancelEventHandler(this.txtPass_Validating);
            // 
            // errorProvider1
            // 
            this.errorProvider1.ContainerControl = this;
            // 
            // errorProvider2
            // 
            this.errorProvider2.ContainerControl = this;
            // 
            // btnS
            // 
            this.btnS.BackColor = System.Drawing.Color.White;
            this.btnS.BackgroundColor = System.Drawing.Color.White;
            this.btnS.BorderColor = System.Drawing.Color.PaleVioletRed;
            this.btnS.BorderRadius = 0;
            this.btnS.BorderSize = 0;
            this.btnS.FlatAppearance.BorderSize = 0;
            this.btnS.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnS.ForeColor = System.Drawing.Color.White;
            this.btnS.Image = ((System.Drawing.Image)(resources.GetObject("btnS.Image")));
            this.btnS.Location = new System.Drawing.Point(472, 367);
            this.btnS.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnS.Name = "btnS";
            this.btnS.Size = new System.Drawing.Size(49, 26);
            this.btnS.TabIndex = 108;
            this.btnS.TextColor = System.Drawing.Color.White;
            this.btnS.UseVisualStyleBackColor = false;
            this.btnS.Click += new System.EventHandler(this.btnS_Click);
            // 
            // btnH
            // 
            this.btnH.BackColor = System.Drawing.Color.White;
            this.btnH.BackgroundColor = System.Drawing.Color.White;
            this.btnH.BorderColor = System.Drawing.Color.PaleVioletRed;
            this.btnH.BorderRadius = 0;
            this.btnH.BorderSize = 0;
            this.btnH.FlatAppearance.BorderSize = 0;
            this.btnH.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnH.ForeColor = System.Drawing.Color.White;
            this.btnH.Image = ((System.Drawing.Image)(resources.GetObject("btnH.Image")));
            this.btnH.Location = new System.Drawing.Point(472, 367);
            this.btnH.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnH.Name = "btnH";
            this.btnH.Size = new System.Drawing.Size(49, 26);
            this.btnH.TabIndex = 107;
            this.btnH.TextColor = System.Drawing.Color.White;
            this.btnH.UseVisualStyleBackColor = false;
            this.btnH.Click += new System.EventHandler(this.btnH_Click);
            // 
            // btnLogin
            // 
            this.btnLogin.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(96)))), ((int)(((byte)(114)))));
            this.btnLogin.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(96)))), ((int)(((byte)(114)))));
            this.btnLogin.BorderColor = System.Drawing.Color.PaleVioletRed;
            this.btnLogin.BorderRadius = 12;
            this.btnLogin.BorderSize = 0;
            this.btnLogin.FlatAppearance.BorderSize = 0;
            this.btnLogin.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnLogin.Font = new System.Drawing.Font("Arial", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.btnLogin.ForeColor = System.Drawing.Color.White;
            this.btnLogin.Location = new System.Drawing.Point(179, 454);
            this.btnLogin.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnLogin.Name = "btnLogin";
            this.btnLogin.Size = new System.Drawing.Size(265, 55);
            this.btnLogin.TabIndex = 106;
            this.btnLogin.Text = "ĐĂNG NHẬP";
            this.btnLogin.TextColor = System.Drawing.Color.White;
            this.btnLogin.UseVisualStyleBackColor = false;
            this.btnLogin.Click += new System.EventHandler(this.btnLogin_Click);
            this.btnLogin.Validating += new System.ComponentModel.CancelEventHandler(this.btnLogin_Validating);
            // 
            // frm_login
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(238)))), ((int)(((byte)(238)))), ((int)(((byte)(238)))));
            this.ClientSize = new System.Drawing.Size(628, 610);
            this.Controls.Add(this.btnS);
            this.Controls.Add(this.btnH);
            this.Controls.Add(this.txtPass);
            this.Controls.Add(this.txtUser);
            this.Controls.Add(this.btnLogin);
            this.Controls.Add(this.bntMinimize);
            this.Controls.Add(this.btnClose);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label2);
            this.ForeColor = System.Drawing.SystemColors.Control;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.HelpButton = true;
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "frm_login";
            this.SizeGripStyle = System.Windows.Forms.SizeGripStyle.Hide;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Load += new System.EventHandler(this.frm_login_Load);
            this.MouseDown += new System.Windows.Forms.MouseEventHandler(this.mouse_Down);
            this.MouseMove += new System.Windows.Forms.MouseEventHandler(this.mouse_Move);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider2)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button bntMinimize;
        private System.Windows.Forms.Button btnClose;
        private Customs.CustomButton btnLogin;
        private System.Windows.Forms.TextBox txtUser;
        private System.Windows.Forms.TextBox txtPass;
        private System.Windows.Forms.ErrorProvider errorProvider1;
        private System.Windows.Forms.ErrorProvider errorProvider2;
        private Customs.CustomButton btnH;
        private Customs.CustomButton btnS;
    }
}

