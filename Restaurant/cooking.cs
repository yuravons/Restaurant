//------------------------------------------------------------------------------
// <auto-generated>
//     Этот код создан по шаблону.
//
//     Изменения, вносимые в этот файл вручную, могут привести к непредвиденной работе приложения.
//     Изменения, вносимые в этот файл вручную, будут перезаписаны при повторном создании кода.
// </auto-generated>
//------------------------------------------------------------------------------

namespace Restaurant
{
    using System;
    using System.Collections.Generic;
    
    public partial class cooking
    {
        public int id { get; set; }
        public System.DateTime receive_time { get; set; }
        public System.DateTime execute_time { get; set; }
        public Nullable<int> check_id { get; set; }
        public Nullable<int> status_id { get; set; }
    
        public virtual checks checks { get; set; }
        public virtual statuses statuses { get; set; }
    }
}
