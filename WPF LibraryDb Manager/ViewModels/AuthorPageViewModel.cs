using System;
using System.Linq;
using EF_Practise.Entities;
using EF_Practise.Contexts;
using System.Collections.Generic;
using WPF_LibraryDb_Manager.Commands;

namespace Library_WPF.ViewModels {
    public class AuthorPageViewModel {

        // Properties

        public List<Author> Authors { get; set; } = new();
        public LibraryDbContext Context { get; set; } = new();
        public RelayCommand AddCommand { get; set; }
        public RelayCommand RemoveCommand { get; set; }

        // Constructor

        public AuthorPageViewModel(List<Author> authors) {
            Authors = authors;
            AddCommand = new RelayCommand(Add);
            RemoveCommand = new RelayCommand(Remove);
        }

        // Functions

        public void Add(object? param) {

        }
        public void Remove(object? param) {

        }


    }
}
