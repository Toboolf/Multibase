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

namespace Multibase
{
    /// <summary>
    /// Interaction logic for AgregarCliente.xaml
    /// </summary>
    public partial class AgregarCliente : Window
    {
        public AgregarCliente()
        {
            InitializeComponent();
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            ClienteHotel cliente = new ClienteHotel();
            cliente.nombre = nombre.Text;
            cliente.apPat = apaterno.Text;
            cliente.apMat = amaterno.Text;
            HotelConnection con = new HotelConnection();
            con.AgregaCliente(cliente);
            MessageBox.Show("Cliente agregado correctamente! (:");

            NuevaReservacion window = new NuevaReservacion();
            window.nombre.Text = cliente.nombre;
            window.apaterno.Text = cliente.apPat;
            window.amaterno.Text = cliente.apMat;
            window.Show();
            this.Close();

        }

        
    }
}
