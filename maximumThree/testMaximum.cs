using System;
using System.Collections.Generic;
using System.Text;

namespace maximumThree
{
    public class MaximumTest
    {
        public int checkMaxForInteger(int number1,int number2,int number3)
        {
            
            if(number1>number2 && number1>number3)
            {
                return number1;
            }
            else if(number2>number1 && number2>number3)
            {
                return number2;
            }
            else
            {
                return number3;
            }
        }
        public float checkMaxForFloat(float number1, float number2, float number3)
        {

            if (number1 > number2 && number1 > number3)
            {
                return number1;
            }
            else if (number2 > number1 && number2 > number3)
            {
                return number2;
            }
            else
            {
                return number3;
            }
        }
        public string checkMaxForString(string string1, string string2, string string3)
        {

            if (string1.CompareTo(string2)>0 && string1.CompareTo(string3) > 0)
            {
                return string1;
            }
            else if (string2.CompareTo(string1) > 0 && string2.CompareTo(string3) > 0)
            {
                return string2;
            }
            else
            {
                return string3;
            }
        }
    }
}
