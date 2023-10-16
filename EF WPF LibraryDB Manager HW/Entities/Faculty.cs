using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EF_Practise.Entities;

public class Faculty : BaseEntity {

    public string Name { get; set; }

    // Navigation Prtoperty

    public ICollection<Group> Groups { get; set; }  

}