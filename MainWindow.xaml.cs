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
using System.IO;

namespace Практика_6
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
            Theme.IsChecked = (ThemeHelper.Current == "Dark.xaml");
        }

        private void Play_Click(object sender, RoutedEventArgs e)
        {
            Progress.Value = 50;
        }

        private void Previous_Click(object sender, RoutedEventArgs e)
        {
            Progress.Value = 35;
        }

        private void Next_Click(object sender, RoutedEventArgs e)
        {
            Progress.Value = 90;
        }

        private void Folder_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            switch (Equalizer.SelectedIndex)
            {
                case 0:
                    Title.Text = "Senna";
                    break;
                case 1:
                    Title.Text = "Hit #2";
                    break;
                case 2:
                    Title.Text = "Груз 200";
                    break;
                case 3:
                    Title.Text = "Jane";
                    break;
            }
        }

        private void Theme_Checked(object sender, RoutedEventArgs e)
        {
            if (IsLoaded)
            {
                ThemeHelper.Toggle();
            }
        }

        private void Cycle_Checked(object sender, RoutedEventArgs e)
        {
            MessageBox.Show("Вы включили зацикливание треков");
        }
    }
}