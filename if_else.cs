

int num1 = 8;
int num2 = 6;

// if () {} ... else if () {} ... else {}
if(num1 > num2)
    {
        Console.WriteLine($"{num1} is bigger than {num2}");
    }
else if (num1 < num2)
    {
        Console.WriteLine($"{num1} is smoller than {num2}");
    }
else
    {
        Console.WriteLine("num1 = num2");
    }
    

// ternary operator
int x = 3;
int y = 2;
 
int z = x < y ? (x + y) : (x - y);
Console.WriteLine(z);   // 1