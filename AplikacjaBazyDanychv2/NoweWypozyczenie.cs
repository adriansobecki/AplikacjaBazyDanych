using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AplikacjaBazyDanychv2
{
    public partial class NoweWypozyczenie : Form
    {
        public static NoweWypozyczenie form = null;
        private int userExist = 0;
        public NoweWypozyczenie()
        {
            InitializeComponent();
        }

        private void NoweWypozyczenie_Load(object sender, EventArgs e)
        {
            DodanySprzet();
            // TODO: Ten wiersz kodu wczytuje dane do tabeli 'projekt2DataSet5.sprzet' . Możesz go przenieść lub usunąć.
            //this.sprzetTableAdapter.Fill(this.projekt2DataSet5.sprzet);
            // TODO: Ten wiersz kodu wczytuje dane do tabeli 'projekt2DataSet5.uzytkownicysystemu' . Możesz go przenieść lub usunąć.
            //this.uzytkownicysystemuTableAdapter.Fill(this.projekt2DataSet5.uzytkownicysystemu);

        }

        public void NowySprzet(int id, float rozmiar, string uwagi, string rodzaj)
        {
            DataTable dt = (DataTable)dataGridView1.DataSource;
            DataRow item = dt.NewRow();
            // Id, rozmiar, uwagi, rodzaj
            item[0] = id;
            item[1] = rozmiar;
            item[2] = uwagi;
            item[3] = rodzaj;

            dt.Rows.InsertAt(item, 0);

        }

        private void DodanySprzet()
        {

            DataTable dt = new DataTable("DostepnoscKolumna");
            DataColumn column1 = dt.Columns.Add("Id", typeof(string));
            DataColumn column2 = dt.Columns.Add("Rozmiar", typeof(string));
            DataColumn column3 = dt.Columns.Add("Uwagi", typeof(string));
            DataColumn column4 = dt.Columns.Add("Rodzaj", typeof(string));
            //column.AllowDBNull = false;
            //column.Unique = true;

            /*
            DataRow item1 = dt.NewRow();
            DataRow item2 = dt.NewRow();
            DataRow item3 = dt.NewRow();
            item1[0] = "Dostepny";
            item2[0] = "ChwilowoNiedostepny";
            item3[0] = "Wypozyczony";

            dt.Rows.InsertAt(item1, 0);
            dt.Rows.InsertAt(item2, 1);
            dt.Rows.InsertAt(item3, 2);
            dostepnoscDataGridViewTextBoxColumn.ValueMember = "Dostepnosc";
            dostepnoscDataGridViewTextBoxColumn.DisplayMember = "Dostepnosc";
            */
            dataGridView1.DataSource = dt;
            //dostepnoscDataGridViewTextBoxColumn.DataSource = dt;
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            MySqlCommand command = new MySqlCommand("DaneKlienta", connection.cnn);
            //command.CommandTimeout = 15;
            //CALL `projekt2`.`ModyfikacjaSprzetu`(<{IN Id INT}>, <{IN ArgDostepnosc varchar(20)}>, <{IN ArgUwagi varchar(160)}>);
            /*
            CREATE DEFINER =`root`@`localhost` PROCEDURE `DaneKlienta`(
 IN Dane varchar(10),
OUT IdKlienta INT,
OUT Imie varchar(20),
OUT Nazwisko varchar(30),
OUT NrTelefonu varchar(12),
OUT NrDowodu varchar(10))
            */
            command.CommandType = CommandType.StoredProcedure;
            string Id = textBox1.Text;
            int IdKlienta = 0;
            string Imie = "";
            string Nazwisko = "";
            string NrTelefonu = "";
            string NrDowodu = "";

            if (Id != "")
            {
                MySqlParameter in1 = new MySqlParameter("Dane", int.Parse(Id)) { Direction = ParameterDirection.Input };
                MySqlParameter out1 = new MySqlParameter("IdKlienta", IdKlienta) { Direction = ParameterDirection.Output };
                MySqlParameter out2 = new MySqlParameter("Imie", Imie) { Direction = ParameterDirection.Output };
                MySqlParameter out3 = new MySqlParameter("Nazwisko", Nazwisko) { Direction = ParameterDirection.Output };
                MySqlParameter out4 = new MySqlParameter("NrTelefonu", NrTelefonu) { Direction = ParameterDirection.Output };
                MySqlParameter out5 = new MySqlParameter("NrDowodu", NrDowodu) { Direction = ParameterDirection.Output };


                command.Parameters.Add(in1);
                command.Parameters.Add(out1);
                command.Parameters.Add(out2);
                command.Parameters.Add(out3);
                command.Parameters.Add(out4);
                command.Parameters.Add(out5);



                MySqlDataReader rdr = command.ExecuteReader();
                if (out1.Value != DBNull.Value)
                {
                    textBox2.Text = out2.Value.ToString();
                    textBox3.Text = out3.Value.ToString();
                    textBox4.Text = out4.Value.ToString();
                    userExist = int.Parse(out1.Value.ToString());
                }
                else
                    userExist = 0;
                rdr.Close();
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            WybierzSprzet form = new WybierzSprzet();
            form.Show();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            DataTable dt = (DataTable)dataGridView1.DataSource;
            DataRowCollection rows= dt.Rows;
            List<int> sprzet = new List<int>();
            foreach (DataRow row in rows)
            {
                sprzet.Add(int.Parse(row[0].ToString()));
            }
            string numerDowodu = textBox1.Text;
            string imie = textBox2.Text;
            string nazwisko = textBox3.Text;
            string numerTelefonu = textBox4.Text;
            string czas = textBox5.Text;


            if (sprzet!=null && numerDowodu.Length!=0 && imie.Length != 0 && nazwisko.Length != 0
                && czas.Length != 0)
            {
                if(userExist==0)
                {

                    MySqlCommand command = new MySqlCommand("NowyKlient", connection.cnn);
                    command.CommandType = CommandType.StoredProcedure;
                    
                    if(numerTelefonu.Length == 0) //insert
                    {
                        numerTelefonu = null;
                    }
                    //int id = 0;
                    MySqlParameter in0 = new MySqlParameter("arg1", imie) { Direction = ParameterDirection.Input };
                    MySqlParameter in1 = new MySqlParameter("arg2", nazwisko) { Direction = ParameterDirection.Input };
                    MySqlParameter in2 = new MySqlParameter("arg3", numerTelefonu) { Direction = ParameterDirection.Input };
                    MySqlParameter in3 = new MySqlParameter("arg4", numerDowodu) { Direction = ParameterDirection.Input };
                    MySqlParameter out1 = new MySqlParameter("Id", userExist) { Direction = ParameterDirection.Output };
                    command.Parameters.Add(in0);
                    command.Parameters.Add(in1);
                    command.Parameters.Add(in2);
                    command.Parameters.Add(in3);
                    command.Parameters.Add(out1);

                    command.ExecuteNonQuery();
                    userExist = int.Parse( out1.Value.ToString());

                }

                MySqlCommand command2 = new MySqlCommand("NoweWypozyczenie", connection.cnn);
                command2.CommandType = CommandType.StoredProcedure;
                MySqlParameter in4 = new MySqlParameter("ArgCzasWypozyczenia", czas) { Direction = ParameterDirection.Input };
                MySqlParameter in5 = new MySqlParameter("ArgIdUzytkownika", Logowanie.id) { Direction = ParameterDirection.Input };
                MySqlParameter in6 = new MySqlParameter("ArgIdKlienta", userExist) { Direction = ParameterDirection.Input };
                command2.Parameters.Add(in4);
                command2.Parameters.Add(in5);
                command2.Parameters.Add(in6);
                command2.ExecuteNonQuery();

                foreach(int id in sprzet)
                {
                    MySqlCommand command3 = new MySqlCommand("InformacjaOWypozyczeniu", connection.cnn);
                    command3.CommandType = CommandType.StoredProcedure;
                    MySqlParameter in7 = new MySqlParameter("ArgCzasWypozyczenia", czas) { Direction = ParameterDirection.Input };
                    MySqlParameter in8 = new MySqlParameter("ArgIdSprzetu", id) { Direction = ParameterDirection.Input };
                    command3.Parameters.Add(in7);
                    command3.Parameters.Add(in8);
                    command3.ExecuteNonQuery();
                }



            }
            NoweWypozyczenie.form.Close();
            Wypozyczenia.form.UpdateForm();
        }
    }
}
