using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bridge
{
    /// <summary>
    /// Represents a car crossing the bridge
    /// inherits from the Vehicle <see cref="Vehicle"/> class.
    /// </summary>
    public class Car : Vehicle
    {
        public Car()
        {
        }

        public Car(string licensePlate, DateTime date) : base(licensePlate, date)
        {
        }

        /// <summary>
        /// Returns the price for crossing the bridge for a car.
        /// with a fixed price of 230.
        /// </summary>
        /// <returns> Price for a Car to cross is (230) </returns>
        public override double Price()
        {
            return 230;
        }

        /// <summary>
        /// Returns the type of the vehicle.
        /// For this class, it returns "Car".
        /// </summary>
        /// <returns>The vehicle type as a string ("Car").</returns>
        public override string VehicleType()
        {
            return "Car";
        }
    }
}