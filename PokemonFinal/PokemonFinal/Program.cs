namespace PokemonFinal
{
    internal class Program
    {
        public static void Main(string[] args)
        {
            Console.WriteLine("Quel pokemon choisissez vous ? : \n1 - Skitty \n2 - Pikachu \n3 - Jirachi"); // propose 3 pokemon parmis les choix ci-dessous
            switch (Console.ReadLine())
            {
                case "1":
                    Console.WriteLine("Skitty");
                    break;
                case "2":
                    Console.WriteLine("Pikachu");
                    break;
                case "3":
                    Console.WriteLine("Jirachi");
                    break;
            }

            Pokemon pokemon = new(); // créer un nouveau pokemon
            bool game = true;
            Ennemi ennemi = new(); // créer un ennemi avec des caracteristiques random appliquées dans la classe ennemi

            while (game && pokemon.Vivant)
            {
                if (ennemi.PointsDeVie <= 0)
                {
                    ennemi = new Ennemi();
                }

                Console.WriteLine("Quel action voulez-vous faire ? : \n1 - Allez combattre \n2 - Se soigner \n3 - Statistiques \n4 - Quitter le jeu "); // choix des différentes actions avant le combat
                switch (Console.ReadLine())
                {
                    case "1":
                        ennemi.PrendreDegats(pokemon.Degats); // l'ennemi prend un certain nombre de dégats en fonction des dégats du pokemon
                        break;
                    case "2":
                        pokemon.SeSoigner(); // le pokemon recupère la totalité de ses PV
                        break;
                    case "3":
                        Console.WriteLine("Point de vie : 100PV");
                        Console.WriteLine("Degats : 10");
                        Console.WriteLine("Vitesse : 90");
                        Console.WriteLine("Expérience : "); ennemi.Experience();
                        break;
                    case "4":
                        Console.WriteLine("Voulez-vous quitter le jeu ? (oui/non)");
                        if (Console.ReadLine() != "oui")
                        {
                            game = !game;
                        }
                        else
                        {
                            Console.WriteLine("relancer le jeu");
                        }
                        break;
                }

                Console.WriteLine("Que voulez-vous faire ? : \n1 - Attaquer \n2 - Potion \n3 - Fuir "); // choix des actions durant le combat 
                switch (Console.ReadLine())
                {
                    case "1":
                        pokemon.SubirDegat(ennemi.Degats); // le pokemon va subir un nombre random de dégats de l'ennemi 
                        break;
                    case "2":
                        pokemon.Potion(); // le pokemon va récupérer 5 pv grâce à la potion
                        break;
                    case "3":
                        Console.WriteLine("Voulez-vous abandonner le combat ? (oui/non)");
                        if (Console.ReadLine() != "oui")
                        {
                            game = !game;
                        }
                        else
                        {
                            ennemi.PrendreDegats(pokemon.Degats);
                        }
                        break;
                }
            }

            if (ennemi.PointsDeVie <= 0)
            {
                Console.WriteLine("Bravo, vous avez tuer le " + ennemi.Nom);
                Console.WriteLine("Voulez-vous continuer à jouer ? (oui/non)");
                if (Console.ReadLine() != "oui")
                {
                    game = !game;
                }

                else
                {
                    pokemon.SubirDegat(ennemi.Degats);
                }
            }
            Console.WriteLine("A bientôt :) ");
        }
    }
}