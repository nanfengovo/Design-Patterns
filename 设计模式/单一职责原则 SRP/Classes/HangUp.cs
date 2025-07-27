using 单一职责原则_SRP.Interfaces;

namespace 单一职责原则_SRP.Classes;

public class HangUp:IHangUp
{
    public void HuangUo(string phoneNumber)
    {
        Console.WriteLine("挂断"+phoneNumber+"的电话");
    }
}
