using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bridge
{
    /// <summary>
    /// Represents a car crossing the bridge.
    /// Inherits from the <see cref="Vehicle"/> class.
    /// </summary>
    public class Car : Vehicle
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="Car"/> class with default values.
        /// </summary>
        public Car() : this("Unknown", DateTime.Now, false) // Default values
        {
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="Car"/> class with specified values.
        /// </summary>
        /// <param name="licensePlate">The license plate of the car.</param>
        /// <param name="date">The date and time when the car crossed the bridge.</param>
        /// <param name="hasBrobizz">Indicates whether the car has a Brobizz discount.</param>
        public Car(string licensePlate, DateTime date, bool hasBrobizz)
            : base(licensePlate, date, hasBrobizz)
        {
        }

        /// <summary>
        /// Returns the base price for crossing the bridge for a car.
        /// The fixed price is 230.
        /// </summary>
        /// <returns>The base price for a car, which is 230.</returns>
        public override double BasePrice()
        {
            return 230;
        }

        /// <summary>
        /// Returns the type of the vehicle.
        /// For this class, it returns "Car".
        /// </summary>
        /// <returns>A string representing the vehicle type ("Car").</returns>
        public override string VehicleType()
        {
            return "Car";
        }
    }
}
