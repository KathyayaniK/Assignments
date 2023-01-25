// Assignment - 1

/**

Maximum Occurrence

Given a string text. 
Write a function that returns the character with the highest frequency. 
If more than 1 character has the same highest frequency, return all those characters as a comma separated string.
If there is no repetition in characters, return "No Repetition".

Example

MaxOccur("Computer Science") ➞ "e"

MaxOccur("Edabit") ➞ "No Repetition"

MaxOccur("system admin") ➞ "m, s"

MaxOccur("the quick brown fox jumps over the lazy dog") ➞ " "

**/
using System;
using System.Collections.Generic;
using System.Linq;

namespace assignment{
public class Program
{
	public static void Main(string txt)
	{
		var str = Console.ReadLine();
		var count = 0;
		var MaxVal = 0;
		List<string> result = new List<string>();
		string answer = new string(str.Distinct().ToArray());
		Console.WriteLine(answer);
			foreach(var j in answer){
				count = str.Count(i => (i==j));
				if(count > MaxVal){
					MaxVal = count;
					result.Clear();
					result.Add(Convert.ToString(j));
				}else if(count == MaxVal){
					MaxVal = count;
					result.Add(Convert.ToString(j));
				}
			}	
		if(MaxVal==1){
		Console.WriteLine("No repitition");
		}else{
			result.ForEach(p => Console.WriteLine(p));
		}
		
	}
}
}