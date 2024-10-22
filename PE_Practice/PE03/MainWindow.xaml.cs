using Microsoft.IdentityModel.Tokens;
using PE03.Models;
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

namespace PE03
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        private readonly Prn221TrialContext context = new Prn221TrialContext();
        public MainWindow()
        {
            InitializeComponent();
            LoadData();
        }

        private void LoadData()
        {
            var listData = context.Employees.ToList();
            listView.ItemsSource = listData;     
        }

        private void listView_Click(object sender, RoutedEventArgs e)
        {
            var item = (sender as ListView).SelectedItem;
            if (item != null)
            {
                var gender = ((Employee)item).Gender;
                if (!string.IsNullOrEmpty(gender))
                {
                    if(gender.ToLower() == "female")
                    {
                        female.IsChecked = true;
                    } else
                    {
                        male.IsChecked = true;   
                    }
                }
            }
        }

    }
}    