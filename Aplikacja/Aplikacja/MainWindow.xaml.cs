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

namespace Aplikacja
{
    /// <summary>
    /// Logika interakcji dla klasy MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }
        private void Login_Click(object sender, RoutedEventArgs e)
        {
            MessageBox.Show("Zalogowano");
            second sec = new second();
            sec.ShowDialog();
            List<string> groceryList = new List<string>();
            using (var db = new LogDbEntities())
            {
                groceryList = (from g in db.LogRegs select g.username).ToList();
                db.Dispose();
                
            }

            foreach(string str in groceryList)
            {
                MainWindow cos = new MainWindow();
                //ListView.Items.Add(str);
                Wyswietl.Items.Add(str);
            }
        }

        private void Register_Click(object sender, RoutedEventArgs e)
        {
            MessageBox.Show("Konto zostało utworzone");
            Register reg = new Register();
            reg.ShowDialog();
            using (var db = new LogDbEntities())
            {
                int g = SP.SelectedIndex;
                LogReg newItem = new LogReg
                {
                    Id = db.LogRegs.Count() + 1,
                    username = UN.Text,
                    password = PW.Password,
                    specification = g,
                };
                db.LogRegs.Add(newItem);
                db.SaveChanges();
                db.Dispose();
            }
        }

        private void TextBox_TextChanged(object sender, TextChangedEventArgs e)
        {

        }

        private void ListView_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            
        }

        private void ComboBoxItem_Selected(object sender, RoutedEventArgs e)
        {

        }
    }
}
