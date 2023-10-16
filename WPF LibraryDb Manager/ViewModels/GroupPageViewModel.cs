using System;
using System.Linq;
using EF_Practise.Entities;
using System.Collections.Generic;

namespace Library_WPF.ViewModels { 
    public class GroupPageViewModel {

        // Properties

        public List<Group> Groups { get; set; } = new();

        // Constructors

        public GroupPageViewModel(List<Group> groups) {

            Groups = groups;
        }
    }
}
