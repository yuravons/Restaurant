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
    
    public partial class shipment
    {
        public int id { get; set; }
        public int id_content { get; set; }
        public int id_storage_ingredient { get; set; }
        public System.DateTime time { get; set; }
    
        public virtual content_order_ingredients content_order_ingredients { get; set; }
        public virtual storage_ingredient storage_ingredient { get; set; }
    }
}