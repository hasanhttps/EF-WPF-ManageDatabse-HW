using System; 
using System.Linq; 
using EF_Practise.Entities;
using Library_WPF.ViewModels;
using System.Windows.Controls; 
using Microsoft.EntityFrameworkCore;

namespace Library_WPF.Views { 
    public partial class TeachersPage : Page {
        public TeachersPage(DbSet<Teacher> teachers) {

            InitializeComponent();
            DataContext = new TeacherPageViewModel(teachers.ToList());
        }
    }
}
