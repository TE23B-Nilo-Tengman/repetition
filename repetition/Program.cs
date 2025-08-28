
Fight();

static void Fight()
{

    int p1Hp = 100;
    int p2Hp = 100;

    int p1Dmg = 0;
    int p2Dmg = 0;

    string p1Name = "Hugo";
    string p2Name = "Bevdar";



    Console.WriteLine($"{p1Name}: {p1Hp}");
    Console.WriteLine($"{p2Name}: {p2Hp}");
    Console.WriteLine("_____________________");

    while (p1Hp > 0 && p2Hp > 0)
    {

        p1Dmg = Random.Shared.Next(10, 26);
        p2Dmg = Random.Shared.Next(10, 26);
        p1Hp -= p1Dmg;
        p2Hp -= p2Dmg;
        Console.WriteLine($"{p1Name}:gjorde {p1Dmg} Dmg");
        Console.WriteLine($"{p2Name}:gjorde {p2Dmg} Dmg");

        Console.WriteLine("_____________________");

        Console.WriteLine($"{p1Name}:har {p1Hp} hp");
        Console.WriteLine($"{p2Name}:har {p2Hp} hp");
        Console.ReadLine();
    }

    if (p1Hp > 0)
    {
        Console.WriteLine($"{p1Name} vann!");
    }
    else if (p1Hp <= 0 && p2Hp <= 0)
    {
        Console.WriteLine("Oavgjort!");
    }
    else
    {
        Console.WriteLine($"{p2Name} vann!");
    }

    Console.ReadLine();
}