using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Sql;
using System.Data.SqlClient;
using System.Text;
using VitalSigns.DAL;

namespace VitalSigns.DAL.SQLServer
{
    public class CRUD : ICRUD
    {
        //
        // Comando SQL e parametros
        //
        private SqlCommand sqlcom = new SqlCommand();
       
        
        //
        // Constantes do nome das procedures que serão chamadas nos métodos abaixo
        //
        private const string NOME_DA_PROCEDURE = "schema.procedureName";


        //
        // Métodos de chamada ao banco de dados
        //

        /// <summary>
        /// 
        /// </summary>
        /// <param name="param"></param>
        /// <returns></returns>
        public DataSet AquiPodeSerUmSelect(string param) 
        {
            //throw new NotImplementedException("Function or method not implemented yet!");

            //sqlcom.CommandType = CommandType.StoredProcedure;
            //sqlcom.CommandText = NOME_DA_PROCEDURE;
            //sqlcom.Parameters.AddWithValue("@parametro", "valor");
            //sqlcom.Connection = new ConnectionBuilder().Connect();
            //SqlDataReader dr = sqlcom.ExecuteReader();
            //DataSet ds = new DataSet();
            //ds.Load(dr, LoadOption.OverwriteChanges, dr.GetSchemaTable());

            //return ds;

            return new DataSet("UNIT TEST");
        }
        public int AquiPodeSerUmInsert(string param) 
        {
            throw new NotImplementedException("Function or method not implemented yet!");
        }
        public int AquiPodeSerUmAlter(string param) 
        {
            throw new NotImplementedException("Function or method not implemented yet!");
        }
        public int AquiPodeSerUmDelete(string param)
        {
            throw new NotImplementedException("Function or method not implemented yet!");
        }


    }
}
