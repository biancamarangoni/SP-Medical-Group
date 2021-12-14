using SP_MedicalGroup.Domains;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace SP_MedicalGroup.Interfaces
{
    interface IConsultaRepository
    {
        void Consulta(Consultum consultaCancelada);
        void CancelarConsulta(int id, Consultum consultaCancelada);
        public void ListarConsultas(List<Consultum> listaDeConsultas);
    }
}
