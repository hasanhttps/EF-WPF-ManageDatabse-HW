using System;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EF_Practise.Entities;

public class Student : BaseEntity {

    public string FirstName { get; set; }
    public string LastName { get; set; }
    [ForeignKey(nameof(Group))]
    public int Id_Group { get; set; }
    public int Term { get; set; }

    // Navigation Property

    public ICollection<S_Card> S_Cards { get; set; }
    public Group Group { get; set; }
}
