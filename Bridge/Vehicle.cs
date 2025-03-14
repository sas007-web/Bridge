namespace Bridge
{
    /// <summary>
    /// Represents a vehicle crossing the bridge.
    /// Base class; a specific vehicle type must be inherited from this class.
    /// </summary>
    public abstract class Vehicle
    {
        private string _licensePlate;

        /// <summary>
        /// Gets or sets the license plate of the vehicle.
        /// Ensures that the license plate does not exceed 7 characters.
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
        /// Gets or sets a value indicating whether the vehicle has a Brobizz.
        /// </summary>
        public bool HasBrobizz { get; set; }

        /// <summary>
        /// Initializes a new instance of the <see cref="Vehicle"/> class with default values.
        /// License plate is set to "Unknown" and date is set to the current date and time.
        /// </summary>
        protected Vehicle()
        {
            LicensePlate = "Unknown";  // Standard value
            Date = DateTime.Now;       // Set date to now
            HasBrobizz = false;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="Vehicle"/> class with specified values.
        /// </summary>
        /// <param name="licensePlate">The vehicle's license plate.</param>
        /// <param name="date">The date and time when the vehicle crossed the bridge.</param>
        /// <param name="hasBrobizz">Indicates whether the vehicle has a Brobizz.</param>
        protected Vehicle(string licensePlate, DateTime date, bool hasBrobizz = false)
        {
            LicensePlate = licensePlate;
            Date = date;
            HasBrobizz = hasBrobizz;
        }

        /// <summary>
        /// Returns the base price of the vehicle.
        /// </summary>
        /// <returns>The base price.</returns>
        public abstract double BasePrice();

        /// <summary>
        /// Returns the price of the vehicle.
        /// A Brobizz discount is applied if the vehicle has a Brobizz.
        /// </summary>
        /// <returns>The final price.</returns>
        public virtual double Price()
        {
            double price = BasePrice();
            if (HasBrobizz)
            {
                price *= 0.9;
            }
            return price;
        }

        /// <summary>
        /// Returns the type of the vehicle.
        /// Overrides specific vehicle type.
        /// </summary>
        /// <returns>The vehicle type as a string.</returns>
        public abstract string VehicleType();
    }
}
