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
    public class Signs
    {
        public Signs() { }

        public int InsertNewSign(string[] parameters)
        {
            ISign sign = DALFactory.CreateSign();
            return sign.Insert((object[])parameters);
        }

    }
}
