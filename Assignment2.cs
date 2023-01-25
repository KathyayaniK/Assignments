//Assignment - 2 

/**
In this challenge, you must verify the equality of two different values given the parameters a and b.

Both the value and type of the parameters need to be equal. The possible types of the given parameters are:

Numbers
Strings
Booleans (false or true)
What have you learned so far that will permit you to do two different checks (value and type) with a single statement?

Implement a function that returns true if the parameters are equal, and false if they are not.

Examples
CheckEquality(1, true) ➞ false
// A number and a boolean: the value and type are different.

CheckEquality(0, "0") ➞ false
// A number and a string: the type is different.

CheckEquality(1,  1) ➞ true
// A number and a number: the type and value are equal. **/

using System;
					
namespace Assignment2{
public class Program
{
	public static void Main()
	{
		
		Program program = new Program();
		Console.WriteLine(program.CheckEquality(1,true));
		Console.WriteLine(program.CheckEquality(1,"1"));
		Console.WriteLine(program.CheckEquality(1,1));
		
	}
	
	public bool CheckEquality<T,n>(T var1, n var2){
		return var1.Equals(var2);
	}
}
}
