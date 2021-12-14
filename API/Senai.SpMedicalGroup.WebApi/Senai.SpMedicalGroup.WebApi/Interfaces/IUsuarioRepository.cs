using Microsoft.AspNetCore.Http;
using Senai.SpMedicalGroup.WebApi.Domains;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Senai.SpMedicalGroup.WebApi.Interfaces
{
    interface IUsuarioRepository
    {
        /// <summary>
        /// Valida o usuário 
        /// </summary>
        /// <param name="email">E-mail do usuário</param>
        /// <param name="senha">Senha do usuário</param>
        /// <returns>Um objeto do tipo Usuario que foi encontrado</returns>
        Usuario Login(string email, string senha);


        void SalvarPerfilDir(IFormFile foto, int idUsuario);

        string ConsultarPerfilDir(int idUsuario);

        public List<Usuario> ListarTodos();

        public Usuario BuscarPorId(int idUsuario);

        public void Cadastrar(Usuario novousuario);

        public void Atualizar(int idUsuario, Usuario usuarioAtualizado);

        public void Deletar(int idUsuario);
    }
}
