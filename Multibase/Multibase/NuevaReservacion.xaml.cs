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
using System.Collections.ObjectModel;
using System.Runtime.InteropServices;

namespace Multibase
{
    /// <summary>
    /// Interaction logic for NuevaReservacion.xaml
    /// </summary>
    public partial class NuevaReservacion : Window
    {

        List<HabitacionHotel> disponibles = new List<HabitacionHotel>();
        List<HabitacionHotel> reservadas = new List<HabitacionHotel>();
        public ObservableCollection<HabitacionHotel> Hdisponibles{ get; set; }

        public NuevaReservacion()
        {
            InitializeComponent();

            HotelConnection con = new HotelConnection();
            disponibles = con.HabitacionesDisponibles();
            Hdisponibles = new ObservableCollection<HabitacionHotel>();
            foreach (HabitacionHotel h in disponibles) 
            {
                Hdisponibles.Add(h);
            }
            DataContext = this;
        
        }

        private void agregar_Click(object sender, RoutedEventArgs e)
        {
            HabitacionHotel h = (HabitacionHotel)habitaciones.SelectedItem;
            res.Items.Add(h);
        }
    }
}
