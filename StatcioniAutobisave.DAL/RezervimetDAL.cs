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
    public class RezervimetDAL : IBaseCrud<Rezervimet>, IConverttoobject<Rezervimet>
    {
        public string connectionString = ConfigurationManager.ConnectionStrings["BusStationManagment"].ConnectionString;
        public int Add(Rezervimet model)
        {
            try
            {
                using (SqlConnection connection = new SqlConnection(connectionString))
                {
                    connection.Open();
                    using (SqlCommand command = new SqlCommand("InsertoRezervimet", connection))
                    {
                        command.CommandType = CommandType.StoredProcedure;
                        command.Parameters.AddWithValue("emrirezervimit", model.emrirezervimit);
                        command.Parameters.AddWithValue("biletaid", model.bileta.billid);

                        int row = command.ExecuteNonQuery();
                        connection.Close();
                        return row;
                        //dasd
                    }
                }
            }
            catch (Exception e)
            {

                throw e;
            }
        }

        public Rezervimet Get(int id)
        {
            throw new NotImplementedException();
        }

        public List<Rezervimet> GetALl()
        {
            using (SqlHelper.GetConnection())
            {
                try
                {

                    List<Rezervimet> result = null;

                    using (SqlCommand command = new SqlCommand("dbo.getallrezervime", SqlHelper.GetConnection()))
                    {
                        command.CommandType = CommandType.StoredProcedure;
                        using (SqlDataReader reader = command.ExecuteReader())
                        {
                            result = new List<Rezervimet>();
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

        public int Modify(Rezervimet model)
        {
            throw new NotImplementedException();
        }

        public int Remove(int id)
        {
            throw new NotImplementedException();
        }

        public Rezervimet toObject(SqlDataReader reader)
        {

            Rezervimet rezervimet = new Rezervimet();

            rezervimet.rezervimetId = int.Parse(reader["RezervimetID"].ToString());
            rezervimet.emrirezervimit = reader["EmriiRezervimit"].ToString();


            return rezervimet;
        }
    }
}
