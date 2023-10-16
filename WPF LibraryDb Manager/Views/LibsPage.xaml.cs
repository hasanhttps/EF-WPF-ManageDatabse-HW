using System; 
using System.Linq; 
using EF_Practise.Entities;
using Library_WPF.ViewModels;
using System.Windows.Controls; 
using Microsoft.EntityFrameworkCore;

namespace Library_WPF.Views { 
    public partial class LibsPage : Page {
        public LibsPage(DbSet<Lib> libs) {

            InitializeComponent();
            DataContext = new LibsPageViewModel(libs.ToList());
        }
    }
}
