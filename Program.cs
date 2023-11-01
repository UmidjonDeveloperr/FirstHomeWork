using System;
// First
int radius=Convert.ToInt32(System.Console.ReadLine());
float pi=3.1415f;
decimal yuza =(decimal)pi*radius*radius;
float length=2*pi*radius;
System.Console.WriteLine($"S={yuza}, L={length}");

// Second

System.Console.WriteLine("Enter a value: ");
int val = Convert.ToInt32(Console.ReadLine());
System.Console.WriteLine("Enter a kurs: ");
int kurs = Convert.ToInt32(Console.ReadLine());
System.Console.WriteLine($"Result of convertation: {val*kurs}");

// Third

System.Console.WriteLine("Enter a year of your birth: ");
int YearOfBirth = Convert.ToInt32(Console.ReadLine());
System.Console.WriteLine($"You have lived for {(2023-YearOfBirth)*365} days!");