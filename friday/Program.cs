using System;

namespace friday
{
    class Program
    {
        static void Main(string[] args)
        {

            char[] letters = new char[4]{ 'g', 'i', 'r', 'l' };
            var length = letters.Length;
            var myLetters = letters.Clone();
            char[] newLetter = { };
            letters.CopyTo(newLetter, 2);

            int[,,] array3D = new int[3, 5, 4] {
                { { 2, 3, 4, 5 }, { 2, 3, 4, 5 }, { 2, 3, 4, 5 }, { 2, 3, 4, 5 }, { 2, 3, 4, 5 } },
                { { 2, 3, 4, 5 }, { 2, 3, 4, 5 }, { 2, 3, 4, 5 }, { 2, 3, 4, 5 }, { 2, 3, 4, 5 } },
                { { 2, 3, 4, 5 }, { 2, 3, 4, 5 }, { 2, 3, 4, 5 }, { 2, 3, 4, 5 }, { 2, 3, 4, 5 } }
            };

            double[] doubleNumber = new double[4] { 1, 2, 3, 4 };

            DateTime[,] dates = new DateTime[5, 5]
            {
                { new DateTime(2021, 11, 1), new DateTime(2021, 11, 1), new DateTime(2021, 11, 1), new DateTime(2021, 11, 1), new DateTime(2021, 11, 1) },
                { new DateTime(2021, 11, 1), new DateTime(2021, 11, 1), new DateTime(2021, 11, 1), new DateTime(2021, 11, 1), new DateTime(2021, 11, 1) },
                { new DateTime(2021, 11, 1), new DateTime(2021, 11, 1), new DateTime(2021, 11, 1), new DateTime(2021, 11, 1), new DateTime(2021, 11, 1) },
                { new DateTime(2021, 11, 1), new DateTime(2021, 11, 1), new DateTime(2021, 11, 1), new DateTime(2021, 11, 1), new DateTime(2021, 11, 1) },
                { new DateTime(2021, 11, 1), new DateTime(2021, 11, 1), new DateTime(2021, 11, 1), new DateTime(2021, 11, 1), new DateTime(2021, 11, 1) }

            };


        }
    }
}
