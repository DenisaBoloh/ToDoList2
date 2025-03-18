using System;
using System.Collections.Generic;

public class AdministratorClienti
{
    private List<Persoana> persoane;

    public AdministratorClienti()
    {
        persoane = new List<Persoana>();
    }

    public void AdaugaPersoana(string nume)
    {
        persoane.Add(new Persoana(nume));
    }

    public Persoana CautaPersoana(string nume)
    {
        return persoane.Find(p => p.Nume == nume);
    }

    public List<Persoana> GetPersoane()
    {
        return persoane;
    }
}
