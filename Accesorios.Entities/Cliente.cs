﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Accesorios.Entities
{
    public class Cliente
    {
        [Key]
        public int ClienteId { get; set; }
        [MaxLength(50)]
        [Required]
        public string Nombre { get; set; }
        [MaxLength(50)]
        [Required]
        public string Apellido { get; set; }
        [MaxLength(50)]
        [Required]
        public string Telefono { get; set; }

        [Required]
        public int EstadoId { get; set; }
        public virtual Estado Estado { get; set; }



        public virtual ICollection<Venta> ventas { get; set; }
    }
}
