using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HesapMakinesi
{
    class İslemler
    {
        public double toplama(double a, double b)
        {
            double sonuc= a+b;
            return sonuc;
        }
        public double carpma(double a,double b)
        {
            double sonuc = a * b;
            return sonuc;
        }
        public double bolme(double a, double b)
        {
            double sonuc = a / b;
            return sonuc;
        }
    }
}
