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
    public class RoleDAL : IBaseCrud<Role>,IConverttoobject<Role>


    {
        //public string _connectionString = "Server=NOTI-TONI\\SQL;Database=Statcioni i autobusave;";
        public string connectionString = ConfigurationManager.ConnectionStrings["BusStationManagment"].ConnectionString;
        public int Add(Role model)
        {
            try
            {
                using (SqlConnection connection = new SqlConnection(connectionString))
                {
                    using (SqlCommand command = new SqlCommand("AddRole", connection))
                    {
                        connection.Open();
                        command.CommandType = CommandType.StoredProcedure;
                        command.Parameters.AddWithValue("name", model.Name);

                        command.Parameters.AddWithValue("Description", model.Description);
                        int rowaffected = command.ExecuteNonQuery();
                        connection.Close();
                        return rowaffected;
                        
                    }
                    
                    
                }
                

            }
            catch ( Exception e)
            {
                return -1;
            }
        }

        public Role Get(int id)
        {
            try
            {
                Role role = null;
                using (SqlConnection connection = new SqlConnection(connectionString))
                {
                    connection.Open();
                    using (SqlCommand command = new SqlCommand("usp_Roles_GetById", connection))
                    {
                        command.Parameters.AddWithValue("RoleID", id);

                        using (SqlDataReader reader = command.ExecuteReader())
                        {
                            if (reader.Read())
                            {

                                // role = new Role();
                                //role.ID = int.Parse(reader["ID"].ToString());
                                //role.Name = reader["Name"].ToString();
                                //if (reader["Description"] != null)
                                //{
                                //    role.Description = reader["Descripton"].ToString();

                                //}
                                role = toObject(reader);
                               

                            }
                        }
                    }
                    return role;

                }
            }
            catch (Exception)
            {
                return null;
            }

        }

        public List<Role> GetALl()
        {
            using (SqlHelper.GetConnection())
            {
                try
                {

                    List<Role> result = null;

                    using (SqlCommand command = new SqlCommand("usp_Roles_GetAll", SqlHelper.GetConnection()))
                    {
                        command.CommandType = CommandType.StoredProcedure;
                        using (SqlDataReader reader = command.ExecuteReader())
                        {
                            result = new List<Role>();
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

        public int Modify(Role model)
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
                    using (SqlCommand command = new SqlCommand("Deleterole", connection))
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

        public Role toObject(SqlDataReader reader)
        {
            Role role = new Role();
          
            role.ID = int.Parse(reader["RoleID"].ToString());
            role.Name = reader["RoleName"].ToString();           
            role.Description = reader["Description"].ToString();


            return role;
         
        }
    }
}
