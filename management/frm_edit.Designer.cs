
namespace management
{
    partial class FrmEdit
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmEdit));
            this.label1 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.avtImg = new System.Windows.Forms.PictureBox();
            this.btntext = new System.Windows.Forms.Button();
            this.txtName = new System.Windows.Forms.TextBox();
            this.txtPass = new System.Windows.Forms.TextBox();
            this.txtUser = new System.Windows.Forms.TextBox();
            this.errorProvider1 = new System.Windows.Forms.ErrorProvider(this.components);
            this.errorProvider2 = new System.Windows.Forms.ErrorProvider(this.components);
            this.errorProvider3 = new System.Windows.Forms.ErrorProvider(this.components);
            this.errorProvider4 = new System.Windows.Forms.ErrorProvider(this.components);
            this.btnH = new management.Customs.CustomButton();
            this.btnS = new management.Customs.CustomButton();
            this.btnUpdate = new management.Customs.CustomButton();
            ((System.ComponentModel.ISupportInitialize)(this.avtImg)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider4)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.label1.ForeColor = System.Drawing.Color.Black;
            this.label1.Location = new System.Drawing.Point(270, 164);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(50, 25);
            this.label1.TabIndex = 25;
            this.label1.Text = "Tên";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.label3.ForeColor = System.Drawing.Color.Black;
            this.label3.Location = new System.Drawing.Point(267, 288);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(141, 25);
            this.label3.TabIndex = 25;
            this.label3.Text = "Mật khẩu mới";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.label6.ForeColor = System.Drawing.Color.Black;
            this.label6.Location = new System.Drawing.Point(270, 224);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(108, 25);
            this.label6.TabIndex = 29;
            this.label6.Text = "Tài khoản";
            // 
            // avtImg
            // 
            this.avtImg.Cursor = System.Windows.Forms.Cursors.Hand;
            this.avtImg.Image = global::management.Properties.Resources.icon_g317f58c3a_640;
            this.avtImg.Location = new System.Drawing.Point(37, 143);
            this.avtImg.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.avtImg.Name = "avtImg";
            this.avtImg.Size = new System.Drawing.Size(166, 159);
            this.avtImg.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.avtImg.TabIndex = 39;
            this.avtImg.TabStop = false;
            this.avtImg.Click += new System.EventHandler(this.pictureBox1_Click);
            // 
            // btntext
            // 
            this.btntext.BackColor = System.Drawing.Color.Transparent;
            this.btntext.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btntext.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.btntext.FlatAppearance.BorderSize = 0;
            this.btntext.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btntext.Font = new System.Drawing.Font("Arial", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btntext.ForeColor = System.Drawing.Color.DodgerBlue;
            this.btntext.Location = new System.Drawing.Point(19, 317);
            this.btntext.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btntext.Name = "btntext";
            this.btntext.Size = new System.Drawing.Size(184, 34);
            this.btntext.TabIndex = 46;
            this.btntext.Text = " Đổi ảnh đại diện";
            this.btntext.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btntext.TextImageRelation = System.Windows.Forms.TextImageRelation.TextBeforeImage;
            this.btntext.UseVisualStyleBackColor = false;
            this.btntext.Click += new System.EventHandler(this.btntext_Click);
            // 
            // txtName
            // 
            this.txtName.BackColor = System.Drawing.Color.White;
            this.txtName.Font = new System.Drawing.Font("Arial", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.txtName.ForeColor = System.Drawing.Color.Black;
            this.txtName.Location = new System.Drawing.Point(426, 153);
            this.txtName.Name = "txtName";
            this.txtName.Size = new System.Drawing.Size(395, 36);
            this.txtName.TabIndex = 47;
            this.txtName.TextChanged += new System.EventHandler(this.txtName_TextChanged);
            this.txtName.Validating += new System.ComponentModel.CancelEventHandler(this.txtName_Validating);
            // 
            // txtPass
            // 
            this.txtPass.BackColor = System.Drawing.Color.White;
            this.txtPass.Font = new System.Drawing.Font("Arial", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.txtPass.ForeColor = System.Drawing.Color.Black;
            this.txtPass.Location = new System.Drawing.Point(426, 277);
            this.txtPass.Name = "txtPass";
            this.txtPass.Size = new System.Drawing.Size(395, 36);
            this.txtPass.TabIndex = 48;
            this.txtPass.UseSystemPasswordChar = true;
            this.txtPass.TextChanged += new System.EventHandler(this.txtOld_TextChanged);
            this.txtPass.Validating += new System.ComponentModel.CancelEventHandler(this.txtPass_Validating);
            // 
            // txtUser
            // 
            this.txtUser.BackColor = System.Drawing.Color.White;
            this.txtUser.Font = new System.Drawing.Font("Arial", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.txtUser.ForeColor = System.Drawing.Color.Black;
            this.txtUser.Location = new System.Drawing.Point(426, 213);
            this.txtUser.Name = "txtUser";
            this.txtUser.Size = new System.Drawing.Size(395, 36);
            this.txtUser.TabIndex = 49;
            this.txtUser.Validating += new System.ComponentModel.CancelEventHandler(this.txtUser_Validating);
            // 
            // errorProvider1
            // 
            this.errorProvider1.ContainerControl = this;
            // 
            // errorProvider2
            // 
            this.errorProvider2.ContainerControl = this;
            // 
            // errorProvider3
            // 
            this.errorProvider3.ContainerControl = this;
            // 
            // errorProvider4
            // 
            this.errorProvider4.ContainerControl = this;
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
            this.btnH.Location = new System.Drawing.Point(762, 285);
            this.btnH.Name = "btnH";
            this.btnH.Size = new System.Drawing.Size(49, 26);
            this.btnH.TabIndex = 112;
            this.btnH.TextColor = System.Drawing.Color.White;
            this.btnH.UseVisualStyleBackColor = false;
            this.btnH.Click += new System.EventHandler(this.btnH_Click);
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
            this.btnS.Location = new System.Drawing.Point(762, 285);
            this.btnS.Name = "btnS";
            this.btnS.Size = new System.Drawing.Size(49, 26);
            this.btnS.TabIndex = 111;
            this.btnS.TextColor = System.Drawing.Color.White;
            this.btnS.UseVisualStyleBackColor = false;
            this.btnS.Click += new System.EventHandler(this.btnS_Click_1);
            // 
            // btnUpdate
            // 
            this.btnUpdate.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(96)))), ((int)(((byte)(114)))));
            this.btnUpdate.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(96)))), ((int)(((byte)(114)))));
            this.btnUpdate.BorderColor = System.Drawing.Color.Black;
            this.btnUpdate.BorderRadius = 10;
            this.btnUpdate.BorderSize = 0;
            this.btnUpdate.Enabled = false;
            this.btnUpdate.FlatAppearance.BorderSize = 0;
            this.btnUpdate.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnUpdate.Font = new System.Drawing.Font("Arial Black", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.btnUpdate.ForeColor = System.Drawing.Color.White;
            this.btnUpdate.Location = new System.Drawing.Point(492, 371);
            this.btnUpdate.Name = "btnUpdate";
            this.btnUpdate.Size = new System.Drawing.Size(238, 61);
            this.btnUpdate.TabIndex = 40;
            this.btnUpdate.Text = "Chỉnh sửa";
            this.btnUpdate.TextColor = System.Drawing.Color.White;
            this.btnUpdate.UseVisualStyleBackColor = false;
            this.btnUpdate.Click += new System.EventHandler(this.btnUpdate_Click);
            // 
            // FrmEdit
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(238)))), ((int)(((byte)(238)))), ((int)(((byte)(238)))));
            this.ClientSize = new System.Drawing.Size(867, 554);
            this.Controls.Add(this.btnH);
            this.Controls.Add(this.btnS);
            this.Controls.Add(this.txtUser);
            this.Controls.Add(this.txtPass);
            this.Controls.Add(this.txtName);
            this.Controls.Add(this.btntext);
            this.Controls.Add(this.btnUpdate);
            this.Controls.Add(this.avtImg);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.label6);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "FrmEdit";
            this.Load += new System.EventHandler(this.frm_edit_Load);
            ((System.ComponentModel.ISupportInitialize)(this.avtImg)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider4)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.PictureBox avtImg;
        private Customs.CustomButton btnUpdate;
        private System.Windows.Forms.Button btntext;
        private System.Windows.Forms.TextBox txtName;
        private System.Windows.Forms.TextBox txtPass;
        private System.Windows.Forms.TextBox txtUser;
        private System.Windows.Forms.ErrorProvider errorProvider1;
        private System.Windows.Forms.ErrorProvider errorProvider2;
        private System.Windows.Forms.ErrorProvider errorProvider3;
        private System.Windows.Forms.ErrorProvider errorProvider4;
        private Customs.CustomButton btnS;
        private Customs.CustomButton btnH;
    }
}