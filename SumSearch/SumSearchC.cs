using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SumSearch
{
    internal class SumSearchC
    {
        public bool IsSumExist(List<int> number, int k)
        {
            for(int i=0; i<number.Count; i++)
            {
                for(int j=i+1; j < number.Count; j++)
                {
                    if(number[i] + number[j] == k) return true;
                }
            }
            return false;
        }
    }
}
