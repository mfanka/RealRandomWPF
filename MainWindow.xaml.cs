using System.Text;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;
using System.Xml.Serialization;

namespace RealRandomWPF
{
	/// <summary>
	/// Interaction logic for MainWindow.xaml
	/// </summary>
	public partial class MainWindow : Window
	{
		public MainWindow()
		{
			
			InitializeComponent();

		}

		private void Button_Exit_Click(object sender, RoutedEventArgs e)
		{
			Application.Current.Shutdown();
		}

		

		private void Top_MouseLeftButtonDown(object sender, MouseButtonEventArgs e)
		{
			this.DragMove();
		}

		private void Button_Exit_MouseEnter(object sender, MouseEventArgs e)
		{
			Image_Exit.Visibility = Visibility.Hidden;
		}

		private void Button_Exit_MouseLeave(object sender, MouseEventArgs e)
		{
			Image_Exit.Visibility = Visibility.Visible;
		}
	}
}