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

namespace RealRandomWPF.PageRR
{
    /// <summary>
    /// Логика взаимодействия для InputPage.xaml
    /// </summary>
    public partial class InputPage : Page
    {
        public InputPage()
        {
            InitializeComponent();
        }

        private void TextBox_PreviewTextInput(object sender, TextCompositionEventArgs e)
        {
            if (!Char.IsDigit(e.Text, 0))
            {
                e.Handled = true;
            }
        }
        private void NumberTwo_PreviewTextInput(object sender, TextCompositionEventArgs e)
        {
            if (!Char.IsDigit(e.Text, 0))
            {
                e.Handled = true;
            }

        }

        private void ActionButton_Click(object sender, RoutedEventArgs e)
        {
            BorderOne.BorderBrush = Brushes.Purple;
            BorderOne.BorderThickness = new Thickness(1);
            BorberTwo.BorderBrush = Brushes.Purple;
            BorberTwo.BorderThickness = new Thickness(1);
            ClassProgram program = new ClassProgram();
            if (NumberOne.Text == "" & NumberTwo.Text == "")
            {
                BorderOne.BorderBrush = Brushes.Red;
                BorderOne.BorderThickness = new Thickness(5);
                BorberTwo.BorderBrush = Brushes.Red;
                BorberTwo.BorderThickness = new Thickness(5);
                return;
            }
            if (NumberOne.Text == "")
            {
                BorderOne.BorderBrush = Brushes.Red;
                BorderOne.BorderThickness = new Thickness(5);
                return;
            }
            if (NumberTwo.Text == "")
            {
                BorberTwo.BorderBrush = Brushes.Red;
                BorberTwo.BorderThickness = new Thickness(5);
                return;
            }
            if (int.Parse(NumberOne.Text) >= int.Parse(NumberTwo.Text))
            {
                BorderOne.BorderBrush = Brushes.Red;
                BorderOne.BorderThickness = new Thickness(5);
                BorberTwo.BorderBrush = Brushes.Red;
                BorberTwo.BorderThickness = new Thickness(5);
                return;
            }

            else
            {
                program.InputOne(int.Parse(NumberOne.Text));
                program.InputTwo(int.Parse(NumberTwo.Text));
                ResultPage resultPage = new ResultPage();
                this.NavigationService.Navigate(resultPage);
            }
            
        }

        private void InfoButton_Click(object sender, RoutedEventArgs e)
        {
            Info info = new Info();
            info.Show();
        }
    }
}
