using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleDarts
{
    public class LineTypes
    {
        public static readonly List<Line> AllLines = new List<Line>();

        public static List<Dot> dotInEmptyLine = new List<Dot>();
        public static List<Dot> dotInFirstLine = new List<Dot>();
        public static List<Dot> dotInSecondLine = new List<Dot>();
        public static List<Dot> dotInThirdLine = new List<Dot>();
        public static List<Dot> dotInFourthLine = new List<Dot>();
        public static List<Dot> dotInFifthLine = new List<Dot>();
        public static List<Dot> dotInSixthLine = new List<Dot>();
        public static List<Dot> dotInSeventhLine = new List<Dot>();
        public static List<Dot> dotInEightLine = new List<Dot>();
        public static List<Dot> dotInNinthLine = new List<Dot>();
        public static List<Dot> dotInTenthLine = new List<Dot>();

        static LineTypes()
        {
            for (int i = 0; i < 26; i++)
            {
                dotInEmptyLine.Add(new Dot(i, 0, DotTypes.AllDots[0].Level, DotTypes.AllDots[0].Color));
            }

            for (int i = 0; i < 26; i++)
            {
                if (i < 8)
                    dotInFirstLine.Add(new Dot(i, 0, DotTypes.AllDots[0].Level, DotTypes.AllDots[0].Color));
                else if (i < 18)
                    dotInFirstLine.Add(new Dot(i, 0, DotTypes.AllDots[1].Level, DotTypes.AllDots[1].Color));
                else
                    dotInFirstLine.Add(new Dot(i, 0, DotTypes.AllDots[0].Level, DotTypes.AllDots[0].Color));
            }

            

            for (int i = 0; i < 26; i++)
            {
                if (i < 7)
                    dotInSecondLine.Add(new Dot(i, 0, DotTypes.AllDots[0].Level, DotTypes.AllDots[0].Color));
                else if (i < 9)
                    dotInSecondLine.Add(new Dot(i, 0, DotTypes.AllDots[1].Level, DotTypes.AllDots[1].Color));
                else if (i < 17)
                    dotInSecondLine.Add(new Dot(i, 0, DotTypes.AllDots[2].Level, DotTypes.AllDots[2].Color));
                else if (i < 19)
                    dotInSecondLine.Add(new Dot(i, 0, DotTypes.AllDots[1].Level, DotTypes.AllDots[1].Color));
                else
                    dotInSecondLine.Add(new Dot(i, 0, DotTypes.AllDots[0].Level, DotTypes.AllDots[0].Color));
            }

            

            for (int i = 0; i < 26; i++)
            {
                if (i < 6)
                    dotInThirdLine.Add(new Dot(i, 0, DotTypes.AllDots[0].Level, DotTypes.AllDots[0].Color));
                else if (i < 8)
                    dotInThirdLine.Add(new Dot(i, 0, DotTypes.AllDots[1].Level, DotTypes.AllDots[1].Color));
                else if (i < 9)
                    dotInThirdLine.Add(new Dot(i, 0, DotTypes.AllDots[2].Level, DotTypes.AllDots[2].Color));
                else if (i < 17)
                    dotInThirdLine.Add(new Dot(i, 0, DotTypes.AllDots[3].Level, DotTypes.AllDots[3].Color));
                else if (i < 18)
                    dotInThirdLine.Add(new Dot(i, 0, DotTypes.AllDots[2].Level, DotTypes.AllDots[2].Color));
                else if (i < 20)
                    dotInThirdLine.Add(new Dot(i, 0, DotTypes.AllDots[1].Level, DotTypes.AllDots[1].Color));
                else
                    dotInThirdLine.Add(new Dot(i, 0, DotTypes.AllDots[0].Level, DotTypes.AllDots[0].Color));
            }

           

            for (int i = 0; i < 26; i++)
            {
                if (i < 5)
                    dotInFourthLine.Add(new Dot(i, 0, DotTypes.AllDots[0].Level, DotTypes.AllDots[0].Color));
                else if (i < 7)
                    dotInFourthLine.Add(new Dot(i, 0, DotTypes.AllDots[1].Level, DotTypes.AllDots[1].Color));
                else if (i < 8)
                    dotInFourthLine.Add(new Dot(i, 0, DotTypes.AllDots[2].Level, DotTypes.AllDots[2].Color));
                else if (i < 10)
                    dotInFourthLine.Add(new Dot(i, 0, DotTypes.AllDots[3].Level, DotTypes.AllDots[3].Color));
                else if (i < 16)
                    dotInFourthLine.Add(new Dot(i, 0, DotTypes.AllDots[4].Level, DotTypes.AllDots[4].Color));
                else if (i < 18)
                    dotInFourthLine.Add(new Dot(i, 0, DotTypes.AllDots[3].Level, DotTypes.AllDots[3].Color));
                else if (i < 19)
                    dotInFourthLine.Add(new Dot(i, 0, DotTypes.AllDots[2].Level, DotTypes.AllDots[2].Color));
                else if (i < 21)
                    dotInFourthLine.Add(new Dot(i, 0, DotTypes.AllDots[1].Level, DotTypes.AllDots[1].Color));
                else
                    dotInFourthLine.Add(new Dot(i, 0, DotTypes.AllDots[0].Level, DotTypes.AllDots[0].Color));
            }

            

            for (int i = 0; i < 26; i++)
            {
                if (i < 4)
                    dotInFifthLine.Add(new Dot(i, 0, DotTypes.AllDots[0].Level, DotTypes.AllDots[0].Color));
                else if (i < 6)
                    dotInFifthLine.Add(new Dot(i, 0, DotTypes.AllDots[1].Level, DotTypes.AllDots[1].Color));
                else if (i < 7)
                    dotInFifthLine.Add(new Dot(i, 0, DotTypes.AllDots[2].Level, DotTypes.AllDots[2].Color));
                else if (i < 9)
                    dotInFifthLine.Add(new Dot(i, 0, DotTypes.AllDots[3].Level, DotTypes.AllDots[3].Color));
                else if (i < 10)
                    dotInFifthLine.Add(new Dot(i, 0, DotTypes.AllDots[4].Level, DotTypes.AllDots[4].Color));
                else if (i < 16)
                    dotInFifthLine.Add(new Dot(i, 0, DotTypes.AllDots[5].Level, DotTypes.AllDots[5].Color));
                else if (i < 17)
                    dotInFifthLine.Add(new Dot(i, 0, DotTypes.AllDots[4].Level, DotTypes.AllDots[4].Color));
                else if (i < 19)
                    dotInFifthLine.Add(new Dot(i, 0, DotTypes.AllDots[3].Level, DotTypes.AllDots[3].Color));
                else if (i < 20)
                    dotInFifthLine.Add(new Dot(i, 0, DotTypes.AllDots[2].Level, DotTypes.AllDots[2].Color));
                else if (i < 22)
                    dotInFifthLine.Add(new Dot(i, 0, DotTypes.AllDots[1].Level, DotTypes.AllDots[1].Color));
                else
                    dotInFifthLine.Add(new Dot(i, 0, DotTypes.AllDots[0].Level, DotTypes.AllDots[0].Color));
            }

            

            for (int i = 0; i < 26; i++)
            {
                if (i < 3)
                    dotInSixthLine.Add(new Dot(i, 0, DotTypes.AllDots[0].Level, DotTypes.AllDots[0].Color));
                else if (i < 5)
                    dotInSixthLine.Add(new Dot(i, 0, DotTypes.AllDots[1].Level, DotTypes.AllDots[1].Color));
                else if (i < 6)
                    dotInSixthLine.Add(new Dot(i, 0, DotTypes.AllDots[2].Level, DotTypes.AllDots[2].Color));
                else if (i < 8)
                    dotInSixthLine.Add(new Dot(i, 0, DotTypes.AllDots[3].Level, DotTypes.AllDots[3].Color));
                else if (i < 9)
                    dotInSixthLine.Add(new Dot(i, 0, DotTypes.AllDots[4].Level, DotTypes.AllDots[4].Color));
                else if (i < 10)
                    dotInSixthLine.Add(new Dot(i, 0, DotTypes.AllDots[5].Level, DotTypes.AllDots[5].Color));
                else if (i < 16)
                    dotInSixthLine.Add(new Dot(i, 0, DotTypes.AllDots[6].Level, DotTypes.AllDots[6].Color));
                else if (i < 17)
                    dotInSixthLine.Add(new Dot(i, 0, DotTypes.AllDots[5].Level, DotTypes.AllDots[5].Color));
                else if (i < 18)
                    dotInSixthLine.Add(new Dot(i, 0, DotTypes.AllDots[4].Level, DotTypes.AllDots[4].Color));
                else if (i < 20)
                    dotInSixthLine.Add(new Dot(i, 0, DotTypes.AllDots[3].Level, DotTypes.AllDots[3].Color));
                else if (i < 21)
                    dotInSixthLine.Add(new Dot(i, 0, DotTypes.AllDots[2].Level, DotTypes.AllDots[2].Color));
                else if (i < 23)
                    dotInSixthLine.Add(new Dot(i, 0, DotTypes.AllDots[1].Level, DotTypes.AllDots[1].Color));
                else
                    dotInSixthLine.Add(new Dot(i, 0, DotTypes.AllDots[0].Level, DotTypes.AllDots[0].Color));
            }

            

            for (int i = 0; i < 26; i++)
            {
                if (i < 3)
                    dotInSeventhLine.Add(new Dot(i, 0, DotTypes.AllDots[0].Level, DotTypes.AllDots[0].Color));
                else if (i < 4)
                    dotInSeventhLine.Add(new Dot(i, 0, DotTypes.AllDots[1].Level, DotTypes.AllDots[1].Color));
                else if (i < 5)
                    dotInSeventhLine.Add(new Dot(i, 0, DotTypes.AllDots[2].Level, DotTypes.AllDots[2].Color));
                else if (i < 7)
                    dotInSeventhLine.Add(new Dot(i, 0, DotTypes.AllDots[3].Level, DotTypes.AllDots[3].Color));
                else if (i < 8)
                    dotInSeventhLine.Add(new Dot(i, 0, DotTypes.AllDots[4].Level, DotTypes.AllDots[4].Color));
                else if (i < 9)
                    dotInSeventhLine.Add(new Dot(i, 0, DotTypes.AllDots[5].Level, DotTypes.AllDots[5].Color));
                else if (i < 11)
                    dotInSeventhLine.Add(new Dot(i, 0, DotTypes.AllDots[6].Level, DotTypes.AllDots[6].Color));
                else if (i < 15)
                    dotInSeventhLine.Add(new Dot(i, 0, DotTypes.AllDots[7].Level, DotTypes.AllDots[7].Color));
                else if (i < 17)
                    dotInSeventhLine.Add(new Dot(i, 0, DotTypes.AllDots[6].Level, DotTypes.AllDots[6].Color));
                else if (i < 18)
                    dotInSeventhLine.Add(new Dot(i, 0, DotTypes.AllDots[5].Level, DotTypes.AllDots[5].Color));
                else if (i < 19)
                    dotInSeventhLine.Add(new Dot(i, 0, DotTypes.AllDots[4].Level, DotTypes.AllDots[4].Color));
                else if (i < 21)
                    dotInSeventhLine.Add(new Dot(i, 0, DotTypes.AllDots[3].Level, DotTypes.AllDots[3].Color));
                else if (i < 22)
                    dotInSeventhLine.Add(new Dot(i, 0, DotTypes.AllDots[2].Level, DotTypes.AllDots[2].Color));
                else if (i < 23)
                    dotInSeventhLine.Add(new Dot(i, 0, DotTypes.AllDots[1].Level, DotTypes.AllDots[1].Color));
                else
                    dotInSeventhLine.Add(new Dot(i, 0, DotTypes.AllDots[0].Level, DotTypes.AllDots[0].Color));
            }

           

            for (int i = 0; i < 26; i++)
            {
                if (i < 3)
                    dotInEightLine.Add(new Dot(i, 0, DotTypes.AllDots[0].Level, DotTypes.AllDots[0].Color));
                else if (i < 4)
                    dotInEightLine.Add(new Dot(i, 0, DotTypes.AllDots[1].Level, DotTypes.AllDots[1].Color));
                else if (i < 5)
                    dotInEightLine.Add(new Dot(i, 0, DotTypes.AllDots[2].Level, DotTypes.AllDots[2].Color));
                else if (i < 6)
                    dotInEightLine.Add(new Dot(i, 0, DotTypes.AllDots[3].Level, DotTypes.AllDots[3].Color));
                else if (i < 7)
                    dotInEightLine.Add(new Dot(i, 0, DotTypes.AllDots[4].Level, DotTypes.AllDots[4].Color));
                else if (i < 8)
                    dotInEightLine.Add(new Dot(i, 0, DotTypes.AllDots[5].Level, DotTypes.AllDots[5].Color));
                else if (i < 10)
                    dotInEightLine.Add(new Dot(i, 0, DotTypes.AllDots[6].Level, DotTypes.AllDots[6].Color));
                else if (i < 12)
                    dotInEightLine.Add(new Dot(i, 0, DotTypes.AllDots[7].Level, DotTypes.AllDots[7].Color));
                else if (i < 14)
                    dotInEightLine.Add(new Dot(i, 0, DotTypes.AllDots[8].Level, DotTypes.AllDots[8].Color));
                else if (i < 16)
                    dotInEightLine.Add(new Dot(i, 0, DotTypes.AllDots[7].Level, DotTypes.AllDots[7].Color));
                else if (i < 18)
                    dotInEightLine.Add(new Dot(i, 0, DotTypes.AllDots[6].Level, DotTypes.AllDots[6].Color));
                else if (i < 19)
                    dotInEightLine.Add(new Dot(i, 0, DotTypes.AllDots[5].Level, DotTypes.AllDots[5].Color));
                else if (i < 20)
                    dotInEightLine.Add(new Dot(i, 0, DotTypes.AllDots[4].Level, DotTypes.AllDots[4].Color));
                else if (i < 21)
                    dotInEightLine.Add(new Dot(i, 0, DotTypes.AllDots[3].Level, DotTypes.AllDots[3].Color));
                else if (i < 22)
                    dotInEightLine.Add(new Dot(i, 0, DotTypes.AllDots[2].Level, DotTypes.AllDots[2].Color));
                else if (i < 23)
                    dotInEightLine.Add(new Dot(i, 0, DotTypes.AllDots[1].Level, DotTypes.AllDots[1].Color));
                else
                    dotInEightLine.Add(new Dot(i, 0, DotTypes.AllDots[0].Level, DotTypes.AllDots[0].Color));
            }



            for (int i = 0; i < 26; i++)
            {
                if (i < 3)
                    dotInNinthLine.Add(new Dot(i, 0, DotTypes.AllDots[0].Level, DotTypes.AllDots[0].Color));
                else if (i < 4)
                    dotInNinthLine.Add(new Dot(i, 0, DotTypes.AllDots[1].Level, DotTypes.AllDots[1].Color));
                else if (i < 5)
                    dotInNinthLine.Add(new Dot(i, 0, DotTypes.AllDots[2].Level, DotTypes.AllDots[2].Color));
                else if (i < 6)
                    dotInNinthLine.Add(new Dot(i, 0, DotTypes.AllDots[3].Level, DotTypes.AllDots[3].Color));
                else if (i < 7)
                    dotInNinthLine.Add(new Dot(i, 0, DotTypes.AllDots[4].Level, DotTypes.AllDots[4].Color));
                else if (i < 8)
                    dotInNinthLine.Add(new Dot(i, 0, DotTypes.AllDots[5].Level, DotTypes.AllDots[5].Color));
                else if (i < 9)
                    dotInNinthLine.Add(new Dot(i, 0, DotTypes.AllDots[6].Level, DotTypes.AllDots[6].Color));
                else if (i < 11)
                    dotInNinthLine.Add(new Dot(i, 0, DotTypes.AllDots[7].Level, DotTypes.AllDots[7].Color));
                else if (i < 12)
                    dotInNinthLine.Add(new Dot(i, 0, DotTypes.AllDots[8].Level, DotTypes.AllDots[8].Color));
                else if (i < 14)
                    dotInNinthLine.Add(new Dot(i, 0, DotTypes.AllDots[9].Level, DotTypes.AllDots[9].Color));
                else if (i < 15)
                    dotInNinthLine.Add(new Dot(i, 0, DotTypes.AllDots[8].Level, DotTypes.AllDots[8].Color));
                else if (i < 17)
                    dotInNinthLine.Add(new Dot(i, 0, DotTypes.AllDots[7].Level, DotTypes.AllDots[7].Color));
                else if (i < 18)
                    dotInNinthLine.Add(new Dot(i, 0, DotTypes.AllDots[6].Level, DotTypes.AllDots[6].Color));
                else if (i < 19)
                    dotInNinthLine.Add(new Dot(i, 0, DotTypes.AllDots[5].Level, DotTypes.AllDots[5].Color));
                else if (i < 20)
                    dotInNinthLine.Add(new Dot(i, 0, DotTypes.AllDots[4].Level, DotTypes.AllDots[4].Color));
                else if (i < 21)
                    dotInNinthLine.Add(new Dot(i, 0, DotTypes.AllDots[3].Level, DotTypes.AllDots[3].Color));
                else if (i < 22)
                    dotInNinthLine.Add(new Dot(i, 0, DotTypes.AllDots[2].Level, DotTypes.AllDots[2].Color));
                else if (i < 23)
                    dotInNinthLine.Add(new Dot(i, 0, DotTypes.AllDots[1].Level, DotTypes.AllDots[1].Color));
                else
                    dotInNinthLine.Add(new Dot(i, 0, DotTypes.AllDots[0].Level, DotTypes.AllDots[0].Color));
            }


            

            for (int i = 0; i < 26; i++)
            {
                if (i < 3)
                    dotInTenthLine.Add(new Dot(i, 0, DotTypes.AllDots[0].Level, DotTypes.AllDots[0].Color));
                else if (i < 4)
                    dotInTenthLine.Add(new Dot(i, 0, DotTypes.AllDots[1].Level, DotTypes.AllDots[1].Color));
                else if (i < 5)
                    dotInTenthLine.Add(new Dot(i, 0, DotTypes.AllDots[2].Level, DotTypes.AllDots[2].Color));
                else if (i < 6)
                    dotInTenthLine.Add(new Dot(i, 0, DotTypes.AllDots[3].Level, DotTypes.AllDots[3].Color));
                else if (i < 7)
                    dotInTenthLine.Add(new Dot(i, 0, DotTypes.AllDots[4].Level, DotTypes.AllDots[4].Color));
                else if (i < 8)
                    dotInTenthLine.Add(new Dot(i, 0, DotTypes.AllDots[5].Level, DotTypes.AllDots[5].Color));
                else if (i < 9)
                    dotInTenthLine.Add(new Dot(i, 0, DotTypes.AllDots[6].Level, DotTypes.AllDots[6].Color));
                else if (i < 10)
                    dotInTenthLine.Add(new Dot(i, 0, DotTypes.AllDots[7].Level, DotTypes.AllDots[7].Color));
                else if (i < 11)
                    dotInTenthLine.Add(new Dot(i, 0, DotTypes.AllDots[8].Level, DotTypes.AllDots[8].Color));
                else if (i < 12)
                    dotInTenthLine.Add(new Dot(i, 0, DotTypes.AllDots[9].Level, DotTypes.AllDots[9].Color));
                else if (i < 14)
                    dotInTenthLine.Add(new Dot(i, 0, DotTypes.AllDots[10].Level, DotTypes.AllDots[10].Color));
                else if (i < 15)
                    dotInTenthLine.Add(new Dot(i, 0, DotTypes.AllDots[9].Level, DotTypes.AllDots[9].Color));
                else if (i < 16)
                    dotInTenthLine.Add(new Dot(i, 0, DotTypes.AllDots[8].Level, DotTypes.AllDots[8].Color));
                else if (i < 17)
                    dotInTenthLine.Add(new Dot(i, 0, DotTypes.AllDots[7].Level, DotTypes.AllDots[7].Color));
                else if (i < 18)
                    dotInTenthLine.Add(new Dot(i, 0, DotTypes.AllDots[6].Level, DotTypes.AllDots[6].Color));
                else if (i < 19)
                    dotInTenthLine.Add(new Dot(i, 0, DotTypes.AllDots[5].Level, DotTypes.AllDots[5].Color));
                else if (i < 20)
                    dotInTenthLine.Add(new Dot(i, 0, DotTypes.AllDots[4].Level, DotTypes.AllDots[4].Color));
                else if (i < 21)
                    dotInTenthLine.Add(new Dot(i, 0, DotTypes.AllDots[3].Level, DotTypes.AllDots[3].Color));
                else if (i < 22)
                    dotInTenthLine.Add(new Dot(i, 0, DotTypes.AllDots[2].Level, DotTypes.AllDots[2].Color));
                else if (i < 23)
                    dotInTenthLine.Add(new Dot(i, 0, DotTypes.AllDots[1].Level, DotTypes.AllDots[1].Color));
                else
                    dotInTenthLine.Add(new Dot(i, 0, DotTypes.AllDots[0].Level, DotTypes.AllDots[0].Color));
            }



            AllLines.Add(new Line(dotInEmptyLine));
            AllLines.Add(new Line(dotInEmptyLine));
            AllLines.Add(new Line(dotInEmptyLine));
            AllLines.Add(new Line(dotInFirstLine));
            AllLines.Add(new Line(dotInSecondLine));
            AllLines.Add(new Line(dotInThirdLine));
            AllLines.Add(new Line(dotInFourthLine));
            AllLines.Add(new Line(dotInFifthLine));
            AllLines.Add(new Line(dotInSixthLine));
            AllLines.Add(new Line(dotInSeventhLine));
            AllLines.Add(new Line(dotInEightLine));
            AllLines.Add(new Line(dotInNinthLine));
            AllLines.Add(new Line(dotInTenthLine));
            AllLines.Add(new Line(dotInTenthLine));
            AllLines.Add(new Line(dotInNinthLine));
            AllLines.Add(new Line(dotInEightLine));
            AllLines.Add(new Line(dotInSeventhLine));
            AllLines.Add(new Line(dotInSixthLine));
            AllLines.Add(new Line(dotInFifthLine));
            AllLines.Add(new Line(dotInFourthLine));
            AllLines.Add(new Line(dotInThirdLine));
            AllLines.Add(new Line(dotInSecondLine));
            AllLines.Add(new Line(dotInFirstLine));
            AllLines.Add(new Line(dotInEmptyLine));
            AllLines.Add(new Line(dotInEmptyLine));
            AllLines.Add(new Line(dotInEmptyLine));
        }

        public Line Line
        {
            get
            {
                throw new System.NotImplementedException();
            }
            set
            {
            }
        }
    }
}
