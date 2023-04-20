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






// Console.WriteLine ("Введите число");
// int number = Convert.ToInt32(Console.ReadLine());

// int currentNumber = 1;

// while(currentNumber<=number)
// {
//     if(currentNumber % 2 == 0)
//     Console.WriteLine(currentNumber);
//     currentNumber++;
// }






//Семинар 2
// Напишите программу, которая выводит случайное число из отрезка [10, 99] и показывает наибольшую цифру числа.

// Например:
// 78 -> 8
// 12-> 2
// 85 -> 8

// Напишите программу, которая выводит случайное число 
// из отрезка [10, 99] и показывает наибольшую цифру числа.

// Например:
// 78 -> 8
// 12-> 2
// 85 -> 8

// int num =new Random().Next(10,100); 
// Console.WriteLine(num);

// int a = num /10;
// int b = num%10;

// if(a>b)
// {
//     Console.WriteLine(a);

// }
// else if(a<b)
// {
//     Console.WriteLine(b);
// }
// else
// {
//     Console.WriteLine("Числа равны");
// }












// // Напишите программу, которая выводит случайное трехзначное число и удаляет вторую цифру этого числа.

// // 456 -> 46
// // 782 -> 72
// // 918 -> 98
// int num =new Random().Next(100,1000); 
// Console.WriteLine(num);

// int a = num / 100;
// int b = num % 10;
// // int c = (num % 100) / 10;

// Console.WriteLine("Итоговое число " + a + b);
// // Console.WriteLine($"Итоговое число {a}{b}");
// // Console.WriteLine($"Итоговое число {c}");








// Console.WriteLine ("Введите число 1");
// int number1 = Convert.ToInt32(Console.ReadLine());
// Console.WriteLine ("Введите число 2");
// int number2 = Convert.ToInt32(Console.ReadLine());

// int result = number1 % number2;

// if( result == 0){
//     Console.WriteLine ("Число 2 кратно числу 1");
// }
// else{
//     Console.WriteLine ("Число 2 не кратно числу 1 отстаток " + result);
// }








// Напишите программу, которая принимает на вход число и проверяет, кратно ли оно одновременно 
// 7 и 23.

// 14 -> нет 
// 46 -> нет 
// 161 -> да

// Console.WriteLine("Введите число");
// int num = Convert.ToInt32(Console.ReadLine());
// if (num % 7 == 0 && num % 23 == 0)
// {
//     Console.WriteLine("ДА");    
// }
// else
// {
// Console.WriteLine("НЕТ");
// }






// Console.WriteLine("Введите 1 число");
// int num1 = Convert.ToInt32(Console.ReadLine());
// Console.WriteLine("Введите 2 число");
// int num2 = Convert.ToInt32(Console.ReadLine());

// if (num2 == num1*num1)
// {
//     Console.WriteLine("Число 2 является квадратом числа 1");
// }
// else if (num1 == num2*num2)
// {
//     Console.WriteLine("Число 1 является квадратом числа 2");
// }
// else
// {
//     Console.WriteLine("Числа несовместимы");
// }








// // Задача 10: Напишите программу, которая принимает на вход трёхзначное число и на выходе показывает вторую цифру этого числа.

// // 456 -> 5
// // 782 -> 8
// // 918 -> 1

// int num =new Random().Next(100,1000); 
// Console.WriteLine(num);

// int a = num / 100;
// int b = (num % 100) / 10;
// int c = num % 10;

// Console.WriteLine($"Итоговое число {b}");










// Задача 13: Напишите программу, которая выводит третью цифру заданного числа или сообщает, что третьей цифры нет.
// 645 -> 5
// 78 -> третьей цифры нет
// 32679 -> 6


// Console.WriteLine("Введите число");
// int num = Convert.ToInt32(Console.ReadLine());
// string textNum = num.ToString();

// if (textNum.Length < 3){
//     Console.WriteLine("Нет третьего число");
// }
// else{
//     int[] array = new int[textNum.Length];
//     Console.WriteLine(textNum.Length);
//     int i = textNum.Length - 1;
//     while (i >= 0){
//         array[i] = num % 10;
//         num = num / 10;
//         Console.WriteLine("i = " + i + " array[i] " + array[i]);
//         i--;
//     }
//     Console.WriteLine("Третья цифра = " + array[2]);
// }







// Задача 15: Напишите программу, которая принимает на вход цифру, обозначающую день недели, и проверяет, является ли этот день выходным.

// 6 -> да
// 7 -> да
// 1 -> нет

// Console.WriteLine("Введите число");
// int num = Convert.ToInt32(Console.ReadLine());

// if ((num < 1) || (num > 7)){
//     Console.WriteLine("Некорректное значение");
// }
// else{
//     if ((num == 6) || (num == 7)){
//         Console.WriteLine("Это выходной день");
//     }
//     else{
//         Console.WriteLine("Не выходной день");
//     }
// }








// 17. Напишите программу, которая принимает на вход 
// координаты точки (X и Y), причём X ≠ 0 и Y ≠ 0 и
//  выдаёт номер четверти плоскости, в которой находится эта точка.

// Console.WriteLine("Введите число ");
//  int X = Convert.ToInt32(Console.ReadLine());
//  Console.WriteLine("Введите число ");
//  int Y = Convert.ToInt32(Console.ReadLine());

//  if (X>0 &&Y>0)
//  {
//     Console.WriteLine("1 четверть ");
//  }

//  else if(X<0 &&Y>0)
//  {
//     Console.WriteLine("2 четверть ");
//  }

// else if(X<0 &&Y<0)
//  {
//     Console.WriteLine("3 четверть ");
//  }
//  else if(X>0 &&Y<0)
//  {
//     Console.WriteLine("4 четверть ");
//  }
//  else
//  {
//     Console.WriteLine("Точка находитя на одной или двух осях координат ");
//  }



// // Задача 18: Напишите программу, которая по заданному номеру четверти, показывает диапазон возможных координат точек в этой четверти (x и y).

// Console.WriteLine("Введите число ");
//  int input = Convert.ToInt32(Console.ReadLine());

//  if (input == 1){
//     Console.WriteLine("1 четверть ");
//     Console.WriteLine("X>0 && Y>0");
//  }
//  else if (input == 2){
//     Console.WriteLine("2 четверть ");
//     Console.WriteLine("X<0 && Y>0");
//  }
//   else if (input == 3){
//     Console.WriteLine("3 четверть ");
//     Console.WriteLine("X<0 && Y<0");
//  }
//   else if (input == 4){
//     Console.WriteLine("4 четверть ");
//     Console.WriteLine("X>0 && Y<0");
//  }
//  else {
//     Console.WriteLine("Неверный ввод");
//  }








// // 17. Напишите программу, которая принимает на вход 
// // координаты точки (X и Y), причём X ≠ 0 и Y ≠ 0 и
// //  выдаёт номер четверти плоскости, в которой находится эта точка.

// Console.WriteLine("Введите число ");
//  int num = Convert.ToInt32(Console.ReadLine());

// switch(num)
// {
//     case 1:
//     {
//         Console.WriteLine("X>0 Y>0");
//         break;
//     }
//     case 2:
//     {
//         Console.WriteLine("X<0 Y>0");
//         break;
//     }
//     case 3:
//     {
//         Console.WriteLine("X<0 Y<0");
//         break;
//     }
//     case 4:
//     {
//         Console.WriteLine("X>0 Y<0");
//         break;
//     }
//     default:
//     {
//         Console.WriteLine("Такой четверти нет");
//         break;
//     }
// }











// Задача 21: Напишите программу, которая принимает на вход координаты двух точек и находит расстояние между ними в 2D пространстве.
// A (3,6); B (2,1) -> 5,09 
// A (7,-5); B (1,-1) -> 7,21


// Задача 21: Напишите программу, которая принимает на 
// вход координаты двух точек и находит расстояние между
//  ними в 2D пространстве.

// Console.WriteLine("Введите число ");
//  int X1 = Convert.ToInt32(Console.ReadLine());
// Console.WriteLine("Введите число ");
//  int X2 = Convert.ToInt32(Console.ReadLine());

// Console.WriteLine("Введите число ");
//  int Y1 = Convert.ToInt32(Console.ReadLine());
// Console.WriteLine("Введите число ");
//  int Y2 = Convert.ToInt32(Console.ReadLine());

// double d=Math.Sqrt(Math.Pow((X2-X1),2)+Math.Pow((Y2-Y1),2));
// Console.WriteLine(d);





// Задача 22: Напишите программу, которая принимает на вход число (N) и выдаёт таблицу квадратов чисел от 1 до N.
// 5 -> 1, 4, 9, 16, 25.
// 2 -> 1,4

// Задача 22: Напишите программу, которая принимает 
// на вход число (N) и выдаёт таблицу квадратов чисел от 1 до N.

// Console.WriteLine("Введите число ");
//  int num = Convert.ToInt32(Console.ReadLine());

//  for (int i=1; i<=num; i++)
//  {
//     Console.WriteLine(Math.Pow(i,2));
//  }






// // Задача 13: Напишите программу, которая выводит третью цифру заданного числа или сообщает, что третьей цифры нет.
// // 645 -> 5
// // 78 -> третьей цифры нет
// // 32679 -> 6

// Console.Write("Введите число: ");
// int num = Convert.ToInt32((Console.ReadLine()));

// if (num < 100)
// {
//     Console.WriteLine($"Третьей цифры нет");
// }
// else
// {
//     while(num>999)
//     {  
//       num/=10;
//     }
//      Console.WriteLine(num%10);
// }






// Console.Write("Введите число: ");
// int num = Convert.ToInt32((Console.ReadLine()));

// // int num = new Random().Next(10000,100000); 
// // Console.WriteLine(num);

// int lastNam1 = num % 10;
// Console.WriteLine(lastNam1);
// int lastNam2 = (num / 10) % 10;
// Console.WriteLine(lastNam2);
// int firstNam2 = (num / 1000) % 10;
// Console.WriteLine(firstNam2);
// int firstNam1 = num / 10000;
// Console.WriteLine(firstNam1);

// if ((lastNam1 == firstNam1) && (lastNam2 == firstNam2)){
//     Console.WriteLine("Число является полиндромом");
// }
// else{
//     Console.WriteLine("Число НЕ является полиндромом");
// }









// // Напишите программу, которая принимает на вход координаты двух точек и находит расстояние между ними в 3D пространстве.
// // A (3,6,8); B (2,1,-7), -> 15.84
// // A (7,-5, 0); B (1,-1,9) -> 11.53

//  int X1 = 7;
//  int Y1 = -5;
//  int Z1 = 0;

//  int X2 = 1;
//  int Y2 = -1;
//  int Z2 = 9;

// double d=Math.Sqrt(Math.Pow((X2-X1),2)+Math.Pow((Y2-Y1),2)+Math.Pow((Z2-Z1),2));
// Console.WriteLine(d);




// Задача 23
// Напишите программу, которая принимает на вход число (N) и выдаёт таблицу кубов чисел от 1 до N.
// 3 -> 1, 8, 27
// 5 -> 1, 8, 27, 64, 125

// Console.Write("Введите число: ");
// int num = Convert.ToInt32((Console.ReadLine()));

// for(int i = 1; i <= num; i++){
//     Console.WriteLine(Math.Pow(i, 3));
// }

// int[] numArr = new int[8];

// for(int i=0;i<numArr.Length;i++){
//     numArr[i] = new Random().Next(0,2);
//     Console.Write(numArr[i]+",");
// }











// Демонстрация решения
// Задача 24: Напишите программу, которая принимает на вход число (А) и выдаёт сумму чисел от 1 до А.
// 7 -> 28
// 4 -> 10
// 8 -> 36


// Демонстрация решения
// Задача 24: Напишите программу, которая принимает
//  на вход число (А) и выдаёт сумму чисел от 1 до А.
// 7 -> 28
// 4 -> 10
// 8 -> 36


// Console.WriteLine("Введите число");                         
// int number = Convert.ToInt32(Console.ReadLine());   

// int GetSumNum()
// {
//     int sum =0;
//     int count =0;

//    while (number>count)
//    {
//     count++;
//     sum+=count;
//     // sum= sum+count;
//    }

//     return sum;
// }

//  Console.WriteLine(GetSumNum());








//  Задача 26: Напишите программу, которая принимает на вход число и выдаёт количество цифр в числе.
// 456 -> 3
// 78 -> 2
// 89126 -> 5



// int countDigits(int a){    int count = 0;    while (a > 0)    {        a /= 10;        count++;    }    return count;}Console.Write("Введите число: ");int n = Convert.ToInt32(Console.ReadLine());Console.WriteLine($"Количество цифр в числе {countDigits(n)}");


// Console.WriteLine("Введите число: ");
// int value = Convert.ToInt32(Console.ReadLine());
// int count = 0;

// while(value != 0)
// {
//     count++;
//     value = value / 10;
// }
// Console.WriteLine(count);







// Console.Write("Введите число: ");
// int number = Convert.ToInt32(Console.ReadLine());
// int getNumCount(){
//     return number.ToString().Length;
// }
// Console.WriteLine("Количество цифр в числе: " + getNumCount());








// Задача 28: Напишите программу, которая принимает на вход число N и выдаёт произведение чисел от 1 до N.
// 4 -> 24 
// 5 -> 120


// Console.WriteLine("Введите целое число");
// int num = Convert.ToInt32(Console.ReadLine());
// int temp = 1;

// for (int i = 1; i<=num; i++)
// {
//     temp=temp*i;
// }
// Console.WriteLine(temp);











// Задача 30: Напишите программу, которая выводит массив из 8 элементов, заполненный нулями и единицами в случайном порядке.
// [1,0,1,1,0,1,0,0]












// // Задача 25: Напишите цикл, который принимает на вход два числа (A и B) и возводит число A в натуральную степень B.
// // 3, 5 -> 243 (3⁵)
// // 2, 4 -> 16

// Console.WriteLine("Введите целое число A");
// int numA = Convert.ToInt32(Console.ReadLine());
// Console.WriteLine("Введите целое число B");
// int numB = Convert.ToInt32(Console.ReadLine());

// int temp = 0;

// int increseNumberLevel()
// {
//     temp = numA;
//     for(int i = 2; i <= numB; i++){
//         temp = temp*numA;
//         // Console.WriteLine("temp = " + temp);
//     }
//     return temp;
// }
// increseNumberLevel();
// Console.WriteLine(temp);

// // double temp2 = Math.Pow(numA, numB); //Проверка
// // Console.WriteLine(temp2);//Проверка












// // Задача 27: Напишите программу, которая принимает на вход число и выдаёт сумму цифр в числе.
// // 452 -> 11
// // 82 -> 10
// // 9012 -> 12

// Console.WriteLine("Введите целое число");
// int num = Convert.ToInt32(Console.ReadLine());
// int sum = 0;
// int temp = 0;

// int GetSumNum(){
//     while(num != 0){
//         temp = num % 10;
//         num = num / 10;
//         sum = sum + temp;
//     }
//     return sum;
// }
// GetSumNum();
// Console.WriteLine(sum);







// Задача 29: Напишите программу, которая задаёт массив из 8 элементов и выводит их на экран.
// 1, 2, 5, 7, 19 -> [1, 2, 5, 7, 19]
// 6, 1, 33 -> [6, 1, 33]

// int[] array = new int[8];

// int[] fillArrayWithNumbers(){
//     for(int i = 0; i < array.Length; i++){
//         Console.WriteLine("Введите целое число как элемен массива с индексом " + i);
//         array[i] = Convert.ToInt32(Console.ReadLine());
//     }
//     return array;
// }

// void printArray(int[] a){
//     for(int i = 0; i < a.Length; i++){
//         Console.Write(a[i] + " ");
//     }
// }

// fillArrayWithNumbers();
// printArray(array);











// // Задача 29: Напишите программу, которая задаёт массив из 8 элементов и выводит их на экран.
// // 1, 2, 5, 7, 19 -> [1, 2, 5, 7, 19]
// // 6, 1, 33 -> [6, 1, 33]

// int[] array = new int[8];

// int[] fillArrayWithNumbers(){
//     for(int i = 0; i < array.Length; i++){
//         array[i] = new Random().Next(1, 100);
//     }
//     return array;
// }

// void printArray(int[] a){
//     for(int i = 0; i < a.Length; i++){
//         Console.Write(a[i] + " ");
//     }
// }

// fillArrayWithNumbers();
// printArray(array);







// Задача 29: Напишите программу, которая задаёт массив из 8 элементов и выводит их на экран.
// // 1, 2, 5, 7, 19 -> [1, 2, 5, 7, 19]
// // 6, 1, 33 -> [6, 1, 33]

int[] array = new int[8];

int[] fillArrayWithNumbers(){
    Console.WriteLine("Введите массив из 8 целых чисел, используя как разделитель ',' ");
        string[] str = Console.ReadLine().Split(new char[] {','});

        Console.WriteLine(String.Join(", ", str) + " это массив символов");

        for (int i = 0; i < str.Length; i++){
            array[i] = Convert.ToInt32(str[i]);
        }
    return array;
}

fillArrayWithNumbers();
Console.WriteLine(String.Join(", ", array) + " а это уже массив чисел");