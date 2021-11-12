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

namespace HomeWork4WpfApp
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

        private void Button_Click(object sender, RoutedEventArgs e)
        {  resSum.Text = MethodConvertor(rate.Text, sum.Text); }

        public static string MethodConvertor ( string rate, string sum )
        {
            double rateDouble = Convert.ToDouble(rate);
            double sumDouble = Convert.ToDouble(sum);
            double resDouble = rateDouble * sumDouble;
            string res = resDouble.ToString();
            return res;
        }

        private void Button_Click_1(object sender, RoutedEventArgs e)
        {
            resSum1.Text = MethodConvertor(rate1.Text, sum1.Text);
        }

        private void Button_Click_2(object sender, RoutedEventArgs e)
        {
            resSum2.Text = MethodConvertor(rate2.Text, sum2.Text);
        }

        private void Button_Click_3(object sender, RoutedEventArgs e)
        {
            resSum3.Text = MethodConvertor(rate3.Text, sum3.Text);
        }

        private void Button_Click_4(object sender, RoutedEventArgs e)
        {
            string rate00 = "0,025";
            resSum00.Text = MethodConvertor(rate00, sum00.Text);
        }

        private void Button_Click_5(object sender, RoutedEventArgs e)
        {
            string rate01 = "0,3";
            resSum01.Text = MethodConvertor(rate01, sum01.Text);
        }

        private void Button_Click_6(object sender, RoutedEventArgs e)
        {
            string rate02 = "1609,34";
            resSum02.Text = MethodConvertor(rate02, sum02.Text);
        }

        private void Button_Click_7(object sender, RoutedEventArgs e)
        {
            string rate03 = "1066,8";
            resSum03.Text = MethodConvertor(rate03, sum03.Text);
        }
    }
}
