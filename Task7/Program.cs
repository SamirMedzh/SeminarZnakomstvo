﻿using static System.Console;

int number = new Random().Next(100,1000);
WriteLine(number);

int first = number/100;
int second = number%10;

Write(first);
WriteLine(second);