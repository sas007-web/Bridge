using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bridge
{
    class MC
    {
        public string LicensePlate { get; set; } //MC LicensePlate Propperty

        public DateTime Date { get; set; } //MC Date of crosing bridge Propperty

        public double Price() //MC Bridge Price method
        {
            return 120; //MC Bridge Price 120kr 
        }

        public string Vehicle () //MC Vehicle type method
        {
            return "MC"; //Vehicle type is MC

        }
    }
}
