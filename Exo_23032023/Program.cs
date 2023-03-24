// Exo 1.1

//Demander à l’utilisateur d’encoder 2 nombres ( int ) et d’en faire l’addition, la conversion devra utiliser la méthode « int.Parse »

{
    Console.WriteLine("Nous allons entrer 2 nombres de type INT et nous en ferons l'addition");

    Console.WriteLine("Entrez le premier nombre");
    int nb1 = int.Parse(Console.ReadLine()!);

    Console.WriteLine("Entrez le deuxième nombre");
    int nb2 = int.Parse(Console.ReadLine()!);

    Console.WriteLine($" la somme des deux nombres est égale à {nb1 + nb2} ");

    Console.WriteLine();
}

//en mettant les exo entre {} on permet de jouer sur des locales



// Exo 2.1
//Demander à l’utilisateur d’encoder 2 nombres ( int ) et d’en faire l’addition, la conversion devra utiliser la méthode « int.TryParse »

{

    int nb1;
    int nb2;

    Console.WriteLine("Nous allons entrer 2 nombres de type INT et nous en ferons l'addition");

    Console.WriteLine("Entrez le premier nombre");
    int.TryParse(Console.ReadLine(), out nb1);


    Console.WriteLine("Entrez le deuxième nombre");
    int.TryParse(Console.ReadLine(), out nb2);

    Console.WriteLine($" la somme des deux nombres est égale à {nb1 + nb2} ");

    Console.WriteLine();

}

// Exo 2.1 bis

{

    Console.WriteLine("Entrez le premier nombre");
    int.TryParse(Console.ReadLine()!, out int nb1); // Pattern Matching
    Console.WriteLine("Entrez le deuxieme nombre");
    int.TryParse(Console.ReadLine()!, out int nb2); // Pattern Matching

    Console.WriteLine($" la somme des deux nombres est égale à {nb1 + nb2} ");

    Console.WriteLine();

}




