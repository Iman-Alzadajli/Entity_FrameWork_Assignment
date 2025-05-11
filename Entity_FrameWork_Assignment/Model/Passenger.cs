using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entity_FrameWork_Assignment.Model
{
    public class Passenger
    {
        public Passenger(string firstName, string lastName, DateOnly dateofBirth, string gender, string nationality, int passport, int phone, string email)
        {
            FirstName = firstName;
            LastName = lastName;
            DateofBirth = dateofBirth;
            this.gender = gender;
            Nationality = nationality;
            Passport = passport;
            Phone = phone;
            Email = email;
        }

        public int PassengerId { get; set; }
        public string FirstName {  get; set; }

        public string LastName { get; set; }

        public DateOnly DateofBirth { get; set; }

        public string gender {  get; set; }

        public string Nationality { get; set; }

        public int Passport {  get; set; }

        public int Phone { get; set; }

        public string Email { get; set; }
    }
}
