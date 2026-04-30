# Metroville Transport

Projet C# orienté objet simulant le fonctionnement simplifié d'un réseau de transport urbain.

## Objectif

Le programme modélise une flotte de véhicules circulant sur une ligne de transport avec plusieurs arrêts et des passagers en attente.

## Notions utilisées

- Classes et objets
- Encapsulation avec attributs `private`
- Propriétés en lecture seule
- Classe abstraite `Vehicule`
- Héritage avec `Bus`, `Tram` et `MetroAutomatique`
- Polymorphisme avec `Demarrer()` et `GetTypeVehicule()`
- Interface `ILocalisable`
- Méthodes statiques avec `Moteur.GetPuissanceMax()`
- Gestion d'exceptions avec `try/catch`
- Cast sécurisé avec `is`

## Structure du projet

Chaque classe est placée dans son propre fichier `.cs` :

- `Moteur.cs`
- `Vehicule.cs`
- `Bus.cs`
- `Tram.cs`
- `MetroAutomatique.cs`
- `Arret.cs`
- `ILocalisable.cs`
- `Ligne.cs`
- `Program.cs`

## Comment lancer le projet

Dans un terminal, à la racine du projet :

```bash
dotnet run
```

## Auteur

Matéo Demonté
