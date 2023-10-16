using System;
using System.Linq;
using EF_Practise.Entities;
using System.Collections.Generic;

namespace Library_WPF.ViewModels {
    public class S_CardPageViewModel {

        // Properties

        public List<S_Card> S_Cards { get; set; }

        // Constructors

        public S_CardPageViewModel(List<S_Card> s_Cards) {
            S_Cards = s_Cards;
        }
    }
}
