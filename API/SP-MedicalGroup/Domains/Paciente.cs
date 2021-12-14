using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

#nullable disable

namespace SP_MedicalGroup.Domains
{
    public partial class Paciente
    {
        public Paciente()
        {
            Consulta = new HashSet<Consultum>();
        }

        public int IdPaciente { get; set; }
        public int? IdUsuario { get; set; }
        public int? IdEndereco { get; set; }

        [Required(ErrorMessage = "Informe o nome do usuário")]
        public string NomePaciente { get; set; }

        [Required(ErrorMessage = "Informe a data de nascimento")]
        public string DataNascimento { get; set; }

        [Required(ErrorMessage = "Informe o número de telefone")]
        public string Telefone { get; set; }

        [Required(ErrorMessage = "Informe o RG")]
        public string Rg { get; set; }

        [Required(ErrorMessage = "Informe o CPF")]
        public string Cpf { get; set; }

        public virtual Endereco IdEnderecoNavigation { get; set; }
        public virtual Usuario IdUsuarioNavigation { get; set; }
        public virtual ICollection<Consultum> Consulta { get; set; }
    }
}
