﻿using System;
using EFCoreWebDemo;

namespace first_ef_project
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
            var context = new EFCoreDemoContext();
            DatabaseOperation dbo = new DatabaseOperation();
            dbo.insertDataIntoDb(context);
            dbo.findDatafromDb("Rabindranath");

            

        }
    }
}
