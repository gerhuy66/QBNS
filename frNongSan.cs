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
    public partial class frNongSan : Form
    {
        SqlConnection conn;
        SqlCommand cmd;
        String connectionString = String.Format(@"Data Source={0};Initial Catalog={1};Persist Security Info=True;User ID={2};Password={3}",
           Properties.Settings.Default.ServerName, Properties.Settings.Default.DBname, Properties.Settings.Default.userName, Properties.Settings.Default.passWord);
        public frNongSan()
        {
            InitializeComponent();
        }
        private String _defaultshopID;

        public String DefaultShopID
        {
            get { return _defaultshopID; }
            set { _defaultshopID = value; }
        }

        private void frNongSan_Load(object sender, EventArgs e)
        {
            loadDTGridView(_defaultshopID);
            this.Height = 768;
            this.Width = MdiParent.Width;
            if (!_defaultshopID.Equals("admin"))
            {
                this.tbMaCH.Text = _defaultshopID;
                this.tbMaCH.ReadOnly = true;
                this.tbMaCH.BackColor = Color.DarkBlue;
                this.tbMaCH.ForeColor = Color.White;
            }
            //aditem
            //VIEW
            // dtGriview.RowTemplate.Height = 50;
           
        }

        private void loadDTGridView(String shopID)
        {
            try
            {
                String sql = "select ag.AGR_ID as MaNS,ag.AGR_Name as TenNS,ag.IMG as HinhAnh,s.Shop_ID as MaCH,f.First_Name as fn," +
                        "f.Last_Name as ln,f.Avatar as Ava from AGRICULTURAL ag join SHOP s on ag.Shop_ID = s.Shop_ID join FARMER f " +
                        "on s.owner_ID = f.Farmer_ID where ag.Shop_ID like'"+shopID+"%'";
                conn = new SqlConnection(connectionString);
                conn.Open();
                cmd = new SqlCommand(sql, conn);
                DataTable dt = new DataTable();
                SqlDataAdapter adapter = new SqlDataAdapter(cmd);
                adapter.Fill(dt);
                //config DG
                dtGridView.DataSource = dt;
                dtGridView.Width= 950;
                dtGridView.Height = 600;
                dtGridView.BorderStyle = BorderStyle.None;
                dtGridView.DefaultCellStyle.SelectionForeColor = Color.LightYellow;
                dtGridView.DefaultCellStyle.SelectionBackColor = Color.DarkTurquoise;
                dtGridView.EnableHeadersVisualStyles = false;
                dtGridView.ColumnHeadersDefaultCellStyle.ForeColor = Color.DarkOrchid;
                dtGridView.ColumnHeadersDefaultCellStyle.BackColor = Color.LightYellow;
                dtGridView.ColumnHeadersHeight = 50;
                //set width
                dtGridView.Columns[0].Width = 120;
                dtGridView.Columns[1].Width = 120;
                dtGridView.Columns[2].Width = 120;
                dtGridView.Columns[3].Width = 120;
                dtGridView.Columns[4].Width = 120;
                dtGridView.Columns[5].Width = 120;
                dtGridView.Columns[6].Width = 120;
                pnTitle.Width = 950;
                //set heigth

                dtGridView.RowTemplate.Height = 150;
               
               


            }
            catch (Exception ex)
            {
                MessageBox.Show("Error:" + ex.Message);
            }
            finally
            {
                cmd.Dispose();
                conn.Close();
            }
        }
        private Image byteArrToImg(byte[] byteArr)
        {
            MemoryStream ms = new MemoryStream();
            Image returnIMG = Image.FromStream(ms);
            return returnIMG;
        }
        private void btnView_Click(object sender, EventArgs e)
        {

            
        }

        private void dtGriview_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            MessageBox.Show(sender.ToString());
        }

        private void dtGridView_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void btnAddAGR_Click(object sender, EventArgs e)//Click Button THEM NONG SAN
        {
            ThemNongSanFr qlns = new ThemNongSanFr();
            qlns.MdiParent = this.MdiParent;
            qlns.shopId =tbMaCH.Text.Trim();
            qlns.Show();
        }

        private void btnDelAGR_Click(object sender, EventArgs e)//Click Button Xoa
        {
            try
            {
                conn = new SqlConnection(connectionString);
                conn.Open();
                String sql = String.Format("Delete from AGRICULTURAL where AGR_ID = '{0}'",tbDelete.Text.Trim());
                cmd = new SqlCommand(sql, conn);
                cmd.ExecuteNonQuery();
                MessageBox.Show("Đã Xóa Nông Sản !");
                if(tbMaCH.Equals(""))
                    loadDTGridView("");//load ALL
                else
                    loadDTGridView(tbMaCH.Text.Trim());
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

        private void dtGridView_SelectionChanged(object sender, EventArgs e)
        {
            foreach(DataGridViewRow row in dtGridView.SelectedRows)
            {
                tbDelete.Text = row.Cells[0].Value.ToString();
            }
        }

        private void pnTitle_Paint(object sender, PaintEventArgs e)
        {

        }

        private void btnUpDate_Click(object sender, EventArgs e)//CLick Sua
        {
            ThemNongSanFr suaNongSanFr = new ThemNongSanFr();
            suaNongSanFr.MdiParent = this.MdiParent;
            suaNongSanFr.setChoosenAGR(this.tbDelete.Text.Trim());
            suaNongSanFr.Show();
        }

        private void btn_Refresh_Click(object sender, EventArgs e)//Click Refresh
        {
            if (tbMaCH.Equals(""))
                loadDTGridView("");
            else
                loadDTGridView(tbMaCH.Text.Trim());
        }

        private void tsNongSan_ItemClicked(object sender, ToolStripItemClickedEventArgs e)
        {

        }

        private void frNongSan_Scroll(object sender, ScrollEventArgs e)
        {
          
        }

        private void tbMaCH_TextChanged(object sender, EventArgs e)
        {
            TextBox tb = new TextBox();
            tb = (TextBox)sender;
            loadDTGridView(tb.Text.Trim());
        }
    }
}
