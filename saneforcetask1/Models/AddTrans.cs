using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;


/// please ignore this model
/// this model just use for Tem for add trans(POST) the original model table was Trans

namespace saneforcetask1.Models
{
    public class AddTrans
    {

        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int Id { get; set; }
        public string ProductCode { get; set; }
        public string ProductName { get; set; }

        public int Quality { get; set; }

        public decimal Rate { get; set; }

        public decimal TaxPercentage { get; set; }

        public decimal TaxAmount { get; set; }

        public decimal GrossTotal { get; set; }

    }
}
