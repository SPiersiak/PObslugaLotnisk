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
    /// Logika interakcji dla Kontrolki DodajPol_.xaml
    /// </summary>
    public partial class DodajPol_ : UserControl
    {
        /// <summary>
        /// String połączenia z bazą oraz dane przechwytywane przez konstruktor
        /// </summary>
        string dbcon = @"Data Source = C:\Users\piers\Documents\GitHub\Aplikacja\LogReg.db;Version=3";
        string x;
        string y;

        public DodajPol_()
        {
            InitializeComponent();
        }

        public DodajPol_(string id, string typ) : this()
        {
            x = id;
            y = typ;
        }

        /// <summary>
        /// Metoda Dodająca połączenia do bazy Danych
        /// </summary>
        /// <remarks>
        /// Po kliknięciu przycisku nawiązywne jest połączenie z bazą, następnie są do niej przekazywane dane połączenia. 
        /// W zależności od statusu działania wyświetli się dany MessageBox
        /// </remarks>
        private void Add_Click(object sender, RoutedEventArgs e)
        {
            SQLiteConnection sqlcon = new SQLiteConnection(dbcon);
            sqlcon.Open();
            SQLiteCommand cmd = new SQLiteCommand();
            cmd.CommandText = @"INSERT INTO przewoznik(K_kl_pierwszej,K_kl_biznesowej,K_kl_ekonomicznej,K_bag_do25,K_bag_pow25,I_miejsc,Cz_trwania,Przesiadki,Id_prze,Z,DO,Nr_lot) VALUES (@klpierwsza,@klbiznes,@klekono,@bagd25,@bagp25,@Imiejsc,@Cztrwania,@przesiadki,@id_prze,@z,@do,@nr_lot)";
            cmd.Connection = sqlcon;
            cmd.Parameters.Add(new SQLiteParameter("@klpierwsza", Convert.ToInt32(firs.Text)));
            cmd.Parameters.Add(new SQLiteParameter("@klbiznes", Convert.ToInt32(biz.Text)));
            cmd.Parameters.Add(new SQLiteParameter("@klekono", Convert.ToInt32(ek.Text)));
            cmd.Parameters.Add(new SQLiteParameter("@bagd25", Convert.ToInt32(do25.Text)));
            cmd.Parameters.Add(new SQLiteParameter("@bagp25", Convert.ToInt32(pow25.Text)));
            cmd.Parameters.Add(new SQLiteParameter("@Imiejsc", Convert.ToInt32(l_miej.Text)));
            cmd.Parameters.Add(new SQLiteParameter("@Cztrwania", zegar.SelectedTime.Value.ToString("hh:mm")));
            cmd.Parameters.Add(new SQLiteParameter("@przesiadki", Prz.SelectionBoxItem.ToString()));
            cmd.Parameters.Add(new SQLiteParameter("@id_prze", x));
            cmd.Parameters.Add(new SQLiteParameter("@z", Z.Text));
            cmd.Parameters.Add(new SQLiteParameter("@do", Do.Text));
            cmd.Parameters.Add(new SQLiteParameter("@nr_lot", nrlot.Text));
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
