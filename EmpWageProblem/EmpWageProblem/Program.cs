// See https://aka.ms/new-console-template for more information

    using System;
int Fulltime = 1;
Random random_num = new Random();
int checkemp = random_num.Next(0, 2);
if (checkemp == Fulltime)
{
    Console.WriteLine("Employee Is Present");
}
else
{
    Console.Write("Employee is Absent");
}