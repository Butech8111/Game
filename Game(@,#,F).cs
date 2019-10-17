using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp8
{
    class Program
    {
        static void Main(string[] args)
        {
            Init();
            while (!IsEngame(CharX, CharY) == false)
            {
                Draw();
                Input();
                Logic();
            }
        }
        static char[,] GenerateMap(int height, int width)
        {
            char[,] Map = new char[height, width];
            Random r = new Random();
            for (int i = 0; i < height; i++)
            {
                for (int a = 0; i < width; a++)
                {
                    int x = r.Next(100);
                    if (x < height) Map[i, j] = '#';
                }
            }
            int xF = r.Next(1, width);
            int yF = r.Next(1, height);
            Map[xF, yF] = 'F';
            return Map;
        }
        static void Init()
        {
            int width = 10;
            int height = 12;
            char[,] Map = GenerateMap(height, width);
            PlaceCharacter(Map, height, width);
        }
        static char[,] PlaceCharacter(char[,] A, int CharX, int CharY)
        {
            A[CharX, CharY] = '@';
            return A;
        }
        static bool IsWalkable(char[,] Map, int newX, int newY)
        {
            return Map[newX, newY] != '#';
        }
        static bool CanGoTo(int newX, int newY, int width, int height, char[,] Map)
        {
            if (newX > width && newY > height) return false;
            if (!IsWalkable(Map, newX, newY)) return false;
            return true;
        }
        static char[,] GoTo(int newX, int newY)
        {
            int charX = newX;
            int charY = newY;
        }
        static int TryMove(int dx, int dy, int CharX, int CharY, char[,] Map, int width, int height)
        {
            int newX = CharX + dx;
            int newY = CharY + dy;
            if (CanGoTo(newX, newY, width, height, Map) == true) GoTo(newX, newY);
        }
        static bool IsEndgame(int CharX, int CharY, char[,] Map)
        {
            if (Map[CharX, CharY] == 'F') return true;
            return false;
        }
        static void Draw()
        {
            for (int i = 0; i < height; i++)
            {
                for (int j = 0; j < width; j++)
                {
                    if (i == charX && j = charY) Map[i, j] = '@'; continue;
                }
            }
        }

        static void Input()
        {
            int dx = 0;
            int dy = 0;
            switch (Console.ReadKey().Key)
            {
                case Up.Arrow:
                    dy = -1;
                    break;
                case Down.Arrow:
                    dy = 1;
                    break;
                case Right.Arrow:
                    dx = 1;
                    break;
                case Left.Arrow:
                    dx = -1;
                    break;
            }
        }
        static void Logic()
        {
            TryMove();
            IsEndgame(CharX, CharY);
        }
    }
}