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
            populateItem();
        }
        private void populateItem()
        {
            try
            {
                conn = new SqlConnection(connectionString);
                conn.Open();
                DataSet ds = new DataSet();
                SqlDataAdapter adapter = new SqlDataAdapter("SELECT * FROM AGRICULTURAL", conn);
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
        }

        private void button1_Click(object sender, EventArgs e)
        {

        }
    }
}
