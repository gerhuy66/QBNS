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
            
            
        }
        private void btnDangNhap_Click(object sender, EventArgs e)
        {
            MainForm mf = new MainForm();
            mf.LogInUser = tbTK.Text;
            mf.Show();
            this.Hide();
            
        }
    }
}
