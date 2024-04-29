
namespace management
{
    partial class FrmInfo
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
            this.label8 = new System.Windows.Forms.Label();
            this.Cb_city = new System.Windows.Forms.ComboBox();
            this.label7 = new System.Windows.Forms.Label();
            this.Cb_dis = new System.Windows.Forms.ComboBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.Cb_pos = new System.Windows.Forms.ComboBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.txtSalary = new System.Windows.Forms.TextBox();
            this.txtDate = new System.Windows.Forms.TextBox();
            this.txtName = new System.Windows.Forms.TextBox();
            this.txtId = new System.Windows.Forms.TextBox();
            this.Cb_sub = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.listView1 = new System.Windows.Forms.ListView();
            this.name = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.year = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.position = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.city = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.district = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.salary = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.backgroundWorker1 = new System.ComponentModel.BackgroundWorker();
            this.btn_Update = new management.Customs.CustomButton();
            this.btn_Del = new management.Customs.CustomButton();
            this.btn_Add = new management.Customs.CustomButton();
            this.customButton1 = new management.Customs.CustomButton();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.label8.ForeColor = System.Drawing.Color.Black;
            this.label8.Location = new System.Drawing.Point(135, 161);
            this.label8.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(59, 20);
            this.label8.TabIndex = 34;
            this.label8.Text = "Lương";
            // 
            // Cb_city
            // 
            this.Cb_city.BackColor = System.Drawing.Color.White;
            this.Cb_city.DisplayMember = "Chọn tỉnh/thành phố";
            this.Cb_city.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.Cb_city.ForeColor = System.Drawing.Color.Black;
            this.Cb_city.FormattingEnabled = true;
            this.Cb_city.Items.AddRange(new object[] {
            "Trưởng Khoa",
            "Phó Khoa",
            "Giảng Viên"});
            this.Cb_city.Location = new System.Drawing.Point(244, 109);
            this.Cb_city.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.Cb_city.Name = "Cb_city";
            this.Cb_city.Size = new System.Drawing.Size(185, 26);
            this.Cb_city.TabIndex = 33;
            this.Cb_city.SelectedIndexChanged += new System.EventHandler(this.Cb_City_Click);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.label7.ForeColor = System.Drawing.Color.Black;
            this.label7.Location = new System.Drawing.Point(470, 86);
            this.label7.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(113, 20);
            this.label7.TabIndex = 32;
            this.label7.Text = "Quận, Huyện";
            // 
            // Cb_dis
            // 
            this.Cb_dis.BackColor = System.Drawing.Color.White;
            this.Cb_dis.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.Cb_dis.ForeColor = System.Drawing.Color.Black;
            this.Cb_dis.FormattingEnabled = true;
            this.Cb_dis.Items.AddRange(new object[] {
            "Trưởng Khoa",
            "Phó Khoa",
            "Giảng Viên"});
            this.Cb_dis.Location = new System.Drawing.Point(470, 109);
            this.Cb_dis.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.Cb_dis.Name = "Cb_dis";
            this.Cb_dis.Size = new System.Drawing.Size(167, 26);
            this.Cb_dis.TabIndex = 31;
            this.Cb_dis.SelectedIndexChanged += new System.EventHandler(this.Cb_dis_Click);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.label6.ForeColor = System.Drawing.Color.Black;
            this.label6.Location = new System.Drawing.Point(8, 86);
            this.label6.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(70, 20);
            this.label6.TabIndex = 29;
            this.label6.Text = "Bộ môn";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.label5.ForeColor = System.Drawing.Color.Black;
            this.label5.Location = new System.Drawing.Point(244, 86);
            this.label5.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(139, 20);
            this.label5.TabIndex = 28;
            this.label5.Text = "Tỉnh, Thành Phố";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.label4.ForeColor = System.Drawing.Color.Black;
            this.label4.Location = new System.Drawing.Point(470, 19);
            this.label4.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(73, 20);
            this.label4.TabIndex = 27;
            this.label4.Text = "Chức vụ";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.label3.ForeColor = System.Drawing.Color.Black;
            this.label3.Location = new System.Drawing.Point(244, 19);
            this.label3.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(83, 20);
            this.label3.TabIndex = 25;
            this.label3.Text = "Năm sinh";
            // 
            // Cb_pos
            // 
            this.Cb_pos.BackColor = System.Drawing.Color.White;
            this.Cb_pos.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.Cb_pos.ForeColor = System.Drawing.Color.Black;
            this.Cb_pos.FormattingEnabled = true;
            this.Cb_pos.Items.AddRange(new object[] {
            "Trưởng Khoa",
            "Phó Khoa",
            "Giảng Viên"});
            this.Cb_pos.Location = new System.Drawing.Point(469, 41);
            this.Cb_pos.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.Cb_pos.Name = "Cb_pos";
            this.Cb_pos.Size = new System.Drawing.Size(168, 26);
            this.Cb_pos.TabIndex = 22;
            this.Cb_pos.SelectedIndexChanged += new System.EventHandler(this.Cb_pos_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.BackColor = System.Drawing.Color.Transparent;
            this.groupBox1.Controls.Add(this.txtSalary);
            this.groupBox1.Controls.Add(this.txtDate);
            this.groupBox1.Controls.Add(this.txtName);
            this.groupBox1.Controls.Add(this.txtId);
            this.groupBox1.Controls.Add(this.Cb_sub);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.Cb_city);
            this.groupBox1.Controls.Add(this.Cb_dis);
            this.groupBox1.Controls.Add(this.label6);
            this.groupBox1.Controls.Add(this.label8);
            this.groupBox1.Controls.Add(this.label7);
            this.groupBox1.Controls.Add(this.Cb_pos);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.groupBox1.Location = new System.Drawing.Point(3, 9);
            this.groupBox1.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Padding = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.groupBox1.Size = new System.Drawing.Size(653, 200);
            this.groupBox1.TabIndex = 40;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Thông tin chi tiét";
            this.groupBox1.Enter += new System.EventHandler(this.groupBox1_Enter);
            // 
            // txtSalary
            // 
            this.txtSalary.BackColor = System.Drawing.Color.White;
            this.txtSalary.Font = new System.Drawing.Font("Arial", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.txtSalary.ForeColor = System.Drawing.Color.Black;
            this.txtSalary.Location = new System.Drawing.Point(206, 156);
            this.txtSalary.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.txtSalary.Name = "txtSalary";
            this.txtSalary.Size = new System.Drawing.Size(256, 30);
            this.txtSalary.TabIndex = 50;
            // 
            // txtDate
            // 
            this.txtDate.BackColor = System.Drawing.Color.White;
            this.txtDate.Font = new System.Drawing.Font("Arial", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.txtDate.ForeColor = System.Drawing.Color.Black;
            this.txtDate.Location = new System.Drawing.Point(242, 41);
            this.txtDate.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.txtDate.Name = "txtDate";
            this.txtDate.Size = new System.Drawing.Size(187, 30);
            this.txtDate.TabIndex = 49;
            // 
            // txtName
            // 
            this.txtName.BackColor = System.Drawing.Color.White;
            this.txtName.Font = new System.Drawing.Font("Arial", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.txtName.ForeColor = System.Drawing.Color.Black;
            this.txtName.Location = new System.Drawing.Point(13, 41);
            this.txtName.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.txtName.Name = "txtName";
            this.txtName.Size = new System.Drawing.Size(187, 30);
            this.txtName.TabIndex = 48;
            // 
            // txtId
            // 
            this.txtId.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(238)))), ((int)(((byte)(238)))), ((int)(((byte)(238)))));
            this.txtId.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtId.Location = new System.Drawing.Point(13, 156);
            this.txtId.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.txtId.Name = "txtId";
            this.txtId.Size = new System.Drawing.Size(21, 14);
            this.txtId.TabIndex = 36;
            // 
            // Cb_sub
            // 
            this.Cb_sub.BackColor = System.Drawing.Color.White;
            this.Cb_sub.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.Cb_sub.ForeColor = System.Drawing.Color.Black;
            this.Cb_sub.FormattingEnabled = true;
            this.Cb_sub.Items.AddRange(new object[] {
            "Trưởng Khoa",
            "Phó Khoa",
            "Giảng Viên"});
            this.Cb_sub.Location = new System.Drawing.Point(12, 109);
            this.Cb_sub.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.Cb_sub.Name = "Cb_sub";
            this.Cb_sub.Size = new System.Drawing.Size(188, 26);
            this.Cb_sub.TabIndex = 35;
            this.Cb_sub.SelectedIndexChanged += new System.EventHandler(this.Cb_sub_SelectedIndexChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.label1.ForeColor = System.Drawing.Color.Black;
            this.label1.Location = new System.Drawing.Point(8, 19);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(63, 20);
            this.label1.TabIndex = 25;
            this.label1.Text = "Họ tên";
            // 
            // groupBox2
            // 
            this.groupBox2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(238)))), ((int)(((byte)(238)))), ((int)(((byte)(238)))));
            this.groupBox2.Controls.Add(this.listView1);
            this.groupBox2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.groupBox2.Location = new System.Drawing.Point(9, 292);
            this.groupBox2.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Padding = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.groupBox2.Size = new System.Drawing.Size(647, 193);
            this.groupBox2.TabIndex = 41;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Danh sách giảng viên";
            // 
            // listView1
            // 
            this.listView1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(238)))), ((int)(((byte)(238)))), ((int)(((byte)(238)))));
            this.listView1.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.name,
            this.year,
            this.position,
            this.city,
            this.district,
            this.salary});
            this.listView1.HeaderStyle = System.Windows.Forms.ColumnHeaderStyle.Nonclickable;
            this.listView1.HideSelection = false;
            this.listView1.Location = new System.Drawing.Point(7, 19);
            this.listView1.Name = "listView1";
            this.listView1.Size = new System.Drawing.Size(636, 169);
            this.listView1.TabIndex = 0;
            this.listView1.UseCompatibleStateImageBehavior = false;
            this.listView1.View = System.Windows.Forms.View.Details;
            this.listView1.SelectedIndexChanged += new System.EventHandler(this.listView1_SelectedIndexChanged);
            // 
            // name
            // 
            this.name.Text = "Tên";
            this.name.Width = 156;
            // 
            // year
            // 
            this.year.Text = "Năm sinh";
            this.year.Width = 89;
            // 
            // position
            // 
            this.position.Text = "Chức vụ";
            this.position.Width = 101;
            // 
            // city
            // 
            this.city.Text = "Thành phố";
            this.city.Width = 94;
            // 
            // district
            // 
            this.district.Text = "Quận huyện";
            this.district.Width = 95;
            // 
            // salary
            // 
            this.salary.Text = "Lương";
            this.salary.Width = 98;
            // 
            // btn_Update
            // 
            this.btn_Update.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(96)))), ((int)(((byte)(114)))));
            this.btn_Update.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(96)))), ((int)(((byte)(114)))));
            this.btn_Update.BorderColor = System.Drawing.Color.PaleVioletRed;
            this.btn_Update.BorderRadius = 15;
            this.btn_Update.BorderSize = 0;
            this.btn_Update.FlatAppearance.BorderSize = 0;
            this.btn_Update.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_Update.ForeColor = System.Drawing.Color.White;
            this.btn_Update.Location = new System.Drawing.Point(195, 239);
            this.btn_Update.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btn_Update.Name = "btn_Update";
            this.btn_Update.Size = new System.Drawing.Size(120, 32);
            this.btn_Update.TabIndex = 43;
            this.btn_Update.Text = "Sửa";
            this.btn_Update.TextColor = System.Drawing.Color.White;
            this.btn_Update.UseVisualStyleBackColor = false;
            this.btn_Update.Click += new System.EventHandler(this.btn_Update_Click);
            // 
            // btn_Del
            // 
            this.btn_Del.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(96)))), ((int)(((byte)(114)))));
            this.btn_Del.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(96)))), ((int)(((byte)(114)))));
            this.btn_Del.BorderColor = System.Drawing.Color.PaleVioletRed;
            this.btn_Del.BorderRadius = 15;
            this.btn_Del.BorderSize = 0;
            this.btn_Del.FlatAppearance.BorderSize = 0;
            this.btn_Del.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_Del.ForeColor = System.Drawing.Color.White;
            this.btn_Del.Location = new System.Drawing.Point(350, 239);
            this.btn_Del.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btn_Del.Name = "btn_Del";
            this.btn_Del.Size = new System.Drawing.Size(120, 32);
            this.btn_Del.TabIndex = 45;
            this.btn_Del.Text = "Xóa";
            this.btn_Del.TextColor = System.Drawing.Color.White;
            this.btn_Del.UseVisualStyleBackColor = false;
            this.btn_Del.Click += new System.EventHandler(this.btn_Del_Click);
            // 
            // btn_Add
            // 
            this.btn_Add.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(96)))), ((int)(((byte)(114)))));
            this.btn_Add.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(96)))), ((int)(((byte)(114)))));
            this.btn_Add.BorderColor = System.Drawing.Color.PaleVioletRed;
            this.btn_Add.BorderRadius = 15;
            this.btn_Add.BorderSize = 0;
            this.btn_Add.FlatAppearance.BorderSize = 0;
            this.btn_Add.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_Add.ForeColor = System.Drawing.Color.White;
            this.btn_Add.Location = new System.Drawing.Point(40, 239);
            this.btn_Add.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btn_Add.Name = "btn_Add";
            this.btn_Add.Size = new System.Drawing.Size(120, 32);
            this.btn_Add.TabIndex = 46;
            this.btn_Add.Text = "Thêm";
            this.btn_Add.TextColor = System.Drawing.Color.White;
            this.btn_Add.UseVisualStyleBackColor = false;
            this.btn_Add.Click += new System.EventHandler(this.btn_Add_Click);
            // 
            // customButton1
            // 
            this.customButton1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(96)))), ((int)(((byte)(114)))));
            this.customButton1.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(96)))), ((int)(((byte)(114)))));
            this.customButton1.BorderColor = System.Drawing.Color.PaleVioletRed;
            this.customButton1.BorderRadius = 15;
            this.customButton1.BorderSize = 0;
            this.customButton1.FlatAppearance.BorderSize = 0;
            this.customButton1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.customButton1.ForeColor = System.Drawing.Color.White;
            this.customButton1.Location = new System.Drawing.Point(506, 239);
            this.customButton1.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.customButton1.Name = "customButton1";
            this.customButton1.Size = new System.Drawing.Size(120, 32);
            this.customButton1.TabIndex = 47;
            this.customButton1.Text = "Xuất file excel";
            this.customButton1.TextColor = System.Drawing.Color.White;
            this.customButton1.UseVisualStyleBackColor = false;
            this.customButton1.Click += new System.EventHandler(this.customButton1_Click);
            // 
            // FrmInfo
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(238)))), ((int)(((byte)(238)))), ((int)(((byte)(238)))));
            this.ClientSize = new System.Drawing.Size(664, 488);
            this.Controls.Add(this.customButton1);
            this.Controls.Add(this.btn_Add);
            this.Controls.Add(this.btn_Update);
            this.Controls.Add(this.btn_Del);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.Name = "FrmInfo";
            this.Text = "Form4";
            this.Load += new System.EventHandler(this.FrmInfo_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.ComboBox Cb_city;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.ComboBox Cb_dis;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ComboBox Cb_pos;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ListView listView1;
        private System.Windows.Forms.ColumnHeader name;
        private System.Windows.Forms.ColumnHeader year;
        private System.Windows.Forms.ColumnHeader position;
        private System.Windows.Forms.ColumnHeader city;
        private System.Windows.Forms.ColumnHeader district;
        private System.Windows.Forms.ColumnHeader salary;
        private System.Windows.Forms.ComboBox Cb_sub;
        private System.Windows.Forms.TextBox txtId;
        private System.ComponentModel.BackgroundWorker backgroundWorker1;
        private Customs.CustomButton btn_Update;
        private Customs.CustomButton btn_Del;
        private Customs.CustomButton btn_Add;
        private Customs.CustomButton customButton1;
        private System.Windows.Forms.TextBox txtSalary;
        private System.Windows.Forms.TextBox txtDate;
        private System.Windows.Forms.TextBox txtName;
    }
}