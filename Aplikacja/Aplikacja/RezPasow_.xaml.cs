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
    /// Logika interakcji dla klasy RezPasow_.xaml
    /// </summary>
    public partial class RezPasow_ : UserControl
    {
        public RezPasow_()
        {
            InitializeComponent();
            Lot.Text = "Rzesow-Jasionka Airport";


            List<Pasy> data = new List<Pasy>
            {
            new Pasy {NrPas="1", NrLot="LO 3805", LinLot = "LOT", DataLot = "22-06-2019", GodzLot="12:55", Sam="Airbus A380" },
            new Pasy {NrPas="2", NrLot="LO 3805", LinLot = "LOT", DataLot = "22-06-2019", GodzLot="12:55", Sam="Airbus A380" },
            new Pasy {NrPas="3", NrLot="LO 3805", LinLot = "LOT", DataLot = "22-06-2019", GodzLot="12:55", Sam="Airbus A380" },
            new Pasy {NrPas="4", NrLot="LO 3805", LinLot = "LOT", DataLot = "22-06-2019", GodzLot="12:55", Sam="Airbus A380" },
            new Pasy {NrPas="5", NrLot="LO 3805", LinLot = "LOT", DataLot = "22-06-2019", GodzLot="12:55", Sam="Airbus A380" },
            new Pasy {NrPas="6", NrLot="LO 3805", LinLot = "LOT", DataLot = "22-06-2019", GodzLot="12:55", Sam="Airbus A380" },
            new Pasy {NrPas="7", NrLot="LO 3805", LinLot = "LOT", DataLot = "22-06-2019", GodzLot="12:55", Sam="Airbus A380" },
            
            };
            int x = data.Count;
            for (int i = 0; i < x; i++)
            {
                Pas.Items.Add(data[i]);
            }
        }
    }

    public class Pasy
    {
        public string NrPas { get; set; }
        public string NrLot { get; set; }
        public string LinLot { get; set; }
        public string DataLot { get; set; }
        public string GodzLot { get; set; }
        public string Sam { get; set; }
    }
}
