using System;
using System.Web;
using System.Web.Services;
using System.Web.Services.Protocols;

[WebService(Namespace = "VitalSigns.Integration")]
[WebServiceBinding(ConformsTo = WsiProfiles.BasicProfile1_1)]
public class IntegrationServices : System.Web.Services.WebService
{
    #region Contructor
    public IntegrationServices () {

        //Uncomment the following line if using designed components 
        //InitializeComponent(); 
    }
    #endregion

    #region Structs
    public struct sDoctors
	{
		public string name;
        public string department;
        public string email;
	}

    public struct sPatients
	{
		public string name;
        public int age;
        public DateTime birthday;
        public string address;
        public string neighborhood;
        public string city;
        public string state;
        public string postalcode;
        public string country;
        public string gender;
        public string ethnicity;
        public string height;
        public string weight;
        public string site;
        public string room;
        public bool critical;
        public string notes;
	}

    public struct sMedications
	{
		public string name;
        public string manufacturer;
        public string dafaultdosage;
    }
    #endregion

    #region Import
    [WebMethod]
    public int Autenticate(string user, string password)
    {
        throw new NotImplementedException();
    }

    [WebMethod]
    public void ImportDoctors(int token, sDoctors [] doctors)
    {
        throw new NotImplementedException();
    }

    [WebMethod]
    public void ImportPatients(int token, sPatients[] patients)
    {
        throw new NotImplementedException();
    }

    [WebMethod]
    public void ImportMedications(int token, sMedications [] medications)
    {
        throw new NotImplementedException();
    }
    #endregion

    #region Export
    [WebMethod]
    public void ExportDoctors(int token, string parameter)
    {
        throw new NotImplementedException();
    }

    [WebMethod]
    public void ExportPatients(int token, string parameter)
    {
        throw new NotImplementedException();
    }

    [WebMethod]
    public void ExportMedications(int token, string parameter)
    {
        throw new NotImplementedException();
    }
    #endregion

    #region Delete
    [WebMethod]
    public void DeleteDoctors(int token, string parameter)
    {
        throw new NotImplementedException();
    }

    [WebMethod]
    public void DeletePatients(int token, string parameter)
    {
        throw new NotImplementedException();
    }

    [WebMethod]
    public void DeleteMedications(int token, string parameter)
    {
        throw new NotImplementedException();
    }
    #endregion

}
