using System;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;

namespace EF_Practise.Entities;

public class Press : BaseEntity {
    public string Name { get; set; }

    // Navigation Property

    public ICollection<Book> Books { get; set; }

}