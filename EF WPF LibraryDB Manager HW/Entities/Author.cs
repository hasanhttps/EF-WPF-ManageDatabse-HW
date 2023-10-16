using System;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EF_Practise.Entities;

public class Author : BaseEntity {
    
    public string FirstName { get; set; }
    public string LastName { get; set; }

    // Navigation property

    public ICollection<Book> Books { get; set; }

}
