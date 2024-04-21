using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SQLite;
using static System.Runtime.InteropServices.JavaScript.JSType;


namespace AutoShop.List
{
    public class CarDatabase
    {
        private SQLiteConnection connection;

        public CarDatabase(string connectionString)
        {
            connection = new SQLiteConnection(connectionString);
        }

        public void OpenConnection()
        {
            if (connection.State != System.Data.ConnectionState.Open)
                connection.Open();
        }

        public void CloseConnection()
        {
            if (connection.State != System.Data.ConnectionState.Closed)
                connection.Close();
        }

        public void SaveCar(string number, string name, string color, string wheels, string interior)
        {
            OpenConnection();
            string selectQuery = "SELECT COUNT(*) FROM Cars WHERE Number = @Number";
            SQLiteCommand selectCommand = new SQLiteCommand(selectQuery, connection);
            selectCommand.Parameters.AddWithValue("@Number", number);
            int count = Convert.ToInt32(selectCommand.ExecuteScalar());

            if (count > 0)
            {
                // Если запись с таким номером уже существует, обновляем данные
                string updateQuery = @"
                UPDATE Cars 
                SET Name = @Name, Color = @Color, Wheels = @Wheels, Interior = @Interior 
                WHERE Number = @Number";
                SQLiteCommand updateCommand = new SQLiteCommand(updateQuery, connection);
                updateCommand.Parameters.AddWithValue("@Name", name);
                updateCommand.Parameters.AddWithValue("@Color", color);
                updateCommand.Parameters.AddWithValue("@Wheels", wheels);
                updateCommand.Parameters.AddWithValue("@Interior", interior);
                updateCommand.Parameters.AddWithValue("@Number", number);
                updateCommand.ExecuteNonQuery();
            }
            else
            {
                // Если записи с таким номером не существует, вставляем новую запись
                string insertQuery = @"
                    INSERT INTO Cars (Number, Name, Color, Wheels, Interior) 
                    VALUES (@Number, @Name, @Color, @Wheels, @Interior)";
                SQLiteCommand insertCommand = new SQLiteCommand(insertQuery, connection);
                insertCommand.Parameters.AddWithValue("@Number", number);
                insertCommand.Parameters.AddWithValue("@Name", name);
                insertCommand.Parameters.AddWithValue("@Color", color);
                insertCommand.Parameters.AddWithValue("@Wheels", wheels);
                insertCommand.Parameters.AddWithValue("@Interior", interior);
                insertCommand.ExecuteNonQuery();
            }

            CloseConnection();
        }
    }
}
