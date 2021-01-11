using System;


namespace SendMessage
{
    class Program
    {
        static void Main(string[] args)
        {
            bool isLogUp = false;
            while (true)
            {
                Console.Clear();
                Console.WriteLine("----------------------PROGRAMM----------------------");
                string phoneNumber = Menu.GetPhoneNumber();
                string randomCode = ServiceClass.GetRandomCode();
                try
                {
                    TwillioClass.SendMessage(phoneNumber, randomCode);
                }
                catch
                {
                    Console.WriteLine("Ой...что-то пошло не так, попробуйте позже!");
                    Console.ReadLine();
                    break;
                }
                while (true)
                {
                    string userCode = Menu.GetUserCode();
                    if (ServiceClass.CheckCode(randomCode, userCode))
                    {
                        Console.WriteLine("Регистрация прошла успешно!");
                        isLogUp = true;
                        break;
                    }
                    else if (userCode.ToLower() == "back")
                    {
                        break;
                    }
                    else
                    {
                        Console.WriteLine("Неверный код, повторите попытку!!!");
                    }
                }
                if (isLogUp) break;
            }

        }
    }
}
