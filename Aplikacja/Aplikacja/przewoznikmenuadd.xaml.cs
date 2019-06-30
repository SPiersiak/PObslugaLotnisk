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
    /// Logika interakcji dla klasy przewoznikmenuadd.xaml
    /// </summary>
    /// <remarks>Po otworzeniu tej strony możemy zaktualizować dane uzytkowika</remarks>
    public partial class przewoznikmenuadd : UserControl
    {

        /// <summary>
        /// String połączenia z bazą oraz dane przechwytywane przez konstruktor
        /// </summary>
        string dbcon = @"Data Source = C:\Users\piers\Documents\GitHub\Aplikacja\LogReg.db;Version=3";
        string x;
        string y;

        public przewoznikmenuadd()
        {
            InitializeComponent();
        }

        /// <summary>
        /// Konstruktor z parametrami
        /// </summary>
        /// <remarks>Po wywołaniu tego konstruktora zostają wczytane dane użytkownika z bazy danych</remarks>
        /// <param name="id">Id zalogowanego uzytkownika</param>
        /// <param name="typ">Typ zalogowanego uzytkownika</param>
        public przewoznikmenuadd(string id, string typ) : this()
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
                O = dr["opis"].ToString();
            }
            if (count == 1)
            {
                nazwa2.Text = N;
                opis2.Text = O;
            }
            else
            {
                nazwa2.Text = N;
                opis2.Text = O;
            }
            sqlcon.Close();
        }


        /// <summary>
        /// Aktualizacja danych Przewoźnika
        /// </summary>
        /// <remarks>Po wpisaniu danych i przycisku Aktualizuj Nazwa i opis Przewoźnika zostają zaktualizowane w bazie</remarks>
        private void Akt(object sender, RoutedEventArgs e)
        {
            try
            {
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
                }
                if (count == 1)
                {
                    SQLiteCommand cmd = new SQLiteCommand();
                    cmd.CommandText = @"UPDATE lot_prze SET nazwa = @nazwa, opis = @opis WHERE Id_us = @id";
                    cmd.Connection = sqlcon;
                    cmd.Parameters.Add(new SQLiteParameter("@nazwa", nazwa.Text));
                    cmd.Parameters.Add(new SQLiteParameter("@opis", opis.Text));
                    cmd.Parameters.Add(new SQLiteParameter("@id", x));
                    int i = cmd.ExecuteNonQuery();
                    if (i == 1)
                    {
                        MessageBox.Show("Zaktualizowane dane");
                        nazwa2.Text = nazwa.Text;
                        opis2.Text = opis.Text;

                    }
                    else
                    {
                        MessageBox.Show("error1");
                    }

                    sqlcon.Close();
                }
                if (count < 1)
                {
                    SQLiteCommand cmd1 = new SQLiteCommand();
                    cmd1.CommandText = @"INSERT INTO lot_prze(Id_us,Nazwa,opis) VALUES (@id,@nazwa,@opis)";
                    cmd1.Connection = sqlcon;
                    cmd1.Parameters.Add(new SQLiteParameter("@nazwa", nazwa.Text));
                    cmd1.Parameters.Add(new SQLiteParameter("@opis", opis.Text));
                    cmd1.Parameters.Add(new SQLiteParameter("@id", x));
                    int u = cmd1.ExecuteNonQuery();
                    if (u == 1)
                    {
                        MessageBox.Show("dodano dane");
                        nazwa2.Text = nazwa.Text;
                        opis2.Text = opis.Text;
                    }
                    else
                    {
                        MessageBox.Show("error2");
                    }

                    sqlcon.Close();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
    }
}
