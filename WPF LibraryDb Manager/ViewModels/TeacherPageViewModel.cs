using System;
using System.Linq;
using EF_Practise.Entities;
using System.Collections.Generic;

namespace Library_WPF.ViewModels {
    public class TeacherPageViewModel {

        // Properties

        public List<Teacher> Teachers { get; set; } = new();

        // Constructors

        public TeacherPageViewModel(List<Teacher> teachers) {

            Teachers = teachers;
        }
       
    }
}
