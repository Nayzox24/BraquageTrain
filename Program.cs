namespace Braquage_train;

class Program
{
    static void Main(string[] args)
    {
        /*
         * Consignes :
           - Utiliser une première boucle pour parcourir les quatre wagons.
           - Utiliser une deuxième boucle à l'intérieur pour parcourir les trois coffres de chaque wagon.
           - Afficher chaque coffre inspecté avec son numéro de wagon.
           - Compter le nombre total de coffres inspectés.
           
           Exemple :
               Inspection des 4 wagons du train
               Wagon 1 - Coffre 1 inspecté
               Wagon 1 - Coffre 2 inspecté
               Wagon 1 - Coffre 3 inspecté
               Wagon 2 - Coffre 1 inspecté
               ...
               Total : 12 coffres inspectés.
            
            BONUS 1 : permettre à l'utilisateur de choisir le nombre de wagons
            BONUS 2 : enregistrer l'ensemble du butin trouvé et l'afficher à la fin
         */
        Console.Write("Combien de wagons voulez-vous inspecter ? ");
        int wagons = int.Parse(Console.ReadLine()!);

        int totalCoffres = 0;
        List<string> butin = new List<string>();

        Console.WriteLine($"Inspection des {wagons} wagons du train");

        for (int wagon = 1; wagon <= wagons; wagon++)
        {
            for (int coffre = 1; coffre <= 3; coffre++)
            {
                Console.WriteLine($"Wagon {wagon} - Coffre {coffre} inspecté");
                totalCoffres++;

                Console.Write("Quel butin avez-vous trouvé ? ");
                string objet = Console.ReadLine() ?? "";

                butin.Add(objet);
            }
        }

        Console.WriteLine($"\nTotal : {totalCoffres} coffres inspectés.");

        Console.WriteLine("Butin trouvé :");

        foreach (string objet in butin)
        {
            Console.WriteLine($"- {objet}");
        }


    }
}