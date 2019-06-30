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
    /// Panel zarządzania kontem dla Użytkownika typu Przewoznik
    /// </summary>
    /// <remarks> Po zalogowaniu się Użytkownik typu Przewoznik zostaje przekierowany do tego okna.
    /// Może tu wybrać interesującą go zakładkę z menu i przejść do niej.
    /// </remarks>
    public partial class Przewoznik : Window
    {
        string x;
        string y;
        public Przewoznik()
        {
            InitializeComponent();
        }

        /// <summary>
        /// Konstruktor przekazujący parametry
        /// </summary>
        /// <param name="id">Id zalogowanego uzytkownika</param>
        /// <param name="typ">Typ zalogowanego uzytkownika</param>
        public Przewoznik(string id, string typ) : this()
        {
            x = id;
            y = typ;
        }

        /// <summary>
        ///  Metoda dla przycisku zamknięcia.
        /// </summary>
        /// <remarks>Po kliknięciu tego przycisku Aplikacja zostaje zamknięta</remarks>
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

        /// <summary>
        /// Menu Panelu Pasazer
        /// </summary>
        ///<remarks>Po kliknięciu na dany przycisk w menu otwiera się odpowiednia zakładka</remarks>
        /// <param name="sender">Obiekt wywołujący zdarzenie</param>
        /// <param name="e">Zdarzenie które wywołało funkcję</param>
        private void ListViewMenu_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            int index = ListViewMenu.SelectedIndex;
            MoveCursorMenu(index);

            switch (index)
            {
                case 0:
                    GridPrincipal.Children.Clear();
                    GridPrincipal.Children.Add(new przewoznikmenu(x,y));
                    break;
                case 1:
                    GridPrincipal.Children.Clear();
                    GridPrincipal.Children.Add(new przewoznikmenuadd(x,y));
                    break;
                case 2:
                    GridPrincipal.Children.Clear();
                    GridPrincipal.Children.Add(new MojePol_(x,y));
                    break;
                case 3:
                    GridPrincipal.Children.Clear();
                    GridPrincipal.Children.Add(new DodajPol_(x,y));
                    break;
                case 4:
                    GridPrincipal.Children.Clear();
                    GridPrincipal.Children.Add(new RejPas(x,y));
                    break;
                default:
                    break;
            }
        }

        /// <summary>
        /// Przestawienie oznaczenia na wybrany przycisk
        /// </summary>
        /// <remarks>Po kliknięci przycisku graficzny znacznik zostaje na niego przestawiony</remarks>
        /// /// <param name="index">index wybranego przycisku menu</param>
        private void MoveCursorMenu(int index)
        {
            TrainsitionigContentSlide.OnApplyTemplate();
            GridCursor.Margin = new Thickness(0, (100 + (60 * index)), 0, 0);
        }
    }
}

