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
    public partial class MainForm : Form
    {
        String connectionString = String.Format(@"Data Source={0};Initial Catalog={1};Persist Security Info=True;User ID={2};Password={3}",
            Properties.Settings.Default.ServerName, Properties.Settings.Default.DBname, Properties.Settings.Default.userName, Properties.Settings.Default.passWord);
        public MainForm()
        {
            InitializeComponent();
        }
        private String _logIn_User = "";

        public String LogInUser
        {
            get { return _logIn_User; }
            set { _logIn_User = value; }
        }


        private void MainForm_Load(object sender, EventArgs e)
        {
            //setting mainform
            //this.TopMost = true;
            //this.FormBorderStyle = FormBorderStyle.None;

            // this.WindowState = FormWindowState.Maximized;

            //add item to tool strip menu
            this.IsMdiContainer = true;
            this.WindowState = FormWindowState.Maximized;
            //nong san
            ToolStripMenuItem nongSanItem = new ToolStripMenuItem("Nông Sản");
            nongSanItem.Name = "nongSanItem";
            toolStripMenu.Items.Add(nongSanItem);
            nongSanItem.Click += nongSanItem_Click;
            //shop
            ToolStripMenuItem shopItem = new ToolStripMenuItem("Shop");
            shopItem.Name = "shopItem";
            toolStripMenu.Items.Add(shopItem);
            shopItem.Click += shopItem_Click;
            //Thuong Lai
            ToolStripMenuItem thiTruongItem = new ToolStripMenuItem("Thị Trường");
            thiTruongItem.Name = "thiTruongItem";
            toolStripMenu.Items.Add(thiTruongItem);
            thiTruongItem.Click += thiTruongItem_Click;

            //exit
            ToolStripMenuItem exit = new ToolStripMenuItem("Thoát");
            toolStripMenu.Items.Add(exit);
            exit.Click += Exit_Click;
            //label
            ToolStripLabel userLabel = new ToolStripLabel("User: " + LogInUser);
            toolStripMenu.Items.Add(userLabel);
            userLabel.BackColor = Color.Blue;

            if (!getAccountType(LogInUser).Equals(""))
            {
                if (getAccountType(LogInUser).Substring(0, 1).Equals("F"))//user is farmer
                {
                    nongSanItem.Visible = false;
                }
                if (getAccountType(LogInUser).Substring(0, 2).Equals("tr"))//user is trader
                {
                    nongSanItem.Visible = false;
                    shopItem.Visible = false;
                }
                if (LogInUser.Equals("admin"))//user is admin
                {
                    shopItem.Visible = false;
                }
            }

        }

        public String getAccountType(String username)
        {
            SqlConnection con = new SqlConnection(connectionString);
            con.Open();
            try
            {
                String sql = "select Farmer_ID,Trader_ID from ACCOUNT where username ='" + username + "'";
                SqlCommand cmd = new SqlCommand(sql, con);
                SqlDataReader reader = cmd.ExecuteReader();
                if (reader.Read())
                {
                    String fID = reader.GetValue(0).ToString();
                    String tID = reader.GetValue(1).ToString();
                    if (fID.Equals(""))// user is trader
                    {
                        return tID;
                    }
                    else
                        return fID;
                }
            }
            catch (Exception exc)
            {
                MessageBox.Show(exc.Message + "here");
            }
            finally
            {
                con.Close();
            }
            return "";
        }
        private void thiTruongItem_Click(object sender, EventArgs e)//click thi truong
        {
            Boolean isopen = false;
            foreach (Form f in Application.OpenForms)
            {
                if (f.Name == "thiTruongItem")
                {
                    isopen = true;
                    f.BringToFront();
                    break;
                }
            }
            if (!isopen)
            {
                ThuongLaiFr thuongLaiFr = new ThuongLaiFr();
                thuongLaiFr.MdiParent = this;
                thuongLaiFr.Name = "ThuongLaiFr";
                thuongLaiFr.FormBorderStyle = FormBorderStyle.None;
                thuongLaiFr.Dock = DockStyle.Fill;
                thuongLaiFr.Width = this.Width - 20;
                thuongLaiFr.Height = this.Height - 80;
                thuongLaiFr.Show();
            }
        }
        private void Exit_Click(object sender, EventArgs e)//Click Exit
        {
            if (MessageBox.Show("Bạn muốn thoát ?", "Hệ Thống", MessageBoxButtons.OKCancel, MessageBoxIcon.Question) == DialogResult.OK)
            {
                Application.Exit();
            }
        }
        private void shopItem_Click(object sender, EventArgs e)//CLICK SHOP
        {
            Boolean isopen = false;
            foreach (Form f in Application.OpenForms)
            {
                if (f.Name == "frShop")
                {
                    isopen = true;
                    f.BringToFront();
                    break;
                }
            }
            if (!isopen)
            {
                ShopFr shopfr = new ShopFr();
                shopfr.MdiParent = this;
                shopfr.Name = "frShop";
                shopfr.setOwnerID(getFarmerID(_logIn_User.Trim()));
                shopfr.setShopID(gerShopID(getFarmerID(_logIn_User.Trim())));
                shopfr.FormBorderStyle = FormBorderStyle.None;
                shopfr.Dock = DockStyle.Fill;
                shopfr.Width = this.Width - 20;
                shopfr.Height = this.Height - 80;
                shopfr.Show();
            }
        }
        private String gerShopID(String farmerID)
        {
            String connectionString = String.Format(@"Data Source={0};Initial Catalog={1};Persist Security Info=True;User ID={2};Password={3}",
            Properties.Settings.Default.ServerName, Properties.Settings.Default.DBname, Properties.Settings.Default.userName, Properties.Settings.Default.passWord);
            SqlConnection con = new SqlConnection(connectionString);
            con.Open();
            String sql = "SELECT Shop_ID FROM SHOP WHERE owner_ID = '" + farmerID.Trim() + "'";
            SqlCommand cmd = new SqlCommand(sql, con);

            try
            {

                SqlDataReader dr = cmd.ExecuteReader();
                if (dr.Read())
                {
                    return dr.GetString(0);
                }
                dr.Close();

            }
            catch (Exception excep)
            {
                MessageBox.Show(excep.Message);
            }
            finally
            {
                cmd.Clone();
                con.Close();
            }
            return "";
        }
        public String getFarmerID(String username)
        {
            String connectionString = String.Format(@"Data Source={0};Initial Catalog={1};Persist Security Info=True;User ID={2};Password={3}",
            Properties.Settings.Default.ServerName, Properties.Settings.Default.DBname, Properties.Settings.Default.userName, Properties.Settings.Default.passWord);
            SqlConnection con = new SqlConnection(connectionString);
            con.Open();
            String sql = "SELECT Farmer_ID FROM ACCOUNT WHERE username = '" + username.Trim() + "'";
            SqlCommand cmd = new SqlCommand(sql, con);

            try
            {

                SqlDataReader dr = cmd.ExecuteReader();
                if (dr.Read())
                {
                    return dr.GetString(0);
                }
                dr.Close();

            }
            catch (Exception excep)
            {
                MessageBox.Show(excep.Message);
            }
            finally
            {
                cmd.Clone();
                con.Close();
            }
            return "";
        }

        private void nongSanItem_Click(object sender, EventArgs e)//CLICK NONG SAN
        {
            Boolean isopen = false;
            foreach (Form f in Application.OpenForms)
            {
                if (f.Name == "frnongsan")
                {
                    isopen = true;
                    f.BringToFront();
                    break;
                }
            }
            if (!isopen)
            {
                frNongSan frnongsan = new frNongSan();
                frnongsan.Name = "frnongsan";
                frnongsan.MdiParent = this;
                frnongsan.Dock = DockStyle.Fill;
                //frnongsan.StartPosition = FormStartPosition.CenterScreen;
                frnongsan.FormBorderStyle = FormBorderStyle.None;
                frnongsan.ControlBox = false;
                if (!LogInUser.Equals("admin"))
                    frnongsan.DefaultShopID = gerShopID(getFarmerID(LogInUser.Trim()));
                else
                    frnongsan.DefaultShopID = "admin";
                frnongsan.Show();
            }
        }
        private void button1_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Bạn muốn thoát ?", "Hệ Thống", MessageBoxButtons.OKCancel, MessageBoxIcon.Question) == DialogResult.OK)
            {
                Application.Exit();
            }
        }



        private void MainForm_FormClosed(object sender, FormClosedEventArgs e)
        {
            Application.Exit();

        }

        private void toolStripLabel1_MouseHover(object sender, EventArgs e)
        {
            ToolStripMenuItem hoverItem = sender as ToolStripMenuItem;
            hoverItem.BackColor = Color.Red;
        }

        private void toolStripLabel1_MouseLeave(object sender, EventArgs e)
        {

        }

        private void toolStripMenu_ItemClicked(object sender, ToolStripItemClickedEventArgs e)
        {

        }

        private void MainForm_Shown(object sender, EventArgs e)
        {
        }
    }
}
