using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Sockets;
using System.Text;
using System.Threading.Tasks;

namespace ChatApp
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("---------------------- 서버 콘솔창 ----------------------");

            // TcpListner
            // IP, port
            TcpListener server = new TcpListener(System.Net.IPAddress.Any, 8080);

            // Server start
            server.Start();

            // 연결된 client 받아오기
            // client 접속 전까지 해당 구문에서 stop
            TcpClient client = server.AcceptTcpClient();
        }
    }
}
