using System;
using System.Collections.Generic;
using System.Text;
using System.Data;
using System.Data.SqlClient;

namespace VitalSigns.DAL.SQLServer
{
    public class Patients : IBase, IPatient
    {
        #region Procedures
        private const string P_PATIENT_I = "dbo.usp_patient_i";
        private const string P_PATIENT_U = "dbo.usp_patient_u";
        private const string P_PATIENT_D = "dbo.usp_patient_d";
        private const string P_PATIENT_S = "dbo.usp_patient_s";

        #endregion


        #region IBase Members

        public int Insert(object[] parameters)
        {
            SqlCommand command = new SqlCommand();
            command.CommandType = CommandType.StoredProcedure;
            command.CommandText = P_PATIENT_I;
            command.Connection = new ConnectionBuilder().Connect();
            command.Parameters.Add(parameters[0]);
            command.Parameters.Add(parameters[1]);
            command.Parameters.Add(parameters[2]);
            command.Parameters.Add(parameters[3]);
            command.Parameters.Add(parameters[4]);
            command.Parameters.Add(parameters[5]);
            command.Parameters.Add(parameters[6]);
            command.Parameters.Add(parameters[7]);
            command.Parameters.Add(parameters[8]);
            command.Parameters.Add(parameters[9]);
            command.Parameters.Add(parameters[10]);
            command.Parameters.Add(parameters[11]);
            command.Parameters.Add(parameters[12]);
            command.Parameters.Add(parameters[13]);
            command.Parameters.Add(parameters[14]);
            command.Parameters.Add(parameters[15]);
            command.Parameters.Add(parameters[16]);

            return command.ExecuteNonQuery();
        }

        public int Update(object[] primaryKey, object[] parameters)
        {
            SqlCommand command = new SqlCommand();
            command.CommandType = CommandType.StoredProcedure;
            command.CommandText = P_PATIENT_U;
            command.Connection = new ConnectionBuilder().Connect();
            command.Parameters.Add(primaryKey[0]);
            command.Parameters.Add(parameters[0]);
            command.Parameters.Add(parameters[1]);
            command.Parameters.Add(parameters[2]);
            command.Parameters.Add(parameters[3]);
            command.Parameters.Add(parameters[4]);
            command.Parameters.Add(parameters[5]);
            command.Parameters.Add(parameters[6]);
            command.Parameters.Add(parameters[7]);
            command.Parameters.Add(parameters[8]);
            command.Parameters.Add(parameters[9]);
            command.Parameters.Add(parameters[10]);
            command.Parameters.Add(parameters[11]);
            command.Parameters.Add(parameters[12]);
            command.Parameters.Add(parameters[13]);
            command.Parameters.Add(parameters[14]);
            command.Parameters.Add(parameters[15]);
            command.Parameters.Add(parameters[16]);
            return command.ExecuteNonQuery();
        }

        public int Delete(object[] primaryKey)
        {
            SqlCommand command = new SqlCommand();
            command.CommandType = CommandType.StoredProcedure;
            command.CommandText = P_PATIENT_D;
            command.Connection = new ConnectionBuilder().Connect();
            command.Parameters.Add(primaryKey[0]);
            return command.ExecuteNonQuery();
        }

        public System.Data.DataSet Select(object[] parameters)
        {
            SqlCommand command = new SqlCommand();
            command.CommandType = CommandType.StoredProcedure;
            command.CommandText = P_PATIENT_S;
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
