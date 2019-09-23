using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Configuration;
using System.Data.OleDb;

namespace PrimerParcial
{
    public static class ConnectionDB
    {
        public static string StrConnection()
        {

            return new OleDbConnection().ConnectionString = ConfigurationManager.ConnectionStrings["Connection"].ToString();
        }

        // abrir conexión a Base de Datos de Access
        public static void ConnectToDataBase()
        {
            ConnectionObject.Conn = new OleDbConnection(ConnectionDB.StrConnection());
            DisconnectDataBase();
            ConnectionObject.Conn.Open();
        }

        // cerrar conexión a Base de Datos de Access
        public static void DisconnectDataBase()
        {
            if (ConnectionObject.Conn != null && ConnectionObject.Conn.State == ConnectionState.Open)
            {
                ConnectionObject.Conn.Close();
            }
        }

        // Query para insertar datos
        public static OleDbCommand InsertCalificacionAlumno()
        {
            ConnectionDB.ConnectToDataBase();
            return new OleDbCommand("INSERT INTO Calificaciones ([Carrera],[Nombre],[Id],[Calificacion],[Fecha]) values (@Carrera,@Nombre,@Id,@Calificacion,@Fecha)", ConnectionObject.Conn);
        }

        // Query para ver datos
        public static OleDbCommand DisplayTableValues()
        {
            return new OleDbCommand("SELECT * FROM Calificaciones", ConnectionObject.Conn);
        }

        public static OleDbDataAdapter DisplayTable()
        {
            return new OleDbDataAdapter("SELECT * FROM Calificaciones", ConnectionObject.Conn);
        }
    }
}
