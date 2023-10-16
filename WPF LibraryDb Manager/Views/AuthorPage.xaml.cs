using System;
using System.Linq;
using EF_Practise.Entities;
using Library_WPF.ViewModels;
using System.Windows.Controls;
using Microsoft.EntityFrameworkCore;

namespace Library_WPF.Views { 
    public partial class AuthorPage : Page {
        public AuthorPage(DbSet<Author> authors) {
            InitializeComponent();
            DataContext = new AuthorPageViewModel(authors.ToList());
        }
    }
}
