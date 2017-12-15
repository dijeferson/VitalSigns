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
    public class Medications
    {
        public Medications() { }

        public int InsertNewMedication(string[] parameters)
        {
            IMedication medication = DALFactory.CreateMedication();
            return medication.Insert((object[])parameters);
        }

    }
}
