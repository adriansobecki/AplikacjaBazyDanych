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
    public partial class Sprzet : Form
    {
        public static Sprzet form = null;
        private int semaphor = 0;
        public Sprzet()
        {
            InitializeComponent();
        }


        private void btnRodzaje_Click(object sender, EventArgs e)
        {
            if (Rodzaje.form == null)
            {
                Rodzaje.form = new Rodzaje();
            }
            Sprzet.form.Hide();
            Rodzaje.form.Show();
        }

        private void btnCennik_Click(object sender, EventArgs e)
        {
            if (Cennik.form == null)
            {
                Cennik.form = new Cennik();
            }
            Sprzet.form.Hide();
            Cennik.form.Show();
        }


        private void btnWypozyczenia_Click(object sender, EventArgs e)
        {
            if (Wypozyczenia.form == null)
            {
                Wypozyczenia.form = new Wypozyczenia();
            }
            Sprzet.form.Hide();
            Wypozyczenia.form.Show();
        }



        private void bntWyloguj_Click(object sender, EventArgs e)
        {
            Sprzet.form.Hide();
            Logowanie.form.Show();
        }

        private void Sprzet_Load(object sender, EventArgs e)
        {
            // TODO: Ten wiersz kodu wczytuje dane do tabeli 'projekt2DataSet5.sprzet' . Możesz go przenieść lub usunąć.
            this.sprzetTableAdapter.Fill(this.projekt2DataSet5.sprzet);
            opcjeRodzaj();
            opcjeDostepnosc();
            this.user.Text = Logowanie.imie + " " + Logowanie.nazwisko;
            // TODO: Ten wiersz kodu wczytuje dane do tabeli 'projekt2DataSet2.sprzetview' . Możesz go przenieść lub usunąć.
            //this.sprzetviewTableAdapter.Fill(this.projekt2DataSet2.sprzetview);


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

        private void opcjeDostepnosc()
        {



            DataTable dt = new DataTable("DostepnoscKolumna");
            DataColumn column = dt.Columns.Add("Dostepnosc", typeof(string));
            column.AllowDBNull = false;
            column.Unique = true;

            
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
            dostepnoscDataGridViewTextBoxColumn.DataSource = dt;
        }

        private void dataGridView1_CellValueChanged(object sender, DataGridViewCellEventArgs e)
        {
            if (dataGridView1.CurrentRow != null && semaphor==0)
            {
                MySqlCommand command = new MySqlCommand("ModyfikacjaSprzetu", connection.cnn);
                //command.CommandTimeout = 15;
                //CALL `projekt2`.`ModyfikacjaSprzetu`(<{IN Id INT}>, <{IN ArgDostepnosc varchar(20)}>, <{IN ArgUwagi varchar(160)}>);

                command.CommandType = CommandType.StoredProcedure;
                var Id = dataGridView1.CurrentRow.Cells["idSprzetuDataGridViewTextBoxColumn"].Value;
                var ArgDostepnosc = dataGridView1.CurrentRow.Cells["dostepnoscDataGridViewTextBoxColumn"].Value;
                var ArgRozmiar = dataGridView1.CurrentRow.Cells["rozmiarDataGridViewTextBoxColumn"].Value;
                var ArgUwagi = dataGridView1.CurrentRow.Cells["uwagiDataGridViewTextBoxColumn"].Value;
                var ArgRodzaj = dataGridView1.CurrentRow.Cells["rodzajSprzetuIdRodzajuSprzetuDataGridViewTextBoxColumn"].Value;


                MySqlParameter in1 = new MySqlParameter("Id", Id) { Direction = ParameterDirection.Input };
                MySqlParameter in2 = new MySqlParameter("ArgDostepnosc", ArgDostepnosc) { Direction = ParameterDirection.Input };
                MySqlParameter in3 = new MySqlParameter("ArgRozmiar", ArgRozmiar) { Direction = ParameterDirection.Input };
                MySqlParameter in4 = new MySqlParameter("ArgUwagi", ArgUwagi) { Direction = ParameterDirection.Input };
                MySqlParameter in5 = new MySqlParameter("ArgRodzaj", ArgRodzaj) { Direction = ParameterDirection.Input };


                command.Parameters.Add(in1);
                command.Parameters.Add(in2);
                command.Parameters.Add(in3);
                command.Parameters.Add(in4);
                command.Parameters.Add(in5);



                MySqlDataReader rdr = command.ExecuteReader();
                rdr.Close();
            }
        }

        private void dataGridView1_UserAddedRow(object sender, DataGridViewRowEventArgs e)
        {
            semaphor = 1;
            dataGridView1.CurrentRow.Cells["dostepnoscDataGridViewTextBoxColumn"].Value = "Dostepny";
            dataGridView1.CurrentRow.Cells["rozmiarDataGridViewTextBoxColumn"].Value = DBNull.Value;
            dataGridView1.CurrentRow.Cells["uwagiDataGridViewTextBoxColumn"].Value = "";
            dataGridView1.CurrentRow.Cells["rodzajSprzetuIdRodzajuSprzetuDataGridViewTextBoxColumn"].Value = 1;
            //dataGridView1.CurrentRow.Cells["czasWypozyczeniaDataGridViewTextBoxColumn"].Value = 0;
            
            MySqlCommand command = new MySqlCommand("NowySprzet", connection.cnn);
            command.CommandType = CommandType.StoredProcedure;
            var ArgDostepnosc = dataGridView1.CurrentRow.Cells["dostepnoscDataGridViewTextBoxColumn"].Value;
            var ArgRozmiar = dataGridView1.CurrentRow.Cells["rozmiarDataGridViewTextBoxColumn"].Value;
            var Uwagi = dataGridView1.CurrentRow.Cells["uwagiDataGridViewTextBoxColumn"].Value;
            var ArgRodzaj = dataGridView1.CurrentRow.Cells["rodzajSprzetuIdRodzajuSprzetuDataGridViewTextBoxColumn"].Value;
            int id = 0;

            if (ArgRozmiar == DBNull.Value)
                ArgRozmiar = null;
            if (Uwagi == DBNull.Value)
                Uwagi = null;

            MySqlParameter in1 = new MySqlParameter("ArgDostepnosc", ArgDostepnosc) { Direction = ParameterDirection.Input };
            MySqlParameter in2 = new MySqlParameter("ArgRozmiar", ArgRozmiar) { Direction = ParameterDirection.Input };
            MySqlParameter in3 = new MySqlParameter("ArgRodzaj", ArgRodzaj) { Direction = ParameterDirection.Input };
            MySqlParameter in4 = new MySqlParameter("Uwagi", Uwagi) { Direction = ParameterDirection.Input };
            MySqlParameter out1 = new MySqlParameter("Id", id) { Direction = ParameterDirection.Output };


            command.Parameters.Add(in1);
            command.Parameters.Add(in2);
            command.Parameters.Add(in3);
            command.Parameters.Add(in4);
            command.Parameters.Add(out1);


            MySqlDataReader rdr = command.ExecuteReader();

            //while (rdr.Read()) ;
            //id = rdr.GetInt32(1);
            dataGridView1.CurrentRow.Cells["idSprzetuDataGridViewTextBoxColumn"].Value = out1.Value;
            rdr.Close();
            semaphor = 0;
            //Cennik_Load(null,null);
        }

        private void dataGridView1_UserDeletingRow(object sender, DataGridViewRowCancelEventArgs e)
        {
            semaphor = 1;
            if (dataGridView1.CurrentRow.Cells["idSprzetuDataGridViewTextBoxColumn"].Value != DBNull.Value)
            {
                if (MessageBox.Show("Usunąć ten rekord?", "Potwierdzenie", MessageBoxButtons.YesNo) == DialogResult.Yes)
                {

                    var id = dataGridView1.CurrentRow.Cells["idSprzetuDataGridViewTextBoxColumn"].Value;
                    MySqlCommand command = new MySqlCommand("UsunSprzet", connection.cnn);
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
