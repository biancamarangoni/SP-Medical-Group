using Microsoft.EntityFrameworkCore;
using Senai.SpMedicalGroup.WebApi.Context;
using Senai.SpMedicalGroup.WebApi.Domains;
using Senai.SpMedicalGroup.WebApi.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Senai.SpMedicalGroup.WebApi.Repositories
{
    public class ConsultaRepository : IConsultaRepository
    {
        SpMedicalGroupContext ctx = new SpMedicalGroupContext();

        public void AdicionarDecrição(int idConsulta, Consulta ConsultaComDescricao)
        {
            Consulta ConsultaBuscada = BuscarPorId(idConsulta);

            if (ConsultaComDescricao.DescricaoConsulta != null)
            {
                ConsultaBuscada.DescricaoConsulta = ConsultaComDescricao.DescricaoConsulta;
            }

            ctx.Consulta.Update(ConsultaBuscada);

            ctx.SaveChanges();
        }

        public void Atualizar(int idConsulta, Consulta consultaAtualizada)
        {
            Consulta ConsultaBuscada = BuscarPorId(idConsulta);

            if (consultaAtualizada.IdPaciente != null && consultaAtualizada.IdMedico != null && consultaAtualizada.IdSituacao != null )
            {
                ConsultaBuscada.IdPaciente = consultaAtualizada.IdPaciente;
                ConsultaBuscada.IdMedico = consultaAtualizada.IdMedico;
                ConsultaBuscada.IdSituacao = consultaAtualizada.IdSituacao;
                ConsultaBuscada.DataConsulta = consultaAtualizada.DataConsulta;
            }

            ctx.Consulta.Update(ConsultaBuscada);

            ctx.SaveChanges();
        }

        public Consulta BuscarPorId(int idConsulta)
        {
            return ctx.Consulta.FirstOrDefault(c => c.IdConsulta == idConsulta);
        }

        public void Cadastrar(Consulta novaConsulta)
        {
            ctx.Consulta.Add(novaConsulta);

            ctx.SaveChanges();
        }

        public void Cancelar(int idConsulta, string status)
        {
            Consulta alterarEstado = BuscarPorId(idConsulta);

            switch (status)
            {
                case "1":
                    alterarEstado.IdSituacao = 1;
                    break;

                case "2":
                    alterarEstado.IdSituacao = 2;
                    break;

                case "3":
                    alterarEstado.IdSituacao = 3;
                    break;

                default:
                    alterarEstado.IdSituacao = alterarEstado.IdSituacao;
                    break;
            }

            ctx.Consulta.Update(alterarEstado);

            ctx.SaveChanges();

        }

        public void Deletar(int idConsulta)
        {
            Consulta consultaBuscada = BuscarPorId(idConsulta);

            ctx.Consulta.Remove(consultaBuscada);

            ctx.SaveChanges();
        }

        public List<Consulta> ListarTodas()
        {
            return ctx.Consulta
                .Select(c => new Consulta
                {
                    IdConsulta = c.IdConsulta,
                    DataConsulta = c.DataConsulta,
                    DescricaoConsulta = c.DescricaoConsulta,
                    IdPacienteNavigation = new Paciente
                    {
                        NomePaciente = c.IdPacienteNavigation.NomePaciente,
                        DataNascimento = c.IdPacienteNavigation.DataNascimento,
                        Telefone = c.IdPacienteNavigation.Telefone,
                        Rg = c.IdPacienteNavigation.Rg,
                        Cpf = c.IdPacienteNavigation.Cpf,
                    },
                    IdMedicoNavigation = new Medico
                    {
                        NomeMedico = c.IdMedicoNavigation.NomeMedico,
                        SobrenomeMedico = c.IdMedicoNavigation.SobrenomeMedico,
                        Crm = c.IdMedicoNavigation.Crm,
                        IdEspecialidadeNavigation = new Especialidade
                        {
                            TituloEspecialidade = c.IdMedicoNavigation.IdEspecialidadeNavigation.TituloEspecialidade
                        }, 
                    },
                    IdSituacaoNavigation = new Situacao
                    {
                        Situacao1 = c.IdSituacaoNavigation.Situacao1
                    }
                }).ToList();
        }

        public List<Consulta> Minhas(int idUsuario)
        {
            return ctx.Consulta
                .Select(c => new Consulta
                {
                    IdConsulta = c.IdConsulta,
                    DataConsulta = c.DataConsulta,
                    DescricaoConsulta = c.DescricaoConsulta,
                    IdPacienteNavigation = new Paciente
                    {
                        NomePaciente = c.IdPacienteNavigation.NomePaciente,
                        DataNascimento = c.IdPacienteNavigation.DataNascimento,
                        Telefone = c.IdPacienteNavigation.Telefone,
                        Rg = c.IdPacienteNavigation.Rg,
                        Cpf = c.IdPacienteNavigation.Cpf,

                        IdUsuarioNavigation = new Usuario
                        {
                            IdUsuario = c.IdPacienteNavigation.IdUsuarioNavigation.IdUsuario
                        }
                    },
                    IdMedicoNavigation = new Medico
                    {
                        NomeMedico = c.IdMedicoNavigation.NomeMedico,
                        SobrenomeMedico = c.IdMedicoNavigation.SobrenomeMedico,
                        Crm = c.IdMedicoNavigation.Crm,
                        IdEspecialidadeNavigation = new Especialidade
                        {
                            TituloEspecialidade = c.IdMedicoNavigation.IdEspecialidadeNavigation.TituloEspecialidade
                        },

                        IdUsuarioNavigation = new Usuario
                        {
                            IdUsuario = c.IdMedicoNavigation.IdUsuarioNavigation.IdUsuario
                        }
                    },
                    IdSituacaoNavigation = new Situacao
                    {
                        Situacao1 = c.IdSituacaoNavigation.Situacao1
                    }
                })
                .Where(c => c.IdPacienteNavigation.IdUsuarioNavigation.IdUsuario == idUsuario || c.IdMedicoNavigation.IdUsuarioNavigation.IdUsuario == idUsuario).ToList();
        }
    }
}
