using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CoreLib
{
    public class Utils
    {
        public static string GenNumOrder(string client, DateTime date)
        {
            var fullName = client.Split(' ');
            return $"{fullName[0]} {fullName[1].Substring(0, 1)}.{fullName[2].Substring(0, 1)}._{date.ToString("MM.dd.yyyy")}_{date.ToString("HH")}_{date.ToString("mm")}";
        }
        public static string CheckPassword(string Password)
        {
            if (Password.Length < 6 && Password.Length > 10)
            {
                return "Пароль должен быть не менее 6 и не более 10 букв";
            }
            else
            {
                bool isSpec = false;
                foreach (var item in Password)
                {
                    if ("-*|$".Contains(item))
                    {
                        isSpec = true;
                    }
                }
                bool isDigit = false;
                foreach (var item in Password)
                {
                    if (char.IsDigit(item))
                    {
                        isDigit = true;
                    }
                }
                if (isDigit == false)
                {
                    return "Не содержит спец символов";

                }
                bool IsNumber = false;
                foreach (var item in Password)
                {
                    if (char.IsNumber(item))
                    {
                        IsNumber = true;
                    }
                }
                if (IsNumber == false)
                {
                    return "Не содержит цифр";
                }
                bool isUpper = false;
                foreach (var item in Password)
                {
                    if (char.IsUpper(item))
                    {
                        isUpper = true;
                    }
                }
                if (isUpper == false)
                {
                    return "Не содержит больших букв";
                }
                bool Islower = false;
                foreach (var item in Password)
                {
                    if (char.IsLower(item))
                    {
                        Islower = true;
                    }
                }
                if (Islower == false)
                {
                    return "Не содержит маленьких букв";
                }
                if (isSpec == false)
                {
                    return "Не содержит спец символов";
                }
            }
            return "Хороший пароль";
            }
        }
    }

