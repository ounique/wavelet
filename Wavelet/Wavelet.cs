using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Wavelet
{
    class Wavelet
    {
        private double[] coeff;
        private int order;
        public Wavelet()
        {

        }
        public Wavelet(double[] array)
        {
            setCoeff(array);
        }
        public void setCoeff(double[] coeff)
        {
            order = coeff.Length;
            this.coeff = Helper.CopyOf(coeff, Math.Sqrt(2));
        }
        public double[] getCoeff()
        {
            return coeff;
        }
        private double getFirstSum()
        {
            double sum = coeff[0];
            for(int i = 1; i < coeff.Length; i++)
            {
                sum += coeff[i];
            }
            return sum;
        }
        public double[] getSums()
        {
            double[] temp = new double[order / 2 + 1];
            temp[0] = getFirstSum();
            int m = 0;
            for (int i = 1; i < temp.Length; i++)
            {
                double sum = 0;
                for (int j = 0; j + 2*m < order; j++)
                {
                    sum += coeff[j] * coeff[j + 2*m];
                }
                temp[i] = sum;
                m++;
            }
            return temp;
        }
    }
}
