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
    
    public partial class Borrowinf
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public Borrowinf()
        {
            this.BrowBook = new HashSet<BrowBook>();
            this.Infringement = new HashSet<Infringement>();
        }
    
        public int Id { get; set; }
        public string BorrowinfNum { get; set; }
        public Nullable<System.DateTime> borrowTime { get; set; }
        public Nullable<System.DateTime> returnTime { get; set; }
        public string ReaderNumber { get; set; }
        public string ReaderName { get; set; }
        public Nullable<bool> Sex { get; set; }
        public string phone { get; set; }
        public string RederCid { get; set; }
        public Nullable<decimal> deposit { get; set; }
        public Nullable<System.DateTime> hadleDate { get; set; }
        public string adminname { get; set; }
    
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<BrowBook> BrowBook { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Infringement> Infringement { get; set; }
    }
}
