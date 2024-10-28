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
using System.Xml.Linq;

namespace Question2
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        private readonly Duongpv14PrnContext context = new Duongpv14PrnContext();
        public MainWindow()
        {
            InitializeComponent();
            txbId.IsEnabled = false;
            rdMale.IsChecked = true;
            LoadCombo();
            LoadData();
        }

        private void LoadCombo()
        {
            cbLec.ItemsSource = context.Lecturers.Select(x => x.FullName).Distinct().ToList();
        }

        private void LoadData()
        {
            listView.ItemsSource = context.Students.Select(s => new
            {
                StudentId = s.Id,
                FullName = s.FullName,
                Gender = s.Male == true? "Male": "Female",
                LecturerName = s.Lecture.FullName,
                Dob = s.Dob,
                Note = s.Note
            }).ToList();
        }

        private void listView_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            var student = listView.SelectedItem as dynamic;
            if (student != null)
            {
                txbId.Text = student.StudentId.ToString();
                txbName.Text = student.FullName;
                if (student.Gender == "Male")
                {
                    rdMale.IsChecked = true;
                } else if (student.Gender == "Female")
                {
                    rdFemale.IsChecked = true;
                }
                cbLec.Text = student.LecturerName;
                datePicker.Text = student.Dob.ToString();
                txbNote.Text = student.Note;
            }

        }

        private void btnRefresh_Click(object sender, RoutedEventArgs e)
        {
            txbId.Text = string.Empty;
            txbName.Text = string.Empty;
            rdMale.IsChecked = false;
            rdFemale.IsChecked = false;
            cbLec.Text = string.Empty;
            datePicker.Text = string.Empty;
            txbNote.Text = string.Empty;
        }

        private void btnAdd_Click(object sender, RoutedEventArgs e)
        {
            
        }

        private void btnEdit_Click(object sender, RoutedEventArgs e)
        {
            
        }

    }
}