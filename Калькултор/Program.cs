
Console.WriteLine("Калькулятор");
string start = "0";
while (start != "9")
{
    Console.WriteLine("Выберите действие:\n1 - Сложить 2 числа\n2 - Вычесть первое из второго\n3 - Перемножить два числа\n4 - Разделить первое на второе\n5 - Возвести в степень N первое ь из числа\n7 - Найти 1 процент от числа\n8 - Найти факториал из числа\n6 - Найти квадратный коренз числа\n9 - Выйти из программы");
    string nachalo = Console.ReadLine();
    if (nachalo == "1")
    {
        Console.WriteLine("Введите число: ");
        string first = Console.ReadLine();
        Console.WriteLine("Введите второе число: ");
        string second = Console.ReadLine();
        float firstn = Convert.ToSingle(first);
        float secondn = Convert.ToSingle(second);
        Console.WriteLine(firstn + secondn);
        

    }
    if (nachalo =="2")
    {
        Console.WriteLine("Введите число: ");
        string first = Console.ReadLine();
        Console.WriteLine("Введите второе число: ");
        string second = Console.ReadLine();
        float firstn = Convert.ToSingle(first);
        float secondn = Convert.ToSingle(second);
        Console.WriteLine(firstn - secondn);
       
    }
    if (nachalo == "3")
    {
        Console.WriteLine("Введите число: ");
        string first = Console.ReadLine();
        Console.WriteLine("Введите второе число: ");
        string second = Console.ReadLine();
        float firstn = Convert.ToSingle(first);
        float secondn = Convert.ToSingle(second);
        Console.WriteLine(firstn * secondn);
       
    }
 if (nachalo== "4")
    {
        Console.WriteLine("Введите число: ");
        string first = Console.ReadLine();
        Console.WriteLine("Введите второе число: ");
        string second = Console.ReadLine();
        float firstn = Convert.ToSingle(first);
        float secondn = Convert.ToSingle(second);
        Console.WriteLine(firstn / secondn);
       
    }
 if (nachalo =="5")
    {
        Console.WriteLine("Введите число: ");
        string first = Console.ReadLine();
        Console.WriteLine("Введите второе число: ");
        string second = Console.ReadLine();
        float firstn = Convert.ToSingle(first);
        float secondn = Convert.ToSingle(second);
        float N = firstn;
        for (int i = 0; i< secondn - 1; i++){
            firstn *= N;
        }
        Console.WriteLine(firstn);
       
    } 
 if (nachalo=="6")
    {
        Console.Write("Введите число: ");
        string first = Console.ReadLine();
        float firstn=Convert.ToSingle(first);
        Console.WriteLine(Math.Sqrt(firstn));
        
    }
 if (nachalo == "7"){
        Console.Write("Введите число: ");
        string first=Console.ReadLine();
        float firstn = Convert.ToSingle(first);
        Console.WriteLine(firstn * 0.01);
        
    }
 if (nachalo == "8")
    {
        Console.Write("Введите число: ");
        string first = Console.ReadLine();
        int firstn = Convert.ToInt32(first);
        int N = 1;
        for (int i=1; i<firstn +1; i++)
        {
            N=i* N;
        }
        Console.WriteLine(N);
        
    }
    if (nachalo != "1" && nachalo != "2" && nachalo != "3" && nachalo != "4" && nachalo != "5" && nachalo != "6" && nachalo != "7" && nachalo != "8")
    {
        break;
    }
}
