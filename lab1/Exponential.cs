using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lab1
{
    public class Exponential:Series
    {
        private int firstElement;
        private int ratio;

        public Exponential(int firstElement, int ratio)
        {
            this.firstElement = firstElement;
            this.ratio = ratio;
        }

        public override int GetElement(int n)
        {
            return (int)(firstElement * Math.Pow(ratio, n - 1));
        }
    }
}
