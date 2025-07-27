namespace 开发封闭原则_OCP;

class Program
{
    static void Main(string[] args)
    {
        //使用代码描述不同需求的人去银行办理不同的业务
        
        //1、在这段程序中会出现多少个对象
        //2、每个对象的属性和行为
        
        //对象1：用户； 属性 ：记录不同类型的用户（存钱、取钱和转账）
        //对象2： 银行柜员 ：帮助用户处理不同的需求
        //对象3： 银行业务系统；处理存钱、取钱和转账的业务系统
        
        
    }
}


public class BankClient
{
  
    public string BankType { get; set; }
    
}

public class BankStuff
{
    private BankProcess bankProcess = new BankProcess();
    
    public void HandleProcess(BankClient bankClient)
    {
        
        //调用银行的业务系统，处理用户的请求
        switch (bankClient.BankType)
        {
            case "存款":
                bankProcess.Deposite();
                break;
        }
        
    }
}

public class BankProcess
{
    //存钱
    public void Deposite()
    {
        Console.WriteLine("存钱");
    }
}
