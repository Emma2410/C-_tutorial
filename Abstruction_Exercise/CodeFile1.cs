using System;

struct MyStuct
{
    int i;
    public MyStuct (int i)
    {
        this.i = i; 
    }
    public void Display() {
        Console.WriteLine("Method is a structure  " + i);

    }
    static void Main() { 
        MyStuct m1 = new MyStuct();
        m1.i =10;
        m1.Display(); 

        MyStuct m2  = new MyStuct(30);
        m2.Display();
        Console.ReadLine();
    }
}