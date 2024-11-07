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

namespace Interfaces_Nomina
{
    /// <summary>
    /// Lógica de interacción para MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }

        private void BtnClick_Click(object sender, RoutedEventArgs e)
        {
            Planilla _planilla = new Planilla();
            _planilla.ShowDialog();
        }

        private void BtnNominaM_Click(object sender, RoutedEventArgs e)
        {
            NominaMensual _NominaMensual = new NominaMensual();
            _NominaMensual.ShowDialog();
        }

        private void BtnAgregarDeducciones_Ingresos_Click(object sender, RoutedEventArgs e)
        {
         DeduccionesE_Ingresos _deduccionesE_Ingresos = new DeduccionesE_Ingresos();
            _deduccionesE_Ingresos.ShowDialog();

        }

        private void BtnCrearDeduccionesEingresos_Click(object sender, RoutedEventArgs e)
        {
            CrearIngreso_Deduccion _crearIngreso_Deduccion = new CrearIngreso_Deduccion();
            _crearIngreso_Deduccion.ShowDialog();
        }
    }
}
