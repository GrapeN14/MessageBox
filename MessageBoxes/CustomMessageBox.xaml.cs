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
using System.Windows.Media.Animation;
using System.Windows.Media.Imaging;
using System.Windows.Shapes;

namespace MessageBoxes
{
    /// <summary>
    /// Логика взаимодействия для CustomMessageBox.xaml
    /// </summary>
    public partial class CustomMessageBox : Window
    {
        public CustomMessageBox()
        {
            InitializeComponent();
        }
        
        private Random _random = new Random();
        private void Button_MouseEnter(object sender, MouseEventArgs e)
        {
            Button button = sender as Button;
            int newX = _random.Next(-400, 400); 
            int newY = _random.Next(-20, 20); 
            button.Margin = new Thickness(newX, newY, 0, 0); 
        }
        
        private void Close_Mess(object sender, RoutedEventArgs e)
        {
            Application.Current.Shutdown();
        }
    }
}
