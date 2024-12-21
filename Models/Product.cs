using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;

namespace SportsStore.Models {

    public class Product {

        public long? ProductID { get; set; }

        [Required(ErrorMessage = "Please Enter A Name")]
        public string Name { get; set; } = String.Empty;

        [Required(ErrorMessage = "Please Enter A Description")]
        public string Description { get; set; } = String.Empty;

        [Required]
        [Range(0.01, double.MaxValue, ErrorMessage = "Please Enter A Positive Price")]
        [Column(TypeName = "decimal(8, 2)")]
        public decimal Price { get; set; }

        [Required(ErrorMessage = "Please Specify A Category")]
        public string Category { get; set; } = String.Empty;
    }
}
