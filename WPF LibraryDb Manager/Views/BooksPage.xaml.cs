using System;
using System.Linq;
using EF_Practise.Entities;
using Library_WPF.ViewModels;
using System.Windows.Controls;
using Microsoft.EntityFrameworkCore;

namespace Library_WPF.Views {
    public partial class BooksPage : Page {
        public BooksPage(DbSet<Book> books) {
            InitializeComponent();
            DataContext = new BookPageViewModel(books.ToList());
        }
    }
}
