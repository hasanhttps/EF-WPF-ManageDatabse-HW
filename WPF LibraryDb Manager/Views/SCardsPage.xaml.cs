using System; 
using System.Linq; 
using EF_Practise.Entities; 
using Library_WPF.ViewModels;
using System.Windows.Controls; 
using Microsoft.EntityFrameworkCore;

namespace Library_WPF.Views { 
    public partial class SCardsPage : Page {
        public SCardsPage(DbSet<S_Card> s_Cards) {

            InitializeComponent();
            DataContext = new S_CardPageViewModel(s_Cards.ToList());
        }
    }
}
