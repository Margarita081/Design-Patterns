using System;
using Task3;
class Program
{
    static void Main()
    {
        var proxy1 = new BookProxy("Alice's Adventures in Wonderland", "Lewis Carroll", "User");
        Console.WriteLine(proxy1.Get());

    }
}