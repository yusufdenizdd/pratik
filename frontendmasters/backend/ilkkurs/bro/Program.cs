public class Person
{
    public string Name { get; set; }
    public int Age { get; set; }

    public Person(string name, int age)
    {
        if (string.IsNullOrWhiteSpace(name))
        {
            throw new ArgumentException("name cant be null or empty", nameof(name));
        }
        Name = name;
        Age = age;
    }
}

public class Person2
{
    public string Name { get; set; }
    public int Age { get; set; }
}

internal class Program
{
    private static void Main(string[] args)
    {
        var spencer = new Person("spencer", 25);
        var deniz = new Person2
        {
            Name = "deniz",
            Age = 24
        };
    }
}