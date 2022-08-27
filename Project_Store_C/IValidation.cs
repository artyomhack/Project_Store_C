namespace Project_Store_C
{
    public interface IValidation
    { 
        string CheckName(string name, int startSymbol, int endSymbol);
        int CheckNumber(int numb, int startNumb, int endNumb);
    }
}