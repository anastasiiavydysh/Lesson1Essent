using System.Net;

namespace Task6
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Address address = new Address();
            address.Street = "ul. Test1";
            address.House = "2A";
            address.Apartment = "1";
            address.Index = "123-123";
            address.City = "CityTest";
            address.Country = "CountryTest";
            Console.WriteLine(address.City);
            Console.WriteLine(address.Country);
            Console.WriteLine(address.Apartment);
            Console.WriteLine(address.Index);
            Console.WriteLine(address.House);
            Console.WriteLine(address.Street);
        }
    }
}