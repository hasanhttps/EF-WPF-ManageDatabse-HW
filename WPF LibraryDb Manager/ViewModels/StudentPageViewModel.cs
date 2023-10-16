using System;
using System.Linq;
using System.Collections.Generic;
using EF_Practise.Entities;

namespace Library_WPF.ViewModels {
    public class StudentPageViewModel {

        // Properties

        public List<Student> Students { get; set; }

        // Constructor

        public StudentPageViewModel(List<Student> students) {

            Students = students;
        }
    }
}
