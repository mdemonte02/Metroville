namespace MetrovilleTransport;

public class Moteur
{
    private int puissance;
    private bool allume;
    private static int puissanceMax = 500;

    public int Puissance
    {
        get { return puissance; }
    }

    public Moteur(int puissance)
    {
        if (puissance < 0 || puissance > puissanceMax)
        {
            throw new ArgumentOutOfRangeException(nameof(puissance), "La puissance doit être comprise entre 0 et 500 kW.");
        }

        this.puissance = puissance;
        allume = false;
    }

    public void Demarrer()
    {
        allume = true;
    }

    public void Arreter()
    {
        allume = false;
    }

    public bool EstAllume()
    {
        return allume;
    }

    public int GetPuissance()
    {
        return puissance;
    }

    public static int GetPuissanceMax()
    {
        return puissanceMax;
    }
}
