using 单一职责原则_SRP.Interfaces;

namespace 单一职责原则_SRP.Classes;

public class DialClass:IDial
{
    public void Dial(string phoneNumber)
    {
        Console.WriteLine("给"+phoneNumber+"打电话");
    }
}
