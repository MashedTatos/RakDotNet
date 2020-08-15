using System;
using System.Threading.Tasks;
using RakDotNet;
using RakDotNet.TcpUdp;

namespace RakDotNetTesting
{
    class Program
    {
        static async Task Main(string[] args)
        {
            await Start();
            
            

        }
        public static async Task Start()
        {
            IRakServer tcpudp = new TcpUdpServer(1001, "3.25 ND1");
            var server = tcpudp.RunAsync();
            var tasks = new[]
            {
                server
            };


            await Task.WhenAny(tasks);
        }
    }

    
}
