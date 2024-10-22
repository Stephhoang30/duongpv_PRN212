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
        private readonly PePrn24sumB1Context context = new PePrn24sumB1Context();
        public MainWindow()
        {
            InitializeComponent();
            LoadCombo();
            LoadData();  
        }

        private void LoadCombo()
        {
            cbCate.ItemsSource = context.CourseCategories.Select(x => x.CategoryName).ToList();
            cbCate.SelectedIndex = 0;

            cbIns.ItemsSource = context.Instructors.Select(ins => ins.Name).Distinct().ToList();
            cbIns.SelectedIndex = 0;
        }

        private void LoadData()
        {
            var firstCate = cbCate.Text;

            var firstCateObj = context.CourseCategories.FirstOrDefault(cate => cate.CategoryName.Equals(firstCate));

            var listData = context.Courses
                .Where(c => c.Categories.Contains(firstCateObj))
                .Select(c => new
            {
                CourseId = c.CourseId,
                Title = c.Title,
                Description = c.Description,
                InstructorId = c.InstructorId,
                InstructorName = c.Instructor.Name
            }
                ).ToList();

            dataGrid.ItemsSource = listData;
        }

        private void btnEdit_Click(object sender, RoutedEventArgs e)
        {
            var courseId = int.Parse(cID.Text);
            var courseUpdate = context.Courses.FirstOrDefault(c => c.CourseId == courseId);
            if (courseUpdate != null)
            {
                courseUpdate.Title = cTitle.Text;
                courseUpdate.Description = cDes.Text;
                courseUpdate.Instructor = context.Instructors.FirstOrDefault(i => i.Name == cbIns.Text);
            }
            context.SaveChanges();
            LoadData();
        }

        private void dataGrid_SelectionChanged(object sender,SelectionChangedEventArgs e)
        {
            var selected = dataGrid.SelectedItem as dynamic;

            if (selected != null)
            {
                cID.Text = selected.CourseId.ToString();
                cTitle.Text = selected.Title;
                cDes.Text = selected.Description;
                cbIns.Text = selected.InstructorName.ToString();
            }
        }

        private void cbCate_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            // using SelectedItem to get Text Combobox
            var cate = cbCate.SelectedItem;

            var cateObj = context.CourseCategories.FirstOrDefault(c => c.CategoryName.Equals(cate));

            var listData = context.Courses
                .Where(c => c.Categories.Contains(cateObj))
                .Select(c => new
                {
                    CourseId = c.CourseId,
                    Title = c.Title,
                    Description = c.Description,
                    InstructorId = c.InstructorId,
                    InstructorName = c.Instructor.Name
                }
                ).ToList();
            dataGrid.ItemsSource = listData;
        }
    }
}