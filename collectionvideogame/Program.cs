using System;
using System.Data.SqlClient;
using static collectionvideogame.methode;

namespace collectionvideogame
{
    class Program
    {
        static void Main(string[] args)
        {
            string connectionString = @"Data Source=DESKTOP-5N4IVFL;Initial Catalog=CollectionGame;Integrated Security=True;";
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                connection.Open();

                while (true)
                {
                    Console.WriteLine("1. Liste des jeux (Tous)");
                    Console.WriteLine("2. Liste des jeux (Par catégorie)");
                    Console.WriteLine("3. Ajouter un jeu");
                    Console.WriteLine("4. Afficher détail d'un jeu");
                    Console.WriteLine("5. Ajouter catégorie"); 
                    Console.WriteLine("6. Lister les catégories"); 
                    Console.WriteLine("7. Modifier"); 
                    Console.WriteLine("8. Quitter");
                    Console.Write("Choisissez une option : ");

                    string choice = Console.ReadLine();
                    Console.WriteLine("\n");
                    Console.Clear();

                    if (choice == "1")
                    {
                        ListJeux(connection);
                    }
                    else if (choice == "2")
                    {
                        Console.Write("Entrez le nom de la catégorie (Action, Aventure, Stratégie) : ");
                        string categorie = Console.ReadLine();
                        ListJeuxParCategorie(connection, categorie);
                    }
                    else if (choice == "3")
                    {
                        AjouterJeu(connection);
                    }
                    else if (choice == "4")
                    {
                        ListJeux(connection);
                        Console.Write("Entrez le nom du jeu : ");
                        string nomJeu = Console.ReadLine();
                        AfficherDetailJeu(connection, nomJeu);
                    }
                    else if (choice == "5")
                    {
                        AjouterCategorie(connection);
                    }
                    else if (choice == "6")
                    {
                        ListCategories(connection);
                    }
                    else if (choice == "7")
                    {
                        Console.Write("Entrez le nom du jeu à modifier : ");
                        string nomJeu = Console.ReadLine();
                        ModifierJeu(connection, nomJeu);
                    }
                    else if (choice == "8")
                    {
                        break;
                    }
                }
            }
        }
    }
}
