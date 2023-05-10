/******************************************************************************

                            Online C# Compiler.
                Code, Compile, Run and Debug C# program online.
Write your code in this editor and press "Run" button to execute it.

*******************************************************************************/
// When you declare public variable, anyone can control it;
using System;
class Circle {
    public double Radius = 12.34;
}

class TestCircle{
    static void Main(){
        Circle c = new Circle();
        Console.WriteLine(c.Radius);
    }
}
