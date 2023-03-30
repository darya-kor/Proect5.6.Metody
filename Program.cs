using System.Diagnostics;
using System.Drawing;

namespace Proect5._6.Metody
{
    internal class Program
    {
        static void Main(string[] args)
        {
            var user = EnterUser();
            ShowUser(user);
        }
            static (string Name, string LastName, int Age, string[] Pet, string[] Color) EnterUser()
            {
                (string Name, string LastName, int Age, string[] Pet, string[] Color) User;
                Console.WriteLine("Введите имя");
                User.Name = Console.ReadLine();
                
                Console.WriteLine("Введите фамилию");
                User.LastName = Console.ReadLine();

                string strage;
                int intage;
                do
                {
                    Console.WriteLine("Введите возраст");
                    strage = Console.ReadLine();
                }
                while (CheckNum(strage, out intage));
                User.Age = intage;

                Console.WriteLine("У вас есть питомец?");
                string havepet = Console.ReadLine();
                if(havepet == "Да" || havepet == "да")
                {
                    string strpet;
                    int intpet;
                    do
                    {
                        Console.WriteLine("Сколько у вас пиомцев?");
                        strpet = Console.ReadLine();
                    }
                    while (CheckNum(strpet, out intpet));
                    User.Pet = ShowPet(intpet);
                }
                else
                {
                    User.Pet = null;
                }

                string strcolor;
                int intcolor;
                do
                {
                    Console.WriteLine("Сколько у вас любимых цветов?");
                    strcolor = Console.ReadLine();
                }
                while (CheckNum(strcolor, out intcolor));
                User.Color = ShowColor(intcolor);
                
            return User;
            }
            
            static bool CheckNum(string strnumber, out int intnumber)
            {
                if(int.TryParse(strnumber, out int intage))
                {
                    if (intage > 0)
                    {
                        intnumber = intage;
                        return false;
                    }
                }
                intnumber = 0;
                return true;
            }
            static string[] ShowPet(int intpet)
            {
                string[] Pet = new string[intpet];
                for (int i = 0; i < intpet; i++) 
                {
                    Console.WriteLine($"Введите имя питомца {i + 1}");
                    Pet[i] = Console.ReadLine();
                }
                return Pet;
            }
            static string[] ShowColor(int intcolor)
            {
                string[] Color = new string[intcolor];
                for (int i = 0; i < intcolor; i++)
                {
                    Console.WriteLine($"Введите любимый цвет {i + 1}");
                    Color[i] = Console.ReadLine();
                }
                return Color;
            }
            static void ShowUser((string Name, string LastName, int Age, string[] Pet, string[] Color) User)
            {
                Console.WriteLine($"Имя: {User.Name}");
                Console.WriteLine($"Фамилия: {User.LastName}");
                Console.WriteLine($"Возраст: {User.Age}");
            foreach(var namepet in User.Pet)
            {
                if(namepet == null) continue;
                Console.WriteLine("Имя питомца: {0}", namepet);
            }
            foreach(var namecolor in User.Color)
            {
                if (namecolor == null) continue;
                    Console.WriteLine("Цвет: {0}", namecolor);
            }
              
            }
            
        
    }
}