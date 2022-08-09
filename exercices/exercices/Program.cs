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

            Console.WriteLine(IsSomme(1,2,4)); // return false
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

        // https://www.w3resource.com/csharp-exercises/basic-algo/index.php • exercies 47 - Les nombres
        public static bool IsSomme(int nbUn, int nbDeux, int nbTrois)
        {
            bool isSomme = false;
            
            if(nbUn + nbDeux == nbTrois)
            {
                isSomme = true;
            }
            return isSomme;
        }
    }
}