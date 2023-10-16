using System;
using System.Linq;
using EF_Practise.Entities;
using System.Collections.Generic;
using WPF_LibraryDb_Manager.Commands;

namespace Library_WPF.ViewModels {
    public class DepartmentPageViewModel {

        // Properties

        public List<Department> Departments { get; set; } = new();
        public RelayCommand AddCommand { get; set; }

        // Constructors

        public DepartmentPageViewModel(List<Department> departments) {

            Departments = departments;
        }
    }
}
