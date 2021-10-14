using System.Collections.Generic;
using DitaliaAPI.Data.VO;

namespace DitaliaAPI.Business
{
    public interface IUsuarioBusiness
    {
        UsuarioVO FindById(int id);
        List<UsuarioVO> FindAll();
        UsuarioVO Create(UsuarioVO usuario);
        UsuarioVO Update(UsuarioVO usuario);
       void Delete(long id);

    }
}
