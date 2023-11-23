using System.ComponentModel.DataAnnotations;
namespace WebStore.Model
{
    public class Category
    {
        [Key]
        public int Id { get; set; }
        public string? Name { get; set; }
        public string? Tag { get; set; }
        public virtual IList<Product>? Products { get; set; }
    }
}