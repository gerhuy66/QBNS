using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace QBNS
{
    public partial class AgrItem : UserControl
    {
        SqlConnection conn;
        SqlCommand cmd;
        String connectionString = String.Format(@"Data Source={0};Initial Catalog={1};Persist Security Info=True;User ID={2};Password={3}",
           Properties.Settings.Default.ServerName, Properties.Settings.Default.DBname, Properties.Settings.Default.userName, Properties.Settings.Default.passWord);
        public AgrItem()
        {
            InitializeComponent();
        }
        #region Properties

        private String _title;
        private String _message;
        private Image _icon;
        private String _agrID;
        private String _amount;
        private String _price;
        private String _unit;
        private String _farmer_ID;

      
        private static System.Windows.Forms.Form _instance;
        public String FarmerID
        {
            get { return _farmer_ID; }
            set { _farmer_ID = value; }
        }


        public System.Windows.Forms.Form Instance
        {
            get { return _instance; }
            set { _instance = value; }
        }

        [Category("Custome Props")]
        public String Unit
        {
            get { return _unit; }
            set { _unit = value; this.lbDVT.Text += " " + value; }
        }


        [Category("Custome Props")]
        public String Price
        {
            get { return _price; }
            set { _price = value; this.lbDonGia.Text += " " + value; }
        }

        [Category("Custome Props")]
        public String Amount
        {
            get { return _amount; }
            set { _amount = value; this.lbSoLuong.Text += " " + value; }
        }


        [Category("Custome Props")]
        public String AgrID
        {
            get { return _agrID; }
            set { _agrID = value; }
        }

        [Category("Custome Props")]
        public String Title
        {
            get { return _title; }
            set { _title = value; lbNameAG.Text = value; }
        }
        [Category("Custome Props")]
        public String Message
        {
            get { return _message; }
            set { _message = value; //richTB.Text = value; 
            }
        }
        [Category("Custome Props")]
        public Image Icon
        {
            get { return _icon; }
            set { _icon = value; agrPIC.Image = value; }
        }
        private bool _traderView = false;
        public bool isTraderView
        {
            get { return _traderView; }
            set { _traderView = value; }
        }


        #endregion

        private void btnDetails_Click(object sender, EventArgs e)
        {

        }

        private void AgrItem_Load(object sender, EventArgs e)
        {
            if(isTraderView)
            {
                this.btnUpdate.Visible = false;
                this.btnDelete.Visible = false;
            }
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

      

        private void btnUpdate_Click(object sender, EventArgs e)//Update
        {
            
        }

        private void lbNameAG_Click(object sender, EventArgs e)
        {

        }

        private void pmDES_Paint(object sender, PaintEventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)//click chi tiet
        {
            ChiTietNsFr ctFr = new ChiTietNsFr();
           // ctFr.MdiParent = this.Instance;
            ctFr.Farmer_ID = this.FarmerID;
            ctFr.AGRID = this.AgrID;
            ctFr.BringToFront();
            ctFr.Show();
        }

        private void btnUpdate_Click_1(object sender, EventArgs e)
        {
            ThemNongSanFr themNongSanFr = new ThemNongSanFr();
            themNongSanFr.setChoosenAGR(AgrID);
            themNongSanFr.MdiParent = this.Instance;
            themNongSanFr.Show();
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            SqlConnection con = new SqlConnection(connectionString);
            con.Open();
            try
            {
                String sql = "Delete From AGRICULTURAL Where AGR_ID ='" +AgrID+ "'";
                SqlCommand cmd = new SqlCommand(sql, con);
                cmd.ExecuteNonQuery();
                MessageBox.Show("Đã xóa nông sản ! hãy cập nhật lại cửa hàng", "Thông Báo", MessageBoxButtons.OK);
                
            }catch(SqlException sqlex)
            {
                MessageBox.Show("Lỗi SQL:" + sqlex.Message);
            }
            finally
            {
                con.Close();
            }

        }
    }
}
