using Restaurants.DataAccess.Entities;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Restaurants.DataAccess.Repositories
{
    public class RestaurantRepository : BaseRepository
    {
        /// <summary>
        /// Get a Restaurant object with a specified ID
        /// </summary>
        /// <param name="id">The Restourant ID in the DB </param>
        /// <returns>A Restourant object if a record with the specified ID exists; otherwise return null</returns>
        public Restaurant GetByID(int id)
        {
            Restaurant result = null;
            using (SqlConnection cnn = new SqlConnection(base.ConnectionString))
            {
                cnn.Open();

                string query = @"
                                SELECT r.ID
                                      ,r.CategoryID
	                                  ,cat.Name CategoryName
                                      ,r.CityID
	                                  ,c.Name CityName
                                      ,r.Name
                                      ,r.Description
                                      ,r.ImageName
                                      ,r.DateCreated
                                  FROM [dbo].[Restaurants] r
                                  JOIN Cities c on c.ID = r.CityID
                                  JOIN Categories cat on cat.ID = r.CategoryID
                                  WHERE r.ID = @id";
                using (SqlCommand command = new SqlCommand(query, cnn))
                {
                    command.CommandType = CommandType.Text;
                    command.Parameters.Add(new SqlParameter("@id", SqlDbType.Int));
                    command.Parameters[0].Value = id;

                    SqlDataReader commandResult = command.ExecuteReader();
                    if (commandResult.Read())
                    {
                        result = new Restaurant();
                        result.ID = commandResult.GetInt32(commandResult.GetOrdinal("ID"));
                        result.Name = commandResult["Name"] as string;
                        result.CategoryID = commandResult.GetInt32(commandResult.GetOrdinal("CategoryID"));
                        result.CategoryName = commandResult.GetString(commandResult.GetOrdinal("CategoryName"));
                        result.CityID = commandResult.GetInt32(commandResult.GetOrdinal("CityID"));
                        result.CityName = commandResult.GetString(commandResult.GetOrdinal("CityName"));
                        result.Description = commandResult.GetString(commandResult.GetOrdinal("Description"));
                        result.ImageName = commandResult["ImageName"] as string;
                        result.DateCreated = commandResult.GetDateTime(commandResult.GetOrdinal("DateCreated"));
                    }
                }

                cnn.Close(); // this is not needed when using "using"
            }
            return result;
        }

        /// <summary>
        /// Gets all Restaurants in the DB
        /// </summary>
        /// <returns>A List of Restaurants</returns>
        public List<Restaurant> GetAll()
        {
            List<Restaurant> result = new List<Restaurant>();
            using (SqlConnection cnn = new SqlConnection(base.ConnectionString))
            {
                cnn.Open();

                string query = @"
                                SELECT r.ID
                                      ,r.CategoryID
	                                  ,cat.Name CategoryName
                                      ,r.CityID
	                                  ,c.Name CityName
                                      ,r.Name
                                      ,r.Description
                                      ,r.ImageName
                                      ,r.DateCreated
                                  FROM [dbo].[Restaurants] r
                                  JOIN Cities c on c.ID = r.CityID
                                  JOIN Categories cat on cat.ID = r.CategoryID";
                using (SqlCommand command = new SqlCommand(query, cnn))
                {
                    command.CommandType = CommandType.Text;

                    SqlDataReader commandResult = command.ExecuteReader();
                    while (commandResult.Read())
                    {
                        Restaurant restaurant = new Restaurant();
                        restaurant.ID = commandResult.GetInt32(commandResult.GetOrdinal("ID"));
                        restaurant.Name = commandResult["Name"] as string;
                        restaurant.CategoryID = commandResult.GetInt32(commandResult.GetOrdinal("CategoryID"));
                        restaurant.CategoryName = commandResult.GetString(commandResult.GetOrdinal("CategoryName"));
                        restaurant.CityID = commandResult.GetInt32(commandResult.GetOrdinal("CityID"));
                        restaurant.CityName = commandResult.GetString(commandResult.GetOrdinal("CityName"));
                        restaurant.Description = commandResult.GetString(commandResult.GetOrdinal("Description"));
                        restaurant.ImageName = commandResult["ImageName"] as string;
                        restaurant.DateCreated = commandResult.GetDateTime(commandResult.GetOrdinal("DateCreated"));
                        result.Add(restaurant);
                    }
                }

                cnn.Close(); // this is not needed when using "using"
            }
            return result;
        }

        /// <summary>
        /// Get all Restaurants in a specific City
        /// </summary>
        /// <param name="cityID">The City ID to filter the Restaurants</param>
        /// <returns>A List of Restourants</returns>
        public List<Restaurant> GetByCityID(int cityID)
        {
            List<Restaurant> result = new List<Restaurant>();
            using (SqlConnection cnn = new SqlConnection(base.ConnectionString))
            {
                cnn.Open();

                string query = @"
                                SELECT r.ID
                                      ,r.CategoryID
	                                  ,cat.Name CategoryName
                                      ,r.CityID
	                                  ,c.Name CityName
                                      ,r.Name
                                      ,r.Description
                                      ,r.ImageName
                                      ,r.DateCreated
                                  FROM [dbo].[Restaurants] r
                                  JOIN Cities c on c.ID = r.CityID
                                  JOIN Categories cat on cat.ID = r.CategoryID
                                  WHERE r.CityID = @cityID";
                using (SqlCommand command = new SqlCommand(query, cnn))
                {
                    command.CommandType = CommandType.Text;
                    command.Parameters.Add(new SqlParameter("@cityID", SqlDbType.Int));
                    command.Parameters[0].Value = cityID;

                    SqlDataReader commandResult = command.ExecuteReader();
                    while (commandResult.Read())
                    {
                        Restaurant restaurant = new Restaurant();
                        restaurant.ID = commandResult.GetInt32(commandResult.GetOrdinal("ID"));
                        restaurant.Name = commandResult["Name"] as string;
                        restaurant.CategoryID = commandResult.GetInt32(commandResult.GetOrdinal("CategoryID"));
                        restaurant.CategoryName = commandResult.GetString(commandResult.GetOrdinal("CategoryName"));
                        restaurant.CityID = commandResult.GetInt32(commandResult.GetOrdinal("CityID"));
                        restaurant.CityName = commandResult.GetString(commandResult.GetOrdinal("CityName"));
                        restaurant.Description = commandResult.GetString(commandResult.GetOrdinal("Description"));
                        restaurant.ImageName = commandResult["ImageName"] as string;
                        restaurant.DateCreated = commandResult.GetDateTime(commandResult.GetOrdinal("DateCreated"));
                        result.Add(restaurant);
                    }
                }

                // get the clild entities

                cnn.Close(); // this is not needed when using "using"
            }
            return result;
        }

        /// <summary>
        /// Create a new Restaurant record in the DB
        /// Note: The ID of the Restaurant is assigned after the record is inserted
        /// </summary>
        /// <param name="restaurant">The Restaurant object to insert</param>
        public void Create(Restaurant restaurant)
        {
            SqlConnection cnn = null;
            try
            {
                // An example to manually create SqlConnection; It is rarely used
                // Usually you should use with "using" operator
                cnn = new SqlConnection(base.ConnectionString);

                cnn.Open();

                string query = @"
                                INSERT INTO Restaurants(CategoryID, CityID, Name, [Description], ImageName, DateCreated)
                                OUTPUT INSERTED.Id 
                                VALUES(@categoryID, @cityID, @name, @description, @imageName, @datecreated);";

                SqlCommand command = new SqlCommand(query, cnn);

                command.CommandType = CommandType.Text;
                command.Parameters.Add(new SqlParameter("@categoryID", SqlDbType.Int));
                command.Parameters[0].Value = restaurant.CategoryID;
                command.Parameters.Add(new SqlParameter("@cityID", SqlDbType.Int));
                command.Parameters[1].Value = restaurant.CityID;
                command.Parameters.Add(new SqlParameter("@name", SqlDbType.NVarChar));
                command.Parameters[2].Value = restaurant.Name;
                command.Parameters.Add(new SqlParameter("@description", SqlDbType.NText));
                command.Parameters[3].Value = restaurant.Description;
                command.Parameters.Add(new SqlParameter("@imageName", SqlDbType.NVarChar));
                command.Parameters[4].Value = restaurant.ImageName;
                command.Parameters.Add(new SqlParameter("@datecreated", SqlDbType.DateTime));
                command.Parameters[5].Value = DateTime.Now;

                //throw new Exception("can not create a new record");

                // set the ID to the object from the query result
                int id = (int)command.ExecuteScalar();
                restaurant.ID = id;

                // It is important to Dispose the Command object
                if (command != null)
                {
                    command.Dispose();
                }
            }
            catch (Exception ex)
            {
                //exceptions are bubbled
                throw;
            }
            finally
            {
                //close and dispose are always called
                if (cnn != null)
                {
                    if (cnn.State == ConnectionState.Open)
                    {
                        cnn.Close();
                    }
                    cnn.Dispose();
                }
            }

        }

        /*
         public void DeleteById(int id){}

         public void Delete(Restaurant restaurant){}
         */

        public void DeleteByID(int id)
        {
            using (SqlConnection cnn = new SqlConnection(base.ConnectionString))
            {
                cnn.Open();

                string cmdText = "DeleteRestaurant";
                using (SqlCommand command = new SqlCommand(cmdText, cnn))
                {
                    command.CommandType = CommandType.StoredProcedure;
                    command.Parameters.Add(new SqlParameter("@id", SqlDbType.Int));
                    command.Parameters[0].Value = id;

                    command.ExecuteNonQuery();
                }

                cnn.Close(); // this is not needed when using "using"
            }
        }
    }
}
