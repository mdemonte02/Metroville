namespace MetrovilleTransport;

public class Arret
{
    private string nom;
    private int passagersEnAttente;

    public string Nom
    {
        get { return nom; }
    }

    public Arret(string nom)
    {
        this.nom = nom;
        passagersEnAttente = 0;
    }

    public void AjouterPassagers(int nb)
    {
        if (nb < 0)
        {
            throw new ArgumentOutOfRangeException(nameof(nb), "Le nombre de passagers ne peut pas être négatif.");
        }

        passagersEnAttente += nb;
    }

    public int FaireMonter(int nb)
    {
        if (nb < 0)
        {
            throw new ArgumentOutOfRangeException(nameof(nb), "Le nombre de passagers ne peut pas être négatif.");
        }

        int montes = Math.Min(nb, passagersEnAttente);
        passagersEnAttente -= montes;
        return montes;
    }

    public int GetPassagersEnAttente()
    {
        return passagersEnAttente;
    }
}
