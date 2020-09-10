using System;
using System.Globalization;
using System.IO;
using System.Linq;

using CsvHelper;

namespace NugetDemoAndCSV
{
    struct BookEntry
    {
        string bookTitle;
        string author;
        string isbn;

        public string BookTitle { get => bookTitle; set => bookTitle = value; }
        public string Author { get => author; set => author = value; }
        public string Isbn { get => isbn; set => isbn = value; }
    }

    class Program
    {
        static void Main(string[] args)
        {
            BookEntry[] myShelf;
            using (var reader = new StreamReader("example.csv"))
            {
                using (var csv = new CsvReader(reader, CultureInfo.InvariantCulture))
                {
                    System.Collections.Generic.IEnumerable<BookEntry> records = csv.GetRecords<BookEntry>();
                    myShelf = records.ToArray<BookEntry>();
                }
            }

            foreach(BookEntry tmpBE in myShelf)
            {
                Console.WriteLine(tmpBE.BookTitle);
            }



            Console.WriteLine("Hello World!");
        }
    }
}
