using System;
using System.Linq;
using EF_Practise.Entities;
using Library_WPF.ViewModels;
using System.Windows.Controls;
using Microsoft.EntityFrameworkCore;

namespace Library_WPF.Views {
    public partial class FacultiesPage : Page {

        // Private Field

        private DbSet<Faculty> faculties;

        // Constructor

        public FacultiesPage(DbSet<Faculty> faculties) {

            InitializeComponent();
            DataContext = new FacultyPageViewModel(faculties.ToList());
        }
    }
}
