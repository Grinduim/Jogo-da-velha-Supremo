//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace API
{
    using System;
    using System.Collections.Generic;
    
    public partial class Fila
    {
        public int Id { get; set; }
        public Nullable<int> IdJogador { get; set; }
        public byte[] HoraEntrada { get; set; }
    
        public virtual Usuario Usuario { get; set; }
    }
}
