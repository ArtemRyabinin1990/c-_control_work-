﻿// See https://aka.ms/new-console-template for more information
using System.Globalization;
using System.Runtime.CompilerServices;

// функции
void printArray(string[] array)
{
    int length = array.Length;

    Console.Write("[");
    for (int i = 0; i < length; i++)
    {
        if (i < length - 1)
        {
            Console.Write("\"" + array[i] + "\", ");
        }
        else
        {
            Console.Write("\"" + array[i] + "\"");
        }
    }
    Console.WriteLine("]");
}

int getCountStr(string[] array, int searchCountStr)
{
    int length = array.Length;
    int count = 0;
    for (int i = 0; i < length; i++)
    {
        if (array[i].Length <= searchCountStr)
        {
            count++;
        }
    }
    return count;
}

string[] getNewArray(string[] array, int searchCountStr)
{
    int length = array.Length;
    int countStr = getCountStr(array, searchCountStr);
    string[] newArray = new string[countStr];
    int j = 0;

    for (int i = 0; i < length; i++)
    {
       if (array[i].Length <= searchCountStr)
       {
           newArray[j] = array[i];
           j++;
       }
    }

    return newArray;
}

int searchCountStr = 3;
Console.WriteLine("Задайте массив через пробел: ");
string str = Console.ReadLine();
string[] userArray = str.Split(' ');
string[] newArray = getNewArray(userArray, searchCountStr);
printArray(newArray);