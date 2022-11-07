using System;

namespace PokemonFinal
{
    public class Pokemon
    {
        // getter et setter
        public string Nom { get; set; }
        public int PointsDeVie { get; set; }
        public int Degats { get; set; }
        public int Defense { get; set; }
        public int Vitesse { get; set; }
        public bool Vivant { get; set; } = true;

        int experience = 0;

        public Pokemon()
        {
            // statistiques du pokemon
            Nom = "Pokemon";
            PointsDeVie = 20;
            Degats = 10;
            Defense = 5;
            Vitesse = 100;
        }

        public Pokemon(string nom, int pointsDeVie, int degats, int defense, int vitesse) //constructeur
        {
            Nom = nom;
            PointsDeVie = pointsDeVie;
            Degats = degats;
            Defense = defense;
            Vitesse = vitesse;
        }

        public void Demarrer (int vitesse)
        {
            // fonction qui annonce qui commence le combat en premier
            if (vitesse <= 100)
            {
            // c'est mon pokemon qui commence //
            }
            else
            {
            // sinon si la vitesse est > a 100 alors c'est le pokemon adverse qui commence //
            }
        }

        public void SubirDegat(int degats)
        {
            // fonction subir des degats qui afflige un nombre de degat du pokemon ennemi
            PointsDeVie = PointsDeVie - degats;
            Console.WriteLine("Votre " + Nom + " reçoit " + degats + " points de dégâts ");
            if (PointsDeVie < 0)
            {
                PointsDeVie = 0;
                GameOver();
            }
            else
            {
                Console.WriteLine("Il reste alors " + PointsDeVie + "PV.");
            }
        }

        public void SeSoigner()
        {
            // fonction se soigner qui restaure tous les pv du pokemon
            PointsDeVie = 20;

            Console.WriteLine("Le " + Nom + " a récupérer tous ses PV, il en a : " + PointsDeVie + " PV ");
        }

        public void Potion()
        {
            // fonction potion qui ajoute 5 pv a la santé du pokemon
            PointsDeVie = PointsDeVie + 5;
        }

        public void GameOver()
        {
            // fonction game over qui indique lorsqu'on meurt si l'ont souhaiter recommencer une partie ou alors quitter le jeu
            Console.WriteLine("Le pokemon vous a eu, vous êtes mort...");
            Vivant = false;
        }

        public void Capture()
        {
            // if (Ennemi.PointsDeVie < 5) si les points de vie de l'ennemi sont inferieur a 5
            {// avec un var random on a 1 chance sur 2 de reussir à le capteur
                // Capture = (random);
                // 
            }
            else
            {
                Console.WriteLine("Vous n'avez pas réussi à capturer le pokemon"); // sinon nous avons echoué 
            }
        }
        
    }
}