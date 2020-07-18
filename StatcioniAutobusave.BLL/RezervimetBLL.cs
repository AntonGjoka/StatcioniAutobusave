using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using StatcioniAutobisave.DAL;
using StatcioniAutobusave.BO;
using StatcioniAutobusave.BO.Interface;

namespace StatcioniAutobusave.BLL
{
   public class RezervimetBLL : IBaseCrud<Rezervimet>
    {
        RezervimetDAL rezdal = new RezervimetDAL();
        public int Add(Rezervimet model)
        {

            return rezdal.Add(model);

        }

        public Rezervimet Get(int id)
        {
            throw new NotImplementedException();
        }

        public List<Rezervimet> GetALl()
        {
           return rezdal.GetALl();
        }

        public int Modify(Rezervimet model)
        {
            throw new NotImplementedException();
        }

        public int Remove(int id)
        {
            throw new NotImplementedException();
        }
    }
}
