using System;
using System.Linq;
using EF_Practise.Entities;
using Library_WPF.ViewModels;
using System.Windows.Controls;
using Microsoft.EntityFrameworkCore;

namespace Library_WPF.Views {
    public partial class CategoryPage : Page {
        public CategoryPage(DbSet<Category> categories) {

            InitializeComponent();
            DataContext = new CategoryPageViewModel(categories.ToList());
        }
    }
}

