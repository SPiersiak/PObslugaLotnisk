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
using System.Windows.Navigation;
using System.Windows.Shapes;
using System.Data.Entity;
using System.Data.SQLite;
using System.IO;

namespace Aplikacja
{
    /// <summary>
    /// Logika interakcji dla klasy Zarezerwuj_.xaml
    /// </summary>
    public partial class Zarezerwuj_ : UserControl
    {
        string dbcon = @"Data Source = C:\Users\piers\Documents\GitHub\Aplikacja\LogReg.db;Version=3";
        string x;
        public Zarezerwuj_()
        {
            InitializeComponent();

        }
        public Zarezerwuj_(string typ):this()
        {
            x = typ;

        }
       


        /// <summary>
        /// Wyszukiwanie Dostępnych lotów
        /// </summary>
        /// <remarks>Po wciśnięciu przycisku w tabeli wyświetlane są wszystkie dostępne Loty miedzy dwoma wpisanymi miejscami</remarks>
        private void Add_Click(object sender, RoutedEventArgs e)
        {
            SQLiteConnection sqlcon = new SQLiteConnection(dbcon);
            sqlcon.Open();
            string query = "SELECT Z, DO, Dzien, Nr_lot FROM przewoznik WHERE Z ='" + Z.Text + "' AND DO = '" + DO.Text + "'";
            SQLiteCommand com = new SQLiteCommand(query, sqlcon);
            com.ExecuteNonQuery();
            SQLiteDataReader dr = com.ExecuteReader();
            int count = 0;
            while (dr.Read())
            {
                count++;
                baza nazwa = new baza { Z = dr["Z"].ToString(), Do = dr["DO"].ToString(), Kiedy = dr["Dzien"].ToString(), Nrlot = dr["Nr_lot"].ToString() };
                Rezw.Items.Add(nazwa);
            }
            sqlcon.Close();
        }


        /// <summary>
        /// Pokaż szczegóły
        /// </summary>
        /// <remarks>Po wciśnięciu przycisku w tabeli w nowym oknie wyświetlane sa szczegółowe dane zaznaczonej w tabeli rezerwacji</remarks>
        private void Kol_Click(object sender, RoutedEventArgs e)
        {
            baza cos = (baza)Rezw.SelectedItem;
            string f = cos.Nrlot;
            Szczegoly abc = new Szczegoly(f);
            abc.Show();
           
        }
    }

    /// <summary>
    /// Klasa Reprezentująca Wiersz w tabeli
    /// </summary>
    /// <remarks>Każda zmienna odpowiada danej kolumnie w tabeli</remarks>
    public class baza
    {
        public string Z { get; set; }
        public string Do { get; set; }
        public string Kiedy{ get; set; }
        public string Nrlot { get; set; }
    }
}
