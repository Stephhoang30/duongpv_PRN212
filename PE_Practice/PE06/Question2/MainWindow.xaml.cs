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
        private readonly PePrn21224sumB5Context context = new PePrn21224sumB5Context();
        public MainWindow()
        {
            InitializeComponent();
            LoadCombo();
            LoadData();
        }

        private void LoadCombo()
        {
            cbPos.ItemsSource = context.Employees.Select(x => x.Position).Distinct().ToList();
            cbPos.SelectedIndex = 0;
        }

        private void LoadData()
        {
            dataGrid.ItemsSource = context.Employees.Select(e => new
            {
                ID = e.Id,
                Name = e.Name,
                Sex = e.Sex,
                DOB = e.Dob,
                Position = e.Position
            }).ToList();

        }
        private void dataGrid_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            var selectedEmployee = dataGrid.SelectedItem as dynamic;

            if (selectedEmployee != null)
            {
                tbID.Text = selectedEmployee.ID.ToString();
                tbName.Text = selectedEmployee.Name;
                if (selectedEmployee.Sex == "Male")
                {
                    male.IsChecked = true;
                }
                else if (selectedEmployee.Sex == "Female")
                {

                    female.IsChecked = true;
                }

                DOB.SelectedDate = selectedEmployee.DOB.ToDateTime(new TimeOnly());

                cbPos.SelectedItem = selectedEmployee.Position;
            }
        }


        private void btnRefresh_Click(object sender, RoutedEventArgs e)
        {
            LoadData();
        }

        private void btnAdd_Click(object sender, RoutedEventArgs e)
        {
            var newEmployee = new Employee
            {
                Name = tbName.Text,
                Dob = DateOnly.FromDateTime(DOB.SelectedDate.Value),
                Sex = male.IsChecked == true ? "Male" : "Female",
                Position = cbPos.SelectedItem.ToString()
            };

            context.Employees.Add(newEmployee);
            context.SaveChanges();
            LoadData();
        }

        private void btnEdit_Click(object sender, RoutedEventArgs e)
        {
            var id = int.Parse(tbID.Text);

            var employeeUpdate = context.Employees.FirstOrDefault(e => e.Id == id);

            if (employeeUpdate != null)
            {
                employeeUpdate.Name = tbName.Text;
                employeeUpdate.Sex = male.IsChecked == true ? "Male" : "Female";
                employeeUpdate.Dob = DateOnly.FromDateTime(DOB.SelectedDate.Value);
                employeeUpdate.Position = cbPos.SelectedItem.ToString();
            }
            context.SaveChanges();
            LoadData();
        }
    }
}