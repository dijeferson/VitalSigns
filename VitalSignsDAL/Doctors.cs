using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Sql;
using System.Data.SqlClient;
using System.Text;
using VitalSigns.DAL;

namespace VitalSigns.DAL.SQLServer
{
    public class Doctors : IBase, IDoctor
    {
        #region Procedures
        private const string P_DOCTORS_I = "dbo.usp_doctors_i";
        private const string P_DOCTORS_U = "dbo.usp_doctors_u";
        private const string P_DOCTORS_D = "dbo.usp_doctors_d";
        private const string P_DOCTORS_S = "dbo.usp_doctors_s";

        #endregion


        #region IBase Members

        public int Insert(object[] parameters)
        {
            SqlCommand command = new SqlCommand();
            command.CommandType = CommandType.StoredProcedure;
            command.CommandText = P_DOCTORS_I;
            command.Connection = new ConnectionBuilder().Connect();
            command.Parameters.Add(parameters[0]);
            command.Parameters.Add(parameters[1]);
            command.Parameters.Add(parameters[2]);
            return command.ExecuteNonQuery();
        }

        public int Update(object[] primaryKey, object[] parameters)
        {
            SqlCommand command = new SqlCommand();
            command.CommandType = CommandType.StoredProcedure;
            command.CommandText = P_DOCTORS_U;
            command.Connection = new ConnectionBuilder().Connect();
            command.Parameters.Add(primaryKey[0]);
            command.Parameters.Add(parameters[0]);
            command.Parameters.Add(parameters[1]);
            command.Parameters.Add(parameters[2]);
            return command.ExecuteNonQuery();
        }

        public int Delete(object[] primaryKey)
        {
            SqlCommand command = new SqlCommand();
            command.CommandType = CommandType.StoredProcedure;
            command.CommandText = P_DOCTORS_D;
            command.Connection = new ConnectionBuilder().Connect();
            command.Parameters.Add(primaryKey[0]);
            return command.ExecuteNonQuery();
        }

        public System.Data.DataSet Select(object[] parameters)
        {
            SqlCommand command = new SqlCommand();
            command.CommandType = CommandType.StoredProcedure;
            command.CommandText = P_DOCTORS_S;
            command.Connection = new ConnectionBuilder().Connect();
            command.Parameters.Add(parameters[0]);
            SqlDataReader dr = command.ExecuteReader();
            DataSet ds = new DataSet();
            ds.Tables[0].Load(dr);
            return ds;
        }

        #endregion
    }
}
