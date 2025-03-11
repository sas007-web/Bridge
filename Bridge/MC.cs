using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bridge
{
    /// <summary>
    /// Represents a motorcycle(MC) crossing the bridge.
    /// Inherits from the Vehicle <see cref="Vehicle"/> class.
    /// </summary>
    public class MC : Vehicle
    {
        /// <summary>
        /// Returns the price for crossing the bridge for a motorcycle.
        /// The price is fixed at 120.
        /// </summary>
        /// <returns>The price for a MC to cross is (120).</returns>
        public override double Price()
        {
            return 120;
        }

        /// <summary>
        /// Gets the type of the vehicle.
        /// For this class, overides it and returns "MC" (Motorcycle).
        /// </summary>
        /// <returns>The vehicle type as a string ("MC").</returns>
        public override string VehicleType()
        {
            return "MC";
        }
    }
}