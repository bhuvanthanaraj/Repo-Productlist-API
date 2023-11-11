using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;

namespace saneforcetask1.Models
{
    public class Product
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int Id { get; set; }
        public Guid ProductCode { get; set; }
        public string ProductName { get; set; }
        public decimal Rate { get; set; }

    }
}
