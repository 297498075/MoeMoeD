//------------------------------------------------------------------------------
// <auto-generated>
//     此代码已从模板生成。
//
//     手动更改此文件可能导致应用程序出现意外的行为。
//     如果重新生成代码，将覆盖对此文件的手动更改。
// </auto-generated>
//------------------------------------------------------------------------------

namespace MoeMoeD.Model.Entity
{
    using System;
    using System.Collections.Generic;
    
    public partial class Folder
    {
        public Folder()
        {
            this.Flie = new HashSet<Flie>();
            this.ChildFolder = new HashSet<Folder>();
        }
    
        public int Id { get; set; }
        public string Name { get; set; }
        public int UserId { get; set; }
        public int FolderId { get; set; }
    
        public virtual ICollection<Flie> Flie { get; set; }
        public virtual ICollection<Folder> ChildFolder { get; set; }
        public virtual Folder ParentFolder { get; set; }
        public virtual User User { get; set; }
    }
}