using System;
using System.Collections.Generic;
using System.Linq;
using System.Numerics;
using System.Text;
using System.Threading.Tasks;

namespace Tools
{
    public static class HandleFibonacci
    {
        public static BigInteger Fibonacci(int n)
        {

            ulong firstnumber = 0, secondnumber = 1, result = 0;
            if (n < -1) return -1;
            if (n == 0) return 0;
            if (n == 1) return 1;
            //  JE METS MA LIMITE A 93, MON BIGINTEGER NE VAS PAS AU DESSUS
            if (n > 93) return -1;

            //BigInteger maxValue = new BigInteger(354224848179261915075);
            BigInteger maxValue = new BigInteger(12200160415121876738);  //  VALEUR  93

            for (int i = 2; i <= n; i++)
            {
                result = firstnumber + secondnumber;
                
                if (result <= 0 || result > maxValue)
                    return -1;

                firstnumber = secondnumber;
                secondnumber = result;
            }
            return result;
        }


        #region Autres...

        public static void Fibonacci_Iterative(int len)
        {
            int a = 0, b = 1, c = 0;
            Console.Write("{0} {1}", a, b);
            for (int i = 2; i < len; i++)
            {
                c = a + b;
                Console.Write(" {0}", c);
                a = b;
                b = c;
            }
        }

        public static void Fibonacci_Recursive(int len)
        {
            Fibonacci_Rec_Temp(0, 1, 1, len);
        }

        private static void Fibonacci_Rec_Temp(int a, int b, int counter, int len)
        {
            if (counter <= len)
            {
                Console.Write("{0} ", a);
                Fibonacci_Rec_Temp(b, a + b, counter + 1, len);
            }
        }

        public static int GetNthFibonacci_Ite(int n)
        {
            int number = n - 1; 
            int[] Fib = new int[number + 1];
            Fib[0] = 0;
            Fib[1] = 1;
            for (int i = 2; i <= number; i++)
            {
                Fib[i] = Fib[i - 2] + Fib[i - 1];
            }
            return Fib[number];
        }

        public static int GetNthFibonacci_Rec(int n)
        {
            try
            {
                if ((n == 0) || (n == 1))
                {
                    return n;
                }
                else
                    return GetNthFibonacci_Rec(n - 1) + GetNthFibonacci_Rec(n - 2);
            }
            catch (Exception)
            {
                return -1;
            }
        }

        #endregion
    }

}
