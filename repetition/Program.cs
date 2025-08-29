
Fight();

static void Fight()
{

    int p1Hp = 100;
    int p2Hp = 100;

    int p1Dmg = 0;
    int p2Dmg = 0;





    Console.WriteLine("Vad heter din goat");
    string p1Name = Console.ReadLine();
    Console.WriteLine("Vad heter din opp");
    string p2Name = Console.ReadLine();
    Console.WriteLine("");



    Console.WriteLine($"Vill du att {p1Name} ha en Kniv som ger +5 dmg (Skriv (k) ) eller en sköld som ger plus 50 hp (skriv (s) )???");
    Console.WriteLine($"om du inte skriver k eller s så får du inget :P");
    string p1Acc = Console.ReadLine();
    Console.WriteLine($"Vill du att {p2Name} ha en Kniv som ger +5 dmg (Skriv (k) ) eller en sköld som ger plus 50 hp (skriv (s) )???");
    string p2Acc = Console.ReadLine();

    if (p1Acc == "s")
    {
        p1Hp += 50;
    }
    else{}
    if (p2Acc == "s")
    {
        p2Hp += 50;
    }
    else{}

    Console.WriteLine($"{p1Name}: {p1Hp} hp");
    Console.WriteLine($"{p2Name}: {p2Hp} hp");
    Console.WriteLine("");

    while (p1Hp > 0 && p2Hp > 0)
    {

        p1Dmg = Random.Shared.Next(1, 26);
        p2Dmg = Random.Shared.Next(1, 26);

        if (p1Acc == "k")
        {
            p2Hp -= p1Dmg + 5;
        }
        else
        {
            p2Hp -= p1Dmg;
        }



        if (p2Acc == "k")
        {
            p1Hp -= p2Dmg + 5;
        }
        else
        {
            p1Hp -= p2Dmg;
        }



        Console.WriteLine($"{p1Name}:gjorde {p1Dmg} Dmg");
        Console.WriteLine($"{p2Name}:gjorde {p2Dmg} Dmg");

        Console.WriteLine("");

        Console.WriteLine($"{p1Name}:har {p1Hp} hp");
        Console.WriteLine($"{p2Name}:har {p2Hp} hp");

        Console.WriteLine("_____________________");

        Console.ReadLine();
    }

    if (p1Hp > 0)
    {
        Console.WriteLine($"{p1Name} vann! Han slaktade den opp {p2Name}, och rädda världen elle nåt sånt.");
    }
    else if (p1Hp <= 0 && p2Hp <= 0)
    {
        Console.WriteLine($"Både din opp {p2Name} och din goat {p1Name} är döda. Vi vann, men var det värt det? Fs in the chat please.");
    }
    else
    {
        Console.WriteLine($"{p2Name} vann :o , nu kommer din opp nog döda alla du älskar :p");
    }

    Console.ReadLine();
}