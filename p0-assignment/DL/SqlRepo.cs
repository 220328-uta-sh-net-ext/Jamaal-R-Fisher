using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.Data.SqlClient;
using Models;
using System.Data;

namespace DL
{
    /*
     * in .net, "ADO.NET" is the branding for the Microsoft-provided data access technologies.
     * traditionally it was all under "System.Data" namespace somewhere. these days, we get those
     * assemblies via NuGet.
     */
 
    public class SqlRepo : IRepo
    {
        public const string connectionStringFilePath = "C:/Revature/Jamaal-R-Fisher/p0-assignment/DL/TextFile1.txt";

        readonly string connectionString;

     
        public SqlRepo(string connectionString)
        {
            //connection string file path, reading the text.
            connectionString = File.ReadAllText(connectionStringFilePath);
            this.connectionString = connectionString;
        }

        // specifically when SELECT statements and result sets are involved,
        // there are two approaches to writing the code.
        // this example uses "connected architecture"
        //    which involves - processing the result set while the connection is open
        //                   as you receive it row by row.

        //  in many practical applications, open connections to the database are
        //    a performance bottleneck. so we often prioritize keeping the connection
        //    open for the minimum possible time.

        // so the alternative is called "disconnected architecture"
        //    which involves using a DataAdapter to put the results in a DataSet
        //     then closing the connection
        //     then processing the data in the DataSet.

        // it's also possible to modify the DataSet and then treat those changes
        // as inserts, updates, and deletes to push to the database.

        public List<Restaurant> GetAllRestaurants()
        {
            string commandString = "SELECT * FROM Restaurants;";

            // the connection (SqlConnection): represents a connection to a database.
            // needs a connection string to know how to connect and where the database is.
            // can Open and Close the connection. is IDisposable so you can have it automatically
            // close with the help of a using statement.

            using SqlConnection connection = new(connectionString);

            // the command (SqlCommand): encapsulates some SQL commands to send.
            //  it supports using SqlParameters for protecting from SQL injection.

            using IDbCommand command = new SqlCommand(commandString, connection);
            connection.Open();

            // the data reader (SqlDataReader): represents a response to a SqlCommand
            // having 1 or more result sets (because of 1 or more SELECT statements).
            // the data reader provides each row of the data immediately as it's
            // received over the network.

            using IDataReader reader = command.ExecuteReader();

            // TODO: leaving out the reviews for now

            var restaurants = new List<Restaurant>();

            // reader.Read advances the "cursor" to the next row
            // and returns true if it's not at the end of the data.

            while (reader.Read())
            {
                // different ways to access the data in the current row
                // - reader[columnName]
                //      the return type of this is object. probably need to cast the type.
                // - reader.Get_____(columnIndex)
                //      return type is whatever type you asked for
                // be aware of DBNull

                restaurants.Add(new Restaurant
                {
                    Id = reader.GetInt32(0),
                    Name = reader.GetString(1),
                    Zipcode = reader.GetString(2),
                });
            }
            return restaurants;
        }

        public List<Restaurant> SearchRestaurants()
        {
            string commandString = "SELECT * FROM Restaurants;";

            using SqlConnection connection = new(connectionString);
            using SqlCommand command = new(commandString, connection);
            IDataAdapter adapter = new SqlDataAdapter(command);
            DataSet dataSet = new();
            connection.Open();
            adapter.Fill(dataSet);              // this sends the query. DataAdapter uses a DataReader to read.
            connection.Close();

            // TODO: leaving out the reviews for now

            var restaurants = new List<Restaurant>();
            DataColumn levelColumn = dataSet.Tables[0].Columns[2];
            foreach (DataRow row in dataSet.Tables[0].Rows)
            {
                restaurants.Add(new Restaurant
                {
                    Id = (int)row[0],
                    Name = (string)row[levelColumn],
                    Zipcode = (string)row["Zip Code"]
                });
            }
            return restaurants;
        }

        public Restaurant AddRestaurant(Restaurant restaurantToAdd)
        {
            string commandString = "INSERT INTO Restaurant (Id, Name, ZipCode, UserReview, Rating) " +
                "VALUES (@id, @name, @zipcode, @userreview, @rating);";

            using SqlConnection connection = new(connectionString);
            using SqlCommand command = new(commandString, connection);
            command.Parameters.AddWithValue("@id", restaurantToAdd.Id);
            command.Parameters.AddWithValue("@name", restaurantToAdd.Name);
            command.Parameters.AddWithValue("@zipcode", restaurantToAdd.Zipcode);
            command.Parameters.AddWithValue("@userreview", restaurantToAdd.UserReview);
            command.Parameters.AddWithValue("@rating", restaurantToAdd.Rating);
            connection.Open();
            command.ExecuteNonQuery();

            return restaurantToAdd;
        }

        public void AddReview(int restaurantId, Review reviewToAdd)
        {
            throw new NotImplementedException();
        }

        public List<Restaurant> SearchRestaurants(string searchTerm)
        {
            throw new NotImplementedException();
        }

        public bool IsDuplicate(Restaurant restaurant)
        {
            throw new NotImplementedException();
        }

        public List<Review> GetAllReviews()
        {
            throw new NotImplementedException();
        }
    }
}
