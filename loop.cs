

// for 

for (int i = 1; i < 4; i++)
{
    Console.WriteLine(i);
}


for (int i = 1, j = 1; i < 10; i++, j++)
{
    Console.WriteLine($"{i * j}");
}


// do..while
int i = 6;
do
{
    Console.WriteLine(i);
    i--;
}
while (i > 0);


// while
int i = 6;
while (i > 0)
{
    Console.WriteLine(i);
    i--;
}

// foreach
foreach(char c in "Tom")
{
    Console.WriteLine(c);
}

int[] numbers = { 1, 2, 3, 4, 5 };
for (int i = 0; i < numbers.Length; i++)
{
    Console.WriteLine(numbers[i]);
}

// -------------------


//  continue and break
for (int i = 0; i < 9; i++)
{
    if (i == 5)
        break;
    Console.WriteLine(i);
}


for (int i = 0; i < 9; i++)
{
    if (i == 5)
        continue;
    Console.WriteLine(i);
}