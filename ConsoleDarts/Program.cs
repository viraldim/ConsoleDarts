using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;

namespace ConsoleDarts
{
    class Program
    {     
        static void Main()
        {
            ConsoleProcesses.ConsoleSetter();
            foreach (var line in LineTypes.AllLines)
            {
                line.Draw();
            }
            int[] dotInfo = new int[2];
            ShotsLocation[] location = new ShotsLocation[3];
            for (int shots = 0; shots < 3; shots++)
            {
                ConsoleProcesses.PrintResult(shots, dotInfo);
                ConsoleProcesses.ColorSetter(ConsoleColor.DarkGreen);
                GameManager Engine = new GameManager();
                HorozontalMovement rulerLine = new HorozontalMovement(Engine.LinerX, LineTypes.AllLines[Engine.LinerX]);
                rulerLine.Draw();
                int ShootX ,ShootY = 0;
                int[] pointData = new int[2];
                ShootX = Engine.HorizontalAiming(rulerLine, shots);
                pointData = Engine.VerticalAiming(ShootX, dotInfo, shots);
                ShootY = pointData[1];
                location[shots].X = ShootX;
                location[shots].Y = ShootY;
                dotInfo[0] -= Engine.ResultChecking(shots, location, ShootX, ShootY, pointData);
                dotInfo[0] += pointData[0];
                GreatingsEventArgs greating = new GreatingsEventArgs();
                Engine.Subscribe(greating);
                greating.Message(dotInfo[0]);
                Thread.Sleep(500);
                new MoveThroughLine(ShootX, Dot.ContentToString(Strings.emptyString)).Draw();
            }
            ConsoleProcesses.PrintResult(3, dotInfo);
        }
    }
}