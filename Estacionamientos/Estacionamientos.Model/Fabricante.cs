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
    
    public partial class Fabricante
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public Fabricante()
        {
            this.Vehiculoes = new HashSet<Vehiculo>();
        }
    
        public decimal IDFabricante { get; set; }
        public string NombreFabricante { get; set; }
        public Nullable<decimal> IDPais { get; set; }
    
        public virtual Pai Pai { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Vehiculo> Vehiculoes { get; set; }
    }
}
