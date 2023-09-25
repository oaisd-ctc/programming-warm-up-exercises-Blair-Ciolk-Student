using System;

namespace NoviceChallenges
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] nums = { 50, 50, 50, 50, 50, 50, 50, 50, 50, 50 };
            // Console.WriteLine(Add(1, 3));
            // Console.WriteLine(IsEven(0));
            // Console.WriteLine(MaxOfThree(2, 74, 6));
            // Console.WriteLine(StringLength("five"));
            // Console.WriteLine(StartsHello(" I'm Blair"));
            // Console.WriteLine(ReverseString("test test test"));
            // Console.WriteLine(Factorial(5));
            // Console.WriteLine(IsPrime(3));
            // Console.WriteLine(Fibonacci(50));
            // Console.WriteLine(LargestInArray(nums));

            //Console.WriteLine(IsPalindrome("tac ocat"));
            // Console.WriteLine(ArraySum(nums));
            // Console.WriteLine(CharCount("Prolly cop a script o roxy oddy kinda sloppy", 'p'));
            //   Console.WriteLine(ConcatenateStrings("Hello, yesterday", "i went to the store"));
            Console.WriteLine(SwapEnds("this isn't cool"));
        }

        // 1. Return the sum of two numbers.
        public static int Add(int a, int b)
        {
            return a + b;
        }

        // 2. Given an integer, return true if it's even, else return false.
        public static bool IsEven(int number)
        {
            return number % 2 == 0;
        }

        // 3. Return the largest of three numbers.
        public static int MaxOfThree(int a, int b, int c)
        {
            // HINT: You might want to use Math.Max function.
            // TODO: Implement this method.
            int large1 = Math.Max(a, b);
            int large2 = Math.Max(b, c);
            int final = Math.Max(large1, large2);
            return final;
        }

        // 4. Return the length of the given string.
        public static int StringLength(string s)
        {
            int length = 0;
            for (int x = 0; x < s.Length; x++)
            {
                length++;
            }
            return length;
        }

        // 5. Return true if the string starts with "Hello", otherwise return false.
        public static bool StartsHello(string s)
        {
            // Using ToLower() first will ensure you handle things like "Hello", "HELLO", "HEllo" etc
            return s.ToLower().StartsWith("hello");
        }

        // 6. Reverse a given string.
        public static string ReverseString(string s)
        {
            char[] charArray = s.ToCharArray();
            // TODO: Reverse the charArray.
            Array.Reverse(charArray);
            return new string(charArray);
        }

        // 7. Return the factorial of a number.
        public static int Factorial(int n)
        {
            int result = 1;
            if (n == 0) return 1;
            // TODO: Calculate the factorial.
            while (n != 1)
            {
                result *= n;
                n--;
            }
            return result;
        }

        // 8. Check if a number is a prime number.
        public static bool IsPrime(int number)
        {
            if (number <= 1) return false;
            if (number == 2) return true;
            for (int i = 2; i < number; i++)
            {
                if (number % i == 0) return false;
            }
            return false;
        }

        // 9. Return the nth Fibonacci number.
        public static int Fibonacci(int n)
        {
            if (n <= 1) return n;
            // TODO: Calculate the nth Fibonacci number.
            int[] a = new int[n + 1];
            a[0] = 0;
            a[1] = 1;

            int blockBefore = 0;
            int currentBlock = 1;
            int newBlock = 0;

            for (int i = 2; i <= n; i++)
            {
                newBlock = blockBefore + currentBlock;
                blockBefore = currentBlock;
                currentBlock = newBlock;
            }

            return newBlock;
        }

        // 10. Given an array of integers, return the largest number.
        public static int LargestInArray(int[] numbers)
        {
            int largest = numbers[0];
            for (int i = 1; i < numbers.Length; i++)
            {
                if (numbers[i] > largest)
                {
                    largest = numbers[i];
                }

            }
            return largest;
        }

        // 11. Check if a string is a palindrome (reads the same forward and backward).
        public static bool IsPalindrome(string s)
        {
            int length = s.Length;

            for (int i = 0; i < length / 2; i++)
            {
                if (s[i] != s[length - 1 - i])
                {
                    return false;
                }
            }
            return true;
        }

        // 12. Given an array of integers, return the sum of its elements.
        public static int ArraySum(int[] numbers)
        {
            int sum = 0;

            // TODO: Calculate the sum of the array's elements.
            foreach (int number in numbers)
            {
                sum += number;
            }
            return sum;
        }

        // 13. Given a string, count how many times a specified character appears in it.
        public static int CharCount(string s, char c)
        {
            int count = 0;

            // TODO: Count how many times character c appears in string s.
            foreach (char character in s)
            {
                if (character == c)
                {
                    count++;
                }
            }
            return count;
        }

        // 14. Given two strings, return a new string that is the concatenation of the two strings with a space in between.
        public static string ConcatenateStrings(string str1, string str2)
        {
            // TODO: Concatenate the two strings with a space in between.
            return str1 + " " + str2;
        }

        // 15. Given a string, return a new string where the first and last characters have been swapped.
        public static string SwapEnds(string s)
        {
            if (s.Length <= 1) return s;
            char firstChar = s[0];
            char lastChar = s[s.Length - 1];
            string middleChars = s.Substring(1, s.Length - 2);

            // TODO: Swap the first and last characters and return the modified string.
            return lastChar + middleChars + firstChar;
        }
    }
}
