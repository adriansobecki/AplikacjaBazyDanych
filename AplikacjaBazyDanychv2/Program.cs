using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Configuration;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AplikacjaBazyDanychv2
{
    static class Program
    {
        /// <summary>
        /// Główny punkt wejścia dla aplikacji.
        /// </summary>
        [STAThread]
        static void Main()
        {
            //System.Configuration.ConfigurationManager.ConnectionStrings["AplikacjaBazyDanychv2.Properties.Settings.projekt2ConnectionString"].ConnectionString.Replace(System.Configuration.ConfigurationManager.ConnectionStrings["AplikacjaBazyDanychv2.Properties.Settings.projekt2ConnectionString"].ConnectionString, Environment.GetEnvironmentVariable("ConnectionString"));
            if (connection.connect())
            {
                Application.EnableVisualStyles();
                Application.SetCompatibleTextRenderingDefault(false);
                Logowanie.form = new Logowanie();
                Application.Run(Logowanie.form);
                //System.Configuration.ConfigurationManager.ConnectionStrings["AplikacjaBazyDanychv2.Properties.Settings.projekt2ConnectionString"].ConnectionString= Environment.GetEnvironmentVariable("ConnectionString");
                //server=localhost;user id=root;password=root;persistsecurityinfo=True;database=projekt2
            }
        }

    }

    public static class connection
    {
        public static string connetionString = null;
        public static MySqlConnection cnn;

        public static bool connect()
        {
           
            connetionString = Environment.GetEnvironmentVariable("ConnectionString");

            var config = ConfigurationManager.OpenExeConfiguration(ConfigurationUserLevel.None);
            var connectionStringsSection = (ConnectionStringsSection)config.GetSection("connectionStrings");
            connectionStringsSection.ConnectionStrings["AplikacjaBazyDanychv2.Properties.Settings.projekt2ConnectionString"].ConnectionString = connetionString;
            config.Save();
            ConfigurationManager.RefreshSection("connectionStrings");

            ConfigurationManager.RefreshSection("appSettings");
            
      
            cnn = new MySqlConnection(connetionString);
            try
            {
                cnn.Open();
                return true;
            }
            catch (Exception ex)
            {
                return false;
            }

        }

    }
}
