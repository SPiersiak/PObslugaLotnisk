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

namespace Aplikacja
{
    /// <summary>
    /// Logika interakcji dla klasy Register.xaml
    /// </summary>
    /// <remarks>Okno rejestracji użytkownika</remarks>
    public partial class Register : Window
    {
        string x;
        string y;
        public Register()
        {
            InitializeComponent();
        }

        /// <summary>
        /// Konstruktor z parametrami
        /// </summary>
        /// <param name="id">Id zalogowanego uzytkownika</param>
        /// <param name="typ">Typ zalogowanego uzytkownika</param>
        public Register(string id, string typ):this()
        {
            x = id;
            y = typ;
        }



        /// <summary>
        /// Rejestracja do Aplikacji
        /// </summary>
        /// <remarks>Po wybraniu typu konta oraz wpisaniu Loginu i hasła oraz Kliknięciu Login
        /// wpisane do pól dane dodawane są do bazy danych
        /// i jesteśmy przenoszeni do okna Logowania aplikacji</remarks>
        /// <param name="sender">Obiekt wywołujący zdarzenie</param>
        /// <param name="e">Zdarzenie które wywołało funkcję</param>
        private void Register_Click(object sender, RoutedEventArgs e)
        {   
           using (var db = new LogRegEntities())
            {
                int g = usrtype.SelectedIndex;
                Log newItem = new Log
                {
                    //Id = db.Logs.Count() + 1,
                    username = LoginBox.Text,
                    password = Password.Password,
                    specification = g,
                };
                db.Logs.Add(newItem);
                db.SaveChanges();
                db.Dispose();
                
            }
            this.Hide();
            MainWindow log = new MainWindow();
            log.ShowDialog();
            



        }


        /// <summary>
        ///  Metoda dla przycisku zamknięcia.
        /// </summary>
        /// <Remarks>Po kliknięciu tego przycisku Aplikacja zostaje zamknięta</Remarks>
        /// <param name="sender">Obiekt wywołujący zdarzenie</param>
        /// <param name="e">Zdarzenie które wywołało funkcję</param>
        private void ButtonFechar_Click(object sender, RoutedEventArgs e)
        {
            Application.Current.Shutdown();
        }

        /// <summary>
        /// Metoda Przesuwania okna
        /// </summary>
        /// <remarks>Po nacisnięciu na okno można je przesuwać po pulpicie</remarks>
        /// <param name="sender">Obiekt wywołujący zdarzenie</param>
        /// <param name="e">Zdarzenie które wywołało funkcję</param>
        private void Grid_MouseDown(object sender, MouseButtonEventArgs e)
        {
            DragMove();
        }
    }
}
