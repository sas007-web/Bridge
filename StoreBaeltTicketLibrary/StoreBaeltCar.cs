using Bridge;
using System.Reflection.Metadata.Ecma335;
namespace StoreBaeltTicketLibrary

{
    /// <summary>
    /// Contains 
    /// </summary>
    public class StoreBaeltCar : Car
    {
        public StoreBaeltCar(string licensePlate, DateTime date, bool hasBrobizz) : base(licensePlate, date, hasBrobizz)
        {
        }

        public override double Price()
        {
                double price = BasePrice();

                if (Date.DayOfWeek == DayOfWeek.Saturday || Date.DayOfWeek == DayOfWeek.Sunday)
                {
                    price *= 0.85; // 15% discount
                }

                if (HasBrobizz)
                {
                    price *= 0.9; // ekstra 10% discount
                }

                return price;
        }
    }
}
