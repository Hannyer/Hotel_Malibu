using Repository.IRepository;
using Service.IService;
using EntityLayer;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Service.Service
{
    public class UserService : IUserService
    {
        private IUserRepository _userRepository;
        public UserService(IUserRepository iUserRepository) { 
        this._userRepository = iUserRepository;
        }
        public List<UserE> GetList(UserE user)
        {
            try
            {
                return _userRepository.GetList(user);
            }
            catch (Exception ex)
            {

                throw ex;
            }
        }

        public void Maintenance(UserE user)
        {
            throw new NotImplementedException();
        }
    }
}
