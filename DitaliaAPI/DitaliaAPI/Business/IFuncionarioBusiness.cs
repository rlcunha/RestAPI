using System.Collections.Generic;
using DitaliaAPI.Data.VO;

namespace DitaliaAPI.Business
{
    public interface IFuncionarioBusiness
    {
        FuncionarioVO FindById(int id);
        List<FuncionarioVO> FindAll();
        FuncionarioVO Create(FuncionarioVO funcionario);
        FuncionarioVO Update(FuncionarioVO funcionario);
       void Delete(long id);

    }
}
