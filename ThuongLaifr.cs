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



    public partial class ThuongLaiFr : Form
    {
        private String nameAG = "";
        private String typeAG = "";
        private String locateAG = "";
        SqlConnection conn;
        SqlCommand cmd;
        String connectionString = String.Format(@"Data Source={0};Initial Catalog={1};Persist Security Info=True;User ID={2};Password={3}",
            Properties.Settings.Default.ServerName, Properties.Settings.Default.DBname, Properties.Settings.Default.userName, Properties.Settings.Default.passWord);
        public ThuongLaiFr()
        {
            InitializeComponent();
        }

        private void ThuongLaiFr_Load(object sender, EventArgs e)
        {
            this.cbLoaiNS.DropDownStyle = ComboBoxStyle.DropDownList;
            this.cbXuatXu.DropDownStyle = ComboBoxStyle.DropDownList;
            loadComboBoxData();
            populateItem(nameAG, typeAG, locateAG);
        }
        private Boolean isExistCbXuatXuItem(String item)
        {
            foreach(var i in cbXuatXu.Items)
            {
                if (i.ToString().Trim().Equals(item))
                    return true;
            }
            return false;
        }
      
        private void loadComboBoxData()
        {
            this.cbLoaiNS.Items.Add("Tat Ca");
            this.cbXuatXu.Items.Add("Tat Ca");
            SqlConnection coon2 = new SqlConnection(connectionString);
            DataSet ds = new DataSet();
            try
            {
                coon2.Open();
                String sql = "SELECT DISTINCT AGR_Type FROM AGRICULTURAL";
                SqlDataAdapter adapter = new SqlDataAdapter(sql, coon2);
                adapter.Fill(ds);
                int count = ds.Tables[0].Rows.Count;
                for (int i = 0; i < count; i++)
                {
                    if(!ds.Tables[0].Rows[i]["AGR_Type"].ToString().Equals(""))
                       this.cbLoaiNS.Items.Add(ds.Tables[0].Rows[i]["AGR_Type"].ToString().Trim());
                }
                sql = "SELECT DISTINCT LOC_ID FROM AGRICULTURAL";
                adapter = new SqlDataAdapter(sql, coon2);
                adapter.Fill(ds);
                count = ds.Tables[0].Rows.Count;
                for (int i = 0; i < count; i++)
                {
                    if (!ds.Tables[0].Rows[i]["LOC_ID"].ToString().Equals(""))
                        this.cbXuatXu.Items.Add(ds.Tables[0].Rows[i]["LOC_ID"].ToString().Trim());
                }
            }
            catch (Exception e)
            {
                MessageBox.Show(e.Message);
            }
            finally
            {
                coon2.Close();
            }
        }
        private String getFarmerIDbyShopID(String shopID)
        {
            conn = new SqlConnection(connectionString);
            conn.Open();
            try
            {
                String sql = "Select owner_ID From SHOP Where Shop_ID ='" + shopID + "'";
                SqlCommand cmd = new SqlCommand(sql, conn);
                SqlDataReader rd = cmd.ExecuteReader();
                if (rd.Read())
                {
                    return rd.GetString(0);
                }
                else
                {
                    MessageBox.Show("Không tìm thấy thông tin farmer");
                }

            }
            catch(Exception exc)
            {
                MessageBox.Show(exc.Message);
            }
            finally
            {
                conn.Close();
            }
            return "";
        }
        private int populateItem(String name, String type, String location)
        {
            int count = 0;
            try
            {
                conn = new SqlConnection(connectionString);
                conn.Open();
                DataSet ds = new DataSet();
                String sql = "";
                if (name.Equals("") && type.Equals("") && location.Equals(""))
                    sql = "SELECT * FROM AGRICULTURAL ag left join AGR_RATING ar on ag.AGR_ID = ar.AGR_ID ORDER BY ar.RatePoint DESC";
                else
                { 
                    sql = String.Format("select * from AGRICULTURAL where AGR_Name like '{0}%' " +
                        "and AGR_Type like '{1}%' and LOC_ID like '{2}%'", name, type, location);
                }
                SqlDataAdapter adapter = new SqlDataAdapter(sql, conn);
                adapter.Fill(ds);
                count = ds.Tables[0].Rows.Count;
                if (count == 0)
                {
                    lbResultMessage.Text = String.Format("Không Tìm Thấy nông sản nào với tên: {0}   loại: {1}   xuất xứ: {2} !", name, type, location);
                    return count;
                }
                lbResultMessage.Text = String.Format("Tìm Thấy {0} nông sản với tên: {1}   loại: {2}   xuất xứ: {3}", count.ToString(), name, type, location);
                AgrItem[] agrList = new AgrItem[count];
                for (int i = 0; i < count; i++)
                {
                    agrList[i] = new AgrItem();
                    agrList[i].Title = ds.Tables[0].Rows[i]["AGR_Name"].ToString().Trim();
                    agrList[i].Message = ds.Tables[0].Rows[i]["DESCRIP"].ToString().Trim();
                    agrList[i].AgrID = ds.Tables[0].Rows[i]["AGR_ID"].ToString().Trim();
                    agrList[i].Amount = ds.Tables[0].Rows[i]["amount"].ToString().Trim();
                    agrList[i].Price = ds.Tables[0].Rows[i]["price"].ToString().Trim();
                    agrList[i].Unit = ds.Tables[0].Rows[i]["unit"].ToString().Trim();
                    agrList[i].Instance = this.MdiParent;
                    agrList[i].FarmerID = getFarmerIDbyShopID(ds.Tables[0].Rows[i]["Shop_ID"].ToString().Trim());
                    agrList[i].isTraderView = true;
                    Byte[] data = new Byte[0];
                    data = (byte[])ds.Tables[0].Rows[i]["IMG"];
                    MemoryStream ms = new MemoryStream(data);
                    agrList[i].Icon = Image.FromStream(ms);
                    if (flowPNMain.Controls.Count < 0)
                    {
                        flowPNMain.Controls.Clear();
                    }
                    else
                    {
                        flowPNMain.Controls.Add(agrList[i]);
                    }

                }


            }
            catch (Exception e)
            {
                MessageBox.Show(e.Message);
            }
            finally
            {
                conn.Close();
            }
            return count;
        }
        private void button1_Click(object sender, EventArgs e)//click tim kiem
        {
            flowPNMain.Controls.Clear();
            if (this.typeAG.Equals("Tat Ca"))
                this.typeAG = "";
            if (this.locateAG.Equals("Tat Ca"))
                this.locateAG = "";
            populateItem(this.nameAG,this.typeAG,this.locateAG);
        }

        private void tbTenNS_TextChanged(object sender, EventArgs e)
        {
            TextBox tb = (TextBox)sender;
            this.nameAG = tb.Text;
            flowPNMain.Controls.Clear();
            populateItem(this.nameAG, this.typeAG, this.locateAG);
        }

        private void cbLoaiNS_SelectedIndexChanged(object sender, EventArgs e)
        {
            ComboBox cb = (ComboBox)sender;
            this.typeAG = cb.SelectedItem.ToString().Trim();
        }

        private void cbXuatXu_SelectedIndexChanged(object sender, EventArgs e)
        {
            ComboBox cb = (ComboBox)sender;
            this.locateAG = cb.SelectedItem.ToString().Trim();
        }
    }
}
