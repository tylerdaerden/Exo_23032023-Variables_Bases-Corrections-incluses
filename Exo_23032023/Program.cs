// Exo 1.1
//Demander à l’utilisateur d’encoder 2 nombres ( int ) et d’en faire l’addition, la conversion devra utiliser la méthode « int.Parse »

//Console.WriteLine("Nous allons entrer 2 nombres de type INT et nous en ferons l'addition");

//Console.WriteLine("Entrez le premier nombre");
//int nb1 = int.Parse(Console.ReadLine());

//Console.WriteLine("Entrez le deuxième nombre" );
//int nb2 = int.Parse(Console.ReadLine());

//Console.WriteLine($" la somme des deux nombres est égale à {nb1 + nb2} ");

//Console.WriteLine();






// Exo 2.1
//Demander à l’utilisateur d’encoder 2 nombres ( int ) et d’en faire l’addition, la conversion devra utiliser la méthode « int.TryParse »

Console.WriteLine("Nous allons entrer 2 nombres de type INT et nous en ferons l'addition");

Console.WriteLine("Entrez le premier nombre");
int nb1;
bool nb1_b = int.TryParse(Console.ReadLine() , out nb1);


Console.WriteLine("Entrez le deuxième nombre");
int nb2;
bool nb2_b = int.TryParse(Console.ReadLine(), out nb2);

Console.WriteLine($" la somme des deux nombres est égale à {nb1 + nb2} ");

Console.WriteLine();
