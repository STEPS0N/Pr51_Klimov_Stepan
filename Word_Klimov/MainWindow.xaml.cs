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
using Microsoft.Win32;
using Word_Klimov.Context;

namespace Word_Klimov
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
            LoadRooms();
        }

        public void LoadRooms()
        {
            for (int i = 0; i < 20; i++)
                Parent.Children.Add(new Elements.Room(i));
        }

        private void Report(object sender, RoutedEventArgs e)
        {
            SaveFileDialog sfd = new SaveFileDialog();
            sfd.Filter = "Word Files (*.docx)|*.docx";
            sfd.ShowDialog();
            if (sfd.FileName != "")
            {
                OwnerContext.Report(sfd.FileName);
            }
        }
    }
}