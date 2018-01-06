using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using  MySql.Data.MySqlClient;


namespace Premia
{
    
    public partial class Form1 : Form
    {
        String konfiguracja = "datasource=localhost; port=3306; username=root;password=password;database=serwis";
        public Form1()
        {
            InitializeComponent();
            pokaz_siatke();
        }
        
        private void oblicz()
        {
            double suma=0;
            double premia = 0;
            double premia_netto = 0;
  
            for (int i=0; i < dgPremia.Rows.Count; i++)
            {
                suma += Convert.ToDouble(dgPremia.Rows[i].Cells[2].Value); // oblicza sume kolumny z kwotą
            }
            lblSumaNetto.Text = Convert.ToString(suma); //suma kwot

            premia = suma * ((Convert.ToDouble(tbProcent.Text)/100)); // premia brutto
            lblPremiaBrutto.Text = Convert.ToString(premia); //zapis do odpowiedniego pola premii brutto

            
            premia_netto= premia * 0.7;
            lblPremiaNetto.Text = Convert.ToString(premia_netto);
        }
        
        private void pokaz_siatke()
        {
            MySqlConnection laczBaze = new MySqlConnection(konfiguracja);
            MySqlCommand pobierzDane = new MySqlCommand("SELECT * FROM premia.tabelaPremia ORDER by wpis_id;", laczBaze);

            try
            {
                MySqlDataAdapter wczytaj = new MySqlDataAdapter(); //interfejs miedzy bazą a danymi
                wczytaj.SelectCommand = pobierzDane;
                DataTable tabela = new DataTable(); // tworzymy tabele
                wczytaj.Fill(tabela);

                BindingSource zrodlo = new BindingSource();
                zrodlo.DataSource = tabela;
                dgPremia.DataSource = zrodlo;
                laczBaze.Close();

            }
            catch (Exception komunikat)
            {
                MessageBox.Show(komunikat.Message);
            }
            oblicz();
            //.Columns[0].Visible = false;
        }

        private void btnSzukaj_Click(object sender, EventArgs e)
        {
            MySqlConnection laczBaze = new MySqlConnection(konfiguracja);
            MySqlCommand wyszukiwanie = new MySqlCommand("SELECT * FROM premia.tabelapremia WHERE CONCAT (numerFV, kwota, opis,' ', data) LIKE '%" + tbSzukaj.Text + "%' ORDER BY wpis_id;", laczBaze);

            try
            {
                MySqlDataAdapter polaczenie = new MySqlDataAdapter();
                polaczenie.SelectCommand = wyszukiwanie;
                DataTable tabela = new DataTable();
                polaczenie.Fill(tabela);

                BindingSource zrodlo = new BindingSource();
                zrodlo.DataSource = tabela;
                dgPremia.DataSource = zrodlo;
                laczBaze.Close();
            }
            catch (Exception komunikat)
            {
                MessageBox.Show(komunikat.Message);
            }
            oblicz();
        }

        private void dgPremia_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                id_rekordu = Convert.ToInt32(dgPremia.Rows[e.RowIndex].Cells[0].Value);
                tbNumerFV.Text=dgPremia.Rows[e.RowIndex].Cells[1].Value.ToString();
                tbKwotaFV.Text = dgPremia.Rows[e.RowIndex].Cells[2].Value.ToString();
                tbOpis.Text = dgPremia.Rows[e.RowIndex].Cells[3].Value.ToString();
                dpData.Text = dgPremia.Rows[e.RowIndex].Cells[4].Value.ToString();

                btnModyfikuj.Enabled = true;
                btnUsun.Enabled = true;

            }
        }

        private void btnDodaj_Click(object sender, EventArgs e)
        {
            if (tbKwotaFV.Text.Length < 2) MessageBox.Show("Data i kwota to pola obowiązkowe !");
            else
            {
                MessageBox.Show("Wpis został pomyślnie dodany");

                MySqlConnection laczBaze = new MySqlConnection(konfiguracja);
                MySqlCommand polaczenie = laczBaze.CreateCommand();
                MySqlTransaction transakcja;
                laczBaze.Open();

                transakcja = laczBaze.BeginTransaction(IsolationLevel.ReadCommitted);

                polaczenie.Connection = laczBaze;
                polaczenie.Transaction = transakcja;

                try
                {
                    polaczenie.CommandText = "INSERT INTO premia.tabelaPremia SET numerFV='"+tbNumerFV.Text+"', kwota='"+tbKwotaFV.Text+"', opis='"+tbOpis.Text+"', data='"+dpData.Text+"'   ;";
                    polaczenie.ExecuteNonQuery();
                    transakcja.Commit();
                }
                catch (Exception komunikat)
                {
                    MessageBox.Show(komunikat.Message);
                }

                pokaz_siatke();
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            oblicz();
        }
    }
}
