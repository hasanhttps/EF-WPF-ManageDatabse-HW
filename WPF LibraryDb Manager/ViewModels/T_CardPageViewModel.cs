using System;
using System.Linq;
using EF_Practise.Entities;
using System.Collections.Generic;

namespace Library_WPF.ViewModels {
    public class T_CardPageViewModel {

        // Properties

        public List<T_Card> T_Cards { get; set; } = new();

        // Constructor

        public T_CardPageViewModel(List<T_Card> t_Cards) {
            T_Cards = t_Cards; 
        }
    }
}
