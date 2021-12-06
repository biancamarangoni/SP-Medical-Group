using SP_MedicalGroup.Domains;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace SP_MedicalGroup.Interfaces
{
    interface IMedicoRepository
    {
        /// <summary>
        /// Lista todas as consultas do Medico
        /// </summary>
        /// <returns> retorna uma lista de consultas </returns>
        List<Consultum> Listar();
    }
}
