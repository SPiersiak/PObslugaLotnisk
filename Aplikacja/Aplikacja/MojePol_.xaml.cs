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
    /// Logika interakcji dla klasy MojePol_.xaml
    /// </summary>
    public partial class MojePol_ : UserControl
    {
        public MojePol_()
        {
            InitializeComponent();
            Linia.Text = "LOT";


            List<Lista> data = new List<Lista>
            {
            new Lista {NrLot="FR2136", LotStart = "Rzeszów", LotDoc = "Warszawa", DataLot = "22-06-2019", GodzLot = "15:25", Sam = "1" },
            new Lista {NrLot="FR2136", LotStart = "Krakow", LotDoc = "Warszawa", DataLot = "22-06-2019", GodzLot = "12:25", Sam = "2" },
            new Lista {NrLot="FR2136", LotStart = "Krakow", LotDoc = "Warszawa", DataLot = "22-06-2019", GodzLot = "12:25", Sam = "3" },
            new Lista {NrLot="FR2136", LotStart = "Krakow", LotDoc = "Warszawa", DataLot = "22-06-2019", GodzLot = "12:25", Sam = "4" },
            new Lista {NrLot="FR2136", LotStart = "Krakow", LotDoc = "Warszawa", DataLot = "22-06-2019", GodzLot = "12:25", Sam = "5" },
            new Lista {NrLot="FR2136", LotStart = "Krakow", LotDoc = "Warszawa", DataLot = "22-06-2019", GodzLot = "12:25", Sam = "6" },
            new Lista {NrLot="FR2136", LotStart = "Świebodzin", LotDoc = "Warszawa", DataLot = "22-06-2019", GodzLot = "13:15",Sam = "7" }
            };
            int x = data.Count;
            for (int i = 0; i < x; i++)
            {
                Pol.Items.Add(data[i]);
            }
        }
    }

    public class Lista
    {
        public string NrLot { get; set; }
        public string LotStart { get; set; }
        public string LotDoc { get; set; }
        public string DataLot { get; set; }
        public string GodzLot { get; set; }
        public string Sam { get; set; }
    }
}