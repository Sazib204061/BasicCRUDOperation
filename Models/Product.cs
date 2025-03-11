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

        [Range(1,5000)]  //it is show default error message
        //[Range(1, 5000, ErrorMessage ="Price must be between 1 to 5000.")]  // if we want to show custom error message
        public decimal Price { get; set; }
    }
}
