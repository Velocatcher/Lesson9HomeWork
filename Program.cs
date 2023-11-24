// Задача 64: Задайте значения M и N. Напишите программу, которая выведет все натуральные числа в промежутке от M до N.
// M = 1; N = 5. -> "1, 2, 3, 4, 5"
// M = 4; N = 8. -> "4, 6, 7, 8"

// Console.Write("Введите число M: ");
// int M = Convert.ToInt32(Console.ReadLine());

// Console.Write("Введите число N: ");
// int N = Convert.ToInt32(Console.ReadLine());


// string PrintNumbers (int start, int end)
// {
//     // Базовый случай
//     if (start == end) return start.ToString();
//     if (start <= 0 && end <= 0)
//     {
//        Console.WriteLine ("Числа M и N должны быть больше 0");
//         return (start.ToString() + " и " + end.ToString() + " < 0  - НЕДОПУСТИМО!");
         
//     }

//     if (start > end) 
//     {
//         Console.WriteLine ("Число M должно быть меньше чем N");
//         return (start.ToString() + " > " + end.ToString() + " - НЕДОПУСТИМО!");
        
//     }
    
//     if (start <= 0 && end > 0)
//     {
//        start =1;  
//     } 
    
//     // Рекурсивный случай
    
//     return (start + ", " + PrintNumbers(start + 1, end));
// }

// Console.WriteLine($"\"" +  PrintNumbers(M, N)+ "\"");


// Задача 66: Задайте значения M и N. Напишите программу, которая найдёт сумму натуральных элементов в промежутке от M до N.
// M = 1; N = 15 -> 120
// M = 4; N = 8. -> 30


// Console.Write("Введите число M: ");
// int M = Convert.ToInt32(Console.ReadLine());

// Console.Write("Введите число N: ");
// int N = Convert.ToInt32(Console.ReadLine());


// string PrintNumbers (int start, int end)
// {
//     // Базовый случай
//     if (start == end) return start.ToString();
//     if (start <= 0 && end <= 0)
//     {
//        Console.WriteLine ("Числа M и N должны быть больше 0");
//         return (start.ToString() + " и " + end.ToString() + " < 0  - НЕДОПУСТИМО!");
         
//     }

//     if (start > end) 
//     {
//         Console.WriteLine ("Число M должно быть меньше чем N");
//         return (start.ToString() + " > " + end.ToString() + " - НЕДОПУСТИМО!");
        
//     }
    
//     if (start <= 0 && end > 0)
//     {
//        start =1;  
//     } 
    
//     // Рекурсивный случай
//     int summ = start + Convert.ToInt32(PrintNumbers(start + 1, end));
//     return summ.ToString();
    
// }

// Console.WriteLine(PrintNumbers(M, N));


// Задача 68: Напишите программу вычисления функции Аккермана с помощью рекурсии. Даны два неотрицательных числа m и n.
// m = 2, n = 3 -> A(m,n) = 9

int AkkerMan(int m, int n)
{
    if (m == 0)
        return n + 1;
    else
      if ((m != 0) && (n == 0))
        return AkkerMan (m - 1, 1);
    else
        return AkkerMan(m - 1, AkkerMan(m, n - 1));
}

Console.WriteLine(AkkerMan(2, 3)); // 9

Console.WriteLine(AkkerMan(3, 2)); // 29
