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

namespace examBrusov
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

        int _Price;
        int _Weight;
        int _Itog;

        int _Vychet;
        int _ItogVychet;

        private void raschet_Click(object sender, RoutedEventArgs e)
        {

            _Price = Int32.Parse(_price.Text);
            _Weight = Int32.Parse(_weight.Text);

            _Itog = _Price * _Weight;
            _itog.Text = (_Itog).ToString();
        }

        private void _vychet_Click(object sender, RoutedEventArgs e)
        {
            _ItogVychet = Int32.Parse(_vychetSumm.Text);

            _itog.Text = ((_Weight - _ItogVychet) * _Price).ToString();
        }
    }
}
