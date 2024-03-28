 using System;
 using System.Threading.Tasks;
 using System.Threading;
 using System.IO;
 
 /*
 Simple representation of light saber in console.
 For the 4th of May Star Wars celebration.
 */
 var end = '\u203E';
 var saber =$@"
     
    |_| 
    |_] 
    | |
    |||
    |||
     {end.ToString()}
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
	Console.SetCursorPosition(0, 14);
	Console.Write(saber);
	using (var reader = new StringReader(blade))
	{
		int i = 17;
		var line = "";
		while(null != (line = reader.ReadLine()))
		{
			i--;
			WritePosition(color, line, 0, i, speed);
		}
	}
	Console.SetCursorPosition(0, 23);
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

//Render blade.
ShowSaber(saber, blade, 100, ConsoleColor.Cyan);
