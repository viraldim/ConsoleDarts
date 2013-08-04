using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;

namespace ConsoleDarts
{
    class GameManager
    {
        private int linerX = 0;
        private Line movementLine;

        public Line MovementLine
        {
            get
            {
                return this.movementLine;
            }
            set
            {
                this.movementLine = value;
            }
        }

        public int LinerX
        {
            get
            {
                return this.linerX;
            }
        }

        public GreatingsEventArgs GreatingsEventArgs
        {
            get
            {
                throw new System.NotImplementedException();
            }
            set
            {
            }
        }

        internal ArrowOverArrowException ArrowOverArrowException
        {
            get
            {
                throw new System.NotImplementedException();
            }
            set
            {
            }
        }

        internal MoveThroughLine MoveThroughLine
        {
            get
            {
                throw new System.NotImplementedException();
            }
            set
            {
            }
        }

        public HorozontalMovement HorozontalMovement
        {
            get
            {
                throw new System.NotImplementedException();
            }
            set
            {
            }
        }

        public GameManager()
        {
        }

        public int HorizontalAiming (HorozontalMovement line, int shootNumber)
        {
            while (true)
            {
                if (Console.KeyAvailable)
                {
                    ConsoleKeyInfo consoleKeyInfo = Console.ReadKey(true);
                    while (Console.KeyAvailable)
                    {
                        Console.ReadKey(true);
                    }
                    if (consoleKeyInfo.Key == ConsoleKey.Spacebar)
                    {
                        return line.X;
                    }
                }
                line.Move();
                line.Draw();
                Thread.Sleep(50 / (shootNumber + 1));
            }
        }

        public int[] VerticalAiming(int shootX, int[] score, int shootNumber)
        {
            MoveThroughLine hittedLine = new MoveThroughLine(shootX, Dot.ContentToString(Strings.shotString));
            hittedLine.Draw();
            while (true)
            {
                if (Console.KeyAvailable)
                {
                    ConsoleKeyInfo consoleKeyInfo = Console.ReadKey(true);
                    while (Console.KeyAvailable)
                    {
                        Console.ReadKey(true);
                    }
                    if (consoleKeyInfo.Key == ConsoleKey.Spacebar)
                    {
                        score = hittedLine.Count();
                        return score;
                    }
                }
                hittedLine.Move();
                hittedLine.Draw();
                Thread.Sleep(50 / (shootNumber+1));
            }
        }

        public int ResultChecking(int shots,ShotsLocation[] location, int ShootX, int ShootY, int[] pointData)
        {
            int reduseScore = 0;
            try
            {
                for (int i = 0; i < shots; i++)
                {
                    if (location[i].X == ShootX && location[i].Y == ShootY)
                    {
                        throw new ArrowOverArrowException("You've hit the same location");
                    }
                }
            }
            catch (ArrowOverArrowException aoae)
            {
                Console.SetCursorPosition(0, Console.WindowHeight - 1);
                Console.Write(aoae.Message);
                reduseScore = pointData[0];
                Thread.Sleep(1000);
            }
            return reduseScore;
        }

        public void Subscribe(GreatingsEventArgs b)
        {
            b.Greatings += new GreatingsEventArgs.GreatingsEventHandler(Alert);
        }

        private void Alert(GreatingsEventArgs b, EventArgs e)
        {
            Console.SetCursorPosition(0, Console.WindowHeight - 1);
            Console.Write("BRAVO!!! your score is MAX: 30 points");
            Thread.Sleep(1000);
        }
    }
}
