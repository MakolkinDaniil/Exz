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
    
    public partial class Products
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public Products()
        {
            this.PaymentSchedule = new HashSet<PaymentSchedule>();
            this.Sales = new HashSet<Sales>();
        }
    
        public int ProductID { get; set; }
        public int ProductTypeID { get; set; }
        public int ClientID { get; set; }
        public System.DateTime DateOfDelivery { get; set; }
        public int StaffID { get; set; }
        public int Cost { get; set; }
        public int DepositCost { get; set; }
        public int RedemptionCost { get; set; }
    
        public virtual Clients Clients { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<PaymentSchedule> PaymentSchedule { get; set; }
        public virtual ProductType ProductType { get; set; }
        public virtual Staff Staff { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Sales> Sales { get; set; }
    }
}