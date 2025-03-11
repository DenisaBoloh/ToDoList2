using System;
using System.Collections.Generic;

class Program
{
    static void Main()
    {
        List<Persoana> persoane = new List<Persoana>();

        // Creăm două persoane
        Persoana denisa = new Persoana("Denisa");
        Persoana alex = new Persoana("Alex");

        // Adăugăm taskuri pentru fiecare
        denisa.AdaugaTask("Cumpara lapte");
        denisa.AdaugaTask("Finalizeaza proiectul .NET");

        alex.AdaugaTask("Citeste o carte");
        alex.AdaugaTask("Fa sport");

        // Adăugăm persoanele în listă
        persoane.Add(denisa);
        persoane.Add(alex);

        // Afișăm toate listele de taskuri
        foreach (var persoana in persoane)
        {
            persoana.AfiseazaToDoList();
        }

        // Exemplu: Marcăm primul task al Denisei ca finalizat
        denisa.MarcheazaTaskFinalizat(0);

        Console.WriteLine("Dupa actualizare:");
        denisa.AfiseazaToDoList();
    }
}
