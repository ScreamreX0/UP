//------------------------------------------------------------------------------
// <auto-generated>
//     Этот код создан по шаблону.
//
//     Изменения, вносимые в этот файл вручную, могут привести к непредвиденной работе приложения.
//     Изменения, вносимые в этот файл вручную, будут перезаписаны при повторном создании кода.
// </auto-generated>
//------------------------------------------------------------------------------

namespace UP
{
    using System;
    using System.Collections.Generic;
    
    public partial class tariffs
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public tariffs()
        {
            this.subscriber_tariffs = new HashSet<subscriber_tariffs>();
            this.treates = new HashSet<treates>();
        }
    
        public int id { get; set; }
        public string service_name { get; set; }
        public string name { get; set; }
        public string terms { get; set; }
        public Nullable<double> cost { get; set; }
    
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<subscriber_tariffs> subscriber_tariffs { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<treates> treates { get; set; }
    }
}
