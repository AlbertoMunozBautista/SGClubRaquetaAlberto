//------------------------------------------------------------------------------
// <auto-generated>
//     Este código se generó a partir de una plantilla.
//
//     Los cambios manuales en este archivo pueden causar un comportamiento inesperado de la aplicación.
//     Los cambios manuales en este archivo se sobrescribirán si se regenera el código.
// </auto-generated>
//------------------------------------------------------------------------------

namespace SGClubRaquetaAlberto
{
    using System;
    using System.Collections.Generic;
    
    public partial class reservas
    {
        public int idReserva { get; set; }
        public System.DateTime fecha { get; set; }
        public System.TimeSpan hora { get; set; }
        public int pista { get; set; }
        public string socio { get; set; }
        public string pagado { get; set; }
        public decimal cantidad { get; set; }
    
        public virtual pistas pistas { get; set; }
        public virtual socios socios { get; set; }
    }
}
