using Bridge;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OresundbroenTicketLibrary
{
    class OresundMc : MC
    {
        public OresundMc(string licensePlate, DateTime date, bool hasBrobizz = false) : base(licensePlate, date, hasBrobizz)
        {
        }
        public override double Price()
        {
            // Hvis der er Brobizz, skal prisen være 92 kr., ellers 235 kr.
            return HasBrobizz ? 92 : 235;
        }

        public override string VehicleType()
        {
            return "Oresund MC";
        }
    }
}