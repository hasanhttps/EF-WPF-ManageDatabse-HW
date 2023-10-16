using System;
using System.Linq;
using EF_Practise.Entities;
using System.Collections.Generic;

namespace Library_WPF.ViewModels {
    public class PressPageViewModel {

        // Properties

        public List<Press> Presses { get; set; }

        // Constructor

        public PressPageViewModel(List<Press> presses) {

            Presses = presses;
        }
    }
}
