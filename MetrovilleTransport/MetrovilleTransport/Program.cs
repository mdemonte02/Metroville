namespace MetrovilleTransport;

internal class Program
{
    private static void Main(string[] args)
    {
        Bus bus1 = new Bus(1, 60, 300, true);
        Bus bus2 = new Bus(2, 60, 300, false);
        Tram tram = new Tram(3, 120, 450, 2);
        MetroAutomatique metro = new MetroAutomatique(4, 200, 500);

        Vehicule[] flotte = { bus1, bus2, tram, metro };

        Arret gareCentrale = new Arret("Gare Centrale");
        Arret universite = new Arret("Université");
        Arret marche = new Arret("Marché");

        gareCentrale.AjouterPassagers(10);
        universite.AjouterPassagers(6);
        marche.AjouterPassagers(8);

        Arret[] arrets = { gareCentrale, universite, marche };

        Ligne ligne42 = new Ligne(42, arrets, flotte);

        Console.WriteLine($"Puissance maximale autorisée : {Moteur.GetPuissanceMax()} kW");

        ligne42.LancerService();
        ligne42.SimulerTour();

        Console.WriteLine("\nTest de vitesse sur le bus n°1 :");
        bus1.Accelerer(40);
        bus1.AfficherEtat();

        try
        {
            bus1.ImposerVitessePourTest(-50);
        }
        catch (ArgumentOutOfRangeException ex)
        {
            Console.WriteLine($"Erreur de vitesse : {ex.Message}");
        }

        ILocalisable busLocalisable = bus1;
        busLocalisable.ActualiserPosition(50.85, 4.35);
        Console.WriteLine($"\nPosition GPS du bus n°1 : latitude = {busLocalisable.Latitude}, longitude = {busLocalisable.Longitude}");

        Console.WriteLine("\nTypes des véhicules de la flotte :");
        foreach (Vehicule vehicule in flotte)
        {
            Console.WriteLine($"- {vehicule.GetTypeVehicule()}");
        }

        Console.WriteLine("\nDétection du métro automatique :");
        foreach (Vehicule vehicule in flotte)
        {
            if (vehicule is MetroAutomatique metroAutomatique)
            {
                metroAutomatique.SignalerIncident("Porte bloquée");
            }
        }
    }
}
