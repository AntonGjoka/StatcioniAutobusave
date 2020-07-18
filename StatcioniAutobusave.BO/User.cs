using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StatcioniAutobusave.BO
{
    public class User:BaseObject
    {
        public int Id { get; set; }
        public string UserName { get; set; }
        public string Password { get; set; }
      
        public DateTime ExpireDate { get; set; }
       

        public Role role { get; set; }

    }
}
