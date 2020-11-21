using System;
using System.Threading;
using System.Windows.Forms;
using System.Windows.Forms.DataVisualization.Charting;

namespace WindowsFormsApp1
{
    internal static class Sorting
    {
        static object locker = new object();
        static public void BubbleSort(String[] strs, int[] sortedIndexs)
        {
            String str;
            int length = strs.Length;
            Series series = new Series("Length");

            ViewController.ChageChart(sortedIndexs);
            try
            {
                for (int index = strs.Length - 1, index2 = 0, tmp; index > 0; --index)
                {
                    while (index2 < index)
                    {
                        if (sortedIndexs[index2] > sortedIndexs[index2 + 1])
                        {
                            tmp = sortedIndexs[index2];
                            sortedIndexs[index2] = sortedIndexs[index2 + 1];
                            sortedIndexs[index2 + 1] = tmp;

                            str = strs[index2];
                            strs[index2] = strs[index2 + 1];
                            strs[index2 + 1] = str;
                            ViewController.ChageChart(sortedIndexs);



                            Thread.Sleep(500);

                        }
                        ++index2;
                    }
                    index2 = 0;
                }
            }
            catch (ThreadAbortException ex)
            {
                MessageBox.Show("Goodbye :(");
            }
        }

        static public void SelectionSort(String[] strs, int[] sortedIndexs)
        {
            int tmpInt;
            string tmpStr;
            int length = strs.Length;
            Series series = new Series("Length");
            try
            {
                for (int i = 0, j, k = 0; i < length - 1; ++i)
                {
                    k = i;
                    for (j = i + 1; j < length; ++j)
                    {
                        if (sortedIndexs[k] > sortedIndexs[j])
                            k = j;
                    }
                    if (k != i)
                    {
                        tmpInt = sortedIndexs[k];
                        sortedIndexs[k] = sortedIndexs[i];
                        sortedIndexs[i] = tmpInt;

                        tmpStr = strs[k];
                        strs[k] = strs[i];
                        strs[i] = tmpStr;
                        ViewController.ChageChart(sortedIndexs);

                        Thread.Sleep(500);
                    }
                }
            }
            catch (ThreadAbortException ex)
            {
                MessageBox.Show("Goodbye :(");
            }
        }


        static public void InsertSort(String[] strs, int[] sortedIndexs)
        {
            int length = strs.Length;
            int tmpInt;
            string tmpStr;
            Series series = new Series("Length");
            try
            {
                for (int index = 1, index2; index < length; index++)
                {
                    tmpInt = sortedIndexs[index];
                    tmpStr = strs[index];
                    for (index2 = index - 1; index2 >= 0;)
                    {
                        if (tmpInt < sortedIndexs[index2])
                        {
                            sortedIndexs[index2 + 1] = sortedIndexs[index2];
                            strs[index2 + 1] = strs[index2];
                            index2--;
                            sortedIndexs[index2 + 1] = tmpInt;
                            strs[index2 + 1] = tmpStr;
                            ViewController.ChageChart(sortedIndexs);

                            Thread.Sleep(500);
                        }
                        else
                            break;
                    }
                }
            }
            catch (ThreadAbortException ex)
            {
                MessageBox.Show("Goodbye :(");
            }
        }

        static public void ShellSorting(String[] strs, int[] sortedIndexs)
        {
            int length = strs.Length;
            int tmpInt;
            string tmpStr;
            Series series = new Series("Length");
            try
            {
                for (int step = length / 2; step > 0; step /= 2)
                {
                    for (int i = step; i < length; i++)
                    {
                        for (int j = i - step; j >= 0 && sortedIndexs[j] > sortedIndexs[j + step]; j -= step)
                        {
                            tmpInt = sortedIndexs[j];
                            sortedIndexs[j] = sortedIndexs[j + step];
                            sortedIndexs[j + step] = tmpInt;

                            tmpStr = strs[j];
                            strs[j] = strs[j + step];
                            strs[j + step] = tmpStr;

                            ViewController.ChageChart(sortedIndexs);
                            Thread.Sleep(500);
                        }
                    }
                }
            }
            catch (ThreadAbortException ex)
            {
                MessageBox.Show("Goodbye :(");
            }
        }

    }
}