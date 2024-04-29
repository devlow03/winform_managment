using management.api.request;
using management.api.response;
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
using System.IO;
using OfficeOpenXml;
using Excel = Microsoft.Office.Interop.Excel;



namespace management
{
    public partial class FrmInfo : Form
    {
        public FrmInfo()
        {
            InitializeComponent();
            getCity();
            getSub();
            getPos();
            txtId.Visible = false;


        }
        public void getSub()
        {
            RestApi call = new RestApi();
            var sub = call.getSub();
            Cb_sub.DisplayMember = "nameSub";
            Cb_sub.ValueMember = "subID";
            Cb_sub.DataSource = sub;

        }
        public void getCity()
        {
            Cb_city.Text = "Please, select any value";
            Cb_city.MaxLength = 200;
            String uri = "https://api.mysupership.vn";
            String route = "/v1/partner/areas/province";
            var client = new RestClient(uri);
            var request = new RestRequest(route, Method.Get);
            RestResponse response = client.Execute(request);
            var city = JsonConvert.DeserializeObject<CityResponse>(response.Content);
            Cb_city.ValueMember = "code";
            Cb_city.DisplayMember = "name";
            Cb_city.DataSource = city.results;
            Cb_city.Text = "--Select--";
            String code = Cb_city.SelectedValue.ToString();




        }
        public void getDistrict(String code)
        {
            Cb_dis.MaxLength = 200;
            String uri = "https://api.mysupership.vn";
            String route = "/v1/partner/areas/district";
            var client = new RestClient(uri);
            var request = new RestRequest(route, Method.Get);
            request.AddQueryParameter("province", code);
            RestResponse response = client.Execute(request);
            var dis = JsonConvert.DeserializeObject<DistrictResponse>(response.Content);
            Cb_dis.ValueMember = "code";
            Cb_dis.DisplayMember = "name";

            Cb_dis.DataSource = dis.results;


        }

        private void Cb_City_Click(object sender, EventArgs e)
        {
            String code = Cb_city.SelectedValue.ToString();
            Cb_dis.DataSource = null;
            Cb_dis.ResetText();
            getDistrict(code);
        }

        public void getPos()
        {
            List<Position> listPos = new List<Position>()
            {
                new Position(){name = "Trưởng Bộ môn"},
                new Position(){name = "Phó Trưởng bộ môn"},
                new Position(){name = "Giảng viên"},

            };
            Cb_pos.DataSource = listPos;
            Cb_pos.ValueMember = "name";

        }
        public class Position
        {
            public string name { get; set; }
        }
        private void btnAdd_Click(object sender, EventArgs e)
        {
            /*MessageBox.Show(Cb_pos.Text);*/
            RestApi call = new RestApi();
            var response = call.addStaff(txtName.Text, txtDate.Text, Cb_pos.Text, Cb_sub.SelectedValue.ToString(), Cb_city.Text, Cb_dis.Text, txtSalary.Text);
            MessageBox.Show(response.ToString());
            if (txtName.Text != "" && txtDate.Text != "" && txtSalary.Text != "")
            {
                ListViewItem item = listView1.Items.Add(txtName.Text);


                item.SubItems.Add(txtName.Text);

                item.SubItems.Add(txtDate.Text);
                item.SubItems.Add(Cb_pos.Text);
                item.SubItems.Add(Cb_city.Text);
                item.SubItems.Add(Cb_dis.Text);
                item.SubItems.Add(txtSalary.Text);
                item.SubItems.Add("");
                item.SubItems.Add("");

            }
        }
        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void FrmInfo_Load(object sender, EventArgs e)
        {

        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void listView1_SelectedIndexChanged(object sender, EventArgs e)
        {

            if (listView1.SelectedItems.Count > 0)
            {
                ListViewItem item = listView1.SelectedItems[0];
                txtName.Text = item.SubItems[0].Text;
                txtDate.Text = item.SubItems[1].Text;
                txtSalary.Text = item.SubItems[5].Text;
                Cb_pos.Text = item.SubItems[2].Text;
                Cb_city.Text = item.SubItems[3].Text;
                Cb_dis.Text = item.SubItems[4].Text;
                Cb_sub.Text = item.SubItems[6].Text;
                txtId.Text = item.SubItems[7].Text;
            }


        }
        public ListView LoadListView
        {
            get
            {
                return listView1;
            }
            set
            {

            }

        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }



        private void Cb_pos_Click(object sender, EventArgs e)
        {

        }

        private void Cb_dis_Click(object sender, EventArgs e)
        {

        }

        private void txtTen_TextChanged(object sender, EventArgs e)
        {

        }

        private void Cb_pos_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void Cb_sub_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
           
            if (listView1.SelectedItems.Count > 0)
            {
                RestApi call = new RestApi();
                var response = call.updateStaff(txtId.Text, txtName.Text, txtDate.Text, Cb_pos.Text, Cb_sub.SelectedValue.ToString(), Cb_city.Text, Cb_dis.Text, txtSalary.Text);
                MessageBox.Show(response.ToString());
                ListViewItem item = listView1.SelectedItems[0];
                item.SubItems[0].Text = txtName.Text;
                item.SubItems[1].Text = txtDate.Text;
                item.SubItems[5].Text = txtSalary.Text + "đ";
                item.SubItems[2].Text = Cb_pos.Text;
                item.SubItems[3].Text = Cb_city.Text;
                item.SubItems[4].Text = Cb_dis.Text;
                item.SubItems[6].Text = Cb_sub.Text;
                item.SubItems[7].Text = txtId.Text;
            }
           /* else
            {
                MessageBox.Show("Chọn nhân sự để chỉnh sửa");
            }*/


        }

        private void btnDel_Click(object sender, EventArgs e)
        {
         
            if(listView1.SelectedItems.Count > 0)
            {
                RestApi call = new RestApi();
                var response = call.removeStaff(txtId.Text);
                MessageBox.Show(response.ToString());
                listView1.Items.Remove(listView1.SelectedItems[0]);
            }
            else
            {
                MessageBox.Show("Chọn nhân sự để xóa");
            }

        }
        private void exportExcel(String path)
        {

        }

        private void btn_Del_Click(object sender, EventArgs e)
        {

            if (listView1.SelectedItems.Count > 0)
            {
                RestApi call = new RestApi();
                var response = call.removeStaff(txtId.Text);
                MessageBox.Show(response.ToString());
                listView1.Items.Remove(listView1.SelectedItems[0]);
            }
            else
            {
                MessageBox.Show("Chọn nhân sự để xóa");
            }

        }

        private void btn_Add_Click(object sender, EventArgs e)
        {
            /*MessageBox.Show(Cb_pos.Text);*/
            RestApi call = new RestApi();
            var response = call.addStaff(txtName.Text, txtDate.Text, Cb_pos.Text, Cb_sub.SelectedValue.ToString(), Cb_city.Text, Cb_dis.Text, txtSalary.Text);
            MessageBox.Show(response.ToString());
            if (txtName.Text != "" && txtDate.Text != "" && txtSalary.Text != "")
            {
                ListViewItem item = listView1.Items.Add(txtName.Text);
                item.SubItems.Add(txtDate.Text);
                item.SubItems.Add(Cb_pos.Text);
                item.SubItems.Add(Cb_city.Text);
                item.SubItems.Add(Cb_dis.Text);
                item.SubItems.Add(txtSalary.Text + "đ");
                item.SubItems.Add("");
                item.SubItems.Add("");
                Cb_sub.Text = item.SubItems[6].Text;

            }
        }

        private void btn_Update_Click(object sender, EventArgs e)
        {

            if (listView1.SelectedItems.Count > 0)
            {
                RestApi call = new RestApi();
                var response = call.updateStaff(txtId.Text, txtName.Text, txtDate.Text, Cb_pos.Text, Cb_sub.SelectedValue.ToString(), Cb_city.Text, Cb_dis.Text, txtSalary.Text);
                MessageBox.Show(response.ToString());
                ListViewItem item = listView1.SelectedItems[0];
                item.SubItems[0].Text = txtName.Text;
                item.SubItems[1].Text = txtDate.Text;
                item.SubItems[5].Text = txtSalary.Text;
                item.SubItems[2].Text = Cb_pos.Text;
                item.SubItems[3].Text = Cb_city.Text;
                item.SubItems[4].Text = Cb_dis.Text;
                item.SubItems[6].Text = Cb_sub.Text;
                item.SubItems[7].Text = txtId.Text;
            }
            else
            {
                MessageBox.Show("Chọn nhân sự để chỉnh sửa");
            }

        }

        private void customButton1_Click(object sender, EventArgs e)
        {
            SaveFileDialog saveFileDialog1 = new SaveFileDialog();
            saveFileDialog1.Filter = "Excel | *.xlsx | Excel 2003 | *.xls";
            if (saveFileDialog1.ShowDialog() == DialogResult.OK)
            {
                ToExcel(listView1, saveFileDialog1.FileName);
            }
        }
        private void ToExcel(ListView listview, string fileName)
        {

            //khai báo thư viện hỗ trợ Microsoft.Office.Interop.Excel
            Microsoft.Office.Interop.Excel.Application excel;
            Microsoft.Office.Interop.Excel.Workbook workbook;
            Microsoft.Office.Interop.Excel.Worksheet worksheet;
            try
            {
                /*MessageBox.Show("1");*/
                //Tạo đối tượng COM.
                excel = new Microsoft.Office.Interop.Excel.Application();
                    
                

                excel.Visible = false;
                excel.DisplayAlerts = false;
                //tạo mới một Workbooks bằng phương thức add()
                /*MessageBox.Show("2");*/

                workbook = excel.Workbooks.Add(Type.Missing);
                /*MessageBox.Show("3");*/

                //Chọn sheet sử dụng (sheet 1) - Không nên đặt tên vì mỗi máy tạo sheet tên khác nhau
                worksheet = (Microsoft.Office.Interop.Excel.Worksheet)workbook.Sheets[1];
                /*MessageBox.Show("4");*/

                //đặt tên cho sheet
                worksheet.Name = "Danh sách nhân sự";

                // export header trong ListView
                for (int i = 0; i < listView1.Columns.Count; i++)
                {
                    worksheet.Cells[1, i + 1] = listView1.Columns[i].Text;
                }

                // export nội dung trong ListView vào excel
                foreach (ListViewItem item in listview.Items)
                {
                    for (int i = 0; i < listView1.Columns.Count; i++)
                    {
                        worksheet.Cells[item.Index + 2, i + 1] = item.SubItems[i].Text;
                    }
                }

                // sử dụng phương thức SaveAs() để lưu workbook với filename
                workbook.SaveAs(fileName);
                //đóng workbook
                workbook.Close();
                excel.Quit();
                MessageBox.Show("Xuất dữ liệu ra Excel thành công!");
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            finally
            {
                workbook = null;
                worksheet = null;
            }
        }
    }
}
