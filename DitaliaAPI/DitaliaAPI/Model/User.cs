using DitaliaAPI.Model.Base;
using System;
using System.ComponentModel.DataAnnotations.Schema;

namespace DitaliaAPI.Model
{
    [Table("Users")]
    public class User : BaseEntity
    {
        //[ForeignKey]
        [Column("id")]
        public String id { get; set; }
        [Column("UserName")]
        public String UserName{ get; set; }
        [Column("FullName")]
        public long FullName { get; set; }
        [Column("Password")]
        public String Password { get; set; }
        [Column("RefreshToken")]
        public String RefreshTokenSenha { get; set; }
        [Column("RefreshTokenExpiryTime")]
        public String RefreshTokenExpiryTime { get; set; }



    }
}
