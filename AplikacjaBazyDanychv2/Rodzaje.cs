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
    public partial class Rodzaje : Form
    {
        public static Rodzaje form = null;
        private int semaphor = 0;
        public Rodzaje()
        {
            InitializeComponent();
        }



        private void btnCennik_Click(object sender, EventArgs e)
        {
            if (Cennik.form == null)
            {
                Cennik.form = new Cennik();
            }
            Rodzaje.form.Hide();
            Cennik.form.Show();
        }


        private void btnWypozyczenia_Click(object sender, EventArgs e)
        {
            if (Wypozyczenia.form == null)
            {
                Wypozyczenia.form = new Wypozyczenia();
            }
            Rodzaje.form.Hide();
            Wypozyczenia.form.Show();
        }


        private void btnSprzęt_Click(object sender, EventArgs e)
        {
            if (Sprzet.form == null)
            {
                Sprzet.form = new Sprzet();
            }
            Rodzaje.form.Hide();
            Sprzet.form.Show();
        }


        private void bntWyloguj_Click(object sender, EventArgs e)
        {
            Rodzaje.form.Hide();
            Logowanie.form.Show();
        }

        private void Rodzaje_Load(object sender, EventArgs e)
        {
            // TODO: Ten wiersz kodu wczytuje dane do tabeli 'projekt2DataSet.rodzajesprzetu' . Możesz go przenieść lub usunąć.
            this.rodzajesprzetuTableAdapter.Fill(this.projekt2DataSet.rodzajesprzetu);
            this.user.Text = Logowanie.imie + " " + Logowanie.nazwisko;

        }

        private void dataGridView1_CellValueChanged(object sender, DataGridViewCellEventArgs e)
        {
            if (dataGridView1.CurrentRow != null && semaphor==0)
            {
                MySqlCommand command = new MySqlCommand("ModyfikujRodzaj", connection.cnn);
                //command.CommandTimeout = 15;
                //CALL `projekt2`.`ModyfikujRodzaj`(<{IN Id INT}>, <{IN oplata INT}>);
                command.CommandType = CommandType.StoredProcedure;
                var Id = dataGridView1.CurrentRow.Cells["idRodzajuSprzetuDataGridViewTextBoxColumn"].Value;
                var nazwa = dataGridView1.CurrentRow.Cells["nazwaSprzetuDataGridViewTextBoxColumn"].Value;
                var oplata = dataGridView1.CurrentRow.Cells["oplataKarnaDataGridViewTextBoxColumn"].Value;
              

                MySqlParameter in1 = new MySqlParameter("Id", Id) { Direction = ParameterDirection.Input };
                MySqlParameter in2 = new MySqlParameter("nazwa", nazwa) { Direction = ParameterDirection.Input };
                MySqlParameter in3 = new MySqlParameter("oplata", oplata) { Direction = ParameterDirection.Input };


                command.Parameters.Add(in1);
                command.Parameters.Add(in2);
                command.Parameters.Add(in3);



                MySqlDataReader rdr = command.ExecuteReader();
                rdr.Close();
            }
        }

        private void dataGridView1_UserAddedRow(object sender, DataGridViewRowEventArgs e)
        {
            semaphor = 1;
            dataGridView1.CurrentRow.Cells["nazwaSprzetuDataGridViewTextBoxColumn"].Value = "";
            dataGridView1.CurrentRow.Cells["oplataKarnaDataGridViewTextBoxColumn"].Value = 0;
            //dataGridView1.CurrentRow.Cells["czasWypozyczeniaDataGridViewTextBoxColumn"].Value = 0;

            MySqlCommand command = new MySqlCommand("NowyRodzajSprzetu", connection.cnn);
            command.CommandType = CommandType.StoredProcedure;
            var Nazwa = dataGridView1.CurrentRow.Cells["nazwaSprzetuDataGridViewTextBoxColumn"].Value;
            var Oplata = dataGridView1.CurrentRow.Cells["oplataKarnaDataGridViewTextBoxColumn"].Value;
            int id = 0;

            if (Nazwa == DBNull.Value)
                Nazwa = "";
            if (Oplata == DBNull.Value)
                Oplata = 0;


            MySqlParameter in1 = new MySqlParameter("Nazwa", Nazwa) { Direction = ParameterDirection.Input };
            MySqlParameter in2 = new MySqlParameter("Oplata", Oplata) { Direction = ParameterDirection.Input };
            MySqlParameter out1 = new MySqlParameter("Id", id) { Direction = ParameterDirection.Output };


            command.Parameters.Add(in1);
            command.Parameters.Add(in2);
            command.Parameters.Add(out1);


            MySqlDataReader rdr = command.ExecuteReader();

            //while (rdr.Read()) ;
            //id = rdr.GetInt32(1);
            dataGridView1.CurrentRow.Cells["idRodzajuSprzetuDataGridViewTextBoxColumn"].Value = out1.Value;
            rdr.Close();
            semaphor = 0;
            //Cennik_Load(null,null);
        }

        private void dataGridView1_UserDeletingRow(object sender, DataGridViewRowCancelEventArgs e)
        {
            semaphor = 1;
            if (dataGridView1.CurrentRow.Cells["idRodzajuSprzetuDataGridViewTextBoxColumn"].Value != DBNull.Value)
            {
                if (MessageBox.Show("Usunąć ten rekord?", "Potwierdzenie", MessageBoxButtons.YesNo) == DialogResult.Yes)
                {

                    var id = dataGridView1.CurrentRow.Cells["idRodzajuSprzetuDataGridViewTextBoxColumn"].Value;
                    MySqlCommand command = new MySqlCommand("UsunRodzajSprzetu", connection.cnn);
                    command.CommandType = CommandType.StoredProcedure;
                    MySqlParameter in1 = new MySqlParameter("Id", id) { Direction = ParameterDirection.Input };
                    command.Parameters.Add(in1);
                    command.ExecuteNonQuery();
                }
                else
                    e.Cancel = true;
            }
            else
                e.Cancel = true;
            semaphor = 0;
        }
    }
}
