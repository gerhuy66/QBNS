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
    public partial class ShopFr : Form
    {
        private String owner_ID="";
        private String shop_ID = "";

        SqlConnection conn;
        SqlCommand cmd;
        String connectionString = String.Format(@"Data Source={0};Initial Catalog={1};Persist Security Info=True;User ID={2};Password={3}",
            Properties.Settings.Default.ServerName, Properties.Settings.Default.DBname, Properties.Settings.Default.userName, Properties.Settings.Default.passWord);
        public ShopFr()
        {
            InitializeComponent();
        }
        public void setOwnerID(String ID)
        {
            this.owner_ID = ID;
        }
        public void setShopID(String ID)
        {
            this.shop_ID = ID;
        }
        private void loadOwnerInfo()
        {
            try
            {
                conn = new SqlConnection(connectionString);
                conn.Open();
                DataSet ds = new DataSet();
                SqlDataAdapter adapter = new SqlDataAdapter(String.Format("SELECT * FROM FARMER WHERE Farmer_ID ='{0}'", this.owner_ID), conn);
                adapter.Fill(ds);
                if(ds.Tables[0].Rows.Count > 0)
                {
                    tbTenChuCH.Text =ds.Tables[0].Rows[0]["First_Name"].ToString().Trim() + " " + ds.Tables[0].Rows[0]["Last_Name"].ToString().Trim();
                    tbSDT.Text =ds.Tables[0].Rows[0]["Phone_Num"].ToString().Trim();
                    //load avatar
                    Byte[] data = new Byte[0];
                    data = (byte[])ds.Tables[0].Rows[0]["Avatar"];
                    MemoryStream ms = new MemoryStream(data);
                    this.avatar.Image = Image.FromStream(ms);
                }
                adapter.Dispose();
            }
            catch (Exception err)
            {
                MessageBox.Show(err.Message);
            }
            finally
            {
                conn.Close();
            }
        }
        private void loadShopInfo()
        {
            try
            {
                conn = new SqlConnection(connectionString);
                conn.Open();
                DataSet ds = new DataSet();
                SqlDataAdapter adapter = new SqlDataAdapter(String.Format("SELECT * FROM SHOP WHERE owner_ID ='{0}'", this.owner_ID), conn);
                adapter.Fill(ds);
                
                if (ds.Tables[0].Rows.Count > 0)
                {
                    //MessageBox.Show(ds.Tables[0].Rows[0]["shop_Name"].ToString().Trim());
                    tbTenShop.Text =ds.Tables[0].Rows[0]["shop_Name"].ToString().Trim();
                    tbDiaChi.Text =ds.Tables[0].Rows[0]["shop_Address"].ToString().Trim();
                }
                adapter.Dispose();
            }
            catch (Exception err)
            {
                MessageBox.Show(err.Message);
            }
            finally
            {
                conn.Close();
            }
        }
        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void ShopFr_Load(object sender, EventArgs e)
        {
            populateItem();
            loadOwnerInfo();
            loadShopInfo();
            
        }
        private void populateItem()
        {
            try
            {
                conn = new SqlConnection(connectionString);
                conn.Open();
                DataSet ds = new DataSet();
                SqlDataAdapter adapter = new SqlDataAdapter(String.Format("SELECT * FROM AGRICULTURAL WHERE shop_ID ='{0}'", this.shop_ID), conn);
                adapter.Fill(ds);
                int count = ds.Tables[0].Rows.Count;
                AgrItem[] agrList = new AgrItem[count];
                for (int i = 0; i < count; i++)
                {
                    agrList[i] = new AgrItem();
                    agrList[i].Title = ds.Tables[0].Rows[i]["AGR_Name"].ToString().Trim();
                    agrList[i].Message = ds.Tables[0].Rows[i]["DESCRIP"].ToString().Trim();
                    agrList[i].agrID = ds.Tables[0].Rows[i]["AGR_ID"].ToString().Trim();
                    agrList[i].Amount = ds.Tables[0].Rows[i]["amount"].ToString().Trim();
                    agrList[i].Price = ds.Tables[0].Rows[i]["price"].ToString().Trim();
                    agrList[i].Unit = ds.Tables[0].Rows[i]["unit"].ToString().Trim();
                    agrList[i].Instance = this.MdiParent;
                    Byte[] data = new Byte[0];
                    data = (byte[])ds.Tables[0].Rows[i]["IMG"];
                    MemoryStream ms = new MemoryStream(data);
                    agrList[i].Icon =Image.FromStream(ms);
                    if (flowLayoutPanel1.Controls.Count < 0)
                    {
                        flowLayoutPanel1.Controls.Clear();
                    }
                    else
                    {
                        flowLayoutPanel1.Controls.Add(agrList[i]);
                    }
                }
                
            }catch(Exception e)
            {
                MessageBox.Show(e.Message);
            }
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void btnRefresh_Click(object sender, EventArgs e)//Click Refresh
        {
            flowLayoutPanel1.Controls.Clear();
            populateItem();
        }

        private void avatar_Click(object sender, EventArgs e)
        {
            
            OpenFileDialog dialog = new OpenFileDialog();
            dialog.Filter = "png files(*.png)|*.png|jpg files(*.jpg)|*.jpg|All files(*.*)|*.*";
            if (dialog.ShowDialog() == DialogResult.OK)
            {
                string imgLoc = dialog.FileName.ToString();
                avatar.ImageLocation = imgLoc;
                //insert Ava
                try
                {
                    String query = "";
                    query = String.Format("UPDATE FARMER SET Avatar = @images WHERE Farmer_ID = '{0}'", owner_ID);
                    conn = new SqlConnection(connectionString);
                    conn.Open();
                    cmd = new SqlCommand(query, conn);
                    byte[] images = null;
                    FileStream stream = new FileStream(imgLoc, FileMode.Open, FileAccess.Read);
                    BinaryReader brs = new BinaryReader(stream);
                    images = brs.ReadBytes((int)stream.Length);
                    cmd.Parameters.Add(new SqlParameter("@images", images));
                    cmd.ExecuteNonQuery();
                    stream.Close();
                }
                catch (Exception exce)
                {
                    MessageBox.Show(exce.Message);
                }
                finally
                {
                    cmd.Dispose();
                    conn.Close();
                }
            }
           
            
            
        }

        private void btnCapNhat_Click(object sender, EventArgs e)
        {
            String query = "";
                query = String.Format("UPDATE SHOP SET owner_ID = '{0}',shop_phone = '{1}',shop_Name = '{2}',shop_Address ='{3}' WHERE Shop_ID='{4}'",owner_ID,tbSDT.Text,tbTenShop.Text,tbDiaChi.Text,shop_ID);
            try
            {
                conn = new SqlConnection(connectionString);
                conn.Open();
                cmd = new SqlCommand(query, conn);
                cmd.ExecuteNonQuery();
                MessageBox.Show("Chỉnh Sửa Thông Tin Thành Công !");
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
    }
}
