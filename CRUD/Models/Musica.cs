//------------------------------------------------------------------------------
// <auto-generated>
//     Este código se generó a partir de una plantilla.
//
//     Los cambios manuales en este archivo pueden causar un comportamiento inesperado de la aplicación.
//     Los cambios manuales en este archivo se sobrescribirán si se regenera el código.
// </auto-generated>
//------------------------------------------------------------------------------

namespace CRUD.Models
{
    using System;
    using System.Collections.Generic;
    
    public partial class Musica
    {
        public int id { get; set; }
        public string Nombre { get; set; }
        public string Artista { get; set; }
        public Nullable<System.DateTime> Lanzamiento { get; set; }
        public string Album { get; set; }
        public double Duracion { get; set; }
    }
}
