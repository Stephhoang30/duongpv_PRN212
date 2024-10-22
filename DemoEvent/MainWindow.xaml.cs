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

namespace DemoEvent
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        List<Student> lstStudents = new List<Student>()
        {
            new Student(1, "a", new DateTime(2001,1,1)),
            new Student(2, "b", new DateTime(2002,2,1)),
            new Student(3, "c", new DateTime(2003,3,1)),
            new Student(4, "d", new DateTime(2004,4,1))
        };

        List<String> lstClass = new List<String>() 
        {
            "SE1861", "SE1863", "SE1864"
        };
        public MainWindow()
        {
            InitializeComponent();
            LoadStudent();
            LoadClass();
        }

        private void LoadClass()
        {
            cbClass.ItemsSource = lstClass;
            cbClass.SelectedIndex = 0;
        }

        public void LoadStudent()
        {
            dgStudent.ItemsSource = lstStudents;
        }

        private void btnAdd_Click(object sender, RoutedEventArgs e)
        {
            string name = txbName.Text;
            string dob = datePicker.Text;

            MessageBox.Show($"Name: {name} - DOB: {dob}");
        }
    }
}