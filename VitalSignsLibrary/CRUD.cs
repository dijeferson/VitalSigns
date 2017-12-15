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
    public class CRUD
    {
        public CRUD() { }

        public System.Data.DataSet GetFill(int idFilling)
        {
            ICRUD crud = DALFactory.CreateCRUD();
            return crud.AquiPodeSerUmSelect(string.Empty);
        }

    }
}
