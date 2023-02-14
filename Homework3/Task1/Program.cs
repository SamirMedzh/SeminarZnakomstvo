// Напишите программу, которая принимает на вход 5значное число
// и проверяет, является ли оно палиндромом ( одинаково справо нлево, и слева напрво)

using static System.Console;

Write("Введите пятизначное число ");
int a = int.Parse(ReadLine()!);

int first_number = a/10000; //первое число
int first_2numbers = a/1000;
int last_number = a%10;     //пятое число
int last_2number = a%100;

int numb = first_2numbers % 5; //здесь получили вторую цифру, если 12345 то 2
int numb2 = last_2number / 10;  //здесь получили четвертую цифру

if (a>= 10000 && a <= 99999)

WriteLine(first_number == last_number && numb == numb2? "Да" : 
  "Нет");

else Write("Введено не пятизначное число");

//  WriteLine($"{numb2}");