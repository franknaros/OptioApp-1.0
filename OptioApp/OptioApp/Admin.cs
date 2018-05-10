using System;
using System.Data.SqlClient;
using System.Speech.Synthesis;
using System.Windows.Forms;

namespace OptioApp
{
    public partial class Admin : Form
    {
        SpeechSynthesizer optio = new SpeechSynthesizer();
        OptioForm of;
        public Admin(OptioForm of)
        {
            this.of = of;
            InitializeComponent();
            Cursor.Show();
        }


        private void prSavebutton_Click(object sender, EventArgs e)
        {
            if (prNametextBox.Text == "" || prLocationtextBox.Text == "" || prPricetextBox.Text == "" || prInfoTextBox.Text == "")
            {
                MessageBox.Show("All fields must be filled");
            
                Refresh();
            }
            else
            {

                try
                {
                    
                    SqlConnection con = new SqlConnection("Data Source=(LocalDB)\\MSSQLLocalDB;AttachDbFilename=C:\\Users\\Franknaros\\documents\\visual studio 2017\\Projects\\OptioApp\\OptioApp\\OptioDB.mdf;Integrated Security=True");
                    con.Open();
                    SqlCommand cmd = new SqlCommand("INSERT INTO Products(productName, productInfo, productLocation, productPrice) VALUES(@productName, @productInfo, @productLocation, @productPrice)", con);
                    cmd.Parameters.AddWithValue("@productName", prNametextBox.Text);
                    cmd.Parameters.AddWithValue("@productInfo", prInfoTextBox.Text);
                    cmd.Parameters.AddWithValue("@productLocation", prLocationtextBox.Text);
                    cmd.Parameters.AddWithValue("@productPrice", prPricetextBox.Text);
                    cmd.ExecuteNonQuery();
                    con.Close();
                    prNametextBox.Clear();
                    prInfoTextBox.Clear();
                    prLocationtextBox.Clear();
                    prPricetextBox.Clear();
                    //Application.Restart();
                    //of.refreshForm();
                }
                catch (Exception ex)
                {
                    optio.SpeakAsync("Product info is not saved, please make sure You have entered the right information. Check " + ex.Message);
                    MessageBox.Show("Product info is not saved, please make sure You have entered the right information. Check " + ex.Message);
                }
            }
            this.Show(); 

        }

        private void exitButton_Click(object sender, EventArgs e)
        {
            Application.Restart();
            of.optio.Volume = 100;

        }

        private void prLocationtextBox_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.KeyChar = Char.ToUpper(e.KeyChar);
        }

        private void prNametextBox_TextChanged(object sender, EventArgs e)
        {

        }

        private void Admin_Load(object sender, EventArgs e)
        {

        }

       
    }
}
