using DitaliaAPI.Hypermedia;
using DitaliaAPI.HyperMedia.Abstract;
using System;
using System.Collections.Generic;

namespace DitaliaAPI.Data.VO
{
    public class FuncionarioVO : ISupportsHyperMedia
    {
        public long Id { get; set; }
        public String Nome { get; set; }
        public String SobreNome { get; set; }
        public long Cpf { get; set; }
        public String Email { get; set; }
        public String Senha { get; set; }
        public String Ativo { get; set; }
        public List<HyperMediaLink> Links { get; set; } = new List<HyperMediaLink>();
    }
}
