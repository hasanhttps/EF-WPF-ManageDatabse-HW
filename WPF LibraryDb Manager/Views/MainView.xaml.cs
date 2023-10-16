using System; 
using System.Windows; 
using Library_WPF.ViewModels;

namespace Library_WPF.Views { 
    public partial class MainView : Window {
        public MainView() {
            InitializeComponent();
            DataContext = new MainViewModel(currentFrame);
        }
    }
}
