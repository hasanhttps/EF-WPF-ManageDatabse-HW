using System;
using System.Linq;
using EF_Practise.Entities;
using System.Collections.Generic;
using WPF_LibraryDb_Manager.Commands;

namespace Library_WPF.ViewModels {
    public class CategoryPageViewModel {

        // Properties

        public List<Category> Categories { get; set; } = new();

        // Constrtuctors

        public CategoryPageViewModel(List<Category> categories) {

            Categories = categories;
        }
    }
}
