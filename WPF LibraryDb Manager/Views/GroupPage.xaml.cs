using System.Linq;
using EF_Practise.Entities;
using Library_WPF.ViewModels;
using System.Windows.Controls;
using Microsoft.EntityFrameworkCore;

namespace Library_WPF.Views {
    public partial class GroupPage : Page {
        public GroupPage(DbSet<Group> groups) {

            InitializeComponent();
            DataContext = new GroupPageViewModel(groups.ToList());
        }
    }
}
