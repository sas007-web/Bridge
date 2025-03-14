using Bridge;
using System;
using Bridge;

namespace OresundTicketLibrary
{
    // Klasse for Oresund Car, der arver fra Car i TicketLibrary
    public class OresundCar : Car
    {
        public OresundCar(string licensePlate, DateTime date, bool hasBrobizz)
            : base(licensePlate, date, hasBrobizz)
        {
        
        }
        public override double Price()
        {
            return HasBrobizz ? 178 : 460;
        }
        public override string VehicleType()
        {
            return "Oresund Car";
        }
    }

}