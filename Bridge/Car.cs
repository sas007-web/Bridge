using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bridge
{
    internal class Car
    {
        public string licensePlate { get; set; } //Bilens Nummerplade Propperty 
        public DateTime Date { get; set; } 

        public double Price() //Brobiz pris metode
        {
            return 230;
        }

        public string VehicleType() //Køretøjs type metode 
        {
            return "Car"; 

         }
    }
}

