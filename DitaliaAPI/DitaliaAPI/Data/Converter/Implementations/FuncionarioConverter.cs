using DitaliaAPI.Data.Converter.Contract;
using DitaliaAPI.Data.VO;
using DitaliaAPI.Model;
using System.Collections.Generic;
using System.Linq;

namespace DitaliaAPI.Data.Converter.Implementations
{
    public class FuncionarioConverter : IParser<FuncionarioVO, Funcionario>, IParser<Funcionario, FuncionarioVO>
    {
        public Funcionario Parse(FuncionarioVO origin)
        {
            if (origin == null) return null;
            return new Funcionario
            {
                Id = origin.Id,
                Nome = origin.Nome,
                SobreNome = origin.SobreNome,
                Cpf = origin.Cpf,
                Email = origin.Email,
                Senha = origin.Senha,
                Ativo = origin.Ativo
            };
        }
        public FuncionarioVO Parse(Funcionario origin)
        {
            if (origin == null) return null;
            return new FuncionarioVO
            {
                Id = origin.Id,
                Nome = origin.Nome,
                SobreNome = origin.SobreNome,
                Cpf = origin.Cpf,
                Email = origin.Email,
                Senha = origin.Senha,
                Ativo = origin.Ativo
            };
        }

        public List<Funcionario> Parse(List<FuncionarioVO> origin)
        {
            if (origin == null) return null;
            return origin.Select(item => Parse(item)).ToList();
        }

        public List<FuncionarioVO> Parse(List<Funcionario> origin)
        {
            if (origin == null) return null;
            return origin.Select(item => Parse(item)).ToList();
        }
    }
}
