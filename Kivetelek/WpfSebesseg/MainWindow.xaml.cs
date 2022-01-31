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

namespace WpfSebesseg
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

        private void buttonSzamolas_Click(object sender, RoutedEventArgs e)
        {
            try
            {
                var sebessegKmh = Convert.ToDouble(textboxKmh.Text);
                var sebessegMsec = sebessegKmh / 3.6;
                textblockMs.Text = $"{sebessegMsec:0.00} méter";
            }
            catch (Exception ex)
            {
                MessageBox.Show("Számot kell megadni!","Hiba!",MessageBoxButton.OK,MessageBoxImage.Error);                
            }
        }
    }
}
