using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Threading;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace WpfApp1
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
            time.Interval = new TimeSpan(0, 0, 3);
            time.Tick += Ontime;
            time.Start();
        }

        
        private void Ontime(object sender, EventArgs e)
        {
            Button but = new Button();
            but.Width = btn.Width;
            but.Height = btn.Height;
            but.Margin = new Thickness(ran.Next(670), ran.Next(380), 0, 0);
            SolidColorBrush b = new SolidColorBrush();
            b.Color = Color.FromRgb(Convert.ToByte(ran.Next(0, 255)), Convert.ToByte(ran.Next(0, 255)), Convert.ToByte(ran.Next(0, 255)));
            but.Background = b;
            but.Content = "ok";
            gri.Children.Add(but);
            but.MouseMove += btn_MouseMove;
        }

        private void btn_MouseMove(object sender, MouseEventArgs e)
        {
            SolidColorBrush a = new SolidColorBrush();
            a.Color = Color.FromRgb(Convert.ToByte(ran.Next(255)), Convert.ToByte(ran.Next(255)), Convert.ToByte(ran.Next(255)));
            Button btn = sender as Button;
            btn.Margin = new Thickness(ran.Next(670), ran.Next(370), 0, 0);
            btn.Background = a;
        }

        private void but_Click(object sender, RoutedEventArgs e)
        {
            Button but = sender as Button;
            but.Width = btn.Width;
            but.Height = btn.Height;
            but.Margin = new Thickness(ran.Next(670), ran.Next(380), 0, 0);
            SolidColorBrush b = new SolidColorBrush();
            b.Color = Color.FromRgb(Convert.ToByte(ran.Next(0, 255)), Convert.ToByte(ran.Next(0, 255)), Convert.ToByte(ran.Next(0, 255)));
            but.Background = b;
            but.Content = "click";
        }
    }
}
