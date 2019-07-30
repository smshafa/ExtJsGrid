using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace ExtJsGrid.Models
{
    public class Contact
    {
        public string Id { get; set; }
        public string Name { get; set; }
        public string Phone { get; set; }
        public string Email { get; set; }
        public DateTime BirthDate { get; set; }
        public bool IsMarried { get; set; }
        public int NoOfCar { get; set; }

        public Contact(string pName, string pPhone, string pEmail, DateTime pBirthDate, bool pIsMarried, int pNoOfCar)
        {
            this.Id = System.Guid.NewGuid().ToString();
            this.Name = pName;
            this.Phone = pPhone;
            this.Email = pEmail;
            this.BirthDate = pBirthDate;
            this.IsMarried = pIsMarried;
            this.NoOfCar = pNoOfCar;
        }

        public Contact() { }
    }
}