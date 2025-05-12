using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entity_FrameWork_Assignment.Model
{
    public class Airline
    {
        public Airline( string namr, int contect_num, string email)
        {
            
            Namr = namr;
            Contect_num = contect_num;
            Email = email;
        }

        public int AirlineId {  get; set; }
        public string Namr {  get; set; }
        public int Contect_num {  get; set; }

        public string Email { get; set; }

        public List<Flight> Flights { get; set; }
        public List<Gate> Gates { get; set; }


    }

    }
