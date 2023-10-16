using System;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;

namespace EF_Practise.Entities;

public class Book : BaseEntity {

    public string Name { get; set; }
    public int Pages { get; set; }
    public int YearPress { get; set; }
    [ForeignKey(nameof(Theme))]
    public int Id_Themes { get; set; }
    [ForeignKey(nameof(Author))]
    public int Id_Author { get; set; }
    [ForeignKey(nameof(Press))]
    public int Id_Press { get; set; }
    [ForeignKey(nameof(Category))]
    public int Id_Category { get; set; }
    public string? Comment { get; set; }
    public int Quantity { get; set; }

    // Navigation Property

    public ICollection<S_Card> S_Cards { get; set; }
    public ICollection<T_Card> T_Cards { get; set; }
    public Category Category { get; set; }
    public Author Author { get; set; }
    public Theme Theme { get; set; }
    public Press Press { get; set; }
}
