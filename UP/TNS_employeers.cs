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
    
    public partial class TNS_employeers
    {
        public int id { get; set; }
        public string number { get; set; }
        public string first_name { get; set; }
        public string name { get; set; }
        public string last_name { get; set; }
        public Nullable<int> role { get; set; }
        public string login { get; set; }
        public string password { get; set; }
    
        public virtual employee_roles employee_roles { get; set; }
    }
}
