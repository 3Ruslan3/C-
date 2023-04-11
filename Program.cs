// Напишите программу, которая на вход принимает два числа и проверяет, является ли первое число квадратом второго.
// a = 25, b = 5 -> да 
// a = 2, b = 10 -> нет 
// a = 9, b = -3 -> да 
// a = -3 b = 9 -> нет

// Console.WriteLine("Введите число 1");
// int number1=Convert.ToInt32(Console.ReadLine());
// Console.WriteLine("Введите число 2");
// int number2=Convert.ToInt32(Console.ReadLine());

// if(number1 == number2*number2){
//     Console.WriteLine("Число 1 является квадратом числа 2");
// }
// else{
//     Console.WriteLine("Число 1 не является квадратом числа 2");
// }

// Console.Write("Квадрат числа равен: ");
// Console.WriteLine(number1);

// Напишите программу, которая будет выдавать название дня недели по заданному номеру.
// 	3 -> Среда 
// 5 -> Пятница

// Console.WriteLine("Введите число день недели ");
// int number1=Convert.ToInt32(Console.ReadLine());

// if(number1 == 1){
//     Console.WriteLine("Понедельник");
// }
// else if(number1 == 2){
//     Console.WriteLine("Вторник");
// }
// else if(number1 == 3){
//     Console.WriteLine("Среда");
// }
// else if(number1 == 4){
//     Console.WriteLine("Четверг");
// }
// else if(number1 == 5){
//     Console.WriteLine("Пятница");
// }
// else if(number1 == 6){
//     Console.WriteLine("Суббота");
// }
// else if(number1 == 7){
//     Console.WriteLine("Воскресенье");
// }
// else{
//     Console.Write("Такого дня недели нет");    
// }


// Напишите программу, которая на вход принимает одно число (N), а на выходе показывает все целые числа в промежутке от -N до N.
// 4 -> "-4, -3, -2, -1, 0, 1, 2, 3, 4" 
// 2 -> " -2, -1, 0, 1, 2"


// Console.WriteLine("Введите число");
// int number=Convert.ToInt32(Console.ReadLine());
// int antiNumber =- number;

// while(number >= antiNumber){
//     Console.WriteLine(antiNumber);
//     antiNumber=antiNumber+1;
// }






// Напишите программу, которая на вход принимает одно число
// //  (N), а на выходе показывает все целые числа в промежутке от -N до N.
// // 4 -> "-4, -3, -2, -1, 0, 1, 2, 3, 4" 
// // 2 -> " -2, -1, 0, 1, 2"

// Console.WriteLine ("Введите первое число");
// int number = Convert.ToInt32(Console.ReadLine());

// int negNumber=-number;

// while(number>=negNumber)
// {
//     Console.WriteLine(negNumber);
//     negNumber++;
// }






// //Напишите программу, которая принимает на вход трёхзначное число и на выходе показывает последнюю цифру этого числа.	456 -> 6	782 -> 2	918 -> 8

// Console.WriteLine("Введите число");
// int number = Convert.ToInt32(Console.ReadLine());
// int result = number % 10;
// Console.WriteLine(result);






// Console.WriteLine("Введите число 1");
// int number1=Convert.ToInt32(Console.ReadLine());
// Console.WriteLine("Введите число 2");
// int number2=Convert.ToInt32(Console.ReadLine());
// int max = 0;

// if(number1 > number2){
//     max = number1;
// }
// else{
//     max = number2;
// }

// Console.Write("max = ");
// Console.WriteLine(max);







// Console.WriteLine("Введите число 1");
// int number1=Convert.ToInt32(Console.ReadLine());
// Console.WriteLine("Введите число 2");
// int number2=Convert.ToInt32(Console.ReadLine());
// Console.WriteLine("Введите число 3");
// int number3=Convert.ToInt32(Console.ReadLine());
// int max = 0;

// if(number1 > number2){
//     max = number1;
//     if(number1 > number3){
//         max = number1;
//     }
//     else{
//         max = number3;
//     }
// }
// else if(number2 > number1){
//     max = number2;
//     if(number2 > number3){
//         max = number2;
//     }
//     else{
//         max = number3;
//     }
// }

// Console.Write("max = ");
// Console.WriteLine(max);







// Console.WriteLine("Введите число 1");
// int number1=Convert.ToInt32(Console.ReadLine());
// if (number1 % 2 == 0){
//     Console.WriteLine("Число чётное");
// }
// else{
//     Console.WriteLine("Число нечётное");
// }






Console.WriteLine ("Введите число");
int number = Convert.ToInt32(Console.ReadLine());

int currentNumber = 1;

while(currentNumber<=number)
{
    if(currentNumber % 2 == 0)
    Console.WriteLine(currentNumber);
    currentNumber++;
}