using Newtonsoft.Json.Linq;
using System;
using System.Text.RegularExpressions;
namespace JSONHandling;

public class JsonEmailValidator
{
    public static void ValidateEmail()
    {
        string json = @"{ 'email':'test@gmail.com' }";
        JObject obj = JObject.Parse(json);

        string email = obj["email"]?.ToString();
        bool isValid = Regex.IsMatch(email,
            @"^[^@\s]+@[^@\s]+\.[^@\s]+$");

        Console.WriteLine("\nEmail Validation: " +
            (isValid ? "Valid" : "Invalid"));
    }
}
