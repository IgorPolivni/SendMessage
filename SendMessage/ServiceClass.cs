using System;
using System.Collections.Generic;
using System.Text;

namespace SendMessage
{
    public class ServiceClass
    {
        public static string GetRandomCode()
        {
            Random random = new Random();
            return random.Next(100000, 999999).ToString(); ;
        }

        public static bool CheckCode(string firstCode, string secondCode)
        {
            if (firstCode == secondCode) return true;
            else return false;
        }
    }
}
