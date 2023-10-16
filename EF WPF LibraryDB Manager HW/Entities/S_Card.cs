using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EF_Practise.Entities;

public class S_Card : BaseEntity {

    [ForeignKey(nameof(Student))]
    public int Id_Student { get; set; }
    [ForeignKey(nameof(Book))]
    public int Id_Book { get; set; }
    public DateTime DateOut { get; set; }
    public DateTime DateIn { get; set; }
    [ForeignKey(nameof(Lib))]
    public int Id_Lib { get; set; }

    // Navigation Property

    public Student Student { get; set; }
    public Book Book { get; set; }
    public Lib Lib { get; set; }
}