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
        public String agrID
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
            set { _message = value; richTB.Text = value; }
        }
        [Category("Custome Props")]
        public Image Icon
        {
            get { return _icon; }
            set { _icon = value; agrPIC.Image = value; }
        }

        #endregion

        private void btnDetails_Click(object sender, EventArgs e)
        {

        }

        private void AgrItem_Load(object sender, EventArgs e)
        {

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
    }
}
