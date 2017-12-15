using System;
using System.Configuration;
using System.Reflection;
using System.Collections.Generic;
using System.Text;

namespace VitalSigns.DAL
{
    class DALFactory
    {
        /// <summary>
        /// 
        /// </summary>
        /// <returns></returns>
        public static IPatient CreatePatient()
        {
            // Nome da classe que será criada a referencia
            string className = "VitalSigns.DAL.SQLServer.Patients";

            // Retorno da interface da classe referenciada
            return (IPatient)Assembly.Load("VitalSigns.DAL").CreateInstance(className);
        }

        /// <summary>
        /// 
        /// </summary>
        /// <returns></returns>
        public static IDoctor CreateDoctor()
        {
            // Nome da classe que será criada a referencia
            string className = "VitalSigns.DAL.SQLServer.Doctors";

            // Retorno da interface da classe referenciada
            return (IDoctor)Assembly.Load("VitalSigns.DAL").CreateInstance(className);
        }

        /// <summary>
        /// 
        /// </summary>
        /// <returns></returns>
        public static IMedication CreateMedication()
        {
            // Nome da classe que será criada a referencia
            string className = "VitalSigns.DAL.SQLServer.Medications";

            // Retorno da interface da classe referenciada
            return (IMedication)Assembly.Load("VitalSigns.DAL").CreateInstance(className);
        }

        /// <summary>
        /// 
        /// </summary>
        /// <returns></returns>
        public static ISign CreateSign()
        {
            // Nome da classe que será criada a referencia
            string className = "VitalSigns.DAL.SQLServer.Signs";

            // Retorno da interface da classe referenciada
            return (ISign)Assembly.Load("VitalSigns.DAL").CreateInstance(className);
        }
    }
}
