internal class Program
{
    private static void Main(string[] args)
    {
        try
        {
            DateTime.Parse("asdf");
            string name = "alice";
            if (name != "spencer")
            {
                throw new ArgumentNullException("you are not spencer");
            }
        }
        catch (ArgumentNullException ex)
        {
            Console.WriteLine(ex);

            Console.WriteLine("Something went wrong!");
        }
        catch (FormatException ex)
        {
            Console.WriteLine(ex);
            Console.WriteLine("something");
        }
        finally
        {
            Console.WriteLine("finally");
        }


        try
        {
            // Code that may throw an exception
        }
        catch (Exception ex) when (ex.Message.Contains("specific condition"))
        {
            Console.WriteLine(ex);
            // Handle exceptions that meet the condition
        }
    }

    public static void DoSomeProcessing(string criticalValue)
    {
        if (string.IsNullOrWhiteSpace(criticalValue))
        {
            throw new ArgumentException("Input cannot be null or empty", nameof(criticalValue));
        }
    }
}