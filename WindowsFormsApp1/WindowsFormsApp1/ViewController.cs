using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms.DataVisualization.Charting;

namespace WindowsFormsApp1
{
    static class ViewController
    {
        private static Form1 f1 = null;
        private static string _result = "Result";
        static object locker = new object(); 
        public static void SetForm(Form1 form)
        {
            if(f1 == null)
            {
                f1 = form;
            }
        }
        public static void ChageChart(int[] sortedIndexs)
        {
            lock (locker)
            {
                Series srs = new Series("Length");
                for (int index3 = 0, length = sortedIndexs.Length; index3 < length; ++index3)
                {
                    srs.Points.AddXY(index3, sortedIndexs[index3]);
                }
                f1.Invoke(new Action(() =>
                {
                    (f1.Controls[_result] as Chart).Series.Clear();
                    (f1.Controls[_result] as Chart).Series.Add(srs);
                }));

            }
        }
    }
}
