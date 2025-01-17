﻿using System;
using System.IO;
using System.Runtime.Serialization.Formatters.Binary;

namespace Assignment_7_4
{
    class Program
    {
        static void Main(string[] args)
        {
            string path = @"C:\Users\BSUDHIRT\CsharpBasic\Assignment 7\text\Text.txt";
            Employee emp = new Employee(123, "bhakti", 40000);
            FileStream stream = new FileStream(path, FileMode.OpenOrCreate);
            BinaryFormatter bf =new BinaryFormatter();


            bf.Serialize(stream, emp);
            stream.Close();
            Console.WriteLine(" File created successfully -> " + path);
          

            FileStream stream1 = new FileStream(path, FileMode.Open, FileAccess.Read);
            Employee objnew = (Employee)bf.Deserialize(stream1);

            Console.WriteLine(objnew.id);
            Console.WriteLine(objnew.name);
            Console.WriteLine(objnew.salary);

        }
    }
}
