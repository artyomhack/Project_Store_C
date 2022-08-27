using System;
using Project_Store_C;

namespace MyC_project.Properties.store
{
    public class Computer : IValidation
    {
        
        private string _name;
        private int _salary;
        private Specifications _specification;

        public Computer(string name, Specifications specification)
        {
            _name = CheckName(name, 1, 20);
            _specification = specification;
            CheckSalaryOfComputer();
        }

        public string Name
        {
            get { return _name;}
            set { _name = value; }
        }

        public int Salary
        {
            get { return _salary; }
            set { _salary = value; }
        }

        public Specifications Specification
        {
            get { return _specification; }
            set { _specification = value; }
        }
        
        private void CheckSalaryOfComputer()
        {
            switch (Name)
            {
                case "Microsoft":
                    Salary += 20000;
                        
                    break;
                case "Apple":
                    Salary += 50000;
                       
                    break;
                case "Xiaomi":
                    Salary += 15000;
                        
                    break;
                case "Asus":
                    Salary += 10000;
                    break;
                default:
                    Salary += 5000;
                    break;
            }
            
            
            int memory =  Specification.Memory/ 2;

            if (memory != 0) 
            { 
                int j = 1;
                while (j <= memory)
                {
                    Salary += 500 * j; // 500 * 2 = 1000; 500 * 4 = 2000; 500 * 6 = 3000; 500 * 8 = 40000
                    j *= 2;
                } 
            }
        }

        public string CheckName(string name, int startSymbol, int endSymbol)
        {
            int j = 0;
            while (true)
            {
                if (name != null && name.Length >= startSymbol && name.Length <= endSymbol)
                {
                    return name;
                }

                j++;
                Console.WriteLine($"{name} will be less than or equal to {startSymbol} character and not more than {endSymbol} characters: Try " + j);
                name = Console.ReadLine();
            }
        }

        public int CheckNumber(int numb, int startNumb, int endNumb)
        {
            int j = 0;
            while (true)
            {
                if (numb >= startNumb  && numb <= endNumb)
                {
                    return numb;
                }

                j++;
                Console.WriteLine($"{numb} will be less than or equal to {startNumb} number and not more than {endNumb} number: Try " + j);
                numb = Convert.ToInt32(Console.ReadLine());
            }
        }
    } 
}