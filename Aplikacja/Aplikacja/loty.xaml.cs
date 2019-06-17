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
using System.Data.Entity;
using System.Data.SQLite;

namespace Aplikacja
{
    /// <summary>
    /// Logika interakcji dla klasy loty.xaml
    /// </summary>
    public partial class loty : Window
    {
        string dbcon = @"Data Source = C:\Users\piers\Documents\GitHub\Aplikacja\LogReg.db;Version=3";
        public loty()
        {
            InitializeComponent();
            List<string> lista = new List<string>();
            using (var db = new LogRegEntities())
            {
                lista = (from g in db.przewozniks select g.Z + g.DO + g.Cz_trwania + g.K_kl_pierwszej + g.K_kl_biznesowej + g.K_kl_ekonomicznej + g.K_bag_do25 + g.K_bag_pow25 + g.Cz_trwania + g.Przesiadki ).ToList();
            }
            foreach (string str in lista)
            {
                listalotow.Items.Add(str[1]);
            }
        }

        private void Listalotow_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {

        }
    }
}
