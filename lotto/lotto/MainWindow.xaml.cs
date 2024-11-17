using System.Security.Cryptography;
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

namespace lotto
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

        private void startButton_Click(object sender, RoutedEventArgs e)
        {
           StringBuilder sb = new StringBuilder();
           Random numberGen = new Random();

            for (int i = 1; i < 7; i++)
            {
                int randomNr = numberGen.Next(1, 46);
                string result = $"Getal{i}: {randomNr}";
                sb.AppendLine(result);

            }
            resultTextBlock.Text = sb.ToString();
            
        }

        private void eraseButton_Click(object sender, RoutedEventArgs e)
        {
            resultTextBlock.Text =  string.Empty;
        }

        private void closeButton_Click(object sender, RoutedEventArgs e)
        {
            Close();
        }
    }
}