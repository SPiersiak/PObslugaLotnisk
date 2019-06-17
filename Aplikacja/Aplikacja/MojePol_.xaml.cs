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
    /// Logika interakcji dla klasy MojePol_.xaml
    /// </summary>
    public partial class MojePol_ : UserControl
    {
        string dbcon = @"Data Source = C:\Users\piers\Documents\GitHub\Aplikacja\LogReg.db;Version=3";
        string x;
        string y;
        public MojePol_()
        {
            InitializeComponent();
            Linia.Text = "LOT";
        }
        public MojePol_(string id, string typ):this()
        {
            x = id;
            y = typ;
            SQLiteConnection sqlcon = new SQLiteConnection(dbcon);
            sqlcon.Open();
            string query = "SELECT Nr_lot, Z, DO, Cz_trwania, Przesiadki FROM przewoznik WHERE Id_prze ='" + x + "'";
            SQLiteCommand com = new SQLiteCommand(query, sqlcon);
            com.ExecuteNonQuery();
            SQLiteDataReader dr = com.ExecuteReader();
            int count = 0;
            while (dr.Read())
            {
                count++;
                Lista nazwa = new Lista { NrLot = dr["Nr_lot"].ToString(), LotStart = dr["Z"].ToString(), LotDoc = dr["DO"].ToString(), Ctrw = dr["Cz_trwania"].ToString(), Prze = dr["Przesiadki"].ToString() };
                Pol.Items.Add(nazwa);
            }
            sqlcon.Close();
        }
    }

    public class Lista
    {
        public string NrLot { get; set; }
        public string LotStart { get; set; }
        public string LotDoc { get; set; }
        public string Ctrw { get; set; }
        public string Prze { get; set; }
    }
}