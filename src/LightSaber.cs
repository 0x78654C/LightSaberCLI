 using System;
 using System.Threading.Tasks;
 using System.Threading;
 using System.IO;
 
 
 var saber =$@"
     _
    |||
    |||
    |_| 
    |_] 
    | |
 ";
 
 var blade =$@"
     █
     █
     █
     █
     █
     █
     █
     █
     █
     █
     █
     █
     █
     
     
     
 ";

/// <summary>
/// Displey console Color position.
/// </summary>
void ShowSaber(string saber, string blade, int speed, ConsoleColor color)
{
	Console.Clear();
	ColorConsoleTextLine(ConsoleColor.Yellow, "Happy 4th of May Star Wars!");
	Console.Write(saber);
	using (var reader = new StringReader(blade))
	{
		int i = 6;
		var line = "";
		while(null != (line = reader.ReadLine()))
		{
			i++;
			WritePosition(color, line, 0, i, speed);
		}
	}
	ColorConsoleTextLine(ConsoleColor.Yellow, "May the force be with you!");
}

/// <summary>
/// Displey console Color position.
/// </summary>
void WritePosition(ConsoleColor color, string data, int left, int top, int speed)
{
	Console.SetCursorPosition(left, top);
	ColorConsoleText(color, data);
	Console.SetCursorPosition(left, top-1);
	Thread.Sleep(speed);
}

/// <summary>
/// Change color of a specific line in console.
/// </summary>
/// <param name="color"></param>
/// <param name="text"></param>
void ColorConsoleTextLine(ConsoleColor color, string text)
{
    ConsoleColor currentForeground = Console.ForegroundColor;
    Console.ForegroundColor = color;
    Console.WriteLine(text);
    Console.ForegroundColor = currentForeground;
}

/// <summary>
/// Change color of a specific text in console.
/// </summary>
/// <param name="color"></param>
/// <param name="text"></param>
void ColorConsoleText(ConsoleColor color, object data)
{
    ConsoleColor currentForeground = Console.ForegroundColor;
    Console.ForegroundColor = color;
    Console.Write(data);
    Console.ForegroundColor = currentForeground;
}

void Test()
{
	for(int i = 12; i<20;i++)
	{
		Console.SetCursorPosition(12,i);
		Console.Write("asdad");
		Console.SetCursorPosition(12,i-1);
		Console.Write("    ");
		Thread.Sleep(500);
	}
}

//Render blade.
ShowSaber(saber, blade, 100, ConsoleColor.Cyan);