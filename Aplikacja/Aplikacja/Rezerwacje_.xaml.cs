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

namespace Aplikacja
{
    /// <summary>
    /// Logika interakcji dla klasy Rezerwacje.xaml
    /// </summary>
    public partial class Rezerwacje_ : UserControl
    {
        string dbcon = @"Data Source = C:\Users\piers\Documents\GitHub\Aplikacja\LogReg.db;Version=3";
        string x;
        public Rezerwacje_()
        {
            InitializeComponent();

            SQLiteConnection sqlcon = new SQLiteConnection(dbcon);
            sqlcon.Open();
            string query = "SELECT nr_lotu FROM rezerwacje WHERE id_uzyt ='" + x + "' ";
            SQLiteCommand com = new SQLiteCommand(query, sqlcon);
            com.ExecuteNonQuery();
            SQLiteDataReader dr = com.ExecuteReader();
            int count = 0;
            while (dr.Read())
            {
                count++;
                Wie nazwa = new Wie { Nrlot = dr["nr_lotu"].ToString() };
                Rezwac.Items.Add(nazwa);
            }
            sqlcon.Close();
        }

        public Rezerwacje_(string id) : this()
        {
            x = id;
            string N = "Nie podano";
            string LN = "Nie podano";
            SQLiteConnection sqlcon = new SQLiteConnection(dbcon);
            sqlcon.Open();
            string query = "SELECT * FROM zar_uzyt WHERE Id_user = '" + x + "'";
            SQLiteCommand com = new SQLiteCommand(query, sqlcon);
            com.ExecuteNonQuery();
            SQLiteDataReader dr = com.ExecuteReader();
            int count = 0;
            while (dr.Read())
            {
                count++;
                N = dr["Name"].ToString();
                LN = dr["LastName"].ToString();
            }
            if (count == 1)
            {
                name.Text = N;
                sname.Text = LN;
            }
            else
            {
                name.Text = N;
                sname.Text = LN;
            }
            sqlcon.Close();
        }

        private void Rezw_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {

        }
    }

    /// <summary>
    /// Klasa Reprezentująca Wiersz w tabeli
    /// </summary>
    /// <remarks>Każda zmienna odpowiada danej kolumnie w tabeli</remarks>
    public class Wie
    {
        public string Nrlot { get; set; }
    }
}
