using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WWAPI.WWAPI;

namespace WWAPI
{
    class Program
    {

        private static WWAPI.WWAPI api = new WWAPI.WWAPI(); // initialise API suite
        static void Main(string[] args)
        {
            
            authentication auth = new authentication(); // fill in authentication details
            auth.username = "******"; //put your username and password as provided to you previously
            auth.password = "******";

            api.authenticationValue = auth; // add authentication to API suite

            List<WildernessProperty> PropertyList = GetPropertyList();

            List<WildernessAvailability> AvailabilityList = GetAvailabilityByProperty(PropertyList[5], 5, DateTime.Now); 

        }

        private static List<WildernessAvailability> GetAvailabilityByProperty(WildernessProperty wildernessProperty, int numberOfDays, DateTime startDate)
        {
            GetAvailabilityByDay Availability = new GetAvailabilityByDay(); // define function you want to use and fill in parameters 
            Availability.NumberOfDays = numberOfDays;
            Availability.PropertyList = wildernessProperty.SupplierCode;
            Availability.StartDate = startDate;

            GetAvailabilityByDayResponse AvailabilityResponse = api.GetAvailabilityByDay(Availability); //initialise response

            List<WildernessAvailability> ReturnList = new List<WildernessAvailability>();
            WildernessAvailability ReturnAvailability = new WildernessAvailability();

            foreach (var ResponseObject in AvailabilityResponse.AvailabilityByDay.AvailabilityByDay_Response)
            {
                ReturnAvailability.Date = ResponseObject.Date;
                ReturnAvailability.PropertyCode = ResponseObject.PropertyCode;
                ReturnAvailability.RoomType = ResponseObject.RoomType;
                ReturnAvailability.RoomsAvail = ResponseObject.RoomsAvail;

                ReturnList.Add(ReturnAvailability);

                ReturnAvailability = new WildernessAvailability();
            }

            return ReturnList;
        }

        private static List<WildernessProperty> GetPropertyList()
        {
            GetWildernessProperties Properties = new GetWildernessProperties();
            GetWildernessPropertiesResponse PropertyResponse = api.GetWildernessProperties(Properties);

            List<WildernessProperty> ReturnList = new List<WildernessProperty>();
            WildernessProperty ReturnProperty = new WildernessProperty();

            foreach (var ResponseObject in PropertyResponse.Response.WildernessSuppliers_Response)
            {
                ReturnProperty.SupplierCode = ResponseObject.SupplierCode;
                ReturnProperty.SupplierLocation = ResponseObject.SupplierLocation;
                ReturnProperty.SupplierName = ResponseObject.SupplierName;
                ReturnProperty.Country = ResponseObject.Country;

                ReturnList.Add(ReturnProperty);

                ReturnProperty = new WildernessProperty();
            }

            return ReturnList;
        }
    }
}
