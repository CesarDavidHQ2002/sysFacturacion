
using System.ComponentModel.DataAnnotations;

namespace sysFacturacion.EL
{
    public class product
    {
        [Key]
        public int Idproduct { get; set; }

        [Required]
        [StringLength(50)]
        public string Name { get; set; }

        [Required]
        [StringLength(100)]
        public string Description { get; set; }

        public string imageURL { get; set; }

        [Required]
        [Range(0, 9999999999999999.99)]
        public decimal price { get; set; }
        public int quantity { get; set; }

        public virtual categori idCategori { get; set; }

    }
}
