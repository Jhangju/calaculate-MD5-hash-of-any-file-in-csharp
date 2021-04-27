using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Security.Cryptography;
using System.IO;

namespace calculate_hash
{
    class Program
    {
       
        static string CalculateMD5(string filename)
        {
            using (var md5 = MD5.Create())
            {
                using (var stream = File.OpenRead(filename))
                {
                    var hash = md5.ComputeHash(stream);
                    return BitConverter.ToString(hash).Replace("-", "").ToLowerInvariant();
                }
            }
        }
        static void Main(string[] args)
        {
           
            string path= System.Reflection.Assembly.GetEntryAssembly().Location;
            string full="\""+path+"\"";
            Console.WriteLine(path);
       
            Console.WriteLine(CalculateMD5(path));
            
            Console.ReadLine();
           
        }
    }
}
