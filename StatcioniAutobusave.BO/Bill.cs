using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StatcioniAutobusave.BO
{
   public class Bill
    {
        public int billid { get; set; }
        public Bus bus { get; set; }
        public DateTime KohaNisjes  { get; set; }
        public DateTime KohaMberritjes { get; set; }
        public decimal Cmimi { get; set; }
        public string NrKontaktit { get; set; }

    }
}
