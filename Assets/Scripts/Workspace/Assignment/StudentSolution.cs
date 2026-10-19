using System;
using System.Collections.Generic;

namespace Assignment
{
    public class StudentSolution
    {
        #region Lecture

        public int LCT01_RecursiveFactorial(int n)
        {

            return Factorial(n);
        }

        private int Factorial(int n)
        {
            if (n == 0) return 1;
            if (n == 1) return 1;
            return n * Factorial(n - 1);

            return -1;
        }

        public int LCT02_RecursiveFibonacci(int n)
        {
            return Fibonacci(n);
        }

        private int Fibonacci(int n)
        {

            if (n == 0) return 0;
            if (n == 1) return 1;


            return Fibonacci(n - 1) + Fibonacci(n - 2);
        }

        public int LCT03_RecursiveSumOfOneToN(int n)
        {
            return SumOfOneToN(n);
        }

        private int SumOfOneToN(int n)
        {

            if (n <= 1) return n;

            return n + SumOfOneToN(n - 1);
        }

        public int LCT04_RecursiveSumOfNumbers(int[] numbers)
        {
            return SumOfNumbers(numbers, 0);
        }

        private int SumOfNumbers(int[] numbers, int index)
        {

            if (index >= numbers.Length) return 0;


            return numbers[index] + SumOfNumbers(numbers, index + 1);
        }

        #endregion

        #region Assignment

        public int ASN01_RecursivePower(int baseNum, int exponent)
        {
            return Power(baseNum, exponent);
        }

        private int Power(int baseNum, int exponent)
        {
            // Base Case: x^0 = 1
            if (exponent == 0)
            {
                return 1;
            }

            // Recursive Case: x^n = x * x^(n-1)
            return baseNum * Power(baseNum, exponent - 1);
        }

        public bool ASN02_IsPalindrome(string str)
        {
            return IsPalindrome(str, 0, str.Length - 1);
        }

        private bool IsPalindrome(string str, int start, int end)
        {
            // Base Case: ตรวจครบทุกคู่แล้ว (รวมกรณี string ว่าง และมี 1 ตัวอักษร)
            if (start >= end)
            {
                return true;
            }

            // ตัวอักษรหัว-ท้ายไม่ตรงกัน ไม่ใช่ Palindrome
            if (str[start] != str[end])
            {
                return false;
            }

            // Recursive Case: ตรวจคู่ถัดไปที่อยู่ด้านในเข้ามา
            return IsPalindrome(str, start + 1, end - 1);
        }

        public int ASN03_RecursiveGCD(int a, int b)
        {
            return GCD(a, b);
        }

        private int GCD(int a, int b)
        {
            // Base Case: เมื่อ b == 0 คำตอบคือ a
            if (b == 0)
            {
                return a;
            }

            // Recursive Case: Euclidean Algorithm
            return GCD(b, a % b);
        }

        public int ASN04_RecursiveBinarySearch(int[] arr, int target)
        {
            return BinarySearch(arr, target, 0, arr.Length - 1);
        }

        private int BinarySearch(int[] arr, int target, int low, int high)
        {
            // Base Case: หมดช่วงค้นหา ไม่พบ target
            if (low > high)
            {
                return -1;
            }

            int mid = low + (high - low) / 2;

            // พบ target
            if (arr[mid] == target)
            {
                return mid;
            }

            // target อยู่ครึ่งซ้าย
            if (arr[mid] > target)
            {
                return BinarySearch(arr, target, low, mid - 1);
            }

            // target อยู่ครึ่งขวา
            return BinarySearch(arr, target, mid + 1, high);
        }
    }
}

#endregion