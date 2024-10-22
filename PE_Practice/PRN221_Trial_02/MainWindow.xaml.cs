using PRN221_Trial_02.Models;
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

namespace PRN221_Trial_02
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        private readonly Prn221Trial2Context _context;
        public MainWindow(Prn221Trial2Context context)
        {
            InitializeComponent();
            _context = context;
            HandleBeforeLoaded();
        }

        public void UpdateListView()
        {
             listView.ItemsSource = _context.Employees.ToList(); 
        }
        private void HandleBeforeLoaded()
        {
             UpdateListView();  
        }

        private void bRefresh_Click(object sender, RoutedEventArgs e)
        {
        }

        private void bAdd_Click(object sender, RoutedEventArgs e)
        {
        }

        private void bEdit_Click(object sender, RoutedEventArgs e)
        {
        }
    }
}