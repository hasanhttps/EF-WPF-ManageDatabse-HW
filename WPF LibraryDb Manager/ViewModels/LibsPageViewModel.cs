using System;
using EF_Practise.Entities;
using System.Collections.Generic;

namespace Library_WPF.ViewModels {
    public class LibsPageViewModel {

        // Properties

        public List<Lib> Libs { get; set; } = new();

        // Constructors

        public LibsPageViewModel(List<Lib> libs) {

            Libs = libs;
        }
    }
}
