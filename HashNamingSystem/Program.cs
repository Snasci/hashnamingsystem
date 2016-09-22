using System;
using System.Net;
using System.Security.Cryptography;
using System.Text;

namespace HashNamingSystem
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hash Naming System");
            Console.WriteLine(Environment.NewLine);
            Console.WriteLine("Enter Name Of Website:");
            string siteName = Console.ReadLine().TrimStart(' ').TrimEnd(' ').ToLower();

            IPAddress ipAddress = ComputeHash(siteName);

            Console.WriteLine(ipAddress.ToString());
            Console.WriteLine(ipAddress.MapToIPv4().ToString());
            Console.WriteLine("Press any key to exit...");
            Console.ReadKey();
        }

        static IPAddress ComputeHash(string siteName)
        {
            byte[] encodedPassword = new UTF8Encoding().GetBytes(siteName);
            byte[] hash = ((HashAlgorithm)CryptoConfig.CreateFromName("MD5")).ComputeHash(encodedPassword);
            return new IPAddress(hash);
        }
    }
}
