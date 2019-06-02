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

            
            List<string> loginList = new List<string>();
            using (var db = new LogRegEntities())
            {
                var query = @"SELECT * from LogReg WHERE username='" + this.Login1.Text + "' and password='" + this.Password.Password + "' ";
                string[] result = db.Database.ExecuteSqlCommand(query);
                //loginList = (from g in db.LogRegs select g.Id + g.username + g.password + g.specification).ToList();
                db.Dispose();
                
            }
            using (var db1 = new DateContext())
            {
                using (var command = db1.Database.GetDbConnection().CreateCommand())
                {

                }
            }
            

           /* if (Equals(log, Login1.Text) && Equals(pas, Password.Password))
            {
                MessageBox.Show(log);
            }
            else MessageBox.Show(log+pas);*/

            this.Hide();
            MessageBox.Show("Zalogowano");
            Lotnisko sec = new Lotnisko();
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
