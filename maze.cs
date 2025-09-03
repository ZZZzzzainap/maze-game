using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace first_oop_project
{
    public class maze

    {
        private int _height;
        private int _width;
        private player _player;
        private mazeopject[,] _mazeobjectarr;
        public maze(int height, int width)
        {
            _height = height;
            _width = width;
            _mazeobjectarr = new mazeopject[width, height];
            _player = new player()
            {

                x = 1
                ,
                y = 1,

            };


        }
        public void updatplayer(int dx, int dy)
        {
            int newx = _player.x + dx;
            int newy = _player.y + dy;
            if (newx <= _width && newx >= 0 && newy <= _height && newy >= 0 && _mazeobjectarr[newx, newy].issolid == false)
            {
                _player.x = newx;
                _player.y = newy;
            }
        }
        public void moveplayer()
        {
            ConsoleKeyInfo userinput = Console.ReadKey();
            ConsoleKey key = userinput.Key;
            switch (key)
            {
                case ConsoleKey.UpArrow:
                    updatplayer(0, -1);
                    break;
                case ConsoleKey.DownArrow:
                    updatplayer(0, 1);
                    break;
                case ConsoleKey.LeftArrow:
                    updatplayer(-1, 0);
                    break;
                case ConsoleKey.RightArrow:
                    updatplayer(1, 0);
                    break;

            }
        }
        public void drowmaze()
        {
            Console.Clear();
            for (int y = 0; y < _height; y++)
            {
                for (int x = 0; x < _width; x++)
                {
                    if (x == _width - 1 && y == _height - 2)
                    {
                        _mazeobjectarr[x, y] = new emptysspace();
                        Console.Write(_mazeobjectarr[x, y].icon);
                    }
                    else if (x == 0 || y == 0 || x == _width - 1 || y == _height - 1)
                    {
                        _mazeobjectarr[x, y] = new wall();
                        Console.Write(_mazeobjectarr[x, y].icon);
                    }
                    else if (x == _player.x && y == _player.y)
                    {
                        Console.Write(_player.icon);
                    }
                    else if (x % 3 == 0 && y % 3 == 0)
                    {
                        _mazeobjectarr[x, y] = new wall();
                        Console.Write(_mazeobjectarr[x, y].icon);

                    }
                    else
                    {

                        _mazeobjectarr[x, y] = new emptysspace();
                        Console.Write(_mazeobjectarr[x, y].icon);
                    }
                }
                Console.WriteLine();




            }
        }
    }
}
    

