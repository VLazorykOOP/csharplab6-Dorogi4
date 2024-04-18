using System;
using System.Collections;
using System.Collections.Generic;

abstract class Software : IEnumerable<Software>
{
    protected string name;
    protected string manufacturer;

    public Software(string name, string manufacturer)
    {
        this.name = name;
        this.manufacturer = manufacturer;
    }

    public abstract void DisplayInformation();
    public abstract bool CanUse(DateTime currentDate);

    public IEnumerator<Software> GetEnumerator()
    {
        yield return this;
    }

    IEnumerator IEnumerable.GetEnumerator()
    {
        return GetEnumerator();
    }
}

class Free : Software
{
    public Free(string name, string manufacturer) : base(name, manufacturer) { }

    public override void DisplayInformation()
    {
        Console.WriteLine($"Type: Free\nName: {name}\nManufacturer: {manufacturer}\n");
    }

    public override bool CanUse(DateTime currentDate)
    {
        // Free software can always be used
        return true;
    }
}

class Trial : Software
{
    protected DateTime installationDate;
    protected int trialDuration; // in days

    public Trial(string name, string manufacturer, DateTime installationDate, int trialDuration)
        : base(name, manufacturer)
    {
        this.installationDate = installationDate;
        this.trialDuration = trialDuration;
    }

    public override void DisplayInformation()
    {
        Console.WriteLine($"Type: Trial\nName: {name}\nManufacturer: {manufacturer}\nInstallation Date: {installationDate.ToShortDateString()}\nTrial Duration: {trialDuration} days\n");
    }

    public override bool CanUse(DateTime currentDate)
    {
        // Check if trial duration has not expired
        return currentDate <= installationDate.AddDays(trialDuration);
    }
}

class Commercial : Software
{
    protected DateTime installationDate;
    protected int usageDuration; // in days

    public Commercial(string name, string manufacturer, DateTime installationDate, int usageDuration)
        : base(name, manufacturer)
    {
        this.installationDate = installationDate;
        this.usageDuration = usageDuration;
    }

    public override void DisplayInformation()
    {
        Console.WriteLine($"Type: Commercial\nName: {name}\nManufacturer: {manufacturer}\nInstallation Date: {installationDate.ToShortDateString()}\nUsage Duration: {usageDuration} days\n");
    }

    public override bool CanUse(DateTime currentDate)
    {
        // Check if usage duration has not expired
        return currentDate <= installationDate.AddDays(usageDuration);
    }
}

class Program
{
    static void Main(string[] args)
    {
        Software[] database = new Software[]
        {
            new Free("Notepad++", "Notepad++ Team"),
            new Trial("Microsoft Office", "Microsoft", new DateTime(2023, 1, 1), 365),
            new Commercial("Adobe Photoshop", "Adobe", new DateTime(2022, 6, 1), 365),
        };

        Console.WriteLine("Information about software in the database:\n");
        foreach (var software in database)
        {
            software.DisplayInformation();
        }

        DateTime currentDate = DateTime.Now;
        Console.WriteLine("Software that can be used on the current date:\n");
        foreach (var software in database)
        {
            if (software.CanUse(currentDate))
            {
                software.DisplayInformation();
            }
        }

        Console.ReadLine();
    }
}
