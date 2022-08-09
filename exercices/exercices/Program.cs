using System;

namespace exercices
{
    internal class Programme
    {
        static void Main(string[] args)
        {
            string TheAlert = "";
            TheAlert = FindChar("ezeqsdb");   
            Console.WriteLine(TheAlert);
        }

        // https://www.w3resource.com/csharp-exercises/basic-algo/index.php • exercies 46 - verrification de chaine de caractère
        public static string FindChar(string chaine)
        {
            string result = "";

            if(chaine.StartsWith('f'))
            {
                result += "Fizz";
            }
            if (chaine.EndsWith("b"))
            {
                result += "Buzz";
            }
            if (String.IsNullOrEmpty(result))
            {
                result += "Aucun des deux";
            }
            return result;
        }
    }
}