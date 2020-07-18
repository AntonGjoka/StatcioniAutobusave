using StatcioniAutobusave.BO;
using StatcioniAutobusave.BO.Interface;
using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using StatcioniAutobusave;
using System.Data;

namespace StatcioniAutobisave.DAL
{
 public class BusDAL : IBaseCrud<Bus>, IConverttoobject<Bus>
    {
        public string connectionString = ConfigurationManager.ConnectionStrings["BusStationManagment"].ConnectionString;
        public int Add(Bus model)
        {
            try
            {
                using (SqlConnection connection=new SqlConnection(connectionString))
                {
                    connection.Open();
                    using (SqlCommand command=new SqlCommand("AddBus",connection))
                    {
                        command.CommandType = CommandType.StoredProcedure;
                        command.Parameters.AddWithValue("kapaciteti", model.Capacity);
                        command.Parameters.AddWithValue("emrikompanise", model.EmriKompanise);

                        int row = command.ExecuteNonQuery();
                        connection.Close();
                        return row;
                    }
                }
            }
            catch (Exception e)
            {

                throw e;
            }
        }

        public Bus Get(int id)
        {
            throw new NotImplementedException();
        }

        public List<Bus> GetALl()
        {
            
                using (SqlHelper.GetConnection())
                {
                    try
                    {

                        List<Bus> result = null;

                        using (SqlCommand command = new SqlCommand("GetAllBus", SqlHelper.GetConnection()))
                        {
                            command.CommandType = CommandType.StoredProcedure;
                            using (SqlDataReader reader = command.ExecuteReader())
                            {
                                result = new List<Bus>();
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
        //public List<Bus> Kerkomeemer(string asd)
        //{
        //    try
        //    {
        //        List<Bus> result = null;
        //        using (SqlConnection connection = new SqlConnection(connectionString))
        //        {
        //            connection.Open();
        //            using (SqlCommand command = new SqlCommand("kerkiminganisja", connection))
        //            {
        //                command.CommandType = CommandType.StoredProcedure;
        //                command.Parameters.AddWithValue("emrikompanise", asd);
                   

        //                int row = command.ExecuteNonQuery();
        //                connection.Close();
        //                return row;
        //            }
        //        }
        //    }
        //    catch (Exception e)
        //    {

        //        throw e;
        //    }
        //}



        public List<Bus> KerkomeEmer(string kerkimi)
        {

            using (SqlHelper.GetConnection())
            {
                try
                {

                    List<Bus> result = null;

                    using (SqlCommand command = new SqlCommand("kerkiminganisja", SqlHelper.GetConnection()))
                    {
                        command.CommandType = CommandType.StoredProcedure;
                        command.Parameters.AddWithValue("emrikompanise", kerkimi);
                        using (SqlDataReader reader = command.ExecuteReader())
                        {
                            result = new List<Bus>();
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

        public int Modify(Bus model)
        {
            throw new NotImplementedException();
        }

        public int Remove(int id)
        {
            try
            {
                using (SqlConnection connection = new SqlConnection(connectionString))
                {
                    connection.Open();
                    using (SqlCommand command = new SqlCommand("DeleteBUS", connection))
                    {

                        command.CommandType = CommandType.StoredProcedure;
                        command.Parameters.AddWithValue("ID", id);
                        int rowaffected = command.ExecuteNonQuery();
                        connection.Close();
                        return rowaffected;

                    };


                };


            }
            catch (Exception e)
            {
                return -1;
            }
        }

        public Bus toObject(SqlDataReader reader)
        {
            Bus bus = new Bus();

            bus.BusID = int.Parse(reader["BusID"].ToString());
            bus.Capacity =(int)reader["Kapaciteti"];
            bus.EmriKompanise = reader["EmriIKompanise"].ToString();
         

            return bus;
        }
    }
}
