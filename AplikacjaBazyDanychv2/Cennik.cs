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
    public partial class Cennik : Form
    {
        private int semaphor = 0;
        public static Cennik form = null;
        public Cennik()
        {
            InitializeComponent();
        }

        private void btnWypozyczenia_Click(object sender, EventArgs e)
        {
            if (Wypozyczenia.form == null)
            {
                Wypozyczenia.form = new Wypozyczenia();
            }
            Cennik.form.Hide();
            Wypozyczenia.form.Show();
        }


        private void btnSprzęt_Click(object sender, EventArgs e)
        {
            if (Sprzet.form == null)
            {
                Sprzet.form = new Sprzet();
            }
            Cennik.form.Hide();
            Sprzet.form.UpdateForm();
            Sprzet.form.Show();
        }

        private void btnRodzaje_Click(object sender, EventArgs e)
        {
            if (Rodzaje.form == null)
            {
                Rodzaje.form = new Rodzaje();
            }
            Cennik.form.Hide();
            Rodzaje.form.Show();
        }

        private void bntWyloguj_Click(object sender, EventArgs e)
        {
            Cennik.form.Hide();
            Logowanie.form.Show();
            Logowanie.form.clear();
        }

        private void Cennik_Load(object sender, EventArgs e)
        {
            // TODO: Ten wiersz kodu wczytuje dane do tabeli 'projekt2DataSet5.cennik' . Możesz go przenieść lub usunąć.
            //this.cennikTableAdapter.Fill(this.projekt2DataSet5.cennik);
            // TODO: Ten wiersz kodu wczytuje dane do tabeli 'projekt2DataSet4.cennikview' . Możesz go przenieść lub usunąć.
            //this.cennikviewTableAdapter1.Fill(this.projekt2DataSet4.cennikview);
            this.cennikTableAdapter.Fill(this.projekt2DataSet5.cennik);
            opcjeRodzaj();
            this.user.Text = Logowanie.imie + " " + Logowanie.nazwisko;
            // TODO: Ten wiersz kodu wczytuje dane do tabeli 'projekt2DataSet3.cennikview' . Możesz go przenieść lub usunąć.
            //this.cennikviewTableAdapter.Fill(this.projekt2DataSet3.cennikview);

        }

        public void UpdateForm()
        {
            this.cennikTableAdapter.Update(this.projekt2DataSet5.cennik);
            opcjeRodzaj();
            //this.cennikTableAdapter.Fill(this.projekt2DataSet5.cennik);
        }


        private void dataGridView1_CellValueChanged(object sender, DataGridViewCellEventArgs e)
        {
            if(dataGridView1.CurrentRow!=null && semaphor==0)
            {
                //MySqlCommand command = new MySqlCommand("EdycjaCennika", connection.cnn);
                //MySqlCommand command = new MySqlCommand("EdycjaCennika", connection.cnn);
                //command.CommandTimeout = 15;
                //CALL `projekt2`.`EdycjaCennika`(<{ IN Rodzaj INT}>, <{ IN Czas TIME}>, <{ IN Oplata INT}>);
                //MySqlCommand command;STRCMP(cennik.CzasWypozyczenia, Czas)=0 AND cennik.RodzajSprzetu_IdRodzajuSprzetu=Rodzaj;
                //command.CommandType = CommandType.StoredProcedure;
                MySqlCommand command = new MySqlCommand("EdycjaCennika", connection.cnn);
                command.CommandType = CommandType.StoredProcedure;
                var id = dataGridView1.CurrentRow.Cells["idDataGridViewTextBoxColumn"].Value;
                var time = dataGridView1.CurrentRow.Cells["czasWypozyczeniaDataGridViewTextBoxColumn"].Value;
                var oplata = dataGridView1.CurrentRow.Cells["KosztWypozyczeniaDataGridViewTextBoxColumn"].Value;
                var rodzaj = dataGridView1.CurrentRow.Cells["rodzajSprzetuIdRodzajuSprzetuDataGridViewTextBoxColumn"].Value;
                /*
                if(id==DBNull.Value || (int)id<0) //insert
                {
                    if (time == DBNull.Value)
                        time = 0;
                    if (oplata == DBNull.Value)
                        oplata = 0;
                    if (rodzaj == DBNull.Value)
                        rodzaj = 1;
                    id = null;
                }*/

                MySqlParameter in0 = new MySqlParameter("Id", id) { Direction = ParameterDirection.Input };
                MySqlParameter in1 = new MySqlParameter("Rodzaj", rodzaj) { Direction = ParameterDirection.Input };
                MySqlParameter in2 = new MySqlParameter("Czas", time) { Direction = ParameterDirection.Input };
                MySqlParameter in3 = new MySqlParameter("Oplata", oplata) { Direction = ParameterDirection.Input };

                command.Parameters.Add(in0);
                command.Parameters.Add(in1);
                command.Parameters.Add(in2);
                command.Parameters.Add(in3);


                MySqlDataReader rdr = command.ExecuteReader();
                rdr.Close();
            }
        }

        private void opcjeRodzaj()
        {
            MySqlDataAdapter sq = new MySqlDataAdapter("SELECT IdRodzajuSprzetu,NazwaSprzetu FROM rodzajesprzetu;", connection.cnn);
            DataTable dt = new DataTable();
            sq.Fill(dt);
            rodzajSprzetuIdRodzajuSprzetuDataGridViewTextBoxColumn.ValueMember = "IdRodzajuSprzetu";
            rodzajSprzetuIdRodzajuSprzetuDataGridViewTextBoxColumn.DisplayMember = "NazwaSprzetu";
            rodzajSprzetuIdRodzajuSprzetuDataGridViewTextBoxColumn.DataSource = dt;
        }

        private void dataGridView1_UserAddedRow(object sender, DataGridViewRowEventArgs e)
        {
            semaphor = 1;
            dataGridView1.CurrentRow.Cells["czasWypozyczeniaDataGridViewTextBoxColumn"].Value = 0;
            dataGridView1.CurrentRow.Cells["KosztWypozyczeniaDataGridViewTextBoxColumn"].Value = 0;
            dataGridView1.CurrentRow.Cells["rodzajSprzetuIdRodzajuSprzetuDataGridViewTextBoxColumn"].Value = 1;
            //dataGridView1.CurrentRow.Cells["czasWypozyczeniaDataGridViewTextBoxColumn"].Value = 0;

            MySqlCommand command = new MySqlCommand("RowAddedCennik", connection.cnn);
            command.CommandType = CommandType.StoredProcedure;
            var time = dataGridView1.CurrentRow.Cells["czasWypozyczeniaDataGridViewTextBoxColumn"].Value;
            var oplata = dataGridView1.CurrentRow.Cells["KosztWypozyczeniaDataGridViewTextBoxColumn"].Value;
            var rodzaj = dataGridView1.CurrentRow.Cells["rodzajSprzetuIdRodzajuSprzetuDataGridViewTextBoxColumn"].Value;
            int id = 0;

            if (time == DBNull.Value)
                    time = 0;
            if (oplata == DBNull.Value)
                    oplata = 0;
            if (rodzaj == DBNull.Value)
                    rodzaj = 1;
            
            MySqlParameter in1 = new MySqlParameter("Rodzaj", rodzaj) { Direction = ParameterDirection.Input };
            MySqlParameter in2 = new MySqlParameter("Czas", time) { Direction = ParameterDirection.Input };
            MySqlParameter in3 = new MySqlParameter("Oplata", oplata) { Direction = ParameterDirection.Input };
            MySqlParameter out1 = new MySqlParameter("Id", id) { Direction = ParameterDirection.Output };


            command.Parameters.Add(in1);
            command.Parameters.Add(in2);
            command.Parameters.Add(in3);
            command.Parameters.Add(out1);


            MySqlDataReader rdr = command.ExecuteReader();

            //while (rdr.Read()) ;
            //id = rdr.GetInt32(1);
            dataGridView1.CurrentRow.Cells["idDataGridViewTextBoxColumn"].Value = out1.Value;
            rdr.Close();
            semaphor = 0;
            //Cennik_Load(null,null);

        }

        private void dataGridView1_UserDeletingRow(object sender, DataGridViewRowCancelEventArgs e)
        {
            semaphor = 1;
            if (dataGridView1.CurrentRow.Cells["idDataGridViewTextBoxColumn"].Value != DBNull.Value)
            {
                if (MessageBox.Show("Usunąć ten rekord?", "Potwierdzenie", MessageBoxButtons.YesNo) == DialogResult.Yes)
                {

                    var id = dataGridView1.CurrentRow.Cells["idDataGridViewTextBoxColumn"].Value;
                    MySqlCommand command = new MySqlCommand("UsunRekordCennik", connection.cnn);
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
