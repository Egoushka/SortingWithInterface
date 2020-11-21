using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowsFormsApp1
{
    enum SortType
    {
        lettersCount,
        lineLength,
        wordsCount,
        signsCount

    }
    enum SortMethod
    {
        Bubble,
        Selection,
        Insertion,
        Shell
    }
    static class Controller
    {
        public static string[] strs = { "hghAAAAAgh", "hgdAAAAAgfh", "gfgAAAAAAAAAAAAAAAAAAdfdgd", "hghghgfhfAAhhwhrthrtether", "hgghAAAAAAAAAgfh" };
        public static SortType st;
        public static SortMethod sm;
        static public void Sort()
        {
            int[] sortedArrByIndexes = new int[strs.Length];
            switch (st)
            {
                case SortType.lettersCount:
                    {
                        sortedArrByIndexes = SortingTypes.CountByLettersA(strs);
                        break;
                    }
                case SortType.lineLength:
                    {
                        sortedArrByIndexes = SortingTypes.CountByLength(strs);
                        break;
                    }
                case SortType.wordsCount:
                    {
                        sortedArrByIndexes = SortingTypes.CountByWords(strs);
                        break;
                    }
                case SortType.signsCount:
                    {
                        sortedArrByIndexes = SortingTypes.CountByPunctSings(strs);
                        break;
                    }
                default:
                    break;
            }

            switch (sm)
            {
                case SortMethod.Bubble:
                    {
                        Sorting.BubbleSort(strs, sortedArrByIndexes);
                        break;
                    }
                case SortMethod.Insertion:
                    {
                        Sorting.InsertSort(strs, sortedArrByIndexes);
                        break;
                    }
                case SortMethod.Selection:
                    {
                        Sorting.SelectionSort(strs, sortedArrByIndexes);

                        break;
                    }
                case SortMethod.Shell:
                    {
                        Sorting.ShellSorting(strs, sortedArrByIndexes);
                        break;
                    }
                default:
                    break;
            }

        }

    }
}