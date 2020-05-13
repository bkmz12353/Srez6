using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics.CodeAnalysis;
using System.Linq;
using System.IO;
namespace Srez6
{
    class TestClass<T>
    {
        T[] mass;   
        public TestClass()
        { mass = new T[0];}
        public void adddata(T num)
        {
            T[] tempMass = new T[mass.Length + 1];
            for (int i = 0; i < mass.Length; i++)
            {
                tempMass[i] = mass[i];
            }
            tempMass[mass.Length] = num;
            mass = tempMass;
        }
        public void removedata(T index)
        {
            int tempindex = -999;
            for (int i = 0; i < mass.Length; i++)
            {
                if (mass[i].Equals(index))
                {
                    tempindex = i;
                    break;
                }
            }
            if (tempindex >=0)
            {
                T[] tempmass = new T[mass.Length - 1];
                for (int i = 0, j = 0; i < mass.Length; i++)
                {
                    if (i == tempindex) continue;
                    tempmass[j] = mass[i];
                    j++;
                }
                mass = tempmass;
            }
        }
        public T getelem(int index)
        {
                return mass[index];
        }
        public int Count()
        {
            return mass.Length;
        }
    }
    class Program
    {
        static void Main(string[] args)
        {   TestClass<string> text = new TestClass<string>();
            TestClass<int> nums = new TestClass<int>();
            Console.ForegroundColor = ConsoleColor.Red;
            Console.WriteLine("добавляем 1 2 и 3");
            nums.adddata(1);      //добавляем 1 2 и 3
            nums.adddata(2);
            nums.adddata(3);
            Console.WriteLine("добавляем Hello bad world");
            text.adddata("Hello");   //добавляем Hello bad world
            text.adddata("bad");
            text.adddata("world");
            Console.WriteLine("выводим");
            Console.ResetColor();
            Console.ForegroundColor = ConsoleColor.Green;
            Console.WriteLine("----------------------------------------------------------------------------------------");
            for (int i = 0; i < text.Count(); i++)
            {
                Console.Write(text.getelem(i) + "  ");
            }
            Console.WriteLine();
            for (int i = 0; i < nums.Count(); i++)
            {
                Console.Write(nums.getelem(i) + "  ");
            }
            Console.WriteLine();
            Console.ResetColor();
            Console.ForegroundColor = ConsoleColor.Green;
            Console.WriteLine("----------------------------------------------------------------------------------------");
            Console.ForegroundColor = ConsoleColor.Red;
            Console.WriteLine("удаляем bad world и добавляем cool world");
            text.removedata("bad");            //удаляем bad world и добавляем cool world
            text.removedata("world");
            text.adddata("cool");
            text.adddata("world");
            Console.WriteLine("удаляем 3 и добавляем 4");
            nums.removedata(3);             //удаляем 3 и добавляем 4
            nums.adddata(4);
            Console.ResetColor();
            Console.ForegroundColor = ConsoleColor.Green;
            Console.WriteLine("----------------------------------------------------------------------------------------");
            for (int i = 0; i < text.Count(); i++)
            {
                Console.Write(text.getelem(i) + "  ");
            }
            Console.WriteLine();
            for (int i = 0; i < nums.Count(); i++)
            {
                Console.Write(nums.getelem(i)+ "  ");
            }
            Console.WriteLine();
            Console.ForegroundColor = ConsoleColor.Green;
            Console.WriteLine("----------------------------------------------------------------------------------------");
            Console.ForegroundColor = ConsoleColor.Red;
            Console.WriteLine("Получаем элемент по индексу");
            Console.WriteLine("Получаем элемент по индексу");
            Console.ResetColor();
            Console.ForegroundColor = ConsoleColor.Green;
            Console.WriteLine("----------------------------------------------------------------------------------------");
            int index = 1;      //индекс вызыввемого элемента
            Console.WriteLine(nums.getelem(index));
            Console.WriteLine(text.getelem(index));
            Console.ForegroundColor = ConsoleColor.Green;
            Console.WriteLine("----------------------------------------------------------------------------------------");
            Console.ResetColor();
        }

    }
}
