using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entity_FrameWork_Assignment.Model
{
    public class Bagger
    {
        public Bagger(float weight, int track_num)
        {
            this.weight = weight;
            Track_num = track_num;
        }

        public int BaggerID { get; set; }
        public float weight { get; set; }

        public int Track_num { get; set; }

        public int PassengerId { get; set; }

        public int TerminalId { get; set; }

        public int AirlineId { get; set; }

    }
}
