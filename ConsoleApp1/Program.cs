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
                "\n Tapez d: Jean Lassalle.";

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
            string a, b, c, d;
            int Joker, Total;
            string Reponse;

            //Affectation des variables.
            Total = 0;
            Joker = 1;

            //Message de bienvenue à l'utilisateur.
            Console.WriteLine("Bonjour ! Nous allons ici revoir par ordre décroissant de leur score les différents candidats pour les élections présiendentielles de 2017. " +
                "\nSerez vous retrouver les candidats de chacun des parties ? C'est ce que nous allons voir !" +
                "\n Vous allez donc répondre à un questionnaire sous forme de QCM.Vous aurez le choix parmi 4 réponses, mais une seule est la bonne réponse." +
                "\n Si vous répondez juste, vous obtenez 2 points." +
                "\n A l'inverse si vous répondez faux, vous perdez un point." +
                "\n Enfin vous possèdez un joker qui vous permez, si il est choisit de passer à la question d'après. Cependant il n'est utilisable qu'une seule fois !" +
                "\n Attention !N'essayez pas de tricher, sinon vous perdrez des points ! (A vos risques et périls.)" +
                "\n Sur ceux, bon jeu !");

            Console.ReadKey();

            Console.Write(q1);

            //Fin du programme.
            Console.ReadKey();
        }
    }
}
