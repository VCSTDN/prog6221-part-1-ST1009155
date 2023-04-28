using System.Collections.ObjectModel;
using System.Windows;

namespace ST10091555_PROGP1_STUDENTY_TIME_MANAGEMENT_APPLICATION
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        private ObservableCollection<Module> modules = new ObservableCollection<Module>();

        public MainWindow()
        {
            InitializeComponent();
            moduleDataGrid.ItemsSource = modules;
        }

        private void AddButton_Click(object sender, RoutedEventArgs e)
        {
            var module = new Module
            {
                Code = codeTextBox.Text,
                Name = nameTextBox.Text,
                Credits = int.Parse(creditsTextBox.Text),
                ClassHoursPerWeek = int.Parse(classHoursTextBox.Text),
            };
            modules.Add(module);
        }
    }

