using System.ComponentModel;
using System.Diagnostics.CodeAnalysis;

for (int i = 0; i < 5; i++)
{
    Console.WriteLine("Hello, World!");
}

//int total = 0;

//for (int i = 0; i < 50; i++)
//{
//    total = total + 1;

//    if (total % 2 !=0)
//        Console.Write($"{total}:");
//
//    else
//        continue;
//    
//}

string deez_nutz = "Hello World";

int size = deez_nutz.Length;

for (int i = size - 1; i >=0; i--)
{
    Console.Write(deez_nutz[i]);
}