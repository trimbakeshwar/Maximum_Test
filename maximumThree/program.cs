using System;
using System.Collections.Generic;
using System.Text;

namespace maximumThree
{
    class program
    {
        static void Main(String[] args)
        {
            MaximumTest<int> maximumInteger = new MaximumTest<int>(4, 3, 2);
           
            MaximumTest<float> maximumFloat = new MaximumTest<float>(4.2f, 4.25f, 4.02f);
            
            MaximumTest<string> maximumString = new MaximumTest<string>("amar", "akbar", "anthani");
           

        }
    }
}
