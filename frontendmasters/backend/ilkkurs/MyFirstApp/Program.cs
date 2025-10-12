// https://schneidenbach.github.io/intro-to-csharp-and-dotnet-from-beginner-to-professional/

internal class Program
{
    private static void Main(string[] args)
    {
        int sonuc = AddNumbers(1, 2);
        Console.WriteLine(sonuc);
        Console.WriteLine(AddNumbers2(1, 2, 4));
        Console.WriteLine("Hello, World!ss");
        Console.WriteLine(DateTime.UtcNow.AddDays(1));

        DateTime d = DateTime.Parse("12/10/2025");
        Console.WriteLine(d);

        int[] arrayOfIntegers = [1, 2, 3];
        //aşağıdaki de başka bi yöntem
        int[] myIntArray = new int[3];
        myIntArray[0] = 1;
        myIntArray[1] = 2;
        myIntArray[2] = 3;

        var employeeType = EmployeeType.Manager;
        Console.WriteLine(employeeType);

        var personInfo = (Age: 30, Name: "Alice", IsEmployed: true);
        Console.WriteLine(personInfo.Age); // Output: 30
        Console.WriteLine(personInfo.Name); // Output: Alice
        Console.WriteLine(personInfo.IsEmployed); // Output: true

        var person = GetPerson();

        Console.WriteLine(person.Name);

        var (age, name) = GetPerson();
        Console.WriteLine(age + " " + name);

        string myString = "Hello, World!";
        string myVerbatimString = @"He said ""Hello"" to me.";
        string myRawString = """Hello, World!""";
        string name2 = "Alice";
        string greeting = $"Hello, {name2}!";
        string greeting2 = $@"Hello, I say to ""{name2}!""";
        string emptyString = string.Empty; // ""
        bool isNullOrEmpty = String.IsNullOrEmpty("blabla");
        bool isNullOrWhiteSpace = String.IsNullOrWhiteSpace("bla bla"); //yukarıdakiyle tek farkı sadece boşluk varsa "   " gibi onu da true sayıyor
        string str1 = "Hello";
        string str2 = "hello";
        bool areEqual = string.Equals(str1, str2, StringComparison.OrdinalIgnoreCase);
        // == diye kontrol etmek gibi ama standart bu çünkü == ve != karşılaştırma metodunu özelleştirmeye izin vermiyor
        // mesela StringComparison.OrdinalIgnoreCase veya StringComparison.Ordinal kullanmayı öneriyorlar. bunlar string karşılaştırma türleri. Ordinal olanda büyük/küçük harf farklı kabul edilir, ignorecase olanda göz ardı edilir.

        // common methods / properties for strings
        // Length: Get the number of characters in a string.
        // String.Join(): Concatenate elements of an array into a single string.
        // ToLower() / ToUpper(): Convert strings to lowercase or uppercase.
        // Contains(): Check if a string contains a specified substring.
        // StartsWith() / EndsWith(): Determine if a string starts or ends with a specific substring.
        // Trim() / TrimStart() / TrimEnd(): Remove whitespace from the start, end, or both ends of a string.
        // Substring(): Extract a substring from a string.
        // IndexOf() / LastIndexOf(): Find the position of a substring within a string.
        // Replace(): Replace occurrences of a substring with another substring.
        // Split(): Split a string into an array of substrings based on a delimiter.

        if (age >= 18)
        {
            Console.WriteLine("You are an adult.");
        }
        else if (age >= 13)
        {
            Console.WriteLine("You are a teenager.");
        }
        else
        {
            Console.WriteLine("You are a minor.");
        }

        int day = 3;
        switch (day)
        {
            case 1:
                Console.WriteLine("Monday");
                break;
            case 2:
                Console.WriteLine("Tuesday");
                break;
            case 3:
                Console.WriteLine("Wednesday");
                break;
            case 4:
                Console.WriteLine("Thursday");
                break;
            case 5:
                Console.WriteLine("Friday");
                break;
            case 6:
                Console.WriteLine("Saturday");
                break;
            case 7:
                Console.WriteLine("Sunday");
                break;
            default:
                Console.WriteLine("Invalid day.");
                break;
        }
        //farklı yazım
        int day2 = 3;
        string dayName = day2 switch
        {
            1 => "Monday",
            2 => "Tuesday",
            3 => "Wednesday",
            4 => "Thursday",
            5 => "Friday",
            6 => "Saturday",
            7 => "Sunday",
            _ => "Invalid day"
        };
        Console.WriteLine(dayName);
    }

    public static (int Age, string Name) GetPerson()
    {
        return (25, "Bob");
    }



    public static int AddNumbers(int a, int b)
    {
        return a + b;
    }

    public static int AddNumbers2(params int[] integers)
    {
        // return integers.Sum(); (LINQ)
        int total = 0;

        foreach (int number in integers)
        {
            total += number;
        }

        return total;

    }
}

enum EmployeeType
{
    Manager = 2,

    Supervisor = 3,

    Worker = 4
}

// enumlar şu tarzda kullanılır:

// Bir class veya namespace içinde tanımlanır
// public enum Gunler
// {
//     Pazartesi,  // Varsayılan değer: 0
//     Sali,       // Varsayılan değer: 1
//     Carsamba,   // Varsayılan değer: 2
//     Persembe,   // Varsayılan değer: 3
//     Cuma,       // Varsayılan değer: 4
//     Cumartesi,  // Varsayılan değer: 5
//     Pazar       // Varsayılan değer: 6
// }

// Değişken tanımlama ve atama
// Gunler bugun = Gunler.Cuma;
// Gunler yarin = Gunler.Cumartesi;

// Kontrol ve Karşılaştırma
// if (bugun == Gunler.Cuma)
// {
//     Console.WriteLine("Hafta sonuna son gün!");
// }