using Senai.SpMedicalGroup.WebApi.Context;
using Senai.SpMedicalGroup.WebApi.Domains;
using Senai.SpMedicalGroup.WebApi.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Senai.SpMedicalGroup.WebApi.Repositories
{
    public class MedicoRepository : IMedicoRepository
    {
        SpMedicalGroupContext ctx = new SpMedicalGroupContext();

        public void Atualizar(int idMedico, Medico medicoAtualizado)
        {
            Medico medicoBuscado = BuscarPorId(idMedico);

            if (medicoAtualizado.IdUsuario != null && medicoAtualizado.IdEspecialidade != null && medicoAtualizado.IdClinica != null && medicoAtualizado.NomeMedico != null && medicoAtualizado.SobrenomeMedico != null && medicoAtualizado.Crm != null)
            {
                medicoBuscado.IdUsuario = medicoAtualizado.IdUsuario;
                medicoBuscado.IdEspecialidade = medicoAtualizado.IdEspecialidade;
                medicoBuscado.IdClinica = medicoAtualizado.IdClinica;
                medicoBuscado.NomeMedico = medicoAtualizado.NomeMedico;
                medicoBuscado.SobrenomeMedico = medicoAtualizado.SobrenomeMedico;
                medicoBuscado.Crm = medicoAtualizado.Crm;
            }

            ctx.Medicos.Update(medicoBuscado);

            ctx.SaveChanges();
        }

        public Medico BuscarPorId(int idMedico)
        {
            return ctx.Medicos.FirstOrDefault(m => m.IdMedico == idMedico);
        }

        public void Cadastrar(Medico novomedico)
        {
            ctx.Medicos.Add(novomedico);

            ctx.SaveChanges();
        }

        public void Deletar(int idMedico)
        {
            Medico medicoBuscado = BuscarPorId(idMedico);

            ctx.Medicos.Remove(medicoBuscado);

            ctx.SaveChanges();
        }

        public List<Medico> ListarTodos()
        {
            return ctx.Medicos.ToList();
        }
    }
}
