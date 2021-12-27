using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CamelSnakeCase
{
    internal class Program
    {
        #region description
//        Zadanie 2:
//-Stwórz 2 metody ToCamelCase() oraz ToSnakeCase(), w taki sposób że każda z nich jako argument dostaje parametr string
//i konwertuje go odpowiednio do tekstu napisane jako camelCase oraz snake_case.
//CamelCase oznacza że pierwsze litera ciągu jest mała, a każdy kolejny wyraz jest napisany z dużej litery bez spacji.
//A snake_case, oznacza, że wszystkie litery są małe, a wyrazy są od siebie oddzielone znakiem _.
//Przykład:
//-Dla parametru "zostan_programista_dot_net" metoda ToCamelase zwróci "zostanProgramistaDotNet".
//-Dla parametru "zostanProgramistaDotNet" metoda ToSnakeCase zwróci "zostan_programista_dot_net".
//-Dla parametru "dzien_dobry" metoda ToCamelase zwróci "dzienDobry".
//-Dla parametru "dzienDobry" metoda ToSnakeCase zwróci "dzien_dobry".
#endregion


        public static string ToSnakeCase2(string input)
        {
            StringBuilder SB = new StringBuilder();

            foreach (Char C in input)
            {
                if (Char.IsUpper(C))
                    SB.Append('_');

                SB.Append(C.ToString().ToLower());
            }


            return SB.ToString();
        }

        public static string ToCamelCase2(string s)
        {

            string[] sarr = s.Split('_');            
            string s2=string.Empty;
            string s3=string.Empty;

            foreach (var item in sarr)
            {

                if (item == sarr[0])
                {
                    s3 += item;
                }
                else
                {
                    s3 = string.Concat(item[0].ToString().ToUpper(), item.Substring(1).ToString());
                }
                s2 =string.Concat(s2 + s3);
            }
            return s2;
        }


        public static string ToCamelCase(string input)
        {
            string[] sarr = input.Split('_');
            string output = string.Empty;

            foreach (var s in sarr)
            {

                if (s == sarr[0])
                {
                    output += s;
                }
                else output = output + s[0].ToString().ToUpper() + s.Substring(1);

            }

            return output;
        }

        public static string ToSnakeCase(string input)
        {
            string output = string.Empty;

            for (int i = 0; i < input.Length; i++)
            {
                if (char.IsUpper(input[i]))
                {
                    output += "_" + char.ToLower(input[i]);
                }
                else
                    output += input[i];

            }

            return output;
        }



        static void Main(string[] args)
        {

            //-Dla parametru "zostan_programista_dot_net" metoda ToCamelase zwróci "zostanProgramistaDotNet".
            //-Dla parametru "zostanProgramistaDotNet" metoda ToSnakeCase zwróci "zostan_programista_dot_net".
            //-Dla parametru "dzien_dobry" metoda ToCamelase zwróci "dzienDobry".
            //-Dla parametru "dzienDobry" metoda ToSnakeCase zwróci "dzien_dobry".


            Console.WriteLine("ToCamelCase1: " + ToCamelCase("zostan_programista_dot_net"));
            Console.WriteLine("ToCamelCase2: " + ToCamelCase2("zostan_programista_dot_net"));

            Console.WriteLine("ToSnakeCase: " + ToSnakeCase("zostanProgramistaDotNet"));
            Console.WriteLine("ToSnakeCase2: " + ToSnakeCase2("zostanProgramistaDotNet"));

            Console.ReadKey();

        }






    }
}
