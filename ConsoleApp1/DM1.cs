using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {
            //Déclaration des variables.
            string q1, q2, q3, q4, q5, q6, q7, q8, q9, q10;
            q1 = "\nQuel a été le/la candidat(e) du Front National?" +
                "\n Tapez a: Marine Lepen." +
                "\n Tapez b: Nicolas Dupont-Aignan." +
                "\n Tapez c: Philippe Poutou." +
                "\n Tapez d: Jean Lassalle.";

            q2 = "\nQuel a été le/la candidat(e) de la République en Marche ?" +
                "\n Tapez a: Jean Lasalle." +
                "\n Tapez b: Emmanuel Macron." +
                "\n Tapez c: Benoît Hamon." +
                "\n Tapez d: Nathalie Arthaud.";

            q3 = "\nQuel a été le/la candidat(e) les Républicains ?" +
                "\n Tapez a: a Nicolas Sarkozy." +
                "\n Tapez b: Nicolas Dupont-Aignan." +
                "\n Tapez c: François Fillon." +
                "\n Tapez d: Philippe Poutou.";

            q4 = "\nQuel a été le/la candidat(e) de la France Insoumise ?" +
                "\n Tapez a: Jean Luc Mélanchon." +
                "\n Tapez b: François Fillon." +
                "\n Tapez c: Nathalie Arthaud." +
                "\n Tapez d: Philippe Poutou.";

            q5 = "\nQuel a été le/la candidat(e) du Parti Socialiste ?" +
                "\n Tapez a: François Asselineau." +
                "\n Tapez b: Jean Lassalle." +
                "\n Tapez c: Benoît Hamon." +
                "\n Tapez d: Jean-Luc Mélanchon.";

            q6 = "\nQuel a été le/la candidat(e) Debout la France ?" +
                "\n Tapez a: Benoît Hamon." +
                "\n Tapez b: Nicolas Dupont-Aignan." +
                "\n Tapez c: Marine Lepen." +
                "\n Tapez d: Jean Lasalle.";

            q7 = "\nQuel a été le/la candidat(e) Résistons ?" +
                "\n Tapez a: François Fillon." +
                "\n Tapez b: Jean Lassalle." +
                "\n Tapez c: Benoît Hamon." +
                "\n Tapez d: Nathalie Arthaud.";

            q8 = "\nQuel a été le/la candidat(e) du Nouveau Parti Anticapitaliste ?" +
                "\n Tapez a: Emmanuel Macron." +
                "\n Tapez b: Nathalie Arthaud." +
                "\n Tapez c: François Asselineau." +
                "\n Tapez d: Philippe Poutou.";

            q9 = "\nQuel a été le/la candidat(e) de l'Union Populaire Républicaine ?" +
                "\n Tapez a: Nathalie Arthaud." +
                "\n Tapez b: Benoît Hamon." +
                "\n Tapez c: François Fillon." +
                "\n Tapez d: François Asselineau.";

            q10 = "\nQuel a été le/la candidat(e) de Lutte Ouvrière ?" +
                "\n Tapez a: Jean Luc Mélanchon." +
                "\n Tapez b: Nathlie arthaud." +
                "\n Tapez c: François asselineau." +
                "\n Tapez d: Emmanuel Macron.";

            //Déclaration de variables.
            string a, b, c, d, j;
            string SReponse;
            int Total, Joker;
            char Reponse;

            //Affectation des variables.
            Total = 0;
            Joker = 1;

            //Message de bienvenue à l'utilisateur.
            Console.WriteLine("Bonjour ! Nous allons ici revoir par ordre décroissant de leur score les différents candidats pour les élections présidentielles de 2017. " +
                "\nSerez-vous retrouver les candidats de chacun des partis ? C'est ce que nous allons voir !" +
                "\nVous allez donc répondre à un questionnaire sous forme de QCM. Vous aurez le choix parmi 4 réponses, mais une seule est la bonne réponse." +
                "\nSi vous répondez juste, vous obtenez 2 points." +
                "\nA l'inverse si vous répondez faux, vous perdez un point." +
                "\nEnfin vous possèdez un joker qui vous permez, si il est choisit de passer à la question d'après. Cependant il n'est utilisable qu'une seule fois !" +
                "\nAttention! N'essayez pas de tricher, sinon vous perdrez des points! (A vos risques et périls.)" +
                "\nSur ceux, bon jeu!");

            //Attente d'un appui de l'utilisateur pour afficher le reste.
            Console.ReadKey();

            //Première question.
            Console.WriteLine(q1);

            if (Joker == 1) {
                Console.WriteLine("\nTapez j pour utiliser votre joker.");
            }

            SReponse = Console.ReadLine();
            Reponse = char.Parse(SReponse);

            if (Reponse == 'a')
            {
                Total = Total + 2;
                Console.WriteLine("Bravo ! C'est la bonne réponse. Vous avez " + Total + " points.");
            }
            else if (Reponse == 'b')
            {
                Total = Total - 1;
                Console.WriteLine("Dommage, la bonne réponse était la réponse a. Vous avez " + Total + " points.");
            }
            else if (Reponse == 'c')
            {
                Total = Total - 1;
                Console.WriteLine("Dommage, la bonne réponse était la réponse a. Vous avez " + Total + " points.");
            }
            else if (Reponse == 'd')
            {
                Total = Total - 1;
                Console.WriteLine("Dommage, la bonne réponse était la réponse a. Vous avez " + Total + " points.");
            }
            else if (Reponse == 'j')
            {
                if (Joker == 1)
                {
                    Console.WriteLine("Vous utilisez votre joker.");
                    Joker = 0;
                }
                else
                {
                    Total = Total - 2;
                    Console.WriteLine("Vous avez essayé de tricher. Vous avez " + Total + " points.");
                }
                
            }
            else
            {
                Total = Total - 1;
                Console.WriteLine("Vous n'avez pas tapez l'un des choix. Vous essayez sûrement de tricher. Vous perdez un point.");
            }

            Console.ReadKey();

            //Deuxième question.
            Console.WriteLine(q2);

            if (Joker == 1)
            {
                Console.WriteLine("\nTapez j pour utiliser votre joker.");
            }

            SReponse = Console.ReadLine();
            Reponse = char.Parse(SReponse);

            if (Reponse == 'b')
            {
                Total = Total + 2;
                Console.WriteLine("Bravo ! C'est la bonne réponse. Vous avez " + Total + " points.");
            }
            else if (Reponse == 'a')
            {
                Total = Total - 1;
                Console.WriteLine("Dommage, la bonne réponse était la réponse b. Vous avez " + Total + " points.");
            }
            else if (Reponse == 'c')
            {
                Total = Total - 1;
                Console.WriteLine("Dommage, la bonne réponse était la réponse b. Vous avez " + Total + " points.");
            }
            else if (Reponse == 'd')
            {
                Total = Total - 1;
                Console.WriteLine("Dommage, la bonne réponse était la réponse b. Vous avez " + Total + " points.");
            }
            else if (Reponse == 'j')
            {
                if (Joker == 1)
                {
                    Console.WriteLine("Vous utilisez votre joker.");
                    Joker = 0;
                }
                else
                {
                    Total = Total - 2;
                    Console.WriteLine("Vous avez essayé de tricher. Vous avez " + Total + " points.");
                }

            }
            else
            {
                Total = Total - 1;
                Console.WriteLine("Vous n'avez pas tapez l'un des choix. Vous essayez sûrement de tricher. Vous perdez un point.");
            }


            Console.ReadKey();

            //Troixième question.
            Console.WriteLine(q3);

            if (Joker == 1)
            {
                Console.WriteLine("\nTapez j pour utiliser votre joker.");
            }

            SReponse = Console.ReadLine();
            Reponse = char.Parse(SReponse);

            if (Reponse == 'c')
            {
                Total = Total + 2;
                Console.WriteLine("Bravo ! C'est la bonne réponse. Vous avez " + Total + " points.");
            }
            else if (Reponse == 'a')
            {
                Total = Total - 1;
                Console.WriteLine("Dommage, la bonne réponse était la réponse c. Vous avez " + Total + " points.");
            }
            else if (Reponse == 'b')
            {
                Total = Total - 1;
                Console.WriteLine("Dommage, la bonne réponse était la réponse c. Vous avez " + Total + " points.");
            }
            else if (Reponse == 'd')
            {
                Total = Total - 1;
                Console.WriteLine("Dommage, la bonne réponse était la réponse c. Vous avez " + Total + " points.");
            }
            else if (Reponse == 'j')
            {
                if (Joker == 1)
                {
                    Console.WriteLine("Vous utilisez votre joker.");
                    Joker = 0;
                }
                else
                {
                    Total = Total - 2;
                    Console.WriteLine("Vous avez essayé de tricher. Vous avez " + Total + " points.");
                }

            }
            else
            {
                Total = Total - 1;
                Console.WriteLine("Vous n'avez pas tapez l'un des choix. Vous essayez sûrement de tricher. Vous perdez un point.");
            }

            Console.ReadKey();

            //Quatrième question.
            Console.WriteLine(q4);

            if (Joker == 1)
            {
                Console.WriteLine("\nTapez j pour utiliser votre joker.");
            }

            SReponse = Console.ReadLine();
            Reponse = char.Parse(SReponse);

            if (Reponse == 'a')
            {
                Total = Total + 2;
                Console.WriteLine("Bravo ! C'est la bonne réponse. Vous avez " + Total + " points.");
            }
            else if (Reponse == 'b')
            {
                Total = Total - 1;
                Console.WriteLine("Dommage, la bonne réponse était la réponse a. Vous avez " + Total + " points.");
            }
            else if (Reponse == 'c')
            {
                Total = Total - 1;
                Console.WriteLine("Dommage, la bonne réponse était la réponse a. Vous avez " + Total + " points.");
            }
            else if (Reponse == 'd')
            {
                Total = Total - 1;
                Console.WriteLine("Dommage, la bonne réponse était la réponse a. Vous avez " + Total + " points.");
            }
            else if (Reponse == 'j')
            {
                if (Joker == 1)
                {
                    Console.WriteLine("Vous utilisez votre joker.");
                    Joker = 0;
                }
                else
                {
                    Total = Total - 2;
                    Console.WriteLine("Vous avez essayé de tricher. Vous avez " + Total + " points.");
                }

            }
            else
            {
                Total = Total - 1;
                Console.WriteLine("Vous n'avez pas tapez l'un des choix. Vous essayez sûrement de tricher. Vous perdez un point.");
            }

            Console.ReadKey();

            //Cinquième question.
            Console.WriteLine(q5);

            if (Joker == 1)
            {
                Console.WriteLine("\nTapez j pour utiliser votre joker.");
            }

            SReponse = Console.ReadLine();
            Reponse = char.Parse(SReponse);

            if (Reponse == 'c')
            {
                Total = Total + 2;
                Console.WriteLine("Bravo ! C'est la bonne réponse. Vous avez " + Total + " points.");
            }
            else if (Reponse == 'a')
            {
                Total = Total - 1;
                Console.WriteLine("Dommage, la bonne réponse était la réponse c. Vous avez " + Total + " points.");
            }
            else if (Reponse == 'b')
            {
                Total = Total - 1;
                Console.WriteLine("Dommage, la bonne réponse était la réponse c. Vous avez " + Total + " points.");
            }
            else if (Reponse == 'd')
            {
                Total = Total - 1;
                Console.WriteLine("Dommage, la bonne réponse était la réponse c. Vous avez " + Total + " points.");
            }
            else if (Reponse == 'j')
            {
                if (Joker == 1)
                {
                    Console.WriteLine("Vous utilisez votre joker.");
                    Joker = 0;
                }
                else
                {
                    Total = Total - 2;
                    Console.WriteLine("Vous avez essayé de tricher. Vous avez " + Total + " points.");
                }

            }
            else
            {
                Total = Total - 1;
                Console.WriteLine("Vous n'avez pas tapez l'un des choix. Vous essayez sûrement de tricher. Vous perdez un point.");
            }

            Console.ReadKey();

            //Sixième question.
            Console.WriteLine(q6);

            if (Joker == 1)
            {
                Console.WriteLine("\nTapez j pour utiliser votre joker.");
            }

            SReponse = Console.ReadLine();
            Reponse = char.Parse(SReponse);

            if (Reponse == 'b')
            {
                Total = Total + 2;
                Console.WriteLine("Bravo ! C'est la bonne réponse. Vous avez " + Total + " points.");
            }
            else if (Reponse == 'a')
            {
                Total = Total - 1;
                Console.WriteLine("Dommage, la bonne réponse était la réponse b. Vous avez " + Total + " points.");
            }
            else if (Reponse == 'c')
            {
                Total = Total - 1;
                Console.WriteLine("Dommage, la bonne réponse était la réponse b. Vous avez " + Total + " points.");
            }
            else if (Reponse == 'd')
            {
                Total = Total - 1;
                Console.WriteLine("Dommage, la bonne réponse était la réponse b. Vous avez " + Total + " points.");
            }
            else if (Reponse == 'j')
            {
                if (Joker == 1)
                {
                    Console.WriteLine("Vous utilisez votre joker.");
                    Joker = 0;
                }
                else
                {
                    Total = Total - 2;
                    Console.WriteLine("Vous avez essayé de tricher. Vous avez " + Total + " points.");
                }

            }
            else
            {
                Total = Total - 1;
                Console.WriteLine("Vous n'avez pas tapez l'un des choix. Vous essayez sûrement de tricher. Vous perdez un point.");
            }

            Console.ReadKey();

            //Septième question.
            Console.WriteLine(q7);

            if (Joker == 1)
            {
                Console.WriteLine("\nTapez j pour utiliser votre joker.");
            }

            SReponse = Console.ReadLine();
            Reponse = char.Parse(SReponse);

            if (Reponse == 'b')
            {
                Total = Total + 2;
                Console.WriteLine("Bravo ! C'est la bonne réponse. Vous avez " + Total + " points.");
            }
            else if (Reponse == 'a')
            {
                Total = Total - 1;
                Console.WriteLine("Dommage, la bonne réponse était la réponse b. Vous avez " + Total + " points.");
            }
            else if (Reponse == 'c')
            {
                Total = Total - 1;
                Console.WriteLine("Dommage, la bonne réponse était la réponse b. Vous avez " + Total + " points.");
            }
            else if (Reponse == 'd')
            {
                Total = Total - 1;
                Console.WriteLine("Dommage, la bonne réponse était la réponse b. Vous avez " + Total + " points.");
            }
            else if (Reponse == 'j')
            {
                if (Joker == 1)
                {
                    Console.WriteLine("Vous utilisez votre joker.");
                    Joker = 0;
                }
                else
                {
                    Total = Total - 2;
                    Console.WriteLine("Vous avez essayé de tricher. Vous avez " + Total + " points.");
                }

            }
            else
            {
                Total = Total - 1;
                Console.WriteLine("Vous n'avez pas tapez l'un des choix. Vous essayez sûrement de tricher. Vous perdez un point.");
            }

            Console.ReadKey();

            //Huitième question.
            Console.WriteLine(q8);

            if (Joker == 1)
            {
                Console.WriteLine("\nTapez j pour utiliser votre joker.");
            }

            SReponse = Console.ReadLine();
            Reponse = char.Parse(SReponse);

            if (Reponse == 'd')
            {
                Total = Total + 2;
                Console.WriteLine("Bravo ! C'est la bonne réponse. Vous avez " + Total + " points.");
            }
            else if (Reponse == 'a')
            {
                Total = Total - 1;
                Console.WriteLine("Dommage, la bonne réponse était la réponse d. Vous avez " + Total + " points.");
            }
            else if (Reponse == 'b')
            {
                Total = Total - 1;
                Console.WriteLine("Dommage, la bonne réponse était la réponse d. Vous avez " + Total + " points.");
            }
            else if (Reponse == 'c')
            {
                Total = Total - 1;
                Console.WriteLine("Dommage, la bonne réponse était la réponse d. Vous avez " + Total + " points.");
            }
            else if (Reponse == 'j')
            {
                if (Joker == 1)
                {
                    Console.WriteLine("Vous utilisez votre joker.");
                    Joker = 0;
                }
                else
                {
                    Total = Total - 2;
                    Console.WriteLine("Vous avez essayé de tricher. Vous avez " + Total + " points.");
                }

            }
            else
            {
                Total = Total - 1;
                Console.WriteLine("Vous n'avez pas tapez l'un des choix. Vous essayez sûrement de tricher. Vous perdez un point.");
            }

            Console.ReadKey();

            //Neuvième question.
            Console.WriteLine(q9);

            if (Joker == 1)
            {
                Console.WriteLine("\nTapez j pour utiliser votre joker.");
            }

            SReponse = Console.ReadLine();
            Reponse = char.Parse(SReponse);

            if (Reponse == 'd')
            {
                Total = Total + 2;
                Console.WriteLine("Bravo ! C'est la bonne réponse. Vous avez " + Total + " points.");
            }
            else if (Reponse == 'a')
            {
                Total = Total - 1;
                Console.WriteLine("Dommage, la bonne réponse était la réponse d. Vous avez " + Total + " points.");
            }
            else if (Reponse == 'b')
            {
                Total = Total - 1;
                Console.WriteLine("Dommage, la bonne réponse était la réponse d. Vous avez " + Total + " points.");
            }
            else if (Reponse == 'c')
            {
                Total = Total - 1;
                Console.WriteLine("Dommage, la bonne réponse était la réponse d. Vous avez " + Total + " points.");
            }
            else if (Reponse == 'j')
            {
                if (Joker == 1)
                {
                    Console.WriteLine("Vous utilisez votre joker.");
                    Joker = 0;
                }
                else
                {
                    Total = Total - 2;
                    Console.WriteLine("Vous avez essayé de tricher. Vous avez " + Total + " points.");
                }

            }
            else
            {
                Total = Total - 1;
                Console.WriteLine("Vous n'avez pas tapez l'un des choix. Vous essayez sûrement de tricher. Vous perdez un point.");
            }

            Console.ReadKey();

            //Dixième question.
            Console.WriteLine(q10);

            if (Joker == 1)
            {
                Console.WriteLine("\nTapez j pour utiliser votre joker.");
            }

            SReponse = Console.ReadLine();
            Reponse = char.Parse(SReponse);

            if (Reponse == 'b')
            {
                Total = Total + 2;
                Console.WriteLine("Bravo ! C'est la bonne réponse. Vous avez " + Total + " points.");
            }
            else if (Reponse == 'a')
            {
                Total = Total - 1;
                Console.WriteLine("Dommage, la bonne réponse était la réponse b. Vous avez " + Total + " points.");
            }
            else if (Reponse == 'c')
            {
                Total = Total - 1;
                Console.WriteLine("Dommage, la bonne réponse était la réponse b. Vous avez " + Total + " points.");
            }
            else if (Reponse == 'd')
            {
                Total = Total - 1;
                Console.WriteLine("Dommage, la bonne réponse était la réponse b. Vous avez " + Total + " points.");
            }
            else if (Reponse == 'j')
            {
                if (Joker == 1)
                {
                    Console.WriteLine("Vous utilisez votre joker.");
                    Joker = 0;
                }
                else
                {
                    Total = Total - 2;
                    Console.WriteLine("Vous avez essayé de tricher. Vous avez " + Total + " points.");
                }

            }
            else
            {
                Total = Total - 1;
                Console.WriteLine("Vous n'avez pas tapez l'un des choix. Vous essayez sûrement de tricher. Vous perdez un point.");
            }

            Console.ReadKey();

            //Annonce des résultats.
            Console.Write("Ça y est ! Il est l'heure des résultats. Vous avez " + Total + " points. Bravo à vous !");

            //Fin du programme.
            Console.ReadKey();
        }
    }
}
