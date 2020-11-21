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
        signsCount,
        wordsDigitCount

    }
    enum SortMethod
    {
        bubble,
        selection,
        insertion,
        shell
    }
    static class Controller
    {
        public static string[] strs = null;
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
                case SortType.wordsDigitCount:
                    {
                        sortedArrByIndexes = SortingTypes.CountByWordsDigit(strs);
                        break;
                    }
                    
                default:
                    break;
            }

            switch (sm)
            {
                case SortMethod.bubble:
                    {
                        Sorting.BubbleSort(strs, sortedArrByIndexes);
                        break;
                    }
                case SortMethod.insertion:
                    {
                        Sorting.InsertSort(strs, sortedArrByIndexes);
                        break;
                    }
                case SortMethod.selection:
                    {
                        Sorting.SelectionSort(strs, sortedArrByIndexes);

                        break;
                    }
                case SortMethod.shell:
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