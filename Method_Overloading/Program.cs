using System;

namespace Method_Overloading
{
    class Program
    {
        static void Main(string[] args)
        {
            var num = Add(1, 2);  // add(1,) is the arguemnt
            var dec = Add(1.0, 1.0);
            Console.WriteLine(num);  //  var num will print to screen
            Console.WriteLine($"The sum of the two doubles =: {dec}"); // same as above, but can add words in ""

            var thirdAnswer = Add(1, 1, true);
            Console.WriteLine(thirdAnswer);
        }
        public static int Add(int x, int y)  // first method
        {
          return x + y;
        }
        public static double Add(double x, double y)  //method overload
        {
            return x + y;
        }
        public static string Add(int x, int y, bool check)
        {
            var sum = x + y;
           
            if (check == true && sum > 1)
            {
                return $"{sum} dollars";
            }
            else if (check == true && sum == 1)
            {
                return $"{sum} dollar";
            }
            else if (check == true && sum < 1)
            {
                return $"{sum} dollars";
            }
            else
            {
                return sum.ToString();
            }

        }
      
    }
}
