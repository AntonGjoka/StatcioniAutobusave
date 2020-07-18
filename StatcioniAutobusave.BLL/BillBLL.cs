using StatcioniAutobusave.BO;
using StatcioniAutobusave.BLL;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using StatcioniAutobisave.DAL;

namespace StatcioniAutobusave.BLL
{
   public class BillBLL : IBaseCrud<Bill>
    {
        BillDal billDal = new BillDal();
        public int Add(Bill model)
        {

            return billDal.Add(model);
        }

        public Bill Get(int id)
        {
            throw new NotImplementedException();
        }

        public List<Bill> GetALl()
        {
            return billDal.GetALl();
        }

        public int Modify(Bill model)
        {
            throw new NotImplementedException();
        }

        public int Remove(int id)
        {
            throw new NotImplementedException();
        }
    }
}
