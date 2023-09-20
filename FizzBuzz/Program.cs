using System.Collections;

public class FizzBuzzer : IEnumerable
{
    private string[] _values;

    public FizzBuzzer(int maximum)
    {
        _values = new string[maximum];

        for (int i=1; i < maximum+1; i++)
        {
            List<string> valueToAdd = new List<string>();
        if ( i % 3 == 0 ) valueToAdd.Add("Fizz");
        if ( i % 5 == 0 ) valueToAdd.Add("Buzz");
        if ( i % 7 == 0 ) valueToAdd.Add("Bang");
        if ( i % 11 == 0 ) {
            valueToAdd.Clear();
            valueToAdd.Add("Bong");
        }
        if ( i % 13 == 0 ) {
            int firstBIndex = valueToAdd.FindIndex( item => item.Substring(0,1) == "B");
            if (firstBIndex == -1) {
                valueToAdd.Add("Fezz");
            }
            else {
                valueToAdd.Insert(firstBIndex , "Fezz");
            }
        }
        if ( i % 17 == 0 ) {
            valueToAdd.Reverse();
        }

        if (valueToAdd.Count == 0)
        { 
             _values[i-1] = Convert.ToString(i);
        }
        else
        {
            _values[i-1] = string.Join("",valueToAdd);
        }
           
        }
    }

    IEnumerator IEnumerable.GetEnumerator()
    {
       return (IEnumerator) GetEnumerator();
    }

    public ValueEnum GetEnumerator()
    {
        return new ValueEnum(_values);
    }
}

public class ValueEnum : IEnumerator
{
    public string[] _values;

    int position = -1;

    public ValueEnum(string[] list)
    {
        _values = list;
    }

    public bool MoveNext()
    {
        position++;
        return (position < _values.Length);
    }

    public void Reset()
    {
        position = -1;
    }

    object IEnumerator.Current
    {
        get
        {
            return Current;
        }
    }

    public string Current
    {
        get
        {
            try
            {
                return _values[position];
            }
            catch (IndexOutOfRangeException)
            {
                throw new InvalidOperationException();
            }
        }
    } 
}


class App
{
    static void Main()
    {
        var fizzBuzzer = new FizzBuzzer(100);

        foreach (string value in fizzBuzzer)
        {
            Console.WriteLine(value);
        }

    }
}
