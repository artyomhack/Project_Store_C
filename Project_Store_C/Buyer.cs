using System;
using Project_Store_C;

namespace MyC_project.Properties.store
{
    public class Buyer : IValidation
    {
        private string _firstName;
        private string _lastName;
        private int _salary;
        private Computer _computer;

        public Buyer(string firstName, string lastName, int salary)
        {
            _firstName= ((IValidation)this).CheckName(firstName, 1, 20);
            _lastName = ((IValidation)this).CheckName(lastName, 1, 35);
            _salary = ((IValidation)this).CheckNumber(salary, 0, 1000000);
            
        }

   

        public string First_Name
        {
            get { return _firstName; }
            set { _firstName = value; }
        }

        public string Last_Name
        {
            get { return _lastName; }
            set { _lastName = value; }
        }

        public int Salary
        {
            get { return _salary; }
            set { _salary = value; }
        }

        public Computer Computer
        {
            get { return _computer; }
            set { _computer = value; }
        }

        public Specifications ChooseComputer(string processor, int memory, int hardDrive)
        {
            return new Specifications(processor, memory, hardDrive);
        }

        public int GetSalaryComputer(Computer computer)
        {
            return computer.Salary;
        }

        string IValidation.CheckName(string name, int startSymbol, int endSymbol)
        {
            int j = 0;
            while (true)
            {
                if (name != null && name.Length >= startSymbol && name.Length <= endSymbol)
                {
                    return name;
                }

                j++;
                Console.WriteLine($"Name:({name}) will be less than or equal to {startSymbol} character and not more than {endSymbol} characters: Try " + j ); 
                
                name = Console.ReadLine(); 
            }
            
        }

        int IValidation.CheckNumber(int numb, int startNumb, int endNumb)
        {
            int j = 0;
            while (true)
            {
                if (numb >= startNumb  && numb <= endNumb)
                {
                    return numb;
                }

                j++;
                Console.WriteLine($"Numb({numb}) will be less than or equal to {startNumb} character and not more than {endNumb} characters: Try " + j);
                numb = Convert.ToInt32(Console.ReadLine());
            }
        }
    }
}