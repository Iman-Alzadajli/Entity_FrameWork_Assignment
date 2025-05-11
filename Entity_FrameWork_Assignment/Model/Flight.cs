using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entity_FrameWork_Assignment.Model
{
    public class Flight
    {
        public Flight(string depatture_city, string destination_city, DateTime departure_time, string flghit_Status, int gate_Num)
        {
            this.depatture_city = depatture_city;
            this.destination_city = destination_city;
            this.departure_time = departure_time;
            Flghit_Status = flghit_Status;
            Gate_Num = gate_Num;
        }

        public int FlightId { get; set; }
        public  string depatture_city { get; set; }

        public string destination_city { get; set; }

        public  DateTime departure_time {  get; set; }

        public string Flghit_Status { get; set; }

        public int Gate_Num { get; set; }

        public int AirlineId { get; set; }
    }
}
