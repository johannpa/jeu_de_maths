using System;

namespace jeu_de_maths
{

    class Program
    {

        enum e_Operateur
        {
            ADDITION = 1,
            MULTIPLICATION = 2,
            SOUSTRACTION = 3
        }

        static bool PoserQuestion(int min, int max)
        {
            int reponseInt = 0;

            Random rand = new Random();

            while(true)
            {
                int a = rand.Next(min, max + 1);
                int b = rand.Next(min, max + 1);
                e_Operateur operateur = (e_Operateur)rand.Next(1, 4);
                int resultatAttendu;


                if(operateur == e_Operateur.ADDITION) 
                {
                    Console.Write($"{a} + {b} = ");
                    resultatAttendu = a + b;
                }
                else if(operateur == e_Operateur.MULTIPLICATION)
                {
                    Console.Write($"{a} x {b} = ");
                    resultatAttendu = a * b;
                }
                else if (operateur == e_Operateur.SOUSTRACTION)
                {
                    Console.Write($"{a} - {b} = ");
                    resultatAttendu = a - b;
                }
                else
                {
                    Console.WriteLine("ERREUR : opérateur inconnu");
                    return false;
                }



                string reponse = Console.ReadLine();


                try
                {
                    reponseInt = int.Parse(reponse);
                    if(reponseInt == resultatAttendu)
                    {
                        return true;
                    }
                        return false;
                }
                catch
                {
                    Console.WriteLine("ERREUR : Vous devez rentrer un nombre");
                }
            }
            
        }

        static void Main(string[] args)
        {

            const int NOMBRE_MIN = 1;
            const int NOMBRE_MAX = 10;
            const int  NB_QUESTIONS = 5;
            int point = 0;

            for(int i = 0; i < NB_QUESTIONS; i++)
            {
                Console.WriteLine($"Question numéro {i + 1}/{NB_QUESTIONS}");
                bool bonneReponse = PoserQuestion(NOMBRE_MIN, NOMBRE_MAX);
                if(bonneReponse)
                {
                    Console.WriteLine("Bonne réponse");
                    point++;
                }
                else
                {
                    Console.WriteLine("Mauvaise réponse");
                }
                Console.WriteLine();
            }

            if( point > 1)
            {
                Console.WriteLine($"Vous avez {point} bonnes réponses sur {NB_QUESTIONS}");
            }
            else
            {
                Console.WriteLine($"Vous avez {point} bonne réponse sur {NB_QUESTIONS}");
            }


            int moyenne = NB_QUESTIONS / 2;


            if (point == NB_QUESTIONS)
            {
                Console.WriteLine("Bravo, 100%");
            }
            else if (point == 0)
            {
                Console.WriteLine("Révisez vos maths !");
            }
            else if (point > moyenne)
            {
                Console.WriteLine("Pas mal");
            }
            else
            {
                Console.WriteLine("Peut mieux faire");
            }
            

        }
    }
}
