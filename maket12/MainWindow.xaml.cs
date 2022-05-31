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

namespace maket12
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

        private void Button_Click_1(object sender, RoutedEventArgs e)
        {
            MessageBox.Show("Стаья 1\n Статья 2\n");
        }

        private void Button_Click_2(object sender, RoutedEventArgs e)
        {
            MessageBox.Show("Самая лучшая аптека");
        }

        private void Button_Click_3(object sender, RoutedEventArgs e)
        {
            MessageBox.Show("Улица Б красная 18 к306");
        }

        private void RadioButton_Checked(object sender, RoutedEventArgs e)
        {
            grid1.Background = new SolidColorBrush(System.Windows.Media.Color.FromRgb(238, 238, 238));
        }

        private void RadioButton_Checked_1(object sender, RoutedEventArgs e)
        {
            LinearGradientBrush myVerticalGradient =
    new LinearGradientBrush();
            myVerticalGradient.StartPoint = new Point(0.5, 0);
            myVerticalGradient.EndPoint = new Point(0.5, 1);
            myVerticalGradient.GradientStops.Add(
                new GradientStop(Colors.Red, 0.0));
            myVerticalGradient.GradientStops.Add(
                new GradientStop(Colors.Orange, 0.20));
            myVerticalGradient.GradientStops.Add(
                new GradientStop(Colors.Yellow, 0.40));
            myVerticalGradient.GradientStops.Add(
                new GradientStop(Colors.LimeGreen, 0.60));
            myVerticalGradient.GradientStops.Add(
                new GradientStop(Colors.DeepSkyBlue, 0.80));
            myVerticalGradient.GradientStops.Add(
               new GradientStop(Colors.Purple, 1));
            grid1.Background = myVerticalGradient;
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            MessageBox.Show("Наш магазин имеет все мединцинские товары, выпускаемые не по рецепту");
        }
    }
}
