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

namespace UltraIdo
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

        private void buttonSzamol_Click(object sender, RoutedEventArgs e)
        {
            var ido= textboxIdo.Text.Split(':');
            double ora = Convert.ToDouble(ido[0]);
            double perc = Convert.ToDouble(ido[1]);
            double masodperc = Convert.ToDouble(ido[2]);

            textblockOra.Text = $"{((ora * 3600) + (perc * 60) + masodperc) / 3600:0.00}.óra";


        }
    }
}
