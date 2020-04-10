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
        String connectionString = String.Format(@"Data Source={0};Initial Catalog={1};Persist Security Info=True;User ID={2};Password={3}",
            Properties.Settings.Default.ServerName, Properties.Settings.Default.DBname, Properties.Settings.Default.userName, Properties.Settings.Default.passWord);
        public Form1()
        {
            InitializeComponent();
        }

        public int addNum(int a,int b)
        {
            return a + b;
        }
        private void Form1_Load(object sender, EventArgs e)
        {
            tbTK.Text = Properties.Settings.Default.unLogIn;
            tbMK.Text = Properties.Settings.Default.pwLogIn;
            cbRemember.Checked = Properties.Settings.Default.RememberMe;
        }
        private bool Authentication(String username, String password)
        {
            SqlConnection con = new SqlConnection(connectionString);
            con.Open();
            String sql = "select * from ACCOUNT";
            SqlCommand cmd = new SqlCommand(sql,con);
            try { 
            SqlDataReader reader = cmd.ExecuteReader();
            while(reader.Read())
            {
                if (username.Equals(reader.GetString(0).Trim()))
                {
                    if (password.GetHashCode().ToString().Trim().Equals(reader.GetString(1).Trim()))
                    {
                       
                        return true;
                    }
                    else
                    {
                        MessageBox.Show("Sai tên tài khoản hoặc mật khẩu");
                        return false;
                    }
                }
            }
                MessageBox.Show("Sai tên tài khoản hoặc mật khẩu");
            }catch(Exception exce)
            {
                MessageBox.Show("Lỗi Đăng Nhập");
            }
            finally
            {
                con.Close();
            }

            return false;
        }
        private void btnDangNhap_Click(object sender, EventArgs e)
        {
            if (Authentication(tbTK.Text, tbMK.Text)) { 
            if (cbRemember.Checked)
            {
                Properties.Settings.Default.unLogIn = tbTK.Text;
                Properties.Settings.Default.RememberMe = true;
                Properties.Settings.Default.pwLogIn = tbMK.Text;
                Properties.Settings.Default.Save();
            }
            else
            {
                Properties.Settings.Default.unLogIn = "";
                Properties.Settings.Default.pwLogIn = "";
                Properties.Settings.Default.RememberMe = false;
                Properties.Settings.Default.Save();
            }
           
            /*
            bool isopen = false;
            foreach (Form f in Application.OpenForms)
            {
                if (f.Name == "MainForm")
                {
                    isopen = true;
                    MainForm mf = (MainForm)f;

                    mf.Show();

                    this.Hide();
                    break;
                }

            }
            if (!isopen) 
            { */
                MainForm mf = new MainForm();
                mf.LogInUser = tbTK.Text;
                mf.Show();
                this.Hide();
                //}
            }

        }

        private void cbRemember_CheckedChanged(object sender, EventArgs e)
        {

        }
    }
}
