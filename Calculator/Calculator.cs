using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CalculatorLibrary
{
    public static class Calculator
    {
        public static double Add(double a, double b) {
            return a + b;
        }
        public static double Subtract(double a, double b) {
            return a - b;
        }

        public static double Multiply(double a, double b) {
            return a * b;
        }

        public static double Divide(double a, double b) {
            return a / b;
        }

        public static double Sum(double[] numbers) {
            double sum = 0;
            foreach (double number in numbers) {
                sum += number;
            }
            return sum;
        }

        public static double Minimum(double[] numbers) {
            double small = numbers[0];
            foreach (double number in numbers) {
                if (small > number) {
                    small = number;
                }
            }
            return small;
        }

        public static double Maximum(double[] numbers) {
            double big = numbers[0];
            foreach (double number in numbers) {
                if (big < number) {
                    big = number;
                }
            }
            return big;
        }

        public static double Average(double[] numbers) {
            return Sum(numbers) / numbers.Length;
        }
    }
}
