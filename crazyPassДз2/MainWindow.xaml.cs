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
using System.Windows.Threading;

namespace crazyPass
{
    /// <summary>
    /// Логика взаимодействия для MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        Random ran = new Random();
        DispatcherTimer time = new DispatcherTimer();

        public MainWindow()
        {
            InitializeComponent();
            time.Interval = new TimeSpan(0, 0, 5);
            time.Tick += Ontime;
            time.Start();
            foreach (UIElement elem in gri.Children)
            {
                if (elem is Button)
                {
                    ((Button)elem).Click += Button_Click;
                }
            }
            txt.TextChanged += Text_Changes;
        }

        private void Text_Changes(object sender, TextChangedEventArgs e)
        {
            if (txt.Text.Length == 5)
            {
                txt.Background = new SolidColorBrush(Color.FromRgb(1, 255, 1));
                txt.Text = "Успешно!";
            }
        }

        private void Ontime(object sender, EventArgs e)
        {
            for (int i = 0; i < gri.Children.Count - 1; i++)
            {
                if ((gri.Children[i] is Button) & (gri.Children[i + 1] is Button))
                {
                    var margin = ((Button)gri.Children[i]).Margin;
                    ((Button)gri.Children[i]).Margin = ((Button)gri.Children[i + 1]).Margin;
                    ((Button)gri.Children[i + 1]).Margin = margin;
                    SolidColorBrush color = new SolidColorBrush();
                    color.Color = Color.FromRgb(Convert.ToByte(ran.Next(0, 255)), Convert.ToByte(ran.Next(0, 255)), Convert.ToByte(ran.Next(0, 255)));
                    ((Button)gri.Children[i]).Background = color;
                    SolidColorBrush ab = new SolidColorBrush();
                    ab.Color = Color.FromRgb(Convert.ToByte(ran.Next(1, 255)), Convert.ToByte(ran.Next(1, 255)), Convert.ToByte(ran.Next(1, 255)));
                    b0.Background = ab;
                }
            }
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            if ((string)((Button)sender).Content == "x")
            {
                foreach (UIElement elem in gri.Children)
                {
                    if (elem is Button)
                        ((Button)elem).Content = "";
                }
            }
            else
            {
                for (int i = 0; i < gri.Children.Count - 1; i++)
                {
                    if ((gri.Children[i] == (Button)sender) & (gri.Children[i + 1] is Button))
                    {
                        var mar = ((Button)gri.Children[i]).Margin;
                        ((Button)gri.Children[i]).Margin = ((Button)gri.Children[i + 1]).Margin;
                        ((Button)gri.Children[i + 1]).Margin = mar;
                        if (txt.Text.Length < 5)
                        {
                            txt.Text += ((Button)gri.Children[i + 1]).Content;
                            txt.Margin = new Thickness(ran.Next(500), ran.Next(270), 0, 0);
                        }
                        break;
                    }
                }
            }
        }
    }
}
