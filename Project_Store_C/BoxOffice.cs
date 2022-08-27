using System;

namespace MyC_project.Properties.store
{
    public class BoxOffice
    {
        private int _salary;

        public BoxOffice(int salary)
        {
            CheckMoney();
            _salary = salary;
        }
        
        public int Salary
        {
            get { return _salary;}
            set {_salary = value;}
        }

        public void Pay(Buyer buyer, Computer computer)
        {
            int change = 0;
            int priceComputer = GetSalary(computer);
            int money = buyer.Salary;
            int boxOffice = Salary;

            if (money > priceComputer)
            {
                change = money - priceComputer;
                money -= priceComputer;
                boxOffice -= change;

            }

            buyer.Salary = money;
            Salary = boxOffice;
        }

        public int GetSalary(Computer computer)
        {
            return computer.Salary;
        }

        private void CheckMoney()
        {
            switch (Salary)
            {
                case 100000: Console.WriteLine("The box office is full");
                    break;
                case 50000: Console.WriteLine("The box office is half empty");
                    break;
                case 10000: Console.WriteLine("The box office almost empty");
                    break;
                case 0: Console.WriteLine("You need to put salary in the cashier");
                    Salary = 100000;
                    break;
            } 
            
        }
    }
}