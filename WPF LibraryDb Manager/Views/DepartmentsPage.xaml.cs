using System;
using System.Linq;
using EF_Practise.Entities;
using Library_WPF.ViewModels;
using System.Windows.Controls;
using Microsoft.EntityFrameworkCore;

namespace Library_WPF.Views {
    public partial class DepartmentsPage : Page {
        public DepartmentsPage(DbSet<Department> departments) {

            InitializeComponent();
            DataContext = new DepartmentPageViewModel(departments.ToList());
        }
    }
}
