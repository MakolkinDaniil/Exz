//------------------------------------------------------------------------------
// <auto-generated>
//     Этот код создан по шаблону.
//
//     Изменения, вносимые в этот файл вручную, могут привести к непредвиденной работе приложения.
//     Изменения, вносимые в этот файл вручную, будут перезаписаны при повторном создании кода.
// </auto-generated>
//------------------------------------------------------------------------------

namespace LombardWPF
{
    using System;
    using System.Collections.Generic;
    
    public partial class PaymentSchedule
    {
        public int PaymentScheduleID { get; set; }
        public int Cost { get; set; }
        public System.DateTime DeadlineDate { get; set; }
        public System.DateTime ActualDate { get; set; }
        public int ProductID { get; set; }
        public int StaffID { get; set; }
        public int PaymentStatusID { get; set; }
    
        public virtual PaymentStatus PaymentStatus { get; set; }
        public virtual Products Products { get; set; }
        public virtual Staff Staff { get; set; }
    }
}
