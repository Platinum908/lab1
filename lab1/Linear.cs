using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lab1
{
    public class Linear:Series
    {
        private int first;
        private int differenc;
        

        public Linear(int first, int differenc)
        {
            this.first = first;
            this.differenc = differenc;
        }
        public override int GetElement(int n)
        {
            return first +(n-1) * differenc;
        }
    }
}
