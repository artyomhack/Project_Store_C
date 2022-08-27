using System;
using System.Linq;
using System.Media;

namespace MyC_project.Properties.store
{
    public class Store
    {
        private Computer[] _computers;
        private BoxOffice _box;

        public Store(Computer[] computers, BoxOffice box)
        {
            _computers = computers;
            _box = box;
            
        }

        public Computer[] Computers
        {
            get { return _computers; }
            set { _computers = value;}
        }

        public BoxOffice Box
        {
            get { return _box;}
            set { _box = value; }
        }

        public Computer FindByNameOrSalary(string name, int salary) 
        {
            for (int i = 0; i < Computers.Length; i++)
            {
                if (Computers[i].Name.Contains(name) || Computers[i].Salary == salary)
                {
                    ComputerDisplay(Computers[i]);
                    return Computers[i];
                }
            }
            
            ComputerDisplay(null);
            return null;
        }

        public Computer FindBySpecifications(Specifications specifications)
        {
            for (int i = 0; i < Computers.Length; i++)
            {
                if (Computers[i].Specification.Memory == specifications.Memory ||
                    Computers[i].Specification.Processor == specifications.Processor ||
                    Computers[i].Specification.HardDrive == specifications.HardDrive)
                {
                    ComputerDisplay(Computers[i]);
                    return Computers[i];
                }
            }
            
            ComputerDisplay(null);
            return null;
        }

        private void ComputerDisplay(Computer computer)
        {
            if (computer != null)
            {
                Console.WriteLine($"{computer.Name} salary: {computer.Salary}");
                Console.WriteLine($"Specifications: {computer.Specification.Memory} {computer.Specification.Processor} {computer.Specification.HardDrive} ");
            }
            else
            {
                Console.WriteLine("I didn't find the computer:C");
            }
        }
    }
}