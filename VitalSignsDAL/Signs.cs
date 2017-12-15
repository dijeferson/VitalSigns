using System;
using System.Collections.Generic;
using System.Text;
using System.Data;
using System.Data.SqlClient;

namespace VitalSigns.DAL.SQLServer
{
    public class Signs : IBase, ISign
    {
        #region Procedures
        private const string P_SIGNS_I = "dbo.usp_signs_i";
        private const string P_SIGNS_U = "dbo.usp_signs_u";
        private const string P_SIGNS_D = "dbo.usp_signs_d";
        private const string P_SIGNS_S = "dbo.usp_signs_s";

        #endregion


        #region IBase Members

        public int Insert(object[] parameters)
        {
            SqlCommand command = new SqlCommand();
            command.CommandType = CommandType.StoredProcedure;
            command.CommandText = P_SIGNS_I;
            command.Connection = new ConnectionBuilder().Connect();
            command.Parameters.Add(parameters[0]);
            command.Parameters.Add(parameters[1]);
            command.Parameters.Add(parameters[2]);
            command.Parameters.Add(parameters[3]);
            return command.ExecuteNonQuery();
        }

        public int Update(object[] primaryKey, object[] parameters)
        {
            throw new Exception("The method or operation is not implemented.");
        }

        public int Delete(object[] primaryKey)
        {
            SqlCommand command = new SqlCommand();
            command.CommandType = CommandType.StoredProcedure;
            command.CommandText = P_SIGNS_D;
            command.Connection = new ConnectionBuilder().Connect();
            command.Parameters.Add(primaryKey[0]);
            return command.ExecuteNonQuery();
        }

        public System.Data.DataSet Select(object[] parameters)
        {
            SqlCommand command = new SqlCommand();
            command.CommandType = CommandType.StoredProcedure;
            command.CommandText = P_SIGNS_S;
            command.Connection = new ConnectionBuilder().Connect();
            command.Parameters.Add(parameters[0]);
            command.Parameters.Add(parameters[1]);
            command.Parameters.Add(parameters[2]);
            SqlDataReader dr =  command.ExecuteReader();
            DataSet ds = new DataSet();
            ds.Tables[0].Load(dr);
            return ds;
        }

        #endregion
    }
}
