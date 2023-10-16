using System; 
using System.Linq; 
using EF_Practise.Entities; 
using Library_WPF.ViewModels;
using System.Windows.Controls; 
using Microsoft.EntityFrameworkCore;

namespace Library_WPF.Views {
    public partial class ThemesPage : Page {
        public ThemesPage(DbSet<Theme> themes) {

            InitializeComponent();
            DataContext = new ThemePageViewModel(themes.ToList());
        }
    }
}
