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
    /// Logika interakcji dla klasy MainMenu.xaml
    /// </summary>
    public partial class MainMenu : UserControl
    {
        /// <summary>
        /// String połączenia z bazą oraz dane przechwytywane przez konstruktor
        /// </summary>
        string dbcon = @"Data Source = C:\Users\piers\Documents\GitHub\Aplikacja\LogReg.db;Version=3";
        string x;
        string y;

        public MainMenu()
        {
            InitializeComponent();
        }

        /// <summary>
        /// Konstruktor z argumentami ładujący dane do strony Menu głownego
        /// </summary>
        /// <remarks> Po wybraniu tej strony zostają do niej wczytane dane z bazy</remarks>
        public MainMenu(string id, string typ):this()
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
                imie2.Text = N;
                nazwisko2.Text = LN;
            }
            else
            {
                imie2.Text = N;
                nazwisko2.Text = LN;
            }
            sqlcon.Close();
        }

        /// <summary>
        /// Aktualizacja danych Użytkownika
        /// </summary>
        /// <remarks>Po wpisaniu danych i kliknieciu przycisku Aktualizuj Nazwa i opis Użytkownika zostają zaktualizowane w bazie</remarks>
        private void Akt(object sender, RoutedEventArgs e)
        {
                try
                {
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
                    }
                    if (count == 1)
                    {
                        SQLiteCommand cmd = new SQLiteCommand();
                        cmd.CommandText = @"UPDATE zar_uzyt SET Name = @name, LastName = @lastname WHERE Id_user = @id";
                        cmd.Connection = sqlcon;
                        cmd.Parameters.Add(new SQLiteParameter("@name", name.Text));
                        cmd.Parameters.Add(new SQLiteParameter("@lastname", sname.Text));
                        cmd.Parameters.Add(new SQLiteParameter("@id", x));
                        int i = cmd.ExecuteNonQuery();
                        if (i == 1)
                        {
                            MessageBox.Show("Zaktualizowane dane");
                            imie2.Text = name.Text;
                            nazwisko2.Text = sname.Text;

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
                        cmd1.CommandText = @"INSERT INTO zar_uzyt(Id_user,Name,LastName) VALUES (@id,@name,@lastname)";
                        cmd1.Connection = sqlcon;
                        cmd1.Parameters.Add(new SQLiteParameter("@name", name.Text));
                        cmd1.Parameters.Add(new SQLiteParameter("@lastname", sname.Text));
                        cmd1.Parameters.Add(new SQLiteParameter("@id", x));
                        int u = cmd1.ExecuteNonQuery();
                        if (u == 1)
                        {
                            MessageBox.Show("dodano dane");
                            imie2.Text = name.Text;
                            nazwisko2.Text = sname.Text;
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
