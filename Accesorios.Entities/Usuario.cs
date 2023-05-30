using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Accesorios.Entities
{
    public class Usuario
    {
        [Key]
        public int UsuarioId { get; set; }
        [MaxLength(80)]
        [Required]
        public string Email { get; set; }
        [MaxLength(80)]
        [Required]
        public string Password { get; set; }
        [Required]
        public int RolId { get; set; }
        [Required]
        public int EstadoId { get; set; }





        public virtual ICollection<Empleado> Empleados { get; set; }
        public virtual Rol Roles { get; set; }
        public virtual Estado Estados { get; set; }


        public virtual ICollection<Compra> Compras { get; set; }

        public virtual ICollection<Venta> Ventas { get; set; }

    }
}
