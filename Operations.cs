using System;
internal class Program
{
    static void Main(string[] args)
    {
        Console.Write(" Please the first number: ");
        int firstNumber = int.Parse(Console.ReadLine());
        Console.Write(" Please the first number: ");
        int _ = int.Parse(Console.ReadLine());
        Console.WriteLine($" {firstNumber} + {_} = {firstNumber + _}");
        Console.WriteLine($" {firstNumber} * {_} = {firstNumber * _}");
        Console.WriteLine($" {firstNumber} - {_} = {firstNumber - _}");
        Console.WriteLine($" {firstNumber} / {_} = {firstNumber / _}");
    }
}