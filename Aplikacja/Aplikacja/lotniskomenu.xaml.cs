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
    /// Logika interakcji dla klasy lotniskomenu.xaml
    /// </summary>
    public partial class lotniskomenu : UserControl
    {
        /// <summary>
        /// String połączenia z bazą oraz dane przechwytywane przez konstruktor
        /// </summary>
        string dbcon = @"Data Source = C:\Users\piers\Documents\GitHub\Aplikacja\LogReg.db;Version=3";
        string x;
        string y;

        public lotniskomenu()
        {
            InitializeComponent();

        }

        /// <summary>
        /// Konstruktor z argumentami ładujący dane do strony Menu głownego
        /// </summary>
        /// <remarks> Po wybraniu tej strony zostają do niej wczytane dane z bazy</remarks>
        public lotniskomenu (string id, string typ) : this()
        {
            x = id;
            y = typ;
            int i = Convert.ToInt32(typ);
            string N = "Nie podano";
            string LN = "Nie podano";
            string N1 = "Nie podano";
            int N2 =  0;
            SQLiteConnection sqlcon = new SQLiteConnection(dbcon);
            sqlcon.Open();
            string query = "SELECT * FROM lot_prze WHERE Id_us = '" + x + "'";
            SQLiteCommand com = new SQLiteCommand(query, sqlcon);
            com.ExecuteNonQuery();
            SQLiteDataReader dr = com.ExecuteReader();
            int count = 0;
            while (dr.Read())
            {
                count++;
                N = dr["Nazwa"].ToString();
                LN = dr["opis"].ToString();
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
            string query2 = "SELECT * FROM Ile_pas WHERE Id_lot = '" + x + "'";
            SQLiteCommand com2 = new SQLiteCommand(query2, sqlcon);
            com2.ExecuteNonQuery();
            SQLiteDataReader dr2 = com2.ExecuteReader();
            int count2 = 0;
            while (dr2.Read())
            {
                count2++;
                N1 = dr2["Ile_pas"].ToString();
                N2 = Convert.ToInt32(dr2["typ"]);
                if (N2 == 0)
                {
                    maly.Content = N1;
                }
                if (N2 == 1)
                {
                    sredni.Content = N1;
                }
                if (N2 == 2)
                {
                    duzy.Content = N1;
                }
            }
            sqlcon.Close();
        }
    }
}
