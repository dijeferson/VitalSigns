using System;
using System.Collections.Generic;
using System.Data;
using System.Text;
using VitalSigns.Library.Model;

namespace VitalSigns.DAL
{
    public interface ICRUD
    {
        /// <summary>
        /// 
        /// </summary>
        /// <param name="param"></param>
        /// <returns></returns>
        DataSet AquiPodeSerUmSelect(string param);

        /// <summary>
        /// 
        /// </summary>
        /// <param name="param"></param>
        /// <returns></returns>
        int AquiPodeSerUmInsert(string param);
        
        /// <summary>
        /// 
        /// </summary>
        /// <param name="param"></param>
        /// <returns></returns>
        int AquiPodeSerUmAlter(string param);
        
        /// <summary>
        /// 
        /// </summary>
        /// <param name="param"></param>
        /// <returns></returns>
        int AquiPodeSerUmDelete(string param);
    }
}
