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
    /// Logika interakcji dla klasy RezPasow_.xaml
    /// </summary>
    /// <remarks>Dodawanie terminu rezerwacji pasa przez lotnisko</remarks>
    public partial class RezPasow_ : UserControl
    {
        string dbcon = @"Data Source = C:\Users\piers\Documents\GitHub\Aplikacja\LogReg.db;Version=3";
        string x;
        string y;
        public RezPasow_()
        {
            InitializeComponent();
         
        }
        public RezPasow_(string id, string typ) : this()
        {
            x = id;
            y = typ;
        }

        /// <summary>
        /// Dodanie Dostępności pasa so bazy
        /// </summary>
        /// <remarks>Po wpisaniu danych i kliknieciu przycisku dany termin zostaje wpisany do bazy danych</remarks>
        private void Add_Click(object sender, RoutedEventArgs e)
        {
            SQLiteConnection sqlcon = new SQLiteConnection(dbcon);
            sqlcon.Open();
            SQLiteCommand cmd = new SQLiteCommand();
            cmd.CommandText = @"INSERT INTO lotnisko(Nazwa_Lot,Adres,Dzien,Godzina,Nr_pas,Typ_sam,Koszt,Zarezerwowane,Id_lot) VALUES (@nazwa,@adres,@dzien,@godzina,@nr_pas,@typ_sam,@koszt,@zarezerwowane,@id_lot)";
            cmd.Connection = sqlcon;
            cmd.Parameters.Add(new SQLiteParameter("@nazwa", Nazwa.Text));
            cmd.Parameters.Add(new SQLiteParameter("@adres", adres.Text));
            cmd.Parameters.Add(new SQLiteParameter("@dzien", Date.SelectedDate.Value.ToString("dd-MM-yyyy")));
            cmd.Parameters.Add(new SQLiteParameter("@godzina", zegar.SelectedTime.Value.ToString("hh:mm")));
            cmd.Parameters.Add(new SQLiteParameter("@nr_pas", Convert.ToInt32(nr_pas.Text)));
            cmd.Parameters.Add(new SQLiteParameter("@typ_sam", Samolot.SelectionBoxItem.ToString()));
            cmd.Parameters.Add(new SQLiteParameter("@koszt", Convert.ToInt32(Koszt.Text)));
            cmd.Parameters.Add(new SQLiteParameter("@zarezerwowane", "Nie"));
            cmd.Parameters.Add(new SQLiteParameter("@id_lot", x));
            int u = cmd.ExecuteNonQuery();
            if (u == 1)
            {
                MessageBox.Show("dodano dane");
            }
            else
            {
                MessageBox.Show("error2");
            }

            sqlcon.Close();
        }
    }

}
