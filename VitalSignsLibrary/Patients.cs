using System;
using System.Collections.Generic;
using System.Text;
using VitalSigns.DAL;
using VitalSigns.Library;
using VitalSigns.Library.BLL;
using VitalSigns.Library.Framework;
using VitalSigns.Library.Model;

namespace VitalSigns.Library.BLL
{
    public class Patients
    {
        public Patients() { }

        public int InsertNewPatient(string[] parameters)
        {
            IPatient patient = DALFactory.CreatePatient();
            return patient.Insert((object[])parameters);
        }

    }
}
