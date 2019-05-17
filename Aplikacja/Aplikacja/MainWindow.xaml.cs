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
            string Login = Login1.Text;
            string Passw = Password.Password;

            this.Hide();
            //MessageBox.Show("Zalogowano");
            second sec = new second();
            sec.ShowDialog();
        }

        private void Register_Click(object sender, RoutedEventArgs e)
        {

            this.Hide();
            Register reg = new Register();
            reg.ShowDialog();
        }

      

        private void Login1_TextChanged(object sender, TextChangedEventArgs e)
        {

        }
    }
}
