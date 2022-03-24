using System;
using System.Collections.Generic;
using System.Text;

namespace KD_505.KD_505
{
    internal class User : IAccount
    {
        public int ID;
        public string Fullname;
        public string Email;
        public string Password;
        public static void PasswordChecker()
        {

            string password = Console.ReadLine();

            int BH = 0;

            int KH = 0;
            int R = 0;
            if (password.Length < 8)
            {
                Console.WriteLine("False");
                return;
            }
            else


                for (int i = 0; i < password.Length; i++)
                {
                    char letter = Convert.ToChar(password.Substring(i, 1));

                    if (letter >= 65 && letter <= 90) BH = BH + 1;
                    if (letter >= 97 && letter <= 122) KH = KH + 1;
                    if (letter >= 48 && letter <= 57) R = R + 1;
                }
            if (BH > 0 && KH > 0 && R > 0)
            {
                Console.Write("Uygun Şifre Girilmiştir");
            }
            else
            {
                if (BH == 0) Console.WriteLine("1 böyük hərf olmalı");
                if (KH == 0) Console.WriteLine("1 kiçik hərf olmalı");
                if (R == 0) Console.WriteLine("1 rəqəm olmalı");
               

            }

        }

        string IAccount.PasswordChecker()
        {
            throw new NotImplementedException();
        }

        public string ShowInfo()
        {
            throw new NotImplementedException();
        }

       public static void ShowInfo(int id, string fullname, string email, string password)
        {
            
        }

    }
}
