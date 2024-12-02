// подходящее число или ошибка. дни недели
System.Console.WriteLine("Введите число: ");
int day = Convert.ToInt32(Console.ReadLine());

if (day > 7)
{
    System.Console.WriteLine("Введённое число слишком большое");
}

if (day < 1)
{
    System.Console.WriteLine("Введённое число слишком маленькое");
}

if (day == 1)
{
    System.Console.WriteLine("Понедельник");
}

if (day == 2)
{
    System.Console.WriteLine("Вторник");
}
if (day == 3)
{
    System.Console.WriteLine("Среда");
}
if (day == 4)
{
    System.Console.WriteLine("Четверг");
}
if (day == 5)
{
    System.Console.WriteLine("Пятница");
}
if (day == 6)
{
    System.Console.WriteLine("Суббота");
}
if (day == 7)
{
    System.Console.WriteLine("Воскресенье");
}


