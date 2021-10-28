using System.IO;
using System.Windows;
using Microsoft.Win32;

namespace Uppgift5
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

        private void ClickÖppnaDialogruta(object sender, RoutedEventArgs e)
		{
			OpenFileDialog openFileDialog = new OpenFileDialog();
			if(openFileDialog.ShowDialog() == true)
				resultatRuta.Text = File.ReadAllText(openFileDialog.FileName);
		}
    }
}
