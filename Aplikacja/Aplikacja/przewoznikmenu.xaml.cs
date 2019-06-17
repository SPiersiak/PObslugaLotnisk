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
    /// Logika interakcji dla klasy przewoznikmenu.xaml
    /// </summary>
    public partial class przewoznikmenu : UserControl
    {
        string dbcon = @"Data Source = C:\Users\piers\Documents\GitHub\Aplikacja\LogReg.db;Version=3";
        string x;
        string y;
        public przewoznikmenu()
        {
            InitializeComponent();
        }
        public przewoznikmenu(string id, string typ) : this()
        {
            x = id;
            y = typ;
            string N = "Nie podano";
            string O = "Nie podano";
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
                O = dr["Opis"].ToString();
            }
            if (count == 1)
            {
                nazwa.Text = N;
                opis.Text = O;
            }
            else
            {
                nazwa.Text = N;
                opis.Text = O;
            }
            sqlcon.Close();
        }
    }
}
