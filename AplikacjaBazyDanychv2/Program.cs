using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
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
            if (connection.connect())
            {
                Application.EnableVisualStyles();
                Application.SetCompatibleTextRenderingDefault(false);
                Logowanie.form = new Logowanie();
                Application.Run(Logowanie.form);
            }
        }
    }

    public static class connection
    {
        public static string connetionString = null;
        public static MySqlConnection cnn;

        public static bool connect()
        {
            connetionString = System.Configuration.ConfigurationManager.ConnectionStrings["AplikacjaBazyDanychv2.Properties.Settings.projekt2ConnectionString"].ConnectionString;
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
