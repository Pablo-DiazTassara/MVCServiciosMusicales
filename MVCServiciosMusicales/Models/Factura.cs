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
    
    public partial class Factura
    {
        public int Numero { get; set; }
        public Nullable<System.DateTime> Fecha { get; set; }
        public Nullable<int> Servicio_Id { get; set; }
        public Nullable<int> Sucursal_Id { get; set; }
        public Nullable<int> Monto { get; set; }
    
        public virtual Servicio Servicio { get; set; }
        public virtual Sucursal Sucursal { get; set; }
    }
}