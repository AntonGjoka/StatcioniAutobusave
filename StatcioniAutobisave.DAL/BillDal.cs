using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using StatcioniAutobusave.BO;
using StatcioniAutobusave.BO.Interface;

namespace StatcioniAutobisave.DAL
{
  public  class BillDal : IBaseCrud<Bill>, IConverttoobject<Bus>
    {


        public string connectionString = ConfigurationManager.ConnectionStrings["BusStationManagment"].ConnectionString;
        public int Add(Bill model)
        {
            try
            {
                using (SqlConnection connection = new SqlConnection(connectionString))
                {
                    using (SqlCommand command = new SqlCommand("AddBill ", connection))
                    {
                        connection.Open();
                        command.CommandType = CommandType.StoredProcedure;
                        command.Parameters.AddWithValue("busid", model.bus.BusID);
                        command.Parameters.AddWithValue("qmimi", model.Cmimi);
                        command.Parameters.AddWithValue("kohamberritjes ", model.KohaMberritjes);
                        command.Parameters.AddWithValue("kohanisjes", model.KohaNisjes);
                        command.Parameters.AddWithValue("kontakti", model.NrKontaktit);

                        
                        int rowaffected = command.ExecuteNonQuery();
                        connection.Close();
                        return rowaffected;

                    }


                }


            }
            catch (Exception e)
            {
                return -1;
            }
        }

        public Bill Get(int id)
        {
            throw new NotImplementedException();
        }

        public List<Bill> GetALl()
        {
            using (SqlHelper.GetConnection())
            {
                try
                {

                    List<Bill> result = null;

                    using (SqlCommand command = new SqlCommand("GetAllBills", SqlHelper.GetConnection()))
                    {
                        command.CommandType = CommandType.StoredProcedure;
                        using (SqlDataReader reader = command.ExecuteReader())
                        {
                            result = new List<Bill>();
                            while (reader.Read())
                            {

                                result.Add(toObject(reader));

                            }
                        }
                    }
                    return result;

                }
                catch (Exception)
                {
                    return null;
                }
            }
        }

        public int Modify(Bill model)
        {
            throw new NotImplementedException();
        }

        public int Remove(int id)
        {
            throw new NotImplementedException();
        }

        public Bill toObject(SqlDataReader reader)
        {
            Bill bill = new Bill();
            bill.billid = int.Parse(reader["BiletaID"].ToString());
            //bill.bus.BusID = int.Parse(reader["BusID"].ToString());
            bill.Cmimi = decimal.Parse(reader["Cmimi"].ToString());
            bill.KohaMberritjes =DateTime.Parse( reader["KohaMberritjes"].ToString());
            bill.KohaNisjes= DateTime.Parse(reader["KohaNisjes"].ToString());
            bill.NrKontaktit = reader["NumriKontaktues"].ToString();
           

            return bill;
        }

        Bus IConverttoobject<Bus>.toObject(SqlDataReader reader)
        {
            throw new NotImplementedException();
        }
    }
}
