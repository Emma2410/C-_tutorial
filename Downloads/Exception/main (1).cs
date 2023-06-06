/******************************************************************************

                            Online C# Compiler.
                Code, Compile, Run and Debug C# program online.
Write your code in this editor and press "Run" button to execute it.

*******************************************************************************/

using System;
class ExceptionDemo
{
	static void Main()
	{
		Console.Write("Enter 1st Number:");
		try{
		int x = int.Parse(Console.ReadLine());
		Console.Write("Enter 2nd Number:");
		int y  = int.Parse(Console.ReadLine());
		int z = x/y;
		Console.WriteLine("The result is :" + z);
		}catch (DivideByZeroException e) {
            Console.WriteLine(e.Message);
        }
        catch(FormatException e){
            Console.WriteLine(e.Message);
        }
        catch(Exception e){
            Console.WriteLine(e.Message);
        }
		Console.WriteLine("End of the program");
	}
}
