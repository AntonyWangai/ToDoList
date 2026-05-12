using Microsoft.UI.Xaml;
using TaskApp.ViewModels;


namespace TaskApp.Views
{
    
    public sealed partial class MainWindow : Window
    {
        public TaskViewModel TaskViewModel { get; }
        public MainWindow()
        {
            InitializeComponent();
            TaskViewModel = new TaskViewModel();
        }
    }
}
