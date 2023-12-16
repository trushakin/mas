
//Задача 1: Задайте одномерный массив из 10 целых чисел от 1 до 100. Найдите количество элементов массива, значения которых лежат в отрезке [20,90]


// int[] array = new int[10];

// for(int i=0; i<array.Length; i++)
// {
// array[i] = new Random().Next(1,101);
// System.Console.Write(array[i]+ " ");
// }
// int num=0;
// for(int i=0; i<array.Length; i++)
// {
// if(array[i]>19 && array[i]<91 )
// num++;
// }
// System.Console.WriteLine("=>"+" "+num);



//Задача 2: Задайте массив на 10 целых чисел. Напишите программу, которая определяет количество чётных чисел в массиве.

// int[] array = new int[10];

// for(int i=0; i<array.Length; i++)
// {
// array[i] = new Random().Next(1,101);
// System.Console.Write(array[i]+ " ");
// }
// int num=0;
// for(int i=0; i<array.Length; i++)
// {
// if(array[i]%2==0) num++;
// }
// System.Console.WriteLine("=>"+" "+num);


//Задача 3: Задайте массив из вещественных чисел с ненулевой дробной частью. Найдите разницу между максимальным и минимальным элементов массива. 


// double[] array = new double[5];
// for(int i=0;i<array.Length;i++)
// {
// array[i]= new Random().NextDouble()*10;
// Console.Write(array[i].ToString("F2")+" ");
// }

// double  max= array[0];
// double min= array[0];

// for(int i=0;i<array.Length;i++)
// { 
//     if (array[i]>max)
//     {
//     max=array[i];
//     }
   
//     if (array[i]<min)
//     {
//     min=array[i];    
//     } 


// }
// double diff= max-min;
// System.Console.WriteLine("=> "+diff.ToString("F2"));




