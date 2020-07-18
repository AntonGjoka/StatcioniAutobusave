using StatcioniAutobusave.BO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using StatcioniAutobisave.DAL;

namespace StatcioniAutobusave.BLL
{
  public  class BusBLL : IBaseCrud<Bus>
    {
        BusDAL busdal = new BusDAL();

        public int Add(Bus model)
        {
           return busdal.Add(model);
        }

        public Bus Get(int id)
        {
            throw new NotImplementedException();
        }

        public List<Bus> GetALl()
        {
           return  busdal.GetALl();
        }
       
        public List<Bus> KerkomeEmer(string str)
        {
            return busdal.KerkomeEmer(str);
        }
        public int Modify(Bus model)
        {
            throw new NotImplementedException();
        }

        public int Remove(int id)
        {
            return busdal.Remove(id);
        }
    }
}
