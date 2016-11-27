using System;
using System.Collections.Generic;
using LINQtoCSV;
using System.Linq;

namespace ConsoleApplication1
{
    class Program
    {
        static void Main(string[] args)
        {
            var filepath = @"C:\Users\Darren\Downloads\SampleCSVFile_119kb.csv";

            CsvFileDescription inputFileDescription = new CsvFileDescription
            {
                SeparatorChar = ',',
                UseFieldIndexForReadingData = true,
                IgnoreUnknownColumns = true,
                EnforceCsvColumnAttribute = false
            };

            CsvContext cc = new CsvContext();

            IEnumerable<Product> products = cc.Read<Product>(filepath, inputFileDescription);

            var productsByName = products
                .Where(p => p.Id < 100)
                .Take(5);

            //added a comment
            foreach (var product in productsByName)
            {
                Console.WriteLine($"ID: {product.Id} : Name: {product.Name} : Price: {product.Price1}");
            }
            Console.ReadLine();
        }
    }
}
