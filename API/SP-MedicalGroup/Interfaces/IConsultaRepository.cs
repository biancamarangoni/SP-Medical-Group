using SP_MedicalGroup.Domains;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace SP_MedicalGroup.Interfaces
{
    interface IConsultaRepository
    {
        void Consulta(Consultum novoCadastro);
    }
}
