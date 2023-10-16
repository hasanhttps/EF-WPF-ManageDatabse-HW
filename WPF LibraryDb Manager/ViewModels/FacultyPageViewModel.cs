using System;
using System.Linq;
using EF_Practise.Entities;
using System.Collections.Generic;
using WPF_LibraryDb_Manager.Commands;

namespace Library_WPF.ViewModels {
    public class FacultyPageViewModel {

        // Properties

        public List<Faculty> Faculties { get; set; } = new();

        // Constructors
         
        public FacultyPageViewModel(List<Faculty> faculties) {

            Faculties = faculties;
        }

    }
}
