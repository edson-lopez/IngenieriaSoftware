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
    
    public partial class order_detail
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public order_detail()
        {
            this.building = new HashSet<building>();
        }
    
        public int id { get; set; }
        public int id_order { get; set; }
        public int id_vehicle_part { get; set; }
        public string color { get; set; }
        public string material { get; set; }
    
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<building> building { get; set; }
        public virtual order order { get; set; }
        public virtual vehicle_part vehicle_part { get; set; }
    }
}
