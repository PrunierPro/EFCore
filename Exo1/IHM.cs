using Exo1.Data;
using Exo1.Models;
using Microsoft.EntityFrameworkCore.Migrations.Operations;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exo1
{
    internal static class IHM
    {
        public static void Start()
        {
            Console.WriteLine("=== MENU PRINCIPAL ===");
            Console.WriteLine("1. Voir les adresses");
            Console.WriteLine("2. Ajouter une adresse");
            Console.WriteLine("3. Editer une adresse");
            Console.WriteLine("4. Supprimer une adresse");
            Console.WriteLine("0. Quitter le programme");
            Console.Write("Votre choix : ");
            string choice = Console.ReadLine();

            Console.Clear();
            switch (choice)
            {
                case "0":
                    Environment.Exit(0);
                    break;
                case "1":
                    ShowAll();
                    break;
                case "2":
                    Add();
                    break;
                case "3":
                    Edit();
                    break;
                case "4":
                    Delete();
                    break;
                default:
                    Console.WriteLine("Erreur de saisie");
                    Start();
                    break;
            }
        }
        private static void ShowAll()
        {
            using ApplicationDbContext context = new ApplicationDbContext();

            Console.WriteLine("=== Liste des adresses ===");
            List<Address> addresses = context.Addresses.ToList();
            foreach(Address a in addresses)
            {
                Console.WriteLine($"\t--{a}");
            }
            Console.WriteLine();
            Start();

        }

        private static void Add()
        {
            using ApplicationDbContext context = new ApplicationDbContext();

            context.Add(CreateAddress());
            if(context.SaveChanges() > 0) Console.WriteLine("Adresse ajoutée");
            else Console.WriteLine("Erreur d'ajout");
            Console.WriteLine();
            Start();
        }

        private static void Edit()
        {
            using ApplicationDbContext context = new ApplicationDbContext();

            Console.WriteLine("=== Editer une adresse ===");
            Console.WriteLine("Entrer les infos de l'adrese à modifier: ");
            Console.Write("Entrer le numéro de voie: ");
            int number = int.Parse(Console.ReadLine());
            Console.Write("Entrer l'intitulé de voie: ");
            string name = Console.ReadLine();
            Console.Write("Entrer la commune: ");
            string commune = Console.ReadLine();
            Console.WriteLine();

            Address address = context.Addresses.FirstOrDefault(a => a.Number == number && a.Name.Equals(name) && a.Commune.Equals(commune));
            if (address.Equals(default))
            {
                Console.WriteLine("Aucune adresse trouvée\n");
            }
            else
            {
                Console.WriteLine($"Adresse trouvée: {address}");

                address = CreateAddress();

                context.Addresses.Update(address);
                if(context.SaveChanges() > 0) Console.WriteLine("Adresse modifiée");
                else Console.WriteLine("Erreur");
                Console.WriteLine();
            }
            Start();
        }

        private static void Delete()
        {
            using ApplicationDbContext context = new ApplicationDbContext();

            Console.WriteLine("=== Supprimer une adresse ===");
            Console.WriteLine("Entrer les infos de l'adrese à supprimer: ");
            Console.Write("Entrer le numéro de voie: ");
            int number = int.Parse(Console.ReadLine());
            Console.Write("Entrer l'intitulé de voie: ");
            string name = Console.ReadLine();
            Console.Write("Entrer la commune: ");
            string commune = Console.ReadLine();
            Console.WriteLine();

            Address address = context.Addresses.FirstOrDefault(a => a.Number == number && a.Name.Equals(name) && a.Commune.Equals(commune));
            if (address.Equals(default))
            {
                Console.WriteLine("Aucune adresse trouvée\n");
            }
            else
            {
                Console.WriteLine($"Adresse trouvée: {address}");
                Console.Write("Supprimer? Y/N");
                string choice = Console.ReadLine();
                if(choice.ToUpper().Equals("Y"))
                {
                    context.Addresses.Remove(address);
                    if(context.SaveChanges() > 0) Console.WriteLine("Adresse supprimée");
                    else Console.WriteLine("Erreur");
                } else
                {
                    Console.WriteLine("Opération annulée");
                }
            }
            Start();
        }

        private static Address CreateAddress()
        {
            Console.Write("Entrer le numéro de voie: ");
            int number = int.Parse(Console.ReadLine());
            Console.Write("Entrer le complément d'adresse: ");
            string complement = Console.ReadLine();
            Console.Write("Entrer l'intitulé de voie: ");
            string name = Console.ReadLine();
            Console.Write("Entrer la commune: ");
            string commune = Console.ReadLine();
            Console.Write("Entrer le code postal: ");
            int postalcode = int.Parse(Console.ReadLine());

            Address address = new Address()
            {
                Number = number,
                Complement = complement,
                Name = name,
                Commune = commune,
                PostalCode = postalcode
            };

            return address;
        }
    }
}
