using System;
using System.Net;

namespace net01
{
    class Program
    {
        static void Main()
        {
            string hostName = Dns.GetHostName();

            Console.WriteLine("Local hostname: {0}", hostName);

            //IPHostEntry myself = Dns.GetHostByName(hostName);

            IPHostEntry myself = Dns.GetHostEntry(hostName);

            foreach (IPAddress addr in myself.AddressList)
            {
                if (addr.AddressFamily.ToString() != "InterNetwork")
                Console.WriteLine(
                        "{0} {1}{2}{3} {4}{5}{6}", 
                        addr.ToString(),

                        addr.IsIPv4MappedToIPv6 ? "IPv4MappedToIPv6 " : " ",
                        addr.IsIPv6LinkLocal ? "IPv6LinkLocal " : " ",
                        addr.IsIPv6Multicast ? "IPv6Multicast " : " ",

                        addr.IsIPv6SiteLocal ? "IPv6SiteLocal " : " ",
                        addr.IsIPv6Teredo ? "IPv6Teredo " : " ",
                        addr.ScopeId.ToString()

                                  );
                if (addr.ToString().StartsWith("2002:"))
                {
                    string s2002 = addr.ToString().Substring(5);
                    string sIPv4 = String.Format("{0}.{1}.{2}.{3}", 
                        Convert.ToInt32(s2002.Substring(0, 2), 16), 
                        Convert.ToInt32(s2002.Substring(2, 2), 16),
                        Convert.ToInt32(s2002.Substring(5, 2), 16),
                        Convert.ToInt32(s2002.Substring(7, 2), 16));

                    Console.WriteLine("\n{0} {1}\n", s2002, sIPv4);
                }
            }
            Console.ReadKey();
        }
    }
}

