using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Speech.Recognition;
using System.Speech.Synthesis;
using System.IO;
using System.Configuration;
using System.Data.SqlClient;

namespace OptioApp
{
    class DBGrammar
    {
        OptioForm of;
        public DBGrammar(OptioForm of)
        {
            this.of = of;
        }
        public void LoadGrammarAndCommands()
        {
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
                    var productcmd = sdr["productName"].ToString();
                    Grammar commandgrammar = new Grammar(new GrammarBuilder(new Choices(productcmd)));
                    of.speechreco.LoadGrammarAsync(commandgrammar);
                }
                //sdr.Close();
                con.Close();
            }
            catch (Exception ex)
            {
                of.optio.SpeakAsync("I have detected an invalid entry in your database commands, possibly a blank line. Database commands will cease to work until this is fixed." + ex.Message);
            }
        }

        public void LoadDefaultGrammarAndCommands()
        {


            try
            {
                string MachineName = Environment.UserName;
                string constring = @"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\" + MachineName + "\\documents\\visual studio 2017\\Projects\\OptioApp\\OptioApp\\OptioDB.mdf;Integrated Security=True";
                // ConfigurationManager.ConnectionStrings["JarvisDataConnectionString"].ConnectionString; //you can use configurationmanager in app.config or you can put in the direct path
                SqlConnection con = new SqlConnection(constring);
                con.Open();
                SqlCommand sc = new SqlCommand();
                sc.Connection = con;
                sc.CommandText = "select * FROM DefaultCommands";
                // sc.CommandType = CommandType.TableDirect;
                SqlDataReader sdr = sc.ExecuteReader();
                while (sdr.Read())
                {
                    var Loadcmd = sdr["OptioDefaultCommands"].ToString();
                    Grammar mycommandgrammar = new Grammar(new GrammarBuilder(new Choices(Loadcmd)));
                    of.speechreco.LoadGrammarAsync(mycommandgrammar);
                }
                sdr.Close();
                con.Close();
            }
            catch (Exception ex)
            {
                of.optio.SpeakAsync("I have detected an invalid entry in your Default Grammar database commands, possibly a blank line. Database commands will cease to work until this is fixed." + ex.Message);
            }
        }

    }
}
