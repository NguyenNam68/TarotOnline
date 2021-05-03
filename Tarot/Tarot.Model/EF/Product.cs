namespace Tarot.Model.EF
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class Product
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public Product()
        {
            Carts = new HashSet<Cart>();
        }

        public int ID { get; set; }

        public int? TypeID { get; set; }

        public int CategoryID { get; set; }

        public int PublisherID { get; set; }

        [StringLength(500)]
        public string ProductName { get; set; }

        [Column(TypeName = "ntext")]
        public string Description { get; set; }

        public string Detail { get; set; }

        public int? QuantitySold { get; set; }

        public string Image { get; set; }

        public decimal? PromotionPrice { get; set; }

        public decimal? Price { get; set; }

        [StringLength(500)]
        public string TopHot { get; set; }

        public int? ViewCount { get; set; }

        public DateTime? CreatedDate { get; set; }

        [StringLength(50)]
        public string CreatedBy { get; set; }

        public bool Status { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Cart> Carts { get; set; }

        public virtual ProductCategory ProductCategory { get; set; }

        public virtual ProductType ProductType { get; set; }

        public virtual Publisher Publisher { get; set; }
    }
}
