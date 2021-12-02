using SP_MedicalGroup.Context;
using SP_MedicalGroup.Domains;
using SP_MedicalGroup.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace SP_MedicalGroup.Repositories
{
    public class ConsultaRepository : IConsultaRepository

    {
        private SPMediContext ctx = new SPMediContext();

        public void Consulta(Consultum novoCadastro)
        {
            // adiciona uma nova consulta
            ctx.Consulta.Add(novoCadastro);

            // salva as informações para serem salvas no banco
            ctx.SaveChanges();

        }
    }
}
