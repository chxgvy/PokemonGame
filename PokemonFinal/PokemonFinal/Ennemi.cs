namespace PokemonFinal
{
    internal class Ennemi
    {
        // info random des pokemon adverse 
        string[] NomsRandoms = { "Ectoplasma", "Mewtwo", "Tortank" };
        int[] PVRandoms = { 15, 20, 25 };
        int[] DegatsRandoms = { 5, 7, 10 };
        int[] VitesseRandoms = { 90, 100, 110 };

        int experience = 0;

        // getter et setter
        public string Nom { get; set; }
        public int PointsDeVie { get; set; }
        public int Degats { get; set; }
        public int Vitesse { get; set; }


        public Ennemi()
        {
            // fonction random qui va chercher la valeur entre 0 à 3 et ainsi l'afficher dans la console
            Random random = new Random();
            Nom = NomsRandoms[random.Next(0, 3)];
            PointsDeVie = PVRandoms[random.Next(0, 3)];
            Degats = DegatsRandoms[random.Next(0, 3)];
            Vitesse = VitesseRandoms[random.Next(0, 3)];

            Console.WriteLine("Fait attention, un " + Nom + " t'attaque !");
        }

        public void PrendreDegats(int degats)
        {
            // fonction qui indique combien de degats prend le pokemon adverse
            PointsDeVie = PointsDeVie - degats;
            Console.WriteLine("Le " + Nom + " reçoit " + degats + " points de dégâts");
            if (PointsDeVie < 0)
            {
                PointsDeVie = 0;
            }
            else
            {
                Console.WriteLine("Il lui reste " + PointsDeVie + "PV.");
            }
        }

        public void Experience()
        {
            // fonction qui fait augmenter l'expérience à chaque fois que l'ont tue un pokemon
            if (PointsDeVie < 0)
            {
                experience = experience + 15; // si les points de vie de l'ennemi sont à 0 alors on prend +15 d'XP
            }
            else
            {
                Console.WriteLine("Tu ne gagnes pas d'XP"); //sinon si on ne tue pas le pokemon on ne gagne pas d'XP
            }
        }
    }
}