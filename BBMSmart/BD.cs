//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace ProductAllTool
{
    using System;
    using System.Collections.Generic;
    
    public partial class BD
    {
        public string MABDS { get; set; }
        public string TENBDS { get; set; }
        public string DIACHI { get; set; }
        public string MACSH { get; set; }
        public string MAVP { get; set; }
    
        public virtual CHUSOHUU CHUSOHUU { get; set; }
    }
}