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
            Console.WriteLine(IsBeforeTwenty(115, 50, 1)); // return true
            Console.WriteLine(MoveCharInString("coca"));

            TenNbInTab();
        }

        // https://www.w3resource.com/csharp-exercises/basic-algo/index.php • exercies 46 - verrification de chaine de caractère
        public static string FindChar(string chaine)
        {
            chaine = chaine.ToLower();
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

        //Trouver si la difference des nombres est inférieure a 20 
        public static bool IsBeforeTwenty(int a, int b, int c)
        {
            return Math.Abs(a-b) >=20 || Math.Abs(a-c) >= 20 || Math.Abs(b-c) >= 20;
        }

        public static string MoveCharInString(string chaine)
        {
            if(chaine.Length > 2)
            {
                return chaine.Remove(0, 2) + chaine.Substring(0, 2); // retire les deux prmier caratère de lz chaine et ajoute les deux premier a la fin
            }
            else
            {
                return "Votre chaine de caratzire n'est pas assez longue.";
            }
        }

        //Ecrire un programme qui permet à l'utilisateur d'entrer 10 nombres qui seront stocker dans un tableau
        public static void TenNbInTab()
        {
            int[] arr = new int[10];
            int i;

            for(i= 0; i < arr.Length; i++)
            {
                Console.WriteLine($"{i} tour(s) de boucle");
                try
                {
                    arr[i] = Convert.ToInt32(Console.ReadLine()); // converti l'entrée utilsateur en nombre
                }
                catch
                {
                    Console.WriteLine("Vous devez entrer un nombre valide");
                }
                
            }

            for (i = 0; i < arr.Length; i++)
            {
                Console.Write($"{arr[i]}");
            }
        }
    }

}