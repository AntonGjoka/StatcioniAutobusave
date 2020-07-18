using StatcioniAutobisave.DAL;
using StatcioniAutobusave.BO;
using StatcioniAutobusave.BO.Interface;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StatcioniAutobusave.BLL
{
    class UserBLL : IBaseCrud<BO.UserBLL>
    {
        private UserDAL userrole;
        public int Add(BO.UserBLL model)
        {
            throw new NotImplementedException();
        }

        public UserBLL Get(int id)
        {
            throw new NotImplementedException();
        }

        public List<BO.UserBLL> GetALl()
        {
            return userrole.GetALl();
        }

        public int Modify(BO.UserBLL model)
        {
            throw new NotImplementedException();
        }

        public int Remove(int id)
        {
            throw new NotImplementedException();
        }
    }
}
