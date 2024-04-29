
using RestSharp;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Runtime.InteropServices;
using management.api.response;
using System.Windows.Forms;
using Newtonsoft.Json;

namespace management
{
    public partial class frm_login : Form
    {
        public Point mouseLocation;

        public frm_login()

        {
            InitializeComponent();
            
            
           
        }
        public static string userID;
        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void contextMenuStrip1_Opening(object sender, CancelEventArgs e)
        {

        }
        public string getUserID()
        {
            return userID;
        }


        private void frm_login_Load(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void txtUser_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtPass_TextChanged(object sender, EventArgs e)
        {

        }

        private void btnLogin_KeyDown(object sender, KeyEventArgs e)
        {

        }

        private void Form1_KeyDown(object sender, KeyEventArgs e)
        {

        }


        private void bntMinimize_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

    

        private void btnLogin_Click(object sender, EventArgs e)
        {
            String uri = "https://doan.khanhnhat.top";
            String route = "/api/login.php";
            var client = new RestClient(uri);
            var body = new
            {

                username = txtUser.Text,
                password = txtPass.Text,



            };
            if(txtUser.Text!="" && txtPass.Text !="")
            {
                var request = new RestRequest(route, Method.Post);
                request.AddObject(body);
                RestResponse response = client.Execute(request);
                //response.IsSuccessful
                if (response.IsSuccessful)
                {
                    var user = JsonConvert.DeserializeObject<user>(response.Content);
                    userID = user.variable;
                    frmDashboard frm2 = new frmDashboard();
                    frm2.ShowDialog();
                    frm2 = null;
                    /*this.Show();*/
                }
                else
                {
                    MessageBox.Show("Đăng nhập thất bại, vui lòng kiếm tra lại tài khoản và mật khẩu");
                }
            }
            else
            {
                MessageBox.Show("Vui lòng nhập tài khoản và mật khẩu");
            }
           

            
        }

        private void txtUser_TextChanged_1(object sender, EventArgs e)
        {

        }

        private void mouse_Down(object sender, MouseEventArgs e)
        {
            mouseLocation = new Point(-e.X, -e.Y);
        }

        private void mouse_Move(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                Point mousePose = Control.MousePosition;
                mousePose.Offset(mouseLocation.X, mouseLocation.Y);
                Location = mousePose;
            }
        }

        private void txtUser_Validating(object sender, CancelEventArgs e)
        {
            if (string.IsNullOrEmpty(txtUser.Text.Trim()))
            {
               /* e.Cancel = true;
                txtUser.Focus();*/
                errorProvider1.SetError(txtUser, "Tài khoản không được để trống");
            }
            else if (txtUser.Text.Length < 5)
            {
               /* e.Cancel = true;
                txtUser.Focus();*/
                errorProvider1.SetError(txtUser, "Tài khoản phải bắt đầu từ 5 kí tự trở lên");
            }
            else
            {
                e.Cancel =false;
                errorProvider1.SetError(txtUser, null);
            }
        }

        private void txtPass_Validating(object sender, CancelEventArgs e)
        {
            if (string.IsNullOrEmpty(txtPass.Text.Trim()))
            {
                //e.Cancel = true;
                //txtPass.Focus();
                errorProvider2.SetError(txtPass, "Mật khẩu không được để trống");
            }
            else if (txtPass.Text.Length < 5)
            {
                /*e.Cancel = true;
                txtPass.Focus();*/
                errorProvider2.SetError(txtPass, "Mật khẩu phải bắt đầu từ 5 kí tự trở lên");
            }
            else
            {
                e.Cancel = false;
                errorProvider2.SetError(txtPass, null);
            }
        }

        private void btnLogin_Validating(object sender, CancelEventArgs e)
        {
            
            
        }

        private void btnShow_Click(object sender, EventArgs e)
        {

        }

        private void btnHidden_Click(object sender, EventArgs e)
        {

        }

        private void customButton1_Click(object sender, EventArgs e)
        {

        }

       

        private void btnShow_Click_2(object sender, EventArgs e)
        {
            btnH.BringToFront();
            txtPass.UseSystemPasswordChar = false;
        }

        private void btnHid_Click(object sender, EventArgs e)
        {
            btnS.BringToFront();
            txtPass.UseSystemPasswordChar = true;
        }

        private void btnS_Click(object sender, EventArgs e)
        {
            btnH.BringToFront();
            txtPass.UseSystemPasswordChar = false;
        }

        private void btnH_Click(object sender, EventArgs e)
        {
            btnS.BringToFront();
            txtPass.UseSystemPasswordChar = true;
        }
    }
}
