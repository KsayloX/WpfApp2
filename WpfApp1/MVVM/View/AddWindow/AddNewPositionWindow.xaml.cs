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
using System.Windows.Shapes;

namespace WpfApp1.MVVM.View.AddWindow
{
    public partial class AddNewPositionWindow : Window
    {
        public AddNewPositionWindow()
        {
            InitializeComponent();
        }

        private void BtnClose_Click(object sender, RoutedEventArgs e)
        {
            this.Close();
        }

        // Пример обработчика события TextComposition для ввода только цифр.
        // private void CheckingText(object sender, TextCompositionEventArgs e)
        // {
        //     Regex regex = new Regex("[^0-9]+");
        //     e.Handled = regex.IsMatch(e.Text);
        // }
    }
}
