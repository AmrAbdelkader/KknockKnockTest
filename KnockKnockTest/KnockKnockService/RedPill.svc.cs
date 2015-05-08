using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.ServiceModel.Activation;
using System.Text;

namespace KnockKnockService
{
    // NOTE: You can use the "Rename" command on the "Refactor" menu to change the class name "RedPill" in code, svc and config file together.
    // NOTE: In order to launch WCF Test Client for testing this service, please select RedPill.svc or RedPill.svc.cs at the Solution Explorer and start debugging.
    [AspNetCompatibilityRequirements(RequirementsMode = AspNetCompatibilityRequirementsMode.Allowed)]
    public class RedPill : IRedPill
    {
        public Guid WhatIsYourToken()
        {
            return System.Guid.Parse("e6070611-4604-414e-9967-37bcde6c001f");
        }

        //return the last number in fibonacci series based on length specified in argumrnt n 
        public long FibonacciNumber(long n)
        {
            if (n == 1 || n == 2)
            {
                return 1;
            }
            long fibo1 = 1, fibo2 = 1, fibonacci = 1;
            for (int i = 3; i <= n; i++)
            {
                fibonacci = fibo1 + fibo2;
                fibo1 = fibo2;
                fibo2 = fibonacci;

            }
            return fibonacci;
        }

        public TriangleType WhatShapeIsThis(int a, int b, int c)
        {
            if (a <= 0 || b <= 0 || c <= 0)
                ThrowFaultException(new ArgumentException(), "Length of sides cannot be less than or equal to 0.");

            //check if this values valid for a triangle or not
            if (a + b < c || b + c < a || a + c < b)
                return TriangleType.Error;
            if (a == b && b == c)
                return TriangleType.Equilateral;
            else if (a == b || b == c || a == c)
                return TriangleType.Isosceles;
            else
                return TriangleType.Scalene;
        }

        public string ReverseWords(string s)
        {
            if (string.IsNullOrEmpty(s))
                ThrowFaultException(new ArgumentException() , "There is no word specified.");
            char[] reversedWord = s.ToCharArray();
            char temp;
            for (int i = 0, j = s.Length - 1; i < s.Length / 2; i++, j--)
            {
                temp = reversedWord[i];
                reversedWord[i] = reversedWord[j];
                reversedWord[j] = temp;
            }
            return new string(reversedWord);

            //another solution
            //string reversedWord = string.Empty;
            //for (int i = s.Length -1 ; i >= 0  ; i--)
            //{
            //    reversedWord += s[i];
            //}
            //return reversedWord;
        }
        void ThrowFaultException<T>(T exception, string message) where T : Exception
        {
            throw new FaultException<T>(exception, message);
        }

    }
}
