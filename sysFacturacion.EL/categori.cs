using System;
using System.ComponentModel.DataAnnotations;

namespace sysFacturacion.EL
{
    public class categori
    {
        [Key]                           //sirve para aplicar cordfirts
        public int idCategori { get; set; }
        [Required]
        [StringLength(50)]
        public string name { get; set; }
        [Required]
        [StringLength(100)]
        public string description { get; set; }
        public byte[] image { get; set; }
        public DateTime date { get; set; }

        public virtual ICollection<product> Products { get; set; }

    }
}
