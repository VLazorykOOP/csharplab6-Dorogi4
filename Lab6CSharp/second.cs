/*using System;

// Інтерфейс програмного забезпечення
public interface Software
{
    // Метод для виведення інформації про програмне забезпечення
    void DisplayInfo();

    // Метод для визначення можливості використання на поточну дату
    bool CanUse();
}

// Похідний клас Вільне програмне забезпечення
public class FreeSoftware : Software
{
    public string Name { get; set; }
    public string Manufacturer { get; set; }

    // Реалізація методу для виведення інформації про програмне забезпечення
    public void DisplayInfo()
    {
        Console.WriteLine($"Software Name: {Name}");
        Console.WriteLine($"Manufacturer: {Manufacturer}");
    }

    // Реалізація методу для визначення можливості використання на поточну дату
    public bool CanUse()
    {
        return true; // Вільне ПЗ завжди можна використовувати
    }
}

// Похідний клас Умовно-безкоштовне програмне забезпечення
public class TrialSoftware : Software
{
    public string Name { get; set; }
    public string Manufacturer { get; set; }
    public DateTime InstallationDate { get; set; }
    public int TrialPeriodDays { get; set; }

    // Реалізація методу для виведення інформації про програмне забезпечення
    public void DisplayInfo()
    {
        Console.WriteLine($"Software Name: {Name}");
        Console.WriteLine($"Manufacturer: {Manufacturer}");
        Console.WriteLine($"Installation Date: {InstallationDate.ToShortDateString()}");
        Console.WriteLine($"Trial Period (days): {TrialPeriodDays}");
    }

    // Реалізація методу для визначення можливості використання на поточну дату
    public bool CanUse()
    {
        // Перевіряємо, чи не минув термін пробного періоду
        TimeSpan trialPeriod = DateTime.Now - InstallationDate;
        return trialPeriod.Days <= TrialPeriodDays;
    }
}

// Похідний клас Комерційне програмне забезпечення
public class CommercialSoftware : Software
{
    public string Name { get; set; }
    public string Manufacturer { get; set; }
    public decimal Price { get; set; }
    public DateTime InstallationDate { get; set; }
    public int ValidityPeriodDays { get; set; }

    // Реалізація методу для виведення інформації про програмне забезпечення
    public void DisplayInfo()
    {
        Console.WriteLine($"Software Name: {Name}");
        Console.WriteLine($"Manufacturer: {Manufacturer}");
        Console.WriteLine($"Price: {Price:C}");
        Console.WriteLine($"Installation Date: {InstallationDate.ToShortDateString()}");
        Console.WriteLine($"Validity Period (days): {ValidityPeriodDays}");
    }

    // Реалізація методу для визначення можливості використання на поточну дату
    public bool CanUse()
    {
        // Перевіряємо, чи не минув термін дії ліцензії
        TimeSpan validityPeriod = DateTime.Now - InstallationDate;
        return validityPeriod.Days <= ValidityPeriodDays;
    }
}

class Program
{
    static void Main(string[] args)
    {
        // Створення масиву з програмним забезпеченням
        Software[] software = new Software[]
        {
            new FreeSoftware { Name = "OpenOffice", Manufacturer = "Apache" },
            new TrialSoftware { Name = "Adobe Photoshop", Manufacturer = "Adobe", InstallationDate = DateTime.Now.AddDays(-20), TrialPeriodDays = 30 },
            new CommercialSoftware { Name = "Microsoft Office", Manufacturer = "Microsoft", Price = 199.99m, InstallationDate = DateTime.Now.AddDays(-10), ValidityPeriodDays = 365 }
        };

        // Виведення інформації про кожне програмне забезпечення
        foreach (var s in software)
        {
            Console.WriteLine("\n------------------------");
            s.DisplayInfo();
            Console.WriteLine($"Can use: {s.CanUse()}");
            Console.WriteLine("------------------------");
        }

        // Пошук програмного забезпечення, яке можна використовувати на поточну дату
        Console.WriteLine("\nSoftware available for current date:");
        foreach (var s in software)
        {
            if (s.CanUse())
            {
                Console.WriteLine("\n------------------------");
                s.DisplayInfo();
                Console.WriteLine("------------------------");
            }
        }
    }
}
*/