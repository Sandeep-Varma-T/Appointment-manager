using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TirumalarajuKilaniMungiProject
{
    //created by TirumalarajuKilaniMungi
    //This is the Data Access Layer which communicates with the database
    internal class DrConsultDataClass
    {

        //Declaring Connection String and SqlConnection object
        private SqlConnection sqlConnection = null;
        string connectionString = ConfigurationManager.ConnectionStrings["TirumalarajuKilaniMungiProject.Properties.Settings.drConsultDBConnectionString"].ConnectionString;

        //Method to get sqlConnection if exists or create a new one if not

        private SqlConnection getSqlConnection()
        {
            if (sqlConnection == null)  sqlConnection = new SqlConnection(connectionString);
            return sqlConnection;
        }//getConnection

        //Method to Open the connection

        private void OpenConnection()
        {
            if (sqlConnection.State == ConnectionState.Closed) {
                    sqlConnection.Open(); }
        }//OpenConnection

        //Method to Close the Connection

        private void CloseConnection() { 
            if (sqlConnection.State == ConnectionState.Open) { sqlConnection.Close();}
        }//CloseConnection

        public DataSet ExecuteQuery(string sqlQuery)
        {

            DataSet ds = new DataSet();
            this.getSqlConnection();
            this.OpenConnection();
            SqlDataAdapter sqlDataAdapter = new SqlDataAdapter(sqlQuery , sqlConnection);
            sqlDataAdapter.Fill(ds);
            this.CloseConnection();
            return ds;

        }//ExecuteQuery

        public int ExecuteNonQuery(string sqlQuery,CommandType cmdType, SqlParameter param1 = null, SqlParameter param2 = null, SqlParameter param3 = null, SqlParameter param4 = null, SqlParameter param5 = null, SqlParameter param6 = null, SqlParameter param7 = null, SqlParameter param8 = null, SqlParameter param9 = null, SqlParameter param10 = null, SqlParameter param11 = null, SqlParameter param12 = null, SqlParameter param13 = null, SqlParameter param14 = null)
        {

            SqlCommand sqlCommand = new SqlCommand(sqlQuery,this.getSqlConnection());
            sqlCommand.CommandType = cmdType;
            if (param1 != null) sqlCommand.Parameters.Add(param1);
            if (param2 != null) sqlCommand.Parameters.Add(param2);
            if (param3 != null) sqlCommand.Parameters.Add(param3);
            if (param4 != null) sqlCommand.Parameters.Add(param4);
            if (param5 != null) sqlCommand.Parameters.Add(param5);
            if (param6 != null) sqlCommand.Parameters.Add(param6);
            if (param7 != null) sqlCommand.Parameters.Add(param7);
            if (param8 != null) sqlCommand.Parameters.Add(param8);
            if (param9 != null) sqlCommand.Parameters.Add(param9);
            if (param10!= null) sqlCommand.Parameters.Add(param10);
            if (param11!= null) sqlCommand.Parameters.Add(param11);
            if (param12 != null) sqlCommand.Parameters.Add(param12);
            if (param13 != null) sqlCommand.Parameters.Add(param13);
            if (param14 != null) sqlCommand.Parameters.Add(param14);

            try
            {
                this.OpenConnection();
                return sqlCommand.ExecuteNonQuery();
            }
            catch(Exception ex)
            {
                throw ex;
            }

            finally
            {
                this.CloseConnection();
                sqlCommand.Dispose(); 
            }

        }//NonQuery

    }//class
}//namespace
