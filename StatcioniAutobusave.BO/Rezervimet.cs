using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StatcioniAutobusave.BO
{
    public class Rezervimet
    {
        public int rezervimetId { get; set; }
        public string emrirezervimit { get; set; }
        public virtual Bill bileta { get; set; }

    }
    
}
