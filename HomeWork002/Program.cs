Console.Write("Введите первое число ");
int numberOne = Convert.ToInt32(Console.ReadLine());
Console.Write("Ввидите второе число ");
int numberTwo = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите третье число ");
int numberThree = Convert.ToInt32(Console.ReadLine());
int max = numberOne;
if ( max > numberTwo )
    if (max > numberThree)
    Console.WriteLine("Число " + max + " максимальное");
    else 
    Console.WriteLine("Число " + numberThree + " максимальное");
else 
    if (numberTwo > numberThree)
    {
    Console.WriteLine("Число " + numberTwo + " максимальное");
    }
    else
    Console.WriteLine("Число " + numberThree + " максимальное");

