//------------------------------------------------------------------------------
// <auto-generated>
//     Этот код создан по шаблону.
//
//     Изменения, вносимые в этот файл вручную, могут привести к непредвиденной работе приложения.
//     Изменения, вносимые в этот файл вручную, будут перезаписаны при повторном создании кода.
// </auto-generated>
//------------------------------------------------------------------------------

namespace ConfApp.Data
{
    using System;
    using System.Collections.Generic;
    
    public partial class ActivityTimeRate
    {
        public int id { get; set; }
        public int IdActivityMain { get; set; }
        public int IdActivityName { get; set; }
        public int IdModer { get; set; }
        public int IdJury1 { get; set; }
        public Nullable<int> IdJury2 { get; set; }
        public Nullable<int> IdJury3 { get; set; }
        public Nullable<int> IdJury4 { get; set; }
        public Nullable<int> IdJury5 { get; set; }
        public System.TimeSpan TimeStart { get; set; }
        public int NumOfDay { get; set; }
    
        public virtual ActivityMain ActivityMain { get; set; }
        public virtual ActivityName ActivityName { get; set; }
        public virtual Users Users { get; set; }
        public virtual Users Users1 { get; set; }
        public virtual Users Users2 { get; set; }
        public virtual Users Users3 { get; set; }
        public virtual Users Users4 { get; set; }
        public virtual Users Users5 { get; set; }
    }
}
