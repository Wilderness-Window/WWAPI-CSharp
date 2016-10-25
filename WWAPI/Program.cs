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
        static void Main(string[] args)
        {

            WWAPI.WWAPI api = new WWAPI.WWAPI(); // initialise API suite

            authentication auth = new authentication(); // fill in authentication details
            auth.username = "******"; //put your username and password as provided to you previously
            auth.password = "******";

            api.authenticationValue = auth; // add authentication to API suite

            GetAvailabilityByDay Availability = new GetAvailabilityByDay(); // define function you want to use and fill in parameters 
            Availability.NumberOfDays = 2; 
            Availability.PropertyList = "MOM001"; // Property code for Mombo
            Availability.StartDate = DateTime.UtcNow;

            GetWildernessProperties Properties = new GetWildernessProperties(); 

            GetAvailabilityByDayResponse avail_resp = api.GetAvailabilityByDay(Availability); //initialise response
            GetWildernessPropertiesResponse prop_resp = api.GetWildernessProperties(Properties);

            //debug purposes
            var avail_resp1 = avail_resp.AvailabilityByDay.AvailabilityByDay_Response[0];
            var avail_resp2 = avail_resp.AvailabilityByDay.AvailabilityByDay_Response[1];

            var prop_resp1 = prop_resp.Response.WildernessSuppliers_Response[0];
            var prop_resp2 = prop_resp.Response.WildernessSuppliers_Response[1];

            Debug.WriteLine(avail_resp1.PropertyCode + " - " + avail_resp1.RoomType + " - " + avail_resp1.RoomsAvail + " - " + avail_resp1.Date);
            Debug.WriteLine(avail_resp2.PropertyCode + " - " + avail_resp2.RoomType + " - " + avail_resp2.RoomsAvail + " - " + avail_resp2.Date);

            Debug.WriteLine(prop_resp1.Country + " - " + prop_resp1.SupplierName + " - " + prop_resp1.SupplierCode);
            Debug.WriteLine(prop_resp2.Country + " - " + prop_resp2.SupplierName + " - " + prop_resp2.SupplierCode);

        }
    }
}
