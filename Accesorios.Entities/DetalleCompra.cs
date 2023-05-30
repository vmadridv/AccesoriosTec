using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Accesorios.Entities
{
    public class DetalleCompra
    {
        [Key]

        public int DetalleCompraId { get; set; }
        [Required]
        public int Cantidad { get; set; }
        [Required]

        public decimal Subtotal { get; set; }
        [Required]

        public int ProductoId { get; set; }
        [Required]
        public int CompraId { get; set; }

        public virtual Compra Compra { get; set; }

        public virtual Producto Productos { get; set; }

    }
}
