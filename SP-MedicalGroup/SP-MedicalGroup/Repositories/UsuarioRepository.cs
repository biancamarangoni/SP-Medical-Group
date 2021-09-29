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
        public Usuario Login(string email, string senha)
        {
            return ctx.Usuarios.FirstOrDefault(u => u.Email == email && u.Senha == senha);

            
        }
    }
}
