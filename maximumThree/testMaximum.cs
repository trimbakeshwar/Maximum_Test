using System;
using System.Collections.Generic;
using System.Text;

namespace maximumThree
{
    public class MaximumTest<T> where T: IComparable
    {
        public T output;
        private T data1;
        private T data2;
        private T data3;
       
        public MaximumTest(T value1,T value2,T value3)
        {
            data1 = value1;
            data2 = value2;
            data3 = value3;
            output=testMaximum(data1,data2,data3);
        }
    
         public T testMaximum(T data1, T data2, T data3)
        {

            if (data1.CompareTo(data2) >0 && data1.CompareTo(data3) > 0)
            {
                return printMaximum(data1);
            }
            else if (data2.CompareTo(data1) > 0 && data2.CompareTo(data3) > 0)
            {
                return printMaximum(data2);
            }
            else
            {
                return printMaximum(data3);
            }
        }
        public T printMaximum(T max)
        {
            Console.WriteLine("max value = "+max);
            return max;
        }
        public int CompareTo(object obj)
        {
            throw new NotImplementedException();
        }

    }
}
