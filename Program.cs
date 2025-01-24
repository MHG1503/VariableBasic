// See https://aka.ms/new-console-template for more information
using VariableBasic.Models;

Console.WriteLine("Hello, .NET 02!");

var minh = new Student();
minh.Id = 1;
minh.Name = "Minh";
minh.Email = "m1503@gmail.com";

System.Console.WriteLine(minh.Id);
System.Console.WriteLine(minh.Name);
System.Console.WriteLine(minh.Email);