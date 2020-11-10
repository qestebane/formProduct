using System.ComponentModel.DataAnnotations;
namespace formProduct.Models
{
    public class Producto
    {
       [Required]
        [Display(Name="Nombre producto")]
        public string Nombre { get; set; }

        [Required]        
        [Display(Name="Precio")]
        public double Precio { get; set; }

        [Required]
        [Display(Name="Descripcion")]
        public string Descripcion { get; set; }
    }
}