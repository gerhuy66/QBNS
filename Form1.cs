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
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }


        private void Form1_Load(object sender, EventArgs e)
        {
            tbTK.Text = Properties.Settings.Default.unLogIn;
            cbRemember.Checked = Properties.Settings.Default.RememberMe;
        }
        private void btnDangNhap_Click(object sender, EventArgs e)
        {
            if (cbRemember.Checked)
            {
                Properties.Settings.Default.unLogIn = tbTK.Text;
                Properties.Settings.Default.RememberMe = true;
                Properties.Settings.Default.Save();
            }
            else
            {
                Properties.Settings.Default.unLogIn = "";
                Properties.Settings.Default.RememberMe = false;
                Properties.Settings.Default.Save();
            }
            MainForm mf = new MainForm();
            mf.LogInUser = tbTK.Text;
            mf.Show();
            this.Hide();
            
        }

        private void cbRemember_CheckedChanged(object sender, EventArgs e)
        {

        }
    }
}
