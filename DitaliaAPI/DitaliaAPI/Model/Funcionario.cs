using DitaliaAPI.Model.Base;
using System;
using System.ComponentModel.DataAnnotations.Schema;

namespace DitaliaAPI.Model
{
    [Table("Funcionarios")]
    public class Funcionario : BaseEntity
    {
        [Column("nome")]
        public String Nome { get; set; }
        [Column("sobrenome")]
        public String SobreNome { get; set; }
        [Column("cpf")]
        public long Cpf { get; set; }
        [Column("email")]
        public String Email { get; set; }
        [Column("senha")]
        public String Senha { get; set; }
        [Column("ativo")]
        public String Ativo { get; set; }
    }
}
