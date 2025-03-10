using System.ComponentModel;
using System.ComponentModel.DataAnnotations;

namespace BasicCRUDOperation.Models
{
    public class Product
    {
        //[Key]
        public int Id { get; set; }
        //here we abel to add diffrent type of data anotation ex- [Required], [Key]
        //[Required]
        //[DisplayName("Product Name")] //using this we set form label name
        public string Name { get; set; }
        //[DisplayName("Product Price")]

        public decimal Price { get; set; }
    }
}
