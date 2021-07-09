using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Main.DataBase
{
    public class Consultas
    {
        private static string cadena = "Server=localhost\\SQLEXPRESS;Database=Veterinaria;Trusted_Connection=true";
        SqlConnection conexion = new SqlConnection(cadena);



        public bool InsertDatos(string Nombre,string amo,string raza,string color,string peso,DateTime fechanacimiento)
        {

           
            conexion.Open();
            SqlCommand command = new SqlCommand("sp_InsertarAnimal",conexion);
            command.CommandType =CommandType.StoredProcedure;
            command.Parameters.AddWithValue("@NombreAnimal",Nombre);
            command.Parameters.AddWithValue("@AmoAnimal",amo);
            command.Parameters.AddWithValue("@RazaAnimal",raza);
            command.Parameters.AddWithValue("@ColorAnimal",color);
            command.Parameters.AddWithValue("@PesoAnimal",peso);
            command.Parameters.AddWithValue("@FechaNacimiento",fechanacimiento);

            int res = command.ExecuteNonQuery();
            conexion.Close();

            return res > 0;
        }
    }
}
