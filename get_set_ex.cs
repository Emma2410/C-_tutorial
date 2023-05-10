/******************************************************************************

                            Online C# Compiler.
                Code, Compile, Run and Debug C# program online.
Write your code in this editor and press "Run" button to execute it.

*******************************************************************************/
// When you declare public variable, anyone can control it;
using System;
class Circle {
    double _Radius = 12.34;  // field name is _radius
    public double Radius{       // method name is radius
        get{return _Radius;} // readonly
        set{_Radius = value;} // write only
    }
}

class TestCircle{
    static void Main(){
        Circle c = new Circle();
        c.Radius =14;    // calling the get accessor of property
        Console.WriteLine(c.Radius);  // calling the set accessor of property
    }
}
