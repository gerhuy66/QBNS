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
namespace QBNS
{
    public partial class FrReport : Form
    {
        public string shop_ID = "";
        String connectionString = String.Format(@"Data Source={0};Initial Catalog={1};Persist Security Info=True;User ID={2};Password={3}",
           Properties.Settings.Default.ServerName, Properties.Settings.Default.DBname, Properties.Settings.Default.userName, Properties.Settings.Default.passWord);
        public FrReport()
        {
            InitializeComponent();
        }

        private void crystalReportViewer1_Load(object sender, EventArgs e)
        {

        }

        private void AgrCrysReport1_InitReport(object sender, EventArgs e)
        {

        }

        private void FrReport_Load(object sender, EventArgs e)
        {
           SqlConnection conn = new SqlConnection(connectionString);
            try
            {
               
                conn.Open();
                DataTable dt = new DataTable();
                string sql = "SELECT AGR_ID,AGR_Name,DESCRIP,LOC_ID,Shop_ID,amount,unit,price,AGR_Type FROM AGRICULTURAL WHERE Shop_ID ='"+this.shop_ID+"'";
                SqlDataAdapter adapter = new SqlDataAdapter(sql, conn);
                adapter.Fill(dt);
                agrREPORT rp = new agrREPORT();
                rp.SetDataSource(dt);
                this.cryReportViewer.ReportSource = rp;

               

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
    }
}
