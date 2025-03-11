namespace Bridge
{
    /// <summary>
    /// Represents a vehicle, crosing the birdge 
    /// Base class, a secefic vehicle type must be inherited from this class
    /// </summary>
    public abstract class Vehicle
    {
        private string _licensePlate;

        /// <summary>
        /// Gets or sets the license plate of the vehicle.
        /// Makes sure that the license plate does not exceed 7 characters.
        /// </summary>
        public string LicensePlate
        {
            get => _licensePlate;
            set
            {
                // Validate that the license plate does not exceed 7 characters
                if (value.Length > 7)
                {
                    throw new ArgumentException("License plate cannot be longer than 7 characters.");
                }
                    _licensePlate = value;
            }
        }

        /// <summary>
        /// Gets or sets the date and time when the vehicle crossed the bridge.
        /// </summary>
        public DateTime Date { get; set; }

        /// <summary>
        /// Initializes a new instance of the <see cref="Vehicle"/> class with default values.
        /// License plate is set to "Unknown" and date is set to the current date and time.
        /// </summary>
        protected Vehicle()
        {
            LicensePlate = "Unknown";  // Standardværdi
            Date = DateTime.Now;       // Sætter dato til nu
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="Vehicle"/> class with specified values.
        /// </summary>
        /// <param name="licensePlate">The license plate of the vehicle.</param>
        /// <param name="date">The date and time of crossing.</param>
        protected Vehicle(string licensePlate, DateTime date)
        {
            LicensePlate = licensePlate;
            Date = date;
        }
        /// <summary>
        /// Calculates the price for crossing the bridge.
        /// Specefik vehicle Overriddes price.
        /// Must be implemented in derived classes. 
        /// </summary>
        /// <returns>The price of crossing as a double.</returns>
        public abstract double Price();

        /// <summary>
        /// Returns the type of the vehicle.
        /// Overrides specefik vehicle type.
        /// </summary>
        /// <returns>The vehicle type as a string.</returns>
        public abstract string VehicleType();
    }
}
