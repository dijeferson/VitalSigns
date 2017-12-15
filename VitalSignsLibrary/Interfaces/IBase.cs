using System;
using System.Collections.Generic;
using System.Text;
using System.Data;

namespace VitalSigns.DAL
{
    public interface IBase
    {
        /// <summary>
        /// 
        /// </summary>
        /// <param name="parameters"></param>
        /// <returns></returns>
        int Insert(object[] parameters);

        /// <summary>
        /// 
        /// </summary>
        /// <param name="primaryKey"></param>
        /// <param name="parameters"></param>
        /// <returns></returns>
        int Update(object[] primaryKey, object[] parameters);

        /// <summary>
        /// 
        /// </summary>
        /// <param name="primaryKey"></param>
        /// <returns></returns>
        int Delete(object[] primaryKey);

        /// <summary>
        /// 
        /// </summary>
        /// <param name="parameters"></param>
        /// <returns></returns>
        DataSet Select(object[] parameters);
        
    }
}
