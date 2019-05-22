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

            string log;
            string pas;
            
            List<string> loginList = new List<string>();
            using (var db = new LogRegEntities())
            {
                loginList = (from g in db.LogRegs select g.Id + g.username + g.password + g.specification).ToList();
                db.Dispose();
            }
           /* if (Equals(log, Login1.Text) && Equals(pas, Password.Password))
            {
                MessageBox.Show(log);
            }
            else MessageBox.Show(log+pas);*/
            foreach(string str in loginList)
            {
                cos.Items.Add(str);
            }

            //    this.Hide();
            //MessageBox.Show("Zalogowano");
            //second sec = new second();
            //sec.ShowDialog();
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
