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
    public partial class Register : Window
    {
        public Register()
        {
            InitializeComponent();
            

        }




        private void Register_Click(object sender, RoutedEventArgs e)
        {
            string login = LoginBox.Text;
            string passw = Password.Password;
            int type = usrtype.SelectedIndex;
            LoginBox.Text = type.ToString();

            this.Hide();
            MessageBox.Show("Zarejestrowano");
            Pasazer pas = new Pasazer();
            pas.ShowDialog();



        }

        private void Usrtype_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            
        }
    }
}
