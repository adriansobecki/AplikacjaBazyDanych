using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AplikacjaBazyDanychv2
{
    public partial class Logowanie : Form
    {
        public static string imie = "";
        public static string nazwisko = "";
        public static int id = 0;
        public static Logowanie form = null;
        public Logowanie()
        {
            
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string login = textLogin.Text.ToString();
            string haslo = textHaslo.Text.ToString();

            byte[] bytes;
            StringBuilder hash = new StringBuilder();
            using (MD5 md5 = MD5.Create())
            {
                bytes = md5.ComputeHash(Encoding.UTF8.GetBytes(haslo));
            }
            for (int i = 0; i < bytes.Length; i++)
            {
                hash.Append(bytes[i].ToString("x2"));
            }
            //MessageBox.Show(hash.ToString());
            //MySql.Data.MySqlClient.MySqlConnection
            //String imie = ""; String nazwisko = ""; int id = 0;
            MySqlCommand command = new MySqlCommand("Logowanie", connection.cnn);
            //command.CommandTimeout = 15;
            command.CommandType = CommandType.StoredProcedure;
            MySqlParameter in1 = new MySqlParameter("ArgLogin", login) { Direction = ParameterDirection.Input };
            MySqlParameter in2 = new MySqlParameter("ArgHaslo", hash.ToString()) { Direction = ParameterDirection.Input };
            MySqlParameter out1 = new MySqlParameter("Imie", imie) { Direction = ParameterDirection.Output };
            MySqlParameter out2 = new MySqlParameter("Nazwisko", nazwisko) { Direction = ParameterDirection.Output };
            MySqlParameter out3 = new MySqlParameter("Id", id) { Direction = ParameterDirection.Output };
            command.Parameters.Add(in1);
            command.Parameters.Add(in2);
            command.Parameters.Add(out1);
            command.Parameters.Add(out2);
            command.Parameters.Add(out3);

            MySqlDataReader rdr = command.ExecuteReader();

            while (rdr.Read()) ;

            if (!rdr.IsDBNull(1))
            {
                //MessageBox.Show(rdr.GetString(0));
                //MessageBox.Show(rdr.GetString(1));
                //MessageBox.Show(rdr.GetString(2));
                imie = rdr.GetString(0);
                nazwisko = rdr.GetString(1);
                id = rdr.GetInt32(2);

                if(Wypozyczenia.form==null)
                {
                    Wypozyczenia.form = new Wypozyczenia();
                    //Form1.form.Close();
                }
                Logowanie.form.Hide();
                Wypozyczenia.form.Show();
                Wypozyczenia.form.UpdateForm();
            }
            else
            {
                MessageBox.Show("Złe dane");
            }
            rdr.Close();
        }
    }
}
