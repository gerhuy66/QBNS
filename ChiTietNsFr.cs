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
    public partial class ChiTietNsFr : Form
    {
        private String farmer_id;
        private String agrID;
        String connectionString = String.Format(@"Data Source={0};Initial Catalog={1};Persist Security Info=True;User ID={2};Password={3}",
           Properties.Settings.Default.ServerName, Properties.Settings.Default.DBname, Properties.Settings.Default.userName, Properties.Settings.Default.passWord);

        public String AGRID
        {
            get { return agrID; }
            set { agrID = value; }
        }

        public String Farmer_ID
        {
            get { return farmer_id; }
            set { farmer_id = value; }
        }

        public ChiTietNsFr()
        {
            InitializeComponent();
        }

        private void ChiTietNsFr_Load(object sender, EventArgs e)
        {
            loadOwnerInfo(Farmer_ID);
            loadShopInfo(Farmer_ID);
            loadAgr(AGRID);
        }
        private void loadOwnerInfo(String owner_ID)
        {
            SqlConnection con = new SqlConnection(connectionString);
            con.Open();
            try
            {
               
                DataSet ds = new DataSet();
                SqlDataAdapter adapter = new SqlDataAdapter(String.Format("SELECT * FROM FARMER WHERE Farmer_ID ='{0}'", owner_ID), con);
                adapter.Fill(ds);
                if (ds.Tables[0].Rows.Count > 0)
                {
                    tbTenChuCH.Text = ds.Tables[0].Rows[0]["First_Name"].ToString().Trim() + " " + ds.Tables[0].Rows[0]["Last_Name"].ToString().Trim();
                    tbSDT.Text = ds.Tables[0].Rows[0]["Phone_Num"].ToString().Trim();
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
                con.Close();
            }
        }
        private void loadShopInfo(String ownerID)
        {
            SqlConnection con = new SqlConnection(connectionString);
            con.Open();
            try
            {
              
     
                DataSet ds = new DataSet();
                SqlDataAdapter adapter = new SqlDataAdapter(String.Format("SELECT * FROM SHOP WHERE owner_ID ='{0}'", ownerID), con);
                adapter.Fill(ds);

                if (ds.Tables[0].Rows.Count > 0)
                {
                    //MessageBox.Show(ds.Tables[0].Rows[0]["shop_Name"].ToString().Trim());
                    tbTenShop.Text = ds.Tables[0].Rows[0]["shop_Name"].ToString().Trim();
                    tbDiaChi.Text = ds.Tables[0].Rows[0]["shop_Address"].ToString().Trim();
                }
                adapter.Dispose();
            }
            catch (Exception err)
            {
                MessageBox.Show(err.Message);
            }
            finally
            {
                con.Close();
            }
        }
        private void loadAgr(String agrID)
        {
            SqlConnection con = new SqlConnection(connectionString);
            con.Open();
            String sql = "select * from AGRICULTURAL WHERE AGR_ID like" + " '"+ agrID + "'";
            
            try
            {
                SqlDataAdapter da = new SqlDataAdapter(sql, con);
                DataSet ds = new DataSet();
                da.Fill(ds);
                if(ds.Tables[0].Rows.Count > 0)
                {
                    //load avatar
                    Byte[] data = new Byte[0];
                    data = (byte[])ds.Tables[0].Rows[0]["IMG"];
                    MemoryStream ms = new MemoryStream(data);
                    this.agrPic.Image = Image.FromStream(ms);
                    this.lbTenNS.Text = ds.Tables[0].Rows[0]["AGR_Name"].ToString().Trim();
                    this.richTextBoxDES.Text= ds.Tables[0].Rows[0]["DESCRIP"].ToString().Trim();
                    this.lbLocation.Text += ds.Tables[0].Rows[0]["LOC_ID"].ToString().Trim();
                    this.lbSanLuong.Text += ds.Tables[0].Rows[0]["amount"].ToString().Trim();
                    this.lbDonGia.Text += ds.Tables[0].Rows[0]["price"].ToString().Trim();
                    this.lbDVT.Text = ds.Tables[0].Rows[0]["unit"].ToString().Trim();
                }
                else
                {
                    MessageBox.Show("Không tìm thấy nông sản", "Thông Báo", MessageBoxButtons.OK);
                }
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            finally
            {
                con.Close();
            }
        }

        private void btnRate_Click(object sender, EventArgs e)
        {
            DanhGiaFr dgiaFr = new DanhGiaFr();
            dgiaFr.MdiParent = this.MdiParent;
            dgiaFr.AgrID = this.agrID;
            dgiaFr.Show();
        }
    }
}
