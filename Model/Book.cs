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
    
    public partial class Book
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public Book()
        {
            this.BrowBook = new HashSet<BrowBook>();
        }
    
        public int Id { get; set; }
        public string bookNumber { get; set; }
        public string bookName { get; set; }
        public string booktype { get; set; }
        public string bookAuthor { get; set; }
        public string bookPublish { get; set; }
        public Nullable<System.DateTime> bookPublisttime { get; set; }
        public string bookversion { get; set; }
        public Nullable<System.DateTime> bookInTime { get; set; }
        public string bookstate { get; set; }
        public Nullable<decimal> price { get; set; }
        public string bookDesply { get; set; }
        public string adminname { get; set; }
    
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<BrowBook> BrowBook { get; set; }
    }
}