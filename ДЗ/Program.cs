﻿
//Задача 1: Задайте одномерный массив из 10 целых чисел от 1 до 100. Найдите количество элементов массива, значения которых лежат в отрезке [20,90]


// int[] array = new int [10];
//  array[i] = new Random().Next(1,101); 
//  System.Console.Write(array[i]+"");

//  for (int i=0; i<array.Length; i++)

int[] array = new int[10];

for(int i=0; i<array.Length; i++)
{
array[i] = new Random().Next(1,101);
System.Console.Write(array[i]+ " ");
}
int num=0;
for(int i=0; i<array.Length; i++)
{
if(array[i]>19 && array[i]<91 )
num++;
}
System.Console.WriteLine("=>"+"\t"+num);