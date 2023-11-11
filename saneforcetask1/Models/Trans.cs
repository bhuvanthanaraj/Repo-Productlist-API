namespace saneforcetask1.Models
{
    public class Trans
    {
        public Guid TransId { get; set; }

        public string ProductCode { get; set; }

        public string ProductName { get; set; }

        public int Quality { get; set; }

        public decimal Rate { get; set; }

        public decimal TaxPercentage { get; set; }

        public decimal TaxAmount { get; set;}

        public decimal GrossTotal { get; set;}

    }


    }

