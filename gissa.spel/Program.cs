        Random random = new Random();
        int hemligt_tal = random.Next(1, 101);

        Console.WriteLine("Gissa ett tal mellan 1 och 100:");

        int försök = 0;

        while (true)
        {
            string input = Console.ReadLine();
            int gissning;
            if (!int.TryParse(input, out gissning))
            {
                Console.WriteLine("Skriv ett giltigt heltal!");
                continue;
            }

            försök++;

    if (gissning < hemligt_tal)
    {
        Console.WriteLine("För lågt, försök igen:");
    }
    else if (gissning > hemligt_tal)
    {
        Console.WriteLine("För högt, försök igen:");
    }
    else
    {
        Console.WriteLine($"Grattis! Du gissade rätt på {försök} försök.");
                break;
            }
        }
   