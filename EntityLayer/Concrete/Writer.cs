
using System.ComponentModel.DataAnnotations;

namespace EntityLayer.Concrete;

public class Writer
{
    [Key]
    public int Id { get; set; }
    [StringLength(50)]
    public string Name { get; set; }
    [StringLength(50)]
    public string SurName { get; set; }
    [StringLength(100)]
    public string Image { get; set; }
    [StringLength(50)]
    public string Mail { get; set; }
    [StringLength(20)]
    public string Password { get; set; }

    public ICollection<Heading> Headings { get; set; }
    public ICollection<Writer> Writers { get; set; }
}