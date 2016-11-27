using LINQtoCSV;

namespace ConsoleApplication1
{
    class Product
    {
        [CsvColumn(Name = "Id", FieldIndex = 1, CanBeNull = false)]
        public int Id { get; set; }

        [CsvColumn(Name = "Name", FieldIndex = 2)]
        public string Name { get; set; }

        [CsvColumn(Name = "Author", FieldIndex = 3)]
        public string Author { get; set; }

        [CsvColumn(Name = "Stock", FieldIndex = 4)]
        public int Stock { get; set; }

        [CsvColumn(Name = "Price1", FieldIndex = 5, CanBeNull = false, OutputFormat = "C")]
        public decimal Price1 { get; set; }

        [CsvColumn(Name = "Price2", FieldIndex = 6, CanBeNull = false, OutputFormat = "C")]
        public decimal Price2 { get; set; }

        [CsvColumn(Name = "Price3", FieldIndex = 7, CanBeNull = false, OutputFormat = "C")]
        public decimal Price3 { get; set; }

        [CsvColumn(Name = "Region", FieldIndex = 8)]
        public string Region { get; set; }

        [CsvColumn(Name = "Category", FieldIndex = 9)]
        public string Category { get; set; }

        [CsvColumn(Name = "Percentage", FieldIndex = 10)]
        public decimal Percentage { get; set; }
    }
}
