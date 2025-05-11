using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entity_FrameWork_Assignment.Model
{
    public class Officer
    {
        public Officer(string firstName, string lastName, string postion, int phone, string email)
        {
            FirstName = firstName;
            LastName = lastName;
            Postion = postion;
            Phone = phone;
            Email = email;
        }

        public int OfficerId { get; set; }
        public string FirstName { get; set; }

        public string LastName { get; set; }

        public string Postion { get; set; }

        public int Phone {  get; set; }

        public string Email { get; set; }
            
    }
}
