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

        private void frNongSan_Load(object sender, EventArgs e)
        {
            loadDTGridView();
            this.Height = 768;
            this.Width = MdiParent.Width;
            //aditem
            //VIEW
            // dtGriview.RowTemplate.Height = 50;
           
        }

        private void loadDTGridView()
        {
            try
            {
                String sql = "Select CONVERT(INT, SUBSTRING(AGR_ID,3,10)) AS code, ag.AGR_ID,ag.AGR_Name,ag.DESCRIP,ag.LOC_ID,ag.IMG From AGRICULTURAL ag ORDER BY(Code) ASC";
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
                dtGridView.Columns[0].Width = 50;
                dtGridView.Columns[1].Width = 100;
                dtGridView.Columns[2].Width = 150;
                dtGridView.Columns[3].Width = 300;
                dtGridView.Columns[4].Width = 100;
                dtGridView.Columns[5].Width = 300;
                pnTitle.Width = 950;
                //set heigth

                dtGridView.RowTemplate.Height = 150;
                //set column
                dtGridView.Columns[0].HeaderText = "STT";
                dtGridView.Columns[1].HeaderText = "Mã Nông Sản";
                dtGridView.Columns[2].HeaderText = "Tên Nông Sản";
                dtGridView.Columns[3].HeaderText = "Mô Tả";
                dtGridView.Columns[4].HeaderText = "Nguồn Gốc";
                dtGridView.Columns[5].HeaderText = "Hình Ảnh";


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
                loadDTGridView();
            }catch(Exception err)
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
                tbDelete.Text = row.Cells[1].Value.ToString();
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
            loadDTGridView();
        }

        private void tsNongSan_ItemClicked(object sender, ToolStripItemClickedEventArgs e)
        {

        }

        private void frNongSan_Scroll(object sender, ScrollEventArgs e)
        {
          
        }
    }
}
