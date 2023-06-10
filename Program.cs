// Задайте массив заполненный случайными положительными трёхзначными числами.
// Напишите программу, которая покажет количество чётных чисел в массиве.
// [345, 897, 568, 234] -> 2

// int[] array=new int[4];
// int num=0;

// for(int i=0; i<array.Length;i++)
// {
//     array[i]=new Random().Next(100,1000);
//     Console.Write(array[i]+" ");
//     int num2=array[i]%2;
//     if(num2==0)
//     {
//         num=num+1;
//     }
// }
// Console.WriteLine("положительных чисел:" +num);

//_____________________________________________________________________________________________

// Задайте одномерный массив, заполненный случайными числами. 
// Найдите .
// [3, 7, 23, 12] -> 19
// [-4, -6, 89, 6] -> 0
// Console.Write("[");
// int[] array=new int[8];
// for(int i=0; i<array.Length;i++)

// {
//     array[i]=new Random().Next(1,10);
//     Console.Write(array[i]+" ");
// }
// Console.Write("]");
// Console.WriteLine();
// int sum=0;
// for(int i=1; i<array.Length;i=i+2)
// {
//     sum=sum+array[i];
// }
// Console.Write("сумма элементов, стоящих на нечётных позициях:"+sum);

//_________________________________________________________________________________________________

// Задайте массив вещественных чисел. Найдите разницу между 
// максимальным и минимальным элементов массива.
// [3.22, 4.2, 1.15, 77.15, 65.2] => 77.15 - 1.15 = 76

// int[] array=new int[4];
// for(int i=0; i<array.Length;i++)

// {
//     array[i]=new Random().Next(1,10);
//     Console.Write(array[i]+" ");
// }
// Console.WriteLine();
// int minind=0;
// int maxind=0;
// for(int i=0; i<array.Length;i++)
// {
//     if(array[i]>maxind)
//     {
//         maxind=array[i];
        
//     }
//     else
//     {
//         minind=array[i];
//     }
   
// }

// Console.Write(maxind-minind);
