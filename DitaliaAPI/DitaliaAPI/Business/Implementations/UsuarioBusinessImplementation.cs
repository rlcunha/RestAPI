using DitaliaAPI.Data.Converter.Implementations;
using DitaliaAPI.Data.VO;
using DitaliaAPI.Model;
using DitaliaAPI.Repository;
using System;
using System.Collections.Generic;

namespace DitaliaAPI.Business.Implementations
{
    public class UsuarioBusinessImplementation : IUsuarioBusiness
    {
        private readonly IRepository<Usuario> _Repository;
        private readonly UsuarioConverter _Converter;
 
        public UsuarioBusinessImplementation(IRepository<Usuario> usuarioRepository)
        {
            _Repository = usuarioRepository;
            _Converter = new UsuarioConverter();
        }

        public List<UsuarioVO> FindAll()
        {
            return _Converter.Parse(_Repository.FindAll());
        }

        public UsuarioVO FindById(int id)
        {
            return _Converter.Parse(_Repository.FindById(id)); ;
        }


        public UsuarioVO Create(UsuarioVO usuario)
        {
            try
            {
                var usuarioEntity = _Converter.Parse(usuario);
                usuarioEntity = _Repository.Create(usuarioEntity);
                return _Converter.Parse(usuarioEntity);
            }
            catch (Exception ex)
            {

                throw ex;
            }
            return usuario;
        }
        public UsuarioVO Update(UsuarioVO usuario)
        {

                try
                {

                var usuarioEntity = _Converter.Parse(usuario);
                usuarioEntity = _Repository.Update(usuarioEntity);
                return _Converter.Parse(usuarioEntity);
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
