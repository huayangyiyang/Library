//------------------------------------------------------------------------------
// <auto-generated>
//     此代码已从模板生成。
//
//     手动更改此文件可能导致应用程序出现意外的行为。
//     如果重新生成代码，将覆盖对此文件的手动更改。
// </auto-generated>
//------------------------------------------------------------------------------

namespace Model
{
    using System;
    using System.Collections.Generic;
    
    public partial class Infringement
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public Infringement()
        {
            this.Ticket = new HashSet<Ticket>();
        }
    
        public int Id { get; set; }
        public string readerNum { get; set; }
        public string ReaderName { get; set; }
        public Nullable<decimal> sumMoney { get; set; }
        public Nullable<System.DateTime> proseDate { get; set; }
        public Nullable<int> BorrowinfId { get; set; }
    
        public virtual Borrowinf Borrowinf { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Ticket> Ticket { get; set; }
    }
}