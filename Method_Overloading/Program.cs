using System;

namespace Method_Overloading
{
    class Program
    {
        static void Main(string[] args)
        {
            var num = Add(1, 2);  // add(1,) is the arguemnt
            var deci = Add(1.0, 1.0);
            Console.WriteLine(num);  //  var num will print to screen
            Console.WriteLine($"The sum of the two doubles = {deci}"); // same as above, but can add words in ""

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

            if (check == true && sum > 1)        //  or if(check == true && (x + y) == 1    // if(check==true)
            {                                                                               // {
                return $"{sum} dollars";         // return $"{x+y} dollar";                 //    if(x+y!=1)
            }                                                                               //   {
            else if (check == true && sum == 1)  // elise if(check == true)                 // return $"{x+y} dollars";
            {                                                                               // }
                return $"{sum} dollar";          // return${x+y} dollars";                  // else
            }                                                                               // {
            else if (check == true && sum < 1)   // else                                    // return $"{x+y} dollars";
            {                                                                               // }                                                                                  
                return $"{sum} dollars";        // return$"{x+y}";                          // }
            }                                                                               // else
            else                                                                            // {
            {                                                                               // return (x+y).ToString();
                return sum.ToString();
            }

        }
      
        {
        public static int Add1(params int[] x)  //take into account for all of the possibilities of the int from above
        {
            int answer = 0;

            foreach (var num in x)
            {
                answer += num;
            }
            return answer;
        }
        }
    }
}
