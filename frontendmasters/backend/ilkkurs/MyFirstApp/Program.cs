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