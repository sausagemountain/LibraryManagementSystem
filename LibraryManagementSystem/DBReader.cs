//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace LibraryManagementSystem
{
    using System;
    using System.Collections.Generic;
    
    public partial class DBReader
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public DBReader()
        {
            this.TakenPublications = new HashSet<DBPublication>();
        }
    
        public int Id { get; set; }
        public string First { get; set; }
        public string Last { get; set; }
        public string Patronimic { get; set; }
        public byte AccessLevel { get; set; }
    
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<DBPublication> TakenPublications { get; set; }
    }
}
