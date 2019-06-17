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
    /// Logika interakcji dla klasy Rezerwacje.xaml
    /// </summary>
    public partial class Rezerwacje_ : UserControl
    {
        string dbcon = @"Data Source = C:\Users\piers\Documents\GitHub\Aplikacja\LogReg.db;Version=3";
        string x;
        public Rezerwacje_()
        {
            InitializeComponent();


            List<Row> data = new List<Row>
            {
            new Row { LotStart = "Rzeszów", LotDoc = "Warszawa", DataLot = "22-06-2019", LinLot = "LOT", NumMiej = "15" },
            new Row { LotStart = "Krakow", LotDoc = "Warszawa", DataLot = "22-06-2019", LinLot = "LOT", NumMiej = "15" },
            new Row { LotStart = "Krakow", LotDoc = "Warszawa", DataLot = "22-06-2019", LinLot = "LOT", NumMiej = "15" },
            new Row { LotStart = "Krakow", LotDoc = "Warszawa", DataLot = "22-06-2019", LinLot = "LOT", NumMiej = "15" },
            new Row { LotStart = "Krakow", LotDoc = "Warszawa", DataLot = "22-06-2019", LinLot = "LOT", NumMiej = "15" },
            new Row { LotStart = "Krakow", LotDoc = "Warszawa", DataLot = "22-06-2019", LinLot = "LOT", NumMiej = "15" },
            new Row { LotStart = "Świebodzin", LotDoc = "Warszawa", DataLot = "22-06-2019", LinLot = "LOT", NumMiej = "15" }
            };
            int x = data.Count;
            for (int i = 0; i < x; i++)
            {
                Rezw.Items.Add(data[i]);
            }
        }
        public Rezerwacje_(string id) : this()
        {
            x = id;
            string N = "Nie podano";
            string LN = "Nie podano";
            SQLiteConnection sqlcon = new SQLiteConnection(dbcon);
            sqlcon.Open();
            string query = "SELECT * FROM zar_uzyt WHERE Id_user = '" + x + "'";
            SQLiteCommand com = new SQLiteCommand(query, sqlcon);
            com.ExecuteNonQuery();
            SQLiteDataReader dr = com.ExecuteReader();
            int count = 0;
            while (dr.Read())
            {
                count++;
                N = dr["Name"].ToString();
                LN = dr["LastName"].ToString();
            }
            if (count == 1)
            {
                name.Text = N;
                sname.Text = LN;
            }
            else
            {
                name.Text = N;
                sname.Text = LN;
            }
            sqlcon.Close();
        }
    }
    

    public class Row
    {
        public string LotStart { get; set; }
        public string LotDoc { get; set; }
        public string DataLot { get; set; }
        public string LinLot { get; set; }
        public string NumMiej { get; set; }
    }
}
