using DitaliaAPI.Model.Base;
using System;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text.Json.Serialization;

namespace DitaliaAPI.Model
{
    [Table("Usuarios")]
    public class Usuario : BaseEntity
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



    }
}
