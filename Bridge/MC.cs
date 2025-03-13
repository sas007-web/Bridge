using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bridge
{
    /// <summary>
    /// Represents a motorcycle (MC) crossing the bridge.
    /// Inherits from the <see cref="Vehicle"/> class.
    /// </summary>
    public class MC : Vehicle
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="MC"/> class with default values.
        /// </summary>
        public MC()
        {
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="MC"/> class with specified values.
        /// </summary>
        /// <param name="licensePlate">The motorcycle's license plate.</param>
        /// <param name="date">The date and time when the motorcycle crossed the bridge.</param>
        /// <param name="hasBrobizz">Indicates whether the motorcycle has a Brobizz.</param>
        public MC(string licensePlate, DateTime date, bool hasBrobizz = false)
            : base(licensePlate, date, hasBrobizz)
        {
        }

        /// <summary>
        /// Returns the base price for crossing the bridge for a motorcycle.
        /// The price is fixed at 120.
        /// </summary>
        /// <returns>The base price for an MC, which is 120.</returns>
        public override double BasePrice()
        {
            return 120;
        }

        /// <summary>
        /// Gets the type of the vehicle.
        /// For this class, overrides and returns "MC" (Motorcycle).
        /// </summary>
        /// <returns>The vehicle type as a string ("MC").</returns>
        public override string VehicleType()
        {
            return "MC";
        }
    }
}
