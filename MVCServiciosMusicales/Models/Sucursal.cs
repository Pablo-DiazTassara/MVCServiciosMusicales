//------------------------------------------------------------------------------
// <auto-generated>
//    Este código se generó a partir de una plantilla.
//
//    Los cambios manuales en este archivo pueden causar un comportamiento inesperado de la aplicación.
//    Los cambios manuales en este archivo se sobrescribirán si se regenera el código.
// </auto-generated>
//------------------------------------------------------------------------------

namespace MVCServiciosMusicales.Models
{
    using System;
    using System.Collections.Generic;
    
    public partial class Sucursal
    {
        public Sucursal()
        {
            this.Factura = new HashSet<Factura>();
        }
    
        public int Id { get; set; }
        public string Zona { get; set; }
        public string Descripcion { get; set; }
    
        public virtual ICollection<Factura> Factura { get; set; }
    }
}
