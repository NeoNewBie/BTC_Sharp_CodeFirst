using System.ComponentModel.DataAnnotations;
namespace CodeFirst.Models
{
    public class Category
    {
        [Key]
        public int Id { get; set; }
        [Required, StringLength(100)]
        public string Name { get; set; }
        public virtual ICollection<Product> Products { get; set; }
    }
}
