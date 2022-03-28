using System.Windows;
using Launcher.Models;
using Launcher.ViewModels;

namespace Launcher.Views
{
    public partial class MainWindowView : Window
    {
        public MainWindowView()
        {
            InitializeComponent();
            DataContext = new MainWindowViewModel(new MainWindowModel());
        }
    }
}