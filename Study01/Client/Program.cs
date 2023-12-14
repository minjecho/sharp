using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Sockets;
using System.Text;
using System.Threading.Tasks;

namespace ChatApp
{
    class Client
    {
        static void Main(string[] args)
        {
            Console.WriteLine("---------------------- 클라이언트 콘솔창 ----------------------");

            TcpClient client = new TcpClient();

            // IP : 127.0.0.1(자기자신을 나타내는 루프백 IP)
            // port : 8080
            try
            {
                client.Connect("127.0.0.1", 9999);
            }
            catch(Exception err)
            {
                string strErr = string.Format("[SYSTEM] : {0}", err.Message);
                Console.WriteLine(strErr);
            }

            // '접속합니다' 출력
            byte[] buf = Encoding.Default.GetBytes("클라이언트 : 접속합니다");

            // Write
            try
            {
                client.GetStream().Write(buf, 0, buf.Length);
            } catch(Exception err)
            {
                string strErr = string.Format("[SYSTEM] : {0}", err.Message);
                Console.WriteLine(strErr);
            }

            client.Close();
        }
    }
}
