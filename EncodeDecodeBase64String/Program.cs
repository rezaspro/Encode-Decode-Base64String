using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EncodeDecodeBase64String
{
    class Program
    {
        static void Main(string[] args)
        {
            var encode = Base64Encode("1040100004211208");
            var decode = Base64Decode(encode);

            Console.WriteLine("{0} {1}", encode, decode);
            Console.ReadLine();
        }

        public static string Base64Encode(string plainText)
        {
            var plainTextBytes = Encoding.UTF8.GetBytes(plainText);
            return Convert.ToBase64String(plainTextBytes);
        }

        public static string Base64Decode(string base64EncodedData)
        {
            var base64EncodedBytes = Convert.FromBase64String(base64EncodedData);
            return Encoding.UTF8.GetString(base64EncodedBytes);
        }
    }
}
