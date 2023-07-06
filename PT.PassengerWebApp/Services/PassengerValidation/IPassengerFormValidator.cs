using PT.PassengerWebApp.Data.Enums;

namespace PT.PassengerWebApp.Services.PassengerValidation
{
    public interface IPassengerFormValidator
    {
        bool IsPassengerValidAge(int age);
        bool UnapprovedChildMeal(int age, bool childMealPicked);
        bool UnapprovedFirstClass(string destinationCountry, FlightClass flightClass);
    }
}