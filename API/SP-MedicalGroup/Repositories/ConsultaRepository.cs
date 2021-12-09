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

        /// <summary>
        /// cadastra um usuario novo
        /// </summary>
        /// <param name="novoCadastro"></param>
        public void Consulta(Consultum novoCadastro)
        {
            // adiciona uma nova consulta
            ctx.Consulta.Add(novoCadastro);

            // salva as informações para serem salvas no banco
            ctx.SaveChanges();

        }

        public void CancelarConsulta(int id, Consultum consultaCancelada)
        {
            Consultum consultaBuscada = ctx.Consulta.Find(id);

            consultaBuscada.IdSituacao = consultaCancelada.IdSituacao;

            // cancela um agendamento
            ctx.Consulta.Update(consultaBuscada);

            // salva a alteração de status do agendamento
            ctx.SaveChanges();
        }

     
    
    }
}
