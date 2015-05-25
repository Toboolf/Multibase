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
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
            Clientes clienteObj = new Clientes();
            Cuentas cuentaObj = new Cuentas();
            Habitacion habitacionObj = new Habitacion();
            Habitacion habitacionObj2 = new Habitacion();
            Reservacion reservacionObj = new Reservacion();
            Usuarios usuarioObj = new Usuarios();

            stackClient.Children.Add(clienteObj);
            stackCuentas.Children.Add(cuentaObj);
            stackHab.Children.Add(habitacionObj);
            //stackHab.Children.Add(habitacionObj2);
            stackRes.Children.Add(reservacionObj);
            stackUser.Children.Add(usuarioObj);
        }

        private void TabControl_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {

           

        }
    }
}
