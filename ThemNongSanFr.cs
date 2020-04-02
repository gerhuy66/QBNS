using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;
using System.IO;

namespace QBNS
{
    public partial class ThemNongSanFr : Form
    {

        private String AGR_CODE="";
        private String farmerPostAGR = "";
        SqlConnection conn;
        SqlCommand cmd;
        String connectionString = String.Format(@"Data Source={0};Initial Catalog={1};Persist Security Info=True;User ID={2};Password={3}",
            Properties.Settings.Default.ServerName,Properties.Settings.Default.DBname,Properties.Settings.Default.userName,Properties.Settings.Default.passWord);
        String imgLoc;
        public ThemNongSanFr()
        {
            InitializeComponent();
        }
        public void setChoosenAGR(String AGR_CODE)
        {
            this.AGR_CODE = AGR_CODE;
        }
        private void qlNongSanFr_Load(object sender, EventArgs e)
        {
            //load combobox location
            try {
                GetLocationList();
            }catch(Exception exception)
            {
                MessageBox.Show(exception.Message);
            }
            //load cb Unit
            this.cbDVT.Items.Add("VNĐ / Kg");
            this.cbDVT.Items.Add("VNĐ / Tấn");
            this.cbDVT.Items.Add("USD / KG");
            this.cbDVT.Items.Add("USD / Tấn");
            if (!AGR_CODE.Equals("")){
                setAgrChoosen();
                //;
            }


        }
        private Image byteArrToImg(byte[] byteArr)
        {
            MemoryStream ms = new MemoryStream();
            Image returnIMG = Image.FromStream(ms);
            return returnIMG;
        }
        public void setAgrChoosen()
        {
            try
            {
                conn = new SqlConnection(connectionString);
                conn.Open();
                cmd = new SqlCommand(String.Format("SELECT * FROM AGRICULTURAL WHERE AGR_ID ='{0}'",AGR_CODE), conn);
                //SqlDataReader reader = cmd.ExecuteReader();
                DataSet ds = new DataSet();
                SqlDataAdapter dataAdapter = new SqlDataAdapter(String.Format("SELECT * FROM AGRICULTURAL WHERE AGR_ID ='{0}'", AGR_CODE), conn);
                dataAdapter.Fill(ds);
                if(ds.Tables[0].Rows.Count != 0) {
                    Byte[] data = new Byte[0];
                    data = (byte[])ds.Tables[0].Rows[0]["IMG"];
                    MemoryStream ms = new MemoryStream(data);
                    this.pictureBox.Image = Image.FromStream(ms);
                    this.tbName.Text = ds.Tables[0].Rows[0]["AGR_Name"].ToString().Trim();
                    this.rtbDES.Text = ds.Tables[0].Rows[0]["DESCRIP"].ToString().Trim();
                    this.cbLocation.SelectedItem = ds.Tables[0].Rows[0]["LOC_ID"].ToString().Trim();
                    this.tbSoLuong.Text = ds.Tables[0].Rows[0]["amount"].ToString().Trim();
                    this.tbDonGia.Text = ds.Tables[0].Rows[0]["price"].ToString().Trim();
                    this.cbDVT.Text = ds.Tables[0].Rows[0]["unit"].ToString().Trim();
                }
            }
            catch(Exception err)
            {
                MessageBox.Show(err.Message);
            }
            finally
            {
                cmd.Dispose();
                conn.Close();
            }

        }
        public void GetLocationList()//Get LocationList
        {
            // Open connection to the database
            try {

                conn = new SqlConnection(connectionString);
                conn.Open();
                // Set up a command with the given query and associate
                // this with the current connection.
                cmd = new SqlCommand("select LOC_Name from LOCATION ORDER BY LOC_Name", conn);
                SqlDataReader dr = cmd.ExecuteReader();
                while (dr.Read())
                {
                    cbLocation.Items.Add(dr[0].ToString().Trim());
                }
                dr.Close();
            }catch(Exception exception)
            {
                MessageBox.Show(exception.Message);
            }
            finally
            {
                conn.Close();
            }

        }
        private string calculateCode()
        {
            String strRs="NS0";
            try
            {
                SqlConnection conn2 = new SqlConnection(connectionString);
                conn2.Open();
                String sql = "SELECT CONVERT(INT, SUBSTRING(AGR_ID,3,10)) AS code FROM AGRICULTURAL ORDER BY(code) DESC";
                SqlCommand cmd2 = new SqlCommand(sql, conn2);
                SqlDataReader reader_Code = cmd2.ExecuteReader();
                if(reader_Code.Read())
                {
                    strRs = reader_Code[0].ToString();
                    Int32 AgrNum = Int32.Parse(strRs) + 1;
                    strRs = "NS" + AgrNum.ToString().Trim();
                }
                reader_Code.Close();
                cmd2.Dispose();
                conn2.Close();
            }
            catch(Exception exc)
            {
                MessageBox.Show(exc.Message);
            }
            
            
            return strRs;
        }
        
        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void pictureBox_Click(object sender, EventArgs e)
        {

        }
        private void btnBrow_Click_1(object sender, EventArgs e)
        {
            OpenFileDialog dialog = new OpenFileDialog();
            dialog.Filter = "png files(*.png)|*.png|jpg files(*.jpg)|*.jpg|All files(*.*)|*.*";
            if (dialog.ShowDialog() == DialogResult.OK)
            {
                imgLoc = dialog.FileName.ToString();
                pictureBox.ImageLocation = imgLoc;
            }
        }

        private void panel3_Paint(object sender, PaintEventArgs e)
        {

        }

        private void btnSave_Click_2(object sender, EventArgs e)
        {
            String query = "";

            if (this.AGR_CODE.Equals(""))
            {
                query = String.Format("Insert into AGRICULTURAL(AGR_ID,AGR_Name,DESCRIP,LOC_ID,IMG,Shop_ID,amount,unit,price) VALUES('{0}','{1}','{2}','{3}'," + "@images" +",'','{4}','{5}','{6}')"
                    , calculateCode(), tbName.Text, rtbDES.Text, cbLocation.SelectedItem.ToString(),tbSoLuong.Text,cbDVT.SelectedItem.ToString().Trim(),tbDonGia.Text);
            }
            else
            {

                query = String.Format("UPDATE AGRICULTURAL SET AGR_Name = '{0}',DESCRIP= '{1}',LOC_ID='{2}',amount='{4}',unit='{5}',price='{6}',IMG =@images WHERE AGR_ID = '{3}'", tbName.Text, rtbDES.Text, cbLocation.SelectedItem.ToString(), this.AGR_CODE,tbSoLuong.Text,cbDVT.Text.ToString().Trim(),tbDonGia.Text);
            }
            try
            {
                conn = new SqlConnection(connectionString);
                conn.Open();
                MessageBox.Show(query);
                cmd = new SqlCommand(query, conn);
                try {
                    if (this.AGR_CODE.Equals("")) 
                    { 
                        byte[] images = null;
                        FileStream stream = new FileStream(imgLoc, FileMode.Open, FileAccess.Read);
                        BinaryReader brs = new BinaryReader(stream);
                        images = brs.ReadBytes((int)stream.Length);
                        cmd.Parameters.Add(new SqlParameter("@images", images));
                        stream.Close();
                    }
                    else {
                        ImageConverter _imageConverter = new ImageConverter();
                        byte[] xByte = (byte[])_imageConverter.ConvertTo(this.pictureBox.Image, typeof(byte[]));
                        cmd.Parameters.Add(new SqlParameter("@images", xByte));
                    }
                }
                catch(Exception err)
                {
                    MessageBox.Show(err.Message);
                }
                cmd.ExecuteNonQuery();
                MessageBox.Show("Thêm Nông Sản Thành Công !");
            }
            catch (Exception exp)
            {
                MessageBox.Show(exp.Message);
            }
            finally
            {
                cmd.Dispose();
                conn.Close();
                
            }
        }

        private void cbDVT_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}
