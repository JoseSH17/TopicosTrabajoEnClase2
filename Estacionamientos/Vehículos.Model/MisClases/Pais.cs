//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace Estacionamientos.Model
{
    using System;
    using System.Collections.Generic;
    
    public partial class Pai
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public Pai()
        {
            this.Fabricantes = new HashSet<Fabricante>();
        }
    
        public decimal IDPais { get; set; }
        public string NombrePais { get; set; }
        public string AbreviaturaPais { get; set; }
        public Nullable<decimal> IDRegionContinente { get; set; }
    
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Fabricante> Fabricantes { get; set; }
        public virtual RegionContinente RegionContinente { get; set; }
    }
}
