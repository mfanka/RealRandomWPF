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

namespace RealRandomWPF.PageRR
{
    /// <summary>
    /// Логика взаимодействия для ResultPage.xaml
    /// </summary>
    public partial class ResultPage : Page
    {
        
        
        public ResultPage()
        {
            InitializeComponent();
            BackButton.Visibility = Visibility.Hidden;
            LoadingImage.Visibility = Visibility.Hidden;
            num1.Visibility = Visibility.Hidden;
            num2.Visibility = Visibility.Hidden;
            RepeatButton.Visibility = Visibility.Hidden;
            ResultNumber.Visibility = Visibility.Hidden;
            ClassProgram program = new ClassProgram();
            ResultNumber.Text = program.OutPutOne().ToString();
            var timer1 = new DispatcherTimer { Interval = TimeSpan.FromSeconds(0.3) };
            timer1.Start();
            timer1.Tick += (sender, args) =>
            {
                timer1.Stop();
                num3.Visibility = Visibility.Hidden;
                num2.Visibility = Visibility.Visible;
                
                timer1.Start();
                timer1.Tick += (sender, args) =>
                {
                    timer1.Stop();
                    num2.Visibility = Visibility.Hidden;
                    num1.Visibility = Visibility.Visible;
                    timer1.Start();
                    timer1.Tick += (sender, args) =>
                    {
                        timer1.Stop();
                        num1.Visibility = Visibility.Hidden;
                        ResultNumber.Visibility = Visibility.Visible;
                        RepeatButton.Visibility = Visibility.Visible;
                        BackButton.Visibility = Visibility.Visible;
                    };
                };
            };
        }

        private void RepeatButton_Click(object sender, RoutedEventArgs e)
        {
            ResultNumber.Visibility = Visibility.Hidden;
            RepeatButton.Visibility = Visibility.Hidden;
            BackButton.Visibility = Visibility.Hidden;
            LoadingImage.Visibility = Visibility.Visible;
            var timer = new DispatcherTimer { Interval = TimeSpan.FromSeconds(1) };
            timer.Start();
            timer.Tick += (sender, args) =>
            {
                timer.Stop();
                LoadingImage.Visibility = Visibility.Hidden;
                ClassProgram program = new ClassProgram();
                ResultNumber.Text = program.OutPutOne().ToString();
                ResultNumber.Visibility = Visibility.Visible;
                RepeatButton.Visibility = Visibility.Visible;
                BackButton.Visibility = Visibility.Visible;
            };
        }

        private void BackButton_Click(object sender, RoutedEventArgs e)
        {
            this.NavigationService.GoBack();
        }
    }
}
