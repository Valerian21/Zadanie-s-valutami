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

namespace Valutka
{
    /// <summary>
    /// Логика взаимодействия для MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }

        private void btnConvertCurrency_Click(object sender, RoutedEventArgs e)
        {
            Main main = new Main();
            string code = $"{cbCurrencyBegin.Text}_{cbCurrencyEnd.Text}";
            decimal resultConvert = Convert.ToDecimal(tbCurrencyBegin.Text) * main.DeserialDataCurrency(code);
            lblFinalRates.Content = $"{resultConvert}";
        }
    }
}
