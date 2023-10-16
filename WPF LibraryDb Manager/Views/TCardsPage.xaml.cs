using System; 
using System.Linq; 
using EF_Practise.Entities; 
using Library_WPF.ViewModels;
using System.Windows.Controls; 
using Microsoft.EntityFrameworkCore;

namespace Library_WPF.Views {
    public partial class TCardsPage : Page {
        public TCardsPage(DbSet<T_Card> t_Cards) {

            InitializeComponent();
            DataContext = new T_CardPageViewModel(t_Cards.ToList());
        }
    }
}
