using System;
using System.Threading;
class Piano
{
    static int[] fiveOctave = new int[] { 523, 554, 587, 622, 659, 698, 740, 784, 831, 880, 932, 988 };
    static int[] sixOctave = new int[] { 1047, 1109, 1175, 1245, 1319, 1397, 1480, 1568, 1661, 1760, 1865, 1976 };
    static int[] sevenOctave = new int[] { 2093, 2217, 2349, 2489, 2637, 2794, 2960, 3136, 3322, 3520, 3729, 3951 };
    static int[] eightOctave = new int[] { 4186, 4435, 4699, 4978, 5274, 5588, 5920, 6272, 6645, 7040, 7459, 7902 };
    static int[] currentOctave;
    static bool running = true;

    static void Main(string[] args)
    {
        Console.WriteLine("Привет! Добро пожаловать в консольное пианино.");
        Console.WriteLine("Используйте клавиши от A до J для белых клавиш и клавиши W, E, T, Y, U для черных клавиш.");
        Console.WriteLine("Нажмите F5 - для пятой октавы, F6 - для шестой октавы, F7 - для седьмой октавы и F8 - для восьмой октавы.");
        Console.WriteLine("Для выхода нажмите Esc.");

        ConsoleKeyInfo keyInfo;
        currentOctave = fiveOctave;
        while (running)
        {
            keyInfo = Console.ReadKey(true);

            if (keyInfo.Key == ConsoleKey.Escape)
            {
                running = false;
            }
            else if (keyInfo.Key == ConsoleKey.F5)
            {
                currentOctave = sixOctave;
                Console.WriteLine("Переключено на пятую октаву.");
            }
            else if (keyInfo.Key == ConsoleKey.F6)
            {
                currentOctave = sixOctave;
                Console.WriteLine("Переключено на шестую октаву.");
            }
            else if (keyInfo.Key == ConsoleKey.F7)
            {
                currentOctave = sevenOctave;
                Console.WriteLine("Переключено на седьмую октаву.");
            }
            else if (keyInfo.Key == ConsoleKey.F8)
            {
                currentOctave = eightOctave;
                Console.WriteLine("Переключено на восьмую октаву.");
            }
            else
            {
                PlaySound(keyInfo.Key);
            }
        }
    }
        static void PlaySound(ConsoleKey key)
        {
            int index = -1;
        switch (key)
        {
            case ConsoleKey.A:
                index = 0;
                break;
            case ConsoleKey.W:
                index = 1;
                break;
            case ConsoleKey.S:
                index = 2;
                break;
            case ConsoleKey.E:
                index = 3;
                break;
            case ConsoleKey.D:
                index = 4;
                break;
            case ConsoleKey.F:
                index = 5;
                break;
            case ConsoleKey.T:
                index = 6;
                break;
            case ConsoleKey.G:
                index = 7;
                break;
            case ConsoleKey.Y:
                index = 8;
                break;
            case ConsoleKey.H:
                index = 9;
                break;
            case ConsoleKey.U:
                index = 10;
                break;
            case ConsoleKey.J:
                index = 11;
                break;;
        }
            if (index >= 0)
            {
                int DK = currentOctave[index];
                Console.Beep(DK, 400);
            }
        }
}
