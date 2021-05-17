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
    public partial class Wypozyczenia : Form
    {
        public static Wypozyczenia form = null;
        public Wypozyczenia()
        {
            InitializeComponent();
            //Form1.form.Close();
        }

        public void UpdateForm()
        {
            this.user.Text = Logowanie.imie + " " + Logowanie.nazwisko;
        }

        private void Form2_Load(object sender, EventArgs e)
        {
            // TODO: Ten wiersz kodu wczytuje dane do tabeli 'projekt2DataSet2.sprzetview' . Możesz go przenieść lub usunąć.
            //this.sprzetviewTableAdapter.Fill(this.projekt2DataSet2.sprzetview);
            // TODO: Ten wiersz kodu wczytuje dane do tabeli 'projekt2DataSet1.wypozyczeniaview' . Możesz go przenieść lub usunąć.
            this.wypozyczeniaviewTableAdapter.Fill(this.projekt2DataSet1.wypozyczeniaview);
            // TODO: Ten wiersz kodu wczytuje dane do tabeli 'projekt2DataSet.wypozyczenia' . Możesz go przenieść lub usunąć.
            //this.wypozyczeniaTableAdapter.Fill(this.projekt2DataSet.wypozyczenia);
            this.user.Text=Logowanie.imie+" "+Logowanie.nazwisko;

        }

        private void btnSprzęt_Click(object sender, EventArgs e)
        {
            if (Sprzet.form == null)
            {
                Sprzet.form = new Sprzet();
            }
            Wypozyczenia.form.Hide();
            Sprzet.form.Show();
        }

        private void btnRodzaje_Click(object sender, EventArgs e)
        {
            if (Rodzaje.form == null)
            {
                Rodzaje.form = new Rodzaje();
            }
            Wypozyczenia.form.Hide();
            Rodzaje.form.Show();
        }

        private void btnCennik_Click(object sender, EventArgs e)
        {
            if (Cennik.form == null)
            {
                Cennik.form = new Cennik();
            }
            Wypozyczenia.form.Hide();
            Cennik.form.Show();
        }

        private void bntWyloguj_Click(object sender, EventArgs e)
        {
            Wypozyczenia.form.Hide();
            Logowanie.form.Show();
        }

        private void dataGridView1_CellValueChanged(object sender, DataGridViewCellEventArgs e)
        {
            if (dataGridView1.CurrentRow != null)
            {
                MySqlCommand command = new MySqlCommand("EdycjaCzasuWypozyczenia", connection.cnn);
                //command.CommandTimeout = 15;
                //CALL `projekt2`.`EdycjaCzasuWypozyczenia`(<{IN Id INT}>, <{IN Czas TIME}>);

                command.CommandType = CommandType.StoredProcedure;
                var Id = dataGridView1.CurrentRow.Cells["idWypozyczeniaDataGridViewTextBoxColumn"].Value;
                var Czas = dataGridView1.CurrentRow.Cells["czasWypozyczeniaDataGridViewTextBoxColumn"].Value;


                MySqlParameter in1 = new MySqlParameter("Id", Id) { Direction = ParameterDirection.Input };
                MySqlParameter in2 = new MySqlParameter("Czas", Czas) { Direction = ParameterDirection.Input };
             
                command.Parameters.Add(in1);
                command.Parameters.Add(in2);




                MySqlDataReader rdr = command.ExecuteReader();
                rdr.Close();
            }
        }


        private void NewWypozyczenie_Click(object sender, EventArgs e)
        {
            NoweWypozyczenie.form= new NoweWypozyczenie();
            NoweWypozyczenie.form.Show();
        }
    }
}
