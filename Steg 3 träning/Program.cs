static void hello32()
{
    for (int i = 0; i < 32; i++)
    {
        Console.WriteLine("hello Wolrd!");
    }
}

static void Square(int num)
{
    Console.WriteLine(num * num);
}

static double Multi(double x, double y)
{
    return x * y;
}

// double e = Multi(8, 7);


// Console.WriteLine(e);


// Square(3);

static double RightTriangleArea(double b, double h)
{
    return b * h / 2;
}

// double area = RightTriangleArea(3, 5);
// Console.WriteLine($"arean av triangeln är {area}");

static double cirkelarea(double b)
{
    return b * b * 3.14;
}

// double cirkel = cirkelarea(4);
// Console.WriteLine($"Arean av cikeln är {cirkel}");





static int GetNumberInput()
{
    int number = 0;
    bool isValid = false;

    while (isValid == false)
    {
        Console.WriteLine("Skriv en sifra");
        string num = Console.ReadLine();

        isValid = int.TryParse(num, out number);

        if (!isValid)
        {
            Console.WriteLine("Fel skriv ett nummer inte bokstav.");
        }

    }
    Console.WriteLine($"Du skrev in siffran: {number}");

    return number;
}



// int o = GetNumberInput();





Console.ReadLine();