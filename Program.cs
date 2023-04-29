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

// int[] array = new int[8];

// int[] fillArrayWithNumbers(){
//     Console.WriteLine("Введите массив из 8 целых чисел, используя как разделитель ',' ");
//         string[] str = Console.ReadLine().Split(new char[] {','});

//         Console.WriteLine(String.Join(", ", str) + " это массив символов");

//         for (int i = 0; i < str.Length; i++){
//             array[i] = Convert.ToInt32(str[i]);
//         }
//     return array;
// }

// fillArrayWithNumbers();
// Console.WriteLine(String.Join(", ", array) + " а это уже массив чисел");











// Задача 31: Задайте массив из 12 элементов, заполненный
//  случайными числами из промежутка [-9, 9]. 
//  Найдите сумму отрицательных и положительных
//   элементов массива.
// Например, в массиве [3,9,-8,1,0,-7,2,-1,8,-3,-1,6]
//  сумма положительных чисел равна 29, сумма отрицательных
//   равна -20.

// int[] numArr = new int[12];

// int positiveNum=0;
// int negNum=0;

// for(int i=0;i<numArr.Length;i++)
// {
//     numArr[i] = new Random().Next(-9,10);

//     if(numArr[i]>0)
//     {
//         positiveNum+=numArr[i];
//     }
//     else
//     {
//         negNum+=numArr[i];
//     }
// }

// Console.WriteLine(String.Join(",",numArr)+
// "\nСумма положительных "+positiveNum+" отрицательных "+negNum);









// Задача 32: Напишите программу замена элементов массива: положительные элементы замените на соответствующие отрицательные, и наоборот.
// [-4, -8, 8, 2] -> [4, 8, -8, -2]

// int[] numArr = new int[] {1,7898,66,-6,-52,0};

// Console.WriteLine(String.Join(",",numArr));

// for(int i=0;i<numArr.Length;i++)
// {
//     numArr[i]=-numArr[i];
// }

// Console.WriteLine(String.Join(",",numArr));









// Задача 33: Задайте массив. Напишите программу, которая определяет, 
// присутствует ли заданное число в массиве.
// 4; массив [6, 7, 19, 345, 3] -> нет
// -3; массив [6, 7, 19, 345, 3] -> да

// Console.WriteLine("Ведите число");
// int nom = Convert.ToInt32(Console.ReadLine());

// int[] numArr = new int[] { 1, 7898, 66, -6, -52, 0 };

// Console.WriteLine(String.Join(",", numArr));

// bool flag = false;

// for (int i = 0; i < numArr.Length; i++)
// {
//     if (numArr[i] == nom)
//     {
//         flag = true;
//         break;
//     }
// }
// if (flag == true)
// {
//     Console.WriteLine("Да");
// }
// else
// {
//     Console.WriteLine("Нет");
// }









// Задача 35: Задайте одномерный массив из 123 случайных чисел. Найдите количество элементов массива, значения которых лежат в отрезке [10,99]. 
// Пример для массива из 5, а не 123 элементов. В своём решении сделайте для 123
// [5, 18, 123, 6, 2] -> 1
// [1, 2, 3, 6, 2] -> 0
// [10, 11, 12, 13, 14] -> 5





// Задача 35: Задайте одномерный массив из 123 случайных
//  чисел. Найдите количество элементов массива, 
//  значения которых лежат в отрезке [10,99]. 
// Пример для массива из 5, а не 123 элементов. 
// В своём решении сделайте для 123
// [5, 18, 123, 6, 2] -> 1
// [1, 2, 3, 6, 2] -> 0
// [10, 11, 12, 13, 14] -> 5

// int[] numArr = new int[123];

// int num = 0;

// for (int i = 0; i < numArr.Length; i++)
// {
//     numArr[i] = new Random().Next(0, 501);

//     if ((numArr[i] > 9) && (numArr[i] < 100))
//     {
//         num = num + 1;
//     }
// }

// Console.WriteLine(String.Join(",", numArr));
// Console.WriteLine("Количество двухзначных чисел = " + num);














// Задача 37: Найдите произведение пар чисел в одномерном массиве. Парой считаем первый и последний элемент, второй и предпоследний и т.д. Результат запишите в новом массиве.
// [1 2 3 4 5] -> 5 8 3
// [6 7 3 6] -> 36 21

// int[] numArr = new int[]{2, 5, 7 ,8};


// int[] array1 = new int[] {3,8,2,6,2};
// int[] array2= new int [(array1.Length/2)+ (array1.Length%2)];

// for(int i=0;i<array2.Length;i++)
// {
//     array2[i]=array1[i]*array1[array1.Length-1-i];

//     if (i==array1.Length-1-i)
//     {
//         array2[i]=array1[array1.Length-1-i];
//     }
// }

// Console.WriteLine(String.Join(",",array2));








// int[] arr = new int[5] {3,8,2,6,5}; //первый массив
// int lg = arr.Length;                //задаем переменную для длинны первого массива для простоты формул
// int middle = lg/2 + lg%2;           //узнаем длину второго массива(четный или нет)
// int[] arr2 = new int[middle];       //задаем длину второго массива

// for(int i=0;i<middle;i++)
// {
//     arr2[i]=arr[i]*arr[lg-i-1];  //берем пары элементов(1 и последний, 2й и предпоследний...) и перемножаем

//     if(i==lg-1-i)               //если массив не четный
//     {
//         arr2[i]=arr[lg-1-i];    //то записать центральный элемент в конец второго массива
//     }
// }
// Console.WriteLine(String.Join(",",arr2)); // выводим второй массив через запятую










// // Задача 34: Задайте массив заполненный случайными положительными трёхзначными числами. Напишите программу, которая покажет количество чётных чисел в массиве.
// // [345, 897, 568, 234] -> 2
// int temp = 0;

// int[] array = new int[10];
// for (int i = 0; i < array.Length; i++){
//     array[i] = new Random().Next(100, 1000);
// }
// Console.WriteLine(String.Join(",", array));
// for (int i = 0; i < array.Length; i++){
//     if(array[i] % 2 == 0){
//         temp++;
//     }
// }
// Console.WriteLine("Число чётный чисел = " + temp);








// // Задача 36: Задайте одномерный массив, заполненный случайными числами. Найдите сумму элементов, стоящих на нечётных позициях.
// // [3, 7, 23, 12] -> 19
// // [-4, -6, 89, 6] -> 0

// int[] array = new int[] {-4, -6, 89, 6};
// // for (int i = 0; i < array.Length; i++){
// //     array[i] = new Random().Next(1, 100);
// // }
// Console.WriteLine(String.Join(",", array));

// int sum = 0;

// for (int i = 0; i < array.Length; i++){
//     if (i % 2 > 0){
//         sum = sum + array[i];
//     }
// }
// Console.WriteLine("Сумма нечётных чисел = " + sum);











// // Задача 38: Задайте массив вещественных чисел. Найдите разницу между максимальным и минимальным элементов массива.
// // [3 7 22 2 78] -> 76

// double[] array = new double[] {3, 7, 22, 2, 78};
// double min = 0;
// double max = 0;
// double result = 0;

// min = array[0];
// for(int i = 0; i < array.Length; i++){
//     if(array[i] < min){
//         min = array[i];
//     }
//     if(array[i] > max){
//         max = array[i];
//     }
// }
// result = max - min;
// Console.WriteLine("min = " + min + " max = " + max + "\n" + "Разница между максимальным и минимальным числами = " + result);







// Задача 37: Найдите произведение пар чисел в одномерном массиве. Парой считаем первый и последний элемент, второй и предпоследний и т.д. Результат запишите в новом массиве.
// [1 2 3 4 5] -> 5 8 3
// [6 7 3 6] -> 36 21

// int[] array = new int[] { 1, 2, 3, 4, 5 };
// // int[] array = new int[] { 6, 7, 3, 6 };

// int[] result = new int[(array.Length / 2) + (array.Length % 2)];

// for (int i = 0; i < result.Length; i++)
// {
//     result[i] = array[i] * array[array.Length - 1 - i];
//     if(i == array.Length - 1 - i){
//         result[i] = array[array.Length - 1 - i];
//     }
// }

// Console.WriteLine(String.Join(",", array));
// Console.WriteLine(String.Join(",", result));













// Задача 40: Напишите программу, которая принимает на вход три числа и проверяет, может ли существовать треугольник с сторонами такой длины.

// Console.WriteLine("Ведите число 1");
// int num1 = Convert.ToInt32(Console.ReadLine());
// Console.WriteLine("Ведите число 2");
// int num2 = Convert.ToInt32(Console.ReadLine());
// Console.WriteLine("Ведите число 3");
// int num3 = Convert.ToInt32(Console.ReadLine());

// if (num1 < (num2 + num3) && (num2 < (num1 + num3)) && (num3 < (num1 + num2)))
// {
//     Console.WriteLine("Такой треугольник существует");
// }
// else if ((num1 <= 0) || (num2 <= 0) || (num3 <= 0))
// {
//     Console.WriteLine("Некорректный ввод");
// }
// else
// {
//     Console.WriteLine("Такой треугольник не существует");
// }













// : Напишите программу, которая будет преобразовывать
//  десятичное число в двоичное.
// 45 -> 101101
// 3  -> 11
// 2  -> 10

// Console.WriteLine("Введите число");
// int num = Convert.ToInt32(Console.ReadLine());

// string result = "";

// while (num > 0)
// {
//     result = num % 2 + result;
//     num = num / 2;
// }
// Console.WriteLine(result);










// // Задача 44: Не используя рекурсию, выведите первые N чисел Фибоначчи. Первые два числа Фибоначчи: 0 и 1.
// // Если N = 5 -> 0 1 1 2 3
// // Если N = 3 -> 0 1 1
// // Если N = 7 -> 0 1 1 2 3 5 8

// Console.WriteLine("Введите число больше 2");
// int N = Convert.ToInt32(Console.ReadLine());
// int i=2;
// if (N>=i)
// {
//     int[] fib=new int[N];
//     fib[0]=0;
//     fib[1]=1;
//     Console.Write($"{fib[0]} {fib[1] }");//Console.Write("0 1");
// while(i<N) //for(int i=2;i<N;i++)
// {
//     fib[i]=fib[i-1]+fib[i-2];
//     Console.Write($" {fib[i]}");
//     i++;
// }
// }
// else{
//     Console.WriteLine("Некорректный ввод");
// }















// // Задача 39: Напишите программу, которая 
// // перевернёт одномерный массив (последний 
// // элемент будет на первом месте, а первый - на последнем и т.д.)
// // [1 2 3 4 5] -> [5 4 3 2 1]
// // [6 7 3 6] -> [6 3 7 6]

// int[] array = new int[5]{1,2,3,4,5};

// int temp=0;
// for (int i = 0; i < array.Length/2; i++)
// {
//     temp = array[i];
//     array[i]=array[array.Length-1-i];
//     array[array.Length-1-i]=temp;
// }

// Console.WriteLine(String.Join(",",array));













// Задача 41: Пользователь вводит с клавиатуры M чисел. Посчитайте, сколько чисел больше 0 ввёл пользователь.
// 0, 7, 8, -2, -2 -> 2
// 1, -7, 567, 89, 223-> 3

// Console.WriteLine("Введите числа через запятую и нажмите ввод");

// string[] str = Console.ReadLine().Split(new char[] { ',' });

// int[] array = new int[str.Length];

// for (int i = 0; i < str.Length; i++)
// {
//     array[i] = Convert.ToInt32(str[i]);
// }

// int count = 0;

// for (int j = 0; j < str.Length; j++)
// {
//     if (array[j] > 0)
//     {
//         count++;
//     }
// }
// Console.WriteLine("ЧИсло положительных чисел = " + count);








// Задача 43: Напишите программу, которая найдёт точку пересечения двух прямых, заданных уравнениями y = k1 * x + b1, y = k2 * x + b2; значения b1, k1, b2 и k2 задаются пользователем.
// b1 = 2, k1 = 5, b2 = 4, k2 = 9 -> (-0,5; -0,5)

// Console.WriteLine("Введите число b1");
// int b1 = Convert.ToInt32(Console.ReadLine());

// Console.WriteLine("Введите число k1");
// int k1 = Convert.ToInt32(Console.ReadLine());

// Console.WriteLine("Введите число b2");
// int b2 = Convert.ToInt32(Console.ReadLine());

// Console.WriteLine("Введите число k2");
// int k2 = Convert.ToInt32(Console.ReadLine());

// double b1 = 2;
// double k1 = 5;
// double b2 = 4;
// double k2 = 9;

// double x = (b2 - b1) / (k1 - k2);
// double y = k2 * x + b2;

// Console.WriteLine($"({x} ; {y})");














// Задача 46: Задайте двумерный массив размером m×n, 
// заполненный случайными целыми числами.
// m = 3, n = 4.
// 1 4 8 19
// 5 -2 33 -2
// 77 3 8 1

// Console.WriteLine("Введите число");
// int rows = Convert.ToInt32(Console.ReadLine());

// Console.WriteLine("Введите число");
// int columns = Convert.ToInt32(Console.ReadLine());

// int[,] array = new int[rows, columns];

// for (int i = 0; i < array.GetLength(0); i++)
// {
//     for (int j = 0; j < array.GetLength(1); j++)
//     {
//         array[i, j] = new Random().Next(0, 10);
//         Console.Write(array[i, j] + " ");
//     }

//     Console.WriteLine();
// }















// Задача 48: Задайте двумерный массив размера m на n, каждый элемент в массиве находится по формуле: Aₘₙ = m+n. Выведите полученный массив на экран.
// m = 3, n = 4.
// 0 1 2 3
// 1 2 3 4
// 2 3 4 5


// Console.WriteLine("Введите число: ");
// int rows = Convert.ToInt32(Console.ReadLine());
// Console.WriteLine("Введите число: ");
// int collumns = Convert.ToInt32(Console.ReadLine());

// int[,] array = new int[rows,collumns];

// for (int i = 0; i < array.GetLength(0); i++)
// {
//     for (int j = 0; j < array.GetLength(1); j++)
//     {
//         array[i,j] = i + j;
//         Console.Write(array[i,j] + " ");
//     }
//     Console.WriteLine();
// }














// Задача 49: Задайте двумерный массив. Найдите элементы,
//  у которых оба индекса чётные, и замените эти элементы на их квадраты.
// Например, изначально массив
//  выглядел вот так:
// 1 4 7 2
// 5 9 2 3
// 8 4 2 4


// Console.WriteLine("Введите число");
// int rows = Convert.ToInt32(Console.ReadLine());

// Console.WriteLine("Введите число");
// int columns = Convert.ToInt32(Console.ReadLine());

// int[,] array = new int[rows, columns];

// for (int i = 0; i < array.GetLength(0); i++)
// {
//     for (int j = 0; j < array.GetLength(1); j++)
//     {
//         array[i, j] = new Random().Next(0, 10);
//         Console.Write(array[i, j] + " ");
//     }

//     Console.WriteLine();
// }
// Console.WriteLine("______");
// for (int i = 0; i < array.GetLength(0); i++)
// {
//     for (int j = 0; j < array.GetLength(1); j++)
//     {
//         if ((i % 2 == 0) && (j % 2 == 0))
//         {
//             array[i, j] = array[i, j] * array[i, j];
//         }

//         Console.Write(array[i, j] + " ");
//     }

//     Console.WriteLine();
// }













// Задача 51: Задайте двумерный массив. Найдите сумму элементов, находящихся на главной диагонали (с индексами (0,0); (1;1) и т.д.
// Например, задан массив:
// 1 4 7 2
// 5 9 2 3
// 8 4 2 4
// Сумма элементов главной диагонали: 1+9+2 = 12



// Console.WriteLine("Введите число");
// int rows = Convert.ToInt32(Console.ReadLine());

// Console.WriteLine("Введите число");
// int columns = Convert.ToInt32(Console.ReadLine());

// int[,] array = new int[rows, columns];

// for (int i = 0; i < array.GetLength(0); i++)
// {
//     for (int j = 0; j < array.GetLength(1); j++)
//     {
//         array[i, j] = new Random().Next(0, 10);
//         Console.Write(array[i, j] + " ");
//     }

//     Console.WriteLine();
// }
// Console.WriteLine("______");

// int sum = 0;

// for (int i = 0; i < array.GetLength(0); i++)
// {
//     for (int j = 0; j < array.GetLength(1); j++)
//     {
//         if (i == j)
//         {
//             sum = sum + array[i, j];
//         }
//     }
// }

// Console.WriteLine("Сумма " + sum);








// Задача 47. Задайте двумерный массив размером m×n, заполненный случайными вещественными числами.

// m = 3, n = 4.
// 0,5 7 -2 -0,2
// 1 -3,3 8 -9,9
// 8 7,8 -7,1 9


// Console.WriteLine("Введите число m");
// int m = Convert.ToInt32(Console.ReadLine());

// Console.WriteLine("Введите число n");
// int n = Convert.ToInt32(Console.ReadLine());

// double[,] array = new double[m, n];

// for (int i = 0; i < array.GetLength(0); i++)
// {
//     for (int j = 0; j < array.GetLength(1); j++)
//     {
//         array[i, j] = new Random().Next(0, 10);
//         Console.Write(array[i, j] + " ");
//     }
//     Console.WriteLine();
// }







// Задача 50. Напишите программу, которая на вход принимает позиции элемента в двумерном массиве, и возвращает значение этого элемента или же указание, что такого элемента нет.
// Например, задан массив:
// 1 4 7 2
// 5 9 2 3
// 8 4 2 4

// int m = 3;
// int n = 4;

// int[,] array = new int[m, n];

// for (int i = 0; i < array.GetLength(0); i++)
// {
//     for (int j = 0; j < array.GetLength(1); j++)
//     {
//         array[i, j] = new Random().Next(0, 10);
//         Console.Write(array[i, j] + " ");
//     }
//     Console.WriteLine();
// }

// Console.WriteLine("Введите позицию элемента в массиве, укажите в формате 'строки,ряды'");
// string[] str = Console.ReadLine().Split(new char[] {','});
// int x = Convert.ToInt32(str[0]);
// int y = Convert.ToInt32(str[1]);

// if((x >= 0 && x < array.GetLength(0)) && (y >= 0 && y < array.GetLength(1))){
//     Console.WriteLine(array[x, y]);
// }
// else{
//     Console.WriteLine("Такого элемента нет");
// }








// Задача 52. Задайте двумерный массив из целых чисел. Найдите среднее арифметическое элементов в каждом столбце.
// Например, задан массив:
// 1 4 7 2
// 5 9 2 3
// 8 4 2 4
// Среднее арифметическое каждого столбца: 4,6; 5,6; 3,6; 3.

Console.WriteLine("__________"); // Разделитель

int[,] array = { { 1, 4, 7, 2 }, {5, 9, 2, 3}, {8, 4, 2, 4} };

for (int i = 0; i < array.GetLength(0); i++)
{
    for (int j = 0; j < array.GetLength(1); j++)
    {
        // array[i, j] = new Random().Next(0, 10);
        Console.Write(array[i, j] + " ");
    }
    Console.WriteLine();
}
Console.WriteLine("__________"); // Разделитель

for (int j = 0; j < array.GetLength(1); j++)
{
    double mid = 0;
    for (int i = 0; i < array.GetLength(0); i++)
    {
        mid = mid + array[i, j];
    }
    mid = mid / array.GetLength(0);
    Console.Write($"{Math.Round(mid, 1)} ");
}