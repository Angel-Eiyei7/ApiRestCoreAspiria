using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BlazorCRUDAspiria.Data
{
    public class Producto
    {
        public int Id { get; set; }
        public string Nombre { get; set; }
        public string Descripcion { get; set; }
        public int Edad { get; set; }
        public string Compañia { get; set; }
        public decimal Precio { get; set; }
    }
}
