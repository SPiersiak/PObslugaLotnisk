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
        string x;
        string y;
        public Register()
        {
            InitializeComponent();
        }
        public Register(string id, string typ):this()
        {
            x = id;
            y = typ;
        }




        private void Register_Click(object sender, RoutedEventArgs e)
        {   
           using (var db = new LogRegEntities())
            {
                int g = usrtype.SelectedIndex;
                /*LogReg newItem = new LogReg
                {
                    Id = db.LogRegs.Count() + 1,
                    username = LoginBox.Text,
                    password = Password.Password,
                    specification = g,
                };
                db.LogRegs.Add(newItem);
                db.SaveChanges();
                db.Dispose();
                */
            }

            //this.Hide();
            //Pasazer pas = new Pasazer();
            //pas.ShowDialog();
            //this.Hide();

            //this.Hide();
            //Przewoznik prz = new Przewoznik();
            //prz.ShowDialog();

            this.Hide();
            Lotnisko lot = new Lotnisko();
            lot.ShowDialog();
            



        }

        

        private void ButtonFechar_Click(object sender, RoutedEventArgs e)
        {
            Application.Current.Shutdown();
        }

        private void Grid_MouseDown(object sender, MouseButtonEventArgs e)
        {
            DragMove();
        }
    }
}
