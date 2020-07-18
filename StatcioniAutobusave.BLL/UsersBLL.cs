
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using StatcioniAutobusave.BO;
using StatcioniAutobisave.DAL;

namespace StatcioniAutobusave.BLL
{
    public class UsersBLL : IBaseCrud<User>
    {
        UserDAL userdal = new UserDAL();
        public int Add(User model)
        {
            return userdal.Add(model);
        }
public int changepassword(string username,string password, string newpassword)
        {
            return userdal.Changepassword(username, password, newpassword);
        }
        public User Get(int id)
        {
            throw new NotImplementedException();
        }

        public List<User> GetALl()
        {
            return userdal.GetALl();
        }

        public int Modify(User model)
        {
            throw new NotImplementedException();
        }

        public int Remove(int id)
        {
            return userdal.Remove(id);
        }
    }
}
