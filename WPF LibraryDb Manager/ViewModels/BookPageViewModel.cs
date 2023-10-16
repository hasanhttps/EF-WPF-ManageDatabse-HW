using System;
using System.Linq;
using EF_Practise.Contexts;
using EF_Practise.Entities;
using System.Collections.Generic;
using WPF_LibraryDb_Manager.Commands;

namespace Library_WPF.ViewModels {
    public class BookPageViewModel {

        // Properties

        public List<Book> Books { get; set; } = new();
        public LibraryDbContext Context { get; set; } = new();
        public RelayCommand AddCommand { get; set; }

        // Constructor

        public BookPageViewModel(List<Book> books) {
            Books = books;
            AddCommand = new RelayCommand(Add);
        }

        // Functions

        public void Add(object? param) {
           
        }
       
    }
}
