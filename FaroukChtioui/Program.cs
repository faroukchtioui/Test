using System;

namespace FaroukChtioui
{

    class Program
    {
        static void Main()
        {
            double prixLaitPoudre = 10 * (1/(1-0.3));
            double prixCafe = 30 * (1/(1-0.3));
            double prixChocolat = 40 * (1/(1-0.3));
            double prixThe = 30 * (1/(1-0.3));
            double prixEau = 5 * (1/(1-0.3));

            double prixEspresso = 2 * prixEau + prixCafe;
            double prixLait = 2 * prixLaitPoudre + prixEau;
            double prixCapuccino = 2 * prixLaitPoudre + prixCafe + prixChocolat + prixEau;
            double prixChocolatChaud = 3 * prixEau + 2 * prixChocolat;
            double prixCafeAuLait = prixLaitPoudre + 2 * prixEau + prixCafe;
            double prixMokaccino = prixLaitPoudre + 2 * prixEau + prixCafe + 2 * prixChocolat;
            double prixThé = 2 * prixEau + prixThe;
            


            int choixBoisson;
            string[] boissons = { "espresso", "lait", "capuccino", "chocolat chaud", "café au lait", "mokaccino", "thé" };

            Console.WriteLine("Veuillez choisir une boisson :");
            for (int i = 0; i < boissons.Length; i++)
            {
                Console.WriteLine($"{i + 1}. {boissons[i]}");
            }
            choixBoisson = int.Parse(Console.ReadLine());

            Console.WriteLine($"Vous avez choisi un {boissons[choixBoisson - 1]}.");
            switch (choixBoisson)
            {
                case 1:
                    Console.WriteLine($"Le prix est de {prixEspresso} cents.");
                    break;
                case 2:
                    Console.WriteLine($"Le prix est de {prixLait} cents.");
                    break;
                case 3:
                    Console.WriteLine($"Le prix est de {prixCapuccino} cents.");
                    break;
                case 4:
                    Console.WriteLine($"Le prix est de {prixChocolatChaud} cents.");
                    break;
                case 5:
                    Console.WriteLine($"Le prix est de {prixCafeAuLait} cents.");
                    break;
                case 6:
                    Console.WriteLine($"Le prix est de {prixMokaccino} cents.");
                    break;
                case 7:
                    Console.WriteLine($"Le prix est de {prixThé} cents.");
                    break;
                default:
                    Console.WriteLine("Choix invalide.");
                    break;
            }

            Console.WriteLine("Merci d'avoir choisi notre distributeur à café");
            Console.ReadLine();
        }
    }

}
