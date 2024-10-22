using Microsoft.Win32;
using System.Collections.ObjectModel;
using System.IO;
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

namespace Q1
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        // kieu ObservableCollection
        ObservableCollection<Star> listStars = new ObservableCollection<Star>();
        public MainWindow()
        {
            InitializeComponent();
            LoadCombo();
            rdFemale.IsChecked = true;
        }

        private void LoadCombo()
        {
            var listNation = new List<string>()
            {
                "USA", "VietNam", "UK"
            };

            cbNation.ItemsSource = listNation;
            cbNation.SelectedIndex = 0;
        }

        private void btnAdd_Click(object sender, RoutedEventArgs e)
        {
            Star sAdd = new Star();

            sAdd.Name = txbStarName.Text;
            sAdd.Gender = rdMale.IsChecked == true ? "Male" : "Female";
            sAdd.Dob = DateOnly.Parse(datePicker.Text);
            sAdd.Nationality = cbNation.Text;

            listStars.Add(sAdd);

            listView.ItemsSource = listStars;

        }

        private void btnImport_Click(object sender, RoutedEventArgs e)
        {
            OpenFileDialog openFile = new OpenFileDialog
            {
                InitialDirectory = @"",
                Multiselect = false
            };

            if (openFile.ShowDialog() == true)
            {
                var fileName = openFile.FileName;
                if (!string.IsNullOrEmpty(fileName) && File.Exists(fileName))
                {
                    ReadFromFile(fileName);
                }
                else
                {
                    MessageBox.Show("File does not exist.", "Error",
                        MessageBoxButton.OK, MessageBoxImage.Error);
                }
            }

        }

        public void ReadFromFile(string filename)
        {

            using StreamReader reader = new StreamReader(filename);
            string? line;
            while ((line = reader.ReadLine()) != null)
            {
                var listString = line.Split(";");
                Star sImport = new Star();
                sImport.Name = listString[0].Trim();
                sImport.Gender = listString[1].Trim();
                sImport.Dob = DateOnly.Parse(listString[2].Trim());
                sImport.Nationality = listString[3].Trim();
                listStars.Add(sImport);
            }

            listView.ItemsSource = listStars;

        }

        private void btnSave_Click(object sender, RoutedEventArgs e)
        {
            SaveFileDialog saveFileDialog = new SaveFileDialog
            {
                Filter = "Text file (*.txt)|*.txt|All files (*.*)|*.*"
            };
            if (saveFileDialog.ShowDialog() == true)
            {
                WriteListToFile(listStars, saveFileDialog.FileName);
                MessageBox.Show("List saved successfully.", "Success", MessageBoxButton.OK, MessageBoxImage.Information);
            }
        }
        private void WriteListToFile(ObservableCollection<Star> list, string filePath)
        {
            try
            {
                using (StreamWriter writer = new StreamWriter(filePath))
                {
                    foreach (var item in list)
                    {
                        string line = $"{item.Name};{(item.Gender)};{item.Dob};{item.Nationality}";
                        writer.WriteLine(line);
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"An error occurred: {ex.Message}", "Error", MessageBoxButton.OK, MessageBoxImage.Error);
            }
        }
    }
}