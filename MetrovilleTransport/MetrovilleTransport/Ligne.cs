namespace MetrovilleTransport;

public class Ligne
{
    private int numeroLigne;
    private Arret[] arrets;
    private Vehicule[] vehicules;

    public Ligne(int numeroLigne, Arret[] arrets, Vehicule[] vehicules)
    {
        this.numeroLigne = numeroLigne;
        this.arrets = arrets;
        this.vehicules = vehicules;
    }

    public void LancerService()
    {
        Console.WriteLine($"\nLancement du service de la ligne {numeroLigne} :");

        foreach (Vehicule vehicule in vehicules)
        {
            vehicule.Demarrer();
        }
    }

    public void SimulerTour()
    {
        Console.WriteLine($"\nSimulation d'un tour complet de la ligne {numeroLigne} :");

        foreach (Vehicule vehicule in vehicules)
        {
            Console.WriteLine($"\n{vehicule.GetTypeVehicule()} n°{vehicule.Numero} commence son tour.");

            foreach (Arret arret in arrets)
            {
                int montes = arret.FaireMonter(5);
                Console.WriteLine($"Arrêt {arret.Nom} : {montes} passager(s) monté(s). Il reste {arret.GetPassagersEnAttente()} passager(s).");
                vehicule.AfficherEtat();
            }
        }
    }
}
