/**
 * Jeu du nombre caché
 * author : Emds
 * date : 23/05/2020
 */
using System;

namespace NombreCache
{
    class Program
    {
        static int essai;
        static void saisie()
        {
            // saisie du premier essai
            correct = false;
            while (!correct)
            {
                try
                {
                    Console.Write("Entrez un essai = ");
                    essai = int.Parse(Console.ReadLine());
                    correct = true;
                }
                catch
                {
                    Console.WriteLine("Erreur de saisie : saisissez une nombre entier");
                }
            }
        }
        static void Main(string[] args)
        {

            // déclaration
            int valeur = 0, nbre = 1;
            bool correct = false;
            essai = 0;
            // saisie du nombre à chercher
            while (!correct)
            {
                try
                {
                    Console.Write("Entrez le nombre à chercher = ");
                    valeur = int.Parse(Console.ReadLine());
                    correct = true;
                }
                catch
                {
                    Console.WriteLine("Erreur de saisie : saisissez une nombre entier");
                }
            }
            
            saisie();
            
            Console.Clear();
            // boucle sur les essais
            while (essai != valeur)
            {
                // test de l'essai par rapport à la valeur à chercher
                if (essai > valeur)
                {
                    Console.WriteLine(" --> trop grand !");
                }
                else
                {
                    Console.WriteLine(" --> trop petit !");
                }
                
                saisie();
                
                // compteur d'essais
                nbre++;
            }
            // valeur trouvée
            Console.WriteLine("Vous avez trouvé en "+nbre+" fois !");
            Console.ReadLine();
        }
    }
}
