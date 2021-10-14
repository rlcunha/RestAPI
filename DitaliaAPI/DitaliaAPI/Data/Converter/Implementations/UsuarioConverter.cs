using DitaliaAPI.Data.Converter.Contract;
using DitaliaAPI.Data.VO;
using DitaliaAPI.Model;
using System.Collections.Generic;
using System.Linq;

namespace DitaliaAPI.Data.Converter.Implementations
{
    public class UsuarioConverter : IParser<UsuarioVO, Usuario>, IParser<Usuario, UsuarioVO>
    {
        public Usuario Parse(UsuarioVO origin)
        {
            if (origin == null) return null;
            return new Usuario
            {
                Id = origin.Id,
                Nome = origin.Nome,
                SobreNome = origin.SobreNome,
                Cpf = origin.Cpf,
                Email = origin.Email,
                Senha = origin.Senha
            };
        }
        public UsuarioVO Parse(Usuario origin)
        {
            if (origin == null) return null;
            return new UsuarioVO
            {
                Id = origin.Id,
                Nome = origin.Nome,
                SobreNome = origin.SobreNome,
                Cpf = origin.Cpf,
                Email = origin.Email,
                Senha = origin.Senha
            };
        }

        public List<Usuario> Parse(List<UsuarioVO> origin)
        {
            if (origin == null) return null;
            return origin.Select(item => Parse(item)).ToList();
        }

        public List<UsuarioVO> Parse(List<Usuario> origin)
        {
            if (origin == null) return null;
            return origin.Select(item => Parse(item)).ToList();
        }
    }
}
