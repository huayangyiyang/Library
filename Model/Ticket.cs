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
    
    public partial class Ticket
    {
        public int Id { get; set; }
        public Nullable<int> InfringementId { get; set; }
        public string bookNumber { get; set; }
        public string bookName { get; set; }
        public Nullable<int> OverDays { get; set; }
        public Nullable<decimal> everyDayPay { get; set; }
        public Nullable<decimal> fine { get; set; }
    
        public virtual Infringement Infringement { get; set; }
    }
}
