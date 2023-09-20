using System.Runtime.InteropServices;
using System.Collections.Generic;

for ( int i = 1; i < 256; i++ )
{
    List<string> output = new List<string>();
    if ( i % 3 == 0 ) output.Add("Fizz");
    if ( i % 5 == 0 ) output.Add("Buzz");
    if ( i % 7 == 0 ) output.Add("Bang");
    if ( i % 11 == 0 ) {
        output.Clear();
        output.Add("Bong");
    }
    if ( i % 13 == 0 ) {
        int firstBIndex = output.FindIndex( item => item.Substring(0,1) == "B");
        if (firstBIndex == -1) {
            output.Add("Fezz");
        }
        else {
            output.Insert(firstBIndex , "Fezz");
        }
    }
    if ( i % 17 == 0 ) {
        output.Reverse();
    }

    if (output.Count == 0)
    { 
        Console.WriteLine(i);
    }
    else
    {
        Console.WriteLine(string.Join("",output));
    }
    
}