using System;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations.Schema;

namespace EF_Practise.Entities;

public class T_Card : BaseEntity {

    [ForeignKey(nameof(Teacher))]
    public int Id_Teacher { get; set; }
    [ForeignKey(nameof(Book))]
    public int Id_Book { get; set; }
    public DateTime DateOut { get; set; }
    public DateTime DateIn { get; set; }
    [ForeignKey(nameof(Lib))]
    public int Id_Lib { get; set; }

    // Navigation Property

    public Teacher Teacher { get; set; }
    public Book Book { get; set; }
    public Lib Lib { get; set; }
}