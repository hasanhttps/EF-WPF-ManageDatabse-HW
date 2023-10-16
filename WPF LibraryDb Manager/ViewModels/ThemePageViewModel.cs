using System;
using System.Linq;
using EF_Practise.Entities;
using EF_Practise.Contexts;
using System.Collections.Generic;

namespace Library_WPF.ViewModels {
    public class ThemePageViewModel {

        // Properties

        public LibraryDbContext Context { get; set; } = new();
        public List<Theme> Themes { get; set; }

        // Constructor

        public ThemePageViewModel(List<Theme> themes) {

            Themes = themes;
        }
    }
}
