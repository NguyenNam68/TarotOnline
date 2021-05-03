namespace Tarot.Model.EF
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("Cart")]
    public partial class Cart
    {
        public int ID { get; set; }

        public int ProductID { get; set; }

        public string ProductName { get; set; }

        public int? Quantity { get; set; }

        public decimal? Discount { get; set; }

        public decimal? Price { get; set; }

        public int PaymentID { get; set; }

        [Column(TypeName = "date")]
        public DateTime? CreatedDate { get; set; }

        [StringLength(500)]
        public string CreatedBy { get; set; }

        public bool Status { get; set; }

        public virtual PaymentMethod PaymentMethod { get; set; }

        public virtual Product Product { get; set; }
    }
}
