using System;
using System.Collections.Generic;

#nullable disable

namespace ApiRestCoreAspiria.Models
{
    public partial class Producto
    {
        public int Id { get; set; }
        public string Nombre { get; set; }
        public string Descripcion { get; set; }
        public int Edad { get; set; }
        public string Compañia { get; set; }
        public decimal Precio { get; set; }
    }
}
