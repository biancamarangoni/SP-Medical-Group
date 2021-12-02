using SP_MedicalGroup.Context;
using SP_MedicalGroup.Domains;
using SP_MedicalGroup.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace SP_MedicalGroup.Repositories
{
    public class UsuarioRepository : IUsuarioRepository
    {
        SPMediContext ctx = new SPMediContext();

        public void Cadastrar(Usuario usuario)
        {
            // adiciona um novo usuario
            ctx.Usuarios.Add(usuario);

            // salva as informaçoes para serem gravadas no banco de dados
            ctx.SaveChanges();
        }

        public Usuario Login(string email, string senha)
        {
            return ctx.Usuarios.FirstOrDefault(u => u.Email == email && u.Senha == senha);

            
        }

        public void Atualizar(int id, Usuario usuarioAtualizado)
        {
            Usuario usuarioPesquisado = ctx.Usuarios.Find(id);

            if (usuarioPesquisado.NomeUsuario != null) ;
        }
    }
}
