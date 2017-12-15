using System;
using System.Collections.Generic;
using System.Text;
using System.Data;
using System.Data.SqlClient;

namespace VitalSigns.DAL.SQLServer
{
    public class Medications : IBase, IMedication
    {
        #region Procedures
        private const string P_MEDICATIONS_I = "dbo.usp_medications_i";
        private const string P_MEDICATIONS_U = "dbo.usp_medications_u";
        private const string P_MEDICATIONS_D = "dbo.usp_medications_d";
        private const string P_MEDICATIONS_S = "dbo.usp_medications_s";

        #endregion


        #region IBase Members

        public int Insert(object[] parameters)
        {
            SqlCommand command = new SqlCommand();
            command.CommandType = CommandType.StoredProcedure;
            command.CommandText = P_MEDICATIONS_I;
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
            command.CommandText = P_MEDICATIONS_U;
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
            command.CommandText = P_MEDICATIONS_D;
            command.Connection = new ConnectionBuilder().Connect();
            command.Parameters.Add(primaryKey[0]);
            return command.ExecuteNonQuery();
        }

        public System.Data.DataSet Select(object[] parameters)
        {
            SqlCommand command = new SqlCommand();
            command.CommandType = CommandType.StoredProcedure;
            command.CommandText = P_MEDICATIONS_S;
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
