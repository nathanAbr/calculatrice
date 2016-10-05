using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace calculatrice
{
    class Program
    {
        static void Main(string[] args)
        {
            bool continuer = true;
            while(continuer)
            {
                string[] operateur = new string[] { "+", "*", "/", "-" };
                Console.WriteLine("Veuillez choisir un opérateur (+, /, *, -)");
                string choixOpe = Console.ReadLine();
                foreach(string ope in operateur)
                { 
                    if (choixOpe == ope)
                    {
                        if (choixOpe == "+")
                        {
                            addition();
                        }
                        if (choixOpe == "/")
                        {
                            Console.WriteLine("Désirez vous la division euclidienne ? (oui sinon tapez sur un autre touche)");
                            string ok = Console.ReadLine();
                            if (ok != "oui")
                            {
                                division();
                            }
                            else { divisionEuclid(); }
                        }
                        if (choixOpe == "-")
                        {
                            soustraction();
                        }
                        if (choixOpe == "*")
                        {
                            multiplication();
                        }
                    }
                }
                Console.WriteLine("Souhaitez-vous faire une autre opération ? (Si oui tapez oui sinon appuyer sur n'importe quelles touche)");
                string next = Console.ReadLine();
                if(next != "oui")
                {
                    continuer = false;
                }
            }
        }

       /*public static int[] saisirNombre()
        {
            bool continuer = true;
            string element;
            int[] tab = new int[] {};
            while (continuer)
            {
                element = Console.ReadLine();
                if (element == "=")
                {
                    continuer = false;
                }
                tab = new int[] {int.Parse(element)};
            }

            return tab;
        }

        public static void addition(int[] tab)
        {
            int somme = 0;
            for (int i = 0; i < tab.Length; i++)
            {
                somme += tab.ElementAt(i);
            }
            
            Console.WriteLine("Le résultat de votre addition est " + somme);
        }

        public static void choisirOperateur()
        {

        }*/

        public static void addition()
        {
            int nbr1 = 0;
            int nbr2 = 0;
            Console.WriteLine("Bonjour, Veuillez saisir un premier nombre :");
            nbr1 = int.Parse(Console.ReadLine());
            Console.WriteLine("Bonjour, Veuillez saisir un second nombre :");
            nbr2 = int.Parse(Console.ReadLine());
            int resultat = nbr1 + nbr2;
            Console.WriteLine("Le résult de l'addition est :" + resultat);
        }

        public static void soustraction()
        {
            int nbr1 = 0;
            int nbr2 = 0;
            Console.WriteLine("Bonjour, Veuillez saisir un premier nombre :");
            nbr1 = int.Parse(Console.ReadLine());
            Console.WriteLine("Bonjour, Veuillez saisir un second nombre :");
            nbr2 = int.Parse(Console.ReadLine());
            int resultat = nbr1 - nbr2;
            Console.WriteLine("Le résultat de l'addition est :" + resultat);
        }

        public static void multiplication()
        {
            int nbr1 = 0;
            int nbr2 = 0;
            Console.WriteLine("Bonjour, Veuillez saisir un premier nombre :");
            nbr1 = int.Parse(Console.ReadLine());
            Console.WriteLine("Bonjour, Veuillez saisir un second nombre :");
            nbr2 = int.Parse(Console.ReadLine());
            int resultat = nbr1 * nbr2;
            Console.WriteLine("Le résult de l'addition est :" + resultat);
        }

        public static void division()
        {
            float nbr1 = 0;
            float nbr2 = 0;
            Console.WriteLine("Bonjour, Veuillez saisir un premier nombre :");
            nbr1 = float.Parse(Console.ReadLine());
            Console.WriteLine("Bonjour, Veuillez saisir un second nombre :");
            nbr2 = float.Parse(Console.ReadLine());
            if (nbr2 != 0)
            {
                float resultat = nbr1 / nbr2;
                Console.WriteLine("Le résult de l'addition est :" + resultat);
            }
            else { Console.WriteLine("La division par zéro est interdite je te crache à la gueule !!"); }
            
        }

        public static void divisionEuclid()
        {
            int nbr1 = 0;
            int nbr2 = 0;
            Console.WriteLine("Bonjour, Veuillez saisir un premier nombre :");
            nbr1 = int.Parse(Console.ReadLine());
            Console.WriteLine("Bonjour, Veuillez saisir un second nombre :");
            nbr2 = int.Parse(Console.ReadLine());
            if (nbr2 != 0)
            {
                float resultat = nbr1 / nbr2;
                float reste = nbr1 % nbr2;
                Console.WriteLine("Le résult de l'addition euclidienne : qutient =" + resultat + "reste = " + reste);
            }
            else { Console.WriteLine("La division par zéro est interdite je te crache à la gueule !!"); }

        }

    }
}
