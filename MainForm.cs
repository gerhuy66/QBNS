using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace QBNS
{
    public partial class MainForm : Form
    {
        public MainForm()
        {
            InitializeComponent();
        }

        private void MainForm_Load(object sender, EventArgs e)
        {
            //setting mainform
            //this.TopMost = true;
            //this.FormBorderStyle = FormBorderStyle.None;

           // this.WindowState = FormWindowState.Maximized;
           
            //add item to tool strip menu
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
            //exit
            ToolStripMenuItem exit = new ToolStripMenuItem("Thoát");
            toolStripMenu.Items.Add(exit);
            exit.Click += Exit_Click;
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
                shopfr.FormBorderStyle = FormBorderStyle.None;
                shopfr.Dock = DockStyle.Fill;
                shopfr.Width = this.Width - 20;
                shopfr.Height = this.Height - 80;
                shopfr.Show();
            }
        }
        private void nongSanItem_Click(object sender, EventArgs e)//CLICK NONG SAN
        {
            Boolean isopen=false;
            foreach(Form f in Application.OpenForms)
            {
                if(f.Name == "frnongsan")
                {
                    isopen = true;
                    f.BringToFront();
                    break;
                }
            }
            if (!isopen) { 
                frNongSan frnongsan = new frNongSan();
                frnongsan.Name = "frnongsan";
                frnongsan.MdiParent = this;
                frnongsan.Dock = DockStyle.Fill;
                //frnongsan.StartPosition = FormStartPosition.CenterScreen;
                frnongsan.FormBorderStyle = FormBorderStyle.None;
                frnongsan.ControlBox = false;
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

        private void toolStripMenu_ItemClicked(object sender, ToolStripItemClickedEventArgs e)
        {
    
        }

     

        private void toolStripLabel1_MouseHover(object sender, EventArgs e)
        {
            ToolStripMenuItem hoverItem = sender as ToolStripMenuItem;
            hoverItem.BackColor = Color.Red;
        }

        private void toolStripLabel1_MouseLeave(object sender, EventArgs e)
        {

        }
    }
}
