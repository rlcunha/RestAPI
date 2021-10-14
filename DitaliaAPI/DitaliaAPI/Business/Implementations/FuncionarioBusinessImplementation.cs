using DitaliaAPI.Data.Converter.Implementations;
using DitaliaAPI.Data.VO;
using DitaliaAPI.Model;
using DitaliaAPI.Repository;
using System;
using System.Collections.Generic;

namespace DitaliaAPI.Business.Implementations
{
    public class FuncionarioBusinessImplementation : IFuncionarioBusiness
    {
        private readonly IRepository<Funcionario> _Repository;
        private readonly FuncionarioConverter _Converter;

        public FuncionarioBusinessImplementation(IRepository<Funcionario> funcionarioRepository)
        {
            _Repository = funcionarioRepository;
            _Converter = new FuncionarioConverter();
        }

        public List<FuncionarioVO> FindAll()
        {
            return _Converter.Parse(_Repository.FindAll());
        }

        public FuncionarioVO FindById(int id)
        {
            return _Converter.Parse(_Repository.FindById(id));
        }


        public FuncionarioVO Create(FuncionarioVO funcionario)
        {
            try
            {
                var funcionarioEntity = _Converter.Parse(funcionario);
                funcionarioEntity = _Repository.Create(funcionarioEntity);
                return _Converter.Parse(funcionarioEntity);
            }
            catch (Exception ex)
            {

                throw ex;
            }
            return funcionario;
        }
        public FuncionarioVO Update(FuncionarioVO funcionario)
        {
                try
                {
                var funcionarioEntity = _Converter.Parse(funcionario);
                funcionarioEntity = _Repository.Update(funcionarioEntity);
                return _Converter.Parse(funcionarioEntity);
                 }
                catch (Exception ex)
                {

                    throw new System.Exception("Erro ao atualizar dados"); ;
                }

        }
        public void Delete(long id)
        {
                try
                {
                    _Repository.Delete(id);
                }
                catch (Exception)
                {

                    throw;
                }


        }

    }
}
