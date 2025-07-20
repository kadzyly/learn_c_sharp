


enum DayTime
{
    Morning,
    Afternoon,
    Evening,
    Night
}

const DayTime dayTime = DayTime.Morning;

switch (dayTime)
{
    case DayTime.Morning:
        Console.WriteLine("Доброе утро");
        break;
    case DayTime.Afternoon:
        Console.WriteLine("Добрый день");
        break;
    case DayTime.Evening:
        Console.WriteLine("Добрый вечер");
        break;
    case DayTime.Night:
        Console.WriteLine("Доброй ночи");
        break;
}

enum DayTime
{
    Morning = 1,
    Afternoon = Morning,
    Evening = 2,
    Night = 2
}


enum DayTime
{
    Morning = 3,    // 3
    Afternoon,      // 4 (because 3 + 1)
    Evening,        // 5
    Night           // 6
}