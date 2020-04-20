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
        //attributes
        public T output;
        private T valueOne;
        private T valueTwo;
        private T valueThree;
       /// <summary>
       /// constructor for assign value
       /// and call to testmaximum for find max value
       /// </summary>
       /// <param name="value1"></param>
       /// <param name="value2"></param>
       /// <param name="value3"></param>
       
        public MaximumTest(T valueOne, T valueTwo, T valueThree)
        {
            this.valueOne = valueOne;
            this.valueTwo = valueTwo;
            this.valueThree = valueThree;
            //cll to test max
            output=testMaximum(valueOne, valueTwo, valueThree);
        }
    /// <summary>
    /// compare three value together and return max value
    /// </summary>
    /// <param name="dataOne"></param>
    /// <param name="dataTwo"></param>
    /// <param name="dataThree"></param>
    /// <returns>max value</returns>
         public T testMaximum(T valueOne, T valueTwo, T valueThree)
        {
            //compare one value with other 2 and call maximum value
            if (valueOne.CompareTo(valueTwo) >0 && valueOne.CompareTo(valueThree) > 0)
            {
                //call to printmax method and print max value and return maxx value
                return printMaximum(valueOne);
            }
            //compare one value with other 2 and call maximum value
            else if (valueTwo.CompareTo(valueOne) > 0 && valueTwo.CompareTo(valueThree) > 0)
            {
                return printMaximum(valueTwo);
            }
            else
            {
                return printMaximum(valueThree);
            }
        }

        public T printMaximum(T maximum)
        {
            Console.WriteLine("max value = "+ maximum);
            return maximum;
        }
        public int CompareTo(object obj)
        {
            throw new NotImplementedException();
        }

    }
}
