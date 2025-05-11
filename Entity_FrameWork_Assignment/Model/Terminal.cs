using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entity_FrameWork_Assignment.Model
{
    public class Terminal
    {
        public Terminal(string terName, int capacity, string location)
        {
            TerName = terName;
            Capacity = capacity;
            Location = location;
        }

        public int TeminalId { get; set; }
        public string TerName {  get; set; }

        public int Capacity { get; set; }

        public string Location { get; set; }
        public List<Gate> Gates { get; set; }

    }
}
