using System; 
using System.Linq; 
using EF_Practise.Entities; 
using Library_WPF.ViewModels;
using System.Windows.Controls; 
using Microsoft.EntityFrameworkCore;

namespace Library_WPF.Views { 
    public partial class StudentPage : Page {
        public StudentPage(DbSet<Student> students) {

            InitializeComponent();
            DataContext=new StudentPageViewModel(students.ToList());
        }
    }
}
