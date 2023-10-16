using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EF_Practise.Entities;

public class Department : BaseEntity {
    public string Name { get; set; }

    // Navigation Property

    public ICollection<Teacher> Teachers { get; set; }
}
