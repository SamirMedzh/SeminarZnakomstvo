﻿using static System.Console;

WriteLine("Введите число 3х значное число ");
int a = Convert.ToInt32(ReadLine());

int first = a/10;
int second = first%10;
//int b = (second - first)/ 10;
//WriteLine(b);
WriteLine(second);
