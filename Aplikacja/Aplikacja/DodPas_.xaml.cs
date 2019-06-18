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
    /// Logika interakcji dla klasy DodPas_.xaml
    /// </summary>
    public partial class DodPas_ : UserControl
    {
        ///zmienna przechowująca Id uzytkownika
        string x;
        
        public DodPas_()
        {
            InitializeComponent();
        }
        public DodPas_(string id) : this()
        {
            x = id;
        }

        /// <summary>
        /// Metoda dodająca pas startowy
        /// </summary>
        /// <remarks> Po kliknieciu przycisku "Dodaj pas Startowy" dane są przekazywane do bazy</remarks>
        private void Add_Click(object sender, RoutedEventArgs e)
        {
            int i = Convert.ToInt32(x);
            string j = ile.Text;
            //Połączenie z bazą
            using (var db = new LogRegEntities())
            {
                int g = rodzaj.SelectedIndex;
                Ile_pas newItem = new Ile_pas
                {
                    Id = db.Ile_pas.Count() + 1,
                    Id_lot = i,
                    Ile_pas1 = Convert.ToInt32(j),
                    typ = g,
                };
                db.Ile_pas.Add(newItem);
                db.SaveChanges();
                MessageBox.Show("Dodano Poprawnie");
                ile.Text = string.Empty;
                rodzaj.SelectedIndex = -1;
                db.Dispose();
            }
        }
    }
}
