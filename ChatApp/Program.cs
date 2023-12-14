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
            TcpListener server = new TcpListener(System.Net.IPAddress.Any, 9999);

            // Server start
            server.Start();

            // 연결된 client 받아오기
            // client 접속 전까지 해당 구문에서 stop
            TcpClient client = server.AcceptTcpClient();

            // NetworkStream 객체 생성 : client가 보낸 데이터 저장
            NetworkStream ns = client.GetStream();

            // Socket : byte[] 형식으로 데이터 통신
            byte[] data = new byte[1024];

            // client가 write한 데이터 읽어오기
            ns.Read(data, 0, data.Length);

            // 출력
            string stringData = Encoding.Default.GetString(data);

            Console.WriteLine(stringData);

            // 서버 종료
            server.Stop();
            ns.Close();
        }
    }
}
