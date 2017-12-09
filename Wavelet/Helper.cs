using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace Wavelet
{
    static class Helper
    {
        public static double[] GetVector(System.Windows.Forms.OpenFileDialog dialog)
        {
            if (dialog.ShowDialog() == System.Windows.Forms.DialogResult.OK)
            {
                return File.ReadAllLines(dialog.FileName)
                        .Select(double.Parse)
                        .ToArray();
            }
            else return null;
        }
        public static double[] CopyOf(double[] sourceArray, double coeff)
        {
            double[] temp = new double[sourceArray.Length];
            for (int i = 0; i < sourceArray.Length; i++)
            {
                temp[i] = sourceArray[i]*coeff;
            }
            return temp;
        }
        public static void FillListView(System.Windows.Forms.ListView listView, double[] array)
        {
            listView.Items.Clear();
            for(int i = 0; i < array.Length; i++)
            {
                listView.Items.Add(Math.Round(array[i], 5).ToString());
            }
        }
    }
}
