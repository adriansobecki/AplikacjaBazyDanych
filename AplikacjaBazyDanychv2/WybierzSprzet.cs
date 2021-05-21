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
    public partial class WybierzSprzet : Form
    {
        public WybierzSprzet()
        {
            InitializeComponent();
        }

        private void WybierzSprzet_Load(object sender, EventArgs e)
        {
            // TODO: Ten wiersz kodu wczytuje dane do tabeli 'projekt2DataSet.sprzet' . Możesz go przenieść lub usunąć.
            //this.sprzetTableAdapter.Fill(this.projekt2DataSet.sprzet);
            DostepnySprzet();

        }

        private void DostepnySprzet()
        {
            MySqlDataAdapter sq = new MySqlDataAdapter("SELECT IdSprzetu,Rozmiar,Dostepnosc,Uwagi,NazwaSprzetu FROM sprzetview WHERE Dostepnosc='Dostepny';", connection.cnn);
            DataTable dt = new DataTable();

            sq.Fill(dt);
            foreach(DataColumn col in dt.Columns)
            {
                col.ReadOnly = true;
            }
            dataGridView1.DataSource = dt;

            //dataGridView1.Columns[0].ReadOnly = true;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (dataGridView1.CurrentRow != null)
            {
                NoweWypozyczenie.form.NowySprzet(int.Parse(dataGridView1.CurrentRow.Cells["IdSprzetu"].Value.ToString()),
                    float.Parse(dataGridView1.CurrentRow.Cells["Rozmiar"].Value.ToString()),
                    dataGridView1.CurrentRow.Cells["Uwagi"].Value.ToString(),
                    dataGridView1.CurrentRow.Cells["NazwaSprzetu"].Value.ToString());
                /*
                MySqlCommand command = new MySqlCommand("ModyfikacjaSprzetu", connection.cnn);

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
                */
            }
        }
        /*
private void opcjeRodzaj()
{
   MySqlDataAdapter sq = new MySqlDataAdapter("SELECT IdRodzajuSprzetu,NazwaSprzetu FROM rodzajesprzetu;", connection.cnn);
   DataTable dt = new DataTable();
   sq.Fill(dt);
   rodzajSprzetuIdRodzajuSprzetuDataGridViewTextBoxColumn.ValueMember = "IdRodzajuSprzetu";
   rodzajSprzetuIdRodzajuSprzetuDataGridViewTextBoxColumn.DisplayMember = "NazwaSprzetu";
   rodzajSprzetuIdRodzajuSprzetuDataGridViewTextBoxColumn.DataSource = dt;
}
*/
    }
}
