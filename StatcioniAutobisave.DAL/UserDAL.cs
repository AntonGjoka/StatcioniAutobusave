using StatcioniAutobusave.BO;
using StatcioniAutobusave.BO.Interface;
using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StatcioniAutobisave.DAL
{
    public class UserDAL : IBaseCrud<User>, IConverttoobject<User>
    {
        public string connectionString = ConfigurationManager.ConnectionStrings["BusStationManagment"].ConnectionString;
        public int Changepassword(string username, string password, string newpassword)
        {
            try
            {
                using (SqlConnection connection = new SqlConnection(connectionString))
                {
                    connection.Open();
                    using (SqlCommand command = new SqlCommand("UpdatePassword", connection))
                    {

                        command.CommandType = CommandType.StoredProcedure;
                        command.Parameters.AddWithValue("username", username);
                        command.Parameters.AddWithValue("Passwordi", password);
                        command.Parameters.AddWithValue("passwordiiri", newpassword);
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

        public int Add(User model)
        {
            try
            {
                using (SqlConnection connection = new SqlConnection(connectionString))
                {
                    connection.Open();
                    using (SqlCommand command = new SqlCommand("AddUser", connection))
                    {
                       
                        command.CommandType = CommandType.StoredProcedure;
                        command.Parameters.AddWithValue("username", model.UserName);
                        command.Parameters.AddWithValue("password", model.Password);
                        command.Parameters.AddWithValue("expiredate", model.ExpireDate);
                        command.Parameters.AddWithValue("roleid", model.role.ID);
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

        public User Get(int id)
        {
            throw new NotImplementedException();
        }








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

                    };


                };


            }
            catch (Exception e)
            {
                return -1;
            }
        }



        public List<User> GetALl()
        {
            using (SqlHelper.GetConnection())
            {
                try
                {
                   
                    List<User> result = null;

                    using (SqlCommand command = new SqlCommand("GetAllUsers", SqlHelper.GetConnection()))
                    {
                        command.CommandType = CommandType.StoredProcedure;
                        using (SqlDataReader reader = command.ExecuteReader())
                        {
                            result = new List<User>();
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
        public User Login(string username,string password)
        {
            User user = null;
            using (var connection = SqlHelper.GetConnection())
            {
                using (var cmdcomand = SqlHelper.Command(connection, "dbo.ups_Authenticate", System.Data.CommandType.StoredProcedure))
                {
                    cmdcomand.Parameters.AddWithValue("username", username);
                    cmdcomand.Parameters.AddWithValue("password", password);
                    using (var reader= cmdcomand.ExecuteReader())
                    {
                        if (reader.Read())
                        {
                            user = toObject(reader);
                        }
                    }
                }
            }
            return user;
        }
        public User toObject(SqlDataReader reader)
        {
            User user = new User();

            user.Id = int.Parse(reader["UsersID"].ToString());
            user.UserName = reader["UserName"].ToString();
            user.Password = reader["UserPass"].ToString();
            user.InsertBy = reader["InsertBy"].ToString();

            return user;

        }

        public int Modify(User model)
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
                    using (SqlCommand command = new SqlCommand("DeleteUser_", connection))
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

       

    }
}
