using System;
using System.Collections.Generic;
using System.Text;

namespace maximumThree
{/// <summary>
/// add genric and implement interface comparable
/// </summary>
/// <typeparam name="T"> int,float,string</typeparam>
    public class MaximumTest<T> where T: IComparable
    {
        public T output;
        private T data1;
        private T data2;
        private T data3;
       /// <summary>
       /// constructor for assign value
       /// and call to testmaximum for find max value
       /// </summary>
       /// <param name="value1"></param>
       /// <param name="value2"></param>
       /// <param name="value3"></param>
        public MaximumTest(T value1,T value2,T value3)
        {
            data1 = value1;
            data2 = value2;
            data3 = value3;
            output=testMaximum(data1,data2,data3);
        }
    /// <summary>
    /// compare three value together and return max value
    /// </summary>
    /// <param name="data1"></param>
    /// <param name="data2"></param>
    /// <param name="data3"></param>
    /// <returns>max value</returns>
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
