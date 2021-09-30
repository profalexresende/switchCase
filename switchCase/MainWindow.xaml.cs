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

namespace switchCase
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }

        private void btnVerificar_Click(object sender, RoutedEventArgs e)
        {
            int codigo;
            string tipoElogio;

            codigo = Convert.ToInt32(txtCodigo.Text);

            switch (codigo)
            {
                case 1:
                    tipoElogio = "Elogio Profissional";
                    break;
                case 2:
                    tipoElogio = "Elogio Físico";
                    break;
                case 3:
                    tipoElogio = "Elogio Pessoal";
                    break;
                default:
                    tipoElogio = "Código inválido";
                    break;
            }
            MessageBox.Show(tipoElogio, "Elogio", MessageBoxButton.OK, MessageBoxImage.Information);
        }
    }
}
