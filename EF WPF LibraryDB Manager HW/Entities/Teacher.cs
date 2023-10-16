using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EF_Practise.Entities;

public class Teacher : BaseEntity {

    public string FirstName { get; set; }
    public string LastName { get; set; }
    [ForeignKey(nameof(Department))]
    public int Id_Dep { get; set; }

    // Navigation Property

    public ICollection<T_Card> T_Cards { get; set; }
    public Department Department { get; set; }

}