int n = Convert.ToInt32(Console.ReadLine());
if(n % 7 == 0)
{
    if(n % 23 == 0)
        Console.WriteLine("кратно");
    else
        Console.WriteLine("кратно 7, но не кратно 23");
}
else
{
    Console.WriteLine("не кратно");
}

