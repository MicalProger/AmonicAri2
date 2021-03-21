using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using AmonicAirSession2.DataBase;
using System.Threading.Tasks;

namespace AmonicAirSession2
{
    public class FinalData
    {
        public string Date;
        public string Time;
        public string From;
        public string To;
        public string FlightNum;
        public int Aircraft;
        public int EconomyPrice;
        public int BuisnessPrice;
        public int FirstClassPrice;
        public FinalData(DataBase.Schedules schedule)
        {
            var db = new DataBase.DataBase();
            Date = schedule.Date.ToString();
            Time = schedule.Time.ToString();
            From = db.Airports.FirstOrDefault(i => i.ID == db.Routes.FirstOrDefault(j => j.ID == schedule.RouteID).DepartureAirportID).IATACode;
            To = db.Airports.FirstOrDefault(i => i.ID == db.Routes.FirstOrDefault(j => j.ID == schedule.RouteID).ArrivalAirportID).IATACode;
            Aircraft = 5; //Int32.Parse(db.Aircrafts.FirstOrDefault(i => i.ID == schedule.AircraftID).MakeModel);
            EconomyPrice = (int)schedule.EconomyPrice;
            BuisnessPrice = EconomyPrice / 100 * 130;
            FirstClassPrice = BuisnessPrice / 100 * 130;
            FlightNum = "qewrty";
        }

    }
}
