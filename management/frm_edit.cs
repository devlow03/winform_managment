using management.api.request;
using Newtonsoft.Json;
using RestSharp;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using management.api.response;

namespace management
{
    public partial class FrmEdit : Form
    {
        public FrmEdit()
        {
            InitializeComponent();
            btnUpdate.Enabled = false;
            frm_login getUser = new frm_login();
            string userID = getUser.getUserID();
            RestApi call = new RestApi();
            var res = call.getUser(userID);
            string passOld = res[0].password;
            for (int i = 0; i < res.Count; i++)
            {
                
                txtName.Text = res[i].name;
                txtUser.Text = res[i].username;
                
                avtImg.Load(res[i].img_url);
            }
            
            
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void frm_edit_Load(object sender, EventArgs e)
        {

        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
           
        }

        private void btnHTTT_Click(object sender, EventArgs e)
        {

        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            frm_login getUser = new frm_login();
            string userID = getUser.getUserID();

            RestApi call = new RestApi();
            var re = call.getUser(userID);
            string passOld = re[0].password;
            if (txtPass.Text == "")
            {
                var res = call.updateAccount(userID, txtName.Text, txtUser.Text, passOld);
                MessageBox.Show(res.ToString());
                Application.Restart();
            }
            else
            {
                var res = call.updateAccount(userID, txtName.Text, txtUser.Text, txtPass.Text);
                MessageBox.Show(res.ToString());
                Application.Restart();
            }


        }

        private void txtName_TextChanged(object sender, EventArgs e)
        {
            btnUpdate.Enabled = true;
        }

        private void btnUpdateImg(object sender, EventArgs e)
        {
            frm_login user = new frm_login();
            string userID = user.getUserID();
            /*            MessageBox.Show(user.getUserID());*/
            String imageLocation = "";
            try
            {
                OpenFileDialog dialog = new OpenFileDialog();
                dialog.Filter = "jpg files(*.jpg)|*.jpg| PNG files(*.png)|*.png| All Files(*.*)|*.*";
                if (dialog.ShowDialog() == System.Windows.Forms.DialogResult.OK)
                {

                    imageLocation = dialog.FileName;
                    String uri = "https://doan.khanhnhat.top";

                    var client = new RestClient(uri);
                    var request = new RestRequest("/api/upload.php", Method.Post);
                    request.AddFile("avatar", imageLocation);
                    /*                    MessageBox.Show(userID);*/
                    request.AddParameter("userID", userID.ToString());

                    request.AlwaysMultipartFormData = true;

                    RestResponse response = client.Execute(request);

                    if (response.IsSuccessful)
                    {
                        var img_url = JsonConvert.DeserializeObject<user>(response.Content);
                        avtImg.ImageLocation = img_url.variable;
                        frmDashboard dsb = new frmDashboard();
                        dsb.Refresh();
                    }

                }
            }
            catch (Exception)
            {
                MessageBox.Show("Đã xảy ra lỗi", "Lỗi!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                throw;
            }
        }

        private void btntext_Click(object sender, EventArgs e)
        {
            frm_login user = new frm_login();
            string userID = user.getUserID();
            /*            MessageBox.Show(user.getUserID());*/
            String imageLocation = "";
            try
            {
                OpenFileDialog dialog = new OpenFileDialog();
                dialog.Filter = "jpg files(*.jpg)|*.jpg| PNG files(*.png)|*.png| All Files(*.*)|*.*";
                if (dialog.ShowDialog() == System.Windows.Forms.DialogResult.OK)
                {

                    imageLocation = dialog.FileName;
                    String uri = "https://doan.khanhnhat.top";

                    var client = new RestClient(uri);
                    var request = new RestRequest("/api/upload.php", Method.Post);
                    request.AddFile("avatar", imageLocation);
                    /*                    MessageBox.Show(userID);*/
                    request.AddParameter("userID", userID.ToString());

                    request.AlwaysMultipartFormData = true;

                    RestResponse response = client.Execute(request);

                    if (response.IsSuccessful)
                    {
                        var img_url = JsonConvert.DeserializeObject<user>(response.Content);

                        avtImg.ImageLocation = img_url.variable;
                        MessageBox.Show("Cập nhật ảnh đại diện thành công, hệ thống sẽ khởi động lại");
                        Application.Restart();
                    }

                }
            }
            catch (Exception)
            {
                MessageBox.Show("Đã xảy ra lỗi", "Lỗi!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                throw;
            }
        }

        private void txtName_Validating(object sender, CancelEventArgs e)
        {
            if (string.IsNullOrEmpty(txtName.Text.Trim()))
            {
                e.Cancel = true;
                txtName.Focus();
                errorProvider1.SetError(txtName, "Tên không được để trống");
            }
            else if (txtName.Text.Length < 5)
            {
                e.Cancel = true;
                txtName.Focus();
                errorProvider1.SetError(txtName, "Tên phải bắt đầu từ 5 kí tự trở lên");
            }
            else
            {
                e.Cancel = false;
                errorProvider1.SetError(txtName, null);
            }
        }

        private void txtUser_Validating(object sender, CancelEventArgs e)
        {
            if (string.IsNullOrEmpty(txtUser.Text.Trim()))
            {
                e.Cancel = true;
                txtUser.Focus();
                errorProvider2.SetError(txtUser, "Tài khoản không được để trống");
            }
            else if (txtUser.Text.Length < 5)
            {
                e.Cancel = true;
                txtUser.Focus();
                errorProvider2.SetError(txtUser, "Tài khoản phải bắt đầu từ 5 kí tự trở lên");
            }
            else
            {
                e.Cancel = false;
                errorProvider2.SetError(txtUser, null);
            }
        }

        /*private void txtOld_Validating(object sender, CancelEventArgs e)
        {
            frm_login getUser = new frm_login();
            string userID = getUser.getUserID();
            RestApi call = new RestApi();
            var res = call.getUser(userID);
            string passOld = res[0].password;
            if (string.IsNullOrEmpty(txtPass.Text.Trim()))
            {
                e.Cancel = true;
                txtPass.Focus();
                errorProvider3.SetError(txtPass, "Mật khẩu không được để trống");
            }
            else if (txtPass.Text != passOld)
            {
                e.Cancel = true;
                txtPass.Focus();
                errorProvider3.SetError(txtPass, "Mật khẩu không khớp");
            }
            else if(txtPass.Text == passOld )
            {
                e.Cancel = false;
                txtPass.Enabled = true;
                *//*errorProvider3.SetError(txtOld, null);*//*
                
            }

        }*/

        private void txtPass_Validating(object sender, CancelEventArgs e)
        {
            if (string.IsNullOrEmpty(txtPass.Text.Trim()))
            {
                e.Cancel = true;
                txtPass.Focus();
                errorProvider4.SetError(txtPass, "Mật khẩu không được để trống");
            }
            else if (txtPass.Text.Length < 5)
            {
                e.Cancel = true;
                txtPass.Focus();
                errorProvider4.SetError(txtPass, "Mật khẩu phải bắt đầu từ 5 kí tự trở lên");
            }
            else
            {
                e.Cancel = false;
                errorProvider4.SetError(txtPass, null);
            }
        }

        private void txtPass_TextChanged(object sender, EventArgs e)
        {

        }

       

        private void btnS_Click_1(object sender, EventArgs e)
        {
            btnH.BringToFront();
            txtPass.UseSystemPasswordChar = true;
        }

        private void btnH_Click(object sender, EventArgs e)
        {
            btnS.BringToFront();
            txtPass.UseSystemPasswordChar = false;
        }

        private void txtOld_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
