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
    public class Doctors
    {
        public Doctors() { }

        public int InsertNewDoctor(string[] parameters)
        {
            IDoctor doctor = DALFactory.CreateDoctor();
            return doctor.Insert((object[])parameters);
        }

    }
}
