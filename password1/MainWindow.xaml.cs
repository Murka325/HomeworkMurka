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

namespace password1
{
    /// <summary>
    /// Логика взаимодействия для MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
            foreach (UIElement element in gri.Children)
            {
                if (element is Button)
                {
                    ((Button)element).Click += Button_Click;
                }
            }
            pass.PasswordChanged += PasswordChangedGandlerAsync;
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            if (pass.Password.Length < 4)
                pass.Password += (string)((Button)sender).Content;
        }

        private async void PasswordChangedGandlerAsync(object sender, RoutedEventArgs e)
        {
            if (pass.Password.Length >= 4)
            {
                if (pass.Password == "3255")
                {
                    pass.Password = "";
                    pass.Visibility = Visibility.Hidden;
                    txt.Background = new SolidColorBrush(Color.FromRgb(7, 251, 31));
                    txt.Visibility = Visibility;
                    txt.Text = "Успешно!";
                    await Task.Delay(1500);
                    gri.Children.Remove(txt);
                    gri.Children.Remove(pass);
                }
                else
                {
                    pass.Password = "";
                    pass.Visibility = Visibility.Hidden;
                    txt.Background = new SolidColorBrush(Color.FromRgb(255, 1, 1));
                    txt.Visibility = Visibility;
                    txt.Text = "Неправильно!?";
                    await Task.Delay(1500);
                    pass.Visibility = Visibility.Visible;
                    txt.Visibility = Visibility.Hidden;
                }
            }
        }
    }
}
