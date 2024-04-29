using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Runtime.InteropServices;
using System.Windows.Forms;
using management.api.request;
using management.api.response;
using management.config;
using RestSharp;
using Newtonsoft.Json;

namespace management
{
    public partial class frmDashboard : Form
    {
        public Point mouseLocation;


        public frmDashboard()
        {
            InitializeComponent();
            //Lay link anh tu csdl
            frm_login getUser = new frm_login();
            string userID = getUser.getUserID();

            RestApi call = new RestApi();
            var user = call.getUser(userID);
            string img_url;

            img_url = user[0].img_url;
            lbName.Text = user[0].name;


            avatar.Load(img_url);

            //ten nguoi dung


            //Bo tron avt
            Rectangle r = new Rectangle(0, 0, avatar.Width, avatar.Height);
            System.Drawing.Drawing2D.GraphicsPath gp = new System.Drawing.Drawing2D.GraphicsPath();

            gp.AddEllipse(0, 0, avatar.Width - 3, avatar.Height - 3);
            Region rg = new Region(gp);
            avatar.Region = rg;

        }
        private Button lastButton;
        private bool on = false;
        private void getColor(Button button)
        {
            if (on)
            {
                lastButton.ForeColor = ColorTranslator.FromHtml("#eee");
                lastButton.BackColor = Color.Transparent;
            }
            button.BackColor = ColorTranslator.FromHtml("#eee");
            button.ForeColor = ColorTranslator.FromHtml("#476072");
        }

        private void btnHTTT_Click(object sender, EventArgs e)
        {
            getColor(btnHTTT);
            on = true;
            lastButton = btnHTTT;

            this.pnlLoad.Controls.Clear();
            FrmInfo frm_info = new FrmInfo() { Dock = DockStyle.Fill, TopLevel = false, TopMost = true };
            frm_info.FormBorderStyle = FormBorderStyle.None;
            this.pnlLoad.Controls.Add(frm_info);


            //Thu nghiem 2
            RestApi call = new RestApi();
            var staffList = call.getStaff("1");

            ListViewItem[] items = new ListViewItem[staffList.Count];
            for (int i = 0; i < staffList.Count; i++)
            {
                items[i] = new ListViewItem();
                items[i].Text = staffList[i].name;
                items[i].SubItems.Add(new ListViewItem.ListViewSubItem() { Text = staffList[i].year });
                items[i].SubItems.Add(new ListViewItem.ListViewSubItem() { Text = staffList[i].position });
                items[i].SubItems.Add(new ListViewItem.ListViewSubItem() { Text = staffList[i].city });
                items[i].SubItems.Add(new ListViewItem.ListViewSubItem() { Text = staffList[i].district });
                items[i].SubItems.Add(new ListViewItem.ListViewSubItem() { Text = staffList[i].salary + "₫" });
                items[i].SubItems.Add(new ListViewItem.ListViewSubItem() { Text = staffList[i].nameSub });
                items[i].SubItems.Add(new ListViewItem.ListViewSubItem() { Text = staffList[i].id });
                frm_info.LoadListView.Items.Add(items[i]);
            }
            frm_info.LoadListView.FullRowSelect = true;

            frm_info.Show();

        }

        private void btnKHMT_Click(object sender, EventArgs e)
        {
            getColor(btnKHMT);
            on = true;
            lastButton = btnKHMT;

            this.pnlLoad.Controls.Clear();
            FrmInfo frm_info = new FrmInfo() { Dock = DockStyle.Fill, TopLevel = false, TopMost = true };
            frm_info.FormBorderStyle = FormBorderStyle.None;
            this.pnlLoad.Controls.Add(frm_info);


            //Thu nghiem 2
            RestApi call = new RestApi();
            var staffList = call.getStaff("2");

            ListViewItem[] items = new ListViewItem[staffList.Count];
            for (int i = 0; i < staffList.Count; i++)
            {
                items[i] = new ListViewItem();
                items[i].Text = staffList[i].name;
                items[i].SubItems.Add(new ListViewItem.ListViewSubItem() { Text = staffList[i].year });
                items[i].SubItems.Add(new ListViewItem.ListViewSubItem() { Text = staffList[i].position });
                items[i].SubItems.Add(new ListViewItem.ListViewSubItem() { Text = staffList[i].city });
                items[i].SubItems.Add(new ListViewItem.ListViewSubItem() { Text = staffList[i].district });
                items[i].SubItems.Add(new ListViewItem.ListViewSubItem() { Text = staffList[i].salary + "₫" });
                items[i].SubItems.Add(new ListViewItem.ListViewSubItem() { Text = staffList[i].nameSub });
                items[i].SubItems.Add(new ListViewItem.ListViewSubItem() { Text = staffList[i].id });
                frm_info.LoadListView.Items.Add(items[i]);
            }
            frm_info.LoadListView.FullRowSelect = true;

            /*item1.SubItems.Add(new ListViewItem.ListViewSubItem() {Text = "sub item 1" });*/

            frm_info.Show();
        }

        private void pnlLoad_Paint(object sender, PaintEventArgs e)
        {

        }

        private void Dashboard_Load(object sender, EventArgs e)
        {

        }

        private void lblTile_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            //            frm_login user = new frm_login();
            //            string userID = user.getUserID();
            ///*            MessageBox.Show(user.getUserID());*/
            //            String imageLocation = "";
            //            try
            //            {
            //                OpenFileDialog dialog = new OpenFileDialog();
            //                dialog.Filter = "jpg files(*.jpg)|*.jpg| PNG files(*.png)|*.png| All Files(*.*)|*.*";
            //                if (dialog.ShowDialog() == System.Windows.Forms.DialogResult.OK)
            //                {

            //                    imageLocation = dialog.FileName;
            //                    String uri = "https://doan.khanhnhat.top";

            //                    var client = new RestClient(uri);
            //                    var request = new RestRequest("/api/upload.php", Method.Post);
            //                    request.AddFile("avatar", imageLocation);
            ///*                    MessageBox.Show(userID);*/
            //                    request.AddParameter("userID", userID.ToString());

            //                    request.AlwaysMultipartFormData = true;

            //                    RestResponse response = client.Execute(request);

            //                    if (response.IsSuccessful)
            //                    {
            //                        var img_url = JsonConvert.DeserializeObject<user>(response.Content);

            //                        avatar.ImageLocation = img_url.variable;
            //                    }

            //                }
            //            }
            //            catch (Exception)
            //            {
            //                MessageBox.Show("Đã xảy ra lỗi", "Lỗi!", MessageBoxButtons.OK, MessageBoxIcon.Error);
            //                throw;
            //            }
        }

        private void bntExit_Click(object sender, EventArgs e)
        {
            Application.Restart();

        }

        private void frmDashboard_FormClosed(object sender, FormClosedEventArgs e)
        {
            /*if (MessageBox.Show("Bạn muốn thoát chứ.", Application.ProductName, MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.No) ;*/
        }

        private void panel3_Paint(object sender, PaintEventArgs e)
        {

        }

        private void btnKTPM_Click(object sender, EventArgs e)
        {
            getColor(btnKTPM);
            on = true;
            lastButton = btnKTPM;

            this.pnlLoad.Controls.Clear();
            FrmInfo frm_info = new FrmInfo() { Dock = DockStyle.Fill, TopLevel = false, TopMost = true };
            frm_info.FormBorderStyle = FormBorderStyle.None;
            this.pnlLoad.Controls.Add(frm_info);


            //Thu nghiem 2
            RestApi call = new RestApi();
            var staffList = call.getStaff("3");

            ListViewItem[] items = new ListViewItem[staffList.Count];
            for (int i = 0; i < staffList.Count; i++)
            {
                items[i] = new ListViewItem();
                items[i].Text = staffList[i].name;
                items[i].SubItems.Add(new ListViewItem.ListViewSubItem() { Text = staffList[i].year });
                items[i].SubItems.Add(new ListViewItem.ListViewSubItem() { Text = staffList[i].position });
                items[i].SubItems.Add(new ListViewItem.ListViewSubItem() { Text = staffList[i].city });
                items[i].SubItems.Add(new ListViewItem.ListViewSubItem() { Text = staffList[i].district });
                items[i].SubItems.Add(new ListViewItem.ListViewSubItem() { Text = staffList[i].salary + "₫" });
                items[i].SubItems.Add(new ListViewItem.ListViewSubItem() { Text = staffList[i].nameSub });
                items[i].SubItems.Add(new ListViewItem.ListViewSubItem() { Text = staffList[i].id });
                frm_info.LoadListView.Items.Add(items[i]);
            }
            frm_info.LoadListView.FullRowSelect = true;

            frm_info.Show();
        }

        private void btnCNTT_Click(object sender, EventArgs e)
        {
            getColor(btnCNTT);
            on = true;
            lastButton = btnCNTT;

            this.pnlLoad.Controls.Clear();
            FrmInfo frm_info = new FrmInfo() { Dock = DockStyle.Fill, TopLevel = false, TopMost = true };
            frm_info.FormBorderStyle = FormBorderStyle.None;
            this.pnlLoad.Controls.Add(frm_info);


            //Thu nghiem 2
            RestApi call = new RestApi();
            var staffList = call.getStaff("2");

            ListViewItem[] items = new ListViewItem[staffList.Count];
            for (int i = 0; i < staffList.Count; i++)
            {
                items[i] = new ListViewItem();
                items[i].Text = staffList[i].name;
                items[i].SubItems.Add(new ListViewItem.ListViewSubItem() { Text = staffList[i].year });
                items[i].SubItems.Add(new ListViewItem.ListViewSubItem() { Text = staffList[i].position });
                items[i].SubItems.Add(new ListViewItem.ListViewSubItem() { Text = staffList[i].city });
                items[i].SubItems.Add(new ListViewItem.ListViewSubItem() { Text = staffList[i].district });
                items[i].SubItems.Add(new ListViewItem.ListViewSubItem() { Text = staffList[i].salary + "₫" });
                items[i].SubItems.Add(new ListViewItem.ListViewSubItem() { Text = staffList[i].nameSub });
                items[i].SubItems.Add(new ListViewItem.ListViewSubItem() { Text = staffList[i].id });
                frm_info.LoadListView.Items.Add(items[i]);
            }
            frm_info.LoadListView.FullRowSelect = true;

            frm_info.Show();
        }

        private void btnKHDL_Click(object sender, EventArgs e)
        {
            getColor(btnKHDL);
            on = true;
            lastButton = btnKHDL;

            this.pnlLoad.Controls.Clear();
            FrmInfo frm_info = new FrmInfo() { Dock = DockStyle.Fill, TopLevel = false, TopMost = true };
            frm_info.FormBorderStyle = FormBorderStyle.None;
            this.pnlLoad.Controls.Add(frm_info);


            //Thu nghiem 2
            RestApi call = new RestApi();
            var staffList = call.getStaff("2");

            ListViewItem[] items = new ListViewItem[staffList.Count];
            for (int i = 0; i < staffList.Count; i++)
            {
                items[i] = new ListViewItem();
                items[i].Text = staffList[i].name;
                items[i].SubItems.Add(new ListViewItem.ListViewSubItem() { Text = staffList[i].year });
                items[i].SubItems.Add(new ListViewItem.ListViewSubItem() { Text = staffList[i].position });
                items[i].SubItems.Add(new ListViewItem.ListViewSubItem() { Text = staffList[i].city });
                items[i].SubItems.Add(new ListViewItem.ListViewSubItem() { Text = staffList[i].district });
                items[i].SubItems.Add(new ListViewItem.ListViewSubItem() { Text = staffList[i].salary +"đ" });
                items[i].SubItems.Add(new ListViewItem.ListViewSubItem() { Text = staffList[i].nameSub });
                items[i].SubItems.Add(new ListViewItem.ListViewSubItem() { Text = staffList[i].id });

                frm_info.LoadListView.Items.Add(items[i]);
            }
            frm_info.LoadListView.FullRowSelect = true;

            frm_info.Show();
        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox1_MouseDoubleClick(object sender, MouseEventArgs e)
        {

        }

        private void panel2_Paint(object sender, PaintEventArgs e)
        {

        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            System.Windows.Forms.Application.Exit();
        }

        private void bntMinimize_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        /* private void button5_Click(object sender, EventArgs e)
         {
             this.Refresh();
         }*/

        private void btn_Edit_Click(object sender, EventArgs e)
        {
            getColor(btn_Edit);
            on = true;
            lastButton = btn_Edit;

            this.pnlLoad.Controls.Clear();
            FrmEdit frm_edit = new FrmEdit() { Dock = DockStyle.Fill, TopLevel = false, TopMost = true };
            frm_edit.FormBorderStyle = FormBorderStyle.None;
            this.pnlLoad.Controls.Add(frm_edit);

            frm_edit.Show();
        }

        private void label1_Click(object sender, EventArgs e)
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
    }
}
