using StatcioniAutobusave.BO.Interface;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StatcioniAutobusave.BO
{
    public class Bus 
    {
        public int BusID { get; set; }
        public int Capacity { get; set; }
        public string EmriKompanise { get; set; }

    }
}
