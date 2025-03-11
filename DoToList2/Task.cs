using System;

public class Task
{
    public string Descriere { get; set; }
    public bool EsteFinalizat { get; set; }

    public Task(string descriere)
    {
        Descriere = descriere;
        EsteFinalizat = false;
    }

    public void MarcheazaFinalizat()
    {
        EsteFinalizat = true;
    }

    public override string ToString()
    {
        return $"{Descriere} - {(EsteFinalizat ? "Completed" : "In Asteptare")}";
    }
}
