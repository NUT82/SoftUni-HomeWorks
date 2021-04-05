using System;
using System.Net;
using System.Net.Sockets;
using System.Text;
using System.Threading.Tasks;

namespace SimpleHTTPServer
{
    class Program
    {
        static async Task Main(string[] args)
        {
            TcpListener tcpListener = new TcpListener(IPAddress.Parse("172.16.1.190"), 12345);
            

            while (true)
            {
                tcpListener.Start();
                var client = await tcpListener.AcceptTcpClientAsync();
                
                using (var stream = client.GetStream())
                {
                    byte[] buffer = new byte[1000000];
                    stream.Read(buffer, 0, buffer.Length);
                    
                    string reqString = Encoding.UTF8.GetString(buffer);
                    Console.WriteLine(reqString);
                    string reqUrl = "default";
                    string[] path = reqString.Split()[1].Split("/", StringSplitOptions.RemoveEmptyEntries);
                    if (path.Length != 0)
                    {
                        reqUrl = path[0];
                    }

                    const string NewLine = "\r\n";
                    string html = "<h1>Hello from my server!</h1>";

                    StringBuilder sb = new StringBuilder();
                    sb.Append("HTTP/1.1 200 OK" + NewLine +
                        "Server: SvetlioServer 2020" + NewLine +
                        "Content-Type: text/html; charset=utf-8" + NewLine +
                        "Content-Length");

                    switch (reqUrl)
                    {
                        case "default":
                            break;
                        case "login":
                            html = "<h1>Please enter your login detail!</h1>";
                            
                            break;
                        default:
                            sb.Clear();
                            html = $"<HTML><HEAD><TITLE>404 Not Found</TITLE></HEAD><BODY><H1>Not Found</H1>The requested URL /{reqUrl} was not found on this server.<P><HR><ADDRESS>SvetlioServer 2020 at Port 12345</ADDRESS></BODY></HTML>";
                            sb.Append("HTTP/1.1 404 Not Found"  + NewLine +
                                    "Server: SvetlioServer 2020" + NewLine +
                                    "Content-Type: text/html; charset=utf-8" + NewLine +
                                    "Content-Length");
                            break;
                    }

                    sb.Append(html.Length + NewLine + NewLine + html + NewLine);
                    byte[] responseBytes = Encoding.UTF8.GetBytes(sb.ToString());
                    stream.Write(responseBytes);

                    Console.WriteLine("-----------------------------------------");
                    tcpListener.Stop();
                }
            }

            int number = int.Parse(Console.ReadLine());
        }
    }
}
