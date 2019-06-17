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
using System.Data.SQLite;


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


        string dbcon = @"Data Source = C:\Users\piers\Documents\GitHub\Aplikacja\LogReg.db;Version=3";

        public void Login_Click1(object sender, RoutedEventArgs e)
        {
            SQLiteConnection sqlcon = new SQLiteConnection(dbcon);
            if (((Login1.Text == "") && (Password.Password == "")) || (Login1.Text == "") || (Password.Password == ""))
            {
                MessageBox.Show("Empty login or password");
            }
            else
            {
                try
                {
                    sqlcon.Open();
                    string query = "SELECT * FROM Log WHERE username = '" + Login1.Text + "'AND password= '" + Password.Password + "' ";
                    SQLiteCommand com = new SQLiteCommand(query, sqlcon);
                    com.ExecuteNonQuery();
                    SQLiteDataReader dr = com.ExecuteReader();
                    int count = 0;
                    string id = "";
                    string typ = "";
                    while (dr.Read())
                    {
                        count++;
                        id = dr["Id"].ToString();
                        typ = dr["specification"].ToString();
                    }
                    
                    if(count == 1)
                    {
                     
                        switch (Convert.ToInt32(typ))
                        {
                            case 0:
                                this.Hide();
                                MessageBox.Show("Zalogowano");
                                Pasazer pas = new Pasazer(id,typ);
                                pas.ShowDialog();
                                break;
                            case 1:
                                this.Hide();
                                MessageBox.Show("Zalogowano");
                                Przewoznik prz = new Przewoznik(id, typ);
                                prz.ShowDialog();
                                break;
                            case 2:
                                this.Hide();
                                MessageBox.Show("Zalogowano");
                                Lotnisko lot = new Lotnisko(id, typ);
                                lot.ShowDialog();
                                break;
                        }
                    }

                    if(count < 1)
                    {
                       
                        MessageBox.Show("Wrong login or pasword");
                        Login1.Clear();
                        Password.Clear();
                    }
                    sqlcon.Close();
                }
                catch(Exception)
                {
                    MessageBox.Show("Error");
                }
                
            }

            
            /*List<string> loginList = new List<string>();
            using (var db = new LogRegEntities())
            {
                var query = @"SELECT Id from LogReg WHERE username='" + this.Login1.Text + "' and password='" + this.Password.Password + "' ";
                int[] result = db.Database.ExecuteSqlCommand(query);
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


            //    this.Hide();
            //MessageBox.Show("Zalogowano");
            //second sec = new second();
            //sec.ShowDialog();*/

            /*this.Hide();
            
            Lotnisko sec = new Lotnisko();
            sec.ShowDialog();*/
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
