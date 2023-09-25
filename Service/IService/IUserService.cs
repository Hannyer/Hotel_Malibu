using EntityLayer;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Service.IService
{
    public interface IUserService
    {
        List<UserE> GetList(UserE user);
        void Maintenance(UserE user);
    }
}
