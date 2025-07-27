namespace 单一职责原则_SRP;

// 变化1：内部的变化，内部任意一方法发生变化都要修改TelPhone，不符合单一职责原则（SRP）
// 变化2; 外部的变化： 如果TelPhone需要添加新的方法，就需要修改TelPhone

public class TelPhone
{
    public void Dial(string phoneNumber)
    {
        Console.WriteLine("给"+phoneNumber+"打电话");
    }

    public void HangUp(string phoneNumber)
    {
        Console.WriteLine("挂断"+phoneNumber+"的电话");
    }

    public void SendMessage(string message)
    {
        Console.WriteLine("发送"+message);
    }

    public void ReceptionMessage(string message)
    {
        Console.WriteLine("接收"+message);
    }
}
