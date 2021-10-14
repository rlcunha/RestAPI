using DitaliaAPI.Data.VO;
using DitaliaAPI.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace DitaliaAPI.Repository
{
    public interface IUserRepository
    {
        User ValidateCredentials(UserVO user);
    }
}
