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
    public partial class DanhGiaFr : Form
    {
        String connectionString = String.Format(@"Data Source={0};Initial Catalog={1};Persist Security Info=True;User ID={2};Password={3}",
            Properties.Settings.Default.ServerName, Properties.Settings.Default.DBname, Properties.Settings.Default.userName, Properties.Settings.Default.passWord);
        private String agrID;

        public String AgrID
        {
            get { return agrID; }
            set { agrID = value; }
        }

        private int ratePoint;

        public int RPoint
        {
            get { return ratePoint; }
            set { ratePoint = value; }
        }

        public DanhGiaFr()
        {
            InitializeComponent();
        }

        private void DanhGiaFr_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            int rp = 0;
            if(radioButton1.Checked)
            {
                rp = 1;
            }
            if (radioButton2.Checked)
            {
                rp = 2;
            }
            if (radioButton3.Checked)
            {
                rp = 3;
            }
            if (radioButton4.Checked)
            {
                rp = 4;
            }
            submitRating(this.AgrID,rp);
            this.Hide();
           
                
            
        }
        private void submitRating(String AgrID, int rp)
        {
            SqlConnection con = new SqlConnection(connectionString);
            con.Open();
            try
            {
                String querry = String.Format("Insert into AGR_RATING(AGR_ID,RatePoint) VALUES('{0}','{1}')",AgrID,rp);
                SqlCommand cmd = new SqlCommand(querry, con);
                cmd.ExecuteNonQuery();
                MessageBox.Show("Đã Đánh Giá !", "Thông Báo");
            }catch(SqlException ex)
            {
                try
                {
                    String querry2 = String.Format("Update AGR_RATING SET RatePoint = {1},numVote = numVote+1 where AGR_ID = '{0}'", AgrID, rp);
                    SqlCommand cmd2 = new SqlCommand(querry2, con);
                    cmd2.ExecuteNonQuery();

                }
                catch (Exception ex2)
                {
                    MessageBox.Show(ex2.Message);
                }
            }
            catch (Exception ex3)
            {
                MessageBox.Show(ex3.Message);
            }
            finally
            {
                con.Close();
            }
        }
    }
}
