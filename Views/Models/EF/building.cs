//------------------------------------------------------------------------------
// <auto-generated>
//     Este código se generó a partir de una plantilla.
//
//     Los cambios manuales en este archivo pueden causar un comportamiento inesperado de la aplicación.
//     Los cambios manuales en este archivo se sobrescribirán si se regenera el código.
// </auto-generated>
//------------------------------------------------------------------------------

namespace Models.EF
{
    using System;
    using System.Collections.Generic;
    
    public partial class building
    {
        public int id { get; set; }
        public int id_order_detail { get; set; }
        public int id_department { get; set; }
        public int quantity { get; set; }
    
        public virtual department department { get; set; }
        public virtual order_detail order_detail { get; set; }
    }
}
