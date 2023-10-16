using System; 
using System.Linq; 
using EF_Practise.Entities; 
using Library_WPF.ViewModels;
using System.Windows.Controls; 
using Microsoft.EntityFrameworkCore;

namespace Library_WPF.Views { 
    public partial class PressPage : Page {
        public PressPage(DbSet<Press> presses) {

            InitializeComponent();
            DataContext = new PressPageViewModel(presses.ToList());
        }
    }
}
