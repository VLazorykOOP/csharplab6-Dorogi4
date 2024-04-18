/*using System;

// Базовий клас Document
public abstract class Document
{
    public string Number { get; set; }
    public DateTime Date { get; set; }

    // Віртуальний метод для виведення інформації
    public virtual void PrintInfo()
    {
        Console.WriteLine($"Number: {Number}");
        Console.WriteLine($"Date: {Date}");
    }
}

// Похідний клас Receipt
public class Receipt : Document
{
    public decimal Amount { get; set; }

    // Перевизначення методу PrintInfo для Receipt
    public override void PrintInfo()
    {
        base.PrintInfo();
        Console.WriteLine($"Amount: {Amount}");
    }
}

// Похідний клас Invoice
public class Invoice : Document
{
    public string CustomerName { get; set; }

    // Перевизначення методу PrintInfo для Invoice
    public override void PrintInfo()
    {
        base.PrintInfo();
        Console.WriteLine($"Customer Name: {CustomerName}");
    }
}

// Похідний клас Bill
public class Bill : Document
{
    public string Recipient { get; set; }

    // Перевизначення методу PrintInfo для Bill
    public override void PrintInfo()
    {
        base.PrintInfo();
        Console.WriteLine($"Recipient: {Recipient}");
    }
}

class Program
{
    static void Main(string[] args)
    {
        // Створення об'єктів кожного класу
        Document doc1 = new Receipt { Number = "R001", Date = DateTime.Now, Amount = 100.50m };
        Document doc2 = new Invoice { Number = "INV001", Date = DateTime.Now, CustomerName = "John Doe" };
        Document doc3 = new Bill { Number = "B001", Date = DateTime.Now, Recipient = "Company XYZ" };

        // Тестування виведення інформації про кожен документ
        PrintDocumentInfo(doc1);
        PrintDocumentInfo(doc2);
        PrintDocumentInfo(doc3);
    }

    // Метод для виведення інформації про документ
    static void PrintDocumentInfo(Document doc)
    {
        Console.WriteLine("\nDocument Information:");
        doc.PrintInfo();
    }
}
*/