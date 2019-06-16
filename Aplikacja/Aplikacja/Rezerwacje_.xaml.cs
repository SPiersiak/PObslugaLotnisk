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
    /// Logika interakcji dla klasy Rezerwacje.xaml
    /// </summary>
    public partial class Rezerwacje_ : UserControl
    {
        public Rezerwacje_()
        {
            InitializeComponent();
            name.Text = "Jan";
            sname.Text = "Niezbędny";


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
