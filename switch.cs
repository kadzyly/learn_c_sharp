


string name = "Tom";
 
switch (name)
{
    case "Bob":
        Console.WriteLine("Your name - Bob");
        break;
    case "Tom":
        Console.WriteLine("Your name - Tom");
        break;
    case "Sam":
        Console.WriteLine("Your name - Sam");
        break;
    default:
        Console.WriteLine("default");
        break;
}



int DoOperation(int op, int a, int b)
{
    switch (op)
    {
        case 1: return a + b;
        case 2: return a - b;
        case 3: return a * b;
        default: return 0;
    }
}

int DoOperation(int op, int a, int b)
{
    int result = op switch {
        1 => a + b,
        2 => a - b,
        3 => a * b,
        _ => 0
    };
    return result;
}

int DoOperation(int op, int a, int b)
{
    return op switch
    {
        1 => a + b,
        2 => a - b,
        3 => a * b
    };
}