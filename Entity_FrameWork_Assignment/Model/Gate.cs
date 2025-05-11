using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entity_FrameWork_Assignment.Model
{
    public class Gate
    {
        public Gate(string gateName, string avalible_Status)
        {
            GateName = gateName;
            this.avalible_Status = avalible_Status;
        }

        public int GatID { get; set; }
        public string GateName { get; set; }

        public string avalible_Status { get; set; }
    }
}
