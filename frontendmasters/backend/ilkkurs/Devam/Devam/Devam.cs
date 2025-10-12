internal class Devam
{

    public static void PatternMatching()
    {
        //yeni yöntem:
        object value = "Hello, World!";
        if (value is string str)
        {
            Console.WriteLine($"The value is a string: {str}");
        }
        else
        {
            Console.WriteLine("The value is not a string.");
        }

        //eski yöntem:
        if (value.GetType() == typeof(string)) // 1. Adım: Tipi kontrol et
        {
            // 2. Adım: Değişkeni string tipine dönüştür (cast et)
            string str2 = (string)value;

            Console.WriteLine($"The value is a string: {str2}");
        }
        else
        {
            Console.WriteLine("The value is not a string.");
        }

        //yeni devam:
        if (value is string str3 && str3.Length > 5)
        {
            Console.WriteLine("The string is longer than 5 characters.");
        }
        else
        {
            Console.WriteLine("The string is not longer than 5 characters.");
        }
    }
}