using Question2.Models;
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

namespace Question2
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        private readonly PePrn221Trial3Context context = new PePrn221Trial3Context();
        public MainWindow()
        {
            InitializeComponent();
            rdMale.IsChecked = true;
            LoadCombo();
        }

        private void LoadCombo()
        {
            var listNation = new List<string>()
            {
                "USA", "UK", "Japan", "Chinese"
            };

            cbNation.ItemsSource = listNation;
        }

        private void btnImport_Click(object sender, RoutedEventArgs e)
        {

        }
    }
}