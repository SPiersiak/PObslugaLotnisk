using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Shapes;
using System.Data.Entity;
using System.Data.SQLite;

namespace Aplikacja
{
    /// <summary>
    /// Logika interakcji dla klasy Szczegoly.xaml
    /// </summary>
    /// <remarks>Okno ze szczegółowymi danymi rezerwacji</remarks>
    public partial class Szczegoly : Window
    {
        string dbcon = @"Data Source = C:\Users\piers\Documents\GitHub\Aplikacja\LogReg.db;Version=3";
        string x;
        public Szczegoly()
        {
            InitializeComponent();
        }

        /// <summary>
        /// Konstruktor z parametrem
        /// </summary>
        /// <remarks>Po stworzeniu obiektu z parametrami wczytuje dane z bazy</remarks>
        /// <param name="id">Id zalogowanego uzytkownika</param>
        public Szczegoly(string nr):this()
        {
            x = nr;
            SQLiteConnection sqlcon = new SQLiteConnection(dbcon);
            sqlcon.Open();
            string query = "SELECT Nr_lot, Z, DO, K_bag_do25, K_bag_pow25, K_kl_ekonomicznej, K_kl_biznesowej, K_kl_pierwszej, Przesiadki FROM przewoznik WHERE Nr_lot = '" + x + "'";
            SQLiteCommand com = new SQLiteCommand(query, sqlcon);
            com.ExecuteNonQuery();
            SQLiteDataReader dr = com.ExecuteReader();
            int count = 0;
            string z = "";
            string d = "";
            int doo25 = 0;
            int po25 = 0;
            int ek = 0;
            int biz = 0;
            int pie = 0;
            string prz = "";
            while (dr.Read())
            {
                count++;
                z = dr["Z"].ToString();
                d = dr["DO"].ToString();
                doo25 = Convert.ToInt32(dr["K_bag_do25"]);
                po25 = Convert.ToInt32(dr["K_bag_pow25"]);
                ek = Convert.ToInt32(dr["K_kl_ekonomicznej"]);
                biz = Convert.ToInt32(dr["K_kl_biznesowej"]);
                pie = Convert.ToInt32(dr["K_kl_pierwszej"]);
                prz = dr["Przesiadki"].ToString();
            }
            string query2 = "SELECT Dzien, Godzina FROM lotnisko WHERE Nr_lot = '" + x + "'";
            SQLiteCommand com2 = new SQLiteCommand(query2, sqlcon);
            com2.ExecuteNonQuery();
            SQLiteDataReader dr2 = com2.ExecuteReader();
            int count2 = 0;
            string da = "";
            string go = "";
            while (dr2.Read())
            {
                count2++;
                da = dr2["Dzien"].ToString();
                go = dr2["Godzina"].ToString();
            }
            sqlcon.Close();
            nrlot.Content = x;
            wyl.Content = z;
            cel.Content = d;
            date.Content = da;
            god.Content = go;
            do25.Content = doo25;
            pow25.Content = pow25;
            eko.Content = ek;
            bi.Content = biz;
            pi.Content = pie;
            prze.Content = prz;
        }


        /// <summary>
        /// Rezrwacja terminu
        /// </summary>
        /// <remarks>Po kliknięciu wyświetlony w oknie termin zostaje zarezerwowany</remarks>
        /// <param name="sender">Obiekt wywołujący zdarzenie</param>
        /// <param name="e">Zdarzenie które wywołało funkcję</param>
        private void Rezerwacja_Click(object sender, RoutedEventArgs e)
        {

        }
    }
}
