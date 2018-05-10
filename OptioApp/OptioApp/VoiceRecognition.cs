using System;
using System.Windows.Forms;
using System.Speech.Recognition;
using System.Data.SqlClient;
using System.Speech.Synthesis;
using System.Linq;
using System.Threading.Tasks;

namespace OptioApp
{
    class VoiceRecognition
    {
        OptioForm of;

        public VoiceRecognition(OptioForm of)
            {
            this.of = of;
        }
        
        public void default_SpeechRecognized(object sender, SpeechRecognizedEventArgs e)
        {
           
            String speech1 = e.Result.Text;
           // of.mainLabel.Text = speech1;
            Login login = new Login(of);
            Admin admin = new Admin(of);


             if (speech1 == "Hello" && e.Result.Confidence > 0.92 || speech1 == "Open admin" && e.Result.Confidence > 0.92 || speech1 == "Close admin" && e.Result.Confidence > 0.92)
            {

            switch (speech1)
            {
                case "What time is it?":
                    System.DateTime now = System.DateTime.Now;
                    string time = now.GetDateTimeFormats('t')[0];
                    of.optio.SpeakAsync(time);
                    of.productLabel.Text = "";
                    break;

                case "What day is it today?":
                    string dayis;
                    dayis = "Today is " + System.DateTime.Now.ToString("dddd", new System.Globalization.CultureInfo("en-US"));
                    of.optio.SpeakAsync(dayis);
                    of.productLabel.Text = "";
                    break;

                case "What is todays date?":
                    string date;
                    date = "the date is " + System.DateTime.Now.ToString("dd MMM yyyy", new System.Globalization.CultureInfo("en-US"));
                    of.optio.SpeakAsync(date);
                    of.productLabel.Text = "";
                    break;

                case "What can you do?":
                    string action;
                    action = "I can help you find anything you are looking for";
                    of.optio.SpeakAsync(action);
                    of.productLabel.Text = "";
                    of.mainLabel.Text = action;
                    break;

                case "What is your name?":
                    string name;
                    name = "My name is Optio";
                    of.optio.SpeakAsync(name);
                    of.productLabel.Text = "";
                    of.mainLabel.Text = name;
                    break;

                case "Hello":
                     string greeting;
                    greeting = "Hi, what would you like to find?";
                    of.optio.SpeakAsync(greeting);
                    of.mainLabel.Text = greeting;
                    of.productLabel.Text = "";
                    break;

                case "Open admin":
                        of.optio.SpeakAsync("opening Admin");
                        of.productLabel.Text = "";
                        of.mainLabel.Text = "";
                        Task.Delay(5000);

                        if (Application.OpenForms.OfType<Login>().Count() == 1)
                            Application.OpenForms.OfType<Login>().First().Close();

                       
                        login.Show();
                        login.TopMost = true;
                        Cursor.Show();
                        volumeCheck();
                        break;
                       

                case "Close admin":
                       // of.optio.Volume = 100;
                        of.optio.SpeakAsync("Closing admin");
                        of.refreshForm();

                        if (Application.OpenForms.OfType<Login>().Count() == 1)
                            Application.OpenForms.OfType<Login>().Last().Close();

                        break;
                }
            }
           
       }

        private void Optio_SpeakCompleted(object sender, SpeakCompletedEventArgs e)
        {
            throw new NotImplementedException();
        }

        public void volumeCheck()
        {
             Form log = Application.OpenForms["Login"];
             Form adm = Application.OpenForms["Admin"]; 

          
            if(log.TopMost == true )
            {
                of.optio.Volume = 0;
            }
            else if(adm.TopMost == true)
            {
                of.optio.Volume = 0;
            }
            else
            {
                of.optio.Volume = 100;
            }
            
                     
        }

        public SpeechRecognitionEngine createSpeechEngine(string preferredCulture)
        {
            foreach (RecognizerInfo config in SpeechRecognitionEngine.InstalledRecognizers())
            {
                if (config.Culture.ToString() == preferredCulture)
                {
                    of.speechreco = new SpeechRecognitionEngine(config);
                    break;
                }
            } //if desired culture is not found then load default
            if (of.speechreco == null)
            {
                MessageBox.Show("The desired culture is not installed on this machine. The speech engine will continue using " + SpeechRecognitionEngine.InstalledRecognizers()[0].Culture.ToString() + "as the default culture. Culture " + preferredCulture + " not found!");
                of.speechreco = new SpeechRecognitionEngine(SpeechRecognitionEngine.InstalledRecognizers()[0]);
            }
            return of.speechreco;
        }

        public void engine_SpeechRecognized(object sender, SpeechRecognizedEventArgs e)
        {
            string speech = e.Result.Text;
           
            if (e.Result.Confidence > 0.87)
            { 

            int i = 0;
            try
            {
                string MachineName = Environment.UserName;
                string constring = @"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\" + MachineName + "\\documents\\visual studio 2017\\Projects\\OptioApp\\OptioApp\\OptioDB.mdf;Integrated Security=True";
                SqlConnection con = new SqlConnection(constring);
                con.Open();
                SqlCommand sc = new SqlCommand();
                sc.Connection = con;
                sc.CommandText = "select * FROM Products";
                // sc.CommandType = CommandType.TableDirect;
                SqlDataReader sdr = sc.ExecuteReader();
                while (sdr.Read())
                {
                    var prName = sdr["productName"].ToString();
                    var prInfo = sdr["productInfo"].ToString();
                    var prLocation = sdr["productLocation"].ToString();
                    var prPrice = sdr["productPrice"].ToString();
                    if (prName == speech)
                    {
                        of.mainLabel.Text = speech;
                        of.optio.SpeakAsync(prName + " can be found at " + prLocation);
                        of.productLabel.Text = "LOCATION: "+ prLocation;
                        of.productLabeltimer.Start();
                    }

                }
                sdr.Close();
                con.Close();

                
            }
            catch (Exception ex)
            {
                i += 1;
                of.optio.SpeakAsync("Please check the " + speech + "command on line " + i + ". It appears to be missing a proper prInfo or web key words " + ex.Message);
             }
            }
           

        }
    }
}
