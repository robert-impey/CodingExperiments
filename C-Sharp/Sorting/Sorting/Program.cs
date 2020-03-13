using Gnu.Getopt;
using System;
using System.IO;
using System.Text.RegularExpressions;

namespace Sorting
{
    internal class Program
    {
        private static void Main(string[] args)
        {
            var g = new Getopt("Sorting", args, "a:f:o:");

            string algorithm = "", shuffledListsFileName = "", outputDirectory = ".";

            int c;
            while ((c = g.getopt()) != -1)
            {
                switch (c)
                {
                    case 'a':
                        algorithm = g.Optarg;
                        break;

                    case 'f':
                        shuffledListsFileName = g.Optarg;
                        break;

                    case 'o':
                        outputDirectory = g.Optarg;
                        break;
                }
            }

            if (algorithm.Length > 0 && shuffledListsFileName.Length > 0 && outputDirectory.Length > 0)
            {
                var listsToSort = ParseShuffledListsFile(shuffledListsFileName);
                int[,] sortedLists = new int[listsToSort.NumberOfLists, listsToSort.SizeOfLists];

                switch (algorithm)
                {
                    case "built_in":
                        BuiltInSorting(listsToSort.Lists, ref sortedLists);
                        break;

                    default:
                        Console.WriteLine("Please set a valid sorting algorithm!");
                        break;
                }

                var output
                    = new StreamWriter(GetOutputFileName(algorithm, outputDirectory, listsToSort)
                    );
                PrintListOfLists(sortedLists, output);
                output.Close();
            }
            else
            {
                Console.WriteLine("Please set the algorith, shuffled lists file name and output directory!");
            }
        }

        private static string GetOutputFileName(string algorithm, string outputDirectory, ShuffledLists shuffledLists)
        {
            return outputDirectory + "/"
                                    + "sorted-c_sharp-" + algorithm
                                    + "-" + shuffledLists.NumberOfLists
                                    + "-" + shuffledLists.SizeOfLists
                                    + ".txt";
        }

        #region IO

        private static ShuffledLists ParseShuffledListsFile(string shuffledListsFileName)
        {
            int numberOfLists, sizeOfLists;

            var fileNameParserRegEx = new Regex("(\\d+)-(\\d+)\\.txt$");

            Match fileNameParserMatch = fileNameParserRegEx.Match(shuffledListsFileName);
            if (fileNameParserMatch.Success)
            {
                numberOfLists = Int32.Parse(fileNameParserMatch.Groups[1].Value);
                sizeOfLists = Int32.Parse(fileNameParserMatch.Groups[2].Value);

                var listsToSort = new int[numberOfLists, sizeOfLists];

                var shuffledListsFile = new StreamReader(shuffledListsFileName);
                string shuffledListLine;
                int listIndex = 0;
                while ((shuffledListLine = shuffledListsFile.ReadLine()) != null)
                {
                    char[] separators = { ',' };
                    var shuffledListItems = shuffledListLine.Split(separators);
                    int itemIndex = 0;

                    foreach (var shuffledListItem in shuffledListItems)
                    {
                        listsToSort[listIndex, itemIndex] = Int32.Parse(shuffledListItem);
                        itemIndex++;
                    }
                    listIndex++;
                }

                return new ShuffledLists(numberOfLists, sizeOfLists, listsToSort);
            }
            else
            {
                throw new Exception("Unable to parse the number of lists and the size of the lists from the file name!");
            }
        }

        private static void PrintListOfLists(int[,] listOfLists, StreamWriter output)
        {
            for (int i = 0; i < listOfLists.GetLength(0); i++)
            {
                for (int j = 0; j < listOfLists.GetLength(1); j++)
                {
                    if (j != 0)
                    {
                        output.Write(",");
                    }
                    output.Write(listOfLists[i, j]);
                }
                output.WriteLine();
            }
        }

        #endregion IO

        #region Sorting

        private static void BuiltInSorting(int[,] listsToSort, ref int[,] sortedLists)
        {
            for (int i = 0; i < listsToSort.GetLength(0); i++)
            {
                int[] listToSort = Get1DArrayFrom2DArray(listsToSort, i);

                Array.Sort(listToSort);

                Put1DArrayInto2DArray(listToSort, i, ref sortedLists);
            }
        }

        #endregion Sorting

        #region Helpers

        private static int[] Get1DArrayFrom2DArray(int[,] listsOfLists, int arrayNumber)
        {
            int[] oneDArray = new int[listsOfLists.GetLength(1)];

            for (int i = 0; i < listsOfLists.GetLength(1); i++)
            {
                oneDArray[i] = listsOfLists[arrayNumber, i];
            }

            return oneDArray;
        }

        private static void Put1DArrayInto2DArray(int[] oneDArray, int insertId, ref int[,] twoDArray)
        {
            for (int i = 0; i < oneDArray.Length; i++)
            {
                twoDArray[insertId, i] = oneDArray[i];
            }
        }

        #endregion Helpers
    }
}