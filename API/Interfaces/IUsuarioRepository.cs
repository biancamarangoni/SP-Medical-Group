using SP_MedicalGroup.Domains;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace SP_MedicalGroup.Interfaces
{
    interface IUsuarioRepository
    {
        /// <summary>
        /// Valida o usuário
        /// </summary>
        /// <param name="email">Email do usuario</param>
        /// <param name="senha">senha do usuario</param>
        /// <returns>um objeto do tipo Usuario que foi encontrado</returns>
        Usuario Login(string email, string senha);
    }
}
