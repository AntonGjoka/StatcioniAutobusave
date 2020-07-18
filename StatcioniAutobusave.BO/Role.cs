using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StatcioniAutobusave.BO
{
  public class Role:BaseObject
    {

        public int ID { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }

        //public virtual List<UserBLL> users { get; set; }

    }
}
