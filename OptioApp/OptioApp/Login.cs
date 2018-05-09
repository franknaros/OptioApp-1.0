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

namespace OptioApp
{
    public partial class Login : Form
    {
        OptioForm of;
        public Login(OptioForm of)
        {
            this.of = of;
            InitializeComponent();
            Cursor.Show();

           
        }

       

        private void loginButton_Click(object sender, EventArgs e)
        {
            try
            {
                string MachineName = Environment.UserName;
                string constring = @"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\" + MachineName + "\\documents\\visual studio 2017\\Projects\\OptioApp\\OptioApp\\OptioDB.mdf;Integrated Security=True";
                SqlConnection con = new SqlConnection(constring);
                con.Open();
                SqlCommand sc = new SqlCommand();
                sc.Connection = con;
                sc.CommandText = "SELECT * FROM admin WHERE username='" + usernameTextBox.Text + "' and password = '" + passwordTextBox.Text + "'";
                SqlDataReader sdr = sc.ExecuteReader();

                if (sdr.HasRows == true)
                {
                    this.Hide();
                    Admin admin= new Admin(of);
                    admin.Show();
                    admin.TopMost = true;
                }
                else
                {
                    MessageBox.Show("Incorrect Username or Password!");
                }
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message.ToString(), "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void pwdCheckBox_CheckedChanged(object sender, EventArgs e)
        {
            bool check = pwdCheckBox.Checked;

            switch (check)
            {
                case true:
                    passwordTextBox.UseSystemPasswordChar = false;
                    break;

                default:
                    passwordTextBox.UseSystemPasswordChar = true;
                    break;
            }
        }

        private void Login_KeyDown(object sender, KeyEventArgs e)
        {

            if (e.KeyCode == Keys.Escape)
            {
                FormBorderStyle = FormBorderStyle.Sizable;
                WindowState = FormWindowState.Normal;
                TopMost = false;
                Cursor.Show();

            }

           
        }

        public void exitLoginbutton_Click(object sender, EventArgs e)
        {
            loginClose();
        }

        public void loginClose()
        {
           TopMost = false;
           WindowState = FormWindowState.Normal;
           Close();

        }
    }
}
