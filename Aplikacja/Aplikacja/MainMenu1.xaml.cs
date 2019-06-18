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
    /// Logika interakcji dla klasy MainMenu1.xaml
    /// </summary>
    /// <remarks>Strona menu automatycznie otwierana wraz z otwarciem okna</remarks>
    public partial class MainMenu1 : UserControl
    {
        string dbcon = @"Data Source = C:\Users\piers\Documents\GitHub\Aplikacja\LogReg.db;Version=3";
        string x;
        string y;
        public MainMenu1()
        {
            InitializeComponent();
        }

        /// <summary>
        /// Konstruktor z argumentami ładujący dane do strony Menu głownego
        /// </summary>
        /// <remarks> Po otwarciu automatycznie pobierane są dane z bazy</remarks>
        public MainMenu1(string id, string typ) : this()
        {
            x = id;
            y = typ;
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
            sqlcon.Close();
        }
    }
}
