//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace CrudMahasiswa.Models
{
    using System;
    using System.Collections.Generic;
    
    public partial class Matakuliah
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public Matakuliah()
        {
            this.Masterdatas = new HashSet<Masterdata>();
        }
    
        public int MatakuliahID { get; set; }
        public string Nama_matakuliah { get; set; }
        public string Sks { get; set; }
    
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Masterdata> Masterdatas { get; set; }
    }
}
