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
    public partial class Szczegoly : Form
    {
        public Szczegoly(int id)
        {
            InitializeComponent();
            wyswietl(id);
        }

        private void wyswietl(int id)
        {
            MySqlDataAdapter sq = new MySqlDataAdapter("select * from informacjeowypozyczeniach where Wypozyczenia_IdWypozyczenia="+id+";", connection.cnn);
            DataTable dt = new DataTable();
            sq.Fill(dt);

            DataColumn column = dt.Columns.Add("NazwaSprzetu", typeof(string));
            
            foreach(DataRow row in dt.Rows)
            {
                int idsprzetu = int.Parse(row[3].ToString());
                MySqlDataAdapter sq2 = new MySqlDataAdapter("SELECT sprzet.RodzajSprzetu_IdRodzajuSprzetu, rodzajesprzetu.NazwaSprzetu from sprzet " +
                    "INNER JOIN rodzajesprzetu ON sprzet.RodzajSprzetu_IdRodzajuSprzetu = rodzajesprzetu.IdRodzajuSprzetu " +
                    "where IdSprzetu ='"+idsprzetu.ToString()+"';", connection.cnn);
                DataTable dt2 = new DataTable();
                sq2.Fill(dt2);
                row[4] = dt2.Rows[0][1].ToString();
            }
            foreach (DataColumn col in dt.Columns)
            {
                col.ReadOnly = true;
            }
            dataGridView1.AllowUserToAddRows = false;
            dataGridView1.AllowUserToDeleteRows = false;
            dataGridView1.DataSource = dt;
        }
    }
}
