using System;
using System.Collections.Generic;

class Program
{
    static void Main()
    {
        AdministratorClienti admin = new AdministratorClienti();

        while (true)
        {
            Console.WriteLine("\nMeniu:");
            Console.WriteLine("1. Adauga persoana");
            Console.WriteLine("2. Adauga task unei persoane");
            Console.WriteLine("3. Afiseaza toate listele de taskuri");
            Console.WriteLine("4. Marcheaza un task ca finalizat");
            Console.WriteLine("5. Iesire");
            Console.Write("Alege o optiune: ");
            

            string optiune = Console.ReadLine();
            switch (optiune)
            {
                case "1":
                    Console.Write("Introdu numele persoanei: ");
                    string numePersoana = Console.ReadLine();
                    admin.AdaugaPersoana(numePersoana);
                    break;

                case "2":
                    Console.Write("Introdu numele persoanei: ");
                    string nume = Console.ReadLine();
                    Persoana persoana = admin.CautaPersoana(nume);
                    if (persoana != null)
                    {
                        Console.Write("Descrierea taskului: ");
                        string descriereTask = Console.ReadLine();
                        persoana.AdaugaTask(descriereTask);
                    }
                    else
                    {
                        Console.WriteLine("Persoana nu a fost gasită.");
                    }
                    break;

                case "3":
                    foreach (var p in admin.GetPersoane())
                    {
                        p.AfiseazaToDoList();
                    }
                    break;

                case "4":
                    Console.Write("Introdu numele persoanei: ");
                    string numeCautat = Console.ReadLine();
                    Persoana pGasita = admin.CautaPersoana(numeCautat);
                    if (pGasita != null)
                    {
                        pGasita.AfiseazaToDoList();
                        Console.Write("Introdu numarul taskului de marcat ca finalizat: ");
                        if (int.TryParse(Console.ReadLine(), out int index) && index > 0 && index <= pGasita.Taskuri.Count)
                        {
                            pGasita.MarcheazaTaskFinalizat(index - 1);
                            Console.WriteLine("Task marcat ca finalizat!");
                        }
                        else
                        {
                            Console.WriteLine("Numar invalid.");
                        }
                    }
                    else
                    {
                        Console.WriteLine("Persoana nu a fost găsită.");
                    }
                    break;

                case "5":
                    return;

                default:
                    Console.WriteLine("Opțiune invalida.");
                    break;
            }
        }
    }
}