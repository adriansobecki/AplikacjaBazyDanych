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
            this.wypozyczeniaviewTableAdapter.Fill(this.projekt2DataSet1.wypozyczeniaview);
            //this.wypozyczeniaviewTableAdapter.Adapter.Update(this.projekt2DataSet1.wypozyczeniaview);
            //this.wypozyczeniaviewTableAdapter.Update(this.projekt2DataSet1.wypozyczeniaview);
            //dataGridView1.Columns.
        }


        private void Form2_Load(object sender, EventArgs e)
        {
            // TODO: Ten wiersz kodu wczytuje dane do tabeli 'projekt2DataSet2.sprzetview' . Możesz go przenieść lub usunąć.
            //this.sprzetviewTableAdapter.Fill(this.projekt2DataSet2.sprzetview);
            // TODO: Ten wiersz kodu wczytuje dane do tabeli 'projekt2DataSet1.wypozyczeniaview' . Możesz go przenieść lub usunąć.
            //this.wypozyczeniaviewTableAdapter.Fill(this.projekt2DataSet1.wypozyczeniaview);
            // TODO: Ten wiersz kodu wczytuje dane do tabeli 'projekt2DataSet.wypozyczenia' . Możesz go przenieść lub usunąć.
            //this.wypozyczeniaTableAdapter.Fill(this.projekt2DataSet.wypozyczenia);
            //this.wypozyczeniaviewTableAdapter.Fill(this.projekt2DataSet1.wypozyczeniaview);
            UpdateForm();
            this.user.Text=Logowanie.imie+" "+Logowanie.nazwisko;
            //dataGridView1.Update();

        }

        private void btnSprzęt_Click(object sender, EventArgs e)
        {
            if (Sprzet.form == null)
            {
                Sprzet.form = new Sprzet();
            }
            Wypozyczenia.form.Hide();
            Sprzet.form.UpdateForm();
            Sprzet.form.Show();
            //Wypozyczenia.form.Close();
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
            Cennik.form.UpdateForm();
            Cennik.form.Show();
            //Cennik.form.UpdateForm();
        }

        private void bntWyloguj_Click(object sender, EventArgs e)
        {
            Wypozyczenia.form.Hide();
            Logowanie.form.clear();
            Logowanie.form.Show();
            //Logowanie.form.clear();
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

        private void button7_Click(object sender, EventArgs e)
        {
            if (dataGridView1.CurrentRow != null)
            {
                if (MessageBox.Show("Potwiedzasz zwrot sprzętu?", "Potwierdzenie", MessageBoxButtons.YesNo) == DialogResult.Yes)
                {
                    MySqlCommand command = new MySqlCommand("ZwrotSprzetu", connection.cnn);
                    //command.CommandTimeout = 15;
                    //CALL `projekt2`.`EdycjaCzasuWypozyczenia`(<{IN Id INT}>, <{IN Czas TIME}>);

                    command.CommandType = CommandType.StoredProcedure;
                    var Id = dataGridView1.CurrentRow.Cells["idWypozyczeniaDataGridViewTextBoxColumn"].Value;
                    int spoznienie = 0;


                    MySqlParameter in1 = new MySqlParameter("Id", Id) { Direction = ParameterDirection.Input };
                    MySqlParameter out1 = new MySqlParameter("Spoznienie", spoznienie) { Direction = ParameterDirection.Output };

                    command.Parameters.Add(in1);
                    command.Parameters.Add(out1);




                    MySqlDataReader rdr = command.ExecuteReader();
                    spoznienie = int.Parse(out1.Value.ToString());
                    rdr.Close();
                    //MessageBox.Show(spoznienie.ToString());
                    //if(spoznienie>0)
                    //{
                    MySqlDataAdapter sq = new MySqlDataAdapter("SELECT informacjeowypozyczeniach.*, sprzet.RodzajSprzetu_IdRodzajuSprzetu" +
                        " FROM informacjeowypozyczeniach" +
                        " INNER JOIN sprzet ON informacjeowypozyczeniach.Sprzet_IdSprzetu = sprzet.IdSprzetu" +
                        " WHERE Wypozyczenia_IdWypozyczenia =" + Id.ToString() + ";", connection.cnn);
                    DataTable dt = new DataTable();
                    sq.Fill(dt);
                    int kwotaCalkowita = 0;
                    if (spoznienie < 0)
                        spoznienie = 0;
                    foreach (DataRow row in dt.Rows)
                    {
                        MySqlCommand command2 = new MySqlCommand("NaliczenieOplatyKarnej", connection.cnn);
                        command2.CommandType = CommandType.StoredProcedure;
                        int idsprzetu = int.Parse(row[3].ToString());
                        int rodzaj = int.Parse(row[4].ToString());
                        int oplataKarna = 0;
                        MySqlParameter in2 = new MySqlParameter("IdWyp", int.Parse(Id.ToString())) { Direction = ParameterDirection.Input };
                        MySqlParameter in3 = new MySqlParameter("IdSprz", idsprzetu) { Direction = ParameterDirection.Input };
                        MySqlParameter in4 = new MySqlParameter("Rodzaj", rodzaj) { Direction = ParameterDirection.Input };
                        MySqlParameter in5 = new MySqlParameter("Delay", spoznienie) { Direction = ParameterDirection.Input };
                        MySqlParameter out2 = new MySqlParameter("OplataK", oplataKarna) { Direction = ParameterDirection.Output };

                        command2.Parameters.Add(in2);
                        command2.Parameters.Add(in3);
                        command2.Parameters.Add(in4);
                        command2.Parameters.Add(in5);
                        command2.Parameters.Add(out2);
                        MySqlDataReader rdr2 = command2.ExecuteReader();
                        //MessageBox.Show(oplataKarna.ToString());
                        oplataKarna = int.Parse(out2.Value.ToString());
                        //MessageBox.Show(oplataKarna.ToString());
                        int oplatazawypozyczenie = int.Parse(row[0].ToString());
                        kwotaCalkowita = kwotaCalkowita + oplataKarna + oplatazawypozyczenie;
                        rdr2.Close();

                        MySqlCommand command4 = new MySqlCommand("SprzetOddany", connection.cnn);
                        command4.CommandType = CommandType.StoredProcedure;
                        MySqlParameter in8 = new MySqlParameter("Id", idsprzetu) { Direction = ParameterDirection.Input };
                        command4.Parameters.Add(in8);
                        command4.ExecuteNonQuery();

                    }
                    MySqlCommand command3 = new MySqlCommand("NaliczenieKwotyCalkowitej", connection.cnn);
                    command3.CommandType = CommandType.StoredProcedure;

                    MySqlParameter in6 = new MySqlParameter("Kwota", kwotaCalkowita) { Direction = ParameterDirection.Input };
                    MySqlParameter in7 = new MySqlParameter("Id", int.Parse(Id.ToString())) { Direction = ParameterDirection.Input };

                    command3.Parameters.Add(in6);
                    command3.Parameters.Add(in7);

                    command3.ExecuteNonQuery();

                    UpdateForm();
                }
            }
        }

        private void dataGridView1_CellContentClick_1(object sender, DataGridViewCellEventArgs e)
        {
            var senderGrid = (DataGridView)sender;

            if (senderGrid.Columns[e.ColumnIndex] is DataGridViewButtonColumn &&
                e.RowIndex >= 0)
            {
                int index = int.Parse(senderGrid.CurrentRow.Cells["idWypozyczeniaDataGridViewTextBoxColumn"].Value.ToString());
                //MessageBox.Show(index.ToString());
                System.Windows.Forms.Form szczegoly = new Szczegoly(index);
                szczegoly.Show();
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            
            string strCmdText;
            var date = DateTime.Now;
            strCmdText = "/C start /b /w \"\" \"C:\\Program Files\\MySQL\\MySQL " +
                "Server 8.0\\bin\\mysqldump.exe\" -u root -p projekt2 > " +
                "C:\\Users\\Adrian\\Desktop\\Backup\\db_backup"
                +date.ToString("MM_dd_yyyy_HH_mm")+".sql";
            System.Diagnostics.Process.Start("C:\\Users\\Adrian\\Desktop" +
                "\\cmd.lnk", strCmdText);


            /*
            System.Diagnostics.Process process = new System.Diagnostics.Process();
            System.Diagnostics.ProcessStartInfo startInfo = new System.Diagnostics.ProcessStartInfo();
            //startInfo.WindowStyle = System.Diagnostics.ProcessWindowStyle.Hidden;
            startInfo.FileName = Environment.ExpandEnvironmentVariables("%SystemRoot%") + @"\System32\cmd.exe";
            startInfo.Arguments = strCmdText;
            //startInfo.Verb = "runas";
            process.StartInfo = startInfo;
            process.Start();
            */
            /*
            using (MySqlCommand cmd = new MySqlCommand())
            {
                using (MySqlBackup mb = new MySqlBackup(cmd))
                {
                    cmd.Connection = conn;
                    conn.Open();
                    mb.ExportToFile(file);
                    conn.Close();
                }
            }
            */
        }

        private void button2_Click(object sender, EventArgs e)
        {
            OpenFileDialog openFileDialog1 = new OpenFileDialog();

            openFileDialog1.InitialDirectory = "C:\\Users\\Adrian\\Desktop\\Backup\\";
            //openFileDialog1.Filter = "Database files (*.mdb, *.accdb)|*.mdb;*.accdb";
            openFileDialog1.FilterIndex = 0;
            openFileDialog1.RestoreDirectory = true;

            if (openFileDialog1.ShowDialog() == DialogResult.OK)
            {
                string selectedFileName = openFileDialog1.FileName;
                string strCmdText;
                MessageBox.Show(selectedFileName);
                strCmdText = "/C start /b /w \"\" \"C:\\Program Files\\MySQL\\" +
                    "MySQL Server 8.0\\bin\\mysql.exe\" -u root -p projekt2 < "+selectedFileName;
                System.Diagnostics.Process.Start("C:\\Users\\Adrian\\Desktop\\cmd.lnk", strCmdText);


                //...
            }
        }
    }
}
