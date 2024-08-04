using QuantumForgeEditor.GameProject;
using System.Windows;

namespace QuantumForgeEditor
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
            Loaded += MainWindow_Loaded;
        }

        private void MainWindow_Loaded(object sender, RoutedEventArgs e)
        {
            Loaded -= MainWindow_Loaded;

            // Open the dialog when the main window is loaded
            ProjectBrowserDilaog projectBrowserDialog = new()
            {
                Owner = this
            };
            bool? dialogClosed = projectBrowserDialog.ShowDialog();

            if (dialogClosed == false)
            {
                Application.Current.Shutdown();
            }
            else
            {
                // Logic to be implemented if the dialog is not closed with a negative result
            }
        }
    }

}