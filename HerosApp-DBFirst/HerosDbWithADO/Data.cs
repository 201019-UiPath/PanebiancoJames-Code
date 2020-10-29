using System;
using Npgsql;

namespace HerosDbWithADO
{
    public class Data
    {
        // path to database
        string connectionStr = "Host=lallah.db.elephantsql.com;Port=5432;Database=nftaixly;Username=nftaixly;Password=KWmPgfSJIVICyNybdRN0X-zWWQxngr8L";
        
        // create a conneciton
        NpgsqlConnection connection;

        // fire the query
        NpgsqlCommand command;

        // get the results
        NpgsqlDataReader reader;


        string query = "select * from Superpeople";
        public void GetSuperPersonConnected()
        {
            try{
                connection = new NpgsqlConnection(connectionStr);
                connection.Open();
                //command = new NpgsqlCommand(connection:connection, cmdText:query); // using named parameters
                command = new NpgsqlCommand(query,connection);
                // return the results of query
                reader = command.ExecuteReader();
                // ExecuteReader reads value, used with select queries
                // ExecuteNonQuary used with Insert, delete and update
                while(reader.Read())
                {
                    System.Console.WriteLine($"{reader[0]} {reader[1]}");
                }
            }
            catch(Exception ex) {
                Console.WriteLine(ex.Message);

                // Log the exception (Serilogg)
            }
            finally {
                connection.Close();
            }
        }
    }
}
