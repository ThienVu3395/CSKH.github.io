//------------------------------------------------------------------------------
// <auto-generated>
//    This code was generated from a template.
//
//    Manual changes to this file may cause unexpected behavior in your application.
//    Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace DuAnCNNB_Web.Models
{
    using System;
    using System.Collections.Generic;
    
    public partial class MUCLUCYEUCAUNANGDOI
    {
        public MUCLUCYEUCAUNANGDOI()
        {
            this.tbGanmois = new HashSet<tbGanmoi>();
        }
    
        public int ID { get; set; }
        public string TENYEUCAUNANGDOI { get; set; }
    
        public virtual ICollection<tbGanmoi> tbGanmois { get; set; }
    }
}
