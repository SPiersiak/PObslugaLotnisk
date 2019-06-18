﻿using System;
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
    /// Panel zarządzania kontem dla Użytkownika typu Lotnisko
    /// </summary>
    /// <remarks> Po zalogowaniu się Użytkownik typu lotnisko zostaje przekierowany do tego okna.
    /// Może tu wybrać interesującą go zakładkę z menu i przejść do niej.
    /// </remarks>
    public partial class Lotnisko : Window
    {
        string x;
        string y;
        public Lotnisko()
        {
            InitializeComponent();
        }
        public Lotnisko(string id, string typ) : this()
        {
            x = id;
            y = typ;
        }

        /// <summary>
        ///  Metoda dla przycisku zamknięcia.
        /// </summary>
        /// <remarks>Po kliknięciu tego przycisku Aplikacja zostaje zamknięta</remarks>
        private void ButtonFechar_Click(object sender, RoutedEventArgs e)
        {
            Application.Current.Shutdown();
        }

        /// <summary>
        /// Metoda Przesuwania okna
        /// </summary>
        /// <remarks>Po nacisnięciu na okno można je przesuwać po pulpicie</remarks>
        private void Grid_MouseDown(object sender, MouseButtonEventArgs e)
        {
            DragMove();
        }

        /// <summary>
        /// Menu Panelu Lotnisko
        /// </summary>
        ///<remarks>Po kliknięciu na dany przycisk w menu otwiera się odpowiednia zakładka</remarks>
        private void ListViewMenu_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            //index wybranego przycisku
            int index = ListViewMenu.SelectedIndex;
            //Przesunięcie oznaczenia wybranego przycisku
            MoveCursorMenu(index);

            switch (index)
            {
                case 0:
                    GridPrincipal.Children.Clear();
                    GridPrincipal.Children.Add(new lotniskomenu(x,y));
                    break;
                case 1:
                    GridPrincipal.Children.Clear();
                    GridPrincipal.Children.Add(new lotniskomenuadd(x,y));
                    break;
                case 2:
                    GridPrincipal.Children.Clear();
                    GridPrincipal.Children.Add(new RezPasow_(x,y));
                    break;
                case 3:
                    GridPrincipal.Children.Clear();
                    GridPrincipal.Children.Add(new DodPas_(x));
                    break;
                default:
                    break;
            }
        }

        /// <summary>
        /// Przestawienie oznaczenia na wybrany przycisk
        /// </summary>
        /// <remarks>Po kliknięci przycisku graficzny znacznik zostaje na niego przestawiony</remarks>
        private void MoveCursorMenu(int index)
        {
            TrainsitionigContentSlide.OnApplyTemplate();
            GridCursor.Margin = new Thickness(0, (100 + (60 * index)), 0, 0);
        }
    }
}

