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

namespace Multibase
{
    /// <summary>
    /// Interaction logic for Clientes.xaml
    /// </summary>
    public partial class Clientes : UserControl
    {
        public ObservableCollection<ClienteHotel> clientesHotelList { get; set; }
        public Clientes()
        {
            InitializeComponent();
            clientesHotelList = new ObservableCollection<ClienteHotel>();
            clientesHotelList.Add(new ClienteHotel("Pancho", "Pérez", "Pérez"));
            clientesHotelList.Add(new ClienteHotel("Karla", "López", "López"));
            DataContext = this;
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {

        }
    }
}
