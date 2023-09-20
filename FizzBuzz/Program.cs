for (int i = 1; i< 21; i++)
{
    string output = "";
    if (i % 3 == 0) output = output + "Fizz";
    if (i % 5 == 0) output = output + "Buzz";
    if (output == "") output = i.ToString();
    Console.WriteLine(output);
}