using System;
using System.Data.SqlClient;

namespace ejerBaseDeDatos01
{
    class Program
    {
        static void Main(string[] args)
        {
            SqlConnection conexion;
            SqlCommand command;
            SqlDataReader reader;
            String connectionString = "Server=localhost;Database=ejercicio1;Trusted_Connection=True";


            //conexion = new SqlConnection(connectionString);
            //command = new SqlCommand();

            //command.CommandType = System.Data.CommandType.Text;

            //command.Connection = conexion;
            ////Le paso la linea SQL
            //command.CommandText = "SELECT * FROM EMPLEADOS";
            ////Abro la conexion
            //conexion.Open();

            //reader = command.ExecuteReader();

            //try
            //{
            //    while(reader.Read())
            //    {
            //        string nombre = reader["nombre"].ToString();
            //        double sueldo = (double)reader[4];
            //        int id_puesto = reader.GetInt32(3);

            //        Console.WriteLine($"{id_puesto}, {nombre} : {sueldo}");
            //    }
            //}
            //catch(Exception e)
            //{
            //    Console.WriteLine(e.Message);
            //}
            //finally
            //{
            //    conexion.Close();
            //}




            //SqlConnection connection;
            //SqlCommand command2;

            //connection = new SqlConnection(connectionString);

            //connection.Open();

            //String consulta = "INSERT INTO EMPLEADOS VALUES (6, 'Igor', 'England', 5, 283558.85, 1, '2013-03-28', NULL, 'iengland@hotmail.com')";

            //command2 = new SqlCommand(consulta, connection);

            //int filasAfectadas = command2.ExecuteNonQuery();
            //if(filasAfectadas == 0)
            //{
            //    Console.WriteLine("No se Agregaron filas");
            //}
            //else
            //{
            //    Console.WriteLine("Se agregaron {0} filas", filasAfectadas);
            //}
            //connection.Close();



        }
    }
}
