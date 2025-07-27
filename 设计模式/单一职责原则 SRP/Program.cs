using System.Net.Mime;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;
using 单一职责原则_SRP.Classes;
using 单一职责原则_SRP.Interfaces;

namespace 单一职责原则_SRP;

class Program
{
    static void Main(string[] args)
    {
        // 创建主机构建器
        var host = CreateHostBuilder(args).Build();
        // 从服务容器中获取服务
        var app = host.Services.GetRequiredService<NewTelPhone>();
        
        // 运行应用
        app.DialPhoneNumber("111");
    }
    
    static IHostBuilder CreateHostBuilder(string[] args) =>
        Host.CreateDefaultBuilder(args)
            .ConfigureServices((hostContext, services) =>
            {
                // 注册服务
                services.AddTransient<IDial, DialClass>();
                services.AddTransient<IHangUp, HangUp>();
                services.AddTransient<NewTelPhone>();
            });
}
