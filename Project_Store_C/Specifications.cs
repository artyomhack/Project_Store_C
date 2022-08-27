using System;
using Project_Store_C;

namespace MyC_project.Properties.store
{
    public class Specifications : IValidation
    {
        private string _processor;
        private int _memory;
        private int  _hard_drive;

        public Specifications(string processor, int memory, int hardDrive)
        {
            _processor = CheckName(processor, 1, 50);
            _memory = CheckNumber(memory, 0, 64);
            _hard_drive = CheckNumber(hardDrive, 100, 5000);
        }

        public string Processor
        {
            get { return _processor; }
            set { _processor = value; }
        }

        public int Memory
        {
            get { return _memory; }
            set { _memory = value; }
        }

        public int HardDrive
        {
            get { return _hard_drive; }
            set { _hard_drive = value; } 
        }

        public string CheckName(string name, int startSymbol, int endSymbol)
        {
            int j = 0;
            while (true)
            {
                if (j != 0) name = Console.ReadLine();
                
                if (name != null && name.Length >= startSymbol && name.Length <= endSymbol)
                {
                    return name;
                }

                j++;
                Console.WriteLine($"Name:({name}) will be less than or equal to {startSymbol} character and not more than {endSymbol} characters: Try " + j );
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