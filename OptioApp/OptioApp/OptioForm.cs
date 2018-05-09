using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Speech.Recognition;
using System.Speech.Synthesis;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace OptioApp
{
    public partial class OptioForm : Form
    {
        public SpeechRecognitionEngine speechreco = null;
        public SpeechSynthesizer optio = new SpeechSynthesizer();
        //internal EventHandler<SpeakStartedEventArgs> SpeakStarted;

        public OptioForm()
        {
            InitializeComponent();

            VoiceRecognition vr = new VoiceRecognition(this);
            speechreco = vr.createSpeechEngine("en-US");

            DBGrammar gr = new DBGrammar(this);
            gr.LoadGrammarAndCommands();
            speechreco.SpeechRecognized += new EventHandler<SpeechRecognizedEventArgs>(vr.engine_SpeechRecognized);

            gr.LoadDefaultGrammarAndCommands();
            speechreco.SpeechRecognized += new EventHandler<SpeechRecognizedEventArgs>(vr.default_SpeechRecognized);

            speechreco.SetInputToDefaultAudioDevice();
            speechreco.RecognizeAsync(RecognizeMode.Multiple);

            StopRepeat stopStart = new StopRepeat(this);
            optio.SpeakStarted += new EventHandler<SpeakStartedEventArgs>(stopStart.optio_SpeakStarted);//To stop system repeating itself
            optio.SpeakCompleted += new EventHandler<SpeakCompletedEventArgs>(stopStart.optio_SpeakCompleted);//To stop system repeating itself


        }


        #region .. Double Buffered function ..
        public static void SetDoubleBuffered(System.Windows.Forms.Control c)
        {
            if (System.Windows.Forms.SystemInformation.TerminalServerSession)
                return;
            System.Reflection.PropertyInfo aProp = typeof(System.Windows.Forms.Control).GetProperty("DoubleBuffered", System.Reflection.BindingFlags.NonPublic | System.Reflection.BindingFlags.Instance);
            aProp.SetValue(c, true, null);
        }

        #endregion


        #region .. code for Flucuring ..

        protected override CreateParams CreateParams
        {
            get
            {
                CreateParams cp = base.CreateParams;
                cp.ExStyle |= 0x02000000;
                return cp;
            }
        }

        #endregion



        private void OptioForm_Load(object sender, EventArgs e)
        {
            refreshForm();
            SetDoubleBuffered(tableLayoutPanel1);
            SetDoubleBuffered(productLabel);
            SetDoubleBuffered(mainLabel);

        }

        public void refreshForm()
        {
            this.FormBorderStyle = FormBorderStyle.None;
            this.WindowState = FormWindowState.Maximized;
            this. TopMost = true;
            Cursor.Hide();
            productLabel.BackColor = Color.Transparent;
            mainLabel.Text = "Just say hello!";
            productLabel.Text = "";
            mainLabel.BackColor = Color.Transparent;
            optio.Volume = 100;
            productLabel.BringToFront();
            SetDoubleBuffered(tableLayoutPanel1);
            SetDoubleBuffered(productLabel);
            SetDoubleBuffered(mainLabel);
            
          

        }

        private void adminlabel_Click(object sender, EventArgs e)
        {
            
            Login login = new Login(this);
            login.Show();
            login.TopMost = true;
            optio.Volume = 0;
            Cursor.Show();
        }

        public void mainLabel_TextChanged(object sender, EventArgs e)
        {
            mainLabel.TextAlign = ContentAlignment.MiddleCenter;
            
        }

        public void mainLabel_sizeChanged(object sender, EventArgs e)
        {
            mainLabel.Left = (this.ClientSize.Width - mainLabel.Size.Width) / 2;
        }

       

        public void productLabel_sizeChanged(object sender, EventArgs e)
        {
            productLabel.Left = (this.ClientSize.Width - productLabel.Size.Width) / 2;
            productLabel.BackColor = Color.Aqua;

        }

        private void OptioForm_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Escape)
            {
                FormBorderStyle = FormBorderStyle.Sizable;
                WindowState = FormWindowState.Normal;
                TopMost = false;
                Cursor.Show();
            }
        }

        private void productLabel_TextChanged(object sender, EventArgs e)
        {
            productLabel.TextAlign = ContentAlignment.MiddleCenter;
            productLabel.BackColor = Color.Transparent;
           
        }

        private void productLabeltimer_Tick(object sender, EventArgs e)
        {
           
            var current = optio.GetCurrentlySpokenPrompt();

             //Login login1 = new Login(this);
            //Admin admin = new Admin(this);

            Form login = Application.OpenForms["Login"];
            //Form admin = Application.OpenForms["Admin"];

            if (current == null && login == null ) 
            {
                refreshForm();
               
            }else
            {
                productLabeltimer.Stop();
                productLabeltimer.Start();
                
            }
           
                
        }

       
      
        
    
        private void OptioForm_MouseClick(object sender, MouseEventArgs e)
        {
            Cursor.Show();
        }

        private void mainLabel_Click(object sender, EventArgs e)
        {

        }

        private void productLabel_Click(object sender, EventArgs e)
        {

        }
    }
}
