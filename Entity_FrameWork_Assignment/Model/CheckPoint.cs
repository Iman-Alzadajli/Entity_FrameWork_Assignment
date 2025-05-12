using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entity_FrameWork_Assignment.Model
{
    public class CheckPoint
    {
        public CheckPoint(int passengerCapacity, string location)
        {
            PassengerCapacity = passengerCapacity;
            Location = location;
        }

        public int CheckPointId { get; set; }

        public int PassengerCapacity { get; set; }

        public string Location { get; set; }

        public int TerminalId { get; set; }
    }
}
