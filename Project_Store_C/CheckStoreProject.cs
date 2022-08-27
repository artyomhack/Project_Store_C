using System;
using MyC_project.Properties.store;

/*
 * Artyom
 * Hackimullin
 * 500000
 * Asus
 * Intel Core I3
 * 8
 * 1024
 */
namespace Project_Store_C
{
    internal class CheckStoreProject
    {

        private static Buyer _buyer = new Buyer("Artyom", "Hack", 100000);
        
        private static Store _store = new Store(new []
        {
            new Computer("Xiaomi",  new Specifications("Intel Core I3", 8, 1024)),
            new Computer("Asus",  new Specifications("Intel Core I5", 16, 2048)),
            new Computer("Microsoft", new Specifications("Pentium", 4, 1000))

        }, new BoxOffice(100000));
        
        public static void Main(string[] args)
        {
            Console.WriteLine("Start: ----->");
            Console.WriteLine("Buyer's salary: " + _buyer.Salary);

            var specifications = _buyer.ChooseComputer("Pentium", 4, 1000);
            
            Computer computer = _store.FindBySpecifications(specifications);

            Console.WriteLine("Box office:" + _store.Box.Salary);

            Console.WriteLine("Change:" + (_buyer.Salary - _store.Box.GetSalary(computer)));
           
            _store.Box.Pay(_buyer, computer);

            Console.WriteLine("Box office:" + _store.Box.Salary);
            Console.WriteLine("Buyer's salary:" + _buyer.Salary);
            
            _buyer.Computer = computer;
            Console.WriteLine($"Computer name of buyer: {_buyer.First_Name} {_buyer.Last_Name}. Computer: {_buyer.Computer.Name}");
        }
    }
}