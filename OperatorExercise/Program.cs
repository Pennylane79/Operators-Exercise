﻿namespace OperatorExercise
{
    public class Program
    {
        static void Main(string[] args)
        {
            int a = 17;
            int b = 4;

            int sum = a + b;
            int diff = a - b;
            int prod = a * b;

            int qout = a / b;
            int rem = a % b;

            Console.WriteLine($"{a}/{b} ={qout}have{sum}a{diff}wonderful{prod}time{rem}");

            var answerOne = CircleArea(1.5);
            Console.WriteLine(answerOne);
 


        }
        public static double CircleArea(double radius)
        {
            return Math.PI * radius * radius;
        }
    }
}
