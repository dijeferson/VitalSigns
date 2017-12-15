using System;
using System.Data;
using System.Data.Common;
using System.Data.Sql;
using System.Data.SqlClient;
using System.Data.SqlTypes;
using System.Collections.Generic;
using System.Text;
using System.Configuration;

namespace VitalSigns.DAL
{
    public class ConnectionBuilder
    {
        private string _ConnectionString;
        private SqlConnection _Connection;

        /// <summary>
        /// 
        /// </summary>
        public string ConnectionString
        {
            get { return _ConnectionString; }
            set { _ConnectionString = value; }
        }

        /// <summary>
        /// 
        /// </summary>
        public SqlConnection Connection
        {
            get { return _Connection; }
            set { _Connection = value; }
        }
       
        /// <summary>
        /// 
        /// </summary>
        public ConnectionBuilder() { }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="connectionString">String de conexão ao banco de dados</param>
        public ConnectionBuilder(string connectionString) 
        {
            ConnectionString = connectionString;
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="settingKey">Nome da SettingKey do App.Config ou Web.Config</param>
        public ConnectionBuilder(object settingKey)
        {
            ConnectionString = new AppSettingsReader().GetValue(settingKey.ToString(), typeof(string)).ToString();
        }
        
        /// <summary>
        /// Estabelece a conexão ao banco de dados
        /// </summary>
        /// <returns>Conexao</returns>
        public SqlConnection Connect()
        {
            try
            {
                _Connection.ConnectionString = ConnectionString;
                _Connection.Open();
            }
            catch (SqlException ex) 
            {
                throw ex;
            }
            catch (NotImplementedException ex)
            {
                throw ex;
            }
            catch (Exception ex)
            {
                throw ex;
            }
            finally { }

            return _Connection;
        }

        /// <summary>
        /// Disconecta do banco de dados
        /// </summary>
        /// <returns>0 se ok / 1 se erro</returns>
        public int Disconnect()
        {
            int Err = 0;
            try
            {
                _Connection.Close();
            }
            catch (SqlException ex)
            {
                Err = 1;
                throw ex;
            }
            catch (NotImplementedException ex)
            {
                Err = 2;
                throw ex;
            }
            catch (Exception ex)
            {
                Err = 3;
                throw ex;
            }
            finally {  }

            return Err;

            
        }
    }
}
