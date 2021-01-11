using System;
using System.Collections.Generic;
using System.Text;

namespace SendMessage
{
    public class Menu
    {

        public static string GetPhoneNumber()
        {
            while (true)
            {
                Console.WriteLine("Введите Ваш номер телефона (В формате +7##########): ");
                string phoneNumber = Console.ReadLine();
                if (phoneNumber[0] == '+' && phoneNumber.Length == 12)
                    return phoneNumber;
                else
                {
                    Console.WriteLine("Вы ввели номер неправильного формата!!!");
                    Console.WriteLine("Повторите попытку!");
                    continue;
                }
            }


        }

        public static string GetUserCode()
        {
            Console.WriteLine("Для ввода другого телефона введите слово \"BACK\"(без кавычек)");
            Console.WriteLine("Введите код с телефона: ");
            return Console.ReadLine();
        }

    }
}
