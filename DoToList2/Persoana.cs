using System;
using System.Collections.Generic;

public class Persoana
{
    public string Nume { get; set; }
    public List<Task> Taskuri { get; set; }

    public Persoana(string nume)
    {
        Nume = nume;
        Taskuri = new List<Task>();
    }

    public void AdaugaTask(string descriere)
    {
        Taskuri.Add(new Task(descriere));
    }

    public void MarcheazaTaskFinalizat(int index)
    {
        if (index >= 0 && index < Taskuri.Count)
        {
            Taskuri[index].MarcheazaFinalizat();
        }
    }

    public void AfiseazaToDoList()
    {
        Console.WriteLine($"{Nume}'s To-Do List:");
        foreach (var task in Taskuri)
        {
            Console.WriteLine(task);
        }
        Console.WriteLine();
    }
}
