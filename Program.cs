


// Задача 10: Напишите программу, которая принимает на вход трёхзначное число 
// и на выходе показывает вторую цифру этого числа.


// void NumberTwo (int n) 
// {
//     if (99 < n && n < 1000)
//     {
//         int a = n/ 10 % 10;
//         Console.WriteLine(a);
//     }     
    
//     else Console.WriteLine("Ведите число от 100 до 999");

// }
//     Console.WriteLine("Ведите трёхзначное число");
//     int num = Convert.ToInt32(Console.ReadLine());
//     NumberTwo(num); 




// Задача 13: Напишите программу, которая выводит третью цифру заданного числа
//  или сообщает, что третьей цифры нет.

// void NumberThree(int n){    
    
//     if (n>999){
//     do
// {
//     n = n / 10;
// } 
//     while (n > 999);
//     Console.Write(n % 10);
//     }
//     else if (99 < n && n < 1000) 
//         Console.Write(n % 10);

//     else Console.WriteLine("Третьего числа нет");
// }

//     Console.WriteLine("Ведите число");
//     int num = Convert.ToInt32(Console.ReadLine());
//     NumberThree(num);
    


// Задача 15: Напишите программу, которая принимает на вход цифру, обозначающую 
// день недели, и проверяет, является ли этот день выходным.

// void Weekends(int a){
      
//     if (a == 6 || a == 7) 
//     Console.WriteLine("day off");

//     else if (1 <= a && a <= 5)
//     Console.WriteLine("working");

//     else Console.WriteLine("День недели не существует");
// }

// Console.WriteLine("Введите число");
// int a = Convert.ToInt32(Console.ReadLine());
// Weekends(a);