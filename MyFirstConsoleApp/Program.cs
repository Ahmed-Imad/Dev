// Asking the user to enter their name

Console.WriteLine("What's your name");
Console.ForegroundColor= ConsoleColor.Green;
var name = Console.ReadLine();
Console.ForegroundColor= ConsoleColor.White;
var currentDate = DateTime.Now;
Console.WriteLine($"{Environment.NewLine}Hello, {name}, on {currentDate:d}");
Console.Write($"{Environment.NewLine} Press any key to see the COLORS!!!");
Console.ReadKey(true);

// Let's go through all Console colors and set them as foreground  

foreach (ConsoleColor color in Enum.GetValues(typeof(ConsoleColor))) {  
            Console.ForegroundColor = color;
            Console.Clear();
            Console.WriteLine($"Foreground color set to {color}");  
        }  
        Console.WriteLine("=====================================");  
        Console.ForegroundColor = ConsoleColor.White;  
        // Let's go through all Console colors and set them as background  
        foreach(ConsoleColor color in Enum.GetValues(typeof(ConsoleColor))) {  
            Console.BackgroundColor = color;  
            Console.WriteLine( $"Background color set to {color}");  
        }  
        Console.WriteLine("=====================================");  
        // Restore original colors  
        Console.ResetColor(); 
        Console.ReadKey();  
    
Console.WriteLine();
Console.WriteLine();
