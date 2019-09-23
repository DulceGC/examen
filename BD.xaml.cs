using System;
using System.Data;
using System.Data.OleDb;
using System.Data.SqlClient;
using System.Windows;
using MahApps.Metro.Controls;

namespace PrimerParcial
{
    /// <summary>
    /// Lógica de interacción para BD.xaml
    /// </summary>
    public partial class BD : MetroWindow
    {
        public BD()
        {
            InitializeComponent();

            try
            {
                ConnectionDB.ConnectToDataBase();
                DataTable dt = new DataTable("Calificaciones");
                OleDbCommand cmd = ConnectionDB.DisplayTableValues();
                cmd.ExecuteNonQuery();
                OleDbDataAdapter oleDb = ConnectionDB.DisplayTable();
                oleDb.Fill(dt);
                dtgCalificacion.ItemsSource = dt.DefaultView;
                oleDb.Update(dt);

            }
            catch (Exception ex)
            {
                var error = ex.Message;
                //Operador Ternario; es igual a utilizar un if y un else
                MessageBox.Show((ex is SqlException) ? ($"SQL error is: {error}!") : ($"Unexpected Error: {error}!"), "Error", MessageBoxButton.OK, MessageBoxImage.Error);

            }
            finally
            {
                ConnectionDB.DisconnectDataBase();
            }
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            try
            {
                ConnectionDB.ConnectToDataBase();
                DataTable dt = new DataTable("Calificaciones");
                OleDbCommand cmd = ConnectionDB.DisplayTableValues();
                cmd.ExecuteNonQuery();
                OleDbDataAdapter oleDb = ConnectionDB.DisplayTable();
                oleDb.Fill(dt);
                dtgCalificacion.ItemsSource = dt.DefaultView;
                oleDb.Update(dt);

            }
            catch (Exception ex)
            {
                var error = ex.Message;
                //Operador Ternario; es igual a utilizar un if y un else
                MessageBox.Show((ex is SqlException) ? ($"SQL error is: {error}!") : ($"Unexpected Error: {error}!"), "Error", MessageBoxButton.OK, MessageBoxImage.Error);

            }
            finally
            {
                ConnectionDB.DisconnectDataBase();
            }
        }
    }
}
