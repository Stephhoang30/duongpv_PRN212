using PE02.Models;
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

namespace PE02
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {

        private readonly Prn221Trial2Context context = new Prn221Trial2Context();

        public MainWindow()
        {
            InitializeComponent();
            LoadComboBox();
            LoadData();
        }

        private void LoadData()
        {
            listView.ItemsSource = context.Employees.Select(c => new
            {
                EmployeeID = c.EmployeeId,
                FirstName = c.FirstName,
                LastName = c.LastName,
                Department = c.Department.DepartmentName,
                Title = c.Title,
                TitleOfCourtesy = c.TitleOfCourtesy,
                Birthdate = c.BirthDate
            }).ToList();
        }

        private void LoadComboBox()
        {
            // load Department
            var listDepartment = context.Departments.Select(d => d.DepartmentName).ToList();
            cbDepartment.ItemsSource = listDepartment;
            cbDepartment.SelectedIndex = 0;

            // load TitleOfCourtesy
            var listTitle = new List<string>()
            {
                "Dr.", "Ms.", "Mrs.", "Mr."
            };
            cbTitleOfCourtesy.ItemsSource = listTitle;
            cbTitleOfCourtesy.SelectedIndex = 0;
        }

        public void listView_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            var selectedEmployee = listView.SelectedItem as dynamic;
            if (selectedEmployee != null)
            {              
                eid.Text = selectedEmployee.EmployeeID.ToString();
                firstname.Text = selectedEmployee.FirstName.ToString();
                lastname.Text = selectedEmployee.LastName.ToString();   
                cbDepartment.Text = selectedEmployee.Department.ToString();
                title.Text = selectedEmployee.Title.ToString();
                cbTitleOfCourtesy.Text = selectedEmployee.TitleOfCourtesy.ToString();
                dob.Text = selectedEmployee.Birthdate.ToString();
            }
        }

        private void bRefresh_Click(object sender, RoutedEventArgs e)
        {
            // Clear all input fields
            eid.Clear();
            firstname.Clear();
            lastname.Clear();
            cbDepartment.SelectedIndex = 0;
            title.Clear();
            cbTitleOfCourtesy.SelectedIndex = 0;
            dob.SelectedDate = null;

            // Reload data in the list view
            LoadData();
        }

        private void bAdd_Click(object sender, RoutedEventArgs e)
        {

        }

        private void bEdit_Click(object sender, RoutedEventArgs e)
        {

        }
    }
}