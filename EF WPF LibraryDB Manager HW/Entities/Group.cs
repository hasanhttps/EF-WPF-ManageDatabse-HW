using System;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations.Schema;

namespace EF_Practise.Entities;

public class Group : BaseEntity {

    public string Name { get; set; }
    [ForeignKey(nameof(Faculty))]
    public int Id_Faculty { get; set; }

    // Navigation Property

    public ICollection<Student> Students { get; set; }
    public Faculty Faculty { get; set; }
}
