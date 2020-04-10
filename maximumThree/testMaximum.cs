using System;
using System.Collections.Generic;
using System.Text;

namespace maximumThree
{
    public class MaximumTest<T> where T: IComparable
    {
        
    
        public T checkMax(T data1, T data2, T data3)
        {

            if (data1.CompareTo(data2) >0 && data1.CompareTo(data3) > 0)
            {
                return data1;
            }
            else if (data2.CompareTo(data1) > 0 && data2.CompareTo(data3) > 0)
            {
                return data2;
            }
            else
            {
                return data3;
            }
        }

        public int CompareTo(object obj)
        {
            throw new NotImplementedException();
        }
    }
}
