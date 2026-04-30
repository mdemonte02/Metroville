namespace MetrovilleTransport;

public abstract class Vehicule
{
    private int numero;
    private int vitesse;
    private int capaciteMax;
    private Moteur moteur;

    public int Vitesse
    {
        get { return vitesse; }
        private set
        {
            if (value < 0 || value > 120)
            {
                throw new ArgumentOutOfRangeException(nameof(Vitesse), "La vitesse doit être comprise entre 0 et 120 km/h.");
            }

            vitesse = value;
        }
    }

    public int Numero
    {
        get { return numero; }
    }

    protected int CapaciteMax
    {
        get { return capaciteMax; }
    }

    protected Moteur Moteur
    {
        get { return moteur; }
    }

    protected Vehicule(int numero, int capaciteMax, int puissanceMoteur)
    {
        this.numero = numero;
        this.capaciteMax = capaciteMax;
        vitesse = 0;
        moteur = new Moteur(puissanceMoteur);
    }

    public void Accelerer(int increment)
    {
        if (increment < 0)
        {
            throw new ArgumentOutOfRangeException(nameof(increment), "L'incrément doit être positif.");
        }

        int nouvelleVitesse = vitesse + increment;

        if (nouvelleVitesse > 120)
        {
            nouvelleVitesse = 120;
        }

        Vitesse = nouvelleVitesse;
    }

    public void Freiner(int decrement)
    {
        if (decrement < 0)
        {
            throw new ArgumentOutOfRangeException(nameof(decrement), "Le décrément doit être positif.");
        }

        int nouvelleVitesse = vitesse - decrement;

        if (nouvelleVitesse < 0)
        {
            nouvelleVitesse = 0;
        }

        Vitesse = nouvelleVitesse;
    }

    public void ImposerVitessePourTest(int nouvelleVitesse)
    {
        Vitesse = nouvelleVitesse;
    }

    public abstract void Demarrer();

    public abstract string GetTypeVehicule();

    public void AfficherEtat()
    {
        string etatMoteur = moteur.EstAllume() ? "allumé" : "éteint";
        Console.WriteLine($"Véhicule n°{numero} | Type : {GetTypeVehicule()} | Vitesse : {vitesse} km/h | Moteur : {etatMoteur}");
    }
}
