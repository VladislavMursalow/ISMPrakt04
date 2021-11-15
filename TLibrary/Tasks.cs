using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TLibrary
{
    public static class Tasks
    {
        //For1
        public static int MultiplyFromAtoB(int A, int B)
        {
            int result = 1;
            for (int i = A; i <= B; i++)
            {
                result *= i;
            }
            return result;
        }

        //For2
        public static float MapSumToN(int N)
        {
            float result = 0;
            for (float i = 1; i <= N; i++)
            {
                result += 1 / i;
            }

            return result;
        }

        //For3
        public static float PowToN(float A, int N)
        {
            float result = 1;
            for (float i = 1; i <= N; i++)
            {
                result *= A;
            }
            return result;
        }

        //For4
        public static int FindSumOfSqueresFromAtoB(int A, int B)
        {
            int result = 0;

            for (int i = A; i <= B; i++)
            {
                result += (int)Math.Pow(i, 2);
            }

            return result;
        }

        //For5
        public static int MapFactorialSummToN(int N)
        {
            int result = 0;
            for (int i = 1; i <= N; i++)
            {
                result += FindFactiorial(i);
            }

            return result;
        }

        //While1
        public static int MapPowToN(int N)
        {
            int result = 0;

            int i = 1;
            int degree = N;
            while (i <= N)
            {
                result += (int)Math.Pow(i, degree);
                i++;
                degree--;
            }

            return result;
        }

        //While2
        public static int FindLessDegreeNum(int N)
        {
            int K = 0;

            while ((int)Math.Pow(3, K) < N) K++;

            return K;
        }

        //while3
        public static float FindTaskParameters(float P, float StartDistance, out int days)
        {
            float S = StartDistance;
            int countDays = 1;
            while (S < 200)
            {
                S += S * P;
                countDays++;
            }

            days = countDays;
            return S;
        }

        //DoWhile1
        public static void DoWhileTask()
        {

        }

        //HelpFunks
        private static int FindFactiorial(int num)
        {
            int result = 1;
            for (int i = 1; i <= num; i++)
            {
                result *= i;
            }
            return result;
        }
    }
}
