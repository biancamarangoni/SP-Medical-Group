using System;
using System.Collections.Generic;

#nullable disable

namespace SP_MedicalGroup.Domains
{
    public partial class Situacao
    {
        public Situacao()
        {
            Consulta = new HashSet<Consultum>();
        }

        public int IdSituacao { get; set; }
        public string TipoStatus { get; set; }

        public virtual ICollection<Consultum> Consulta { get; set; }
    }
}
